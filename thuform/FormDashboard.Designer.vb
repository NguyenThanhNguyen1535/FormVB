<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDashboard
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlHeader = New Panel()
        lblHeaderTitle = New Label()
        pnlStatsContainer = New TableLayoutPanel()
        pnlStat1 = New Panel()
        lblStat1Val = New Label()
        lblStat1Title = New Label()
        pnlStat2 = New Panel()
        lblStat2Val = New Label()
        lblStat2Title = New Label()
        pnlStat3 = New Panel()
        lblStat3Val = New Label()
        lblStat3Title = New Label()
        pnlDashboardGrids = New TableLayoutPanel()
        pnlRecentGD = New Panel()
        lblRecentTitle = New Label()
        dgvRecentTransactions = New DataGridView()
        pnlCarrierStats = New Panel()
        lblCarrierTitle = New Label()
        dgvCarrierStats = New DataGridView()
        pnlHeader.SuspendLayout()
        pnlStatsContainer.SuspendLayout()
        pnlStat1.SuspendLayout()
        pnlStat2.SuspendLayout()
        pnlStat3.SuspendLayout()
        pnlDashboardGrids.SuspendLayout()
        pnlRecentGD.SuspendLayout()
        CType(dgvRecentTransactions, ComponentModel.ISupportInitialize).BeginInit()
        pnlCarrierStats.SuspendLayout()
        CType(dgvCarrierStats, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(850, 60)
        pnlHeader.TabIndex = 0
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.White
        lblHeaderTitle.Location = New Point(20, 10)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(352, 32)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "📊 BẢNG ĐIỀU KHIỂN CHÍNH"
        ' 
        ' pnlStatsContainer
        ' 
        pnlStatsContainer.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlStatsContainer.ColumnCount = 3
        pnlStatsContainer.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        pnlStatsContainer.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        pnlStatsContainer.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        pnlStatsContainer.Controls.Add(pnlStat1, 0, 0)
        pnlStatsContainer.Controls.Add(pnlStat2, 1, 0)
        pnlStatsContainer.Controls.Add(pnlStat3, 2, 0)
        pnlStatsContainer.Location = New Point(15, 75)
        pnlStatsContainer.Name = "pnlStatsContainer"
        pnlStatsContainer.RowCount = 1
        pnlStatsContainer.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        pnlStatsContainer.Size = New Size(820, 105)
        pnlStatsContainer.TabIndex = 1
        ' 
        ' pnlStat1
        ' 
        pnlStat1.BackColor = Color.FromArgb(CByte(16), CByte(185), CByte(129))
        pnlStat1.Controls.Add(lblStat1Val)
        pnlStat1.Controls.Add(lblStat1Title)
        pnlStat1.Dock = DockStyle.Fill
        pnlStat1.Location = New Point(5, 5)
        pnlStat1.Margin = New Padding(5)
        pnlStat1.Name = "pnlStat1"
        pnlStat1.Padding = New Padding(15)
        pnlStat1.Size = New Size(263, 95)
        pnlStat1.TabIndex = 0
        ' 
        ' lblStat1Val
        ' 
        lblStat1Val.Dock = DockStyle.Fill
        lblStat1Val.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        lblStat1Val.ForeColor = Color.White
        lblStat1Val.Location = New Point(15, 40)
        lblStat1Val.Name = "lblStat1Val"
        lblStat1Val.Size = New Size(233, 40)
        lblStat1Val.TabIndex = 1
        lblStat1Val.Text = "0 VNĐ"
        lblStat1Val.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblStat1Title
        ' 
        lblStat1Title.Dock = DockStyle.Top
        lblStat1Title.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblStat1Title.ForeColor = Color.FromArgb(CByte(209), CByte(250), CByte(229))
        lblStat1Title.Location = New Point(15, 15)
        lblStat1Title.Name = "lblStat1Title"
        lblStat1Title.Size = New Size(233, 25)
        lblStat1Title.TabIndex = 0
        lblStat1Title.Text = "💵 TỔNG DOANH THU"
        lblStat1Title.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlStat2
        ' 
        pnlStat2.BackColor = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        pnlStat2.Controls.Add(lblStat2Val)
        pnlStat2.Controls.Add(lblStat2Title)
        pnlStat2.Dock = DockStyle.Fill
        pnlStat2.Location = New Point(278, 5)
        pnlStat2.Margin = New Padding(5)
        pnlStat2.Name = "pnlStat2"
        pnlStat2.Padding = New Padding(15)
        pnlStat2.Size = New Size(263, 95)
        pnlStat2.TabIndex = 1
        ' 
        ' lblStat2Val
        ' 
        lblStat2Val.Dock = DockStyle.Fill
        lblStat2Val.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        lblStat2Val.ForeColor = Color.White
        lblStat2Val.Location = New Point(15, 40)
        lblStat2Val.Name = "lblStat2Val"
        lblStat2Val.Size = New Size(233, 40)
        lblStat2Val.TabIndex = 1
        lblStat2Val.Text = "0"
        lblStat2Val.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblStat2Title
        ' 
        lblStat2Title.Dock = DockStyle.Top
        lblStat2Title.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblStat2Title.ForeColor = Color.FromArgb(CByte(219), CByte(234), CByte(254))
        lblStat2Title.Location = New Point(15, 15)
        lblStat2Title.Name = "lblStat2Title"
        lblStat2Title.Size = New Size(233, 25)
        lblStat2Title.TabIndex = 0
        lblStat2Title.Text = "👥 KHÁCH HÀNG"
        lblStat2Title.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlStat3
        ' 
        pnlStat3.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        pnlStat3.Controls.Add(lblStat3Val)
        pnlStat3.Controls.Add(lblStat3Title)
        pnlStat3.Dock = DockStyle.Fill
        pnlStat3.Location = New Point(551, 5)
        pnlStat3.Margin = New Padding(5)
        pnlStat3.Name = "pnlStat3"
        pnlStat3.Padding = New Padding(15)
        pnlStat3.Size = New Size(264, 95)
        pnlStat3.TabIndex = 2
        ' 
        ' lblStat3Val
        ' 
        lblStat3Val.Dock = DockStyle.Fill
        lblStat3Val.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        lblStat3Val.ForeColor = Color.White
        lblStat3Val.Location = New Point(15, 40)
        lblStat3Val.Name = "lblStat3Val"
        lblStat3Val.Size = New Size(234, 40)
        lblStat3Val.TabIndex = 1
        lblStat3Val.Text = "0"
        lblStat3Val.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblStat3Title
        ' 
        lblStat3Title.Dock = DockStyle.Top
        lblStat3Title.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblStat3Title.ForeColor = Color.FromArgb(CByte(243), CByte(232), CByte(255))
        lblStat3Title.Location = New Point(15, 15)
        lblStat3Title.Name = "lblStat3Title"
        lblStat3Title.Size = New Size(234, 25)
        lblStat3Title.TabIndex = 0
        lblStat3Title.Text = "📈 TỔNG GIAO DỊCH"
        lblStat3Title.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlDashboardGrids
        ' 
        pnlDashboardGrids.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDashboardGrids.ColumnCount = 2
        pnlDashboardGrids.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60F))
        pnlDashboardGrids.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        pnlDashboardGrids.Controls.Add(pnlRecentGD, 0, 0)
        pnlDashboardGrids.Controls.Add(pnlCarrierStats, 1, 0)
        pnlDashboardGrids.Location = New Point(15, 195)
        pnlDashboardGrids.Name = "pnlDashboardGrids"
        pnlDashboardGrids.RowCount = 1
        pnlDashboardGrids.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        pnlDashboardGrids.Size = New Size(820, 408)
        pnlDashboardGrids.TabIndex = 2
        ' 
        ' pnlRecentGD
        ' 
        pnlRecentGD.BackColor = Color.White
        pnlRecentGD.Controls.Add(lblRecentTitle)
        pnlRecentGD.Controls.Add(dgvRecentTransactions)
        pnlRecentGD.Dock = DockStyle.Fill
        pnlRecentGD.Location = New Point(5, 5)
        pnlRecentGD.Margin = New Padding(5)
        pnlRecentGD.Name = "pnlRecentGD"
        pnlRecentGD.Padding = New Padding(15)
        pnlRecentGD.Size = New Size(482, 398)
        pnlRecentGD.TabIndex = 0
        ' 
        ' lblRecentTitle
        ' 
        lblRecentTitle.AutoSize = True
        lblRecentTitle.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        lblRecentTitle.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblRecentTitle.Location = New Point(15, 10)
        lblRecentTitle.Name = "lblRecentTitle"
        lblRecentTitle.Size = New Size(253, 31)
        lblRecentTitle.TabIndex = 0
        lblRecentTitle.Text = "Giao dịch gần đây nhất"
        ' 
        ' dgvRecentTransactions
        ' 
        dgvRecentTransactions.AllowUserToAddRows = False
        dgvRecentTransactions.AllowUserToDeleteRows = False
        dgvRecentTransactions.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvRecentTransactions.BackgroundColor = Color.White
        dgvRecentTransactions.BorderStyle = BorderStyle.None
        dgvRecentTransactions.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvRecentTransactions.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        DataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvRecentTransactions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvRecentTransactions.ColumnHeadersHeight = 35
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(239), CByte(246), CByte(255))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvRecentTransactions.DefaultCellStyle = DataGridViewCellStyle2
        dgvRecentTransactions.EnableHeadersVisualStyles = False
        dgvRecentTransactions.GridColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        dgvRecentTransactions.Location = New Point(15, 45)
        dgvRecentTransactions.Name = "dgvRecentTransactions"
        dgvRecentTransactions.ReadOnly = True
        dgvRecentTransactions.RowHeadersVisible = False
        dgvRecentTransactions.RowHeadersWidth = 62
        dgvRecentTransactions.RowTemplate.Height = 30
        dgvRecentTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRecentTransactions.Size = New Size(452, 338)
        dgvRecentTransactions.TabIndex = 1
        ' 
        ' pnlCarrierStats
        ' 
        pnlCarrierStats.BackColor = Color.White
        pnlCarrierStats.Controls.Add(lblCarrierTitle)
        pnlCarrierStats.Controls.Add(dgvCarrierStats)
        pnlCarrierStats.Dock = DockStyle.Fill
        pnlCarrierStats.Location = New Point(497, 5)
        pnlCarrierStats.Margin = New Padding(5)
        pnlCarrierStats.Name = "pnlCarrierStats"
        pnlCarrierStats.Padding = New Padding(15)
        pnlCarrierStats.Size = New Size(318, 398)
        pnlCarrierStats.TabIndex = 1
        ' 
        ' lblCarrierTitle
        ' 
        lblCarrierTitle.AutoSize = True
        lblCarrierTitle.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        lblCarrierTitle.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblCarrierTitle.Location = New Point(15, 10)
        lblCarrierTitle.Name = "lblCarrierTitle"
        lblCarrierTitle.Size = New Size(333, 31)
        lblCarrierTitle.TabIndex = 0
        lblCarrierTitle.Text = "Doanh thu chia theo nhà mạng"
        ' 
        ' dgvCarrierStats
        ' 
        dgvCarrierStats.AllowUserToAddRows = False
        dgvCarrierStats.AllowUserToDeleteRows = False
        dgvCarrierStats.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvCarrierStats.BackgroundColor = Color.White
        dgvCarrierStats.BorderStyle = BorderStyle.None
        dgvCarrierStats.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvCarrierStats.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        DataGridViewCellStyle3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvCarrierStats.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvCarrierStats.ColumnHeadersHeight = 35
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Window
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(239), CByte(246), CByte(255))
        DataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        dgvCarrierStats.DefaultCellStyle = DataGridViewCellStyle4
        dgvCarrierStats.EnableHeadersVisualStyles = False
        dgvCarrierStats.GridColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        dgvCarrierStats.Location = New Point(15, 45)
        dgvCarrierStats.Name = "dgvCarrierStats"
        dgvCarrierStats.ReadOnly = True
        dgvCarrierStats.RowHeadersVisible = False
        dgvCarrierStats.RowHeadersWidth = 62
        dgvCarrierStats.RowTemplate.Height = 30
        dgvCarrierStats.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCarrierStats.Size = New Size(288, 338)
        dgvCarrierStats.TabIndex = 1
        ' 
        ' FormDashboard
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        ClientSize = New Size(850, 618)
        Controls.Add(pnlDashboardGrids)
        Controls.Add(pnlStatsContainer)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormDashboard"
        Text = "FormDashboard"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlStatsContainer.ResumeLayout(False)
        pnlStat1.ResumeLayout(False)
        pnlStat2.ResumeLayout(False)
        pnlStat3.ResumeLayout(False)
        pnlDashboardGrids.ResumeLayout(False)
        pnlRecentGD.ResumeLayout(False)
        pnlRecentGD.PerformLayout()
        CType(dgvRecentTransactions, ComponentModel.ISupportInitialize).EndInit()
        pnlCarrierStats.ResumeLayout(False)
        pnlCarrierStats.PerformLayout()
        CType(dgvCarrierStats, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Private WithEvents pnlHeader As Panel
    Private WithEvents lblHeaderTitle As Label
    Private WithEvents pnlStatsContainer As TableLayoutPanel
    Private WithEvents pnlStat1 As Panel
    Private WithEvents lblStat1Val As Label
    Private WithEvents lblStat1Title As Label
    Private WithEvents pnlStat2 As Panel
    Private WithEvents lblStat2Val As Label
    Private WithEvents lblStat2Title As Label
    Private WithEvents pnlStat3 As Panel
    Private WithEvents lblStat3Val As Label
    Private WithEvents lblStat3Title As Label
    Private WithEvents pnlDashboardGrids As TableLayoutPanel
    Private WithEvents pnlRecentGD As Panel
    Private WithEvents lblRecentTitle As Label
    Private WithEvents dgvRecentTransactions As DataGridView
    Private WithEvents pnlCarrierStats As Panel
    Private WithEvents lblCarrierTitle As Label
    Private WithEvents dgvCarrierStats As DataGridView
End Class
