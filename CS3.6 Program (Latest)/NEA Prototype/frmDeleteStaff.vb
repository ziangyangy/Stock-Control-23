Public Class frmDeleteStaff
    Private Sub cBoxNames_TextChanged(sender As Object, e As EventArgs) Handles cBoxNames.TextChanged
        'subroutine which autofills the name if the first part is entered
        Dim spacePosition As Integer = 0 'stores the position of the "space" in the string
        For i = 0 To IndexStaff - 1
            spacePosition = arrStaff(i).UserName.IndexOf(" ") 'works out the position of the space
            If spacePosition > 0 Then 'if the space isnt the first character of the string then
                If cBoxNames.Text.ToLower = arrStaff(i).UserName.Substring(0, spacePosition).ToLower Then 'if the name entered matches the first part of another name
                    cBoxNames.Text = arrStaff(i).UserName 'the stock name textbox is updated to the full name
                End If
            ElseIf cBoxNames.Text.ToLower = arrStaff(i).UserName.ToLower Then 'if the name entered matches the name in the array
                cBoxNames.Text = arrStaff(i).UserName 'matches the name entered to the name in file, main function is to match any capitalisations
            End If
        Next
    End Sub

    Private Sub frmDeleteStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData() 'calls sub to load in the combobox data when the menu first loads in
    End Sub

    Sub LoadData()
        'subroutine which loads the name combobox options
        cBoxNames.Items.Clear() 'clears the combobox items
        For i = 0 To IndexStaff - 1 'adds the names into the combobox
            cBoxNames.Items.Add(arrStaff(i).UserName)
        Next
    End Sub

    Private Sub btnMngMenu_Click(sender As Object, e As EventArgs) Handles btnMngMenu.Click
        Me.Close() 'navigation button that loads the menu and closes the current form
        frmManagementMenu.Show()
    End Sub

    Private Sub btnDeleteStaff_Click(sender As Object, e As EventArgs) Handles btnDeleteStaff.Click
        'subroutine which deletes the staff data
        'validation:
        If PresenceCheck(cBoxNames.Text) = False Then 'combobox presence check
            MsgBox("Please select a name.")
            Exit Sub
        End If

        Dim currentIndex As Integer 'stores the location of the item to be deleted
        Dim found As Boolean 'stores whether the data has been found or not to give an error message
        found = False 'sets to false so it can be set to True later if found
        For i = 0 To IndexStaff - 1 'finds the item
            If arrStaff(i).UserName = cBoxNames.Text Then 'checks if the name in the array matches the name in the combobox
                currentIndex = i 'sets the currentIndex to the position
                found = True 'sets to true as it has been found
            End If
        Next
        If found = True Then 'if the item is found
            For i = currentIndex To IndexStaff - 2 '-2 since the array size will have decreased by 1
                arrStaff(i) = arrStaff(i + 1) 'overwrites the stock data to delete it
            Next
            IndexStaff = IndexStaff - 1 'decreases the index stock by 1 before writing the data to file
            WriteStaff() 'writes the new stock information to the stock file
            cBoxNames.Text = "" 'removes the text in the combobox
            ReadStaff() 'reads the new stock information back into the program
            LoadData() 'calls sub to load in the combobox data
        Else
            MsgBox("Username not found.") 'if the item isn't found then outputs an appropiate message
        End If
    End Sub
End Class