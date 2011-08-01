<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBill
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBillNumber = New System.Windows.Forms.TextBox
        Me.txtCustomerName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCustomerAddress = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDate = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.dgvBill = New System.Windows.Forms.DataGridView
        Me.item_code = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.item_price = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.item_quantity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.item_total = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtTax = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtSubTotal = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.label8 = New System.Windows.Forms.Label
        Me.btnSaveBill = New System.Windows.Forms.Button
        Me.btnPrintBill = New System.Windows.Forms.Button
        Me.btnCancelBill = New System.Windows.Forms.Button
        Me.BillingdbDataSet1 = New BillingSystem.billingdbDataSet
        Me.Bill_itemsTableAdapter1 = New BillingSystem.billingdbDataSetTableAdapters.bill_itemsTableAdapter
        Me.BillTableAdapter1 = New BillingSystem.billingdbDataSetTableAdapters.billTableAdapter
        Me.StocksTableAdapter1 = New BillingSystem.billingdbDataSetTableAdapters.stocksTableAdapter
        Me.CustomerTableAdapter1 = New BillingSystem.billingdbDataSetTableAdapters.customerTableAdapter
        Me.BillitemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvBill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillingdbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillitemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bill Number"
        '
        'txtBillNumber
        '
        Me.txtBillNumber.Enabled = False
        Me.txtBillNumber.Location = New System.Drawing.Point(138, 40)
        Me.txtBillNumber.Name = "txtBillNumber"
        Me.txtBillNumber.Size = New System.Drawing.Size(233, 20)
        Me.txtBillNumber.TabIndex = 1
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(138, 76)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(233, 20)
        Me.txtCustomerName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Customer Name"
        '
        'txtCustomerAddress
        '
        Me.txtCustomerAddress.Location = New System.Drawing.Point(138, 116)
        Me.txtCustomerAddress.Name = "txtCustomerAddress"
        Me.txtCustomerAddress.Size = New System.Drawing.Size(233, 20)
        Me.txtCustomerAddress.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Customer Address"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(519, 40)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(200, 20)
        Me.txtDate.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(473, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Date"
        '
        'dgvBill
        '
        Me.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBill.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item_code, Me.item_name, Me.item_price, Me.item_quantity, Me.item_total})
        Me.dgvBill.Location = New System.Drawing.Point(77, 167)
        Me.dgvBill.Name = "dgvBill"
        Me.dgvBill.Size = New System.Drawing.Size(615, 180)
        Me.dgvBill.TabIndex = 8
        '
        'item_code
        '
        Me.item_code.HeaderText = "Item Code"
        Me.item_code.Name = "item_code"
        Me.item_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'item_name
        '
        Me.item_name.HeaderText = "Item Name"
        Me.item_name.Name = "item_name"
        Me.item_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.item_name.Width = 150
        '
        'item_price
        '
        Me.item_price.HeaderText = "Unit Price"
        Me.item_price.Name = "item_price"
        Me.item_price.ReadOnly = True
        Me.item_price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.item_price.Width = 120
        '
        'item_quantity
        '
        Me.item_quantity.HeaderText = "Quantity"
        Me.item_quantity.Name = "item_quantity"
        Me.item_quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'item_total
        '
        Me.item_total.HeaderText = "Total"
        Me.item_total.Name = "item_total"
        Me.item_total.ReadOnly = True
        Me.item_total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(550, 465)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(142, 20)
        Me.txtTax.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(442, 469)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Tax"
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(550, 425)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(142, 20)
        Me.txtDiscount.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(442, 425)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Discount"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Location = New System.Drawing.Point(550, 389)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(142, 20)
        Me.txtSubTotal.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(442, 389)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Sub Total"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(550, 505)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(142, 20)
        Me.txtTotal.TabIndex = 16
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(442, 510)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(42, 13)
        Me.label8.TabIndex = 15
        Me.label8.Text = "TOTAL"
        '
        'btnSaveBill
        '
        Me.btnSaveBill.Location = New System.Drawing.Point(77, 389)
        Me.btnSaveBill.Name = "btnSaveBill"
        Me.btnSaveBill.Size = New System.Drawing.Size(104, 42)
        Me.btnSaveBill.TabIndex = 17
        Me.btnSaveBill.Text = "Save Bill"
        Me.btnSaveBill.UseVisualStyleBackColor = True
        '
        'btnPrintBill
        '
        Me.btnPrintBill.Enabled = False
        Me.btnPrintBill.Location = New System.Drawing.Point(77, 444)
        Me.btnPrintBill.Name = "btnPrintBill"
        Me.btnPrintBill.Size = New System.Drawing.Size(104, 42)
        Me.btnPrintBill.TabIndex = 18
        Me.btnPrintBill.Text = "Print Bill"
        Me.btnPrintBill.UseVisualStyleBackColor = True
        '
        'btnCancelBill
        '
        Me.btnCancelBill.Location = New System.Drawing.Point(77, 497)
        Me.btnCancelBill.Name = "btnCancelBill"
        Me.btnCancelBill.Size = New System.Drawing.Size(104, 42)
        Me.btnCancelBill.TabIndex = 19
        Me.btnCancelBill.Text = "Cancel Bill"
        Me.btnCancelBill.UseVisualStyleBackColor = True
        '
        'BillingdbDataSet1
        '
        Me.BillingdbDataSet1.DataSetName = "billingdbDataSet"
        Me.BillingdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Bill_itemsTableAdapter1
        '
        Me.Bill_itemsTableAdapter1.ClearBeforeFill = True
        '
        'BillTableAdapter1
        '
        Me.BillTableAdapter1.ClearBeforeFill = True
        '
        'StocksTableAdapter1
        '
        Me.StocksTableAdapter1.ClearBeforeFill = True
        '
        'CustomerTableAdapter1
        '
        Me.CustomerTableAdapter1.ClearBeforeFill = True
        '
        'BillitemsBindingSource
        '
        Me.BillitemsBindingSource.DataMember = "bill_items"
        Me.BillitemsBindingSource.DataSource = Me.BillingdbDataSet1
        '
        'frmBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 560)
        Me.Controls.Add(Me.btnCancelBill)
        Me.Controls.Add(Me.btnPrintBill)
        Me.Controls.Add(Me.btnSaveBill)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvBill)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtCustomerAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBillNumber)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBill"
        Me.Text = "Bill"
        CType(Me.dgvBill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillingdbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillitemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBillNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvBill As System.Windows.Forms.DataGridView
    Friend WithEvents BillingdbDataSet1 As BillingSystem.billingdbDataSet
    Friend WithEvents Bill_itemsTableAdapter1 As BillingSystem.billingdbDataSetTableAdapters.bill_itemsTableAdapter
    Friend WithEvents BillTableAdapter1 As BillingSystem.billingdbDataSetTableAdapters.billTableAdapter
    Friend WithEvents StocksTableAdapter1 As BillingSystem.billingdbDataSetTableAdapters.stocksTableAdapter
    Friend WithEvents CustomerTableAdapter1 As BillingSystem.billingdbDataSetTableAdapters.customerTableAdapter
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents btnSaveBill As System.Windows.Forms.Button
    Friend WithEvents btnPrintBill As System.Windows.Forms.Button
    Friend WithEvents btnCancelBill As System.Windows.Forms.Button
    Friend WithEvents BillitemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents item_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_total As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
