Imports Microsoft.Data.SqlClient
Imports System.Data
Imports System.Globalization
Imports System.Windows.Forms

Public Class FormGiaoDich
    Private selectedGDId As Integer = -1

    Private Sub FormGiaoDich_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ẩn các điều khiển Số Lượng vì giao dịch nạp đơn lẻ tính theo mệnh giá thẻ
        lblGDSoLuong.Visible = False
        numGDSoLuong.Visible = False
        
        ' Đặt mặc định Mã nhân viên có sẵn trong hệ thống (Seeded 1: Đại lý Admin)
        numGDMaNV.Value = 1

        LoadGDKhachHangCombo()
        LoadGDLoaiTheCombo()
        LoadGiaoDichGrid()
        CalculateGDTotal()
    End Sub

    ' Populate customer dropdown
    Private Sub LoadGDKhachHangCombo()
        Try
            Dim dt As DataTable = SQLDatabase.GetData("SELECT MaKH, HoTen, SoDienThoai, SoDu FROM KhachHang ORDER BY HoTen ASC")
            
            Dim displayList As New List(Of KeyValuePair(Of Integer, String))()
            For Each row As DataRow In dt.Rows
                Dim id As Integer = Convert.ToInt32(row("MaKH"))
                Dim name As String = row("HoTen").ToString()
                Dim phone As String = row("SoDienThoai").ToString()
                Dim balance As Decimal = Convert.ToDecimal(row("SoDu"))
                Dim displayText As String = $"{name} ({phone}) - Dư: {balance.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"))}"
                displayList.Add(New KeyValuePair(Of Integer, String)(id, displayText))
            Next

            cboGDKhachHang.DataSource = Nothing
            If displayList.Count > 0 Then
                cboGDKhachHang.DataSource = New BindingSource(displayList, Nothing)
                cboGDKhachHang.DisplayMember = "Value"
                cboGDKhachHang.ValueMember = "Key"
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi tải danh sách khách hàng vào ComboBox: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Populate card types dropdown
    Private Sub LoadGDLoaiTheCombo()
        Try
            Dim dt As DataTable = SQLDatabase.GetData("SELECT MaLoai, TenNhaMang, MenhGia FROM LoaiThe ORDER BY TenNhaMang ASC, MenhGia ASC")
            
            Dim displayList As New List(Of KeyValuePair(Of Integer, String))()
            For Each row As DataRow In dt.Rows
                Dim id As Integer = Convert.ToInt32(row("MaLoai"))
                Dim carrier As String = row("TenNhaMang").ToString()
                Dim value As Decimal = Convert.ToDecimal(row("MenhGia"))
                Dim displayText As String = $"{carrier} - Mệnh giá: {value.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"))}"
                displayList.Add(New KeyValuePair(Of Integer, String)(id, displayText))
            Next

            cboGDLoaiThe.DataSource = Nothing
            If displayList.Count > 0 Then
                cboGDLoaiThe.DataSource = New BindingSource(displayList, Nothing)
                cboGDLoaiThe.DisplayMember = "Value"
                cboGDLoaiThe.ValueMember = "Key"
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi tải danh mục thẻ nạp vào ComboBox: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Load Transactions Grid
    Public Sub LoadGiaoDichGrid(Optional searchQuery As String = "")
        Try
            Dim sql As String = "
                SELECT gd.MaGD AS [Mã GD], nv.HoTen AS [Nhân Viên], kh.HoTen AS [Khách Hàng], lt.TenNhaMang AS [Nhà Mạng], 
                       lt.MenhGia AS [Tổng Tiền], gd.NgayGD AS [Ngày GD]
                FROM GiaoDich gd
                JOIN NhanVien nv ON gd.MaNV = nv.MaNV
                JOIN KhachHang kh ON gd.MaKH = kh.MaKH
                JOIN LoaiThe lt ON gd.MaLoai = lt.MaLoai"
            Dim dt As DataTable
            If String.IsNullOrEmpty(searchQuery) Then
                dt = SQLDatabase.GetData(sql & " ORDER BY gd.MaGD DESC")
            Else
                sql &= " WHERE kh.HoTen LIKE @Query ORDER BY gd.MaGD DESC"
                dt = SQLDatabase.GetData(sql, New SqlParameter("@Query", "%" & searchQuery & "%"))
            End If
            
            dgvGiaoDich.DataSource = dt
            FormatGridCurrency(dgvGiaoDich, "Tổng Tiền")
            dgvGiaoDich.AutoResizeColumns()
        Catch ex As Exception
            MessageBox.Show("Lỗi tải lịch sử giao dịch: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtGDSearch_TextChanged(sender As Object, e As EventArgs) Handles txtGDSearch.TextChanged
        LoadGiaoDichGrid(txtGDSearch.Text.Trim())
    End Sub

    Private Sub dgvGiaoDich_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGiaoDich.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvGiaoDich.Rows(e.RowIndex)
            selectedGDId = Convert.ToInt32(row.Cells("Mã GD").Value)
        End If
    End Sub

    ' Calculate Total amount
    Private Sub CalculateGDTotal()
        If cboGDLoaiThe.SelectedItem IsNot Nothing Then
            Try
                Dim selectedKvp As KeyValuePair(Of Integer, String) = CType(cboGDLoaiThe.SelectedItem, KeyValuePair(Of Integer, String))
                Dim maLoai As Integer = selectedKvp.Key
                
                Dim valueObj = SQLDatabase.ExecuteScalar("SELECT MenhGia FROM LoaiThe WHERE MaLoai = @MaLoai", New SqlParameter("@MaLoai", maLoai))
                If valueObj IsNot Nothing Then
                    Dim val As Double = Convert.ToDouble(valueObj)
                    lblGDTongTienVal.Text = val.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) & " ₫"
                End If
            Catch
            End Try
        Else
            lblGDTongTienVal.Text = "0 ₫"
        End If
    End Sub

    Private Sub cboGDLoaiThe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGDLoaiThe.SelectedIndexChanged
        CalculateGDTotal()
    End Sub

    Private Sub btnGDReset_Click(sender As Object, e As EventArgs) Handles btnGDReset.Click
        ClearGDFields()
    End Sub

    Private Sub ClearGDFields()
        selectedGDId = -1
        numGDMaNV.Value = 1
        txtGDSearch.Clear()
        LoadGDKhachHangCombo()
        LoadGDLoaiTheCombo()
        LoadGiaoDichGrid()
        CalculateGDTotal()
    End Sub

    ' Execute Transaction (Thực hiện giao dịch & Trừ số dư)
    Private Sub btnGDAdd_Click(sender As Object, e As EventArgs) Handles btnGDAdd.Click
        If cboGDKhachHang.SelectedItem Is Nothing OrElse cboGDLoaiThe.SelectedItem Is Nothing Then
            MessageBox.Show("Vui lòng thiết lập đầy đủ Khách hàng và Loại thẻ cần nạp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim khKvp As KeyValuePair(Of Integer, String) = CType(cboGDKhachHang.SelectedItem, KeyValuePair(Of Integer, String))
        Dim ltKvp As KeyValuePair(Of Integer, String) = CType(cboGDLoaiThe.SelectedItem, KeyValuePair(Of Integer, String))

        Dim maKH As Integer = khKvp.Key
        Dim maLoai As Integer = ltKvp.Key
        Dim maNV As Integer = Convert.ToInt32(numGDMaNV.Value)

        Try
            ' 1. Kiểm tra mã nhân viên có tồn tại trong CSDL hay không
            Dim countNV = Convert.ToInt32(SQLDatabase.ExecuteScalar("SELECT COUNT(*) FROM NhanVien WHERE MaNV = @MaNV", New SqlParameter("@MaNV", maNV)))
            If countNV = 0 Then
                MessageBox.Show("Mã nhân viên này không tồn tại trong hệ thống! Vui lòng nhập mã nhân viên đúng (Ví dụ: 1 hoặc 2).", "Lỗi nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' 2. Lấy thông tin mệnh giá thẻ để kiểm tra
            Dim cardValObj = SQLDatabase.ExecuteScalar("SELECT MenhGia FROM LoaiThe WHERE MaLoai = @MaLoai", New SqlParameter("@MaLoai", maLoai))
            If cardValObj Is Nothing Then Return
            Dim tongTien As Double = Convert.ToDouble(cardValObj)

            ' 3. Kiểm tra số dư hiện tại của khách hàng
            Dim custBalanceObj = SQLDatabase.ExecuteScalar("SELECT SoDu FROM KhachHang WHERE MaKH = @MaKH", New SqlParameter("@MaKH", maKH))
            If custBalanceObj Is Nothing Then Return
            Dim currentBalance As Double = Convert.ToDouble(custBalanceObj)

            ' 4. Xử lý ghi nợ nếu số dư nhỏ hơn mệnh giá thẻ nạp
            If currentBalance < tongTien Then
                Dim debtDiff As Double = tongTien - currentBalance
                Dim confirmMsg As String = $"Khách hàng không đủ tiền trong ví (Còn {currentBalance.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"))})." & vbCrLf &
                                           $"Thiếu hụt: {debtDiff.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"))}." & vbCrLf &
                                           $"Bạn có muốn đồng ý cho khách nạp và ghi nợ tài khoản (số dư âm) không?"
                
                Dim result = MessageBox.Show(confirmMsg, "Xác nhận ghi nợ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result <> DialogResult.Yes Then
                    Return ' Hủy bỏ giao dịch
                End If
            End If

            ' 5. Ghi nhận giao dịch vào bảng GiaoDich
            Dim sqlInsertGD As String = "INSERT INTO GiaoDich (MaNV, MaKH, MaLoai, NgayGD) VALUES (@MaNV, @MaKH, @MaLoai, GETDATE())"
            SQLDatabase.Execute(sqlInsertGD,
                New SqlParameter("@MaNV", maNV),
                New SqlParameter("@MaKH", maKH),
                New SqlParameter("@MaLoai", maLoai)
            )

            ' 6. Trừ số dư ví khách hàng
            Dim sqlUpdateKH As String = "UPDATE KhachHang SET SoDu = SoDu - @TongTien WHERE MaKH = @MaKH"
            SQLDatabase.Execute(sqlUpdateKH,
                New SqlParameter("@TongTien", tongTien),
                New SqlParameter("@MaKH", maKH)
            )

            MessageBox.Show("Thực hiện giao dịch nạp tiền thành công! Số dư tài khoản đã được cập nhật.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)
            
            ' Làm mới trường nhập liệu
            ClearGDFields()

        Catch ex As Exception
            MessageBox.Show("Giao dịch thất bại: " & ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Cancel / Delete Transaction (Hủy & Hoàn tiền)
    Private Sub btnGDDelete_Click(sender As Object, e As EventArgs) Handles btnGDDelete.Click
        If selectedGDId = -1 Then
            MessageBox.Show("Vui lòng chọn một giao dịch từ bảng danh sách để hủy/hoàn tiền!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result = MessageBox.Show("Bạn có muốn hủy giao dịch này và hoàn trả lại số tiền đã thanh toán vào số dư tài khoản của khách hàng không?", "Xác nhận hủy giao dịch", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                ' 1. Lấy thông tin khách hàng và mệnh giá thẻ để hoàn trả
                Dim dtGD As DataTable = SQLDatabase.GetData("
                    SELECT gd.MaKH, lt.MenhGia 
                    FROM GiaoDich gd
                    JOIN LoaiThe lt ON gd.MaLoai = lt.MaLoai 
                    WHERE gd.MaGD = @MaGD", New SqlParameter("@MaGD", selectedGDId))
                
                If dtGD.Rows.Count > 0 Then
                    Dim maKH As Integer = Convert.ToInt32(dtGD.Rows(0)("MaKH"))
                    Dim tongTien As Double = Convert.ToDouble(dtGD.Rows(0)("MenhGia"))

                    ' 2. Cộng lại tiền vào ví khách hàng
                    Dim sqlRefund As String = "UPDATE KhachHang SET SoDu = SoDu + @TongTien WHERE MaKH = @MaKH"
                    SQLDatabase.Execute(sqlRefund,
                        New SqlParameter("@TongTien", tongTien),
                        New SqlParameter("@MaKH", maKH)
                    )

                    ' 3. Xóa bản ghi lịch sử giao dịch
                    SQLDatabase.Execute("DELETE FROM GiaoDich WHERE MaGD = @MaGD", New SqlParameter("@MaGD", selectedGDId))

                    MessageBox.Show("Đã hủy giao dịch thành công và hoàn trả tiền nạp vào số dư tài khoản khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearGDFields()
                End If
            Catch ex As Exception
                MessageBox.Show("Lỗi hoàn trả giao dịch: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
