Public Class frmOrderStatus
    Private Sub frmOrderStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loads the combobox status options and combobox order IDs
        cboxStatus.Items.Clear()  'clears the status combobox and loads the options
        cboxStatus.Items.Add("Ordered")
        cboxStatus.Items.Add("Dispatched")
        cboxStatus.Items.Add("In Transit")
        cboxStatus.Items.Add("Delivered")
        cboxStatus.Items.Add("Returned")
        ReadOrderID()
        For i = 0 To IndexOrderID - 1
            cBoxOrderID.Items.Add(arrOrderIDs(i))
        Next
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'subroutine which updates the order status when the button is clicked
        If PresenceCheck(cBoxOrderID.Text) = False Then 'presence checks to check if data is present
            MsgBox("Please select the order ID.")
            Exit Sub
        End If

        If PresenceCheck(cboxStatus.Text) = False Then
            MsgBox("Please choose a status.")
            Exit Sub
        End If

        'updates the stock status with the status selected
        Try
            ReadOrder(cBoxOrderID.Text) 'reads the order file
            maxAddOrderPageNumber = maxAddOrderPageNumber - 1 'needs to decrease by 1 so it will write the number of stock ordered
            WriteOrder(cBoxOrderID.Text, OrderDate, cboxStatus.Text, Supplier) 'writes to the order file
            MsgBox("Status of order " & cBoxOrderID.Text & " successfully updated.") 'message to show if it was successfully updated
        Catch ex As Exception
            MsgBox("Could not update the status of order " & cBoxOrderID.Text) 'error message in case it was unsuccessful
        End Try
    End Sub

    Private Sub btnMngMenu_Click(sender As Object, e As EventArgs) Handles btnMngMenu.Click
        Me.Close()
        frmManagementMenu.Show() 'navigation button that loads the menu and closes the current form
    End Sub
End Class