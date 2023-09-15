<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Maintance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnback = New System.Windows.Forms.Button()
        Me.gbmaintance = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtproblam = New System.Windows.Forms.TextBox()
        Me.txtgragename = New System.Windows.Forms.TextBox()
        Me.txtcarid = New System.Windows.Forms.TextBox()
        Me.txtfinishdate = New System.Windows.Forms.TextBox()
        Me.btnaddnew = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.gbmaintance.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnback.Location = New System.Drawing.Point(1010, 384)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(114, 29)
        Me.btnback.TabIndex = 5
        Me.btnback.Text = "Back "
        Me.btnback.UseVisualStyleBackColor = False
        '
        'gbmaintance
        '
        Me.gbmaintance.BackColor = System.Drawing.Color.AliceBlue
        Me.gbmaintance.Controls.Add(Me.Label4)
        Me.gbmaintance.Controls.Add(Me.Label3)
        Me.gbmaintance.Controls.Add(Me.Label2)
        Me.gbmaintance.Controls.Add(Me.Label1)
        Me.gbmaintance.Controls.Add(Me.txtproblam)
        Me.gbmaintance.Controls.Add(Me.txtgragename)
        Me.gbmaintance.Controls.Add(Me.txtcarid)
        Me.gbmaintance.Controls.Add(Me.txtfinishdate)
        Me.gbmaintance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbmaintance.ForeColor = System.Drawing.Color.BlueViolet
        Me.gbmaintance.Location = New System.Drawing.Point(12, 12)
        Me.gbmaintance.Name = "gbmaintance"
        Me.gbmaintance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gbmaintance.Size = New System.Drawing.Size(1129, 182)
        Me.gbmaintance.TabIndex = 6
        Me.gbmaintance.TabStop = False
        Me.gbmaintance.Text = "Maintance Form"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(646, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Finish Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(439, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Problem"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(237, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Garage Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(24, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Car Number"
        '
        'txtproblam
        '
        Me.txtproblam.Location = New System.Drawing.Point(442, 74)
        Me.txtproblam.Name = "txtproblam"
        Me.txtproblam.Size = New System.Drawing.Size(137, 22)
        Me.txtproblam.TabIndex = 3
        '
        'txtgragename
        '
        Me.txtgragename.Location = New System.Drawing.Point(240, 74)
        Me.txtgragename.Name = "txtgragename"
        Me.txtgragename.Size = New System.Drawing.Size(137, 22)
        Me.txtgragename.TabIndex = 2
        '
        'txtcarid
        '
        Me.txtcarid.Location = New System.Drawing.Point(27, 74)
        Me.txtcarid.Name = "txtcarid"
        Me.txtcarid.Size = New System.Drawing.Size(137, 22)
        Me.txtcarid.TabIndex = 1
        '
        'txtfinishdate
        '
        Me.txtfinishdate.Location = New System.Drawing.Point(649, 74)
        Me.txtfinishdate.Name = "txtfinishdate"
        Me.txtfinishdate.Size = New System.Drawing.Size(137, 22)
        Me.txtfinishdate.TabIndex = 0
        '
        'btnaddnew
        '
        Me.btnaddnew.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnaddnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddnew.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnaddnew.Location = New System.Drawing.Point(1010, 29)
        Me.btnaddnew.Name = "btnaddnew"
        Me.btnaddnew.Size = New System.Drawing.Size(114, 29)
        Me.btnaddnew.TabIndex = 7
        Me.btnaddnew.Text = "Add new"
        Me.btnaddnew.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnupdate.Location = New System.Drawing.Point(1010, 86)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(114, 29)
        Me.btnupdate.TabIndex = 8
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btndelete.Location = New System.Drawing.Point(1010, 143)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(114, 29)
        Me.btndelete.TabIndex = 9
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.Location = New System.Drawing.Point(12, 200)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(992, 253)
        Me.DataGridView1.TabIndex = 10
        '
        'Maintance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 573)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnaddnew)
        Me.Controls.Add(Me.gbmaintance)
        Me.Controls.Add(Me.btnback)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Name = "Maintance"
        Me.Text = "Maintance"
        Me.gbmaintance.ResumeLayout(False)
        Me.gbmaintance.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnback As Button
    Friend WithEvents gbmaintance As GroupBox
    Friend WithEvents btnaddnew As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents txtproblam As TextBox
    Friend WithEvents txtgragename As TextBox
    Friend WithEvents txtcarid As TextBox
    Friend WithEvents txtfinishdate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
