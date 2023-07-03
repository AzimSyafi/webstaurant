<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Btn_addgrp = New System.Windows.Forms.Button()
        Me.Btn_reset = New System.Windows.Forms.Button()
        Me.LstGroup = New System.Windows.Forms.ListBox()
        Me.lblwinner = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_addgrp
        '
        Me.Btn_addgrp.Location = New System.Drawing.Point(41, 28)
        Me.Btn_addgrp.Name = "Btn_addgrp"
        Me.Btn_addgrp.Size = New System.Drawing.Size(165, 354)
        Me.Btn_addgrp.TabIndex = 0
        Me.Btn_addgrp.Text = "Add Group Name"
        Me.Btn_addgrp.UseVisualStyleBackColor = True
        '
        'Btn_reset
        '
        Me.Btn_reset.Location = New System.Drawing.Point(41, 408)
        Me.Btn_reset.Name = "Btn_reset"
        Me.Btn_reset.Size = New System.Drawing.Size(165, 78)
        Me.Btn_reset.TabIndex = 1
        Me.Btn_reset.Text = "Reset"
        Me.Btn_reset.UseVisualStyleBackColor = True
        '
        'LstGroup
        '
        Me.LstGroup.FormattingEnabled = True
        Me.LstGroup.ItemHeight = 16
        Me.LstGroup.Location = New System.Drawing.Point(248, 28)
        Me.LstGroup.Name = "LstGroup"
        Me.LstGroup.Size = New System.Drawing.Size(611, 356)
        Me.LstGroup.TabIndex = 2
        '
        'lblwinner
        '
        Me.lblwinner.AutoSize = True
        Me.lblwinner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblwinner.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwinner.Location = New System.Drawing.Point(238, 408)
        Me.lblwinner.Name = "lblwinner"
        Me.lblwinner.Size = New System.Drawing.Size(631, 22)
        Me.lblwinner.TabIndex = 3
        Me.lblwinner.Text = "                                                                                 " &
    "                                           "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 517)
        Me.Controls.Add(Me.lblwinner)
        Me.Controls.Add(Me.LstGroup)
        Me.Controls.Add(Me.Btn_reset)
        Me.Controls.Add(Me.Btn_addgrp)
        Me.Name = "Form1"
        Me.Text = "OMC MARK CALCULATOR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_addgrp As Button
    Friend WithEvents Btn_reset As Button
    Friend WithEvents LstGroup As ListBox
    Friend WithEvents lblwinner As Label
End Class
