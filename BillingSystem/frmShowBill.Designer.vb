<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowBill
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
        Me.dgvBill = New System.Windows.Forms.DataGridView
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BillnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BilldateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustomeridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustomernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustomeraddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DiscountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GrandtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BillingdbDataSet = New BillingSystem.billingdbDataSet
        Me.BillTableAdapter = New BillingSystem.billingdbDataSetTableAdapters.billTableAdapter
        Me.btnShow = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.txtBillnumber = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnShowAll = New System.Windows.Forms.Button
        Me.Bill_itemsTableAdapter1 = New BillingSystem.billingdbDataSetTableAdapters.bill_itemsTableAdapter
        Me.btnDeleteAll = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTotalofamount = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtProfit = New System.Windows.Forms.TextBox
        Me.StocksTableAdapter = New BillingSystem.billingdbDataSetTableAdapters.stocksTableAdapter
        CType(Me.dgvBill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillingdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBill
        '
        Me.dgvBill.AllowUserToAddRows = False
        Me.dgvBill.AllowUserToDeleteRows = False
        Me.dgvBill.AutoGenerateColumns = False
        Me.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBill.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.BillnumberDataGridViewTextBoxColumn, Me.BilldateDataGridViewTextBoxColumn, Me.CustomeridDataGridViewTextBoxColumn, Me.CustomernameDataGridViewTextBoxColumn, Me.CustomeraddressDataGridViewTextBoxColumn, Me.SubtotalDataGridViewTextBoxColumn, Me.DiscountDataGridViewTextBoxColumn, Me.TaxDataGridViewTextBoxColumn, Me.GrandtotalDataGridViewTextBoxColumn})
        Me.dgvBill.DataSource = Me.BillBindingSource
        Me.dgvBill.Location = New System.Drawing.Point(12, 79)
        Me.dgvBill.MultiSelect = False
        Me.dgvBill.Name = "dgvBill"
        Me.dgvBill.ReadOnly = True
        Me.dgvBill.RowTemplate.ReadOnly = True
        Me.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBill.Size = New System.Drawing.Size(920, 389)
        Me.dgvBill.TabIndex = 5
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'BillnumberDataGridViewTextBoxColumn
        '
        Me.BillnumberDataGridViewTextBoxColumn.DataPropertyName = "bill_number"
        Me.BillnumberDataGridViewTextBoxColumn.HeaderText = "Bill Number"
        Me.BillnumberDataGridViewTextBoxColumn.Name = "BillnumberDataGridViewTextBoxColumn"
        Me.BillnumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.BillnumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'BilldateDataGridViewTextBoxColumn
        '
        Me.BilldateDataGridViewTextBoxColumn.DataPropertyName = "bill_date"
        Me.BilldateDataGridViewTextBoxColumn.HeaderText = "Bill Date"
        Me.BilldateDataGridViewTextBoxColumn.Name = "BilldateDataGridViewTextBoxColumn"
        Me.BilldateDataGridViewTextBoxColumn.ReadOnly = True
        Me.BilldateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CustomeridDataGridViewTextBoxColumn
        '
        Me.CustomeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.HeaderText = "Customer ID"
        Me.CustomeridDataGridViewTextBoxColumn.Name = "CustomeridDataGridViewTextBoxColumn"
        Me.CustomeridDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomeridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CustomernameDataGridViewTextBoxColumn
        '
        Me.CustomernameDataGridViewTextBoxColumn.DataPropertyName = "customer_name"
        Me.CustomernameDataGridViewTextBoxColumn.HeaderText = "Customer Name"
        Me.CustomernameDataGridViewTextBoxColumn.Name = "CustomernameDataGridViewTextBoxColumn"
        Me.CustomernameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomernameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CustomeraddressDataGridViewTextBoxColumn
        '
        Me.CustomeraddressDataGridViewTextBoxColumn.DataPropertyName = "customer_address"
        Me.CustomeraddressDataGridViewTextBoxColumn.HeaderText = "Customer Address"
        Me.CustomeraddressDataGridViewTextBoxColumn.Name = "CustomeraddressDataGridViewTextBoxColumn"
        Me.CustomeraddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomeraddressDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'SubtotalDataGridViewTextBoxColumn
        '
        Me.SubtotalDataGridViewTextBoxColumn.DataPropertyName = "sub_total"
        Me.SubtotalDataGridViewTextBoxColumn.HeaderText = "Sub Total"
        Me.SubtotalDataGridViewTextBoxColumn.Name = "SubtotalDataGridViewTextBoxColumn"
        Me.SubtotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubtotalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DiscountDataGridViewTextBoxColumn
        '
        Me.DiscountDataGridViewTextBoxColumn.DataPropertyName = "discount"
        Me.DiscountDataGridViewTextBoxColumn.HeaderText = "Discount"
        Me.DiscountDataGridViewTextBoxColumn.Name = "DiscountDataGridViewTextBoxColumn"
        Me.DiscountDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiscountDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TaxDataGridViewTextBoxColumn
        '
        Me.TaxDataGridViewTextBoxColumn.DataPropertyName = "tax"
        Me.TaxDataGridViewTextBoxColumn.HeaderText = "Tax"
        Me.TaxDataGridViewTextBoxColumn.Name = "TaxDataGridViewTextBoxColumn"
        Me.TaxDataGridViewTextBoxColumn.ReadOnly = True
        Me.TaxDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'GrandtotalDataGridViewTextBoxColumn
        '
        Me.GrandtotalDataGridViewTextBoxColumn.DataPropertyName = "grand_total"
        Me.GrandtotalDataGridViewTextBoxColumn.HeaderText = "Grand Total"
        Me.GrandtotalDataGridViewTextBoxColumn.Name = "GrandtotalDataGridViewTextBoxColumn"
        Me.GrandtotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.GrandtotalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'BillBindingSource
        '
        Me.BillBindingSource.DataMember = "bill"
        Me.BillBindingSource.DataSource = Me.BillingdbDataSet
        '
        'BillingdbDataSet
        '
        Me.BillingdbDataSet.DataSetName = "billingdbDataSet"
        Me.BillingdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BillTableAdapter
        '
        Me.BillTableAdapter.ClearBeforeFill = True
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(345, 23)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(128, 32)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "Show Selected Bill"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(496, 23)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(128, 32)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete Selected Bill"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtBillnumber
        '
        Me.txtBillnumber.Location = New System.Drawing.Point(167, 30)
        Me.txtBillnumber.Name = "txtBillnumber"
        Me.txtBillnumber.Size = New System.Drawing.Size(149, 20)
        Me.txtBillnumber.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Search by Bill Number"
        '
        'btnShowAll
        '
        Me.btnShowAll.Location = New System.Drawing.Point(646, 23)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(128, 32)
        Me.btnShowAll.TabIndex = 4
        Me.btnShowAll.Text = "Show All Bills"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'Bill_itemsTableAdapter1
        '
        Me.Bill_itemsTableAdapter1.ClearBeforeFill = True
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.Location = New System.Drawing.Point(804, 23)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(128, 32)
        Me.btnDeleteAll.TabIndex = 6
        Me.btnDeleteAll.Text = "Delete All Bills"
        Me.btnDeleteAll.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(647, 506)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Total of Bill Amount"
        '
        'txtTotalofamount
        '
        Me.txtTotalofamount.Enabled = False
        Me.txtTotalofamount.Location = New System.Drawing.Point(783, 503)
        Me.txtTotalofamount.Name = "txtTotalofamount"
        Me.txtTotalofamount.Size = New System.Drawing.Size(149, 20)
        Me.txtTotalofamount.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(647, 541)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Total Profit"
        '
        'txtProfit
        '
        Me.txtProfit.Enabled = False
        Me.txtProfit.Location = New System.Drawing.Point(783, 538)
        Me.txtProfit.Name = "txtProfit"
        Me.txtProfit.Size = New System.Drawing.Size(149, 20)
        Me.txtProfit.TabIndex = 9
        '
        'StocksTableAdapter
        '
        Me.StocksTableAdapter.ClearBeforeFill = True
        '
        'frmShowBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 580)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtProfit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotalofamount)
        Me.Controls.Add(Me.btnDeleteAll)
        Me.Controls.Add(Me.btnShowAll)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBillnumber)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.dgvBill)
        Me.Name = "frmShowBill"
        Me.Text = "Saved Bills"
        CType(Me.dgvBill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillingdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvBill As System.Windows.Forms.DataGridView
    Friend WithEvents BillingdbDataSet As BillingSystem.billingdbDataSet
    Friend WithEvents BillBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BillTableAdapter As BillingSystem.billingdbDataSetTableAdapters.billTableAdapter
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtBillnumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnShowAll As System.Windows.Forms.Button
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BillnumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BilldateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomeridDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomeraddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubtotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiscountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaxDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrandtotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bill_itemsTableAdapter1 As BillingSystem.billingdbDataSetTableAdapters.bill_itemsTableAdapter
    Friend WithEvents btnDeleteAll As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotalofamount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtProfit As System.Windows.Forms.TextBox
    Friend WithEvents StocksTableAdapter As BillingSystem.billingdbDataSetTableAdapters.stocksTableAdapter
End Class
