Public Class frmAddStaff
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'this subroutine adds the staff data entered to the file
        'validation:
        If PresenceCheck(txtUsername.Text) = False Then 'presence checks for the textboxes
            MsgBox("Please enter a username.")
            Exit Sub
        End If

        If PresenceCheck(txtPassword.Text) = False Then
            MsgBox("Please enter a password.")
            Exit Sub
        End If

        If moreThanLengthCheck(txtUsername.Text, 20) = True Then 'length check, returns True if the username > 20 characters
            MsgBox("Please enter a shorter username.")
            Exit Sub
        End If

        If moreThanLengthCheck(txtPassword.Text, 20) = True Then 'length check, returns True if the password > 20 characters
            MsgBox("Please enter a shorter password.")
            Exit Sub
        End If

        If lessThanLengthCheck(txtUsername.Text, 3) = True Then 'length check, returns True if username < 3 characters
            MsgBox("Please enter a longer username.")
            Exit Sub
        End If

        If lessThanLengthCheck(txtPassword.Text, 8) = True Then 'length check, returns True if password < 8 characters
            MsgBox("Please enter a longer password.")
            Exit Sub
        End If

        'tries to add staff data to file
        Try
            ReadStaff() 'reads staff file
            Dim newID As Integer 'stores the new ID to be generated
            newID = getnewID("staff") 'sets the newID as the generated ID
            arrStaff(IndexStaff).ID = newID 'sets their staff ID to the new ID
            arrStaff(IndexStaff).UserName = txtUsername.Text 'sets their username to their entered username
            arrStaff(IndexStaff).Password = txtPassword.Text 'sets their password to their entered password
            arrStaff(IndexStaff).RestrictInfo = chkAccess.Checked 'sets their restriction to menus, True if the checkbox is ticked
            IndexStaff = IndexStaff + 1 'increments index before adding to file
            WriteStaff() 'overwrites the file with the new staff information
            MsgBox("Staff successfully added.") 'gives a message if it was successful
        Catch ex As Exception
            MsgBox("Could not add staff to file.") 'gives an error message if it was unsuccessful
        End Try
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        'navigation button
        Me.Close()
        frmManagementMenu.Show() 'directs to management menu
    End Sub
End Class