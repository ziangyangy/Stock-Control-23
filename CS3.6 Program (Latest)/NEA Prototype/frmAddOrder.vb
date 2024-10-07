Public Class frmAddOrder
    Private Sub frmAddOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'this subroutine clears all the textboxes and comboboxes and loads 
        'the suppliers and the different status into their comboboxes
        cBoxStatus.Items.Clear()  'clears the status combobox
        addOrderPageNumber = 0
        For i = 0 To 999 'clears the order array
            arrAddOrders(0, i) = ""
            arrAddOrders(1, i) = ""
            arrAddOrders(2, i) = ""
        Next
        'loads the options to choose from into the status combobox
        cBoxStatus.Items.Add("Ordered")
        cBoxStatus.Items.Add("Dispatched")
        cBoxStatus.Items.Add("In Transit")
        cBoxStatus.Items.Add("Delivered")
        cBoxStatus.Items.Add("Returned")

        cBoxSupplier.Items.Clear()   'clears the supplier combobox and loads the supplier names

        'loads the suppliers into the supplier combobox
        ReadSupplier() 'reads supplier file into array
        For i = 0 To IndexSupplier - 1
            cBoxSupplier.Items.Add(arrSupplier(i).Name) 'loads the supplier names from the record in the array into the combobox
        Next

        maxAddOrderPageNumber = 0 'sets the maximum number of pages to 0 to clear previous data
        txtPage.Text = addOrderPageNumber + 1 & " / " & maxAddOrderPageNumber + 1 'displays the current page

        ReadStock() 'reads stock file to load stock data into runtime
    End Sub

    Private Sub btnMngMenu_Click(sender As Object, e As EventArgs) Handles btnMngMenu.Click
        'navigation subroutine to redirect to other forms
        Me.Close()
        frmManagementMenu.Show() 'navigation button that loads the menu and closes the current form
    End Sub

    Private Sub btnPastOrders_Click(sender As Object, e As EventArgs) Handles btnPastOrders.Click
        'navigation subroutine to redirect to other forms
        Me.Close()
        frmPastOrders.Show() 'navigation button that loads frmPastOrders and closes the current form
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'this subroutine clears the data from the stock textboxes, and "loads" a new page to enter more stock data 
        'when the next button is clicked
        'to do this the stock data entered is stored in a 2D array so the data can be accessed 
        'when the data needs to be written to the stock history files 

        'validation
        If PresenceCheck(txtStockID.Text) = False Then 'presence checks to check if there is data present
            MsgBox("Please enter the stock ID") 'checks the stock ID textbox
            Exit Sub
        End If

        If PresenceCheck(txtStockName.Text) = False Then
            MsgBox("Please enter the stock name") 'checks the stock name textbox
            Exit Sub
        End If

        If PresenceCheck(txtQuantity.Text) = False Then
            MsgBox("Please enter the quantity ordered.") 'checks the quantity checkbox
            Exit Sub
        End If

        'reads the data entered from the textboxes into the array
        arrAddOrders(0, addOrderPageNumber) = txtStockID.Text
        arrAddOrders(1, addOrderPageNumber) = txtQuantity.Text 'arr(x,y) where x stores the stock ID, quantity and name
        arrAddOrders(2, addOrderPageNumber) = txtStockName.Text 'y keeps track of the quantity of stock

        addOrderPageNumber = addOrderPageNumber + 1 'current page number is incremented by 1


        txtStockID.Clear() 'clears the bottom 3 stock data textboxes as different stock information needs to be entered
        txtStockName.Clear()
        txtQuantity.Clear()


        'if there is existing data in the next page then it loads it in
        If addOrderPageNumber < 999 Then 'the maximum size of the 2D array is (2,999), so it must not exceed 999 or the program will crash
            txtStockID.Text = arrAddOrders(0, addOrderPageNumber) 'loads in any previous values stored in the array into the textboxes
            txtQuantity.Text = arrAddOrders(1, addOrderPageNumber)
            txtStockName.Text = arrAddOrders(2, addOrderPageNumber)

            If maxAddOrderPageNumber < addOrderPageNumber Then 'updates the maximum number of pages if it is smaller than the current page number
                maxAddOrderPageNumber = addOrderPageNumber 'this prevents the maximum number of pages incrementing when it doesn't need to
            End If

            txtPage.Text = addOrderPageNumber + 1 & " / " & maxAddOrderPageNumber + 1 'updates the textbox that shows the current page
        Else
            addOrderPageNumber = addOrderPageNumber - 1 'goes back to its previous value so it doesn't crash the program
        End If
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        'this subroutine clears the data from the stock textboxes, and "loads" a new page to enter more stock data 
        'when the previous button is clicked
        'to do this the stock data entered is stored in a 2D array so the data can be accessed 
        'when the data needs to be written to the stock history files 

        'reads the data entered from the textboxes into the array
        arrAddOrders(0, addOrderPageNumber) = txtStockID.Text 'reads the data entered from the bottom 3 stock data textboxes into the array
        arrAddOrders(1, addOrderPageNumber) = txtQuantity.Text
        arrAddOrders(2, addOrderPageNumber) = txtStockName.Text

        addOrderPageNumber = addOrderPageNumber - 1 'current page number is decreased by 1 to keep track of the current page the user is on

        'if there is existing data in the next page then it loads it in
        If addOrderPageNumber >= 0 Then 'checks if it will be negative, otherwise if it goes negative the program crashes since arrAddOrders cannot have a negative y value
            txtStockID.Text = arrAddOrders(0, addOrderPageNumber) 'loads in any previous values stored in the array into the stock data textboxes
            txtQuantity.Text = arrAddOrders(1, addOrderPageNumber)
            txtStockName.Text = arrAddOrders(2, addOrderPageNumber)

            txtPage.Text = addOrderPageNumber + 1 & " / " & maxAddOrderPageNumber + 1 'updates the textbox that shows the current page
        Else
            addOrderPageNumber = addOrderPageNumber + 1 'goes back to its previous value so it doesn't crash the program
        End If
    End Sub

    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        'this subroutine writes the order to the file and stores the order ID in a separate file
        'it updates the stock yearly data by using the date of the order to update the number of stock ordered in the month of the order

        'validation:
        If PresenceCheck(txtOrderID.Text) = False Then 'presence check for the order id textbox
            MsgBox("Please enter the order ID.")
            Exit Sub
        End If

        If PresenceCheck(cBoxSupplier.Text) = False Then 'presence check for the supplier 
            MsgBox("Please select a supplier.")
            Exit Sub
        End If

        If PresenceCheck(cBoxStatus.Text) = False Then 'presence check for the status
            MsgBox("Please select a supplier.")
            Exit Sub
        End If

        If PresenceCheck(txtStockID.Text) = False Then 'presence checks for the 3 stock textboxes
            MsgBox("Please enter the stock ID")
            Exit Sub
        End If

        If PresenceCheck(txtStockName.Text) = False Then
            MsgBox("Please enter the stock name")
            Exit Sub
        End If

        If PresenceCheck(txtQuantity.Text) = False Then
            MsgBox("Please enter the quantity ordered.")
            Exit Sub
        End If



        arrAddOrders(0, addOrderPageNumber) = txtStockID.Text 'reads the data from the current page 
        arrAddOrders(1, addOrderPageNumber) = txtQuantity.Text 'entered from the textboxes into the array
        arrAddOrders(2, addOrderPageNumber) = txtStockName.Text


        'writes the order information to the order file
        Try
            WriteOrder(txtOrderID.Text, Convert.ToString(dpOrderDate.Value), cBoxStatus.Text, cBoxSupplier.Text)
            MsgBox("Order added.")
        Catch ex As Exception
            MsgBox("Error: could not add order.")
        End Try

        ReadOrderID() 'reads the order ID file

        arrOrderIDs(IndexOrderID) = txtOrderID.Text 'adds the entered order ID from the textbox onto the end of the array

        IndexOrderID = IndexOrderID + 1 'incremented by 1 as the size of the array has been increased by 1

        WriteOrderID() 'the order IDs are written back to the file

        txtOrderID.Clear() 'clears all the textboxes/comboboxes
        cBoxSupplier.Text = ""
        cBoxStatus.Text = ""
        txtStockID.Clear()
        txtStockName.Clear()
        txtQuantity.Clear()

        'updates the yearly/monthly stock data:
        Dim tempDate As String 'stores the date from the date picker
        Dim monthOfOrder As String 'stores the month of the order
        Dim yearOfOrder As String 'stores the year of the order
        Dim updateYearOfOrder As Boolean 'stores whether the year of order has been found or not to prevent one of the loops infinite looping
        Dim count As Integer 'increments for the while loop so it keeps looping until the year has been found or count has reached 100
        Dim currentDate As String 'stores the computer's date
        Dim currentYear As String 'stores the computer's year of the date
        currentDate = Today 'sets the currentDate to the computer's date
        currentYear = currentDate.Substring(6, 4) 'splits the date to store the year
        tempDate = dpOrderDate.Value 'sets the tempDate to the date from the date picker


        For i = 0 To maxAddOrderPageNumber 'loop which works out whether the stock file already has a certain yearly data and updates the yearly data
            updateYearOfOrder = False 'set to false as the yearly stock data file (odrHistory) has not been updated yet
            count = 0 'initialised for the upcoming loop which needs to keep track of the count

            monthOfOrder = tempDate.Substring(3, 2) 'works out the month and year the order was placed
            yearOfOrder = tempDate.Substring(6, 4)

            For j = 0 To 99 'clears the order history array by resetting all the values
                arrOrderHistoryYear(j).Year = ""
                arrOrderHistoryYear(j).January = "0"
                arrOrderHistoryYear(j).February = "0"
                arrOrderHistoryYear(j).March = "0"
                arrOrderHistoryYear(j).April = "0"
                arrOrderHistoryYear(j).May = "0"
                arrOrderHistoryYear(j).June = "0"
                arrOrderHistoryYear(j).July = "0"
                arrOrderHistoryYear(j).August = "0"
                arrOrderHistoryYear(j).September = "0"
                arrOrderHistoryYear(j).October = "0"
                arrOrderHistoryYear(j).November = "0"
                arrOrderHistoryYear(j).December = "0"
            Next

            ReadOrderHistory(arrAddOrders(0, i)) 'reads the order with the StockID as arrAddOrders(0,i)

            'if the year the order was placed in matches one of the years in the order history year array then it updates the array
            If yearOfOrder = arrOrderHistoryYear(i).Year Then
                'sets the updateYearOfOrder to true 
                updateYearOfOrder = True
                If monthOfOrder = "01" Then 'updates the order history month array
                    'updates the number of stock ordered for each month
                    '                                converts the quantity to integer      converts the already existing quantity to an integer
                    arrOrderHistoryYear(i).January = Convert.ToInt32(arrAddOrders(1, i)) + Convert.ToInt32(arrOrderHistoryYear(i).January)
                ElseIf monthOfOrder = "02" Then
                    arrOrderHistoryYear(i).February = Convert.ToInt32(arrAddOrders(1, i)) + Convert.ToInt32(arrOrderHistoryYear(i).February)
                ElseIf monthOfOrder = "03" Then
                    arrOrderHistoryYear(i).March = Convert.ToInt32(arrAddOrders(1, i)) + Convert.ToInt32(arrOrderHistoryYear(i).March)
                ElseIf monthOfOrder = "04" Then
                    arrOrderHistoryYear(i).April = Convert.ToInt32(arrAddOrders(1, i)) + Convert.ToInt32(arrOrderHistoryYear(i).April)
                ElseIf monthOfOrder = "05" Then
                    arrOrderHistoryYear(i).May = Convert.ToInt32(arrAddOrders(1, i)) + Convert.ToInt32(arrOrderHistoryYear(i).May)
                ElseIf monthOfOrder = "06" Then
                    arrOrderHistoryYear(i).June = Convert.ToInt32(arrAddOrders(1, i)) + Convert.ToInt32(arrOrderHistoryYear(i).June)
                ElseIf monthOfOrder = "07" Then
                    arrOrderHistoryYear(i).July = Convert.ToInt32(arrAddOrders(1, i)) + Convert.ToInt32(arrOrderHistoryYear(i).July)
                ElseIf monthOfOrder = "08" Then
                    arrOrderHistoryYear(i).August = Convert.ToInt32(arrAddOrders(1, i)) + Convert.ToInt32(arrOrderHistoryYear(i).August)
                ElseIf monthOfOrder = "09" Then
                    arrOrderHistoryYear(i).September = Convert.ToInt32(arrAddOrders(1, i)) + Convert.ToInt32(arrOrderHistoryYear(i).September)
                ElseIf monthOfOrder = "10" Then
                    arrOrderHistoryYear(i).October = Convert.ToInt32(arrAddOrders(1, i)) + Convert.ToInt32(arrOrderHistoryYear(i).October)
                ElseIf monthOfOrder = "11" Then
                    arrOrderHistoryYear(i).November = Convert.ToInt32(arrAddOrders(1, i)) + Convert.ToInt32(arrOrderHistoryYear(i).November)
                Else
                    arrOrderHistoryYear(i).December = Convert.ToInt32(arrAddOrders(1, i)) + Convert.ToInt32(arrOrderHistoryYear(i).December)
                End If
            End If
            If updateYearOfOrder = False Then 'if there is no previous data for the year that the stock was ordered
                While count < 100 And updateYearOfOrder = False 'keeps looping until an empty space in the array is found
                    If arrOrderHistoryYear(count).Year = "" Then

                        arrOrderHistoryYear(count).Year = yearOfOrder 'updates the year ordered
                        updateYearOfOrder = True 'updates this so the loop doesn't repeat

                        If monthOfOrder = "01" Then 'updates the order history month array
                            'updates the number of stock ordered for each month
                            '                                   converts the quantity to integer      converts the already existing quantity to an integer
                            arrOrderHistoryYear(count).January = Convert.ToInt32(arrAddOrders(1, i)) + Convert.ToInt32(arrOrderHistoryYear(count).January)
                        ElseIf monthOfOrder = "02" Then
                            arrOrderHistoryYear(count).February = Convert.ToInt32(arrAddOrders(1, i)) + Convert.ToInt32(arrOrderHistoryYear(count).February)
                        ElseIf monthOfOrder = "03" Then
                            arrOrderHistoryYear(count).March = Convert.ToInt32(arrAddOrders(1, i)) + Convert.ToInt32(arrOrderHistoryYear(count).March)
                        ElseIf monthOfOrder = "04" Then
                            arrOrderHistoryYear(count).April = Convert.ToInt32(arrAddOrders(1, i)) + Convert.ToInt32(arrOrderHistoryYear(count).April)
                        ElseIf monthOfOrder = "05" Then
                            arrOrderHistoryYear(count).May = Convert.ToInt32(arrAddOrders(1, i)) + Convert.ToInt32(arrOrderHistoryYear(count).May)
                        ElseIf monthOfOrder = "06" Then
                            arrOrderHistoryYear(count).June = Convert.ToInt32(arrAddOrders(1, i)) + Convert.ToInt32(arrOrderHistoryYear(count).June)
                        ElseIf monthOfOrder = "07" Then
                            arrOrderHistoryYear(count).July = Convert.ToInt32(arrAddOrders(1, i)) + Convert.ToInt32(arrOrderHistoryYear(count).July)
                        ElseIf monthOfOrder = "08" Then
                            arrOrderHistoryYear(count).August = Convert.ToInt32(arrAddOrders(1, i)) + Convert.ToInt32(arrOrderHistoryYear(count).August)
                        ElseIf monthOfOrder = "09" Then
                            arrOrderHistoryYear(count).September = Convert.ToInt32(arrAddOrders(1, i)) + Convert.ToInt32(arrOrderHistoryYear(count).September)
                        ElseIf monthOfOrder = "10" Then
                            arrOrderHistoryYear(count).October = Convert.ToInt32(arrAddOrders(1, i)) + Convert.ToInt32(arrOrderHistoryYear(count).October)
                        ElseIf monthOfOrder = "11" Then
                            arrOrderHistoryYear(count).November = Convert.ToInt32(arrAddOrders(1, i)) + Convert.ToInt32(arrOrderHistoryYear(count).November)
                        Else
                            arrOrderHistoryYear(count).December = Convert.ToInt32(arrAddOrders(1, i)) + Convert.ToInt32(arrOrderHistoryYear(count).December)
                        End If

                        IndexOrderYear = count + 1 'increments the index of the arrOrderHistoryYear by 1 as new data has been added
                    End If
                    count = count + 1 'increments count so the program can check each index in the array
                End While

            End If

            WriteOrderHistory(arrAddOrders(0, i)) 'writes the stock data that contains the number of stock ordered each month to their history file

        Next

        For i = 0 To 999 'clears the order array
            arrAddOrders(0, i) = ""
            arrAddOrders(1, i) = ""
            arrAddOrders(2, i) = ""
        Next

        addOrderPageNumber = 0 'resets the page numbers to 0
        maxAddOrderPageNumber = 0
        txtPage.Text = addOrderPageNumber + 1 & " / " & maxAddOrderPageNumber + 1 'resets the page numbers displayed

    End Sub

    Private Sub txtStockID_TextChanged(sender As Object, e As EventArgs) Handles txtStockID.TextChanged
        'when the text in the stock ID textbox has been changed then the ID textbox needs to update which is the purpose of this subroutine
        If txtStockID.Text = "" Then 'if the ID textbox is cleared then the name textbox is cleared too
            txtStockName.Text = ""
        Else 'finds the name that matches the ID entered by searching through the stock array
            For i = 0 To IndexStock - 1
                If txtStockID.Text = arrStock(i).ID Then 'if it matches then
                    txtStockName.Text = arrStock(i).Name 'updates the name textbox
                End If
            Next
        End If
    End Sub


    Private Sub txtstockname_textchanged(sender As Object, e As EventArgs) Handles txtStockName.TextChanged
        'this subroutine autofills the name if the first part is entered and matches the ID to the name entered
        Dim spacePosition As Integer = 0 'stores the position of the "space" in the string
        For i = 0 To IndexStock - 1
            spacePosition = arrStock(i).Name.IndexOf(" ") 'works out the position of the space
            If spacePosition > 0 Then 'if the space isnt the first character of the string then
                If txtStockName.Text.ToLower = arrStock(i).Name.Substring(0, spacePosition).ToLower Then 'if the name entered matches the first part of another name
                    txtStockName.Text = arrStock(i).Name 'the stock name textbox is updated to the full name
                End If
            ElseIf txtStockName.Text.ToLower = arrStock(i).Name.ToLower Then 'if the name entered matches the name in the array
                txtStockName.Text = arrStock(i).Name 'it autocapitalises the letters to match the capitals in the array
            End If
        Next



        'updates the ID textbox automatically when the name is entered
        If txtStockName.Text = "" Then
            txtStockID.Text = "" 'if the name textbox is cleared then the ID textbox is cleared too
        Else 'finds the ID that matches the name entered by searching through the stock array
            For i = 0 To IndexStock - 1
                If txtStockName.Text = arrStock(i).Name Then 'if it matches then
                    txtStockID.Text = arrStock(i).ID 'updates the ID textbox 
                End If
            Next
        End If
    End Sub
End Class
