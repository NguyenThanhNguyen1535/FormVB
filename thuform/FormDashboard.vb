Imports System.Globalization
Imports System.Data

Public Class FormDashboard
    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboardStats()
    End Sub

    Public Sub LoadDashboardStats()
        Try
            ' 1. Tổng doanh thu (Tính bằng SUM của mệnh giá thẻ trong các giao dịch)
            Dim totalRevenueObj = SQLDatabase.ExecuteScalar("SELECT SUM(TongTien) FROM GiaoDich;")
            Dim totalRevenue As Double = 0
            If totalRevenueObj IsNot DBNull.Value AndAlso totalRevenueObj IsNot Nothing Then
                totalRevenue = Convert.ToDouble(totalRevenueObj)
            End If
            lblStat1Val.Text = totalRevenue.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) & " ₫"

            ' 2. Tổng số khách hàng
            Dim totalCustomersObj = SQLDatabase.ExecuteScalar("SELECT COUNT(*) FROM KhachHang;")
            Dim totalCustomers As Long = 0
            If totalCustomersObj IsNot Nothing Then
                totalCustomers = Convert.ToInt64(totalCustomersObj)
            End If
            lblStat2Val.Text = totalCustomers.ToString()

            ' 3. Tổng số giao dịch
            Dim totalTransactionsObj = SQLDatabase.ExecuteScalar("SELECT COUNT(*) FROM GiaoDich;")
            Dim totalTransactions As Long = 0
            If totalTransactionsObj IsNot Nothing Then
                totalTransactions = Convert.ToInt64(totalTransactionsObj)
            End If
            lblStat3Val.Text = totalTransactions.ToString()

            ' 4. Danh sách 10 Giao Dịch Gần Nhất
            Dim sqlRecent As String = "
                SELECT TOP 10 gd.MaGD AS [Mã GD], nv.HoTen AS [Nhân Viên], kh.HoTen AS [Khách Hàng], 
                       lt.TenNhaMang AS [Nhà Mạng], gd.TongTien AS [Số Tiền], gd.NgayGD AS [Ngày GD]
                FROM GiaoDich gd
                JOIN NhanVien nv ON gd.MaNV = nv.MaNV
                JOIN KhachHang kh ON gd.MaKH = kh.MaKH
                JOIN LoaiThe lt ON gd.MaLoai = lt.MaLoai
                ORDER BY gd.MaGD DESC;"
            Dim dtRecent As DataTable = SQLDatabase.GetData(sqlRecent)
            dgvRecentTransactions.DataSource = dtRecent
            FormatGridCurrency(dgvRecentTransactions, "Số Tiền")
            dgvRecentTransactions.AutoResizeColumns()

            ' 5. Doanh thu theo từng nhà mạng
            Dim sqlCarrier As String = "
                SELECT lt.TenNhaMang AS [Nhà Mạng], SUM(gd.TongTien) AS [Doanh Thu]
                FROM GiaoDich gd
                JOIN LoaiThe lt ON gd.MaLoai = lt.MaLoai
                GROUP BY lt.TenNhaMang
                ORDER BY [Doanh Thu] DESC;"
            Dim dtCarrier As DataTable = SQLDatabase.GetData(sqlCarrier)
            dgvCarrierStats.DataSource = dtCarrier
            FormatGridCurrency(dgvCarrierStats, "Doanh Thu")
            dgvCarrierStats.AutoResizeColumns()

        Catch ex As Exception
            ' Bỏ qua nếu có lỗi khởi chạy khi kết nối chưa hoàn tất
        End Try
    End Sub

    Private Sub FormatGridCurrency(dgv As DataGridView, columnName As String)
        If dgv.Columns.Contains(columnName) Then
            dgv.Columns(columnName).DefaultCellStyle.Format = "C0"
            dgv.Columns(columnName).DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vi-VN")
        End If
    End Sub
End Class
