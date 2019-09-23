<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tcMain = New System.Windows.Forms.TabControl()
        Me.tabAccountInfo = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvAccounts = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.lblAccountName = New System.Windows.Forms.Label()
        Me.lblAccountType = New System.Windows.Forms.Label()
        Me.lblAccountNumber = New System.Windows.Forms.Label()
        Me.lblBillingType = New System.Windows.Forms.Label()
        Me.lblContactName = New System.Windows.Forms.Label()
        Me.lblContactBusPhone = New System.Windows.Forms.Label()
        Me.lblContactCellPhone = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblContactStreetAddress = New System.Windows.Forms.Label()
        Me.lblReportingEmail = New System.Windows.Forms.Label()
        Me.lblContactEmail = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.tcMain.SuspendLayout()
        Me.tabAccountInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcMain
        '
        Me.tcMain.Controls.Add(Me.tabAccountInfo)
        Me.tcMain.Controls.Add(Me.TabPage2)
        Me.tcMain.Location = New System.Drawing.Point(12, 12)
        Me.tcMain.Name = "tcMain"
        Me.tcMain.SelectedIndex = 0
        Me.tcMain.Size = New System.Drawing.Size(1167, 445)
        Me.tcMain.TabIndex = 0
        '
        'tabAccountInfo
        '
        Me.tabAccountInfo.Controls.Add(Me.GroupBox1)
        Me.tabAccountInfo.Location = New System.Drawing.Point(4, 22)
        Me.tabAccountInfo.Name = "tabAccountInfo"
        Me.tabAccountInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAccountInfo.Size = New System.Drawing.Size(1159, 419)
        Me.tabAccountInfo.TabIndex = 0
        Me.tabAccountInfo.Text = "Account Info"
        Me.tabAccountInfo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblContactStreetAddress)
        Me.GroupBox1.Controls.Add(Me.lblReportingEmail)
        Me.GroupBox1.Controls.Add(Me.lblContactEmail)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.TextBox11)
        Me.GroupBox1.Controls.Add(Me.TextBox12)
        Me.GroupBox1.Controls.Add(Me.TextBox13)
        Me.GroupBox1.Controls.Add(Me.TextBox14)
        Me.GroupBox1.Controls.Add(Me.lblContactCellPhone)
        Me.GroupBox1.Controls.Add(Me.lblContactBusPhone)
        Me.GroupBox1.Controls.Add(Me.lblContactName)
        Me.GroupBox1.Controls.Add(Me.lblBillingType)
        Me.GroupBox1.Controls.Add(Me.lblAccountNumber)
        Me.GroupBox1.Controls.Add(Me.lblAccountType)
        Me.GroupBox1.Controls.Add(Me.lblAccountName)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.dgvAccounts)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1128, 385)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "View/Add/Edit Accounts"
        '
        'dgvAccounts
        '
        Me.dgvAccounts.AllowUserToAddRows = False
        Me.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccounts.Location = New System.Drawing.Point(120, 37)
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvAccounts.Size = New System.Drawing.Size(645, 150)
        Me.dgvAccounts.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Account:"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(768, 400)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(120, 194)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(260, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(120, 220)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(260, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(120, 246)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(260, 20)
        Me.TextBox3.TabIndex = 5
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(120, 272)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(260, 20)
        Me.TextBox4.TabIndex = 6
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(120, 298)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(260, 20)
        Me.TextBox5.TabIndex = 7
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(120, 324)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(260, 20)
        Me.TextBox6.TabIndex = 8
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(120, 350)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(260, 20)
        Me.TextBox7.TabIndex = 9
        '
        'lblAccountName
        '
        Me.lblAccountName.AutoSize = True
        Me.lblAccountName.Location = New System.Drawing.Point(36, 197)
        Me.lblAccountName.Name = "lblAccountName"
        Me.lblAccountName.Size = New System.Drawing.Size(81, 13)
        Me.lblAccountName.TabIndex = 10
        Me.lblAccountName.Text = "Account Name:"
        '
        'lblAccountType
        '
        Me.lblAccountType.AutoSize = True
        Me.lblAccountType.Location = New System.Drawing.Point(40, 223)
        Me.lblAccountType.Name = "lblAccountType"
        Me.lblAccountType.Size = New System.Drawing.Size(77, 13)
        Me.lblAccountType.TabIndex = 11
        Me.lblAccountType.Text = "Account Type:"
        '
        'lblAccountNumber
        '
        Me.lblAccountNumber.AutoSize = True
        Me.lblAccountNumber.Location = New System.Drawing.Point(27, 249)
        Me.lblAccountNumber.Name = "lblAccountNumber"
        Me.lblAccountNumber.Size = New System.Drawing.Size(90, 13)
        Me.lblAccountNumber.TabIndex = 12
        Me.lblAccountNumber.Text = "Account Number:"
        '
        'lblBillingType
        '
        Me.lblBillingType.AutoSize = True
        Me.lblBillingType.Location = New System.Drawing.Point(53, 275)
        Me.lblBillingType.Name = "lblBillingType"
        Me.lblBillingType.Size = New System.Drawing.Size(64, 13)
        Me.lblBillingType.TabIndex = 13
        Me.lblBillingType.Text = "Billing Type:"
        '
        'lblContactName
        '
        Me.lblContactName.AutoSize = True
        Me.lblContactName.Location = New System.Drawing.Point(39, 301)
        Me.lblContactName.Name = "lblContactName"
        Me.lblContactName.Size = New System.Drawing.Size(78, 13)
        Me.lblContactName.TabIndex = 14
        Me.lblContactName.Text = "Contact Name:"
        '
        'lblContactBusPhone
        '
        Me.lblContactBusPhone.AutoSize = True
        Me.lblContactBusPhone.Location = New System.Drawing.Point(12, 327)
        Me.lblContactBusPhone.Name = "lblContactBusPhone"
        Me.lblContactBusPhone.Size = New System.Drawing.Size(105, 13)
        Me.lblContactBusPhone.TabIndex = 15
        Me.lblContactBusPhone.Text = "Contact Bus. Phone:"
        '
        'lblContactCellPhone
        '
        Me.lblContactCellPhone.AutoSize = True
        Me.lblContactCellPhone.Location = New System.Drawing.Point(13, 353)
        Me.lblContactCellPhone.Name = "lblContactCellPhone"
        Me.lblContactCellPhone.Size = New System.Drawing.Size(101, 13)
        Me.lblContactCellPhone.TabIndex = 16
        Me.lblContactCellPhone.Text = "Contact Cell Phone:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(398, 356)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Contact Cell Phone:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(397, 330)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Contact Bus. Phone:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(424, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Contact Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(438, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Billing Type:"
        '
        'lblContactStreetAddress
        '
        Me.lblContactStreetAddress.AutoSize = True
        Me.lblContactStreetAddress.Location = New System.Drawing.Point(412, 252)
        Me.lblContactStreetAddress.Name = "lblContactStreetAddress"
        Me.lblContactStreetAddress.Size = New System.Drawing.Size(91, 13)
        Me.lblContactStreetAddress.TabIndex = 26
        Me.lblContactStreetAddress.Text = "Contact St. Addr.:"
        '
        'lblReportingEmail
        '
        Me.lblReportingEmail.AutoSize = True
        Me.lblReportingEmail.Location = New System.Drawing.Point(419, 226)
        Me.lblReportingEmail.Name = "lblReportingEmail"
        Me.lblReportingEmail.Size = New System.Drawing.Size(84, 13)
        Me.lblReportingEmail.TabIndex = 25
        Me.lblReportingEmail.Text = "Reporting Email:"
        '
        'lblContactEmail
        '
        Me.lblContactEmail.AutoSize = True
        Me.lblContactEmail.Location = New System.Drawing.Point(421, 200)
        Me.lblContactEmail.Name = "lblContactEmail"
        Me.lblContactEmail.Size = New System.Drawing.Size(75, 13)
        Me.lblContactEmail.TabIndex = 24
        Me.lblContactEmail.Text = "Contact Email:"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(505, 353)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(260, 20)
        Me.TextBox8.TabIndex = 23
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(505, 327)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(260, 20)
        Me.TextBox9.TabIndex = 22
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(505, 301)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(260, 20)
        Me.TextBox10.TabIndex = 21
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(505, 275)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(260, 20)
        Me.TextBox11.TabIndex = 20
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(505, 249)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(260, 20)
        Me.TextBox12.TabIndex = 19
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(505, 223)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(260, 20)
        Me.TextBox13.TabIndex = 18
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(505, 197)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(260, 20)
        Me.TextBox14.TabIndex = 17
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 476)
        Me.Controls.Add(Me.tcMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Account Management"
        Me.tcMain.ResumeLayout(False)
        Me.tabAccountInfo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcMain As TabControl
    Friend WithEvents tabAccountInfo As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvAccounts As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblContactStreetAddress As Label
    Friend WithEvents lblReportingEmail As Label
    Friend WithEvents lblContactEmail As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents lblContactCellPhone As Label
    Friend WithEvents lblContactBusPhone As Label
    Friend WithEvents lblContactName As Label
    Friend WithEvents lblBillingType As Label
    Friend WithEvents lblAccountNumber As Label
    Friend WithEvents lblAccountType As Label
    Friend WithEvents lblAccountName As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
