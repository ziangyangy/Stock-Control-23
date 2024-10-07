Imports System.ComponentModel

Public Class frmStockList
    Dim temp As Stock 'stores the stock record to be swapped in the bubble sorts

    Private Sub Stock_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetList() 'calls the subroutine to reset the stock list
    End Sub

    Sub ResetList()
        'subroutine which resets the stock lists to the default order
        'reads the stock data into runtime
        ReadStock()

        'automatically ticks the ascending and name radio buttons
        rbtnAscending.Checked = True
        rbtnStockName.Checked = True

        'sorts the list into ascending order by name by default
        'calls the bubble sort to sort the names of the stock into ascending order
        BubbleName("ascending")

        'once the bubble sort has sorted the array into ascending order, the stock is displayed in the two list boxes
        For i = 0 To IndexStock - 1
            lstStock.Items.Add(arrStock(i).ID & vbTab & arrStock(i).Name)
            lstStock.Items.Add("")
            lstStockRight.Items.Add(arrStock(i).CurrentQuantity & vbTab & arrStock(i).ThresholdLevel & vbTab & arrStock(i).BelowThreshold & vbTab & arrStock(i).Cost)
            lstStockRight.Items.Add("")
        Next
    End Sub

    Sub BubbleName(Order As String) 'the Order determines whether the bubble sort sorts in ascending or descending order
        'bubble sort subroutine for the names
        Dim swapped As Boolean = True 'keeps track if there are any swaps made with each pass

        'ascending bubble sort
        If Order = "ascending" Then 'if an ascending order bubble sort is required then it executes the ascending order bubble sort
            While swapped = True 'set to True so it can keep looping until there is a pass with no swaps
                swapped = False 'set to False so if the program sets it to True again then a swap has been made
                For i = 0 To IndexStock - 2 'set to -2 instead of -1 because if i reaches the end of the array, i + 1 would be an overflow error
                    'if the first character of the name in the array in the first index is higher than the first character of the name in the array in the index after
                    If Convert.ToByte(Convert.ToChar(arrStock(i).Name.Replace(" ", "").Substring(0, 1).ToLower)) > (Convert.ToByte(Convert.ToChar(arrStock(i + 1).Name.Replace(" ", "").Substring(0, 1).ToLower))) Then
                        'swaps the records 
                        temp = arrStock(i)
                        arrStock(i) = arrStock(i + 1)
                        arrStock(i + 1) = temp
                        swapped = True 'set to True as a swap has been made
                    End If
                Next
            End While
        Else

            'descending bubble sort
            While swapped = True 'set to True so it can keep looping until there is a pass with no swaps
                swapped = False 'set to False so if the program sets it to True again then a swap has been made
                For i = 0 To IndexStock - 2 'set to -2 instead of -1 because if i reaches the end of the array, i + 1 would be an overflow error
                    'if the first character of the name in the array in the first index is lower than the first character of the name in the array in the index after
                    If Convert.ToByte(Convert.ToChar(arrStock(i).Name.Replace(" ", "").Substring(0, 1).ToLower)) < (Convert.ToByte(Convert.ToChar(arrStock(i + 1).Name.Replace(" ", "").Substring(0, 1).ToLower))) Then
                        'swaps the records 
                        temp = arrStock(i)
                        arrStock(i) = arrStock(i + 1)
                        arrStock(i + 1) = temp
                        swapped = True 'set to True as a swap has been made
                    End If
                Next
            End While
        End If
    End Sub

    Sub BubbleID(Order As String) 'the Order determines whether the bubble sort sorts in ascending or descending order
        'bubble sort subroutine for the IDs
        Dim swapped As Boolean = True 'keeps track if there are any swaps made with each pass

        'ascending bubble sort
        If Order = "ascending" Then 'if an ascending order bubble sort is required then it executes the ascending order bubble sort
            While swapped = True 'set to True so it can keep looping until there is a pass with no swaps
                swapped = False 'set to False so if the program sets it to True again then a swap has been made
                For i = 0 To IndexStock - 2 'set to -2 instead of -1 because if i reaches the end of the array, i + 1 would be an overflow error
                    'if the ID in the array in the first index is higher than the ID in the array in the index after
                    If Convert.ToInt32(arrStock(i).ID) > Convert.ToInt32(arrStock(i + 1).ID) Then
                        'swaps the records 
                        temp = arrStock(i)
                        arrStock(i) = arrStock(i + 1)
                        arrStock(i + 1) = temp
                        swapped = True 'set to True as a swap has been made
                    End If
                Next
            End While
        Else
            'descending bubble sort
            While swapped = True 'set to True so it can keep looping until there is a pass with no swaps
                swapped = False 'set to False so if the program sets it to True again then a swap has been made
                For i = 0 To IndexStock - 2 'set to -2 instead of -1 because if i reaches the end of the array, i + 1 would be an overflow error
                    'if the ID in the array in the first index is lower than the ID in the array in the index after
                    If Convert.ToInt32(arrStock(i).ID) < Convert.ToInt32(arrStock(i + 1).ID) Then
                        'swaps the records 
                        temp = arrStock(i)
                        arrStock(i) = arrStock(i + 1)
                        arrStock(i + 1) = temp
                        swapped = True 'set to True as a swap has been made
                    End If
                Next
            End While
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'subroutine which searches the array for a matching name and can also give search results if the first part of the name matches



        'validation:
        If PresenceCheck(txtSearch.Text) = False Then 'presence check for the search textbox
            MsgBox("Please enter something to search.")
            Exit Sub
        End If


        'clears the stock lists to show search results
        lstStock.Items.Clear()
        lstStockRight.Items.Clear()
        'linear search to display the item being searched
        'autofills the name if the first part is entered

        'matches the search result to the names in the array and displays the full name if part of the name is searched
        Dim spacePosition As Integer = 0 'stores the position of the "space" in the string
        Dim found As Boolean = False 'found variable to check if anything has been found
        For i = 0 To IndexStock - 1
            spacePosition = arrStock(i).Name.IndexOf(" ") 'works out the position of the space
            If spacePosition > 0 Then 'if the space isnt the first character of the string then
                If txtSearch.Text.ToLower = arrStock(i).Name.Substring(0, spacePosition).ToLower Then 'if the name entered matches the first part of another name
                    'displays the search results in the lists boxes
                    lstStock.Items.Add(arrStock(i).ID & vbTab & arrStock(i).Name)
                    lstStock.Items.Add("")
                    lstStockRight.Items.Add(arrStock(i).CurrentQuantity & vbTab & arrStock(i).ThresholdLevel & vbTab & arrStock(i).BelowThreshold & vbTab & arrStock(i).Cost)
                    lstStockRight.Items.Add("")
                    found = True
                End If
            ElseIf txtSearch.Text.ToLower = arrStock(i).Name.ToLower Then 'if the name entered matches the name in the array
                'displays the search results in the lists boxes
                lstStock.Items.Add(arrStock(i).ID & vbTab & arrStock(i).Name)
                lstStock.Items.Add("")
                lstStockRight.Items.Add(arrStock(i).CurrentQuantity & vbTab & arrStock(i).ThresholdLevel & vbTab & arrStock(i).BelowThreshold & vbTab & arrStock(i).Cost)
                lstStockRight.Items.Add("")
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Cannnot find search entered. Please enter a valid stock name.")
        End If
    End Sub


    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        'subroutine which sorts the stock list into the filters chosen

        'clears any previous items added to the list
        lstStock.Items.Clear()
        lstStockRight.Items.Clear()

        'the sorting code which displays the list according to the filters
        If rbtnID.Checked = True Then 'if the ID radio button is checked
            If rbtnAscending.Checked = True Then 'if the ascending button is checked then the array is sorted in ID ascending order
                'calls the ID bubble sort to sort the IDs in ascending order
                BubbleID("ascending")

                'adds the items to the lists in case the threshold buttons aren't checked
                For i = 0 To IndexStock - 1
                    lstStock.Items.Add(arrStock(i).ID & vbTab & arrStock(i).Name)
                    lstStock.Items.Add("")
                    lstStockRight.Items.Add(arrStock(i).CurrentQuantity & vbTab & arrStock(i).ThresholdLevel & vbTab & arrStock(i).BelowThreshold & vbTab & arrStock(i).Cost)
                    lstStockRight.Items.Add("")
                Next

                'if the below threshold button is checked then it lists the stock that are below threshold in ID ascending order
                If rbtnBelowThresholdLevel.Checked = True Then
                    lstStock.Items.Clear() 'clears the lists
                    lstStockRight.Items.Clear()

                    For i = 0 To IndexStock - 1
                        If arrStock(i).BelowThreshold = True Then 'checks if the stock in the array are below the threshold level
                            'lists the stock data in the stock lists
                            lstStock.Items.Add(arrStock(i).ID & vbTab & arrStock(i).Name)
                            lstStock.Items.Add("")
                            lstStockRight.Items.Add(arrStock(i).CurrentQuantity & vbTab & arrStock(i).ThresholdLevel & vbTab & arrStock(i).BelowThreshold & vbTab & arrStock(i).Cost)
                            lstStockRight.Items.Add("")
                        End If
                    Next

                    'if the above threshold button is checked then it lists the stock that are below threshold in ID ascending order
                ElseIf rbtnAboveThresholdLevel.Checked = True Then
                    lstStock.Items.Clear() 'clears the lists
                    lstStockRight.Items.Clear()

                    For i = 0 To IndexStock - 1
                        If arrStock(i).BelowThreshold = False Then 'checks if the stock in the array are above the threshold level
                            'lists the stock data in the stock lists
                            lstStock.Items.Add(arrStock(i).ID & vbTab & arrStock(i).Name)
                            lstStock.Items.Add("")
                            lstStockRight.Items.Add(arrStock(i).CurrentQuantity & vbTab & arrStock(i).ThresholdLevel & vbTab & arrStock(i).BelowThreshold & vbTab & arrStock(i).Cost)
                            lstStockRight.Items.Add("")
                        End If
                    Next
                End If

            ElseIf rbtnDescending.Checked = True Then 'if the descending button is checked then the array is sorted in ID descending order
                'calls the ID bubble sort to sort the IDs in descending order
                BubbleID("descending")

                'adds the items to the lists in case the threshold buttons aren't checked
                For i = 0 To IndexStock - 1
                    lstStock.Items.Add(arrStock(i).ID & vbTab & arrStock(i).Name)
                    lstStock.Items.Add("")
                    lstStockRight.Items.Add(arrStock(i).CurrentQuantity & vbTab & arrStock(i).ThresholdLevel & vbTab & arrStock(i).BelowThreshold & vbTab & arrStock(i).Cost)
                    lstStockRight.Items.Add("")
                Next

                'if the below threshold button is checked then it lists the stock that are below threshold in ID descending order
                If rbtnBelowThresholdLevel.Checked = True Then
                    lstStock.Items.Clear() 'clears the lists
                    lstStockRight.Items.Clear()

                    For i = 0 To IndexStock - 1
                        If arrStock(IndexStock - i).BelowThreshold = True Then 'checks if the stock in the array are below the threshold level
                            'lists the stock data in the stock lists
                            lstStock.Items.Add(arrStock(i).ID & vbTab & arrStock(i).Name)
                            lstStock.Items.Add("")
                            lstStockRight.Items.Add(arrStock(i).CurrentQuantity & vbTab & arrStock(i).ThresholdLevel & vbTab & arrStock(i).BelowThreshold & vbTab & arrStock(i).Cost)
                            lstStockRight.Items.Add("")
                        End If
                    Next

                    'if the above threshold button is checked then it lists the stock that are below threshold in ID descending order
                ElseIf rbtnAboveThresholdLevel.Checked = True Then
                    lstStock.Items.Clear() 'clears the lists
                    lstStockRight.Items.Clear()

                    For i = 0 To IndexStock - 1
                        If arrStock(IndexStock - i).BelowThreshold = False Then 'checks if the stock in the array are above the threshold level
                            'lists the stock data in the stock lists
                            lstStock.Items.Add(arrStock(i).ID & vbTab & arrStock(i).Name)
                            lstStock.Items.Add("")
                            lstStockRight.Items.Add(arrStock(i).CurrentQuantity & vbTab & arrStock(i).ThresholdLevel & vbTab & arrStock(i).BelowThreshold & vbTab & arrStock(i).Cost)
                            lstStockRight.Items.Add("")
                        End If
                    Next
                End If
            End If

        ElseIf rbtnStockName.Checked = True Then 'if the name radio button is checked
            If rbtnAscending.Checked = True Then 'if the ascending button is checked then the array is sorted in name ascending order
                'calls the name bubble sort to sort the names in ascending order
                BubbleName("ascending")

                'adds the items to the lists in case the threshold buttons aren't checked
                For i = 0 To IndexStock - 1
                    lstStock.Items.Add(arrStock(i).ID & vbTab & arrStock(i).Name)
                    lstStock.Items.Add("")
                    lstStockRight.Items.Add(arrStock(i).CurrentQuantity & vbTab & arrStock(i).ThresholdLevel & vbTab & arrStock(i).BelowThreshold & vbTab & arrStock(i).Cost)
                    lstStockRight.Items.Add("")
                Next

                'if the below threshold button is checked then it lists the stock that are below threshold in name ascending order
                If rbtnBelowThresholdLevel.Checked = True Then
                    lstStock.Items.Clear() 'clears the lists
                    lstStockRight.Items.Clear()

                    For i = 0 To IndexStock - 1
                        If arrStock(i).BelowThreshold = True Then 'checks if the stock in the array are below the threshold level
                            'lists the stock data in the stock lists
                            lstStock.Items.Add(arrStock(i).ID & vbTab & arrStock(i).Name)
                            lstStock.Items.Add("")
                            lstStockRight.Items.Add(arrStock(i).CurrentQuantity & vbTab & arrStock(i).ThresholdLevel & vbTab & arrStock(i).BelowThreshold & vbTab & arrStock(i).Cost)
                            lstStockRight.Items.Add("")
                        End If
                    Next

                    'if the above threshold button is checked then it lists the stock that are above threshold in name ascending order
                ElseIf rbtnAboveThresholdLevel.Checked = True Then
                    lstStock.Items.Clear() 'clears the lists
                    lstStockRight.Items.Clear()

                    For i = 0 To IndexStock - 1
                        If arrStock(i).BelowThreshold = False Then 'checks if the stock in the array are above the threshold level
                            'lists the stock data in the stock lists
                            lstStock.Items.Add(arrStock(i).ID & vbTab & arrStock(i).Name)
                            lstStock.Items.Add("")
                            lstStockRight.Items.Add(arrStock(i).CurrentQuantity & vbTab & arrStock(i).ThresholdLevel & vbTab & arrStock(i).BelowThreshold & vbTab & arrStock(i).Cost)
                            lstStockRight.Items.Add("")
                        End If
                    Next
                End If

            ElseIf rbtnDescending.Checked = True Then 'if the descending button is checked then the array is sorted in name descending order
                'bubble sort to sort the names of the stock into descending order
                BubbleName("descending")

                'adds the items to the lists in case the threshold buttons aren't checked
                For i = 0 To IndexStock - 1
                    lstStock.Items.Add(arrStock(i).ID & vbTab & arrStock(i).Name)
                    lstStock.Items.Add("")
                    lstStockRight.Items.Add(arrStock(i).CurrentQuantity & vbTab & arrStock(i).ThresholdLevel & vbTab & arrStock(i).BelowThreshold & vbTab & arrStock(i).Cost)
                    lstStockRight.Items.Add("")
                Next

                'if the below threshold button is checked then it lists the stock that are below threshold in name descending order
                If rbtnBelowThresholdLevel.Checked = True Then
                    lstStock.Items.Clear() 'clears the lists
                    lstStockRight.Items.Clear()

                    For i = 0 To IndexStock - 1
                        If arrStock(i).BelowThreshold = True Then 'checks if the stock in the array are below the threshold level
                            'lists the stock data in the stock lists
                            lstStock.Items.Add(arrStock(i).ID & vbTab & arrStock(i).Name)
                            lstStock.Items.Add("")
                            lstStockRight.Items.Add(arrStock(i).CurrentQuantity & vbTab & arrStock(i).ThresholdLevel & vbTab & arrStock(i).BelowThreshold & vbTab & arrStock(i).Cost)
                            lstStockRight.Items.Add("")
                        End If
                    Next

                    'if the above threshold button is checked then it lists the stock that are above threshold in name descending order
                ElseIf rbtnAboveThresholdLevel.Checked = True Then
                    lstStock.Items.Clear() 'clears the lists
                    lstStockRight.Items.Clear()

                    For i = 0 To IndexStock - 1
                        If arrStock(i).BelowThreshold = False Then 'checks if the stock in the array are above the threshold level
                            'lists the stock data in the stock lists
                            lstStock.Items.Add(arrStock(i).ID & vbTab & arrStock(i).Name)
                            lstStock.Items.Add("")
                            lstStockRight.Items.Add(arrStock(i).CurrentQuantity & vbTab & arrStock(i).ThresholdLevel & vbTab & arrStock(i).BelowThreshold & vbTab & arrStock(i).Cost)
                            lstStockRight.Items.Add("")
                        End If
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'thsi subroutine resets the list to the default order when the reset button is clicked
        lstStock.Items.Clear() 'clears any items remaining in the list and reloads the items
        lstStockRight.Items.Clear()
        ResetList() 'calls the subroutine that resets the stock lists
        'unchecks the threshold radio buttons
        rbtnAboveThresholdLevel.Checked = False
        rbtnBelowThresholdLevel.Checked = False
    End Sub

    Private Sub btnMngMenu_Click(sender As Object, e As EventArgs) Handles btnMngMenu.Click
        'this subroutine checks which menu the user should be redirected to by checking if they have restricted access
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

    Private Sub lstStock_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStock.SelectedIndexChanged
        'when the list box is clicked on and the index is changed, the index of the other listbox matches
        'this ensures the user knows which row of data matches both listboxes
        lstStockRight.SelectedIndex = lstStock.SelectedIndex
    End Sub

    Private Sub lstStockRight_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStockRight.SelectedIndexChanged
        'when the list box is clicked on and the index is changed, the index of the other listbox matches
        'this ensures the user knows which row of data matches both listboxes
        lstStock.SelectedIndex = lstStockRight.SelectedIndex
    End Sub
End Class