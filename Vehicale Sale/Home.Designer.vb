<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.btnforsale = New System.Windows.Forms.Button()
        Me.btnmaintance = New System.Windows.Forms.Button()
        Me.btnsold = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnforsale
        '
        Me.btnforsale.BackColor = System.Drawing.Color.Chartreuse
        Me.btnforsale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnforsale.Font = New System.Drawing.Font("Franklin Gothic Book", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnforsale.Location = New System.Drawing.Point(74, 39)
        Me.btnforsale.Name = "btnforsale"
        Me.btnforsale.Size = New System.Drawing.Size(122, 47)
        Me.btnforsale.TabIndex = 0
        Me.btnforsale.Text = "For Sale"
        Me.btnforsale.UseVisualStyleBackColor = False
        '
        'btnmaintance
        '
        Me.btnmaintance.BackColor = System.Drawing.Color.Chartreuse
        Me.btnmaintance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmaintance.Font = New System.Drawing.Font("Franklin Gothic Book", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmaintance.Location = New System.Drawing.Point(74, 135)
        Me.btnmaintance.Name = "btnmaintance"
        Me.btnmaintance.Size = New System.Drawing.Size(122, 47)
        Me.btnmaintance.TabIndex = 1
        Me.btnmaintance.Text = "Maintance"
        Me.btnmaintance.UseVisualStyleBackColor = False
        '
        'btnsold
        '
        Me.btnsold.BackColor = System.Drawing.Color.Chartreuse
        Me.btnsold.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsold.Font = New System.Drawing.Font("Franklin Gothic Book", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsold.Location = New System.Drawing.Point(74, 237)
        Me.btnsold.Name = "btnsold"
        Me.btnsold.Size = New System.Drawing.Size(122, 47)
        Me.btnsold.TabIndex = 2
        Me.btnsold.Text = "Sold"
        Me.btnsold.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Chartreuse
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Book", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(74, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 47)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Settings"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(590, 406)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 29)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Back "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(793, 406)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 29)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Vehicale_Sale.My.Resources.Resources.car_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1009, 469)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnsold)
        Me.Controls.Add(Me.btnmaintance)
        Me.Controls.Add(Me.btnforsale)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnforsale As Button
    Friend WithEvents btnmaintance As Button
    Friend WithEvents btnsold As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
