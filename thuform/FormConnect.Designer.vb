<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormConnect
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
        lblServer = New Label()
        txtServer = New TextBox()
        lblDatabase = New Label()
        txtDatabase = New TextBox()
        lblAuth = New Label()
        cboAuth = New ComboBox()
        lblUser = New Label()
        txtUser = New TextBox()
        lblPass = New Label()
        txtPass = New TextBox()
        btnConnect = New Button()
        btnExit = New Button()
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
        pnlHeader.Size = New Size(400, 70)
        pnlHeader.TabIndex = 0
        '
        ' lblHeaderTitle
        '
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblHeaderTitle.ForeColor = Color.FromArgb(56, 189, 248)
        lblHeaderTitle.Location = New Point(15, 12)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(213, 21)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "KẾT NỐI CƠ SỞ DỮ LIỆU SQL"
        '
        ' lblHeaderDesc
        '
        lblHeaderDesc.AutoSize = True
        lblHeaderDesc.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblHeaderDesc.ForeColor = Color.FromArgb(148, 163, 184)
        lblHeaderDesc.Location = New Point(16, 38)
        lblHeaderDesc.Name = "lblHeaderDesc"
        lblHeaderDesc.Size = New Size(307, 13)
        lblHeaderDesc.TabIndex = 1
        lblHeaderDesc.Text = "Vui lòng điền thông tin máy chủ SQL Server để khởi chạy ứng dụng"
        '
        ' lblServer
        '
        lblServer.AutoSize = True
        lblServer.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblServer.ForeColor = Color.FromArgb(71, 85, 105)
        lblServer.Location = New Point(30, 95)
        lblServer.Name = "lblServer"
        lblServer.Size = New Size(79, 15)
        lblServer.TabIndex = 1
        lblServer.Text = "Tên Máy Chủ:"
        '
        ' txtServer
        '
        txtServer.BorderStyle = BorderStyle.FixedSingle
        txtServer.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtServer.Location = New Point(30, 115)
        txtServer.Name = "txtServer"
        txtServer.Size = New Size(340, 25)
        txtServer.TabIndex = 2
        txtServer.Text = "(localdb)\MSSQLLocalDB"
        '
        ' lblDatabase
        '
        lblDatabase.AutoSize = True
        lblDatabase.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblDatabase.ForeColor = Color.FromArgb(71, 85, 105)
        lblDatabase.Location = New Point(30, 155)
        lblDatabase.Name = "lblDatabase"
        lblDatabase.Size = New Size(94, 15)
        lblDatabase.TabIndex = 3
        lblDatabase.Text = "Tên Cơ Sở Dữ Liệu:"
        '
        ' txtDatabase
        '
        txtDatabase.BorderStyle = BorderStyle.FixedSingle
        txtDatabase.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtDatabase.Location = New Point(30, 175)
        txtDatabase.Name = "txtDatabase"
        txtDatabase.Size = New Size(340, 25)
        txtDatabase.TabIndex = 4
        txtDatabase.Text = "PhoneCardManager"
        '
        ' lblAuth
        '
        lblAuth.AutoSize = True
        lblAuth.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblAuth.ForeColor = Color.FromArgb(71, 85, 105)
        lblAuth.Location = New Point(30, 215)
        lblAuth.Name = "lblAuth"
        lblAuth.Size = New Size(89, 15)
        lblAuth.TabIndex = 5
        lblAuth.Text = "Kiểu Xác Thực:"
        '
        ' cboAuth
        '
        cboAuth.DropDownStyle = ComboBoxStyle.DropDownList
        cboAuth.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cboAuth.FormattingEnabled = True
        cboAuth.Items.AddRange(New Object() {"Windows Authentication", "SQL Server Authentication"})
        cboAuth.Location = New Point(30, 235)
        cboAuth.Name = "cboAuth"
        cboAuth.Size = New Size(340, 25)
        cboAuth.TabIndex = 6
        '
        ' lblUser
        '
        lblUser.AutoSize = True
        lblUser.Enabled = False
        lblUser.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblUser.ForeColor = Color.FromArgb(71, 85, 105)
        lblUser.Location = New Point(30, 275)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(62, 15)
        lblUser.TabIndex = 7
        lblUser.Text = "Tài Khoản:"
        '
        ' txtUser
        '
        txtUser.BorderStyle = BorderStyle.FixedSingle
        txtUser.Enabled = False
        txtUser.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtUser.Location = New Point(30, 295)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(340, 25)
        txtUser.TabIndex = 8
        txtUser.Text = "sa"
        '
        ' lblPass
        '
        lblPass.AutoSize = True
        lblPass.Enabled = False
        lblPass.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblPass.ForeColor = Color.FromArgb(71, 85, 105)
        lblPass.Location = New Point(30, 335)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(62, 15)
        lblPass.TabIndex = 9
        lblPass.Text = "Mật Khẩu:"
        '
        ' txtPass
        '
        txtPass.BorderStyle = BorderStyle.FixedSingle
        txtPass.Enabled = False
        txtPass.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtPass.Location = New Point(30, 355)
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "●"c
        txtPass.Size = New Size(340, 25)
        txtPass.TabIndex = 10
        '
        ' btnConnect
        '
        btnConnect.BackColor = Color.FromArgb(16, 185, 129)
        btnConnect.Cursor = Cursors.Hand
        btnConnect.FlatAppearance.BorderSize = 0
        btnConnect.FlatStyle = FlatStyle.Flat
        btnConnect.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnConnect.ForeColor = Color.White
        btnConnect.Location = New Point(80, 405)
        btnConnect.Name = "btnConnect"
        btnConnect.Size = New Size(115, 38)
        btnConnect.TabIndex = 11
        btnConnect.Text = "🔌  Kết Nối"
        btnConnect.UseVisualStyleBackColor = False
        '
        ' btnExit
        '
        btnExit.BackColor = Color.FromArgb(107, 114, 128)
        btnExit.Cursor = Cursors.Hand
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(205, 405)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(115, 38)
        btnExit.TabIndex = 12
        btnExit.Text = "🚪  Thoát"
        btnExit.UseVisualStyleBackColor = False
        '
        ' FormConnect
        '
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        ClientSize = New Size(400, 470)
        Controls.Add(btnExit)
        Controls.Add(btnConnect)
        Controls.Add(txtPass)
        Controls.Add(lblPass)
        Controls.Add(txtUser)
        Controls.Add(lblUser)
        Controls.Add(cboAuth)
        Controls.Add(lblAuth)
        Controls.Add(txtDatabase)
        Controls.Add(lblDatabase)
        Controls.Add(txtServer)
        Controls.Add(lblServer)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormConnect"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cấu hình CSDL SQL Server"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents pnlHeader As Panel
    Private WithEvents lblHeaderTitle As Label
    Private WithEvents lblHeaderDesc As Label
    Private WithEvents lblServer As Label
    Private WithEvents txtServer As TextBox
    Private WithEvents lblDatabase As Label
    Private WithEvents txtDatabase As TextBox
    Private WithEvents lblAuth As Label
    Private WithEvents cboAuth As ComboBox
    Private WithEvents lblUser As Label
    Private WithEvents txtUser As TextBox
    Private WithEvents lblPass As Label
    Private WithEvents txtPass As TextBox
    Private WithEvents btnConnect As Button
    Private WithEvents btnExit As Button
End Class
