<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLoaiThe
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
        pnlLTLayout = New TableLayoutPanel()
        pnlLTForm = New Panel()
        lblLTFormTitle = New Label()
        lblLTNhaMang = New Label()
        cboLTNhaMang = New ComboBox()
        lblLTMenhGia = New Label()
        numLTMenhGia = New NumericUpDown()
        btnLTAdd = New Button()
        btnLTEdit = New Button()
        btnLTDelete = New Button()
        btnLTClear = New Button()
        pnlLTGridContainer = New Panel()
        pnlLTSearch = New Panel()
        lblLTSearch = New Label()
        txtLTSearch = New TextBox()
        dgvLoaiThe = New DataGridView()
        pnlHeader.SuspendLayout()
        pnlLTLayout.SuspendLayout()
        pnlLTForm.SuspendLayout()
        CType(numLTMenhGia, System.ComponentModel.ISupportInitialize).BeginInit()
        pnlLTGridContainer.SuspendLayout()
        pnlLTSearch.SuspendLayout()
        CType(dgvLoaiThe, System.ComponentModel.ISupportInitialize).BeginInit()
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
        lblHeaderTitle.Size = New Size(167, 21)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "💳 QUẢN LÝ LOẠI THẺ"
        '
        ' lblHeaderDesc
        '
        lblHeaderDesc.AutoSize = True
        lblHeaderDesc.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblHeaderDesc.ForeColor = Color.FromArgb(148, 163, 184)
        lblHeaderDesc.Location = New Point(22, 33)
        lblHeaderDesc.Name = "lblHeaderDesc"
        lblHeaderDesc.Size = New Size(346, 13)
        lblHeaderDesc.TabIndex = 1
        lblHeaderDesc.Text = "Quản lý danh sách mệnh giá thẻ và các nhà mạng viễn thông hỗ trợ"
        '
        ' pnlLTLayout
        '
        pnlLTLayout.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlLTLayout.ColumnCount = 2
        pnlLTLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35.0F))
        pnlLTLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 65.0F))
        pnlLTLayout.Controls.Add(pnlLTForm, 0, 0)
        pnlLTLayout.Controls.Add(pnlLTGridContainer, 1, 0)
        pnlLTLayout.Location = New Point(15, 75)
        pnlLTLayout.Name = "pnlLTLayout"
        pnlLTLayout.RowCount = 1
        pnlLTLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        pnlLTLayout.Size = New Size(820, 528)
        pnlLTLayout.TabIndex = 1
        '
        ' pnlLTForm
        '
        pnlLTForm.BackColor = Color.White
        pnlLTForm.Controls.Add(lblLTFormTitle)
        pnlLTForm.Controls.Add(lblLTNhaMang)
        pnlLTForm.Controls.Add(cboLTNhaMang)
        pnlLTForm.Controls.Add(lblLTMenhGia)
        pnlLTForm.Controls.Add(numLTMenhGia)
        pnlLTForm.Controls.Add(btnLTAdd)
        pnlLTForm.Controls.Add(btnLTEdit)
        pnlLTForm.Controls.Add(btnLTDelete)
        pnlLTForm.Controls.Add(btnLTClear)
        pnlLTForm.Dock = DockStyle.Fill
        pnlLTForm.Location = New Point(5, 5)
        pnlLTForm.Margin = New Padding(5)
        pnlLTForm.Name = "pnlLTForm"
        pnlLTForm.Padding = New Padding(15)
        pnlLTForm.Size = New Size(277, 518)
        pnlLTForm.TabIndex = 0
        '
        ' lblLTFormTitle
        '
        lblLTFormTitle.AutoSize = True
        lblLTFormTitle.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblLTFormTitle.ForeColor = Color.FromArgb(30, 41, 59)
        lblLTFormTitle.Location = New Point(15, 10)
        lblLTFormTitle.Name = "lblLTFormTitle"
        lblLTFormTitle.Size = New Size(141, 20)
        lblLTFormTitle.TabIndex = 0
        lblLTFormTitle.Text = "Thông tin Loại Thẻ"
        '
        ' lblLTNhaMang
        '
        lblLTNhaMang.AutoSize = True
        lblLTNhaMang.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblLTNhaMang.ForeColor = Color.FromArgb(71, 85, 105)
        lblLTNhaMang.Location = New Point(15, 55)
        lblLTNhaMang.Name = "lblLTNhaMang"
        lblLTNhaMang.Size = New Size(67, 15)
        lblLTNhaMang.TabIndex = 1
        lblLTNhaMang.Text = "Nhà mạng:"
        '
        ' cboLTNhaMang
        '
        cboLTNhaMang.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cboLTNhaMang.DropDownStyle = ComboBoxStyle.DropDownList
        cboLTNhaMang.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cboLTNhaMang.FormattingEnabled = True
        cboLTNhaMang.Items.AddRange(New Object() {"Viettel", "Mobifone", "Vinaphone", "Vietnamobile", "Gmobile"})
        cboLTNhaMang.Location = New Point(15, 75)
        cboLTNhaMang.Name = "cboLTNhaMang"
        cboLTNhaMang.Size = New Size(247, 25)
        cboLTNhaMang.TabIndex = 2
        '
        ' lblLTMenhGia
        '
        lblLTMenhGia.AutoSize = True
        lblLTMenhGia.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblLTMenhGia.ForeColor = Color.FromArgb(71, 85, 105)
        lblLTMenhGia.Location = New Point(15, 115)
        lblLTMenhGia.Name = "lblLTMenhGia"
        lblLTMenhGia.Size = New Size(81, 15)
        lblLTMenhGia.TabIndex = 3
        lblLTMenhGia.Text = "Mệnh giá (₫):"
        '
        ' numLTMenhGia
        '
        numLTMenhGia.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        numLTMenhGia.BorderStyle = BorderStyle.FixedSingle
        numLTMenhGia.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        numLTMenhGia.Increment = New Decimal(New Integer() {10000, 0, 0, 0})
        numLTMenhGia.Location = New Point(15, 135)
        numLTMenhGia.Maximum = New Decimal(New Integer() {2000000, 0, 0, 0})
        numLTMenhGia.Name = "numLTMenhGia"
        numLTMenhGia.Size = New Size(247, 25)
        numLTMenhGia.TabIndex = 4
        numLTMenhGia.ThousandsSeparator = True
        '
        ' btnLTAdd
        '
        btnLTAdd.BackColor = Color.FromArgb(16, 185, 129)
        btnLTAdd.Cursor = Cursors.Hand
        btnLTAdd.FlatAppearance.BorderSize = 0
        btnLTAdd.FlatStyle = FlatStyle.Flat
        btnLTAdd.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnLTAdd.ForeColor = Color.White
        btnLTAdd.Location = New Point(15, 195)
        btnLTAdd.Name = "btnLTAdd"
        btnLTAdd.Size = New Size(115, 38)
        btnLTAdd.TabIndex = 5
        btnLTAdd.Text = "➕  Thêm"
        btnLTAdd.UseVisualStyleBackColor = False
        '
        ' btnLTEdit
        '
        btnLTEdit.BackColor = Color.FromArgb(59, 130, 246)
        btnLTEdit.Cursor = Cursors.Hand
        btnLTEdit.FlatAppearance.BorderSize = 0
        btnLTEdit.FlatStyle = FlatStyle.Flat
        btnLTEdit.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnLTEdit.ForeColor = Color.White
        btnLTEdit.Location = New Point(147, 195)
        btnLTEdit.Name = "btnLTEdit"
        btnLTEdit.Size = New Size(115, 38)
        btnLTEdit.TabIndex = 6
        btnLTEdit.Text = "✏️  Sửa"
        btnLTEdit.UseVisualStyleBackColor = False
        '
        ' btnLTDelete
        '
        btnLTDelete.BackColor = Color.FromArgb(239, 68, 68)
        btnLTDelete.Cursor = Cursors.Hand
        btnLTDelete.FlatAppearance.BorderSize = 0
        btnLTDelete.FlatStyle = FlatStyle.Flat
        btnLTDelete.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnLTDelete.ForeColor = Color.White
        btnLTDelete.Location = New Point(15, 245)
        btnLTDelete.Name = "btnLTDelete"
        btnLTDelete.Size = New Size(115, 38)
        btnLTDelete.TabIndex = 7
        btnLTDelete.Text = "🗑️  Xóa"
        btnLTDelete.UseVisualStyleBackColor = False
        '
        ' btnLTClear
        '
        btnLTClear.BackColor = Color.FromArgb(107, 114, 128)
        btnLTClear.Cursor = Cursors.Hand
        btnLTClear.FlatAppearance.BorderSize = 0
        btnLTClear.FlatStyle = FlatStyle.Flat
        btnLTClear.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnLTClear.ForeColor = Color.White
        btnLTClear.Location = New Point(147, 245)
        btnLTClear.Name = "btnLTClear"
        btnLTClear.Size = New Size(115, 38)
        btnLTClear.TabIndex = 8
        btnLTClear.Text = "🔄  Làm mới"
        btnLTClear.UseVisualStyleBackColor = False
        '
        ' pnlLTGridContainer
        '
        pnlLTGridContainer.BackColor = Color.White
        pnlLTGridContainer.Controls.Add(pnlLTSearch)
        pnlLTGridContainer.Controls.Add(dgvLoaiThe)
        pnlLTGridContainer.Dock = DockStyle.Fill
        pnlLTGridContainer.Location = New Point(294, 5)
        pnlLTGridContainer.Margin = New Padding(5)
        pnlLTGridContainer.Name = "pnlLTGridContainer"
        pnlLTGridContainer.Padding = New Padding(15)
        pnlLTGridContainer.Size = New Size(521, 518)
        pnlLTGridContainer.TabIndex = 1
        '
        ' pnlLTSearch
        '
        pnlLTSearch.Controls.Add(lblLTSearch)
        pnlLTSearch.Controls.Add(txtLTSearch)
        pnlLTSearch.Dock = DockStyle.Top
        pnlLTSearch.Location = New Point(15, 15)
        pnlLTSearch.Name = "pnlLTSearch"
        pnlLTSearch.Size = New Size(491, 40)
        pnlLTSearch.TabIndex = 0
        '
        ' lblLTSearch
        '
        lblLTSearch.AutoSize = True
        lblLTSearch.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblLTSearch.ForeColor = Color.FromArgb(71, 85, 105)
        lblLTSearch.Location = New Point(3, 10)
        lblLTSearch.Name = "lblLTSearch"
        lblLTSearch.Size = New Size(65, 17)
        lblLTSearch.TabIndex = 0
        lblLTSearch.Text = "Tìm kiếm:"
        '
        ' txtLTSearch
        '
        txtLTSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtLTSearch.BorderStyle = BorderStyle.FixedSingle
        txtLTSearch.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtLTSearch.Location = New Point(74, 7)
        txtLTSearch.Name = "txtLTSearch"
        txtLTSearch.PlaceholderText = "Tìm theo tên nhà mạng..."
        txtLTSearch.Size = New Size(414, 25)
        txtLTSearch.TabIndex = 1
        '
        ' dgvLoaiThe
        '
        dgvLoaiThe.AllowUserToAddRows = False
        dgvLoaiThe.AllowUserToDeleteRows = False
        dgvLoaiThe.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvLoaiThe.BackgroundColor = Color.White
        dgvLoaiThe.BorderStyle = BorderStyle.None
        dgvLoaiThe.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvLoaiThe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 23, 42)
        dataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        dataGridViewCellStyle1.ForeColor = Color.White
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(15, 23, 42)
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvLoaiThe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1
        dgvLoaiThe.ColumnHeadersHeight = 35
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        dataGridViewCellStyle2.BackColor = SystemColors.Window
        dataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 65, 85)
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(239, 246, 255)
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 41, 59)
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvLoaiThe.DefaultCellStyle = dataGridViewCellStyle2
        dgvLoaiThe.EnableHeadersVisualStyles = False
        dgvLoaiThe.GridColor = Color.FromArgb(241, 245, 249)
        dgvLoaiThe.Location = New Point(15, 65)
        dgvLoaiThe.Name = "dgvLoaiThe"
        dgvLoaiThe.ReadOnly = True
        dgvLoaiThe.RowHeadersVisible = False
        dgvLoaiThe.RowTemplate.Height = 30
        dgvLoaiThe.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLoaiThe.Size = New Size(491, 438)
        dgvLoaiThe.TabIndex = 1
        '
        ' FormLoaiThe
        '
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(241, 245, 249)
        ClientSize = New Size(850, 618)
        Controls.Add(pnlLTLayout)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormLoaiThe"
        Text = "FormLoaiThe"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlLTLayout.ResumeLayout(False)
        pnlLTForm.ResumeLayout(False)
        pnlLTForm.PerformLayout()
        CType(numLTMenhGia, System.ComponentModel.ISupportInitialize).EndInit()
        pnlLTGridContainer.ResumeLayout(False)
        pnlLTGridContainer.PerformLayout()
        CType(dgvLoaiThe, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Private WithEvents pnlHeader As Panel
    Private WithEvents lblHeaderTitle As Label
    Private WithEvents lblHeaderDesc As Label
    Private WithEvents pnlLTLayout As TableLayoutPanel
    Private WithEvents pnlLTForm As Panel
    Private WithEvents lblLTFormTitle As Label
    Private WithEvents lblLTNhaMang As Label
    Private WithEvents cboLTNhaMang As ComboBox
    Private WithEvents lblLTMenhGia As Label
    Private WithEvents numLTMenhGia As NumericUpDown
    Private WithEvents btnLTAdd As Button
    Private WithEvents btnLTEdit As Button
    Private WithEvents btnLTDelete As Button
    Private WithEvents btnLTClear As Button
    Private WithEvents pnlLTGridContainer As Panel
    Private WithEvents pnlLTSearch As Panel
    Private WithEvents lblLTSearch As Label
    Private WithEvents txtLTSearch As TextBox
    Private WithEvents dgvLoaiThe As DataGridView
End Class
