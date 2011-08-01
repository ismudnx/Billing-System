Public Class frmCustomer
    Dim edit_flag = False
    Dim customerRow As billingdbDataSet.customerRow
    Private Sub frmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmMain
        Me.Top = 0
        Me.Left = 0
        'TODO: This line of code loads data into the 'BillingdbDataSet.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.BillingdbDataSet.customer)

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'validation
        Dim valid As Boolean = True
        If txtName.Text = "" Then
            txtName.BackColor = Color.LightSkyBlue
            valid = False
        Else
            txtName.BackColor = Color.White
        End If

        If txtAddress.Text = "" Then
            txtAddress.BackColor = Color.LightSkyBlue
            valid = False
        Else
            txtAddress.BackColor = Color.White

        End If

        If Not IsNumeric(txtPhone1.Text) Then
            txtPhone1.BackColor = Color.LightSkyBlue
            valid = False
        Else
            txtPhone1.BackColor = Color.White

        End If

        If Not IsNumeric(txtPhone2.Text) And txtPhone2.Text <> "" Then
            txtPhone2.BackColor = Color.LightSkyBlue
            valid = False
        Else
            txtPhone2.BackColor = Color.White

        End If

        If valid = True Then
            Dim res As Integer = 0
            If edit_flag = False Then
                res = Me.CustomerTableAdapter.Insert(txtName.Text, txtCity.Text, txtCountry.Text, _
                                           txtZip.Text, txtPhone1.Text, txtPhone2.Text, _
                                           txtAddress.Text, txtState.Text)
            Else
                customerRow.name = txtName.Text
                customerRow.address = txtAddress.Text
                customerRow.city = txtCity.Text
                customerRow.state = txtState.Text
                customerRow.country = txtCountry.Text
                customerRow.zip = txtZip.Text
                customerRow.phone_1 = txtPhone1.Text
                customerRow.phone_2 = txtPhone2.Text

                res = Me.CustomerTableAdapter.Update(customerRow)

            End If
            
            If res > 0 Then MsgBox("Customer details saved.", MsgBoxStyle.Information) Else MsgBox("some problem occured while saving", MsgBoxStyle.Information)
            reset()
            Me.CustomerTableAdapter.Fill(Me.BillingdbDataSet.customer)
            dgvCustomer.Refresh()
        Else
            MsgBox("Please fill the highlighted fields correctly.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub reset()
        txtName.Text = ""
        txtAddress.Text = ""
        txtCity.Text = ""
        txtCountry.Text = ""
        txtPhone1.Text = ""
        txtPhone2.Text = ""
        txtState.Text = ""
        txtZip.Text = ""
        edit_flag = False
        btnSave.Text = "Save"
        btnDelete.Visible = False

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        reset()
        
    End Sub

    Private Sub dgvCustomer_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCustomer.CellClick

        Dim current_index = dgvCustomer.SelectedRows(0).Index
        customerRow = BillingdbDataSet.customer.Rows(current_index)
        edit_flag = True
        btnDelete.Visible = True
        txtName.Text = customerRow.name
        txtAddress.Text = customerRow.address
        txtCity.Text = customerRow.city
        txtCountry.Text = customerRow.country
        txtPhone1.Text = customerRow.phone_1
        txtPhone2.Text = customerRow.phone_2
        txtState.Text = customerRow.state
        txtZip.Text = customerRow.zip
        btnSave.Text = "Save Changes"
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure you want to delete " + customerRow.name + " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim res As Integer = 0
            With customerRow
                res = Me.CustomerTableAdapter.Delete(.id, .name, .city, .country, .zip, .phone_1, .phone_2, .address, .state)
            End With
            reset()
            If res > 0 Then MsgBox("Customer details deleted.", MsgBoxStyle.Information) Else MsgBox("Some problem occured.", MsgBoxStyle.Information)
            btnDelete.Visible = False
            Me.CustomerTableAdapter.Fill(Me.BillingdbDataSet.customer)
            dgvCustomer.Refresh()

        End If
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

End Class
