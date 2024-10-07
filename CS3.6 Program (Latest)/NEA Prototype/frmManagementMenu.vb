Public Class frmManagementMenu
    'the main navigational menu which directs the user to the appropiate menu when the button is clicked
    Private Sub btnStockList_Click(sender As Object, e As EventArgs) Handles btnStockList.Click
        Me.Hide()
        frmStockList.Show() 'directs to stock list form
    End Sub

    Private Sub btnDeleteStock_Click(sender As Object, e As EventArgs) Handles btnDeleteStock.Click
        Me.Hide()
        frmDeleteStock.Show()  'directs to delete stock form
    End Sub

    Private Sub btnAddStockMenu_Click(sender As Object, e As EventArgs) Handles btnAddStockMenu.Click
        Me.Hide()
        frmAddStock.Show()  'directs to add stock form
    End Sub

    Private Sub btnUpdateStock_Click(sender As Object, e As EventArgs) Handles btnUpdateStock.Click
        Me.Hide()
        frmUpdateStock.Show()  'directs to update stock form
    End Sub

    Private Sub btnPastOrders_Click(sender As Object, e As EventArgs) Handles btnPastOrders.Click
        Me.Hide()
        frmPastOrders.Show()  'directs to past orders form
    End Sub

    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        Me.Hide()
        frmAddOrder.Show()  'directs to add orders form
    End Sub

    Private Sub btnStockAnalysis_Click(sender As Object, e As EventArgs) Handles btnStockAnalysis.Click
        Me.Hide()
        frmStockAnalysis.Show()  'directs to the stock analysis menu
    End Sub

    Private Sub btnOrderList_Click(sender As Object, e As EventArgs) Handles btnOrderList.Click
        Me.Hide()
        frmOrderList.Show()  'directs to order list form
    End Sub

    Private Sub btnOrderStatus_Click(sender As Object, e As EventArgs) Handles btnOrderStatus.Click
        Me.Hide()
        frmOrderStatus.Show()  'directs to the order status form
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        LoggedIn = False
        UserLoggedIn = 0
        Me.Close()
        frmLogin.Show() 'logs out and directs to the login menu
    End Sub

    Private Sub btnAddStaff_Click(sender As Object, e As EventArgs) Handles btnAddStaff.Click
        Me.Close()
        frmAddStaff.Show() 'directs to the add staff menu
    End Sub

    Private Sub btnDelStaff_Click(sender As Object, e As EventArgs) Handles btnDelStaff.Click
        Me.Close()
        frmDeleteStaff.Show() 'directs to the delete staff menu
    End Sub

    Private Sub btnStaffDetails_Click(sender As Object, e As EventArgs) Handles btnStaffDetails.Click
        Me.Close()
        frmStaffDetails.Show() 'directs to the staff details menu
    End Sub
End Class