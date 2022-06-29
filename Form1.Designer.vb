<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HospitalsAmbulanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoliceStationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FireServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BloodDonorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactDeveloperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_fire_form = New System.Windows.Forms.Button()
        Me.btn_hospital_form = New System.Windows.Forms.Button()
        Me.button_blood_form = New System.Windows.Forms.Button()
        Me.btn_police_form = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(0, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1127, 86)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Emergency Services"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplicationToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1127, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "Menu"
        '
        'ApplicationToolStripMenuItem
        '
        Me.ApplicationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HospitalsAmbulanceToolStripMenuItem, Me.PoliceStationsToolStripMenuItem, Me.FireServiceToolStripMenuItem, Me.BloodDonorsToolStripMenuItem})
        Me.ApplicationToolStripMenuItem.Name = "ApplicationToolStripMenuItem"
        Me.ApplicationToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ApplicationToolStripMenuItem.Text = "Services"
        '
        'HospitalsAmbulanceToolStripMenuItem
        '
        Me.HospitalsAmbulanceToolStripMenuItem.Name = "HospitalsAmbulanceToolStripMenuItem"
        Me.HospitalsAmbulanceToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.HospitalsAmbulanceToolStripMenuItem.Text = "Hospitals and Ambulance"
        '
        'PoliceStationsToolStripMenuItem
        '
        Me.PoliceStationsToolStripMenuItem.Name = "PoliceStationsToolStripMenuItem"
        Me.PoliceStationsToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.PoliceStationsToolStripMenuItem.Text = "Police Stations"
        '
        'FireServiceToolStripMenuItem
        '
        Me.FireServiceToolStripMenuItem.Name = "FireServiceToolStripMenuItem"
        Me.FireServiceToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.FireServiceToolStripMenuItem.Text = "Fire Service"
        '
        'BloodDonorsToolStripMenuItem
        '
        Me.BloodDonorsToolStripMenuItem.Name = "BloodDonorsToolStripMenuItem"
        Me.BloodDonorsToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.BloodDonorsToolStripMenuItem.Text = "Blood Donors"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContactDeveloperToolStripMenuItem, Me.AboutAppToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ContactDeveloperToolStripMenuItem
        '
        Me.ContactDeveloperToolStripMenuItem.Name = "ContactDeveloperToolStripMenuItem"
        Me.ContactDeveloperToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ContactDeveloperToolStripMenuItem.Text = "Contact Developer team"
        '
        'AboutAppToolStripMenuItem
        '
        Me.AboutAppToolStripMenuItem.Name = "AboutAppToolStripMenuItem"
        Me.AboutAppToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.AboutAppToolStripMenuItem.Text = "About app"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_fire_form, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_hospital_form, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.button_blood_form, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_police_form, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 110)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1127, 412)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'btn_fire_form
        '
        Me.btn_fire_form.BackColor = System.Drawing.Color.FloralWhite
        Me.btn_fire_form.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_fire_form.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_fire_form.FlatAppearance.BorderSize = 0
        Me.btn_fire_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fire_form.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_fire_form.Image = Global.Emergency_Services.My.Resources.Resources.icons8_fire_96px
        Me.btn_fire_form.Location = New System.Drawing.Point(566, 209)
        Me.btn_fire_form.Name = "btn_fire_form"
        Me.btn_fire_form.Padding = New System.Windows.Forms.Padding(10)
        Me.btn_fire_form.Size = New System.Drawing.Size(200, 195)
        Me.btn_fire_form.TabIndex = 3
        Me.btn_fire_form.Text = "Fire Services"
        Me.btn_fire_form.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_fire_form.UseVisualStyleBackColor = False
        '
        'btn_hospital_form
        '
        Me.btn_hospital_form.BackColor = System.Drawing.Color.FloralWhite
        Me.btn_hospital_form.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_hospital_form.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_hospital_form.FlatAppearance.BorderSize = 0
        Me.btn_hospital_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_hospital_form.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_hospital_form.Image = Global.Emergency_Services.My.Resources.Resources.icons8_hospital_96px
        Me.btn_hospital_form.Location = New System.Drawing.Point(360, 209)
        Me.btn_hospital_form.Name = "btn_hospital_form"
        Me.btn_hospital_form.Padding = New System.Windows.Forms.Padding(10)
        Me.btn_hospital_form.Size = New System.Drawing.Size(200, 195)
        Me.btn_hospital_form.TabIndex = 1
        Me.btn_hospital_form.Text = "Hospitals"
        Me.btn_hospital_form.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_hospital_form.UseVisualStyleBackColor = False
        '
        'button_blood_form
        '
        Me.button_blood_form.BackColor = System.Drawing.Color.FloralWhite
        Me.button_blood_form.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_blood_form.Dock = System.Windows.Forms.DockStyle.Right
        Me.button_blood_form.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.button_blood_form.FlatAppearance.BorderSize = 0
        Me.button_blood_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_blood_form.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.button_blood_form.Image = Global.Emergency_Services.My.Resources.Resources.icons8_drop_of_blood_96px_1
        Me.button_blood_form.Location = New System.Drawing.Point(360, 8)
        Me.button_blood_form.Name = "button_blood_form"
        Me.button_blood_form.Padding = New System.Windows.Forms.Padding(10)
        Me.button_blood_form.Size = New System.Drawing.Size(200, 195)
        Me.button_blood_form.TabIndex = 0
        Me.button_blood_form.Text = "Blood Donors"
        Me.button_blood_form.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.button_blood_form.UseVisualStyleBackColor = False
        '
        'btn_police_form
        '
        Me.btn_police_form.BackColor = System.Drawing.Color.FloralWhite
        Me.btn_police_form.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_police_form.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_police_form.FlatAppearance.BorderSize = 0
        Me.btn_police_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_police_form.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_police_form.Image = Global.Emergency_Services.My.Resources.Resources.icons8_police_96px
        Me.btn_police_form.Location = New System.Drawing.Point(566, 8)
        Me.btn_police_form.Name = "btn_police_form"
        Me.btn_police_form.Padding = New System.Windows.Forms.Padding(10)
        Me.btn_police_form.Size = New System.Drawing.Size(200, 195)
        Me.btn_police_form.TabIndex = 2
        Me.btn_police_form.Text = "Police"
        Me.btn_police_form.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_police_form.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 611)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(1143, 650)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emergency Services"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HospitalsAmbulanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PoliceStationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FireServiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BloodDonorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactDeveloperToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutAppToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents button_blood_form As Button
    Friend WithEvents btn_fire_form As Button
    Friend WithEvents btn_hospital_form As Button
    Friend WithEvents btn_police_form As Button
End Class
