<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaffDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStaffDetails))
        Me.lstStaffID = New System.Windows.Forms.ListBox()
        Me.lstUsername = New System.Windows.Forms.ListBox()
        Me.lstPassword = New System.Windows.Forms.ListBox()
        Me.lstRestriction = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnMngMenu = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cBoxID = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cBoxSelectInfo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtNewInfo = New System.Windows.Forms.TextBox()
        Me.cBoxNewInfo = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstStaffID
        '
        Me.lstStaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstStaffID.FormattingEnabled = True
        Me.lstStaffID.ItemHeight = 16
        Me.lstStaffID.Location = New System.Drawing.Point(12, 87)
        Me.lstStaffID.Name = "lstStaffID"
        Me.lstStaffID.Size = New System.Drawing.Size(150, 276)
        Me.lstStaffID.TabIndex = 1
        '
        'lstUsername
        '
        Me.lstUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUsername.FormattingEnabled = True
        Me.lstUsername.ItemHeight = 16
        Me.lstUsername.Location = New System.Drawing.Point(179, 87)
        Me.lstUsername.Name = "lstUsername"
        Me.lstUsername.Size = New System.Drawing.Size(150, 276)
        Me.lstUsername.TabIndex = 2
        '
        'lstPassword
        '
        Me.lstPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPassword.FormattingEnabled = True
        Me.lstPassword.ItemHeight = 16
        Me.lstPassword.Location = New System.Drawing.Point(347, 88)
        Me.lstPassword.Name = "lstPassword"
        Me.lstPassword.Size = New System.Drawing.Size(150, 276)
        Me.lstPassword.TabIndex = 3
        '
        'lstRestriction
        '
        Me.lstRestriction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRestriction.FormattingEnabled = True
        Me.lstRestriction.ItemHeight = 16
        Me.lstRestriction.Location = New System.Drawing.Point(516, 88)
        Me.lstRestriction.Name = "lstRestriction"
        Me.lstRestriction.Size = New System.Drawing.Size(150, 276)
        Me.lstRestriction.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Staff ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(216, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(385, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(504, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Sensitive Menu Restriction?"
        '
        'btnMngMenu
        '
        Me.btnMngMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMngMenu.Location = New System.Drawing.Point(550, 3)
        Me.btnMngMenu.Name = "btnMngMenu"
        Me.btnMngMenu.Size = New System.Drawing.Size(127, 52)
        Me.btnMngMenu.TabIndex = 17
        Me.btnMngMenu.Text = "Main Menu"
        Me.btnMngMenu.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 380)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Edit Information:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(-6, 367)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(721, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = resources.GetString("Label7.Text")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 414)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Select ID:"
        '
        'cBoxID
        '
        Me.cBoxID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBoxID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBoxID.FormattingEnabled = True
        Me.cBoxID.Location = New System.Drawing.Point(93, 411)
        Me.cBoxID.Name = "cBoxID"
        Me.cBoxID.Size = New System.Drawing.Size(69, 28)
        Me.cBoxID.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(209, 414)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(189, 20)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Select information to edit:"
        '
        'cBoxSelectInfo
        '
        Me.cBoxSelectInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBoxSelectInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBoxSelectInfo.FormattingEnabled = True
        Me.cBoxSelectInfo.Location = New System.Drawing.Point(414, 411)
        Me.cBoxSelectInfo.Name = "cBoxSelectInfo"
        Me.cBoxSelectInfo.Size = New System.Drawing.Size(171, 28)
        Me.cBoxSelectInfo.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(145, 455)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(168, 20)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Enter new information:"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(271, 488)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(127, 52)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtNewInfo
        '
        Me.txtNewInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewInfo.Location = New System.Drawing.Point(319, 452)
        Me.txtNewInfo.Name = "txtNewInfo"
        Me.txtNewInfo.Size = New System.Drawing.Size(168, 26)
        Me.txtNewInfo.TabIndex = 25
        '
        'cBoxNewInfo
        '
        Me.cBoxNewInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBoxNewInfo.Enabled = False
        Me.cBoxNewInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBoxNewInfo.FormattingEnabled = True
        Me.cBoxNewInfo.Location = New System.Drawing.Point(345, 451)
        Me.cBoxNewInfo.Name = "cBoxNewInfo"
        Me.cBoxNewInfo.Size = New System.Drawing.Size(121, 28)
        Me.cBoxNewInfo.TabIndex = 27
        Me.cBoxNewInfo.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(743, 59)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(231, 42)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Staff Details"
        '
        'frmStaffDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 552)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cBoxNewInfo)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtNewInfo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cBoxSelectInfo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cBoxID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnMngMenu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstRestriction)
        Me.Controls.Add(Me.lstPassword)
        Me.Controls.Add(Me.lstUsername)
        Me.Controls.Add(Me.lstStaffID)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmStaffDetails"
        Me.Text = "frmStaffDetails"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstStaffID As ListBox
    Friend WithEvents lstUsername As ListBox
    Friend WithEvents lstPassword As ListBox
    Friend WithEvents lstRestriction As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnMngMenu As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cBoxID As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cBoxSelectInfo As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtNewInfo As TextBox
    Friend WithEvents cBoxNewInfo As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
End Class
