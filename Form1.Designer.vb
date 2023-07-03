<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.lblSignUp = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblregister = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.LightBlue
        Me.btnSignUp.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnSignUp.Location = New System.Drawing.Point(760, 482)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(93, 38)
        Me.btnSignUp.TabIndex = 23
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'lblSignUp
        '
        Me.lblSignUp.AutoSize = True
        Me.lblSignUp.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.lblSignUp.Location = New System.Drawing.Point(531, 492)
        Me.lblSignUp.Name = "lblSignUp"
        Me.lblSignUp.Size = New System.Drawing.Size(205, 19)
        Me.lblSignUp.TabIndex = 22
        Me.lblSignUp.Text = "Not on The Webstaurant yet?"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.LightSalmon
        Me.btnLogin.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnLogin.Location = New System.Drawing.Point(413, 482)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(93, 38)
        Me.btnLogin.TabIndex = 21
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.lblLogin.Location = New System.Drawing.Point(207, 492)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(176, 19)
        Me.lblLogin.TabIndex = 20
        Me.lblLogin.Text = "Do you have an account?"
        '
        'lblregister
        '
        Me.lblregister.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblregister.Location = New System.Drawing.Point(308, 101)
        Me.lblregister.Name = "lblregister"
        Me.lblregister.Size = New System.Drawing.Size(393, 23)
        Me.lblregister.TabIndex = 19
        Me.lblregister.Text = "Hi! Welcome to The Webstaurant. "
        Me.lblregister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.theWebstaurant_design.My.Resources.Resources.photo_2023_06_27_12_24_52
        Me.PictureBox1.Location = New System.Drawing.Point(372, 160)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(246, 249)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1104, 657)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.lblSignUp)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.lblregister)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Register"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSignUp As Button
    Friend WithEvents lblSignUp As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblregister As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
