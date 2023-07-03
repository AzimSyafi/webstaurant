<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form24
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.theWebstaurant_design.My.Resources.Resources.photo_2023_06_27_12_24_52
        Me.PictureBox1.Location = New System.Drawing.Point(403, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGreen
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Button1.Location = New System.Drawing.Point(98, 362)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 59)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Restaurant/Seller Management"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightGreen
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Button2.Location = New System.Drawing.Point(340, 362)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 59)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Customer Management"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightGreen
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Button3.Location = New System.Drawing.Point(585, 362)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(184, 59)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Product Management"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightGreen
        Me.Button4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Button4.Location = New System.Drawing.Point(834, 362)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(184, 59)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Announcement"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightGray
        Me.Button5.Location = New System.Drawing.Point(455, 515)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(160, 41)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Log Out"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Form24
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1104, 657)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "Form24"
        Me.Text = "Admin Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
