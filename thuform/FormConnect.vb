Imports System.Windows.Forms

Public Class FormConnect
    Private Sub FormConnect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboAuth.SelectedIndex = 0
    End Sub

    Private Sub cboAuth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAuth.SelectedIndexChanged
        Dim isSqlAuth As Boolean = (cboAuth.SelectedIndex = 1)
        lblUser.Enabled = isSqlAuth
        txtUser.Enabled = isSqlAuth
        lblPass.Enabled = isSqlAuth
        txtPass.Enabled = isSqlAuth
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim server As String = txtServer.Text.Trim()
        Dim db As String = txtDatabase.Text.Trim()
        Dim auth As String = cboAuth.SelectedItem.ToString()
        Dim user As String = txtUser.Text.Trim()
        Dim pass As String = txtPass.Text

        If String.IsNullOrEmpty(server) OrElse String.IsNullOrEmpty(db) Then
            MessageBox.Show("Vui lòng điền đầy đủ Tên máy chủ và Tên cơ sở dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If auth = "SQL Server Authentication" AndAlso String.IsNullOrEmpty(user) Then
            MessageBox.Show("Vui lòng nhập Tài khoản SQL Server!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Cursor = Cursors.WaitCursor
        Try
            ' Xây dựng chuỗi kết nối động dựa trên thông tin người dùng nhập vào
            Dim connStr As String = ""
            If auth = "Windows Authentication" Then
                connStr = $"Server={server};Database={db};Integrated Security=True;TrustServerCertificate=True"
            Else
                connStr = $"Server={server};Database={db};User ID={user};Password={pass};TrustServerCertificate=True"
            End If

            ' Gán chuỗi kết nối mới và chạy kiểm tra kết nối
            SQLDatabase.strConn = connStr
            Using conn As New Microsoft.Data.SqlClient.SqlConnection(SQLDatabase.strConn)
                conn.Open()
            End Using
            
            MessageBox.Show("Kết nối cơ sở dữ liệu SQL Server thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Lỗi kết nối CSDL: " & ex.Message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
