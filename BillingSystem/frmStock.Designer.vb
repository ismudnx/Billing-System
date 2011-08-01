<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStock
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
        Me.txtItemPrice = New System.Windows.Forms.TextBox
        Me.txtItemCode = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtItemQuantity = New System.Windows.Forms.TextBox
        Me.txtItemName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.dgvStocks = New System.Windows.Forms.DataGridView
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.item_code = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.item_price = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.item_cost = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.item_quantity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.total_amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.initial_stock = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BillingdbDataSet = New BillingSystem.billingdbDataSet
        Me.txtItemTotal = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtItemCost = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.StocksTableAdapter = New BillingSystem.billingdbDataSetTableAdapters.stocksTableAdapter
        Me.txtCurrentStock = New System.Windows.Forms.TextBox
        Me.txtTotalSales = New System.Windows.Forms.TextBox
        Me.txtTotalStock = New System.Windows.Forms.TextBox
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Bill_itemsTableAdapter1 = New BillingSystem.billingdbDataSetTableAdapters.bill_itemsTableAdapter
        Me.btnDeleteAll = New System.Windows.Forms.Button
        Me.BillTableAdapter1 = New BillingSystem.billingdbDataSetTableAdapters.billTableAdapter
        CType(Me.dgvStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillingdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtItemPrice
        '
        Me.txtItemPrice.Location = New System.Drawing.Point(112, 68)
        Me.txtItemPrice.Name = "txtItemPrice"
        Me.txtItemPrice.Size = New System.Drawing.Size(167, 20)
        Me.txtItemPrice.TabIndex = 3
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(112, 37)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(167, 20)
        Me.txtItemCode.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Item Price"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Item Code"
        '
        'txtItemQuantity
        '
        Me.txtItemQuantity.Location = New System.Drawing.Point(412, 68)
        Me.txtItemQuantity.Name = "txtItemQuantity"
        Me.txtItemQuantity.Size = New System.Drawing.Size(167, 20)
        Me.txtItemQuantity.TabIndex = 4
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(412, 37)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(167, 20)
        Me.txtItemName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(343, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Item Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(342, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Item Name"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(611, 65)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(122, 23)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(611, 98)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(122, 23)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(611, 34)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(122, 23)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dgvStocks
        '
        Me.dgvStocks.AllowUserToAddRows = False
        Me.dgvStocks.AllowUserToDeleteRows = False
        Me.dgvStocks.AutoGenerateColumns = False
        Me.dgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStocks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.item_code, Me.item_name, Me.item_price, Me.item_cost, Me.item_quantity, Me.total_amount, Me.initial_stock})
        Me.dgvStocks.DataSource = Me.StocksBindingSource
        Me.dgvStocks.Location = New System.Drawing.Point(45, 149)
        Me.dgvStocks.MultiSelect = False
        Me.dgvStocks.Name = "dgvStocks"
        Me.dgvStocks.ReadOnly = True
        Me.dgvStocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStocks.Size = New System.Drawing.Size(688, 299)
        Me.dgvStocks.TabIndex = 10
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'item_code
        '
        Me.item_code.DataPropertyName = "item_code"
        Me.item_code.HeaderText = "Item Code"
        Me.item_code.Name = "item_code"
        Me.item_code.ReadOnly = True
        Me.item_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'item_name
        '
        Me.item_name.DataPropertyName = "item_name"
        Me.item_name.HeaderText = "Item Name"
        Me.item_name.Name = "item_name"
        Me.item_name.ReadOnly = True
        Me.item_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'item_price
        '
        Me.item_price.DataPropertyName = "item_price"
        Me.item_price.HeaderText = "Item Price"
        Me.item_price.Name = "item_price"
        Me.item_price.ReadOnly = True
        Me.item_price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'item_cost
        '
        Me.item_cost.DataPropertyName = "item_cost"
        Me.item_cost.HeaderText = "Item Cost"
        Me.item_cost.Name = "item_cost"
        Me.item_cost.ReadOnly = True
        Me.item_cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'item_quantity
        '
        Me.item_quantity.DataPropertyName = "item_quantity"
        Me.item_quantity.HeaderText = "Item Quantity"
        Me.item_quantity.Name = "item_quantity"
        Me.item_quantity.ReadOnly = True
        Me.item_quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'total_amount
        '
        Me.total_amount.DataPropertyName = "total_amount"
        Me.total_amount.HeaderText = "Total Amount"
        Me.total_amount.Name = "total_amount"
        Me.total_amount.ReadOnly = True
        Me.total_amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'initial_stock
        '
        Me.initial_stock.DataPropertyName = "total_amount"
        Me.initial_stock.HeaderText = "Initial Stock"
        Me.initial_stock.Name = "initial_stock"
        Me.initial_stock.ReadOnly = True
        '
        'StocksBindingSource
        '
        Me.StocksBindingSource.DataMember = "stocks"
        Me.StocksBindingSource.DataSource = Me.BillingdbDataSet
        '
        'BillingdbDataSet
        '
        Me.BillingdbDataSet.DataSetName = "billingdbDataSet"
        Me.BillingdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtItemTotal
        '
        Me.txtItemTotal.Location = New System.Drawing.Point(411, 100)
        Me.txtItemTotal.Name = "txtItemTotal"
        Me.txtItemTotal.Size = New System.Drawing.Size(167, 20)
        Me.txtItemTotal.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(342, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Total Amount"
        '
        'txtItemCost
        '
        Me.txtItemCost.Location = New System.Drawing.Point(111, 100)
        Me.txtItemCost.Name = "txtItemCost"
        Me.txtItemCost.Size = New System.Drawing.Size(167, 20)
        Me.txtItemCost.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Item Cost"
        '
        'StocksTableAdapter
        '
        Me.StocksTableAdapter.ClearBeforeFill = True
        '
        'txtCurrentStock
        '
        Me.txtCurrentStock.Enabled = False
        Me.txtCurrentStock.Location = New System.Drawing.Point(565, 541)
        Me.txtCurrentStock.Name = "txtCurrentStock"
        Me.txtCurrentStock.Size = New System.Drawing.Size(167, 20)
        Me.txtCurrentStock.TabIndex = 19
        '
        'txtTotalSales
        '
        Me.txtTotalSales.Enabled = False
        Me.txtTotalSales.Location = New System.Drawing.Point(566, 509)
        Me.txtTotalSales.Name = "txtTotalSales"
        Me.txtTotalSales.Size = New System.Drawing.Size(167, 20)
        Me.txtTotalSales.TabIndex = 18
        '
        'txtTotalStock
        '
        Me.txtTotalStock.Enabled = False
        Me.txtTotalStock.Location = New System.Drawing.Point(566, 478)
        Me.txtTotalStock.Name = "txtTotalStock"
        Me.txtTotalStock.Size = New System.Drawing.Size(167, 20)
        Me.txtTotalStock.TabIndex = 17
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(170, 478)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(167, 20)
        Me.txtSearch.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 481)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Search item by code"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(468, 481)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Total Stock"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(468, 512)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Total Sales"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(468, 544)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Current Stock"
        '
        'Bill_itemsTableAdapter1
        '
        Me.Bill_itemsTableAdapter1.ClearBeforeFill = True
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.Location = New System.Drawing.Point(45, 525)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(128, 32)
        Me.btnDeleteAll.TabIndex = 25
        Me.btnDeleteAll.Text = "Delete All Stocks"
        Me.btnDeleteAll.UseVisualStyleBackColor = True
        '
        'BillTableAdapter1
        '
        Me.BillTableAdapter1.ClearBeforeFill = True
        '
        'frmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 588)
        Me.Controls.Add(Me.btnDeleteAll)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.txtCurrentStock)
        Me.Controls.Add(Me.txtTotalSales)
        Me.Controls.Add(Me.txtTotalStock)
        Me.Controls.Add(Me.txtItemTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtItemCost)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvStocks)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtItemQuantity)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtItemPrice)
        Me.Controls.Add(Me.txtItemCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmStock"
        Me.Text = "Stocks"
        CType(Me.dgvStocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillingdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtItemPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtItemQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dgvStocks As System.Windows.Forms.DataGridView
    Friend WithEvents BillingdbDataSet As BillingSystem.billingdbDataSet
    Friend WithEvents StocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StocksTableAdapter As BillingSystem.billingdbDataSetTableAdapters.stocksTableAdapter
    Friend WithEvents txtItemTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtItemCost As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents initial_stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCurrentStock As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalSales As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalStock As System.Windows.Forms.TextBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Bill_itemsTableAdapter1 As BillingSystem.billingdbDataSetTableAdapters.bill_itemsTableAdapter
    Friend WithEvents btnDeleteAll As System.Windows.Forms.Button
    Friend WithEvents BillTableAdapter1 As BillingSystem.billingdbDataSetTableAdapters.billTableAdapter
End Class
