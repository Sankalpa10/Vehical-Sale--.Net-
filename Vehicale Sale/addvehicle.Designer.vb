<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addvehicle
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.txtregyear = New System.Windows.Forms.TextBox()
        Me.txtmanuyear = New System.Windows.Forms.TextBox()
        Me.txtmodel = New System.Windows.Forms.TextBox()
        Me.txtbrand = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picbox1 = New System.Windows.Forms.PictureBox()
        Me.btnbrowse = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnaddvehicle = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picbox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Beige
        Me.GroupBox1.BackgroundImage = Global.Vehicale_Sale.My.Resources.Resources.istockphoto_500328404_170667a
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.txtprice)
        Me.GroupBox1.Controls.Add(Me.txtregyear)
        Me.GroupBox1.Controls.Add(Me.txtmanuyear)
        Me.GroupBox1.Controls.Add(Me.txtmodel)
        Me.GroupBox1.Controls.Add(Me.txtbrand)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(538, 474)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Vehicle"
        '
        'txtprice
        '
        Me.txtprice.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtprice.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.Location = New System.Drawing.Point(208, 367)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(241, 22)
        Me.txtprice.TabIndex = 15
        '
        'txtregyear
        '
        Me.txtregyear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtregyear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtregyear.Location = New System.Drawing.Point(208, 295)
        Me.txtregyear.Name = "txtregyear"
        Me.txtregyear.Size = New System.Drawing.Size(241, 22)
        Me.txtregyear.TabIndex = 14
        '
        'txtmanuyear
        '
        Me.txtmanuyear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtmanuyear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmanuyear.Location = New System.Drawing.Point(208, 239)
        Me.txtmanuyear.Name = "txtmanuyear"
        Me.txtmanuyear.Size = New System.Drawing.Size(241, 22)
        Me.txtmanuyear.TabIndex = 13
        '
        'txtmodel
        '
        Me.txtmodel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtmodel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmodel.Location = New System.Drawing.Point(208, 176)
        Me.txtmodel.Name = "txtmodel"
        Me.txtmodel.Size = New System.Drawing.Size(241, 22)
        Me.txtmodel.TabIndex = 12
        '
        'txtbrand
        '
        Me.txtbrand.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtbrand.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbrand.Location = New System.Drawing.Point(208, 116)
        Me.txtbrand.Name = "txtbrand"
        Me.txtbrand.Size = New System.Drawing.Size(241, 22)
        Me.txtbrand.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Wheat
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(106, 370)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Price :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Wheat
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Register Year :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Wheat
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Manufacrture Year :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Wheat
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Vehical Model :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Wheat
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Vehical Brand :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picbox1
        '
        Me.picbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picbox1.Location = New System.Drawing.Point(610, 12)
        Me.picbox1.Name = "picbox1"
        Me.picbox1.Size = New System.Drawing.Size(241, 149)
        Me.picbox1.TabIndex = 1
        Me.picbox1.TabStop = False
        '
        'btnbrowse
        '
        Me.btnbrowse.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnbrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbrowse.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnbrowse.Location = New System.Drawing.Point(661, 169)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.Size = New System.Drawing.Size(114, 29)
        Me.btnbrowse.TabIndex = 12
        Me.btnbrowse.Text = "Browse"
        Me.btnbrowse.UseVisualStyleBackColor = False
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnback.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnback.Location = New System.Drawing.Point(689, 360)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(114, 29)
        Me.btnback.TabIndex = 13
        Me.btnback.Text = "Back "
        Me.btnback.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnexit.Location = New System.Drawing.Point(777, 408)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(114, 29)
        Me.btnexit.TabIndex = 14
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnaddvehicle
        '
        Me.btnaddvehicle.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnaddvehicle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaddvehicle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddvehicle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnaddvehicle.Location = New System.Drawing.Point(590, 310)
        Me.btnaddvehicle.Name = "btnaddvehicle"
        Me.btnaddvehicle.Size = New System.Drawing.Size(114, 29)
        Me.btnaddvehicle.TabIndex = 15
        Me.btnaddvehicle.Text = "Add Vehicle"
        Me.btnaddvehicle.UseVisualStyleBackColor = False
        '
        'addvehicle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(903, 472)
        Me.Controls.Add(Me.btnaddvehicle)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btnbrowse)
        Me.Controls.Add(Me.picbox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "addvehicle"
        Me.Text = "addvehicle"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picbox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents picbox1 As PictureBox
    Friend WithEvents btnbrowse As Button
    Friend WithEvents txtprice As TextBox
    Friend WithEvents txtregyear As TextBox
    Friend WithEvents txtmanuyear As TextBox
    Friend WithEvents txtmodel As TextBox
    Friend WithEvents txtbrand As TextBox
    Friend WithEvents btnback As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents btnaddvehicle As Button
End Class
