﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSideOne = New System.Windows.Forms.TextBox()
        Me.txtSideTwo = New System.Windows.Forms.TextBox()
        Me.txtHyp = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Length of one side"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Length of other side"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Length of Hypotenuse"
        '
        'txtSideOne
        '
        Me.txtSideOne.Location = New System.Drawing.Point(193, 23)
        Me.txtSideOne.Name = "txtSideOne"
        Me.txtSideOne.Size = New System.Drawing.Size(136, 22)
        Me.txtSideOne.TabIndex = 3
        '
        'txtSideTwo
        '
        Me.txtSideTwo.Location = New System.Drawing.Point(193, 51)
        Me.txtSideTwo.Name = "txtSideTwo"
        Me.txtSideTwo.Size = New System.Drawing.Size(136, 22)
        Me.txtSideTwo.TabIndex = 4
        '
        'txtHyp
        '
        Me.txtHyp.Location = New System.Drawing.Point(193, 211)
        Me.txtHyp.Name = "txtHyp"
        Me.txtHyp.ReadOnly = True
        Me.txtHyp.Size = New System.Drawing.Size(136, 22)
        Me.txtHyp.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(99, 122)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(187, 29)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate Hypotenuse"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 267)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtHyp)
        Me.Controls.Add(Me.txtSideTwo)
        Me.Controls.Add(Me.txtSideOne)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Right Triangle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSideOne As System.Windows.Forms.TextBox
    Friend WithEvents txtSideTwo As System.Windows.Forms.TextBox
    Friend WithEvents txtHyp As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button

End Class
