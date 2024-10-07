Public Class frmOrderList
    Private Sub frmOrderList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'this subroutine works out which stock items are below their threshold level and displays their information onto the two listboxes
        Dim TotalCost As Decimal = 0 'variable to keep track of the total cost of the stock that needs to be ordered to meet the threshold level
        ReadStock() 'reads the stock file
        For i = 0 To IndexStock - 1 'displays the order information 
            If arrStock(i).BelowThreshold = "True" Then 'only displays the stock that are below their thresholds
                'adds the stock that are below their threshold levels to the list
                lstStock.Items.Add(arrStock(i).ID & vbTab & arrStock(i).Name)
                lstStock.Items.Add("")
                lstStockRight.Items.Add(arrStock(i).CurrentQuantity & vbTab & arrStock(i).ThresholdLevel & vbTab & arrStock(i).Cost)
                lstStockRight.Items.Add("")
                'works out the cost of the stock that needs to be ordered to meet their threshold level
                TotalCost = (Convert.ToDecimal(arrStock(i).Cost) * (Convert.ToInt32(arrStock(i).ThresholdLevel) - Convert.ToInt32(arrStock(i).CurrentQuantity))) + TotalCost
            End If
        Next
        txtTotalCost.Text = TotalCost 'updates the total cost of the stock to be ordered
    End Sub

    Private Sub btnMngMenu_Click(sender As Object, e As EventArgs) Handles btnMngMenu.Click
        'this code checks which menu the user should be redirected to by checking if they have restricted access
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