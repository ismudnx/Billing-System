Public Class frmBill
    Public currentBillID As Integer
    Public show_flag As Boolean = False
    Dim billTable As New billingdbDataSet.billDataTable
    Dim stockTable As New billingdbDataSet.stocksDataTable
    Dim itemTable As New billingdbDataSet.bill_itemsDataTable
    Dim billRow As billingdbDataSet.billRow
    Dim sub_total As Double = 0
    Dim grand_total As Double = 0
    Dim discount As Double = 0
    Dim tax As Double = 0
    Dim discount_amt As Double = 0
    Dim tax_amt As Double = 0
    Dim save_flag As Boolean = False
    Dim cancel_flag As Boolean = False
    Dim no_item As Boolean = False

    Private Sub frmBill_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        If save_flag = False And show_flag = False And cancel_flag = False Then
            billTable.Last.Delete()
            BillTableAdapter1.Update(billTable)
        End If
    End Sub

    Private Sub frmBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmMain
        Me.Top = 0
        Me.Left = 0
        Dim bill_n As Integer = GetSetting("Billing System", "Bills", "Billnumber", 100)

        If show_flag = False Then
            BillTableAdapter1.AddNew()
            BillTableAdapter1.Fill(billTable)
            billRow = billTable.Last
            billRow.bill_number = bill_n + 1
            currentBillID = billRow.id
            frmPrint.bill_id = currentBillID

        Else
            BillTableAdapter1.Fill(billTable)
            billRow = billTable.FindByid(currentBillID)
            frmPrint.bill_id = currentBillID
            btnSaveBill.Enabled = True
            btnCancelBill.Enabled = False
            btnPrintBill.Enabled = True
            dgvBill.Enabled = False
        End If

        Bill_itemsTableAdapter1.FillByBillId(itemTable, billRow.id)

        txtSubTotal.Text = sub_total
        txtTotal.Text = grand_total
        populate()
        'frmPrint.bill_id = currentBillID

    End Sub

    Private Sub btnSaveBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveBill.Click
        'validation
        Dim valid As Boolean = True

        If Not IsNumeric(txtBillNumber.Text) Then
            txtBillNumber.BackColor = Color.LightSkyBlue
            valid = False
        Else
            txtBillNumber.BackColor = Color.White

        End If

        If txtCustomerName.Text = "" Then
            txtCustomerName.BackColor = Color.LightSkyBlue
            valid = False
        Else
            txtCustomerName.BackColor = Color.White
        End If


        Dim res1, res2, res3, i As Integer
        If valid = True Then
            If MsgBox("Save the Bill?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                billRow.bill_number = txtBillNumber.Text
                billRow.customer_name = txtCustomerName.Text
                billRow.customer_address = txtCustomerAddress.Text
                billRow.bill_date = txtDate.Text
                billRow.sub_total = txtSubTotal.Text
                billRow.discount = txtDiscount.Text
                billRow.tax = txtTax.Text
                billRow.grand_total = txtTotal.Text
               
                StocksTableAdapter1.Fill(stockTable)
                If show_flag = False Then
                    If itemTable.Rows.Count > 0 Then
                        For i = 0 To itemTable.Rows.Count - 1
                            stockTable.FindByid(itemTable.Rows(i).Item(1)).item_quantity -= itemTable.Rows(i).Item(2)
                        Next
                    End If
                End If
                res3 = StocksTableAdapter1.Update(stockTable)
                res2 = Bill_itemsTableAdapter1.Update(itemTable)
                res1 = BillTableAdapter1.Update(billRow)
                If res1 > 0 Then
                    SaveSetting("Billing System", "Bills", "Billnumber", txtBillNumber.Text)
                    MsgBox("Bill Saved Successfully. " & res2 & " item(s) added.", MsgBoxStyle.Information)
                    save_flag = True
                    btnSaveBill.Enabled = False
                    btnCancelBill.Enabled = False
                    btnPrintBill.Enabled = True
                Else
                    MsgBox("Sorry Some problem Occured. Cannot save the bill.", MsgBoxStyle.Information)
                End If
            End If
        Else
            MsgBox("Complete the highlighted fields.", MsgBoxStyle.Information)

        End If
       

    End Sub

    Private Sub btnPrintBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintBill.Click
        frmPrint.Show()
        Dim i As Integer
        Dim str As String = "StId Q BId" + vbNewLine
        For i = 0 To itemTable.Rows.Count - 1
            str = str + CStr(itemTable.Rows(i).Item(1)) + " " + CStr(itemTable.Rows(i).Item(2)) + " " + CStr(itemTable.Rows(i).Item(3)) + vbNewLine
        Next
        'MsgBox(str)
    End Sub

    Private Sub btnCancelBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelBill.Click
        billTable.Last.Delete()
        BillTableAdapter1.Update(billTable)
        cancel_flag = True
        Me.Close()
    End Sub

    Private Sub dgvBill_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBill.CellEndEdit

        Dim res As Integer = 0
        'MsgBox(dgvBill.CurrentCell.Value)
        'stockTable = Nothing
        If item_code.Index = dgvBill.CurrentCell.OwningColumn.Index Then
            If dgvBill.CurrentCell.Value <> Nothing Then
                res = StocksTableAdapter1.FillByItemCode(stockTable, dgvBill.CurrentCell.Value.ToString)
            End If

            If res > 0 Then
                dgvBill.CurrentRow.Cells(1).Value = stockTable.First.item_name
                dgvBill.CurrentRow.Cells(2).Value = stockTable.First.item_price
                dgvBill.CurrentRow.Cells(3).Value = 1
                dgvBill.CurrentRow.Cells(4).Value = stockTable.First.item_price
                no_item = False
                itemTable.Rows(dgvBill.CurrentRow.Index).Item(1) = stockTable.First.id
                itemTable.Rows(dgvBill.CurrentRow.Index).Item(2) = 1
            Else
                dgvBill.CurrentRow.Cells(1).Value = "-No such item-"
                dgvBill.CurrentRow.Cells(2).Value = ""
                dgvBill.CurrentRow.Cells(3).Value = ""
                dgvBill.CurrentRow.Cells(4).Value = ""
                MsgBox("-No such item-")
                no_item = True
                itemTable.Rows(dgvBill.CurrentRow.Index).Delete()
                dgvBill.Rows.Remove(dgvBill.CurrentRow)

            End If
        End If

        If item_quantity.Index = dgvBill.CurrentCell.OwningColumn.Index And no_item = False Then
            If Not IsNumeric(dgvBill.CurrentRow.Cells(3).Value) Then dgvBill.CurrentRow.Cells(3).Value = 0
            If CDbl(dgvBill.CurrentRow.Cells(3).Value) > CDbl(stockTable.First.item_quantity) Then
                MsgBox("Only " + CStr(stockTable.First.item_quantity) + " items present in the Stock.", MsgBoxStyle.Information)
                dgvBill.CurrentRow.Cells(3).Value = CDbl(stockTable.First.item_quantity)
            End If
            itemTable.Rows(dgvBill.CurrentRow.Index).Item(2) = dgvBill.CurrentRow.Cells(3).Value
            'stockTable.First.item_quantity = stockTable.First.item_quantity - CDbl(dgvBill.CurrentRow.Cells(3).Value)
            dgvBill.CurrentRow.Cells(4).Value = CDbl(dgvBill.CurrentRow.Cells(2).Value) * CDbl(dgvBill.CurrentRow.Cells(3).Value)

        End If

    End Sub
    Private Sub row_removed(ByVal sender As Object, ByVal e As EventArgs)
        MsgBox("removed")
    End Sub
    Private Sub dgvBill_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBill.RowLeave
        calculate()
    End Sub

    Private Sub dgvBill_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgvBill.UserAddedRow
        itemTable.Addbill_itemsRow(0, 0, billRow.id)
    End Sub

    Private Sub dgvBill_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles dgvBill.UserDeletingRow
        itemTable.Rows(dgvBill.CurrentRow.Index).Delete()
    End Sub

    Private Sub txtDiscount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscount.TextChanged
        calculate()
    End Sub

    Private Sub txtTax_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTax.TextChanged
        calculate()
    End Sub

    Sub calculate()
        Dim temp As Double = 0
        sub_total = 0
        grand_total = 0

        Dim i As Integer = 0
        For i = 0 To dgvBill.RowCount - 1
            If IsNumeric(dgvBill.Rows(i).Cells(4).Value) Then sub_total += CDbl(dgvBill.Rows(i).Cells(4).Value)
        Next
        If IsNumeric(txtTax.Text) Then tax = CDbl(txtTax.Text) Else tax = 0
        If IsNumeric(txtDiscount.Text) Then discount = CDbl(txtDiscount.Text) Else discount = 0
        discount_amt = discount
        temp = sub_total - discount_amt
        tax_amt = tax
        grand_total = temp + tax_amt
        txtSubTotal.Text = sub_total
        txtTotal.Text = grand_total
    End Sub
    Sub populate()
        Dim i As Integer
        Dim stockR As billingdbDataSet.stocksRow
        With billRow
            txtBillNumber.Text = .bill_number
            txtCustomerName.Text = .customer_name
            txtCustomerAddress.Text = .customer_address
            If .bill_date <> "" Then txtDate.Value = .bill_date
            txtSubTotal.Text = .sub_total
            txtDiscount.Text = .discount
            txtTax.Text = .tax
            txtTotal.Text = .grand_total
        End With
        StocksTableAdapter1.Fill(stockTable)
        If itemTable.Rows.Count > 0 Then
            dgvBill.Rows.Add(itemTable.Rows.Count)
            For i = 0 To itemTable.Rows.Count - 1
                stockR = stockTable.FindByid(itemTable.Rows(i).Item(1))
                dgvBill.Rows(i).Cells(0).Value = stockR.item_code
                dgvBill.Rows(i).Cells(1).Value = stockR.item_name
                dgvBill.Rows(i).Cells(2).Value = stockR.item_price
                dgvBill.Rows(i).Cells(3).Value = itemTable.Rows(i).Item(2)
                dgvBill.Rows(i).Cells(4).Value = CDbl(dgvBill.Rows(i).Cells(2).Value) * CDbl(dgvBill.Rows(i).Cells(3).Value)
            Next
        End If
        calculate()
    End Sub
    
End Class