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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlHeader = New Panel()
        lblHeaderTitle = New Label()
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
        CType(numLTMenhGia, ComponentModel.ISupportInitialize).BeginInit()
        pnlLTGridContainer.SuspendLayout()
        pnlLTSearch.SuspendLayout()
        CType(dgvLoaiThe, ComponentModel.ISupportInitialize).BeginInit()
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
        lblHeaderTitle.Size = New Size(272, 32)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "💳 QUẢN LÝ LOẠI THẺ"
        ' 
        ' pnlLTLayout
        ' 
        pnlLTLayout.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlLTLayout.ColumnCount = 2
        pnlLTLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35F))
        pnlLTLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 65F))
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
        lblLTFormTitle.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        lblLTFormTitle.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblLTFormTitle.Location = New Point(15, 10)
        lblLTFormTitle.Name = "lblLTFormTitle"
        lblLTFormTitle.Size = New Size(207, 31)
        lblLTFormTitle.TabIndex = 0
        lblLTFormTitle.Text = "Thông tin Loại Thẻ"
        ' 
        ' lblLTNhaMang
        ' 
        lblLTNhaMang.AutoSize = True
        lblLTNhaMang.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblLTNhaMang.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblLTNhaMang.Location = New Point(15, 55)
        lblLTNhaMang.Name = "lblLTNhaMang"
        lblLTNhaMang.Size = New Size(101, 25)
        lblLTNhaMang.TabIndex = 1
        lblLTNhaMang.Text = "Nhà mạng:"
        ' 
        ' cboLTNhaMang
        ' 
        cboLTNhaMang.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cboLTNhaMang.DropDownStyle = ComboBoxStyle.DropDownList
        cboLTNhaMang.Font = New Font("Segoe UI", 9.75F)
        cboLTNhaMang.FormattingEnabled = True
        cboLTNhaMang.Items.AddRange(New Object() {"Viettel", "Mobifone", "Vinaphone", "Vietnamobile", "Gmobile"})
        cboLTNhaMang.Location = New Point(15, 75)
        cboLTNhaMang.Name = "cboLTNhaMang"
        cboLTNhaMang.Size = New Size(247, 36)
        cboLTNhaMang.TabIndex = 2
        ' 
        ' lblLTMenhGia
        ' 
        lblLTMenhGia.AutoSize = True
        lblLTMenhGia.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblLTMenhGia.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblLTMenhGia.Location = New Point(15, 115)
        lblLTMenhGia.Name = "lblLTMenhGia"
        lblLTMenhGia.Size = New Size(122, 25)
        lblLTMenhGia.TabIndex = 3
        lblLTMenhGia.Text = "Mệnh giá (₫):"
        ' 
        ' numLTMenhGia
        ' 
        numLTMenhGia.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        numLTMenhGia.BorderStyle = BorderStyle.FixedSingle
        numLTMenhGia.Font = New Font("Segoe UI", 9.75F)
        numLTMenhGia.Increment = New Decimal(New Integer() {10000, 0, 0, 0})
        numLTMenhGia.Location = New Point(15, 135)
        numLTMenhGia.Maximum = New Decimal(New Integer() {2000000, 0, 0, 0})
        numLTMenhGia.Name = "numLTMenhGia"
        numLTMenhGia.Size = New Size(247, 33)
        numLTMenhGia.TabIndex = 4
        numLTMenhGia.ThousandsSeparator = True
        ' 
        ' btnLTAdd
        ' 
        btnLTAdd.BackColor = Color.FromArgb(CByte(16), CByte(185), CByte(129))
        btnLTAdd.Cursor = Cursors.Hand
        btnLTAdd.FlatAppearance.BorderSize = 0
        btnLTAdd.FlatStyle = FlatStyle.Flat
        btnLTAdd.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
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
        btnLTEdit.BackColor = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        btnLTEdit.Cursor = Cursors.Hand
        btnLTEdit.FlatAppearance.BorderSize = 0
        btnLTEdit.FlatStyle = FlatStyle.Flat
        btnLTEdit.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
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
        btnLTDelete.BackColor = Color.FromArgb(CByte(239), CByte(68), CByte(68))
        btnLTDelete.Cursor = Cursors.Hand
        btnLTDelete.FlatAppearance.BorderSize = 0
        btnLTDelete.FlatStyle = FlatStyle.Flat
        btnLTDelete.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
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
        btnLTClear.BackColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        btnLTClear.Cursor = Cursors.Hand
        btnLTClear.FlatAppearance.BorderSize = 0
        btnLTClear.FlatStyle = FlatStyle.Flat
        btnLTClear.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
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
        pnlLTGridContainer.Location = New Point(292, 5)
        pnlLTGridContainer.Margin = New Padding(5)
        pnlLTGridContainer.Name = "pnlLTGridContainer"
        pnlLTGridContainer.Padding = New Padding(15)
        pnlLTGridContainer.Size = New Size(523, 518)
        pnlLTGridContainer.TabIndex = 1
        ' 
        ' pnlLTSearch
        ' 
        pnlLTSearch.Controls.Add(lblLTSearch)
        pnlLTSearch.Controls.Add(txtLTSearch)
        pnlLTSearch.Dock = DockStyle.Top
        pnlLTSearch.Location = New Point(15, 15)
        pnlLTSearch.Name = "pnlLTSearch"
        pnlLTSearch.Size = New Size(493, 40)
        pnlLTSearch.TabIndex = 0
        ' 
        ' lblLTSearch
        ' 
        lblLTSearch.AutoSize = True
        lblLTSearch.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        lblLTSearch.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblLTSearch.Location = New Point(3, 10)
        lblLTSearch.Name = "lblLTSearch"
        lblLTSearch.Size = New Size(102, 28)
        lblLTSearch.TabIndex = 0
        lblLTSearch.Text = "Tìm kiếm:"
        ' 
        ' txtLTSearch
        ' 
        txtLTSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtLTSearch.BorderStyle = BorderStyle.FixedSingle
        txtLTSearch.Font = New Font("Segoe UI", 9.75F)
        txtLTSearch.Location = New Point(111, 7)
        txtLTSearch.Name = "txtLTSearch"
        txtLTSearch.PlaceholderText = "Tìm theo tên nhà mạng..."
        txtLTSearch.Size = New Size(377, 33)
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
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        DataGridViewCellStyle3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvLoaiThe.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvLoaiThe.ColumnHeadersHeight = 35
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Window
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(239), CByte(246), CByte(255))
        DataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        dgvLoaiThe.DefaultCellStyle = DataGridViewCellStyle4
        dgvLoaiThe.EnableHeadersVisualStyles = False
        dgvLoaiThe.GridColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        dgvLoaiThe.Location = New Point(15, 65)
        dgvLoaiThe.Name = "dgvLoaiThe"
        dgvLoaiThe.ReadOnly = True
        dgvLoaiThe.RowHeadersVisible = False
        dgvLoaiThe.RowHeadersWidth = 62
        dgvLoaiThe.RowTemplate.Height = 30
        dgvLoaiThe.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLoaiThe.Size = New Size(493, 438)
        dgvLoaiThe.TabIndex = 1
        ' 
        ' FormLoaiThe
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        ClientSize = New Size(850, 618)
        Controls.Add(pnlLTLayout)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormLoaiThe"
        Text = "FormLoaiThe"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlLTLayout.ResumeLayout(False)
        pnlLTForm.ResumeLayout(False)
        pnlLTForm.PerformLayout()
        CType(numLTMenhGia, ComponentModel.ISupportInitialize).EndInit()
        pnlLTGridContainer.ResumeLayout(False)
        pnlLTSearch.ResumeLayout(False)
        pnlLTSearch.PerformLayout()
        CType(dgvLoaiThe, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Private WithEvents pnlHeader As Panel
    Private WithEvents lblHeaderTitle As Label
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
