Public Class frmStock
    Dim edit_flag As Boolean = False
    Dim current_i As Integer
    Dim stock_row As billingdbDataSet.stocksRow
    Dim initial_stock_column As New System.Data.DataColumn("initial_stock", System.Type.GetType("System.Double"), "total_amount/item_cost", MappingType.Hidden)
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'validation
        Try
            Dim valid As Boolean = True
            If txtItemCode.Text = "" Then
                txtItemCode.BackColor = Color.LightSkyBlue
                valid = False
            Else
                txtItemCode.BackColor = Color.White
            End If

            If txtItemName.Text = "" Then
                txtItemName.BackColor = Color.LightSkyBlue
                valid = False
            Else
                txtItemName.BackColor = Color.White

            End If

            If Not IsNumeric(txtItemQuantity.Text) Then
                txtItemQuantity.BackColor = Color.LightSkyBlue
                valid = False
            Else
                txtItemQuantity.BackColor = Color.White

            End If

            If Not IsNumeric(txtItemPrice.Text) Then
                txtItemPrice.BackColor = Color.LightSkyBlue
                valid = False
            Else
                txtItemPrice.BackColor = Color.White

            End If

            If Not IsNumeric(txtItemCost.Text) Then
                txtItemCost.BackColor = Color.LightSkyBlue
                valid = False
            Else
                txtItemCost.BackColor = Color.White
            End If

            If Not IsNumeric(txtItemTotal.Text) Then
                txtItemTotal.BackColor = Color.LightSkyBlue
                valid = False
            Else
                txtItemTotal.BackColor = Color.White
            End If

            If valid = True Then
                Dim res As Integer = 0
                If edit_flag = False Then
                    res = Me.StocksTableAdapter.Insert(txtItemCode.Text, txtItemName.Text, txtItemPrice.Text, txtItemQuantity.Text, txtItemCost.Text, txtItemTotal.Text)
                Else
                    With stock_row
                        .item_code = txtItemCode.Text
                        .item_name = txtItemName.Text
                        .item_price = txtItemPrice.Text
                        .item_quantity = txtItemQuantity.Text
                        .item_cost = txtItemCost.Text
                        .total_amount = txtItemTotal.Text
                    End With
                    res = Me.StocksTableAdapter.Update(stock_row)
                End If
                If res > 0 Then MsgBox("Stock saved successfully.", MsgBoxStyle.Information) Else MsgBox("Some problem occured while adding.", MsgBoxStyle.Information)
                reset()
                Me.StocksTableAdapter.Fill(Me.BillingdbDataSet.stocks)
                dgvStocks.Refresh()
                inventory()
            Else
                MsgBox("Please fill the highlighted fields correctly.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
        
    End Sub
    Private Sub reset()
        txtItemCode.Text = ""
        txtItemName.Text = ""
        txtItemPrice.Text = ""
        txtItemQuantity.Text = ""
        txtItemCost.Text = ""
        txtItemTotal.Text = ""
        edit_flag = False
        btnSave.Text = "Save"
        btnDelete.Visible = False
    End Sub

    Private Sub frmStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmMain
        Me.Top = 0
        Me.Left = 0
        'TODO: This line of code loads data into the 'BillingdbDataSet.stocks' table. You can move, or remove it, as needed.
        Me.BillingdbDataSet.stocks.Columns.Add(initial_stock_column)
        initial_stock.DataPropertyName = "initial_stock"
        Me.StocksTableAdapter.Fill(Me.BillingdbDataSet.stocks)
        inventory()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        reset()
        
    End Sub

    Private Sub dgvStocks_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStocks.CellClick
        current_i = dgvStocks.SelectedRows(0).Index
        stock_row = Me.BillingdbDataSet.stocks.Rows(current_i)
        edit_flag = True
        btnDelete.Visible = True
        txtItemCode.Text = stock_row.item_code
        txtItemName.Text = stock_row.item_name
        txtItemPrice.Text = stock_row.item_price
        txtItemQuantity.Text = stock_row.item_quantity
        txtItemCost.Text = stock_row.item_cost
        txtItemTotal.Text = stock_row.total_amount
        btnSave.Text = "Save Changes"

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim bill_item_table As New billingdbDataSet.bill_itemsDataTable
        Bill_itemsTableAdapter1.FillByStock_id(bill_item_table, stock_row.id)
        If bill_item_table.Rows.Count > 0 Then
            MsgBox("Stock present in the bill, cannot delete a stock which is in a bill.")
            Exit Sub
        End If
        If MsgBox("Are you sure you want to delete " + stock_row.item_name + " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim res As Integer = 0
            With stock_row
                res = Me.StocksTableAdapter.Delete(.id, .item_code, .item_name, .item_price, .item_quantity, .item_cost, .total_amount)
            End With
            reset()
            If res > 0 Then MsgBox("Stock details deleted.", MsgBoxStyle.Information) Else MsgBox("Some problem occured.", MsgBoxStyle.Information)
            btnDelete.Visible = False
            Me.StocksTableAdapter.Fill(Me.BillingdbDataSet.stocks)
            dgvStocks.Refresh()
            inventory()
        End If
    End Sub

    Private Sub txtItemCost_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItemCost.TextChanged
        If IsNumeric(txtItemCost.Text) And IsNumeric(txtItemQuantity.Text) Then
            txtItemTotal.Text = CDbl(txtItemCost.Text) * CDbl(txtItemQuantity.Text)
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        StocksTableAdapter.Search(BillingdbDataSet.stocks, "%" & txtSearch.Text & "%")
        dgvStocks.Refresh()
    End Sub
    Private Sub inventory()
        Dim i_stock_column As New System.Data.DataColumn("initial_stock", System.Type.GetType("System.Double"), "total_amount/item_cost", MappingType.Hidden)
        Dim stockdb As New billingdbDataSet.stocksDataTable
        Dim total_stock As Double = 0
        Dim total_sales As Double = 0
        Dim current_stock As Double = 0
        Dim i_stock As Double
        Dim c_stock As Double
        Dim sales As Double
        Dim i As Integer = 0
        stockdb.Columns.Add(i_stock_column)
        Me.StocksTableAdapter.Fill(stockdb)
        Dim stock_count As Integer = stockdb.Rows.Count

        For i = 0 To stock_count - 1
            sales = 0
            i_stock = 0
            c_stock = 0
            If IsNumeric(stockdb.Rows(i).Item("item_quantity")) And IsNumeric(stockdb.Rows(i).Item("initial_stock")) Then
                i_stock = stockdb.Rows(i).Item("initial_stock")
                c_stock = stockdb.Rows(i).Item("item_quantity")
            End If
            total_stock += stockdb.Rows(i).Item("total_amount")
            sales = (i_stock - c_stock) * stockdb.Rows(i).Item("item_cost")
            If Not Double.IsNaN(sales) Then total_sales += sales
        Next
        current_stock = total_stock - total_sales
        txtTotalStock.Text = total_stock
        If (total_sales) = Double.NaN Then MsgBox(total_sales)
        txtTotalSales.Text = total_sales
        txtCurrentStock.Text = current_stock
    End Sub

    Private Sub txtItemQuantity_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItemQuantity.TextChanged
        If IsNumeric(txtItemCost.Text) And IsNumeric(txtItemQuantity.Text) Then
            txtItemTotal.Text = CDbl(txtItemCost.Text) * CDbl(txtItemQuantity.Text)
        End If
    End Sub

    Private Sub btnDeleteAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteAll.Click
        Dim bill_table As New billingdbDataSet.billDataTable
        BillTableAdapter1.Fill(bill_table)
        If bill_table.Rows.Count > 0 Then
            MsgBox("Cannot delete all stocks. To do this all the bills must be deleted first.", MsgBoxStyle.Information)
            Exit Sub
        Else
            If MsgBox("Are you sure you want to delete all stocks? ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim cmd As New SQLite.SQLiteCommand
                Dim del_num As Integer = 0
                Dim delete_all As String = "DELETE FROM stocks;"
                Dim reset_c As String = "DELETE FROM sqlite_sequence WHERE name='stocks';"
                Dim connection As New SQLite.SQLiteConnection(My.Settings.billingdbConnectionString)
                cmd.Connection = connection
                connection.Open()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = delete_all
                del_num = cmd.ExecuteNonQuery()
                cmd.CommandText = reset_c
                cmd.ExecuteNonQuery()
                MsgBox(del_num & " entries deleted.", MsgBoxStyle.Information)
            End If
        End If
        Me.StocksTableAdapter.Fill(Me.BillingdbDataSet.stocks)
        dgvStocks.Refresh()
        inventory()
    End Sub
    Private Sub txtItemCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItemCode.LostFocus
        Dim stock_t As New billingdbDataSet.stocksDataTable
        StocksTableAdapter.FillByItemCode(stock_t, txtItemCode.Text)
        If stock_t.Count > 0 Then
            stock_row = stock_t.Rows(0)
            edit_flag = True
            btnDelete.Visible = True
            txtItemCode.Text = stock_row.item_code
            txtItemName.Text = stock_row.item_name
            txtItemPrice.Text = stock_row.item_price
            txtItemQuantity.Text = stock_row.item_quantity
            txtItemCost.Text = stock_row.item_cost
            txtItemTotal.Text = stock_row.total_amount
            btnSave.Text = "Save Changes"
        End If
    End Sub
End Class