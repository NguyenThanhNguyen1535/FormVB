Imports Microsoft.Data.SqlClient
Imports System.Data
Imports System.Globalization
Imports System.Windows.Forms

Public Class FormLoaiThe
    Private selectedLTId As Integer = -1

    Private Sub FormLoaiThe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboLTNhaMang.SelectedIndex = 0
        LoadLoaiTheGrid()
    End Sub

    Public Sub LoadLoaiTheGrid(Optional searchQuery As String = "")
        Try
            Dim sql As String = "SELECT MaLoai AS [Mã Loại], TenNhaMang AS [Tên Nhà Mạng], MenhGia AS [Mệnh Giá] FROM LoaiThe"
            Dim dt As DataTable
            If String.IsNullOrEmpty(searchQuery) Then
                dt = SQLDatabase.GetData(sql & " ORDER BY MaLoai DESC")
            Else
                sql &= " WHERE TenNhaMang LIKE @Query ORDER BY MaLoai DESC"
                dt = SQLDatabase.GetData(sql, New SqlParameter("@Query", "%" & searchQuery & "%"))
            End If
            dgvLoaiThe.DataSource = dt
            FormatGridCurrency(dgvLoaiThe, "Mệnh Giá")
            dgvLoaiThe.AutoResizeColumns()
        Catch ex As Exception
            MessageBox.Show("Lỗi tải danh mục loại thẻ: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtLTSearch_TextChanged(sender As Object, e As EventArgs) Handles txtLTSearch.TextChanged
        LoadLoaiTheGrid(txtLTSearch.Text.Trim())
    End Sub

    Private Sub dgvLoaiThe_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLoaiThe.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvLoaiThe.Rows(e.RowIndex)
            selectedLTId = Convert.ToInt32(row.Cells("Mã Loại").Value)
            cboLTNhaMang.SelectedItem = row.Cells("Tên Nhà Mạng").Value.ToString()
            numLTMenhGia.Value = Convert.ToDecimal(row.Cells("Mệnh Giá").Value)
        End If
    End Sub

    Private Sub btnLTClear_Click(sender As Object, e As EventArgs) Handles btnLTClear.Click
        ClearLTFields()
    End Sub

    Private Sub ClearLTFields()
        selectedLTId = -1
        cboLTNhaMang.SelectedIndex = 0
        numLTMenhGia.Value = 0
        txtLTSearch.Clear()
        LoadLoaiTheGrid()
    End Sub

    ' CRUD - Insert Card Type
    Private Sub btnLTAdd_Click(sender As Object, e As EventArgs) Handles btnLTAdd.Click
        Dim nhaMang As String = cboLTNhaMang.SelectedItem.ToString()
        Dim menhGia As Double = Convert.ToDouble(numLTMenhGia.Value)

        If menhGia <= 0 Then
            MessageBox.Show("Mệnh giá thẻ phải lớn hơn 0 ₫!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim checkSql As String = "SELECT COUNT(*) FROM LoaiThe WHERE TenNhaMang = @Carrier AND MenhGia = @Value"
            Dim count As Integer = Convert.ToInt32(SQLDatabase.ExecuteScalar(checkSql,
                New SqlParameter("@Carrier", nhaMang),
                New SqlParameter("@Value", menhGia)
            ))
            If count > 0 Then
                MessageBox.Show("Mệnh giá của nhà mạng này đã tồn tại trong danh mục!", "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim sql As String = "INSERT INTO LoaiThe (TenNhaMang, MenhGia) VALUES (@Carrier, @Value)"
            SQLDatabase.Execute(sql,
                New SqlParameter("@Carrier", nhaMang),
                New SqlParameter("@Value", menhGia)
            )

            MessageBox.Show("Thêm loại thẻ mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearLTFields()
            LoadLoaiTheGrid()
        Catch ex As Exception
            MessageBox.Show("Lỗi thêm loại thẻ: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' CRUD - Update Card Type
    Private Sub btnLTEdit_Click(sender As Object, e As EventArgs) Handles btnLTEdit.Click
        If selectedLTId = -1 Then
            MessageBox.Show("Vui lòng chọn loại thẻ từ danh sách để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim nhaMang As String = cboLTNhaMang.SelectedItem.ToString()
        Dim menhGia As Double = Convert.ToDouble(numLTMenhGia.Value)

        If menhGia <= 0 Then
            MessageBox.Show("Mệnh giá thẻ phải lớn hơn 0 ₫!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim checkSql As String = "SELECT COUNT(*) FROM LoaiThe WHERE TenNhaMang = @Carrier AND MenhGia = @Value AND MaLoai <> @MaLoai"
            Dim count As Integer = Convert.ToInt32(SQLDatabase.ExecuteScalar(checkSql,
                New SqlParameter("@Carrier", nhaMang),
                New SqlParameter("@Value", menhGia),
                New SqlParameter("@MaLoai", selectedLTId)
            ))
            If count > 0 Then
                MessageBox.Show("Nhà mạng đã có mệnh giá thẻ này rồi!", "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim sql As String = "UPDATE LoaiThe SET TenNhaMang = @Carrier, MenhGia = @Value WHERE MaLoai = @MaLoai"
            SQLDatabase.Execute(sql,
                New SqlParameter("@Carrier", nhaMang),
                New SqlParameter("@Value", menhGia),
                New SqlParameter("@MaLoai", selectedLTId)
            )

            MessageBox.Show("Cập nhật loại thẻ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearLTFields()
            LoadLoaiTheGrid()
        Catch ex As Exception
            MessageBox.Show("Lỗi sửa loại thẻ: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' CRUD - Delete Card Type
    Private Sub btnLTDelete_Click(sender As Object, e As EventArgs) Handles btnLTDelete.Click
        If selectedLTId = -1 Then
            MessageBox.Show("Vui lòng chọn loại thẻ từ bảng để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirmResult = MessageBox.Show("Bạn chắc chắn muốn xóa loại thẻ này? Các giao dịch mua loại thẻ này cũng sẽ bị xóa theo!", "Xác nhận xóa thẻ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.Yes Then
            Try
                Dim sql As String = "DELETE FROM LoaiThe WHERE MaLoai = @MaLoai"
                SQLDatabase.Execute(sql, New SqlParameter("@MaLoai", selectedLTId))
                MessageBox.Show("Đã xóa loại thẻ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearLTFields()
                LoadLoaiTheGrid()
            Catch ex As Exception
                MessageBox.Show("Lỗi xóa loại thẻ: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub FormatGridCurrency(dgv As DataGridView, columnName As String)
        If dgv.Columns.Contains(columnName) Then
            dgv.Columns(columnName).DefaultCellStyle.Format = "C0"
            dgv.Columns(columnName).DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vi-VN")
        End If
    End Sub

    Private Sub lblHeaderDesc_Click(sender As Object, e As EventArgs)

    End Sub
End Class
