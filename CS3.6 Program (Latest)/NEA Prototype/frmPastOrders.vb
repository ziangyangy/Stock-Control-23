Public Class frmPastOrders
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'searches for the order file to display
        If PresenceCheck(cBoxOrderID.Text) = False Then 'presence check for the order ID textbox
            MsgBox("Please enter the order ID.")
            Exit Sub
        End If

        Dim ArrCost(999) As Decimal 'array to store the cost of all the items in the order
        Dim totalCost As Decimal 'stores the total cost of the order
        Dim IndexCost As Integer 'stores the array size of the array arrCost
        IndexCost = 0 'initialisation
        ReadOrder(cBoxOrderID.Text) 'reads the order file and the order ID entered is passed as a parameter
        ReadStock() 'reads stock file
        lstOrder.Items.Clear() 'clears the list

        'adds the stock ordered to the list and stores the cost into the array
        For i = 0 To IndexStock - 1
            For j = 0 To maxAddOrderPageNumber - 1
                If arrStock(i).ID = arrAddOrders(0, j) Then 'if the stock ID matches the ID in the orders array
                    lstOrder.Items.Add(arrStock(i).ID & " " & arrStock(i).Name & " " & arrAddOrders(1, j)) 'adds the stock details to the list
                    ArrCost(j) = Convert.ToDecimal(arrStock(i).Cost) * Convert.ToInt32(arrAddOrders(1, j)) 'calculates the cost and stores in the ArrCost array
                    IndexCost = IndexCost + 1 'increments by 1 to keep track of the array size
                End If
            Next
        Next

        For i = 0 To IndexCost - 1
            totalCost = ArrCost(i) + totalCost 'works out the total cost
        Next

        txtCost.Text = "£" & totalCost 'displays the total cost
        txtDate.Text = OrderDate 'displays the order date
        txtSupplier.Text = Supplier 'displays the supplier
        txtStatus.Text = OrderStatus 'displays the order status
    End Sub

    Private Sub btnMngMenu_Click(sender As Object, e As EventArgs) Handles btnMngMenu.Click
        Me.Close()
        frmManagementMenu.Show() 'navigation button that loads the menu and closes the current form
    End Sub

    Private Sub btnDelOrder_Click(sender As Object, e As EventArgs) Handles btnDelOrder.Click
        'subroutine which deletes the order file
        Dim currentIndex As Integer 'variable which will store the index of the item to be deleted
        Dim found As Boolean 'stores whether the data has been found or not to give an error message
        found = False 'sets to false so it can be set to True later if found
        For i = 0 To IndexStock - 1 'finds the item
            If arrOrderIDs(i) = cBoxOrderID.Text Then 'checks if the ID in the array matches the ID in the combobox
                currentIndex = i 'sets the currentIndex to the position
                found = True 'sets to true as it has been found
            End If
        Next
        If found = True Then 'if the item is found then it deletes the data
            For i = currentIndex To IndexOrderID - 2 '-2 since the array size will have decreased by 1
                arrOrderIDs(i) = arrOrderIDs(i + 1) 'overwrites the stock data to delete it
            Next
            IndexOrderID = IndexOrderID - 1 'decreases the index stock by 1 before writing the data to file as array size has decreased by 1
            WriteOrderID() 'overwrites file with deleted order ID
            ReadOrderID() 'reads the order ID file to load the IDs back into the combobox
            DeleteOrder(cBoxOrderID.Text) 'deletes the file
            'clears the textboxes and list and combobox
            lstOrder.Items.Clear()
            txtCost.Clear()
            txtDate.Clear()
            txtStatus.Clear()
            txtSupplier.Clear()
            cBoxOrderID.Text = ""
            cBoxOrderID.Items.Clear()
            LoadOrderIDs() 'loads the IDs back into the combobox
        End If
    End Sub

    Private Sub frmPastOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loads the IDs into the combobox when the form loads
        LoadOrderIDs()
    End Sub

    Sub LoadOrderIDs()
        'subroutine which loads the order ID file into the combobox so the user can select the IDs
        ReadOrderID()
        For i = 0 To IndexOrderID - 1
            cBoxOrderID.Items.Add(arrOrderIDs(i))
        Next
    End Sub
End Class