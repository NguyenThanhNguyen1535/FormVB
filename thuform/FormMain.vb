Imports System.Windows.Forms

Public Class FormMain
    Private currentChildForm As Form = Nothing

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cập nhật nhãn trạng thái kết nối ở thanh StatusStrip dưới cùng
        UpdateStatusLabel()

        ' Load màn hình Dashboard thống kê mặc định đầu tiên
        LoadDashboard()
    End Sub

    Public Sub UpdateStatusLabel()
        If Not String.IsNullOrEmpty(SQLDatabase.strConn) Then
            ' Extract server and database name from connection string for friendly display
            Dim server As String = "SQL Server"
            Dim db As String = "CSDL"
            Try
                Dim builder As New Microsoft.Data.SqlClient.SqlConnectionStringBuilder(SQLDatabase.strConn)
                server = builder.DataSource
                db = builder.InitialCatalog
            Catch
            End Try
            lblStatus.Text = $"🔌 Đã kết nối SQL Server: {server} | CSDL: {db}"
        Else
            lblStatus.Text = "❌ Chưa kết nối cơ sở dữ liệu"
        End If
    End Sub

    ' Embedding Child Form Helper
    Public Sub LoadChildForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
            currentChildForm.Dispose()
        End If

        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(childForm)
        pnlContent.Tag = childForm
        childForm.Show()
    End Sub

    ' Menu Handlers
    Private Sub mnuConnect_Click(sender As Object, e As EventArgs) Handles mnuConnect.Click
        Using frm As New FormConnect()
            If frm.ShowDialog() = DialogResult.OK Then
                UpdateStatusLabel()
                ' Reload dashboard or current view
                LoadDashboard()
            End If
        End Using
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub mnuKhachHang_Click(sender As Object, e As EventArgs) Handles mnuKhachHang.Click
        LoadChildForm(New FormKhachHang())
    End Sub

    Private Sub mnuLoaiThe_Click(sender As Object, e As EventArgs) Handles mnuLoaiThe.Click
        LoadChildForm(New FormLoaiThe())
    End Sub

    Private Sub mnuGiaoDich_Click(sender As Object, e As EventArgs) Handles mnuGiaoDich.Click
        LoadChildForm(New FormGiaoDich())
    End Sub

    Private Sub mnuDashboard_Click(sender As Object, e As EventArgs) Handles mnuDashboard.Click
        LoadDashboard()
    End Sub

    Private Sub LoadDashboard()
        LoadChildForm(New FormDashboard())
    End Sub
End Class
