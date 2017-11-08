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
        Me.lblJoke = New System.Windows.Forms.Label()
        Me.btnOne = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblJoke
        '
        Me.lblJoke.AutoSize = True
        Me.lblJoke.Location = New System.Drawing.Point(0, 73)
        Me.lblJoke.Name = "lblJoke"
        Me.lblJoke.Size = New System.Drawing.Size(305, 13)
        Me.lblJoke.TabIndex = 0
        Me.lblJoke.Text = "How Many Programmers Does It Take To Change A Lightbulb?"
        Me.lblJoke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOne
        '
        Me.btnOne.Location = New System.Drawing.Point(92, 124)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(75, 23)
        Me.btnOne.TabIndex = 1
        Me.btnOne.Text = "Answer"
        Me.btnOne.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnOne)
        Me.Controls.Add(Me.lblJoke)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblJoke As System.Windows.Forms.Label
    Friend WithEvents btnOne As System.Windows.Forms.Button

End Class
