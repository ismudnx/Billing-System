<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrint
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
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.billBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.billingdbDataSet = New BillingSystem.billingdbDataSet
        Me.printView = New Microsoft.Reporting.WinForms.ReportViewer
        Me.billTableAdapter = New BillingSystem.billingdbDataSetTableAdapters.billTableAdapter
        CType(Me.billBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.billingdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'billBindingSource
        '
        Me.billBindingSource.DataMember = "bill"
        Me.billBindingSource.DataSource = Me.billingdbDataSet
        '
        'billingdbDataSet
        '
        Me.billingdbDataSet.DataSetName = "billingdbDataSet"
        Me.billingdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'printView
        '
        Me.printView.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "billingdbDataSet_bill"
        ReportDataSource1.Value = Me.billBindingSource
        Me.printView.LocalReport.DataSources.Add(ReportDataSource1)
        Me.printView.LocalReport.ReportEmbeddedResource = "BillingSystem.BillPrint.rdlc"
        Me.printView.Location = New System.Drawing.Point(0, 0)
        Me.printView.Margin = New System.Windows.Forms.Padding(1)
        Me.printView.Name = "printView"
        Me.printView.Size = New System.Drawing.Size(796, 530)
        Me.printView.TabIndex = 0
        '
        'billTableAdapter
        '
        Me.billTableAdapter.ClearBeforeFill = True
        '
        'frmPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 530)
        Me.Controls.Add(Me.printView)
        Me.Name = "frmPrint"
        Me.Text = "Print"
        CType(Me.billBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.billingdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents printView As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents billBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents billingdbDataSet As BillingSystem.billingdbDataSet
    Friend WithEvents billTableAdapter As BillingSystem.billingdbDataSetTableAdapters.billTableAdapter
End Class
