<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGiaoDich
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
        Dim dataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim dataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlHeader = New Panel()
        lblHeaderTitle = New Label()
        lblHeaderDesc = New Label()
        pnlGDLayout = New TableLayoutPanel()
        pnlGDForm = New Panel()
        lblGDFormTitle = New Label()
        lblGDMaNV = New Label()
        numGDMaNV = New NumericUpDown()
        lblGDKhachHang = New Label()
        cboGDKhachHang = New ComboBox()
        lblGDLoaiThe = New Label()
        cboGDLoaiThe = New ComboBox()
        lblGDSoLuong = New Label()
        numGDSoLuong = New NumericUpDown()
        pnlGDTotals = New Panel()
        lblGDTongTienVal = New Label()
        lblGDTongTienTitle = New Label()
        btnGDAdd = New Button()
        btnGDDelete = New Button()
        btnGDReset = New Button()
        pnlGDGridContainer = New Panel()
        pnlGDSearch = New Panel()
        lblGDSearch = New Label()
        txtGDSearch = New TextBox()
        dgvGiaoDich = New DataGridView()
        pnlHeader.SuspendLayout()
        pnlGDLayout.SuspendLayout()
        pnlGDForm.SuspendLayout()
        CType(numGDMaNV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(numGDSoLuong, System.ComponentModel.ISupportInitialize).BeginInit()
        pnlGDTotals.SuspendLayout()
        pnlGDGridContainer.SuspendLayout()
        pnlGDSearch.SuspendLayout()
        CType(dgvGiaoDich, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        ' pnlHeader
        '
        pnlHeader.BackColor = Color.FromArgb(30, 41, 59)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Controls.Add(lblHeaderDesc)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(850, 60)
        pnlHeader.TabIndex = 0
        '
        ' lblHeaderTitle
        '
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblHeaderTitle.ForeColor = Color.White
        lblHeaderTitle.Location = New Point(20, 10)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(265, 21)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "💸 NẠP TIỀN & LỊCH SỬ GIAO DỊCH"
        '
        ' lblHeaderDesc
        '
        lblHeaderDesc.AutoSize = True
        lblHeaderDesc.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblHeaderDesc.ForeColor = Color.FromArgb(148, 163, 184)
        lblHeaderDesc.Location = New Point(22, 33)
        lblHeaderDesc.Name = "lblHeaderDesc"
        lblHeaderDesc.Size = New Size(393, 13)
        lblHeaderDesc.TabIndex = 1
        lblHeaderDesc.Text = "Nạp thẻ điện thoại cho khách hàng, tự động quản lý số dư và thu hồi/hoàn trả ví"
        '
        ' pnlGDLayout
        '
        pnlGDLayout.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlGDLayout.ColumnCount = 2
        pnlGDLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35.0F))
        pnlGDLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 65.0F))
        pnlGDLayout.Controls.Add(pnlGDForm, 0, 0)
        pnlGDLayout.Controls.Add(pnlGDGridContainer, 1, 0)
        pnlGDLayout.Location = New Point(15, 75)
        pnlGDLayout.Name = "pnlGDLayout"
        pnlGDLayout.RowCount = 1
        pnlGDLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        pnlGDLayout.Size = New Size(820, 528)
        pnlGDLayout.TabIndex = 1
        '
        ' pnlGDForm
        '
        pnlGDForm.BackColor = Color.White
        pnlGDForm.Controls.Add(lblGDFormTitle)
        pnlGDForm.Controls.Add(lblGDMaNV)
        pnlGDForm.Controls.Add(numGDMaNV)
        pnlGDForm.Controls.Add(lblGDKhachHang)
        pnlGDForm.Controls.Add(cboGDKhachHang)
        pnlGDForm.Controls.Add(lblGDLoaiThe)
        pnlGDForm.Controls.Add(cboGDLoaiThe)
        pnlGDForm.Controls.Add(lblGDSoLuong)
        pnlGDForm.Controls.Add(numGDSoLuong)
        pnlGDForm.Controls.Add(pnlGDTotals)
        pnlGDForm.Controls.Add(btnGDAdd)
        pnlGDForm.Controls.Add(btnGDDelete)
        pnlGDForm.Controls.Add(btnGDReset)
        pnlGDForm.Dock = DockStyle.Fill
        pnlGDForm.Location = New Point(5, 5)
        pnlGDForm.Margin = New Padding(5)
        pnlGDForm.Name = "pnlGDForm"
        pnlGDForm.Padding = New Padding(15)
        pnlGDForm.Size = New Size(277, 518)
        pnlGDForm.TabIndex = 0
        '
        ' lblGDFormTitle
        '
        lblGDFormTitle.AutoSize = True
        lblGDFormTitle.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblGDFormTitle.ForeColor = Color.FromArgb(30, 41, 59)
        lblGDFormTitle.Location = New Point(15, 10)
        lblGDFormTitle.Name = "lblGDFormTitle"
        lblGDFormTitle.Size = New Size(147, 20)
        lblGDFormTitle.TabIndex = 0
        lblGDFormTitle.Text = "Nghiệp vụ Giao dịch"
        '
        ' lblGDMaNV
        '
        lblGDMaNV.AutoSize = True
        lblGDMaNV.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblGDMaNV.ForeColor = Color.FromArgb(71, 85, 105)
        lblGDMaNV.Location = New Point(15, 50)
        lblGDMaNV.Name = "lblGDMaNV"
        lblGDMaNV.Size = New Size(85, 15)
        lblGDMaNV.TabIndex = 1
        lblGDMaNV.Text = "Mã Nhân Viên:"
        '
        ' numGDMaNV
        '
        numGDMaNV.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        numGDMaNV.BorderStyle = BorderStyle.FixedSingle
        numGDMaNV.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        numGDMaNV.Location = New Point(15, 70)
        numGDMaNV.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numGDMaNV.Name = "numGDMaNV"
        numGDMaNV.Size = New Size(247, 25)
        numGDMaNV.TabIndex = 2
        numGDMaNV.Value = New Decimal(New Integer() {101, 0, 0, 0})
        '
        ' lblGDKhachHang
        '
        lblGDKhachHang.AutoSize = True
        lblGDKhachHang.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblGDKhachHang.ForeColor = Color.FromArgb(71, 85, 105)
        lblGDKhachHang.Location = New Point(15, 110)
        lblGDKhachHang.Name = "lblGDKhachHang"
        lblGDKhachHang.Size = New Size(74, 15)
        lblGDKhachHang.TabIndex = 3
        lblGDKhachHang.Text = "Khách Hàng:"
        '
        ' cboGDKhachHang
        '
        cboGDKhachHang.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cboGDKhachHang.DropDownStyle = ComboBoxStyle.DropDownList
        cboGDKhachHang.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        cboGDKhachHang.FormattingEnabled = True
        cboGDKhachHang.Location = New Point(15, 130)
        cboGDKhachHang.Name = "cboGDKhachHang"
        cboGDKhachHang.Size = New Size(247, 23)
        cboGDKhachHang.TabIndex = 4
        '
        ' lblGDLoaiThe
        '
        lblGDLoaiThe.AutoSize = True
        lblGDLoaiThe.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblGDLoaiThe.ForeColor = Color.FromArgb(71, 85, 105)
        lblGDLoaiThe.Location = New Point(15, 170)
        lblGDLoaiThe.Name = "lblGDLoaiThe"
        lblGDLoaiThe.Size = New Size(99, 15)
        lblGDLoaiThe.TabIndex = 5
        lblGDLoaiThe.Text = "Nhà mạng - Thẻ:"
        '
        ' cboGDLoaiThe
        '
        cboGDLoaiThe.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cboGDLoaiThe.DropDownStyle = ComboBoxStyle.DropDownList
        cboGDLoaiThe.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        cboGDLoaiThe.FormattingEnabled = True
        cboGDLoaiThe.Location = New Point(15, 190)
        cboGDLoaiThe.Name = "cboGDLoaiThe"
        cboGDLoaiThe.Size = New Size(247, 23)
        cboGDLoaiThe.TabIndex = 6
        '
        ' lblGDSoLuong
        '
        lblGDSoLuong.AutoSize = True
        lblGDSoLuong.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblGDSoLuong.ForeColor = Color.FromArgb(71, 85, 105)
        lblGDSoLuong.Location = New Point(15, 230)
        lblGDSoLuong.Name = "lblGDSoLuong"
        lblGDSoLuong.Size = New Size(60, 15)
        lblGDSoLuong.TabIndex = 7
        lblGDSoLuong.Text = "Số Lượng:"
        '
        ' numGDSoLuong
        '
        numGDSoLuong.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        numGDSoLuong.BorderStyle = BorderStyle.FixedSingle
        numGDSoLuong.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        numGDSoLuong.Location = New Point(15, 250)
        numGDSoLuong.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        numGDSoLuong.Name = "numGDSoLuong"
        numGDSoLuong.Size = New Size(247, 25)
        numGDSoLuong.TabIndex = 8
        numGDSoLuong.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        ' pnlGDTotals
        '
        pnlGDTotals.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlGDTotals.BackColor = Color.FromArgb(248, 250, 252)
        pnlGDTotals.Controls.Add(lblGDTongTienVal)
        pnlGDTotals.Controls.Add(lblGDTongTienTitle)
        pnlGDTotals.Location = New Point(15, 290)
        pnlGDTotals.Name = "pnlGDTotals"
        pnlGDTotals.Size = New Size(247, 65)
        pnlGDTotals.TabIndex = 9
        '
        ' lblGDTongTienVal
        '
        lblGDTongTienVal.Dock = DockStyle.Fill
        lblGDTongTienVal.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblGDTongTienVal.ForeColor = Color.FromArgb(220, 38, 38)
        lblGDTongTienVal.Location = New Point(0, 25)
        lblGDTongTienVal.Name = "lblGDTongTienVal"
        lblGDTongTienVal.Size = New Size(247, 40)
        lblGDTongTienVal.TabIndex = 1
        lblGDTongTienVal.Text = "0 ₫"
        lblGDTongTienVal.TextAlign = ContentAlignment.MiddleCenter
        '
        ' lblGDTongTienTitle
        '
        lblGDTongTienTitle.Dock = DockStyle.Top
        lblGDTongTienTitle.Font = New Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblGDTongTienTitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblGDTongTienTitle.Location = New Point(0, 0)
        lblGDTongTienTitle.Name = "lblGDTongTienTitle"
        lblGDTongTienTitle.Size = New Size(247, 25)
        lblGDTongTienTitle.TabIndex = 0
        lblGDTongTienTitle.Text = "TỔNG SỐ TIỀN CẦN THANH TOÁN"
        lblGDTongTienTitle.TextAlign = ContentAlignment.MiddleCenter
        '
        ' btnGDAdd
        '
        btnGDAdd.BackColor = Color.FromArgb(16, 185, 129)
        btnGDAdd.Cursor = Cursors.Hand
        btnGDAdd.FlatAppearance.BorderSize = 0
        btnGDAdd.FlatStyle = FlatStyle.Flat
        btnGDAdd.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnGDAdd.ForeColor = Color.White
        btnGDAdd.Location = New Point(15, 370)
        btnGDAdd.Name = "btnGDAdd"
        btnGDAdd.Size = New Size(247, 40)
        btnGDAdd.TabIndex = 10
        btnGDAdd.Text = "💵  Thực hiện Giao dịch"
        btnGDAdd.UseVisualStyleBackColor = False
        '
        ' btnGDDelete
        '
        btnGDDelete.BackColor = Color.FromArgb(239, 68, 68)
        btnGDDelete.Cursor = Cursors.Hand
        btnGDDelete.FlatAppearance.BorderSize = 0
        btnGDDelete.FlatStyle = FlatStyle.Flat
        btnGDDelete.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnGDDelete.ForeColor = Color.White
        btnGDDelete.Location = New Point(15, 420)
        btnGDDelete.Name = "btnGDDelete"
        btnGDDelete.Size = New Size(115, 38)
        btnGDDelete.TabIndex = 11
        btnGDDelete.Text = "❌  Hủy GD"
        btnGDDelete.UseVisualStyleBackColor = False
        '
        ' btnGDReset
        '
        btnGDReset.BackColor = Color.FromArgb(107, 114, 128)
        btnGDReset.Cursor = Cursors.Hand
        btnGDReset.FlatAppearance.BorderSize = 0
        btnGDReset.FlatStyle = FlatStyle.Flat
        btnGDReset.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnGDReset.ForeColor = Color.White
        btnGDReset.Location = New Point(147, 420)
        btnGDReset.Name = "btnGDReset"
        btnGDReset.Size = New Size(115, 38)
        btnGDReset.TabIndex = 12
        btnGDReset.Text = "🔄  Làm mới"
        btnGDReset.UseVisualStyleBackColor = False
        '
        ' pnlGDGridContainer
        '
        pnlGDGridContainer.BackColor = Color.White
        pnlGDGridContainer.Controls.Add(pnlGDSearch)
        pnlGDGridContainer.Controls.Add(dgvGiaoDich)
        pnlGDGridContainer.Dock = DockStyle.Fill
        pnlGDGridContainer.Location = New Point(294, 5)
        pnlGDGridContainer.Margin = New Padding(5)
        pnlGDGridContainer.Name = "pnlGDGridContainer"
        pnlGDGridContainer.Padding = New Padding(15)
        pnlGDGridContainer.Size = New Size(521, 518)
        pnlGDGridContainer.TabIndex = 1
        '
        ' pnlGDSearch
        '
        pnlGDSearch.Controls.Add(lblGDSearch)
        pnlGDSearch.Controls.Add(txtGDSearch)
        pnlGDSearch.Dock = DockStyle.Top
        pnlGDSearch.Location = New Point(15, 15)
        pnlGDSearch.Name = "pnlGDSearch"
        pnlGDSearch.Size = New Size(491, 40)
        pnlGDSearch.TabIndex = 0
        '
        ' lblGDSearch
        '
        lblGDSearch.AutoSize = True
        lblGDSearch.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblGDSearch.ForeColor = Color.FromArgb(71, 85, 105)
        lblGDSearch.Location = New Point(3, 10)
        lblGDSearch.Name = "lblGDSearch"
        lblGDSearch.Size = New Size(65, 17)
        lblGDSearch.TabIndex = 0
        lblGDSearch.Text = "Tìm kiếm:"
        '
        ' txtGDSearch
        '
        txtGDSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtGDSearch.BorderStyle = BorderStyle.FixedSingle
        txtGDSearch.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtGDSearch.Location = New Point(74, 7)
        txtGDSearch.Name = "txtGDSearch"
        txtGDSearch.PlaceholderText = "Tìm theo tên khách hàng nạp thẻ..."
        txtGDSearch.Size = New Size(414, 25)
        txtGDSearch.TabIndex = 1
        '
        ' dgvGiaoDich
        '
        dgvGiaoDich.AllowUserToAddRows = False
        dgvGiaoDich.AllowUserToDeleteRows = False
        dgvGiaoDich.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvGiaoDich.BackgroundColor = Color.White
        dgvGiaoDich.BorderStyle = BorderStyle.None
        dgvGiaoDich.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvGiaoDich.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 23, 42)
        dataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        dataGridViewCellStyle1.ForeColor = Color.White
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(15, 23, 42)
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvGiaoDich.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1
        dgvGiaoDich.ColumnHeadersHeight = 35
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        dataGridViewCellStyle2.BackColor = SystemColors.Window
        dataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 65, 85)
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(239, 246, 255)
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 41, 59)
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvGiaoDich.DefaultCellStyle = dataGridViewCellStyle2
        dgvGiaoDich.EnableHeadersVisualStyles = False
        dgvGiaoDich.GridColor = Color.FromArgb(241, 245, 249)
        dgvGiaoDich.Location = New Point(15, 65)
        dgvGiaoDich.Name = "dgvGiaoDich"
        dgvGiaoDich.ReadOnly = True
        dgvGiaoDich.RowHeadersVisible = False
        dgvGiaoDich.RowTemplate.Height = 30
        dgvGiaoDich.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvGiaoDich.Size = New Size(491, 438)
        dgvGiaoDich.TabIndex = 1
        '
        ' FormGiaoDich
        '
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(241, 245, 249)
        ClientSize = New Size(850, 618)
        Controls.Add(pnlGDLayout)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormGiaoDich"
        Text = "FormGiaoDich"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlGDLayout.ResumeLayout(False)
        pnlGDForm.ResumeLayout(False)
        pnlGDForm.PerformLayout()
        CType(numGDMaNV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(numGDSoLuong, System.ComponentModel.ISupportInitialize).EndInit()
        pnlGDTotals.ResumeLayout(False)
        pnlGDGridContainer.ResumeLayout(False)
        pnlGDGridContainer.PerformLayout()
        CType(dgvGiaoDich, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Private WithEvents pnlHeader As Panel
    Private WithEvents lblHeaderTitle As Label
    Private WithEvents lblHeaderDesc As Label
    Private WithEvents pnlGDLayout As TableLayoutPanel
    Private WithEvents pnlGDForm As Panel
    Private WithEvents lblGDFormTitle As Label
    Private WithEvents lblGDMaNV As Label
    Private WithEvents numGDMaNV As NumericUpDown
    Private WithEvents lblGDKhachHang As Label
    Private WithEvents cboGDKhachHang As ComboBox
    Private WithEvents lblGDLoaiThe As Label
    Private WithEvents cboGDLoaiThe As ComboBox
    Private WithEvents lblGDSoLuong As Label
    Private WithEvents numGDSoLuong As NumericUpDown
    Private WithEvents pnlGDTotals As Panel
    Private WithEvents lblGDTongTienVal As Label
    Private WithEvents lblGDTongTienTitle As Label
    Private WithEvents btnGDAdd As Button
    Private WithEvents btnGDDelete As Button
    Private WithEvents btnGDReset As Button
    Private WithEvents pnlGDGridContainer As Panel
    Private WithEvents pnlGDSearch As Panel
    Private WithEvents lblGDSearch As Label
    Private WithEvents txtGDSearch As TextBox
    Private WithEvents dgvGiaoDich As DataGridView
End Class
