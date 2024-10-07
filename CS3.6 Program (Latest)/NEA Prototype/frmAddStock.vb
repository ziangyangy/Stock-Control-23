Public Class frmAddStock
    Private Sub btnAddStock_Click(sender As Object, e As EventArgs) Handles btnAddStock.Click
        'this subroutine writes the new stock data to the stock file

        'validation:
        If PresenceCheck(txtName.Text) = False Then 'presence checks for all the textboxes with appropiate error messages if nothing is entered
            MsgBox("The name cannot be left blank.")
            Exit Sub
        End If

        If PresenceCheck(txtCuLevel.Text) = False Then
            MsgBox("The current level cannot be left blank.")
            Exit Sub
        End If

        If PresenceCheck(txtThLevel.Text) = False Then
            MsgBox("The threshold level cannot be left blank.")
            Exit Sub
        End If

        If PresenceCheck(txtCost.Text) = False Then
            MsgBox("The cost cannot be left blank.")
            Exit Sub
        End If

        'start of type checks with appropiate responses if they do not pass
        If IntTypeCheck(txtCuLevel.Text) = False Then 'checks if the quantity entered in an integer
            MsgBox("Please enter an integer into the current level box.")
            Exit Sub
        End If

        If IntTypeCheck(txtThLevel.Text) = False Then 'checks if the threshold entered is an integer
            MsgBox("Please enter an integer into the threshold level box.")
            Exit Sub
        End If

        If DecimalTypeCheck(txtCost.Text) = False Then 'checks if the cost entered is a real value
            MsgBox("Please enter the cost correctly.")
            Exit Sub
        End If

        If MoneyFormatCheck(txtCost.Text) = False Then 'checks if the cost has exactly two decimals places
            MsgBox("Please enter the cost correctly.")
            Exit Sub
        End If


        Dim IntCurrentQuantity As Integer 'stores the current quantity entered
        Dim IntThresholdLevel As Integer 'stores the threshold level entered

        'sets the variables to the data entered
        IntCurrentQuantity = Convert.ToInt32(txtCuLevel.Text)
        IntThresholdLevel = Convert.ToInt32(txtThLevel.Text)

        'reads stock data into runtime so the stock data can be added onto the end of the array
        ReadStock()

        Dim newID As Integer 'stores the new stock ID
        newID = getnewID("stock") 'calls the function to get a new stock id
        arrStock(IndexStock).ID = Convert.ToString(newID) 'sets the stock ID to the new ID
        arrStock(IndexStock).Name = txtName.Text 'sets the name to the name entered
        arrStock(IndexStock).CurrentQuantity = txtCuLevel.Text 'sets the current quantity to the quantity entered
        arrStock(IndexStock).ThresholdLevel = txtThLevel.Text 'sets the threshold level to the threshold level entered
        If IntCurrentQuantity < IntThresholdLevel Then 'works out whether the threshold level should be true or false
            arrStock(IndexStock).BelowThreshold = True 'true when the current quantity is less than the threshold
        Else
            arrStock(IndexStock).BelowThreshold = False 'false when the current quantity is bigger than the threshold
        End If
        arrStock(IndexStock).Cost = txtCost.Text 'sets the cost
        IndexStock = IndexStock + 1 'increments the stock index before writing to file
        WriteStock() 'writes data to file
        txtName.Clear() 'clears the textboxes
        txtCuLevel.Clear()
        txtThLevel.Clear()
        txtCost.Clear()
    End Sub

    Private Sub btnMngMenu_Click(sender As Object, e As EventArgs) Handles btnMngMenu.Click
        'this code checks which menu the user should be redirected to by checking if they have restricted access
        Me.Close() 'closes the current form
        For i = 0 To IndexStaff - 1 'loops through the staff array to find the user logged in
            If arrStaff(i).ID = UserLoggedIn Then 'checks the id for each staff member to the user that is currently logged in
                If arrStaff(i).RestrictInfo = False Then
                    frmManagementMenu.Show() 'shows the management menu form if their RestrictInfo variable is False
                Else
                    frmStaffMenu.Show() 'shows the staff menu form if their RestrictInfo variable is True
                End If
            End If
        Next
    End Sub
End Class