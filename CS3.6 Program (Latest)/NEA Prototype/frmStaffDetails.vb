Public Class frmStaffDetails
    Private Sub frmStaffDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'when the menu loads in, the data is displayed for all 4 listboxes and comboboxes
        LoadData()
    End Sub

    Sub LoadData()
        'subroutine which loads in the data for the listboxes and comboboxes
        'listboxes are cleared of any previous data
        lstStaffID.Items.Clear()
        lstUsername.Items.Clear()
        lstPassword.Items.Clear()
        lstRestriction.Items.Clear()
        cBoxID.Items.Clear() 'combobox options cleared
        cBoxSelectInfo.Items.Clear()
        cBoxNewInfo.Text = "" 'clears the text of the new info combobox and textbox
        txtNewInfo.Text = ""
        txtNewInfo.Enabled = True 'enables the new info textbox
        txtNewInfo.Visible = True 'makes it visible
        cBoxNewInfo.Enabled = False 'disables the new info combobox
        cBoxNewInfo.Visible = False 'makes it invisible

        'loads the data into the listboxes
        For i = 0 To IndexStaff - 1
            lstStaffID.Items.Add(arrStaff(i).ID) 'adds the ID to the ID listbox
            lstStaffID.Items.Add("") 'adds an empty row for readability
            lstUsername.Items.Add(arrStaff(i).UserName) 'adds username to the listbox
            lstUsername.Items.Add("") 'adds an empty row for readability
            lstPassword.Items.Add(arrStaff(i).Password) 'adds password to the listbox
            lstPassword.Items.Add("") 'adds an empty row for readability
            If arrStaff(i).RestrictInfo = True Then 'if their RestrictInfo is True
                lstRestriction.Items.Add("Yes") 'displays "Yes"
                lstRestriction.Items.Add("")
            Else 'if their RestrictInfo is False
                lstRestriction.Items.Add("No") 'displays "No"
                lstRestriction.Items.Add("")
            End If

            cBoxID.Items.Add(arrStaff(i).ID) 'adds the ID to the ID combobox
        Next
        cBoxSelectInfo.Items.Add("Username") 'loads in the options for the select info combobox
        cBoxSelectInfo.Items.Add("Password")
        cBoxSelectInfo.Items.Add("Access Restrictions")
    End Sub

    Private Sub btnMngMenu_Click(sender As Object, e As EventArgs) Handles btnMngMenu.Click
        Me.Close() 'navigation which closes the current menu and loads the management menu
        frmManagementMenu.Show()
    End Sub

    Private Sub cBoxSelectInfo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cBoxSelectInfo.SelectedIndexChanged
        'subroutine which enables or disables the new info textbox or combobox depending on the select info combobox
        If cBoxSelectInfo.Text = "Access Restrictions" Then 'if access restrictions is selected
            txtNewInfo.Enabled = False 'disables the new info textbox
            txtNewInfo.Visible = False 'makes it invisible since it won't be used
            cBoxNewInfo.Enabled = True 'enables the new info combobox
            cBoxNewInfo.Visible = True 'makes it visible
            cBoxNewInfo.Items.Clear() 'loads previous options
            cBoxNewInfo.Items.Add("Restrict") 'reloads them
            cBoxNewInfo.Items.Add("Don't restrict")
        Else 'if access restrictions isn't selected
            txtNewInfo.Enabled = True 'enables the new info textbox
            txtNewInfo.Visible = True 'makes it visible
            cBoxNewInfo.Enabled = False 'disables the combobox
            cBoxNewInfo.Visible = False 'makes it invisible
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'updates the staff information with the new details
        'validation:
        If PresenceCheck(cBoxID.Text) = False Then 'presence checks for the comboboxes and textboxes
            MsgBox("Please select an ID.")
            Exit Sub
        End If

        If PresenceCheck(cBoxSelectInfo.Text) = False Then
            MsgBox("Please select information to edit.")
            Exit Sub
        End If

        If txtNewInfo.Enabled = True Then 'if the textbox is enabled then it carries out a presence check for the textbox only
            If PresenceCheck(txtNewInfo.Text) = False Then
                MsgBox("Please enter information to edit.")
                Exit Sub
            End If
        Else 'if the textbox is disabled then it carries out a presence check for the combo box
            If PresenceCheck(cBoxNewInfo.Text) = False Then
                MsgBox("Please select the access restriction.")
                Exit Sub
            End If
        End If
        Dim updateIndex As Integer = 0 'finds the index to be updated
        For i = 0 To IndexStaff - 1
            If cBoxID.Text = arrStaff(i).ID Then 'checks for the index to be updated
                updateIndex = i 'sets the updateIndex to the index to be updated
            End If
        Next

        'updates the information
        If cBoxSelectInfo.Text = "Username" Then 'checks if the user wants the username updated
            arrStaff(updateIndex).UserName = txtNewInfo.Text 'sets the username in the array to the new username
            WriteStaff() 'overwrites new data to file
            LoadData() 'calls subroutine to reload the data
        ElseIf cBoxSelectInfo.Text = "Password" Then 'checks if the user wants the password updated
            arrStaff(updateIndex).Password = txtNewInfo.Text 'sets the password in the array to the new password
            WriteStaff() 'overwrites new data to file
            LoadData() 'calls subroutine to reload the data
        ElseIf cBoxSelectInfo.Text = "Access Restrictions" Then 'checks if the user wants the restrictions updated
            If cBoxNewInfo.Text = "Restrict" Then 'if "Restrict" is selected then
                arrStaff(updateIndex).RestrictInfo = True 'sets the restrictInfo in the array to True
            Else 'if "Don't restrict" is selected then
                arrStaff(updateIndex).RestrictInfo = False 'sets the restrictInfo in the array to False
            End If
            WriteStaff() 'overwrites new data to file
            LoadData() 'calls subroutine to reload the data
        End If
    End Sub

    Private Sub lstStaffID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStaffID.SelectedIndexChanged
        'when the list box is clicked on and the index is changed, the index of the other listboxes matches
        'this ensures the user knows which row of data matches both listboxes
        lstUsername.SelectedIndex = lstStaffID.SelectedIndex
        lstPassword.SelectedIndex = lstStaffID.SelectedIndex
        lstRestriction.SelectedIndex = lstStaffID.SelectedIndex
    End Sub

    Private Sub lstUsername_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUsername.SelectedIndexChanged
        'when the list box is clicked on and the index is changed, the index of the other listboxes matches
        'this ensures the user knows which row of data matches both listboxes
        lstStaffID.SelectedIndex = lstUsername.SelectedIndex
        lstPassword.SelectedIndex = lstUsername.SelectedIndex
        lstRestriction.SelectedIndex = lstUsername.SelectedIndex
    End Sub

    Private Sub lstPassword_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPassword.SelectedIndexChanged
        'when the list box is clicked on and the index is changed, the index of the other listboxes matches
        'this ensures the user knows which row of data matches both listboxes
        lstStaffID.SelectedIndex = lstPassword.SelectedIndex
        lstUsername.SelectedIndex = lstPassword.SelectedIndex
        lstRestriction.SelectedIndex = lstPassword.SelectedIndex
    End Sub

    Private Sub lstRestriction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRestriction.SelectedIndexChanged
        'when the list box is clicked on and the index is changed, the index of the other listboxes matches
        'this ensures the user knows which row of data matches both listboxes
        lstUsername.SelectedIndex = lstRestriction.SelectedIndex
        lstPassword.SelectedIndex = lstRestriction.SelectedIndex
        lstStaffID.SelectedIndex = lstRestriction.SelectedIndex
    End Sub
End Class