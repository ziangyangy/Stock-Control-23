<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockAnalysis
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.StockChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnMngMenu = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStockID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStockName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGraph = New System.Windows.Forms.TextBox()
        Me.cmbTime = New System.Windows.Forms.ComboBox()
        Me.btnAddGraph = New System.Windows.Forms.Button()
        Me.btnRemoveGraph = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbSelectYear = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.StockChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StockChart
        '
        ChartArea1.Name = "ChartArea1"
        Me.StockChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.StockChart.Legends.Add(Legend1)
        Me.StockChart.Location = New System.Drawing.Point(324, 82)
        Me.StockChart.Name = "StockChart"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.StockChart.Series.Add(Series1)
        Me.StockChart.Size = New System.Drawing.Size(818, 435)
        Me.StockChart.TabIndex = 0
        Me.StockChart.Text = "cmbSelectYear"
        '
        'btnMngMenu
        '
        Me.btnMngMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMngMenu.Location = New System.Drawing.Point(1007, 3)
        Me.btnMngMenu.Name = "btnMngMenu"
        Me.btnMngMenu.Size = New System.Drawing.Size(135, 50)
        Me.btnMngMenu.TabIndex = 11
        Me.btnMngMenu.Text = "Main Menu"
        Me.btnMngMenu.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(96, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Enter Stock ID:"
        '
        'txtStockID
        '
        Me.txtStockID.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockID.Location = New System.Drawing.Point(15, 142)
        Me.txtStockID.Multiline = True
        Me.txtStockID.Name = "txtStockID"
        Me.txtStockID.Size = New System.Drawing.Size(286, 42)
        Me.txtStockID.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(92, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Enter Stock Name:"
        '
        'txtStockName
        '
        Me.txtStockName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockName.Location = New System.Drawing.Point(15, 210)
        Me.txtStockName.Multiline = True
        Me.txtStockName.Name = "txtStockName"
        Me.txtStockName.Size = New System.Drawing.Size(286, 42)
        Me.txtStockName.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Graph to Add:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightGray
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(104, 323)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Time Interval:"
        '
        'txtGraph
        '
        Me.txtGraph.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGraph.Location = New System.Drawing.Point(15, 278)
        Me.txtGraph.Multiline = True
        Me.txtGraph.Name = "txtGraph"
        Me.txtGraph.ReadOnly = True
        Me.txtGraph.Size = New System.Drawing.Size(286, 42)
        Me.txtGraph.TabIndex = 21
        '
        'cmbTime
        '
        Me.cmbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTime.Enabled = False
        Me.cmbTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTime.FormattingEnabled = True
        Me.cmbTime.Location = New System.Drawing.Point(15, 346)
        Me.cmbTime.Name = "cmbTime"
        Me.cmbTime.Size = New System.Drawing.Size(286, 39)
        Me.cmbTime.TabIndex = 22
        '
        'btnAddGraph
        '
        Me.btnAddGraph.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddGraph.Location = New System.Drawing.Point(161, 459)
        Me.btnAddGraph.Name = "btnAddGraph"
        Me.btnAddGraph.Size = New System.Drawing.Size(139, 54)
        Me.btnAddGraph.TabIndex = 23
        Me.btnAddGraph.Text = "Add Graph"
        Me.btnAddGraph.UseVisualStyleBackColor = True
        '
        'btnRemoveGraph
        '
        Me.btnRemoveGraph.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveGraph.Location = New System.Drawing.Point(16, 459)
        Me.btnRemoveGraph.Name = "btnRemoveGraph"
        Me.btnRemoveGraph.Size = New System.Drawing.Size(139, 54)
        Me.btnRemoveGraph.TabIndex = 24
        Me.btnRemoveGraph.Text = "Clear Graph"
        Me.btnRemoveGraph.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightGray
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(104, 388)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Select Year:"
        '
        'cmbSelectYear
        '
        Me.cmbSelectYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelectYear.Enabled = False
        Me.cmbSelectYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSelectYear.FormattingEnabled = True
        Me.cmbSelectYear.Location = New System.Drawing.Point(15, 411)
        Me.cmbSelectYear.Name = "cmbSelectYear"
        Me.cmbSelectYear.Size = New System.Drawing.Size(286, 39)
        Me.cmbSelectYear.TabIndex = 26
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PictureBox1.Location = New System.Drawing.Point(-18, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1186, 59)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(405, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(276, 42)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Stock Analysis"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PictureBox2.Location = New System.Drawing.Point(12, 78)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(293, 35)
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox5.Location = New System.Drawing.Point(12, 107)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(293, 410)
        Me.PictureBox5.TabIndex = 38
        Me.PictureBox5.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(106, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 33)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Graph"
        '
        'frmStockAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 546)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbSelectYear)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnRemoveGraph)
        Me.Controls.Add(Me.btnAddGraph)
        Me.Controls.Add(Me.cmbTime)
        Me.Controls.Add(Me.txtGraph)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStockName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtStockID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnMngMenu)
        Me.Controls.Add(Me.StockChart)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Name = "frmStockAnalysis"
        Me.Text = "frmStockAnalysis"
        CType(Me.StockChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StockChart As DataVisualization.Charting.Chart
    Friend WithEvents btnMngMenu As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStockID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStockName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGraph As TextBox
    Friend WithEvents cmbTime As ComboBox
    Friend WithEvents btnAddGraph As Button
    Friend WithEvents btnRemoveGraph As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbSelectYear As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label7 As Label
End Class
