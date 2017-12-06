<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _18GameOver1
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
        Me.lblGOText = New System.Windows.Forms.Label()
        Me.btnTryAgain = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGOText
        '
        Me.lblGOText.AutoSize = True
        Me.lblGOText.Location = New System.Drawing.Point(13, 13)
        Me.lblGOText.Name = "lblGOText"
        Me.lblGOText.Size = New System.Drawing.Size(104, 17)
        Me.lblGOText.TabIndex = 0
        Me.lblGOText.Text = "GameOverText"
        '
        'btnTryAgain
        '
        Me.btnTryAgain.Location = New System.Drawing.Point(289, 640)
        Me.btnTryAgain.Name = "btnTryAgain"
        Me.btnTryAgain.Size = New System.Drawing.Size(172, 51)
        Me.btnTryAgain.TabIndex = 1
        Me.btnTryAgain.Text = "Try Again"
        Me.btnTryAgain.UseVisualStyleBackColor = True
        '
        '_18GameOver1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 703)
        Me.Controls.Add(Me.btnTryAgain)
        Me.Controls.Add(Me.lblGOText)
        Me.Name = "_18GameOver1"
        Me.Text = "Epidemic - Game Over"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGOText As System.Windows.Forms.Label
    Friend WithEvents btnTryAgain As System.Windows.Forms.Button
End Class
