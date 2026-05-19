<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        mnuStrip = New MenuStrip()
        mnuHeThong = New ToolStripMenuItem()
        mnuConnect = New ToolStripMenuItem()
        mnuExitSeparator = New ToolStripSeparator()
        mnuExit = New ToolStripMenuItem()
        mnuDanhMuc = New ToolStripMenuItem()
        mnuKhachHang = New ToolStripMenuItem()
        mnuLoaiThe = New ToolStripMenuItem()
        mnuNghiepVu = New ToolStripMenuItem()
        mnuGiaoDich = New ToolStripMenuItem()
        mnuThongKe = New ToolStripMenuItem()
        mnuDashboard = New ToolStripMenuItem()
        pnlContent = New Panel()
        statusMain = New StatusStrip()
        lblStatus = New ToolStripStatusLabel()
        mnuStrip.SuspendLayout()
        statusMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' mnuStrip
        ' 
        mnuStrip.BackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        mnuStrip.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        mnuStrip.ImageScalingSize = New Size(20, 20)
        mnuStrip.Items.AddRange(New ToolStripItem() {mnuHeThong, mnuDanhMuc, mnuNghiepVu, mnuThongKe})
        mnuStrip.Location = New Point(0, 0)
        mnuStrip.Name = "mnuStrip"
        mnuStrip.Padding = New Padding(6, 8, 0, 8)
        mnuStrip.Size = New Size(1100, 48)
        mnuStrip.TabIndex = 0
        mnuStrip.Text = "MenuStrip"
        ' 
        ' mnuHeThong
        ' 
        mnuHeThong.DropDownItems.AddRange(New ToolStripItem() {mnuConnect, mnuExitSeparator, mnuExit})
        mnuHeThong.ForeColor = Color.White
        mnuHeThong.Name = "mnuHeThong"
        mnuHeThong.Size = New Size(153, 32)
        mnuHeThong.Text = "⚙️ Hệ Thống"
        ' 
        ' mnuConnect
        ' 
        mnuConnect.Name = "mnuConnect"
        mnuConnect.Size = New Size(368, 36)
        mnuConnect.Text = "🔐 Đăng Nhập Nhân Viên..."
        ' 
        ' mnuExitSeparator
        ' 
        mnuExitSeparator.Name = "mnuExitSeparator"
        mnuExitSeparator.Size = New Size(365, 6)
        ' 
        ' mnuExit
        ' 
        mnuExit.Name = "mnuExit"
        mnuExit.Size = New Size(368, 36)
        mnuExit.Text = "🚪 Thoát Ứng Dụng"
        ' 
        ' mnuDanhMuc
        ' 
        mnuDanhMuc.DropDownItems.AddRange(New ToolStripItem() {mnuKhachHang, mnuLoaiThe})
        mnuDanhMuc.ForeColor = Color.White
        mnuDanhMuc.Name = "mnuDanhMuc"
        mnuDanhMuc.Size = New Size(155, 32)
        mnuDanhMuc.Text = "🏷️ Danh Mục"
        ' 
        ' mnuKhachHang
        ' 
        mnuKhachHang.Name = "mnuKhachHang"
        mnuKhachHang.Size = New Size(338, 36)
        mnuKhachHang.Text = "👥 Quản Lý Khách Hàng"
        ' 
        ' mnuLoaiThe
        ' 
        mnuLoaiThe.Name = "mnuLoaiThe"
        mnuLoaiThe.Size = New Size(338, 36)
        mnuLoaiThe.Text = "💳 Quản Lý Loại Thẻ"
        ' 
        ' mnuNghiepVu
        ' 
        mnuNghiepVu.DropDownItems.AddRange(New ToolStripItem() {mnuGiaoDich})
        mnuNghiepVu.ForeColor = Color.White
        mnuNghiepVu.Name = "mnuNghiepVu"
        mnuNghiepVu.Size = New Size(160, 32)
        mnuNghiepVu.Text = "💸 Nghiệp Vụ"
        ' 
        ' mnuGiaoDich
        ' 
        mnuGiaoDich.Name = "mnuGiaoDich"
        mnuGiaoDich.Size = New Size(329, 36)
        mnuGiaoDich.Text = "💳 Nạp Tiền & Giao Dịch"
        ' 
        ' mnuThongKe
        ' 
        mnuThongKe.DropDownItems.AddRange(New ToolStripItem() {mnuDashboard})
        mnuThongKe.ForeColor = Color.White
        mnuThongKe.Name = "mnuThongKe"
        mnuThongKe.Size = New Size(150, 32)
        mnuThongKe.Text = "📈 Thống Kê"
        ' 
        ' mnuDashboard
        ' 
        mnuDashboard.Name = "mnuDashboard"
        mnuDashboard.Size = New Size(300, 36)
        mnuDashboard.Text = "📊 Bảng Điều Khiển"
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(0, 48)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(1100, 600)
        pnlContent.TabIndex = 1
        ' 
        ' statusMain
        ' 
        statusMain.BackColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        statusMain.ImageScalingSize = New Size(20, 20)
        statusMain.Items.AddRange(New ToolStripItem() {lblStatus})
        statusMain.Location = New Point(0, 648)
        statusMain.Name = "statusMain"
        statusMain.Size = New Size(1100, 32)
        statusMain.TabIndex = 2
        statusMain.Text = "StatusStrip"
        ' 
        ' lblStatus
        ' 
        lblStatus.Font = New Font("Segoe UI", 9F)
        lblStatus.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(198, 25)
        lblStatus.Text = "Trạng thái: Chưa kết nối"
        ' 
        ' FormMain
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        ClientSize = New Size(1100, 680)
        Controls.Add(pnlContent)
        Controls.Add(statusMain)
        Controls.Add(mnuStrip)
        Font = New Font("Segoe UI", 9F)
        MainMenuStrip = mnuStrip
        Name = "FormMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Hệ thống Quản lý Tiền Điện thoại "
        mnuStrip.ResumeLayout(False)
        mnuStrip.PerformLayout()
        statusMain.ResumeLayout(False)
        statusMain.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents mnuStrip As MenuStrip
    Private WithEvents mnuHeThong As ToolStripMenuItem
    Private WithEvents mnuConnect As ToolStripMenuItem
    Private WithEvents mnuExitSeparator As ToolStripSeparator
    Private WithEvents mnuExit As ToolStripMenuItem
    Private WithEvents mnuDanhMuc As ToolStripMenuItem
    Private WithEvents mnuKhachHang As ToolStripMenuItem
    Private WithEvents mnuLoaiThe As ToolStripMenuItem
    Private WithEvents mnuNghiepVu As ToolStripMenuItem
    Private WithEvents mnuGiaoDich As ToolStripMenuItem
    Private WithEvents mnuThongKe As ToolStripMenuItem
    Private WithEvents mnuDashboard As ToolStripMenuItem
    Private WithEvents pnlContent As Panel
    Private WithEvents statusMain As StatusStrip
    Private WithEvents lblStatus As ToolStripStatusLabel
End Class
