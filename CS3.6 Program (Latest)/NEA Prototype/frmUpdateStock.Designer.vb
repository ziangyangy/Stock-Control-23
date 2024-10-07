<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateStock
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
        Me.cmbID = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtThLevel = New System.Windows.Forms.TextBox()
        Me.txtCuLevel = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnUpdateStock = New System.Windows.Forms.Button()
        Me.btnMngMenu = New System.Windows.Forms.Button()
        Me.chkboxName = New System.Windows.Forms.CheckBox()
        Me.chkboxCuLevel = New System.Windows.Forms.CheckBox()
        Me.chkboxThLevel = New System.Windows.Forms.CheckBox()
        Me.chkboxCost = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbID
        '
        Me.cmbID.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbID.FormattingEnabled = True
        Me.cmbID.Location = New System.Drawing.Point(115, 68)
        Me.cmbID.Name = "cmbID"
        Me.cmbID.Size = New System.Drawing.Size(70, 39)
        Me.cmbID.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(191, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Select:"
        '
        'cmbName
        '
        Me.cmbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbName.FormattingEnabled = True
        Me.cmbName.Location = New System.Drawing.Point(248, 68)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.Size = New System.Drawing.Size(248, 39)
        Me.cmbName.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Modify Details:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 297)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Cost:"
        '
        'txtCost
        '
        Me.txtCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Location = New System.Drawing.Point(133, 285)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(269, 38)
        Me.txtCost.TabIndex = 17
        '
        'txtThLevel
        '
        Me.txtThLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThLevel.Location = New System.Drawing.Point(133, 241)
        Me.txtThLevel.Name = "txtThLevel"
        Me.txtThLevel.Size = New System.Drawing.Size(269, 38)
        Me.txtThLevel.TabIndex = 16
        '
        'txtCuLevel
        '
        Me.txtCuLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuLevel.Location = New System.Drawing.Point(133, 197)
        Me.txtCuLevel.Name = "txtCuLevel"
        Me.txtCuLevel.Size = New System.Drawing.Size(269, 38)
        Me.txtCuLevel.TabIndex = 15
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(133, 153)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(269, 38)
        Me.txtName.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Threshold Level:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 205)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Current Level:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Name:"
        '
        'btnUpdateStock
        '
        Me.btnUpdateStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateStock.Location = New System.Drawing.Point(195, 342)
        Me.btnUpdateStock.Name = "btnUpdateStock"
        Me.btnUpdateStock.Size = New System.Drawing.Size(125, 52)
        Me.btnUpdateStock.TabIndex = 20
        Me.btnUpdateStock.Text = "Update Stock"
        Me.btnUpdateStock.UseVisualStyleBackColor = True
        '
        'btnMngMenu
        '
        Me.btnMngMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMngMenu.Location = New System.Drawing.Point(395, 3)
        Me.btnMngMenu.Name = "btnMngMenu"
        Me.btnMngMenu.Size = New System.Drawing.Size(127, 52)
        Me.btnMngMenu.TabIndex = 19
        Me.btnMngMenu.Text = "Main Menu"
        Me.btnMngMenu.UseVisualStyleBackColor = True
        '
        'chkboxName
        '
        Me.chkboxName.AutoSize = True
        Me.chkboxName.Location = New System.Drawing.Point(440, 163)
        Me.chkboxName.Name = "chkboxName"
        Me.chkboxName.Size = New System.Drawing.Size(15, 14)
        Me.chkboxName.TabIndex = 21
        Me.chkboxName.UseVisualStyleBackColor = True
        '
        'chkboxCuLevel
        '
        Me.chkboxCuLevel.AutoSize = True
        Me.chkboxCuLevel.Location = New System.Drawing.Point(440, 210)
        Me.chkboxCuLevel.Name = "chkboxCuLevel"
        Me.chkboxCuLevel.Size = New System.Drawing.Size(15, 14)
        Me.chkboxCuLevel.TabIndex = 22
        Me.chkboxCuLevel.UseVisualStyleBackColor = True
        '
        'chkboxThLevel
        '
        Me.chkboxThLevel.AutoSize = True
        Me.chkboxThLevel.Location = New System.Drawing.Point(440, 254)
        Me.chkboxThLevel.Name = "chkboxThLevel"
        Me.chkboxThLevel.Size = New System.Drawing.Size(15, 14)
        Me.chkboxThLevel.TabIndex = 23
        Me.chkboxThLevel.UseVisualStyleBackColor = True
        '
        'chkboxCost
        '
        Me.chkboxCost.AutoSize = True
        Me.chkboxCost.Location = New System.Drawing.Point(440, 298)
        Me.chkboxCost.Name = "chkboxCost"
        Me.chkboxCost.Size = New System.Drawing.Size(15, 14)
        Me.chkboxCost.TabIndex = 24
        Me.chkboxCost.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(408, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 30)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Keep current" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      value?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PictureBox1.Location = New System.Drawing.Point(-10, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(538, 59)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 42)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Update Stock"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(-13, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(559, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "---------------------------------------------------------------------------------" &
    "--------------------------------------------------------------------------------" &
    "-----------------------"
        '
        'frmUpdateStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 417)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.chkboxCost)
        Me.Controls.Add(Me.chkboxThLevel)
        Me.Controls.Add(Me.chkboxCuLevel)
        Me.Controls.Add(Me.chkboxName)
        Me.Controls.Add(Me.btnUpdateStock)
        Me.Controls.Add(Me.btnMngMenu)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtThLevel)
        Me.Controls.Add(Me.txtCuLevel)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbID)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmUpdateStock"
        Me.Text = "frmUpdateStock"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbID As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbName As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtThLevel As TextBox
    Friend WithEvents txtCuLevel As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnUpdateStock As Button
    Friend WithEvents btnMngMenu As Button
    Friend WithEvents chkboxName As CheckBox
    Friend WithEvents chkboxCuLevel As CheckBox
    Friend WithEvents chkboxThLevel As CheckBox
    Friend WithEvents chkboxCost As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
End Class
