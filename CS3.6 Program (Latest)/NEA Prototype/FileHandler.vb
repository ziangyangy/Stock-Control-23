Module FileHandler
    Const StaffFile As String = "StaffFile.txt" 'stores the constant StaffFile as the filename "StaffFile.txt"
    Const StockFile As String = "StockFile.txt" 'stores the constant StockFile as the filename "StockFile.txt"
    Const SupplierFile As String = "SupplierFile.txt" 'stores the constant SupplierFile as the filename "SupplierFile.txt"
    Const IDFile As String = "ID.txt" 'stores the constant IDFile as the filename "IDFile.txt"
    Const OrderIDFile As String = "OrderIDs.txt" 'stores the constant OrderIDFile as the filename "OrderIDs.txt"

    'subroutine which reads the stock file and loads data into the stock array
    Sub ReadStock()
        Dim stringTemp As String = "" 'stores the string version of the ID, current quantity, threshold and the cost
        IndexStock = 0 'initalises in case this has changed in other forms
        Try 'tries to read the file
            FileOpen(1, StockFile, OpenMode.Input)
            'reads the comma separated blocks into the array
            While Not EOF(1) 'while not end of file, inputs the stock data
                Input(1, stringTemp) 'inputs the ID into the stringTemp variable
                arrStock(IndexStock).ID = Convert.ToInt32(stringTemp) 'converts the stringTemp ID into an integer to store in the stock array
                Input(1, arrStock(IndexStock).Name) 'inputs the stock name
                Input(1, stringTemp) 'inputs the current quantity into the stringTemp variable
                arrStock(IndexStock).CurrentQuantity = Convert.ToInt32(stringTemp) 'converts the stringTemp currenty quantity into an integer to store in the stock array
                Input(1, stringTemp) 'inputs the threshold into the stringTemp variable
                arrStock(IndexStock).ThresholdLevel = stringTemp 'converts the stringTemp threshold into an integer to store in the stock array
                Input(1, arrStock(IndexStock).BelowThreshold) 'inputs the boolean value of the BelowThreshold
                Input(1, stringTemp) 'inputs the cost into the stringTemp variable
                arrStock(IndexStock).Cost = Convert.ToDecimal(stringTemp) 'converts the stringTemp cost into a decimal to store in the stock array
                stringTemp = "" 'clears the stringTemp variable
                IndexStock = IndexStock + 1 'increments the stock index to keep track of the array size
            End While
        Catch ex As Exception
            'if there is an error then a message is displayed to inform the user
            MsgBox("Cannot read stock file.")
        End Try
        FileClose(1) 'closes the file
    End Sub

    'subroutine which writes the data from the stock array into the file
    Sub WriteStock()
        Try 'tries to write to the file
            FileOpen(1, StockFile, OpenMode.Output) 'opens the file
            For i = 0 To IndexStock - 1 'goes through each record in the array and writes the records to the file
                WriteLine(1, arrStock(i).ID, arrStock(i).Name, arrStock(i).CurrentQuantity, arrStock(i).ThresholdLevel, arrStock(i).BelowThreshold, arrStock(i).Cost)
            Next
        Catch ex As Exception
            'if there is an error then a message is displayed to inform the user
            MsgBox("Cannot write to stock file.")
        End Try
        FileClose(1) 'closes the file
    End Sub

    'subroutine which fetches and returns a new ID
    Function getnewID(detail As String) 'the parameter "detail" stores what type of ID needs fetching, e.g. stock or staff
        Dim count As Integer = 0 'stores the ID array size as it increments
        Dim stringTemp As String = "" 'stores the string version of the ID
        Try
            FileOpen(1, IDFile, OpenMode.Input) 'opens the file
            While Not EOF(1) 'reads data in file into array
                Input(1, arrID(count).detail) 'inputs the type of ID
                Input(1, stringTemp) 'inputs the ID into the stringTemp variable
                arrID(count).ID = Convert.ToInt32(stringTemp) 'converts the stringTemp ID into an integer to store in the ID array
                count = count + 1 'increments count
            End While
        Catch ex As Exception
            MsgBox("Cannot read ID file") 'if there is an error then a message is displayed to inform the user
        End Try
        FileClose(1) 'closes the file

        'opens the file to increment the ID by 1 and write the new ID to the file
        FileOpen(2, IDFile, OpenMode.Output) 'opens the file
        Dim tempID As String = "" 'stores the old ID
        Dim newID As Integer = 0 'stores the new ID that has incremented by 1
        For i = 0 To count - 1
            If detail = arrID(i).detail Then 'checks the type of ID to be incremented
                tempID = arrID(i).ID 'sets the tempID as the currentID
                newID = Convert.ToInt32(tempID + 1) 'the new ID is the currentID incremented by 1
                arrID(i).ID = newID 'the ID in the array is set to the new ID
            End If
        Next
        For i = 0 To count - 1
            WriteLine(2, arrID(i).detail, arrID(i).ID) 'writes the new ID into the file
        Next
        FileClose(2) 'closes the file
        Return newID 'returns the new ID
    End Function

    'subroutine which reads an order file to load the data into the order array
    Sub ReadOrder(OrderID As String) 'orderID parameter is the order ID passed when calling the sub
        maxAddOrderPageNumber = 0 'initalises in case this has changed in other menus
        Try
            Dim tempDate As String 'stores the date which may include the time when the file is read
            FileOpen(1, "odr" & OrderID & ".txt", OpenMode.Input) 'opens the file
            Input(1, tempDate) 'inputs the whole date which may include the time
            OrderDate = tempDate.Substring(0, 10) 'gets the actual date format to display instead of including the time
            Input(1, OrderStatus) 'inputs the order status
            Input(1, Supplier) 'inputs the supplier

            While Not EOF(1)
                Input(1, arrAddOrders(0, maxAddOrderPageNumber)) 'inputs stock ID
                Input(1, arrAddOrders(1, maxAddOrderPageNumber)) 'inputs quantity ordered
                maxAddOrderPageNumber = maxAddOrderPageNumber + 1 'incremented to keep track of array size
            End While
        Catch ex As Exception
            MsgBox("Cannot read order file.") 'if there is an error then a message is displayed
        End Try
        FileClose(1) 'closes the file
    End Sub

    'subroutine which deletes the order from the system
    Sub DeleteOrder(OrderID As String) 'orderID parameter is the order ID passed when calling the sub
        Try 'tries to delete the file
            My.Computer.FileSystem.DeleteFile("odr" & OrderID & ".txt") 'deletes the file from the system
            MsgBox("File successfully deleted.") 'if successful then a message is displayed
        Catch ex As Exception
            MsgBox("File cannot be deleted.") 'if there is an error then a message is displayed
        End Try
    End Sub

    'subroutine which writes the order to the file
    Sub WriteOrder(OrderID As String, OrderDate As String, OrderStatus As String, OrderSupplier As String)
        'OrderID stores the order ID passed, OrderDate stores the date of the order, OrderStatus stores the status and the OrderSupplier stores the supplier
        Try 'tries to read the file
            FileOpen(1, "odr" & OrderID & ".txt", OpenMode.Output) 'opens the file
            WriteLine(1, Convert.ToString(OrderDate), OrderStatus, OrderSupplier) 'writes the order date, status and supplier at the top of the file
            For i = 0 To maxAddOrderPageNumber
                WriteLine(1, arrAddOrders(0, i), arrAddOrders(1, i)) 'writes the stock ID and quantity ordered
            Next
        Catch ex As Exception
            'if there is an error then a message is displayed to inform the user
            MsgBox("Cannot write to order file.")
        End Try
        FileClose(1) 'closes the file
    End Sub

    'subroutine which reads the supplier file
    Sub ReadSupplier()
        Dim stringTemp As String = "" 'stores the string version of the ID
        IndexSupplier = 0 'set to 0 in case it has been changed in the other menus
        Try 'tries to read the file
            FileOpen(1, SupplierFile, OpenMode.Input) 'opens the file
            While Not EOF(1)
                Input(1, stringTemp) 'inputs the ID into stringTemp
                arrSupplier(IndexSupplier).ID = Convert.ToInt32(stringTemp) 'converts the stringTemp ID to an integer to store in the supplier array
                Input(1, arrSupplier(IndexSupplier).Name) 'inputs the name of the supplier into the array
                IndexSupplier = IndexSupplier + 1 'increments to keep track of array size
            End While
        Catch ex As Exception
            'if there is an error then a message is displayed to inform the user
            MsgBox("Cannot read the supplier file.")
        End Try
        FileClose(1) 'closes the file
    End Sub

    'subroutine which reads the order history of stock
    Sub ReadOrderHistory(StockID) 'StockID parameter has the stock ID passed to it
        IndexOrderYear = 0 'set to 0 in case this has changed in other forms
        Try 'tries to read the file
            FileOpen(1, "odrHist" & StockID & ".txt", OpenMode.Input) 'opens the file
            While Not EOF(1) 'while not end of file, it inputs all of the stock ordered per month
                Input(1, arrOrderHistoryYear(IndexOrderYear).Year) 'inputs the year of the order
                'inputs the quantity of stock ordered for every month
                Input(1, arrOrderHistoryYear(IndexOrderYear).January)
                Input(1, arrOrderHistoryYear(IndexOrderYear).February)
                Input(1, arrOrderHistoryYear(IndexOrderYear).March)
                Input(1, arrOrderHistoryYear(IndexOrderYear).April)
                Input(1, arrOrderHistoryYear(IndexOrderYear).May)
                Input(1, arrOrderHistoryYear(IndexOrderYear).June)
                Input(1, arrOrderHistoryYear(IndexOrderYear).July)
                Input(1, arrOrderHistoryYear(IndexOrderYear).August)
                Input(1, arrOrderHistoryYear(IndexOrderYear).September)
                Input(1, arrOrderHistoryYear(IndexOrderYear).October)
                Input(1, arrOrderHistoryYear(IndexOrderYear).November)
                Input(1, arrOrderHistoryYear(IndexOrderYear).December)
                IndexOrderYear = IndexOrderYear + 1 'increments by 1 to keep track of array size
            End While
        Catch ex As Exception
            'if there is an error then a message is displayed to inform the user
            MsgBox("Cannot read order history file or file is empty.")
        End Try
        FileClose(1) 'closes the file
    End Sub

    'subroutine which writes the stock history to file
    Sub WriteOrderHistory(StockID) 'StockID parameter has the stock ID passed to it
        Try 'tries to read the file
            FileOpen(1, "odrHist" & StockID & ".txt", OpenMode.Output) 'opens the file
            For i = 0 To IndexOrderYear - 1 'writes the year of the order and quantity of stock ordered for each month
                WriteLine(1, arrOrderHistoryYear(i).Year, arrOrderHistoryYear(i).January, arrOrderHistoryYear(i).February, arrOrderHistoryYear(i).March, arrOrderHistoryYear(i).April, arrOrderHistoryYear(i).May, arrOrderHistoryYear(i).June, arrOrderHistoryYear(i).July, arrOrderHistoryYear(i).August, arrOrderHistoryYear(i).September, arrOrderHistoryYear(i).October, arrOrderHistoryYear(i).November, arrOrderHistoryYear(i).December)
            Next
        Catch ex As Exception
            'if there is an error then a message is displayed to inform the user
            MsgBox("Cannot write to order history file.")
        End Try
        FileClose(1) 'closes the file
    End Sub

    'subroutine which reads the staff file
    Sub ReadStaff()
        Dim stringID As String = "" 'stores the string version of the ID
        IndexStaff = 0 'set to 0 in case this has changed in other forms
        Try
            FileOpen(1, StaffFile, OpenMode.Input) 'opens the file
            While Not EOF(1)
                Input(1, stringID) 'inputs the ID into the stringID
                arrStaff(IndexStaff).ID = Convert.ToInt32(stringID) 'converts the stringID to an integer and stores it in the array
                Input(1, arrStaff(IndexStaff).UserName) 'inputs the username
                Input(1, arrStaff(IndexStaff).Password) 'inputs the password
                Input(1, arrStaff(IndexStaff).RestrictInfo) 'inputs their boolean Restriction variable
                IndexStaff = IndexStaff + 1
            End While
        Catch ex As Exception
            MsgBox("Cannot read staff file.") 'error message
        End Try
        FileClose(1) 'closes the file
    End Sub

    'subroutine which writes to the staff file
    Sub WriteStaff()
        Try
            FileOpen(1, StaffFile, OpenMode.Output) 'opens the file
            For i = 0 To IndexStaff - 1 'writes the ID, username, password and RestrictInfo variable to file for all the staff records
                WriteLine(1, arrStaff(i).ID, arrStaff(i).UserName, arrStaff(i).Password, arrStaff(i).RestrictInfo)
            Next
        Catch ex As Exception
            MsgBox("Cannot write to staff file.") 'error message
        End Try
        FileClose(1) 'closes the file
    End Sub

    'subroutine which reads the Order ID file into array
    Sub ReadOrderID()
        IndexOrderID = 0 'set to 0 in case this has changed in other forms
        Try
            FileOpen(1, OrderIDFile, OpenMode.Input) 'opens the file
            While Not EOF(1)
                Input(1, arrOrderIDs(IndexOrderID)) 'inputs the orderID into the array
                IndexOrderID = IndexOrderID + 1 'increments by 1 to keep track of array size
            End While
        Catch ex As Exception
            MsgBox("Cannot read order ID file.") 'error message
        End Try
        FileClose(1) 'closes the file
    End Sub

    'subroutine which writes to the Order ID file
    Sub WriteOrderID()
        Try
            FileOpen(1, OrderIDFile, OpenMode.Output) 'opens the file
            For i = 0 To IndexOrderID - 1
                WriteLine(1, arrOrderIDs(i)) 'writes the order ID to file
            Next
        Catch ex As Exception
            MsgBox("Cannot write to order ID file.") 'error message
        End Try
        FileClose(1)
    End Sub
End Module
