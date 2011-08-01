Imports Microsoft.Reporting.WinForms

Public Class frmPrint
    Public bill_id As Integer
    Private Sub frmPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmMain
        Me.Top = 0
        Me.Left = 0
        'TODO: This line of code loads data into the 'billingdbDataSet.bill' table. You can move, or remove it, as needed.
        Me.billTableAdapter.FillByID(Me.billingdbDataSet.bill, bill_id)
        Dim params(1) As Microsoft.Reporting.WinForms.ReportParameter
        params(0) = New ReportParameter("CompanyName", GetSetting("Billing System", "Settings", "CompanyName"), False)
        params(1) = New ReportParameter("CompanyAddress", GetSetting("Billing System", "Settings", "Address") + ", Phone-" + GetSetting("Billing System", "Settings", "Phone"), False)
        printView.LocalReport.SetParameters(params)
        AddHandler printView.LocalReport.SubreportProcessing, AddressOf ItemsSubreportProcessingEventHandler
        Me.printView.RefreshReport()
    End Sub

    Private Sub ItemsSubreportProcessingEventHandler(ByVal sender As Object, ByVal e As SubreportProcessingEventArgs)
        Dim da As New billingdbDataSetTableAdapters.CustomTableAdapter
        da.FillByBillid(billingdbDataSet.CustomTable, bill_id)
        e.DataSources.Add(New ReportDataSource("billingdbDataSet_CustomTable", billingdbDataSet.CustomTable))
    End Sub
End Class