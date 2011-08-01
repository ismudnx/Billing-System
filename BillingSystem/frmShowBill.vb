Public Class frmShowBill
    Dim current_i As Integer = -1
    'Dim initial_stock_column As New System.Data.DataColumn("initial_stock", System.Type.GetType("System.Double"), "total_amount/item_cost", MappingType.Hidden)
    Private Sub frmShowBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmMain
        Me.Top = 0
        Me.Left = 0
        'TODO: This line of code loads data into the 'BillingdbDataSet.bill' table. You can move, or remove it, as needed.
        Me.BillTableAdapter.Fill(Me.BillingdbDataSet.bill)
        total_of_amount()
    End Sub

    Private Sub dgvBill_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBill.CellClick
        current_i = dgvBill.SelectedRows(0).Index
        
    End Sub

    Private Sub txtBillnumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBillnumber.TextChanged
        BillTableAdapter.FillByBillNumber(BillingdbDataSet.bill, txtBillnumber.Text)
        dgvBill.Refresh()
        total_of_amount()
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        If current_i = -1 Then
            MsgBox("Select a bill to show", MsgBoxStyle.Information)
        Else
            frmBill.currentBillID = BillingdbDataSet.bill(current_i).id
            frmBill.show_flag = True
            current_i = -1
            frmBill.Show()
        End If
        
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim res As Integer
        If current_i = -1 Then
            MsgBox("Select a bill to delete", MsgBoxStyle.Information)
        Else
            If MsgBox("Do you want to delete the bill with bill number-" & BillingdbDataSet.bill(current_i).bill_number & " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                BillingdbDataSet.bill(current_i).Delete()
                current_i = -1
                res = BillTableAdapter.Update(BillingdbDataSet.bill)
                If res > 0 Then MsgBox("Bill Deleted Successfully.", MsgBoxStyle.Information) Else MsgBox("Some problem occured during Delete.", MsgBoxStyle.Information)
            End If
            Me.BillTableAdapter.Fill(Me.BillingdbDataSet.bill)
            dgvBill.Refresh()
            total_of_amount()
        End If
        current_i = -1
    End Sub

    Private Sub btnShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAll.Click
        Me.BillTableAdapter.Fill(Me.BillingdbDataSet.bill)
        dgvBill.Refresh()
        total_of_amount()
    End Sub

    
    Private Sub btnDeleteAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteAll.Click
        Dim bill_table As New billingdbDataSet.billDataTable
        BillTableAdapter.Fill(bill_table)
       
        If MsgBox("Are you sure you want to delete all bills? ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim cmd As New SQLite.SQLiteCommand
            Dim del_num As Integer = 0
            Dim delete_all As String = "DELETE FROM bill;"
            Dim reset_c As String = "DELETE FROM sqlite_sequence WHERE name ='bill';"
            Dim connection As New SQLite.SQLiteConnection(My.Settings.billingdbConnectionString)
            connection.Open()
            cmd.Connection = connection
            cmd.CommandType = CommandType.Text
            cmd.CommandText = delete_all
            del_num = cmd.ExecuteNonQuery()
            delete_all = "DELETE FROM bill_items;"
            cmd.CommandText = delete_all
            cmd.ExecuteNonQuery()
            cmd.CommandText = reset_c
            cmd.ExecuteNonQuery()
            reset_c = "DELETE FROM sqlite_sequence WHERE name ='bill_items';"
            cmd.CommandText = reset_c
            cmd.ExecuteNonQuery()
            MsgBox(del_num & "bills deleted.", MsgBoxStyle.Information)
        End If
        Me.BillTableAdapter.Fill(Me.BillingdbDataSet.bill)
        dgvBill.Refresh()
        total_of_amount()
    End Sub
    Sub total_of_amount()
        Dim bill_t As New billingdbDataSet.billDataTable
        BillTableAdapter.Fill(bill_t)
        Dim i, t_amount As Integer
        i = t_amount = 0
        For i = 0 To bill_t.Count - 1
            If IsNumeric(bill_t.Rows(i).Item("grand_total")) Then t_amount += bill_t.Rows(i).Item("grand_total")
        Next
        txtTotalofamount.Text = t_amount
        txtProfit.Text = t_amount - inventory()
    End Sub
    Private Function inventory() As Double
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
        Return total_sales

    End Function
End Class