<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bloodForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchContainer = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.bloodGroupBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.areaBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cityBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.divisonBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.loaderPanel = New System.Windows.Forms.Panel()
        Me.loadingGif = New System.Windows.Forms.PictureBox()
        Me.bloodDonorTable = New System.Windows.Forms.DataGridView()
        Me.nameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bloodCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.divCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cityCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.areaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.addressCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phoneCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.searchContainer.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.loaderPanel.SuspendLayout()
        CType(Me.loadingGif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bloodDonorTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = Global.Emergency_Services.My.Resources.Resources.icons8_drop_of_blood_96px_1
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1127, 88)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Look for blood donors around you"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'searchContainer
        '
        Me.searchContainer.BackColor = System.Drawing.SystemColors.Control
        Me.searchContainer.Controls.Add(Me.Panel6)
        Me.searchContainer.Controls.Add(Me.Panel5)
        Me.searchContainer.Controls.Add(Me.Panel4)
        Me.searchContainer.Controls.Add(Me.Panel3)
        Me.searchContainer.Controls.Add(Me.Panel1)
        Me.searchContainer.Dock = System.Windows.Forms.DockStyle.Top
        Me.searchContainer.Location = New System.Drawing.Point(0, 88)
        Me.searchContainer.Name = "searchContainer"
        Me.searchContainer.Size = New System.Drawing.Size(1127, 81)
        Me.searchContainer.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.bloodGroupBox)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(891, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(10, 15, 15, 10)
        Me.Panel6.Size = New System.Drawing.Size(236, 81)
        Me.Panel6.TabIndex = 3
        '
        'bloodGroupBox
        '
        Me.bloodGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bloodGroupBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bloodGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bloodGroupBox.FormattingEnabled = True
        Me.bloodGroupBox.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"})
        Me.bloodGroupBox.Location = New System.Drawing.Point(10, 48)
        Me.bloodGroupBox.Name = "bloodGroupBox"
        Me.bloodGroupBox.Size = New System.Drawing.Size(211, 23)
        Me.bloodGroupBox.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(10, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Blood Group"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.areaBox)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(630, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(10, 15, 15, 10)
        Me.Panel5.Size = New System.Drawing.Size(261, 81)
        Me.Panel5.TabIndex = 2
        '
        'areaBox
        '
        Me.areaBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.areaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.areaBox.Enabled = False
        Me.areaBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.areaBox.FormattingEnabled = True
        Me.areaBox.Items.AddRange(New Object() {"Dhaka", "Rajshahi", "Khulna"})
        Me.areaBox.Location = New System.Drawing.Point(10, 48)
        Me.areaBox.Name = "areaBox"
        Me.areaBox.Size = New System.Drawing.Size(236, 23)
        Me.areaBox.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(10, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Choose Area"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.cityBox)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(315, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(10, 15, 15, 10)
        Me.Panel4.Size = New System.Drawing.Size(315, 81)
        Me.Panel4.TabIndex = 2
        '
        'cityBox
        '
        Me.cityBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cityBox.Enabled = False
        Me.cityBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cityBox.FormattingEnabled = True
        Me.cityBox.Items.AddRange(New Object() {"Dhaka", "Rajshahi", "Khulna"})
        Me.cityBox.Location = New System.Drawing.Point(10, 48)
        Me.cityBox.Name = "cityBox"
        Me.cityBox.Size = New System.Drawing.Size(290, 23)
        Me.cityBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(10, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Choose City"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.divisonBox)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(10, 15, 15, 10)
        Me.Panel3.Size = New System.Drawing.Size(315, 81)
        Me.Panel3.TabIndex = 1
        '
        'divisonBox
        '
        Me.divisonBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.divisonBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.divisonBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.divisonBox.FormattingEnabled = True
        Me.divisonBox.ItemHeight = 15
        Me.divisonBox.Location = New System.Drawing.Point(10, 48)
        Me.divisonBox.Name = "divisonBox"
        Me.divisonBox.Size = New System.Drawing.Size(290, 23)
        Me.divisonBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(10, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Choose Division"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(776, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(8, 8)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel2.Controls.Add(Me.loaderPanel)
        Me.Panel2.Controls.Add(Me.bloodDonorTable)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 169)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1127, 442)
        Me.Panel2.TabIndex = 2
        '
        'loaderPanel
        '
        Me.loaderPanel.BackColor = System.Drawing.Color.White
        Me.loaderPanel.Controls.Add(Me.loadingGif)
        Me.loaderPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.loaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.loaderPanel.Name = "loaderPanel"
        Me.loaderPanel.Size = New System.Drawing.Size(1127, 442)
        Me.loaderPanel.TabIndex = 1
        Me.loaderPanel.Visible = False
        '
        'loadingGif
        '
        Me.loadingGif.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.loadingGif.Image = Global.Emergency_Services.My.Resources.Resources.Rolling_1s_200px__1_
        Me.loadingGif.Location = New System.Drawing.Point(515, 161)
        Me.loadingGif.Name = "loadingGif"
        Me.loadingGif.Size = New System.Drawing.Size(100, 100)
        Me.loadingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.loadingGif.TabIndex = 0
        Me.loadingGif.TabStop = False
        '
        'bloodDonorTable
        '
        Me.bloodDonorTable.ColumnHeadersHeight = 40
        Me.bloodDonorTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.bloodDonorTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nameCol, Me.bloodCol, Me.divCol, Me.cityCol, Me.areaCol, Me.addressCol, Me.phoneCol})
        Me.bloodDonorTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bloodDonorTable.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.bloodDonorTable.Location = New System.Drawing.Point(0, 0)
        Me.bloodDonorTable.Name = "bloodDonorTable"
        Me.bloodDonorTable.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.bloodDonorTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.bloodDonorTable.RowHeadersVisible = False
        Me.bloodDonorTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.bloodDonorTable.RowTemplate.Height = 40
        Me.bloodDonorTable.RowTemplate.ReadOnly = True
        Me.bloodDonorTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.bloodDonorTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.bloodDonorTable.Size = New System.Drawing.Size(1127, 442)
        Me.bloodDonorTable.TabIndex = 0
        '
        'nameCol
        '
        Me.nameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nameCol.HeaderText = "Donor Name"
        Me.nameCol.Name = "nameCol"
        Me.nameCol.ReadOnly = True
        '
        'bloodCol
        '
        Me.bloodCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.bloodCol.DefaultCellStyle = DataGridViewCellStyle1
        Me.bloodCol.HeaderText = "Blood Group"
        Me.bloodCol.Name = "bloodCol"
        Me.bloodCol.ReadOnly = True
        '
        'divCol
        '
        Me.divCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.divCol.HeaderText = "Division"
        Me.divCol.Name = "divCol"
        Me.divCol.ReadOnly = True
        '
        'cityCol
        '
        Me.cityCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cityCol.HeaderText = "City"
        Me.cityCol.Name = "cityCol"
        Me.cityCol.ReadOnly = True
        '
        'areaCol
        '
        Me.areaCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.areaCol.HeaderText = "Area"
        Me.areaCol.Name = "areaCol"
        Me.areaCol.ReadOnly = True
        '
        'addressCol
        '
        Me.addressCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.addressCol.HeaderText = "Full Address"
        Me.addressCol.Name = "addressCol"
        Me.addressCol.ReadOnly = True
        '
        'phoneCol
        '
        Me.phoneCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.phoneCol.HeaderText = "Phone"
        Me.phoneCol.Name = "phoneCol"
        Me.phoneCol.ReadOnly = True
        '
        'bloodForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 611)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.searchContainer)
        Me.Controls.Add(Me.Label1)
        Me.Name = "bloodForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blood donors across whole country"
        Me.searchContainer.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.loaderPanel.ResumeLayout(False)
        CType(Me.loadingGif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bloodDonorTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents searchContainer As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents divisonBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents areaBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cityBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents bloodDonorTable As DataGridView
    Friend WithEvents nameCol As DataGridViewTextBoxColumn
    Friend WithEvents bloodCol As DataGridViewTextBoxColumn
    Friend WithEvents divCol As DataGridViewTextBoxColumn
    Friend WithEvents cityCol As DataGridViewTextBoxColumn
    Friend WithEvents areaCol As DataGridViewTextBoxColumn
    Friend WithEvents addressCol As DataGridViewTextBoxColumn
    Friend WithEvents phoneCol As DataGridViewTextBoxColumn
    Friend WithEvents Panel6 As Panel
    Friend WithEvents bloodGroupBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents loaderPanel As Panel
    Friend WithEvents loadingGif As PictureBox
End Class
