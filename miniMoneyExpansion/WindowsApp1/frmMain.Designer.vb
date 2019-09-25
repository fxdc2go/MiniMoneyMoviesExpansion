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
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.lblActive = New System.Windows.Forms.Label()
        Me.lblCreatedDate = New System.Windows.Forms.Label()
        Me.lblSalesContact = New System.Windows.Forms.Label()
        Me.txtCreatedDate = New System.Windows.Forms.TextBox()
        Me.txtSalesContact = New System.Windows.Forms.TextBox()
        Me.lblContactZip = New System.Windows.Forms.Label()
        Me.lblContactStateAbbr = New System.Windows.Forms.Label()
        Me.lblContactCity = New System.Windows.Forms.Label()
        Me.lblContactStreetAddress = New System.Windows.Forms.Label()
        Me.lblReportingEmail = New System.Windows.Forms.Label()
        Me.lblContactEmail = New System.Windows.Forms.Label()
        Me.txtContactZip = New System.Windows.Forms.TextBox()
        Me.txtContactStateAbbr = New System.Windows.Forms.TextBox()
        Me.txtContactCity = New System.Windows.Forms.TextBox()
        Me.txtContactStreetAddress = New System.Windows.Forms.TextBox()
        Me.txtReportingEmail = New System.Windows.Forms.TextBox()
        Me.txtContactEmail = New System.Windows.Forms.TextBox()
        Me.lblContactCellPhone = New System.Windows.Forms.Label()
        Me.lblContactBusPhone = New System.Windows.Forms.Label()
        Me.lblContactName = New System.Windows.Forms.Label()
        Me.lblBillingType = New System.Windows.Forms.Label()
        Me.lblAccountNumber = New System.Windows.Forms.Label()
        Me.lblAccountType = New System.Windows.Forms.Label()
        Me.lblAccountName = New System.Windows.Forms.Label()
        Me.txtContactCellPhone = New System.Windows.Forms.TextBox()
        Me.txtContactBusPhone = New System.Windows.Forms.TextBox()
        Me.txtContactName = New System.Windows.Forms.TextBox()
        Me.txtBillingType = New System.Windows.Forms.TextBox()
        Me.txtAccountNumber = New System.Windows.Forms.TextBox()
        Me.txtAccountType = New System.Windows.Forms.TextBox()
        Me.txtAccountName = New System.Windows.Forms.TextBox()
        Me.dgvAccounts = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabAccessCodes = New System.Windows.Forms.TabPage()
        Me.tabAccountReports = New System.Windows.Forms.TabPage()
        Me.tabAccountBilling = New System.Windows.Forms.TabPage()
        Me.tabGenMonthlyBilling = New System.Windows.Forms.TabPage()
        Me.tabGenMonthlyReports = New System.Windows.Forms.TabPage()
        Me.tabManageUsers = New System.Windows.Forms.TabPage()
        Me.llEdit = New System.Windows.Forms.LinkLabel()
        Me.llSaveAccount = New System.Windows.Forms.LinkLabel()
        Me.llNewAccount = New System.Windows.Forms.LinkLabel()
        Me.llExit = New System.Windows.Forms.LinkLabel()
        Me.tcMain.SuspendLayout()
        Me.tabAccountInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcMain
        '
        Me.tcMain.Controls.Add(Me.tabAccountInfo)
        Me.tcMain.Controls.Add(Me.tabAccessCodes)
        Me.tcMain.Controls.Add(Me.tabAccountReports)
        Me.tcMain.Controls.Add(Me.tabAccountBilling)
        Me.tcMain.Controls.Add(Me.tabGenMonthlyBilling)
        Me.tcMain.Controls.Add(Me.tabGenMonthlyReports)
        Me.tcMain.Controls.Add(Me.tabManageUsers)
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
        Me.GroupBox1.Controls.Add(Me.llExit)
        Me.GroupBox1.Controls.Add(Me.llNewAccount)
        Me.GroupBox1.Controls.Add(Me.llSaveAccount)
        Me.GroupBox1.Controls.Add(Me.llEdit)
        Me.GroupBox1.Controls.Add(Me.chkActive)
        Me.GroupBox1.Controls.Add(Me.lblActive)
        Me.GroupBox1.Controls.Add(Me.lblCreatedDate)
        Me.GroupBox1.Controls.Add(Me.lblSalesContact)
        Me.GroupBox1.Controls.Add(Me.txtCreatedDate)
        Me.GroupBox1.Controls.Add(Me.txtSalesContact)
        Me.GroupBox1.Controls.Add(Me.lblContactZip)
        Me.GroupBox1.Controls.Add(Me.lblContactStateAbbr)
        Me.GroupBox1.Controls.Add(Me.lblContactCity)
        Me.GroupBox1.Controls.Add(Me.lblContactStreetAddress)
        Me.GroupBox1.Controls.Add(Me.lblReportingEmail)
        Me.GroupBox1.Controls.Add(Me.lblContactEmail)
        Me.GroupBox1.Controls.Add(Me.txtContactZip)
        Me.GroupBox1.Controls.Add(Me.txtContactStateAbbr)
        Me.GroupBox1.Controls.Add(Me.txtContactCity)
        Me.GroupBox1.Controls.Add(Me.txtContactStreetAddress)
        Me.GroupBox1.Controls.Add(Me.txtReportingEmail)
        Me.GroupBox1.Controls.Add(Me.txtContactEmail)
        Me.GroupBox1.Controls.Add(Me.lblContactCellPhone)
        Me.GroupBox1.Controls.Add(Me.lblContactBusPhone)
        Me.GroupBox1.Controls.Add(Me.lblContactName)
        Me.GroupBox1.Controls.Add(Me.lblBillingType)
        Me.GroupBox1.Controls.Add(Me.lblAccountNumber)
        Me.GroupBox1.Controls.Add(Me.lblAccountType)
        Me.GroupBox1.Controls.Add(Me.lblAccountName)
        Me.GroupBox1.Controls.Add(Me.txtContactCellPhone)
        Me.GroupBox1.Controls.Add(Me.txtContactBusPhone)
        Me.GroupBox1.Controls.Add(Me.txtContactName)
        Me.GroupBox1.Controls.Add(Me.txtBillingType)
        Me.GroupBox1.Controls.Add(Me.txtAccountNumber)
        Me.GroupBox1.Controls.Add(Me.txtAccountType)
        Me.GroupBox1.Controls.Add(Me.txtAccountName)
        Me.GroupBox1.Controls.Add(Me.dgvAccounts)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1128, 385)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "View/Add/Edit Accounts"
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Location = New System.Drawing.Point(862, 226)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(15, 14)
        Me.chkActive.TabIndex = 38
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'lblActive
        '
        Me.lblActive.AutoSize = True
        Me.lblActive.Location = New System.Drawing.Point(773, 226)
        Me.lblActive.Name = "lblActive"
        Me.lblActive.Size = New System.Drawing.Size(86, 13)
        Me.lblActive.TabIndex = 37
        Me.lblActive.Text = "Active Account.:"
        '
        'lblCreatedDate
        '
        Me.lblCreatedDate.AutoSize = True
        Me.lblCreatedDate.Location = New System.Drawing.Point(786, 200)
        Me.lblCreatedDate.Name = "lblCreatedDate"
        Me.lblCreatedDate.Size = New System.Drawing.Size(73, 13)
        Me.lblCreatedDate.TabIndex = 36
        Me.lblCreatedDate.Text = "Created Date:"
        '
        'lblSalesContact
        '
        Me.lblSalesContact.AutoSize = True
        Me.lblSalesContact.Location = New System.Drawing.Point(426, 356)
        Me.lblSalesContact.Name = "lblSalesContact"
        Me.lblSalesContact.Size = New System.Drawing.Size(76, 13)
        Me.lblSalesContact.TabIndex = 35
        Me.lblSalesContact.Text = "Sales Contact:"
        '
        'txtCreatedDate
        '
        Me.txtCreatedDate.Location = New System.Drawing.Point(862, 197)
        Me.txtCreatedDate.Name = "txtCreatedDate"
        Me.txtCreatedDate.Size = New System.Drawing.Size(260, 20)
        Me.txtCreatedDate.TabIndex = 32
        '
        'txtSalesContact
        '
        Me.txtSalesContact.Location = New System.Drawing.Point(505, 353)
        Me.txtSalesContact.Name = "txtSalesContact"
        Me.txtSalesContact.Size = New System.Drawing.Size(260, 20)
        Me.txtSalesContact.TabIndex = 31
        '
        'lblContactZip
        '
        Me.lblContactZip.AutoSize = True
        Me.lblContactZip.Location = New System.Drawing.Point(436, 330)
        Me.lblContactZip.Name = "lblContactZip"
        Me.lblContactZip.Size = New System.Drawing.Size(65, 13)
        Me.lblContactZip.TabIndex = 30
        Me.lblContactZip.Text = "Contact Zip:"
        '
        'lblContactStateAbbr
        '
        Me.lblContactStateAbbr.AutoSize = True
        Me.lblContactStateAbbr.Location = New System.Drawing.Point(398, 304)
        Me.lblContactStateAbbr.Name = "lblContactStateAbbr"
        Me.lblContactStateAbbr.Size = New System.Drawing.Size(103, 13)
        Me.lblContactStateAbbr.TabIndex = 29
        Me.lblContactStateAbbr.Text = "Contact State Abbr.:"
        '
        'lblContactCity
        '
        Me.lblContactCity.AutoSize = True
        Me.lblContactCity.Location = New System.Drawing.Point(434, 277)
        Me.lblContactCity.Name = "lblContactCity"
        Me.lblContactCity.Size = New System.Drawing.Size(67, 13)
        Me.lblContactCity.TabIndex = 27
        Me.lblContactCity.Text = "Contact City:"
        '
        'lblContactStreetAddress
        '
        Me.lblContactStreetAddress.AutoSize = True
        Me.lblContactStreetAddress.Location = New System.Drawing.Point(410, 251)
        Me.lblContactStreetAddress.Name = "lblContactStreetAddress"
        Me.lblContactStreetAddress.Size = New System.Drawing.Size(91, 13)
        Me.lblContactStreetAddress.TabIndex = 26
        Me.lblContactStreetAddress.Text = "Contact St. Addr.:"
        '
        'lblReportingEmail
        '
        Me.lblReportingEmail.AutoSize = True
        Me.lblReportingEmail.Location = New System.Drawing.Point(417, 225)
        Me.lblReportingEmail.Name = "lblReportingEmail"
        Me.lblReportingEmail.Size = New System.Drawing.Size(84, 13)
        Me.lblReportingEmail.TabIndex = 25
        Me.lblReportingEmail.Text = "Reporting Email:"
        '
        'lblContactEmail
        '
        Me.lblContactEmail.AutoSize = True
        Me.lblContactEmail.Location = New System.Drawing.Point(426, 199)
        Me.lblContactEmail.Name = "lblContactEmail"
        Me.lblContactEmail.Size = New System.Drawing.Size(75, 13)
        Me.lblContactEmail.TabIndex = 24
        Me.lblContactEmail.Text = "Contact Email:"
        '
        'txtContactZip
        '
        Me.txtContactZip.Location = New System.Drawing.Point(505, 327)
        Me.txtContactZip.Name = "txtContactZip"
        Me.txtContactZip.Size = New System.Drawing.Size(260, 20)
        Me.txtContactZip.TabIndex = 23
        '
        'txtContactStateAbbr
        '
        Me.txtContactStateAbbr.Location = New System.Drawing.Point(505, 301)
        Me.txtContactStateAbbr.Name = "txtContactStateAbbr"
        Me.txtContactStateAbbr.Size = New System.Drawing.Size(260, 20)
        Me.txtContactStateAbbr.TabIndex = 22
        '
        'txtContactCity
        '
        Me.txtContactCity.Location = New System.Drawing.Point(505, 274)
        Me.txtContactCity.Name = "txtContactCity"
        Me.txtContactCity.Size = New System.Drawing.Size(260, 20)
        Me.txtContactCity.TabIndex = 20
        '
        'txtContactStreetAddress
        '
        Me.txtContactStreetAddress.Location = New System.Drawing.Point(505, 248)
        Me.txtContactStreetAddress.Name = "txtContactStreetAddress"
        Me.txtContactStreetAddress.Size = New System.Drawing.Size(260, 20)
        Me.txtContactStreetAddress.TabIndex = 19
        '
        'txtReportingEmail
        '
        Me.txtReportingEmail.Location = New System.Drawing.Point(505, 222)
        Me.txtReportingEmail.Name = "txtReportingEmail"
        Me.txtReportingEmail.Size = New System.Drawing.Size(260, 20)
        Me.txtReportingEmail.TabIndex = 18
        '
        'txtContactEmail
        '
        Me.txtContactEmail.Location = New System.Drawing.Point(505, 196)
        Me.txtContactEmail.Name = "txtContactEmail"
        Me.txtContactEmail.Size = New System.Drawing.Size(260, 20)
        Me.txtContactEmail.TabIndex = 17
        '
        'lblContactCellPhone
        '
        Me.lblContactCellPhone.AutoSize = True
        Me.lblContactCellPhone.Location = New System.Drawing.Point(16, 353)
        Me.lblContactCellPhone.Name = "lblContactCellPhone"
        Me.lblContactCellPhone.Size = New System.Drawing.Size(101, 13)
        Me.lblContactCellPhone.TabIndex = 16
        Me.lblContactCellPhone.Text = "Contact Cell Phone:"
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
        'lblContactName
        '
        Me.lblContactName.AutoSize = True
        Me.lblContactName.Location = New System.Drawing.Point(39, 301)
        Me.lblContactName.Name = "lblContactName"
        Me.lblContactName.Size = New System.Drawing.Size(78, 13)
        Me.lblContactName.TabIndex = 14
        Me.lblContactName.Text = "Contact Name:"
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
        'lblAccountNumber
        '
        Me.lblAccountNumber.AutoSize = True
        Me.lblAccountNumber.Location = New System.Drawing.Point(27, 249)
        Me.lblAccountNumber.Name = "lblAccountNumber"
        Me.lblAccountNumber.Size = New System.Drawing.Size(90, 13)
        Me.lblAccountNumber.TabIndex = 12
        Me.lblAccountNumber.Text = "Account Number:"
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
        'lblAccountName
        '
        Me.lblAccountName.AutoSize = True
        Me.lblAccountName.Location = New System.Drawing.Point(36, 197)
        Me.lblAccountName.Name = "lblAccountName"
        Me.lblAccountName.Size = New System.Drawing.Size(81, 13)
        Me.lblAccountName.TabIndex = 10
        Me.lblAccountName.Text = "Account Name:"
        '
        'txtContactCellPhone
        '
        Me.txtContactCellPhone.Location = New System.Drawing.Point(120, 350)
        Me.txtContactCellPhone.Name = "txtContactCellPhone"
        Me.txtContactCellPhone.Size = New System.Drawing.Size(260, 20)
        Me.txtContactCellPhone.TabIndex = 9
        '
        'txtContactBusPhone
        '
        Me.txtContactBusPhone.Location = New System.Drawing.Point(120, 324)
        Me.txtContactBusPhone.Name = "txtContactBusPhone"
        Me.txtContactBusPhone.Size = New System.Drawing.Size(260, 20)
        Me.txtContactBusPhone.TabIndex = 8
        '
        'txtContactName
        '
        Me.txtContactName.Location = New System.Drawing.Point(120, 298)
        Me.txtContactName.Name = "txtContactName"
        Me.txtContactName.Size = New System.Drawing.Size(260, 20)
        Me.txtContactName.TabIndex = 7
        '
        'txtBillingType
        '
        Me.txtBillingType.Location = New System.Drawing.Point(120, 272)
        Me.txtBillingType.Name = "txtBillingType"
        Me.txtBillingType.Size = New System.Drawing.Size(260, 20)
        Me.txtBillingType.TabIndex = 6
        '
        'txtAccountNumber
        '
        Me.txtAccountNumber.Location = New System.Drawing.Point(120, 246)
        Me.txtAccountNumber.Name = "txtAccountNumber"
        Me.txtAccountNumber.Size = New System.Drawing.Size(260, 20)
        Me.txtAccountNumber.TabIndex = 5
        '
        'txtAccountType
        '
        Me.txtAccountType.Location = New System.Drawing.Point(120, 220)
        Me.txtAccountType.Name = "txtAccountType"
        Me.txtAccountType.Size = New System.Drawing.Size(260, 20)
        Me.txtAccountType.TabIndex = 4
        '
        'txtAccountName
        '
        Me.txtAccountName.Location = New System.Drawing.Point(120, 194)
        Me.txtAccountName.Name = "txtAccountName"
        Me.txtAccountName.Size = New System.Drawing.Size(260, 20)
        Me.txtAccountName.TabIndex = 3
        '
        'dgvAccounts
        '
        Me.dgvAccounts.AllowUserToAddRows = False
        Me.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccounts.Location = New System.Drawing.Point(120, 41)
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvAccounts.Size = New System.Drawing.Size(1002, 150)
        Me.dgvAccounts.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Account:"
        '
        'tabAccessCodes
        '
        Me.tabAccessCodes.Location = New System.Drawing.Point(4, 22)
        Me.tabAccessCodes.Name = "tabAccessCodes"
        Me.tabAccessCodes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAccessCodes.Size = New System.Drawing.Size(1159, 419)
        Me.tabAccessCodes.TabIndex = 1
        Me.tabAccessCodes.Text = "Account Access Code Blocks"
        Me.tabAccessCodes.UseVisualStyleBackColor = True
        '
        'tabAccountReports
        '
        Me.tabAccountReports.Location = New System.Drawing.Point(4, 22)
        Me.tabAccountReports.Name = "tabAccountReports"
        Me.tabAccountReports.Size = New System.Drawing.Size(1159, 419)
        Me.tabAccountReports.TabIndex = 2
        Me.tabAccountReports.Text = "Account Reports"
        Me.tabAccountReports.UseVisualStyleBackColor = True
        '
        'tabAccountBilling
        '
        Me.tabAccountBilling.Location = New System.Drawing.Point(4, 22)
        Me.tabAccountBilling.Name = "tabAccountBilling"
        Me.tabAccountBilling.Size = New System.Drawing.Size(1159, 419)
        Me.tabAccountBilling.TabIndex = 3
        Me.tabAccountBilling.Text = "Account Billing"
        Me.tabAccountBilling.UseVisualStyleBackColor = True
        '
        'tabGenMonthlyBilling
        '
        Me.tabGenMonthlyBilling.Location = New System.Drawing.Point(4, 22)
        Me.tabGenMonthlyBilling.Name = "tabGenMonthlyBilling"
        Me.tabGenMonthlyBilling.Size = New System.Drawing.Size(1159, 419)
        Me.tabGenMonthlyBilling.TabIndex = 4
        Me.tabGenMonthlyBilling.Text = "Generate and Email Monthly Bills"
        Me.tabGenMonthlyBilling.UseVisualStyleBackColor = True
        '
        'tabGenMonthlyReports
        '
        Me.tabGenMonthlyReports.Location = New System.Drawing.Point(4, 22)
        Me.tabGenMonthlyReports.Name = "tabGenMonthlyReports"
        Me.tabGenMonthlyReports.Size = New System.Drawing.Size(1159, 419)
        Me.tabGenMonthlyReports.TabIndex = 5
        Me.tabGenMonthlyReports.Text = "Generate and Email Monthly Reports"
        Me.tabGenMonthlyReports.UseVisualStyleBackColor = True
        '
        'tabManageUsers
        '
        Me.tabManageUsers.Location = New System.Drawing.Point(4, 22)
        Me.tabManageUsers.Name = "tabManageUsers"
        Me.tabManageUsers.Size = New System.Drawing.Size(1159, 419)
        Me.tabManageUsers.TabIndex = 6
        Me.tabManageUsers.Text = "Manage System Users"
        Me.tabManageUsers.UseVisualStyleBackColor = True
        '
        'llEdit
        '
        Me.llEdit.AutoSize = True
        Me.llEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llEdit.Location = New System.Drawing.Point(862, 251)
        Me.llEdit.Name = "llEdit"
        Me.llEdit.Size = New System.Drawing.Size(178, 16)
        Me.llEdit.TabIndex = 39
        Me.llEdit.TabStop = True
        Me.llEdit.Text = "Click to Edit Account Info"
        '
        'llSaveAccount
        '
        Me.llSaveAccount.AutoSize = True
        Me.llSaveAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llSaveAccount.Location = New System.Drawing.Point(862, 278)
        Me.llSaveAccount.Name = "llSaveAccount"
        Me.llSaveAccount.Size = New System.Drawing.Size(187, 16)
        Me.llSaveAccount.TabIndex = 40
        Me.llSaveAccount.TabStop = True
        Me.llSaveAccount.Text = "Click to Save Account Info"
        '
        'llNewAccount
        '
        Me.llNewAccount.AutoSize = True
        Me.llNewAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llNewAccount.Location = New System.Drawing.Point(862, 305)
        Me.llNewAccount.Name = "llNewAccount"
        Me.llNewAccount.Size = New System.Drawing.Size(184, 16)
        Me.llNewAccount.TabIndex = 41
        Me.llNewAccount.TabStop = True
        Me.llNewAccount.Text = "Click to Add New Account"
        '
        'llExit
        '
        Me.llExit.AutoSize = True
        Me.llExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llExit.Location = New System.Drawing.Point(862, 331)
        Me.llExit.Name = "llExit"
        Me.llExit.Size = New System.Drawing.Size(212, 16)
        Me.llExit.TabIndex = 42
        Me.llExit.TabStop = True
        Me.llExit.Text = "Click to Exit Account Manager"
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Manager"
        Me.tcMain.ResumeLayout(False)
        Me.tabAccountInfo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcMain As TabControl
    Friend WithEvents tabAccountInfo As TabPage
    Friend WithEvents tabAccessCodes As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvAccounts As DataGridView
    Friend WithEvents lblContactZip As Label
    Friend WithEvents lblContactStateAbbr As Label
    Friend WithEvents lblContactCity As Label
    Friend WithEvents lblContactStreetAddress As Label
    Friend WithEvents lblReportingEmail As Label
    Friend WithEvents lblContactEmail As Label
    Friend WithEvents txtContactZip As TextBox
    Friend WithEvents txtContactStateAbbr As TextBox
    Friend WithEvents txtContactCity As TextBox
    Friend WithEvents txtContactStreetAddress As TextBox
    Friend WithEvents txtReportingEmail As TextBox
    Friend WithEvents txtContactEmail As TextBox
    Friend WithEvents lblContactCellPhone As Label
    Friend WithEvents lblContactBusPhone As Label
    Friend WithEvents lblContactName As Label
    Friend WithEvents lblBillingType As Label
    Friend WithEvents lblAccountNumber As Label
    Friend WithEvents lblAccountType As Label
    Friend WithEvents lblAccountName As Label
    Friend WithEvents txtContactCellPhone As TextBox
    Friend WithEvents txtContactBusPhone As TextBox
    Friend WithEvents txtContactName As TextBox
    Friend WithEvents txtBillingType As TextBox
    Friend WithEvents txtAccountNumber As TextBox
    Friend WithEvents txtAccountType As TextBox
    Friend WithEvents txtAccountName As TextBox
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents lblActive As Label
    Friend WithEvents lblCreatedDate As Label
    Friend WithEvents lblSalesContact As Label
    Friend WithEvents txtCreatedDate As TextBox
    Friend WithEvents txtSalesContact As TextBox
    Friend WithEvents tabAccountReports As TabPage
    Friend WithEvents tabAccountBilling As TabPage
    Friend WithEvents tabGenMonthlyBilling As TabPage
    Friend WithEvents tabGenMonthlyReports As TabPage
    Friend WithEvents tabManageUsers As TabPage
    Friend WithEvents llExit As LinkLabel
    Friend WithEvents llNewAccount As LinkLabel
    Friend WithEvents llSaveAccount As LinkLabel
    Friend WithEvents llEdit As LinkLabel
End Class
