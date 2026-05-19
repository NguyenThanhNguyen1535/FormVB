<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKhachHang
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
        pnlHeader = New Panel()
        lblHeaderTitle = New Label()
        pnlKHLayout = New TableLayoutPanel()
        pnlKHForm = New Panel()
        lblKHFormTitle = New Label()
        lblKHHoTen = New Label()
        txtKHHoTen = New TextBox()
        lblKHPhone = New Label()
        txtKHPhone = New TextBox()
        lblKHSoDu = New Label()
        numKHSoDu = New NumericUpDown()
        btnKHAdd = New Button()
        btnKHEdit = New Button()
        btnKHDelete = New Button()
        btnKHClear = New Button()
        pnlKHGridContainer = New Panel()
        pnlKHSearch = New Panel()
        lblKHSearch = New Label()
        txtKHSearch = New TextBox()
        dgvKhachHang = New DataGridView()
        pnlHeader.SuspendLayout()
        pnlKHLayout.SuspendLayout()
        pnlKHForm.SuspendLayout()
        CType(numKHSoDu, ComponentModel.ISupportInitialize).BeginInit()
        pnlKHGridContainer.SuspendLayout()
        pnlKHSearch.SuspendLayout()
        CType(dgvKhachHang, ComponentModel.ISupportInitialize).BeginInit()
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
        lblHeaderTitle.Size = New Size(328, 32)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "👥 QUẢN LÝ KHÁCH HÀNG"
        ' 
        ' pnlKHLayout
        ' 
        pnlKHLayout.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlKHLayout.ColumnCount = 2
        pnlKHLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35F))
        pnlKHLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 65F))
        pnlKHLayout.Controls.Add(pnlKHForm, 0, 0)
        pnlKHLayout.Controls.Add(pnlKHGridContainer, 1, 0)
        pnlKHLayout.Location = New Point(15, 75)
        pnlKHLayout.Name = "pnlKHLayout"
        pnlKHLayout.RowCount = 1
        pnlKHLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        pnlKHLayout.Size = New Size(820, 528)
        pnlKHLayout.TabIndex = 1
        ' 
        ' pnlKHForm
        ' 
        pnlKHForm.BackColor = Color.White
        pnlKHForm.Controls.Add(lblKHFormTitle)
        pnlKHForm.Controls.Add(lblKHHoTen)
        pnlKHForm.Controls.Add(txtKHHoTen)
        pnlKHForm.Controls.Add(lblKHPhone)
        pnlKHForm.Controls.Add(txtKHPhone)
        pnlKHForm.Controls.Add(lblKHSoDu)
        pnlKHForm.Controls.Add(numKHSoDu)
        pnlKHForm.Controls.Add(btnKHAdd)
        pnlKHForm.Controls.Add(btnKHEdit)
        pnlKHForm.Controls.Add(btnKHDelete)
        pnlKHForm.Controls.Add(btnKHClear)
        pnlKHForm.Dock = DockStyle.Fill
        pnlKHForm.Location = New Point(5, 5)
        pnlKHForm.Margin = New Padding(5)
        pnlKHForm.Name = "pnlKHForm"
        pnlKHForm.Padding = New Padding(15)
        pnlKHForm.Size = New Size(277, 518)
        pnlKHForm.TabIndex = 0
        ' 
        ' lblKHFormTitle
        ' 
        lblKHFormTitle.AutoSize = True
        lblKHFormTitle.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        lblKHFormTitle.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblKHFormTitle.Location = New Point(15, 10)
        lblKHFormTitle.Name = "lblKHFormTitle"
        lblKHFormTitle.Size = New Size(245, 31)
        lblKHFormTitle.TabIndex = 0
        lblKHFormTitle.Text = "Thông tin Khách Hàng"
        ' 
        ' lblKHHoTen
        ' 
        lblKHHoTen.AutoSize = True
        lblKHHoTen.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblKHHoTen.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblKHHoTen.Location = New Point(15, 55)
        lblKHHoTen.Name = "lblKHHoTen"
        lblKHHoTen.Size = New Size(97, 25)
        lblKHHoTen.TabIndex = 1
        lblKHHoTen.Text = "Họ và Tên:"
        ' 
        ' txtKHHoTen
        ' 
        txtKHHoTen.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtKHHoTen.BorderStyle = BorderStyle.FixedSingle
        txtKHHoTen.Font = New Font("Segoe UI", 9.75F)
        txtKHHoTen.Location = New Point(15, 75)
        txtKHHoTen.Name = "txtKHHoTen"
        txtKHHoTen.Size = New Size(247, 33)
        txtKHHoTen.TabIndex = 2
        ' 
        ' lblKHPhone
        ' 
        lblKHPhone.AutoSize = True
        lblKHPhone.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblKHPhone.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblKHPhone.Location = New Point(15, 115)
        lblKHPhone.Name = "lblKHPhone"
        lblKHPhone.Size = New Size(131, 25)
        lblKHPhone.TabIndex = 3
        lblKHPhone.Text = "Số Điện Thoại:"
        ' 
        ' txtKHPhone
        ' 
        txtKHPhone.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtKHPhone.BorderStyle = BorderStyle.FixedSingle
        txtKHPhone.Font = New Font("Segoe UI", 9.75F)
        txtKHPhone.Location = New Point(15, 135)
        txtKHPhone.Name = "txtKHPhone"
        txtKHPhone.Size = New Size(247, 33)
        txtKHPhone.TabIndex = 4
        ' 
        ' lblKHSoDu
        ' 
        lblKHSoDu.AutoSize = True
        lblKHSoDu.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblKHSoDu.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblKHSoDu.Location = New Point(15, 175)
        lblKHSoDu.Name = "lblKHSoDu"
        lblKHSoDu.Size = New Size(173, 25)
        lblKHSoDu.TabIndex = 5
        lblKHSoDu.Text = "Số dư tài khoản (₫):"
        ' 
        ' numKHSoDu
        ' 
        numKHSoDu.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        numKHSoDu.BorderStyle = BorderStyle.FixedSingle
        numKHSoDu.Font = New Font("Segoe UI", 9.75F)
        numKHSoDu.Location = New Point(15, 195)
        numKHSoDu.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        numKHSoDu.Name = "numKHSoDu"
        numKHSoDu.Size = New Size(247, 33)
        numKHSoDu.TabIndex = 6
        numKHSoDu.ThousandsSeparator = True
        ' 
        ' btnKHAdd
        ' 
        btnKHAdd.BackColor = Color.FromArgb(CByte(16), CByte(185), CByte(129))
        btnKHAdd.Cursor = Cursors.Hand
        btnKHAdd.FlatAppearance.BorderSize = 0
        btnKHAdd.FlatStyle = FlatStyle.Flat
        btnKHAdd.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnKHAdd.ForeColor = Color.White
        btnKHAdd.Location = New Point(15, 250)
        btnKHAdd.Name = "btnKHAdd"
        btnKHAdd.Size = New Size(115, 38)
        btnKHAdd.TabIndex = 7
        btnKHAdd.Text = "➕  Thêm"
        btnKHAdd.UseVisualStyleBackColor = False
        ' 
        ' btnKHEdit
        ' 
        btnKHEdit.BackColor = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        btnKHEdit.Cursor = Cursors.Hand
        btnKHEdit.FlatAppearance.BorderSize = 0
        btnKHEdit.FlatStyle = FlatStyle.Flat
        btnKHEdit.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnKHEdit.ForeColor = Color.White
        btnKHEdit.Location = New Point(147, 250)
        btnKHEdit.Name = "btnKHEdit"
        btnKHEdit.Size = New Size(115, 38)
        btnKHEdit.TabIndex = 8
        btnKHEdit.Text = "✏️  Sửa"
        btnKHEdit.UseVisualStyleBackColor = False
        ' 
        ' btnKHDelete
        ' 
        btnKHDelete.BackColor = Color.FromArgb(CByte(239), CByte(68), CByte(68))
        btnKHDelete.Cursor = Cursors.Hand
        btnKHDelete.FlatAppearance.BorderSize = 0
        btnKHDelete.FlatStyle = FlatStyle.Flat
        btnKHDelete.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnKHDelete.ForeColor = Color.White
        btnKHDelete.Location = New Point(15, 300)
        btnKHDelete.Name = "btnKHDelete"
        btnKHDelete.Size = New Size(115, 38)
        btnKHDelete.TabIndex = 9
        btnKHDelete.Text = "🗑️  Xóa"
        btnKHDelete.UseVisualStyleBackColor = False
        ' 
        ' btnKHClear
        ' 
        btnKHClear.BackColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        btnKHClear.Cursor = Cursors.Hand
        btnKHClear.FlatAppearance.BorderSize = 0
        btnKHClear.FlatStyle = FlatStyle.Flat
        btnKHClear.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnKHClear.ForeColor = Color.White
        btnKHClear.Location = New Point(147, 300)
        btnKHClear.Name = "btnKHClear"
        btnKHClear.Size = New Size(115, 38)
        btnKHClear.TabIndex = 10
        btnKHClear.Text = "🔄  Làm mới"
        btnKHClear.UseVisualStyleBackColor = False
        ' 
        ' pnlKHGridContainer
        ' 
        pnlKHGridContainer.BackColor = Color.White
        pnlKHGridContainer.Controls.Add(pnlKHSearch)
        pnlKHGridContainer.Controls.Add(dgvKhachHang)
        pnlKHGridContainer.Dock = DockStyle.Fill
        pnlKHGridContainer.Location = New Point(292, 5)
        pnlKHGridContainer.Margin = New Padding(5)
        pnlKHGridContainer.Name = "pnlKHGridContainer"
        pnlKHGridContainer.Padding = New Padding(15)
        pnlKHGridContainer.Size = New Size(523, 518)
        pnlKHGridContainer.TabIndex = 1
        ' 
        ' pnlKHSearch
        ' 
        pnlKHSearch.Controls.Add(lblKHSearch)
        pnlKHSearch.Controls.Add(txtKHSearch)
        pnlKHSearch.Dock = DockStyle.Top
        pnlKHSearch.Location = New Point(15, 15)
        pnlKHSearch.Name = "pnlKHSearch"
        pnlKHSearch.Size = New Size(493, 40)
        pnlKHSearch.TabIndex = 0
        ' 
        ' lblKHSearch
        ' 
        lblKHSearch.AutoSize = True
        lblKHSearch.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        lblKHSearch.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblKHSearch.Location = New Point(3, 10)
        lblKHSearch.Name = "lblKHSearch"
        lblKHSearch.Size = New Size(102, 28)
        lblKHSearch.TabIndex = 0
        lblKHSearch.Text = "Tìm kiếm:"
        ' 
        ' txtKHSearch
        ' 
        txtKHSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtKHSearch.BorderStyle = BorderStyle.FixedSingle
        txtKHSearch.Font = New Font("Segoe UI", 9.75F)
        txtKHSearch.Location = New Point(111, 7)
        txtKHSearch.Name = "txtKHSearch"
        txtKHSearch.PlaceholderText = "Nhập tên hoặc số điện thoại để tìm..."
        txtKHSearch.Size = New Size(377, 33)
        txtKHSearch.TabIndex = 1
        ' 
        ' dgvKhachHang
        ' 
        dgvKhachHang.AllowUserToAddRows = False
        dgvKhachHang.AllowUserToDeleteRows = False
        dgvKhachHang.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvKhachHang.BackgroundColor = Color.White
        dgvKhachHang.BorderStyle = BorderStyle.None
        dgvKhachHang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvKhachHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        DataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvKhachHang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvKhachHang.ColumnHeadersHeight = 35
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(239), CByte(246), CByte(255))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvKhachHang.DefaultCellStyle = DataGridViewCellStyle2
        dgvKhachHang.EnableHeadersVisualStyles = False
        dgvKhachHang.GridColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        dgvKhachHang.Location = New Point(15, 65)
        dgvKhachHang.Name = "dgvKhachHang"
        dgvKhachHang.ReadOnly = True
        dgvKhachHang.RowHeadersVisible = False
        dgvKhachHang.RowHeadersWidth = 62
        dgvKhachHang.RowTemplate.Height = 30
        dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvKhachHang.Size = New Size(493, 438)
        dgvKhachHang.TabIndex = 1
        ' 
        ' FormKhachHang
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        ClientSize = New Size(850, 618)
        Controls.Add(pnlKHLayout)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormKhachHang"
        Text = "FormKhachHang"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlKHLayout.ResumeLayout(False)
        pnlKHForm.ResumeLayout(False)
        pnlKHForm.PerformLayout()
        CType(numKHSoDu, ComponentModel.ISupportInitialize).EndInit()
        pnlKHGridContainer.ResumeLayout(False)
        pnlKHSearch.ResumeLayout(False)
        pnlKHSearch.PerformLayout()
        CType(dgvKhachHang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Private WithEvents pnlHeader As Panel
    Private WithEvents lblHeaderTitle As Label
    Private WithEvents pnlKHLayout As TableLayoutPanel
    Private WithEvents pnlKHForm As Panel
    Private WithEvents lblKHFormTitle As Label
    Private WithEvents lblKHHoTen As Label
    Private WithEvents txtKHHoTen As TextBox
    Private WithEvents lblKHPhone As Label
    Private WithEvents txtKHPhone As TextBox
    Private WithEvents lblKHSoDu As Label
    Private WithEvents numKHSoDu As NumericUpDown
    Private WithEvents btnKHAdd As Button
    Private WithEvents btnKHEdit As Button
    Private WithEvents btnKHDelete As Button
    Private WithEvents btnKHClear As Button
    Private WithEvents pnlKHGridContainer As Panel
    Private WithEvents pnlKHSearch As Panel
    Private WithEvents lblKHSearch As Label
    Private WithEvents txtKHSearch As TextBox
    Private WithEvents dgvKhachHang As DataGridView
End Class
