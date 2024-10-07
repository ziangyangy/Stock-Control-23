Module DataStructures
    'Stock array and record structure
    Public arrStock(999) As Stock 'array that stores the stock records in each index
    Public IndexStock As Integer 'stores the size of the stock array

    Structure Stock 'stock record structure
        Dim ID As Integer 'stores stock ID
        Dim Name As String 'stores stock name
        Dim CurrentQuantity As Integer 'stores the current quantity of the stock
        Dim ThresholdLevel As Integer 'stores the threshold level of the stock
        Dim BelowThreshold As Boolean 'stores the boolean value of whether the stock is below threshold or not (when true it is below threshold)
        Dim Cost As Decimal 'stores the price of the stock item
    End Structure

    'Supplier array and record structure
    Public arrSupplier(999) As SupplierType 'array that stores the supplier information
    Public IndexSupplier As Integer = 0 'stores the size of the supplier array

    Structure SupplierType 'supplier record structure
        Dim ID As Integer 'stores the supplier ID
        Dim Name As String 'stores the supplier name
        Dim Telephone As String 'stores the supplier telephone number
    End Structure

    'autoID array and record structure
    Public arrID(5) As ID 'array which stores the records of the IDs
    Structure ID 'autoID record structure
        Dim detail As String 'this stores the type of autoid needed to be generated, e.g. stock or supplier
        Dim ID As Integer 'this stores the actual ID
    End Structure

    'order details 2D array and stock history record structure
    Public OrderDate As String 'stores the date when the order was placed
    Public OrderStatus As String 'stores the status of the order
    Public Supplier As String 'stores which supplier supplied the order

    Public arrAddOrders(2, 999) As String '2d array, (x,y): x stores the stock data, 0 is stock ID, 1 is stock quantity, 2 is stock name
    'the y value stores the page number in the Add Orders menu, so when the y value is changed, the array can be navigated to different stock data
    Public maxAddOrderPageNumber As Integer = 0 'stores the highest value of the page number that the user has flicked through
    'e.g. every time the user navigates to the next page in the Add Orders Menu, it increments by 1
    Public addOrderPageNumber As Integer = 0 'stores the current page number that the user is on

    Public arrOrderHistoryYear(999) As orderHistoryYear 'array that stores the records of the stock history data
    Public IndexOrderYear As Integer 'stores the size of the arrOrderHistoryYear array
    Structure orderHistoryYear 'record which stores the order history of stock
        Dim Year As String 'stores the year when the order was placed
        Dim January As String 'stores the number of stock ordered january of that year
        Dim February As String 'stores the number of stock ordered february of that year
        Dim March As String 'stores the number of stock ordered march of that year
        Dim April As String 'stores the number of stock ordered april of that year
        Dim May As String 'stores the number of stock ordered may of that year
        Dim June As String 'stores the number of stock ordered june of that year
        Dim July As String 'stores the number of stock ordered july of that year
        Dim August As String 'stores the number of stock ordered august of that year
        Dim September As String 'stores the number of stock ordered september of that year
        Dim October As String 'stores the number of stock ordered october of that year
        Dim November As String 'stores the number of stock ordered november of that year
        Dim December As String 'stores the number of stock ordered december of that year
    End Structure

    'staff array and record structure
    Public arrStaff(99) As Staff 'array that stores the records of staff
    Public IndexStaff As Integer 'stores the size of the staff array
    Public LoggedIn As Boolean 'stores whether there is a user logged in or not
    Public UserLoggedIn As Integer 'stores the ID of the user logged in

    Structure Staff 'record structure for staff data
        Dim ID As Integer 'stores the staff ID
        Dim UserName As String 'stores the staff username
        Dim Password As String 'stores the password
        Dim RestrictInfo As Boolean 'stores whether that staff member is restricted from sensitive menus (True if restricted)
    End Structure

    'order IDs array
    Public arrOrderIDs(99999) As String 'stores the array of order IDs
    Public IndexOrderID As Integer 'stores the size of the array of order IDs
End Module
