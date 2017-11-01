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
        Me.BtnInches = New System.Windows.Forms.Button()
        Me.BtnFeet = New System.Windows.Forms.Button()
        Me.BtnYards = New System.Windows.Forms.Button()
        Me.BtnMiles = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnInches
        '
        Me.BtnInches.Location = New System.Drawing.Point(12, 143)
        Me.BtnInches.Name = "BtnInches"
        Me.BtnInches.Size = New System.Drawing.Size(75, 23)
        Me.BtnInches.TabIndex = 0
        Me.BtnInches.Text = "Inches"
        Me.BtnInches.UseVisualStyleBackColor = True
        '
        'BtnFeet
        '
        Me.BtnFeet.Location = New System.Drawing.Point(102, 143)
        Me.BtnFeet.Name = "BtnFeet"
        Me.BtnFeet.Size = New System.Drawing.Size(75, 23)
        Me.BtnFeet.TabIndex = 1
        Me.BtnFeet.Text = "Feet "
        Me.BtnFeet.UseVisualStyleBackColor = True
        '
        'BtnYards
        '
        Me.BtnYards.Location = New System.Drawing.Point(197, 143)
        Me.BtnYards.Name = "BtnYards"
        Me.BtnYards.Size = New System.Drawing.Size(75, 23)
        Me.BtnYards.TabIndex = 2
        Me.BtnYards.Text = "Yards"
        Me.BtnYards.UseVisualStyleBackColor = True
        '
        'BtnMiles
        '
        Me.BtnMiles.Location = New System.Drawing.Point(60, 184)
        Me.BtnMiles.Name = "BtnMiles"
        Me.BtnMiles.Size = New System.Drawing.Size(75, 23)
        Me.BtnMiles.TabIndex = 3
        Me.BtnMiles.Text = "Miles"
        Me.BtnMiles.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(152, 184)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Exit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "1 Kilometer = ?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.BtnMiles)
        Me.Controls.Add(Me.BtnYards)
        Me.Controls.Add(Me.BtnFeet)
        Me.Controls.Add(Me.BtnInches)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnInches As System.Windows.Forms.Button
    Friend WithEvents BtnFeet As System.Windows.Forms.Button
    Friend WithEvents BtnYards As System.Windows.Forms.Button
    Friend WithEvents BtnMiles As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
