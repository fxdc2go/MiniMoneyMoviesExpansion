Option Explicit On
Option Compare Text
Public Class frmMain
    Dim objDataAccess As New clsDataAccess
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dt As New DataTable
        dt = objDataAccess.GetAccounts
        dgvAccounts.ReadOnly = True
        dgvAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAccounts.ScrollBars = ScrollBars.Vertical
        dgvAccounts.DataSource = dt
        For intRows = 0 To dt.Columns.Count - 1
            dgvAccounts.Columns(intRows).Visible = False
        Next
        dgvAccounts.Columns("AccountName").Visible = True
        dgvAccounts.Columns("Accountname").Width = 0.22 * dgvAccounts.Width
        dgvAccounts.Columns("AccountType").Visible = True
        dgvAccounts.Columns("AccountType").Width = 0.22 * dgvAccounts.Width
        dgvAccounts.Columns("AccountNumber").Visible = True
        dgvAccounts.Columns("AccountNumber").Width = 0.22 * dgvAccounts.Width
        dgvAccounts.Columns("BillingType").Visible = True
        dgvAccounts.Columns("BillingType").Width = 0.22 * dgvAccounts.Width
        dgvAccounts.Columns("ContactActive").Visible = True
        dgvAccounts.Columns("ContactActive").Width = 0.1 * dgvAccounts.Width
        'dgvAccounts.Width = dgvAccounts.Columns.GetColumnsWidth(DataGridViewElementStates.Displayed)
        '(DataGridViewElementStates.Displayed)
        dgvAccounts.AllowUserToAddRows = False
        dgvAccounts.RowHeadersVisible = False
        Call NonEdit()
        Call dgvAccounts_Click(sender, e)
    End Sub

    Private Sub dgvAccounts_Click(sender As Object, e As EventArgs) Handles dgvAccounts.Click
        ' MsgBox(dgvAccounts.SelectedCells(0).Value.ToString)
        Dim dt As New DataTable
        dt = objDataAccess.GetCustomerAccountByID(dgvAccounts.SelectedCells(0).Value)
        With dt.Rows(0)
            Me.txtAccountName.Text = .Item("AccountName").ToString
            Me.txtAccountType.Text = .Item("AccountType").ToString
            Me.txtAccountNumber.Text = .Item("AccountNumber").ToString
            Me.txtBillingType.Text = .Item("BillingType").ToString
            Me.txtContactName.Text = .Item("ContactName").ToString
            Me.txtContactBusPhone.Text = .Item("ContactBusPhone").ToString
            Me.txtContactCellPhone.Text = .Item("ContactCell").ToString
            Me.txtContactEmail.Text = .Item("ContactEmail").ToString
            Me.txtReportingEmail.Text = .Item("ReportingEmail").ToString
            Me.txtContactStreetAddress.Text = .Item("ContactStreetAddress").ToString
            Me.txtContactCity.Text = .Item("ContactCity").ToString
            Me.txtContactStateAbbr.Text = .Item("ContactState").ToString
            Me.txtContactZip.Text = .Item("ContactZip").ToString
            Me.txtSalesContact.Text = .Item("SalesContact").ToString
            Me.txtCreatedDate.Text = .Item("CreatedDate").ToString
            Me.chkActive.Checked = .Item("ContactActive")

        End With
    End Sub

    Private Sub NonEdit()
        Me.txtAccountName.ReadOnly = True
        Me.txtAccountType.ReadOnly = True
        Me.txtAccountNumber.ReadOnly = True
        Me.txtBillingType.ReadOnly = True
        Me.txtContactName.ReadOnly = True
        Me.txtContactBusPhone.ReadOnly = True
        Me.txtContactCellPhone.ReadOnly = True
        Me.txtContactEmail.ReadOnly = True
        Me.txtReportingEmail.ReadOnly = True
        Me.txtContactStreetAddress.ReadOnly = True
        Me.txtContactCity.ReadOnly = True
        Me.txtContactStateAbbr.ReadOnly = True
        Me.txtContactZip.ReadOnly = True
        Me.txtSalesContact.ReadOnly = True
        Me.txtCreatedDate.ReadOnly = True
        Me.chkActive.Enabled = False
    End Sub

    Private Sub llEdit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llEdit.LinkClicked
        Call Edit()
    End Sub

    Private Sub Edit()
        Me.txtAccountName.ReadOnly = False
        Me.txtAccountType.ReadOnly = False
        Me.txtAccountNumber.ReadOnly = False
        Me.txtBillingType.ReadOnly = False
        Me.txtContactName.ReadOnly = False
        Me.txtContactBusPhone.ReadOnly = False
        Me.txtContactCellPhone.ReadOnly = False
        Me.txtContactEmail.ReadOnly = False
        Me.txtReportingEmail.ReadOnly = False
        Me.txtContactStreetAddress.ReadOnly = False
        Me.txtContactCity.ReadOnly = False
        Me.txtContactStateAbbr.ReadOnly = False
        Me.txtContactZip.ReadOnly = False
        Me.txtSalesContact.ReadOnly = False
        Me.txtCreatedDate.ReadOnly = False
        Me.chkActive.Enabled = True
    End Sub

    Private Sub llSaveAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llSaveAccount.LinkClicked
        Call NonEdit()
    End Sub

    Private Sub llExit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llExit.LinkClicked
        End
    End Sub
End Class
