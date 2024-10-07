Public Class frmDeleteStock
    Private Sub frmDeleteStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'subroutine which loads data into runtime
        ReadStock() 'reads stock file
        LoadData() 'calls sub to load in the combobox data
    End Sub

    Sub LoadData()
        'subroutine which loads the stock names into the combobox
        cmbBoxNames.Items.Clear() 'clears the combobox items
        For i = 0 To IndexStock - 1 'adds the names into the combobox
            cmbBoxNames.Items.Add(arrStock(i).Name)
        Next
    End Sub

    Private Sub btnMngMenu_Click(sender As Object, e As EventArgs) Handles btnMngMenu.Click
        Me.Close() 'navigation button that loads the menu and closes the current form
        frmManagementMenu.Show()
    End Sub

    Private Sub btnDeleteStock_Click(sender As Object, e As EventArgs) Handles btnDeleteStock.Click
        'subroutine which deletes the stock data from the file
        'validation:
        If PresenceCheck(cmbBoxNames.Text) = False Then 'presence check for the name
            MsgBox("Please select a name.")
            Exit Sub
        End If

        Dim currentIndex As Integer 'variable which will store the index of the item to be deleted
        Dim found As Boolean 'stores whether the data has been found or not to give an error message
        found = False 'sets to false so it can be set to True later if found
        For i = 0 To IndexStock - 1 'finds the item
            If arrStock(i).Name = cmbBoxNames.Text Then 'checks if the name in the array matches the name in the combobox
                currentIndex = i 'sets the currentIndex to the position
                found = True 'sets to true as it has been found
            End If
        Next
        If found = True Then 'if the item is found then it deletes the data
            For i = currentIndex To IndexStock - 2 '-2 since the array size will have decreased by 1
                arrStock(i) = arrStock(i + 1) 'overwrites the stock data to delete it
            Next
            IndexStock = IndexStock - 1 'decreases the index stock by 1 before writing the data to file
            WriteStock() 'writes the new stock information to the stock file
            cmbBoxNames.Text = "" 'removes the text in the combobox
            ReadStock() 'reads the new stock information back into the program
            LoadData() 'calls sub to load in the combobox data
        Else
            MsgBox("Please select an item.") 'if the item isn't found then outputs an appropiate message
        End If
    End Sub

    Private Sub cmbBoxNames_TextChanged(sender As Object, e As EventArgs) Handles cmbBoxNames.TextChanged
        'subroutine which autofills the name if the first part is entered
        Dim spacePosition As Integer = 0 'stores the position of the "space" in the string
        For i = 0 To IndexStock - 1
            spacePosition = arrStock(i).Name.IndexOf(" ") 'works out the position of the space
            If spacePosition > 0 Then 'if the space isnt the first character of the string then
                If cmbBoxNames.Text.ToLower = arrStock(i).Name.Substring(0, spacePosition).ToLower Then 'if the name entered matches the first part of another name
                    cmbBoxNames.Text = arrStock(i).Name 'the stock name textbox is updated to the full name
                End If
            ElseIf cmbBoxNames.Text.ToLower = arrStock(i).Name.ToLower Then 'if the name entered matches the name in the array
                cmbBoxNames.Text = arrStock(i).Name 'matches the name entered to the name in file, main function is to match any capitalisations
            End If
        Next
    End Sub
End Class