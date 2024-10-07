Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'this subroutine checks the entered username and password so the user can log in when the log in button is clicked
        'staff file is read into an array so the program can check the entered username and password
        ReadStaff()

        'validation:
        If PresenceCheck(txtUsername.Text) = False Then 'presence checks for the username and password
            MsgBox("Please enter a username.")
            Exit Sub
        End If

        If PresenceCheck(txtPassword.Text) = False Then
            MsgBox("Please enter a password.")
            Exit Sub
        End If

        'searches the array for a matching username and password
        For i = 0 To IndexStaff - 1
            If arrStaff(i).UserName = txtUsername.Text Then 'if the username entered matches the username in the array
                If arrStaff(i).Password = txtPassword.Text Then 'if the password also matches then
                    'the login menu is hidden and the user is redirected to their appropiate main menu
                    'this is dependent on their RestrictInfo variable
                    Me.Hide()
                    If arrStaff(i).RestrictInfo = True Then 'if RestrictInfo is True then they are redirected to the staff menu which doesn't contain sensitive menus
                        frmStaffMenu.Show()
                    Else
                        frmManagementMenu.Show() 'if it is false then they are redirected to the management menu which has access to every menu
                    End If

                    LoggedIn = True 'set to True as the user has logged in
                    UserLoggedIn = arrStaff(i).ID 'sets the UserLoggedIn varaible to their ID
                    'the program can keep track of who's logged in so the user can be redirected to the correct main menus
                    'in the other menus

                    'clears the textboxes so if the user logs out and logs in again the textboxes are cleared
                    txtUsername.Clear()
                    txtPassword.Clear()
                End If
            End If
        Next
        If LoggedIn = False Then
            MsgBox("Invalid username or password") 'error message which shows up if no matching username or passwords are found
        End If
    End Sub


End Class