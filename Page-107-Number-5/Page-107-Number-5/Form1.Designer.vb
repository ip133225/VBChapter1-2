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
        Me.btnSinister = New System.Windows.Forms.Button()
        Me.btnMedium = New System.Windows.Forms.Button()
        Me.btnDexter = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblTwo = New System.Windows.Forms.Label()
        Me.lblThree = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSinister
        '
        Me.btnSinister.Location = New System.Drawing.Point(12, 104)
        Me.btnSinister.Name = "btnSinister"
        Me.btnSinister.Size = New System.Drawing.Size(75, 23)
        Me.btnSinister.TabIndex = 0
        Me.btnSinister.Text = "Sinister"
        Me.btnSinister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSinister.UseVisualStyleBackColor = True
        '
        'btnMedium
        '
        Me.btnMedium.Location = New System.Drawing.Point(106, 104)
        Me.btnMedium.Name = "btnMedium"
        Me.btnMedium.Size = New System.Drawing.Size(75, 23)
        Me.btnMedium.TabIndex = 1
        Me.btnMedium.Text = "Medium"
        Me.btnMedium.UseVisualStyleBackColor = True
        '
        'btnDexter
        '
        Me.btnDexter.Location = New System.Drawing.Point(197, 104)
        Me.btnDexter.Name = "btnDexter"
        Me.btnDexter.Size = New System.Drawing.Size(75, 23)
        Me.btnDexter.TabIndex = 2
        Me.btnDexter.Text = "Dexter"
        Me.btnDexter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDexter.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(40, 36)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(25, 13)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "Left"
        Me.lbl1.Visible = False
        '
        'lblTwo
        '
        Me.lblTwo.AutoSize = True
        Me.lblTwo.Location = New System.Drawing.Point(205, 36)
        Me.lblTwo.Name = "lblTwo"
        Me.lblTwo.Size = New System.Drawing.Size(32, 13)
        Me.lblTwo.TabIndex = 4
        Me.lblTwo.Text = "Right"
        Me.lblTwo.Visible = False
        '
        'lblThree
        '
        Me.lblThree.AutoSize = True
        Me.lblThree.Location = New System.Drawing.Point(121, 36)
        Me.lblThree.Name = "lblThree"
        Me.lblThree.Size = New System.Drawing.Size(38, 13)
        Me.lblThree.TabIndex = 5
        Me.lblThree.Text = "Center"
        Me.lblThree.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 215)
        Me.Controls.Add(Me.lblThree)
        Me.Controls.Add(Me.lblTwo)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnDexter)
        Me.Controls.Add(Me.btnMedium)
        Me.Controls.Add(Me.btnSinister)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSinister As System.Windows.Forms.Button
    Friend WithEvents btnMedium As System.Windows.Forms.Button
    Friend WithEvents btnDexter As System.Windows.Forms.Button
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lblTwo As System.Windows.Forms.Label
    Friend WithEvents lblThree As System.Windows.Forms.Label

End Class
