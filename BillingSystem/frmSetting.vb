Public Class frmSetting

    Private Sub frmSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmMain
        Me.Top = 0
        Me.Left = 0
        txtCompanyName.Text = GetSetting("Billing System", "Settings", "CompanyName")
        txtAddress.Text = GetSetting("Billing System", "Settings", "Address")
        txtPhone.Text = GetSetting("Billing System", "Settings", "Phone")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveSetting("Billing System", "Settings", "CompanyName", txtCompanyName.Text)
        SaveSetting("Billing System", "Settings", "Address", txtAddress.Text)
        SaveSetting("Billing System", "Settings", "Phone", txtPhone.Text)
        MsgBox("Settings saved successfully.", MsgBoxStyle.Information)
        Me.Close()
    End Sub
End Class