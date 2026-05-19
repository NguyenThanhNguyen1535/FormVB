Imports Microsoft.Data.SqlClient
Imports System.Data
Imports System.Globalization
Imports System.Windows.Forms

Public Class FormKhachHang
    Private selectedKHId As Integer = -1

    Private Sub FormKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKhachHangGrid()
    End Sub

    Public Sub LoadKhachHangGrid(Optional searchQuery As String = "")
        Try
            Dim sql As String = "SELECT MaKH AS [Mã KH], HoTen AS [Họ Tên], SoDienThoai AS [Số Điện Thoại], SoDu AS [Số Dư] FROM KhachHang"
            Dim dt As DataTable
            If String.IsNullOrEmpty(searchQuery) Then
                dt = SQLDatabase.GetData(sql & " ORDER BY MaKH DESC")
            Else
                sql &= " WHERE HoTen LIKE @Query OR SoDienThoai LIKE @Query ORDER BY MaKH DESC"
                dt = SQLDatabase.GetData(sql, New SqlParameter("@Query", "%" & searchQuery & "%"))
            End If
            dgvKhachHang.DataSource = dt
            FormatGridCurrency(dgvKhachHang, "Số Dư")
            dgvKhachHang.AutoResizeColumns()
        Catch ex As Exception
            MessageBox.Show("Lỗi tải danh sách khách hàng: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtKHSearch_TextChanged(sender As Object, e As EventArgs) Handles txtKHSearch.TextChanged
        LoadKhachHangGrid(txtKHSearch.Text.Trim())
    End Sub

    Private Sub dgvKhachHang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKhachHang.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvKhachHang.Rows(e.RowIndex)
            selectedKHId = Convert.ToInt32(row.Cells("Mã KH").Value)
            txtKHHoTen.Text = row.Cells("Họ Tên").Value.ToString()
            txtKHPhone.Text = row.Cells("Số Điện Thoại").Value.ToString()
            numKHSoDu.Value = Convert.ToDecimal(row.Cells("Số Dư").Value)
        End If
    End Sub

    Private Sub btnKHClear_Click(sender As Object, e As EventArgs) Handles btnKHClear.Click
        ClearKHFields()
    End Sub

    Private Sub ClearKHFields()
        selectedKHId = -1
        txtKHHoTen.Clear()
        txtKHPhone.Clear()
        numKHSoDu.Value = 0
        txtKHSearch.Clear()
        LoadKhachHangGrid()
    End Sub

    ' CRUD - Insert Customer
    Private Sub btnKHAdd_Click(sender As Object, e As EventArgs) Handles btnKHAdd.Click
        Dim hoTen As String = txtKHHoTen.Text.Trim()
        Dim phone As String = txtKHPhone.Text.Trim()
        Dim soDu As Double = Convert.ToDouble(numKHSoDu.Value)

        If String.IsNullOrEmpty(hoTen) OrElse String.IsNullOrEmpty(phone) Then
            MessageBox.Show("Vui lòng điền đầy đủ Họ tên và Số điện thoại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim checkSql As String = "SELECT COUNT(*) FROM KhachHang WHERE SoDienThoai = @Phone"
            Dim count As Integer = Convert.ToInt32(SQLDatabase.ExecuteScalar(checkSql, New SqlParameter("@Phone", phone)))
            If count > 0 Then
                MessageBox.Show("Số điện thoại này đã tồn tại trong hệ thống!", "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim sql As String = "INSERT INTO KhachHang (HoTen, SoDienThoai, SoDu) VALUES (@HoTen, @Phone, @SoDu)"
            SQLDatabase.Execute(sql,
                New SqlParameter("@HoTen", hoTen),
                New SqlParameter("@Phone", phone),
                New SqlParameter("@SoDu", soDu)
            )

            MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearKHFields()
            
            ' Refresh parent form if needed or refresh local
            LoadKhachHangGrid()
        Catch ex As Exception
            MessageBox.Show("Lỗi thêm khách hàng: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' CRUD - Update Customer
    Private Sub btnKHEdit_Click(sender As Object, e As EventArgs) Handles btnKHEdit.Click
        If selectedKHId = -1 Then
            MessageBox.Show("Vui lòng chọn một khách hàng từ danh sách trước!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim hoTen As String = txtKHHoTen.Text.Trim()
        Dim phone As String = txtKHPhone.Text.Trim()
        Dim soDu As Double = Convert.ToDouble(numKHSoDu.Value)

        If String.IsNullOrEmpty(hoTen) OrElse String.IsNullOrEmpty(phone) Then
            MessageBox.Show("Họ tên và Số điện thoại không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim checkSql As String = "SELECT COUNT(*) FROM KhachHang WHERE SoDienThoai = @Phone AND MaKH <> @MaKH"
            Dim count As Integer = Convert.ToInt32(SQLDatabase.ExecuteScalar(checkSql,
                New SqlParameter("@Phone", phone),
                New SqlParameter("@MaKH", selectedKHId)
            ))
            If count > 0 Then
                MessageBox.Show("Số điện thoại này đã được sử dụng bởi khách hàng khác!", "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim sql As String = "UPDATE KhachHang SET HoTen = @HoTen, SoDienThoai = @Phone, SoDu = @SoDu WHERE MaKH = @MaKH"
            SQLDatabase.Execute(sql,
                New SqlParameter("@HoTen", hoTen),
                New SqlParameter("@Phone", phone),
                New SqlParameter("@SoDu", soDu),
                New SqlParameter("@MaKH", selectedKHId)
            )

            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearKHFields()
            LoadKhachHangGrid()
        Catch ex As Exception
            MessageBox.Show("Lỗi cập nhật khách hàng: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' CRUD - Delete Customer
    Private Sub btnKHDelete_Click(sender As Object, e As EventArgs) Handles btnKHDelete.Click
        If selectedKHId = -1 Then
            MessageBox.Show("Vui lòng chọn một khách hàng từ bảng để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirmResult = MessageBox.Show("Bạn có thực sự muốn xóa khách hàng này? Tất cả lịch sử giao dịch liên quan cũng sẽ bị xóa bỏ!", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.Yes Then
            Try
                Dim sql As String = "DELETE FROM KhachHang WHERE MaKH = @MaKH"
                SQLDatabase.Execute(sql, New SqlParameter("@MaKH", selectedKHId))
                MessageBox.Show("Đã xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearKHFields()
                LoadKhachHangGrid()
            Catch ex As Exception
                MessageBox.Show("Lỗi xóa khách hàng: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub FormatGridCurrency(dgv As DataGridView, columnName As String)
        If dgv.Columns.Contains(columnName) Then
            dgv.Columns(columnName).DefaultCellStyle.Format = "C0"
            dgv.Columns(columnName).DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vi-VN")
        End If
    End Sub
End Class
