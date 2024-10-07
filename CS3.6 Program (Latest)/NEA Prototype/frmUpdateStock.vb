Public Class frmUpdateStock
    Dim selectedID As String 'stores the selected ID
    Dim selectedName As String 'stores the name entered
    Dim updateIndex As Integer = 0 'used to find the index of the item to be updated


    Private Sub btnupdateStock_Click(sender As Object, e As EventArgs) Handles btnUpdateStock.Click
        'this subroutine updates the stock data in the array with the data entered and write it to the file
        Dim IntCurrentQuantity As Integer 'stores the integer versions of the quantity and threshold
        Dim IntThresholdLevel As Integer 'used to see if .BelowThreshold will change


        'validation:
        If PresenceCheck(cmbID.Text) = False Then 'presence checks
            MsgBox("Please select the ID.")
            Exit Sub
        End If

        If PresenceCheck(cmbName.Text) = False Then
            MsgBox("Please select the name.")
            Exit Sub
        End If

        Try
            IntCurrentQuantity = Convert.ToInt32(txtCuLevel.Text) 'the current quantity and threshold are converted to integers
            IntThresholdLevel = Convert.ToInt32(txtThLevel.Text) 'they are stored in their Int variables

            'updates the array with the new information
            arrStock(updateIndex).Name = txtName.Text 'overwrites the name in the array with the name entered
            arrStock(updateIndex).CurrentQuantity = txtCuLevel.Text 'overwrites the quantity in the array with the quantity entered
            arrStock(updateIndex).ThresholdLevel = txtThLevel.Text 'overwrites the threshold in the array with the threshold entered
            If IntCurrentQuantity < IntThresholdLevel Then 'calculates whether it is below the threshold
                arrStock(updateIndex).BelowThreshold = "True"
            Else
                arrStock(updateIndex).BelowThreshold = "False"
            End If
            arrStock(updateIndex).Cost = txtCost.Text 'overwrites the cost in the array with the cost entered

            'clears the textboxes
            txtName.Clear()
            txtCuLevel.Clear()
            txtThLevel.Clear()
            txtCost.Clear()

            'writes to file and gives a message if the stock was successfully updated
            WriteStock()
            MsgBox(arrStock(updateIndex).Name & " sucessfully updated.")
        Catch ex As Exception
            MsgBox("Could not update " & txtName.Text) 'error message if unsuccessful
        End Try

    End Sub

    Private Sub frmUpdateStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'subroutine which loads the combobox options
        ReadStock() 'reads stock file
        For i = 0 To IndexStock - 1 'reads data from the array into the combo boxes
            cmbID.Items.Add(arrStock(i).ID)
            cmbName.Items.Add(arrStock(i).Name)
        Next
    End Sub

    Private Sub cBoxName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbName.SelectedIndexChanged
        'subroutine which updates the ID combobox when the name combobox is changed
        selectedID = cmbID.Text 'assigns the ID and name selected
        selectedName = cmbName.Text

        For i = 0 To IndexStock 'finds the index in the array that needs to be updated
            If arrStock(i).Name = selectedName Then
                updateIndex = i 'sets the update index to the index to be updated
            End If
        Next

        For i = 0 To IndexStock 'updates the ID combobox when the appropriate name is selected
            If arrStock(i).ID = selectedID Or arrStock(i).Name = selectedName Then 'matches the ID or name
                cmbID.Text = arrStock(i).ID 'updates the ID combobox
            End If
        Next

    End Sub

    Private Sub cBoxID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbID.SelectedIndexChanged
        'subroutine which updates the name combobox when the ID is selected
        selectedID = cmbID.Text 'assigns the ID and name selected
        selectedName = cmbName.Text

        For i = 0 To IndexStock 'finds the index in the array that needs to be updated
            If arrStock(i).ID = selectedID Then
                updateIndex = i 'sets the update index to the index to be updated
            End If
        Next

        For i = 0 To IndexStock  'updates the name combobox when the appropriate ID is selected
            If arrStock(i).ID = selectedID Or arrStock(i).Name = selectedName Then 'matches the ID and name
                cmbName.Text = arrStock(i).Name 'updates the name combobox
            End If
        Next
    End Sub

    Private Sub btnMngMenu_Click(sender As Object, e As EventArgs) Handles btnMngMenu.Click
        'subroutine which checks which menu the user should be redirected to by checking if they have restricted access
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




    Private Sub chkboxName_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxName.CheckedChanged
        'if the checkboxes are ticked then the textboxes are automatically filled out
        If chkboxName.Checked = True Then
            txtName.Text = arrStock(updateIndex).Name 'updates the name textbox
        Else
            txtName.Text = "" 'clears text if the checkbox is not checked
        End If
    End Sub

    Private Sub chkboxCuLevel_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxCuLevel.CheckedChanged
        'if the checkboxes are ticked then the textboxes are automatically filled out
        If chkboxCuLevel.Checked = True Then
            txtCuLevel.Text = arrStock(updateIndex).CurrentQuantity 'updates the quantity textbox
        Else
            txtCuLevel.Text = "" 'clears text if the checkbox is not checked
        End If
    End Sub

    Private Sub chkboxThLevel_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxThLevel.CheckedChanged
        'if the checkboxes are ticked then the textboxes are automatically filled out
        If chkboxThLevel.Checked = True Then
            txtThLevel.Text = arrStock(updateIndex).ThresholdLevel 'updates the threshold textbox
        Else
            txtThLevel.Text = "" 'clears text if the checkbox is not checked
        End If
    End Sub

    Private Sub chkboxCost_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxCost.CheckedChanged
        'if the checkboxes are ticked then the textboxes are automatically filled out
        If chkboxCost.Checked = True Then
            txtCost.Text = arrStock(updateIndex).Cost 'updates the cost textbox
        Else
            txtCost.Text = "" 'clears text if the checkbox is not checked
        End If
    End Sub

    Private Sub cmbName_TextChanged(sender As Object, e As EventArgs) Handles cmbName.TextChanged
        'subroutine which autofills the name if the first part is entered
        Dim spacePosition As Integer = 0 'stores the position of the "space" in the string
        For i = 0 To IndexStock - 1
            spacePosition = arrStock(i).Name.IndexOf(" ") 'works out the position of the space
            If spacePosition > 0 Then 'if the space isnt the first character of the string then
                If cmbName.Text.ToLower = arrStock(i).Name.Substring(0, spacePosition).ToLower Then 'if the name entered matches the first part of another name
                    cmbName.Text = arrStock(i).Name 'the stock name textbox is updated to the full name
                End If
            ElseIf cmbName.Text.ToLower = arrStock(i).Name.ToLower Then 'if the name entered matches the name in the array
                cmbName.Text = arrStock(i).Name 'matches the name entered to the name in file, main function is to match any capitalisations
            End If
        Next

        selectedID = cmbID.Text 'assigns the ID and name selected
        selectedName = cmbName.Text

        For i = 0 To IndexStock 'finds the index in the array that needs to be updated
            If arrStock(i).Name = selectedName Then
                updateIndex = i 'sets the update index to the index that needs updating
            End If
        Next

        For i = 0 To IndexStock 'updates the ID combobox when the appropriate name is selected
            If arrStock(i).ID = selectedID Or arrStock(i).Name = selectedName Then 'matches the ID or name
                cmbID.Text = arrStock(i).ID 'updates the ID combobox
            End If
        Next
    End Sub
End Class