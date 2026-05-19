Imports Microsoft.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Clear()
        txtPass.Clear()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUser.Text.Trim()
        Dim password As String = txtPass.Text

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Vui lòng điền đầy đủ Tài khoản và Mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim sql As String = "SELECT MaNV, HoTen, Quyen FROM NhanVien WHERE TaiKhoan = @User AND MatKhau = @Pass"
            Dim dt As DataTable = SQLDatabase.GetData(sql,
                New SqlParameter("@User", username),
                New SqlParameter("@Pass", password)
            )

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                SessionState.CurrentMaNV = Convert.ToInt32(row("MaNV"))
                SessionState.CurrentHoTen = row("HoTen").ToString()
                SessionState.CurrentQuyen = row("Quyen").ToString()

                MessageBox.Show($"Chào mừng nhân viên '{SessionState.CurrentHoTen}' đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Tài khoản hoặc Mật khẩu không chính xác! Vui lòng kiểm tra lại.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi thực hiện đăng nhập: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
