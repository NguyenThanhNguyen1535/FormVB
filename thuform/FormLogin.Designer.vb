<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlHeader = New Panel()
        lblHeaderTitle = New Label()
        lblHeaderDesc = New Label()
        lblUser = New Label()
        txtUser = New TextBox()
        lblPass = New Label()
        txtPass = New TextBox()
        btnLogin = New Button()
        btnCancel = New Button()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        '
        ' pnlHeader
        '
        pnlHeader.BackColor = Color.FromArgb(15, 23, 42)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Controls.Add(lblHeaderDesc)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(380, 60)
        pnlHeader.TabIndex = 0
        '
        ' lblHeaderTitle
        '
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblHeaderTitle.ForeColor = Color.White
        lblHeaderTitle.Location = New Point(15, 10)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(207, 20)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "🔐 ĐĂNG NHẬP NHÂN VIÊN"
        '
        ' lblHeaderDesc
        '
        lblHeaderDesc.AutoSize = True
        lblHeaderDesc.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblHeaderDesc.ForeColor = Color.FromArgb(148, 163, 184)
        lblHeaderDesc.Location = New Point(17, 33)
        lblHeaderDesc.Name = "lblHeaderDesc"
        lblHeaderDesc.Size = New Size(260, 13)
        lblHeaderDesc.TabIndex = 1
        lblHeaderDesc.Text = "Vui lòng nhập tài khoản nhân viên để bán thẻ nạp"
        '
        ' lblUser
        '
        lblUser.AutoSize = True
        lblUser.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblUser.ForeColor = Color.FromArgb(71, 85, 105)
        lblUser.Location = New Point(30, 80)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(62, 15)
        lblUser.TabIndex = 1
        lblUser.Text = "Tài Khoản:"
        '
        ' txtUser
        '
        txtUser.BorderStyle = BorderStyle.FixedSingle
        txtUser.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtUser.Location = New Point(30, 100)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(320, 25)
        txtUser.TabIndex = 2
        '
        ' lblPass
        '
        lblPass.AutoSize = True
        lblPass.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblPass.ForeColor = Color.FromArgb(71, 85, 105)
        lblPass.Location = New Point(30, 140)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(62, 15)
        lblPass.TabIndex = 3
        lblPass.Text = "Mật Khẩu:"
        '
        ' txtPass
        '
        txtPass.BorderStyle = BorderStyle.FixedSingle
        txtPass.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtPass.Location = New Point(30, 160)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(320, 25)
        txtPass.TabIndex = 4
        txtPass.UseSystemPasswordChar = True
        '
        ' btnLogin
        '
        btnLogin.BackColor = Color.FromArgb(16, 185, 129)
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(30, 210)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(150, 35)
        btnLogin.TabIndex = 5
        btnLogin.Text = "🔓 Đăng Nhập"
        btnLogin.UseVisualStyleBackColor = False
        '
        ' btnCancel
        '
        btnCancel.BackColor = Color.FromArgb(107, 114, 128)
        btnCancel.Cursor = Cursors.Hand
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(200, 210)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(150, 35)
        btnCancel.TabIndex = 6
        btnCancel.Text = "🚪 Hủy"
        btnCancel.UseVisualStyleBackColor = False
        '
        ' FormLogin
        '
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        ClientSize = New Size(380, 270)
        Controls.Add(btnCancel)
        Controls.Add(btnLogin)
        Controls.Add(txtPass)
        Controls.Add(lblPass)
        Controls.Add(txtUser)
        Controls.Add(lblUser)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormLogin"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Đăng nhập nhân viên"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents pnlHeader As Panel
    Private WithEvents lblHeaderTitle As Label
    Private WithEvents lblHeaderDesc As Label
    Private WithEvents lblUser As Label
    Private WithEvents txtUser As TextBox
    Private WithEvents lblPass As Label
    Private WithEvents txtPass As TextBox
    Private WithEvents btnLogin As Button
    Private WithEvents btnCancel As Button
End Class
