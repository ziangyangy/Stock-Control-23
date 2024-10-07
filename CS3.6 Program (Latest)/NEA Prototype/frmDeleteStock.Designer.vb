<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeleteStock
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbBoxNames = New System.Windows.Forms.ComboBox()
        Me.btnMngMenu = New System.Windows.Forms.Button()
        Me.btnDeleteStock = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name:"
        '
        'cmbBoxNames
        '
        Me.cmbBoxNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBoxNames.FormattingEnabled = True
        Me.cmbBoxNames.Location = New System.Drawing.Point(87, 67)
        Me.cmbBoxNames.Name = "cmbBoxNames"
        Me.cmbBoxNames.Size = New System.Drawing.Size(300, 39)
        Me.cmbBoxNames.TabIndex = 2
        '
        'btnMngMenu
        '
        Me.btnMngMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMngMenu.Location = New System.Drawing.Point(284, 2)
        Me.btnMngMenu.Name = "btnMngMenu"
        Me.btnMngMenu.Size = New System.Drawing.Size(127, 52)
        Me.btnMngMenu.TabIndex = 3
        Me.btnMngMenu.Text = "Main Menu"
        Me.btnMngMenu.UseVisualStyleBackColor = True
        '
        'btnDeleteStock
        '
        Me.btnDeleteStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteStock.Location = New System.Drawing.Point(145, 121)
        Me.btnDeleteStock.Name = "btnDeleteStock"
        Me.btnDeleteStock.Size = New System.Drawing.Size(130, 58)
        Me.btnDeleteStock.TabIndex = 4
        Me.btnDeleteStock.Text = "Delete Stock Data"
        Me.btnDeleteStock.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PictureBox1.Location = New System.Drawing.Point(-122, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(538, 59)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 42)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Delete Stock"
        '
        'frmDeleteStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 194)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDeleteStock)
        Me.Controls.Add(Me.btnMngMenu)
        Me.Controls.Add(Me.cmbBoxNames)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmDeleteStock"
        Me.Text = "frmDeleteStock"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbBoxNames As ComboBox
    Friend WithEvents btnMngMenu As Button
    Friend WithEvents btnDeleteStock As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
