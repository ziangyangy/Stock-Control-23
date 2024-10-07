<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddOrder))
        Me.btnMngMenu = New System.Windows.Forms.Button()
        Me.btnPastOrders = New System.Windows.Forms.Button()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cBoxSupplier = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStockID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStockName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cBoxStatus = New System.Windows.Forms.ComboBox()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtPage = New System.Windows.Forms.TextBox()
        Me.btnAddOrder = New System.Windows.Forms.Button()
        Me.dpOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMngMenu
        '
        Me.btnMngMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMngMenu.Location = New System.Drawing.Point(433, 3)
        Me.btnMngMenu.Name = "btnMngMenu"
        Me.btnMngMenu.Size = New System.Drawing.Size(127, 52)
        Me.btnMngMenu.TabIndex = 11
        Me.btnMngMenu.Text = "Main Menu"
        Me.btnMngMenu.UseVisualStyleBackColor = True
        '
        'btnPastOrders
        '
        Me.btnPastOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPastOrders.Location = New System.Drawing.Point(303, 3)
        Me.btnPastOrders.Name = "btnPastOrders"
        Me.btnPastOrders.Size = New System.Drawing.Size(127, 52)
        Me.btnPastOrders.TabIndex = 12
        Me.btnPastOrders.Text = "Past Orders"
        Me.btnPastOrders.UseVisualStyleBackColor = True
        '
        'txtOrderID
        '
        Me.txtOrderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderID.Location = New System.Drawing.Point(220, 117)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(280, 29)
        Me.txtOrderID.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Enter Order ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Select Supplier:"
        '
        'cBoxSupplier
        '
        Me.cBoxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBoxSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBoxSupplier.FormattingEnabled = True
        Me.cBoxSupplier.Location = New System.Drawing.Point(220, 163)
        Me.cBoxSupplier.Name = "cBoxSupplier"
        Me.cBoxSupplier.Size = New System.Drawing.Size(280, 32)
        Me.cBoxSupplier.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Enter Stock ID:"
        '
        'txtStockID
        '
        Me.txtStockID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockID.Location = New System.Drawing.Point(220, 271)
        Me.txtStockID.Name = "txtStockID"
        Me.txtStockID.Size = New System.Drawing.Size(280, 29)
        Me.txtStockID.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Enter Stock Name:"
        '
        'txtStockName
        '
        Me.txtStockName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockName.Location = New System.Drawing.Point(220, 314)
        Me.txtStockName.Name = "txtStockName"
        Me.txtStockName.Size = New System.Drawing.Size(280, 29)
        Me.txtStockName.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 363)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 20)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Enter Quantity Ordered:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(220, 357)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(280, 29)
        Me.txtQuantity.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 20)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Select Status:"
        '
        'cBoxStatus
        '
        Me.cBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBoxStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBoxStatus.FormattingEnabled = True
        Me.cBoxStatus.Location = New System.Drawing.Point(220, 209)
        Me.cBoxStatus.Name = "cBoxStatus"
        Me.cBoxStatus.Size = New System.Drawing.Size(280, 32)
        Me.cBoxStatus.TabIndex = 24
        '
        'btnPrev
        '
        Me.btnPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.Location = New System.Drawing.Point(12, 402)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(127, 52)
        Me.btnPrev.TabIndex = 25
        Me.btnPrev.Text = "Prev"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(280, 402)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(127, 52)
        Me.btnNext.TabIndex = 26
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'txtPage
        '
        Me.txtPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPage.Location = New System.Drawing.Point(159, 419)
        Me.txtPage.Name = "txtPage"
        Me.txtPage.ReadOnly = True
        Me.txtPage.Size = New System.Drawing.Size(100, 22)
        Me.txtPage.TabIndex = 27
        '
        'btnAddOrder
        '
        Me.btnAddOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddOrder.Location = New System.Drawing.Point(424, 402)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(127, 52)
        Me.btnAddOrder.TabIndex = 28
        Me.btnAddOrder.Text = "Add Order"
        Me.btnAddOrder.UseVisualStyleBackColor = True
        '
        'dpOrderDate
        '
        Me.dpOrderDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpOrderDate.Location = New System.Drawing.Point(220, 73)
        Me.dpOrderDate.Name = "dpOrderDate"
        Me.dpOrderDate.Size = New System.Drawing.Size(280, 29)
        Me.dpOrderDate.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(35, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 20)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Select Date:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(596, 59)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 42)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Add Order"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(-6, 249)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(697, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = resources.GetString("Label8.Text")
        '
        'frmAddOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 464)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dpOrderDate)
        Me.Controls.Add(Me.btnAddOrder)
        Me.Controls.Add(Me.txtPage)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.cBoxStatus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtStockName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtStockID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cBoxSupplier)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPastOrders)
        Me.Controls.Add(Me.btnMngMenu)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmAddOrder"
        Me.Text = "frmAddOrder"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMngMenu As Button
    Friend WithEvents btnPastOrders As Button
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cBoxSupplier As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStockID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStockName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cBoxStatus As ComboBox
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txtPage As TextBox
    Friend WithEvents btnAddOrder As Button
    Friend WithEvents dpOrderDate As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
End Class
