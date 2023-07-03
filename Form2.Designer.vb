<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnSeller = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.LightBlue
        Me.btnAdmin.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnAdmin.Location = New System.Drawing.Point(651, 376)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(146, 46)
        Me.btnAdmin.TabIndex = 14
        Me.btnAdmin.Text = "Admin"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'btnSeller
        '
        Me.btnSeller.BackColor = System.Drawing.Color.LightCoral
        Me.btnSeller.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnSeller.Location = New System.Drawing.Point(438, 376)
        Me.btnSeller.Name = "btnSeller"
        Me.btnSeller.Size = New System.Drawing.Size(146, 46)
        Me.btnSeller.TabIndex = 13
        Me.btnSeller.Text = "Seller"
        Me.btnSeller.UseVisualStyleBackColor = False
        '
        'btnCustomer
        '
        Me.btnCustomer.BackColor = System.Drawing.Color.LightGreen
        Me.btnCustomer.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnCustomer.Location = New System.Drawing.Point(225, 376)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(146, 46)
        Me.btnCustomer.TabIndex = 12
        Me.btnCustomer.Text = "Customer"
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(388, 310)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(264, 30)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Please select an option below :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(419, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 30)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Who Are You?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1104, 657)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.btnSeller)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Account Login"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnSeller As Button
    Friend WithEvents btnCustomer As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
