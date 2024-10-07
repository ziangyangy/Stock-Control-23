<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaffMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStockList = New System.Windows.Forms.Button()
        Me.btnAddStockMenu = New System.Windows.Forms.Button()
        Me.btnUpdateStock = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnOrderList = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 42)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Staff Menu"
        '
        'btnStockList
        '
        Me.btnStockList.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockList.Location = New System.Drawing.Point(12, 80)
        Me.btnStockList.Name = "btnStockList"
        Me.btnStockList.Size = New System.Drawing.Size(157, 79)
        Me.btnStockList.TabIndex = 8
        Me.btnStockList.Text = "Stock List"
        Me.btnStockList.UseVisualStyleBackColor = True
        '
        'btnAddStockMenu
        '
        Me.btnAddStockMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStockMenu.Location = New System.Drawing.Point(188, 80)
        Me.btnAddStockMenu.Name = "btnAddStockMenu"
        Me.btnAddStockMenu.Size = New System.Drawing.Size(157, 79)
        Me.btnAddStockMenu.TabIndex = 9
        Me.btnAddStockMenu.Text = "Add Stock"
        Me.btnAddStockMenu.UseVisualStyleBackColor = True
        '
        'btnUpdateStock
        '
        Me.btnUpdateStock.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnUpdateStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateStock.Location = New System.Drawing.Point(12, 174)
        Me.btnUpdateStock.Name = "btnUpdateStock"
        Me.btnUpdateStock.Size = New System.Drawing.Size(157, 79)
        Me.btnUpdateStock.TabIndex = 10
        Me.btnUpdateStock.Text = "Update Stock"
        Me.btnUpdateStock.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(218, 5)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(135, 50)
        Me.btnLogOut.TabIndex = 12
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnOrderList
        '
        Me.btnOrderList.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderList.Location = New System.Drawing.Point(188, 174)
        Me.btnOrderList.Name = "btnOrderList"
        Me.btnOrderList.Size = New System.Drawing.Size(157, 79)
        Me.btnOrderList.TabIndex = 13
        Me.btnOrderList.Text = "Order List"
        Me.btnOrderList.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PictureBox1.Location = New System.Drawing.Point(-96, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(538, 59)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'frmStaffMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 271)
        Me.Controls.Add(Me.btnOrderList)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnUpdateStock)
        Me.Controls.Add(Me.btnAddStockMenu)
        Me.Controls.Add(Me.btnStockList)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmStaffMenu"
        Me.Text = "frmStaffMenu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnStockList As Button
    Friend WithEvents btnAddStockMenu As Button
    Friend WithEvents btnUpdateStock As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnOrderList As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
