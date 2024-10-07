Public Class frmStaffMenu
    Private Sub btnStockList_Click(sender As Object, e As EventArgs) Handles btnStockList.Click
        Me.Close()
        frmStockList.Show() 'directs to the stock list menu
    End Sub

    Private Sub btnAddStockMenu_Click(sender As Object, e As EventArgs) Handles btnAddStockMenu.Click
        Me.Close()
        frmAddStock.Show() 'directs to the add stock menu
    End Sub

    Private Sub btnUpdateStock_Click(sender As Object, e As EventArgs) Handles btnUpdateStock.Click
        Me.Close()
        frmUpdateStock.Show() 'directs to the update stock menu
    End Sub

    Private Sub btnOrderList_Click(sender As Object, e As EventArgs) Handles btnOrderList.Click
        Me.Close()
        frmOrderList.Show() 'directs to the order list menu
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        LoggedIn = False
        UserLoggedIn = 0
        Me.Close()
        frmLogin.Show() 'logs out and directs to the login menu
    End Sub
End Class