Imports System.Windows.Forms.DataVisualization.Charting 'imports the charts
Public Class frmStockAnalysis
    Dim s As New Series 'creates a new series to create the graph
    Dim month() As String = {"Jan", "Feb", "Mar", "April", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"} 'array containing the months of the year
    Dim arrYearlyTotals(99) As Integer 'array to store the total of stock ordered per year
    Dim values(11) As Integer 'array that will contain the number of stock ordered per month
    Dim GraphChanged As Boolean = False 'this variable is only necessary so when the graph is removed then the program won't try to remove an already empty graph, preventing it from crashing

    Private Sub btnMngMenu_Click(sender As Object, e As EventArgs) Handles btnMngMenu.Click
        Me.Close()
        frmManagementMenu.Show() 'navigation button that loads the management menu and closes the current form
    End Sub

    Private Sub frmStockAnalysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'this subroutine adds the options to select the time interval when the menu is opened
        ReadStock() 'reads stock data
        cmbTime.Items.Add("Monthly") 'adds the options to select the time interval
        cmbTime.Items.Add("Yearly")
    End Sub

    Sub CreateMonthlyChart()
        'subroutine which creates the graph
        s.ChartType = SeriesChartType.Line 'creates a series for a line graph

        'if the Monthly interval has been selected then the values are added
        If cmbTime.Text = "Monthly" Then
            For i = 0 To 11
                s.Points.AddXY(month(i), values(i)) 'adds the points to the graph
            Next
            StockChart.Series.Clear() 'clears any previous series
            StockChart.Series.Add(s) 'adds the new series to the graph
        Else 'if the year interval has been selected
            'bubble sort to sort the years and their appropiate records into order
            Dim swapped As Boolean = True 'keeps track if there are any swaps made with each pass
            Dim temp As orderHistoryYear 'stores the record of the yearly order history to swap
            'sorts the array into ascending order
            While swapped = True 'set to True so it can keep looping until there is a pass with no swaps
                swapped = False 'set to False so if the program sets it to True again then a swap has been made
                For i = 0 To IndexOrderYear - 1
                    If Convert.ToInt32(arrOrderHistoryYear(i + 1).Year) <> 0 Then 'if there is more than one record
                        If Convert.ToInt32(arrOrderHistoryYear(i).Year) > Convert.ToInt32(arrOrderHistoryYear(i + 1).Year) Then 'if the year of the record is smaller than the year of the record in the index after
                            'swaps the records 
                            temp = arrOrderHistoryYear(i)
                            arrOrderHistoryYear(i) = arrOrderHistoryYear(i + 1) 'swaps the records around
                            arrOrderHistoryYear(i + 1) = temp
                            swapped = True 'set to True as a swap has been made
                        End If
                    End If
                Next
            End While

            Dim YearlyTotal As Integer 'stores the total yearly cost of a stock item

            For i = 0 To IndexOrderYear - 1 'works out the yearly total for a certain year and stores it into the yearly totals array chronologically
                YearlyTotal = Convert.ToInt32(arrOrderHistoryYear(i).January) + Convert.ToInt32(arrOrderHistoryYear(i).February) + Convert.ToInt32(arrOrderHistoryYear(i).March) + Convert.ToInt32(arrOrderHistoryYear(i).April) + Convert.ToInt32(arrOrderHistoryYear(i).May) + Convert.ToInt32(arrOrderHistoryYear(i).June) + Convert.ToInt32(arrOrderHistoryYear(i).July) + Convert.ToInt32(arrOrderHistoryYear(i).August) + Convert.ToInt32(arrOrderHistoryYear(i).September) + Convert.ToInt32(arrOrderHistoryYear(i).October) + Convert.ToInt32(arrOrderHistoryYear(i).November) + Convert.ToInt32(arrOrderHistoryYear(i).December)
                arrYearlyTotals(i) = YearlyTotal
            Next

            For i = 0 To IndexOrderYear - 1 'adds the points to the graph
                s.Points.AddXY(arrOrderHistoryYear(i).Year, arrYearlyTotals(i))
            Next
            StockChart.Series.Clear() 'clears any previous series
            StockChart.Series.Add(s) 'adds the new series to the graph
        End If
    End Sub

    Private Sub txtStockID_TextChanged(sender As Object, e As EventArgs) Handles txtStockID.TextChanged
        'this subroutine updates the name textbox and graph read-only textbox when an ID is typed in
        If txtStockID.Text = "" Then 'if the ID textbox is cleared then the name textbox is cleared too
            txtStockName.Text = ""
        Else
            For i = 0 To IndexStock - 1 'searches for the matching IDs and updates the other two textboxes when a match is found
                If txtStockID.Text = arrStock(i).ID Then
                    txtStockName.Text = arrStock(i).Name 'updates the name textbox if the ID entered matches
                    txtGraph.Text = arrStock(i).Name 'updates the graph textbox to show which graph will be plotted
                End If
            Next
            cmbSelectYear.Text = "" 'clears the text in the combobox
            cmbSelectYear.Items.Clear() 'clears the items in the combobox
            LoadMonthlyValues() 'loads the data from the order history
            For i = 0 To IndexOrderYear - 1
                cmbSelectYear.Items.Add(arrOrderHistoryYear(i).Year) 'loads the years that can be selected to load in the monthly values
            Next
        End If
    End Sub

    Private Sub txtStockName_TextChanged(sender As Object, e As EventArgs) Handles txtStockName.TextChanged
        'this subroutine autofills the name if the first part of the name is entered
        Dim spacePosition As Integer = 0 'stores the position of the "space" in the string
        For i = 0 To IndexStock - 1
            spacePosition = arrStock(i).Name.IndexOf(" ") 'works out the position of the space
            If spacePosition > 0 Then 'if the space isnt the first character of the string then
                If txtStockName.Text.ToLower = arrStock(i).Name.Substring(0, spacePosition).ToLower Then 'if the name entered matches the first part of another name
                    txtStockName.Text = arrStock(i).Name 'the stock name textbox is updated to the full name
                End If
            ElseIf txtStockName.Text.ToLower = arrStock(i).Name.ToLower Then 'if the name entered matches the name in the array
                txtStockName.Text = arrStock(i).Name 'matches the name entered to the name in file, main function is to match any capitalisations
            End If
        Next

        'updates the ID textbox automatically when the name is entered
        If txtStockName.Text = "" Then
            txtStockID.Text = "" 'if the name textbox is cleared then the ID textbox is cleared too
        Else 'finds the ID that matches the name entered by searching through the stock array
            For i = 0 To IndexStock - 1
                If txtStockName.Text = arrStock(i).Name Then
                    txtStockID.Text = arrStock(i).ID 'updates the ID textbox if the name entered matches
                    txtGraph.Text = arrStock(i).Name 'updates the graph textbox to show which graph will be plotted
                End If
            Next
        End If
    End Sub

    Private Sub btnAddGraph_Click(sender As Object, e As EventArgs) Handles btnAddGraph.Click
        'this subroutine adds the graph when the button is clicked
        'validation:
        If PresenceCheck(txtStockID.Text) = False Then
            MsgBox("Please enter the stock ID") 'checks the stock ID textbox
            Exit Sub
        End If

        If PresenceCheck(txtStockName.Text) = False Then
            MsgBox("Please enter the stock name") 'checks the stock name textbox
            Exit Sub
        End If


        If GraphChanged = True Then 'clears the series and points only if the graph has been changed
            StockChart.Series.Clear()
            s.Points.Clear()
        End If
        LoadMonthlyValues() 'calls the subroutine which loads in the monthly stock data

        If cmbTime.Text = "Monthly" Then 'if the monthly graph is selected then it loads the selected year's data
            For i = 0 To IndexOrderYear - 1
                If arrOrderHistoryYear(i).Year = cmbSelectYear.Text Then
                    values(0) = arrOrderHistoryYear(i).January 'puts the monthly stock data into the values array
                    values(1) = arrOrderHistoryYear(i).February
                    values(2) = arrOrderHistoryYear(i).March
                    values(3) = arrOrderHistoryYear(i).April
                    values(4) = arrOrderHistoryYear(i).May
                    values(5) = arrOrderHistoryYear(i).June
                    values(6) = arrOrderHistoryYear(i).July
                    values(7) = arrOrderHistoryYear(i).August
                    values(8) = arrOrderHistoryYear(i).September
                    values(9) = arrOrderHistoryYear(i).October
                    values(10) = arrOrderHistoryYear(i).November
                    values(11) = arrOrderHistoryYear(i).December
                End If
            Next
        End If
        CreateMonthlyChart() 'sub to create the graph is called
        GraphChanged = True 'the graph has been changed so is set to True
    End Sub

    Private Sub txtGraph_TextChanged(sender As Object, e As EventArgs) Handles txtGraph.TextChanged
        cmbTime.Enabled = True 'if there is a graph selected then the time combobox can be enabled
    End Sub

    Private Sub cmbTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTime.SelectedIndexChanged
        'this subroutine loads in the monthly or yearly values depending on what is selected
        cmbSelectYear.Text = "" 'clears any values in the select year combobox if the time combobox is changed
        cmbSelectYear.Items.Clear()

        'enables or disables the select year combobox depending if monthly or yearly is selected
        If cmbTime.Text = "Monthly" Then
            cmbSelectYear.Enabled = True

            'loads in the monthly values from the file
            LoadMonthlyValues()
            For i = 0 To IndexOrderYear - 1
                cmbSelectYear.Items.Add(arrOrderHistoryYear(i).Year) 'loads in the years that have data
            Next
        Else
            cmbSelectYear.Enabled = False 'disables yearly combobox as it is not needed
        End If
    End Sub

    Sub LoadMonthlyValues()
        'this subroutine loads in the number of stock ordered per month
        Dim tempStockID As String 'stores the stock ID of the selected stock to graph
        ReadStock() 'reads stock information
        For i = 0 To IndexStock - 1
            If arrStock(i).Name = txtGraph.Text Then
                tempStockID = arrStock(i).ID 'sets the tempStockID to the stock ID that needs to be graphed
            End If
        Next
        Try
            ReadOrderHistory(tempStockID) 'reads the order history of the stock ID
        Catch ex As Exception
            MsgBox("Invalid graph entered.") 'error message displayed if there are errors
        End Try
    End Sub

    Private Sub btnRemoveGraph_Click(sender As Object, e As EventArgs) Handles btnRemoveGraph.Click
        'this subroutine clears the current graph when the clear graph button is clicked
        If GraphChanged = True Then
            StockChart.Series.Clear() 'clears the series and points only if the graph has been changed
            s.Points.Clear()
        End If
    End Sub
End Class