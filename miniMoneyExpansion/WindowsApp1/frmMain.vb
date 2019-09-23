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
        dgvAccounts.Columns("AccountType").Visible = True
        dgvAccounts.Columns("AccountNumber").Visible = True
        dgvAccounts.Columns("BillingType").Visible = True
        dgvAccounts.Columns("ContactActive").Visible = True
        dgvAccounts.Width = dgvAccounts.Columns.GetColumnsWidth(DataGridViewElementStates.Displayed)
        'grid.Columns.GetColumnsWidth(DataGridViewElementStates.Displayed)
        dgvAccounts.AllowUserToAddRows = False
        dgvAccounts.RowHeadersVisible = False
    End Sub

    Private Sub dgvAccounts_Click(sender As Object, e As EventArgs) Handles dgvAccounts.Click
        MsgBox(dgvAccounts.SelectedCells(0).Value.ToString)
    End Sub
End Class
