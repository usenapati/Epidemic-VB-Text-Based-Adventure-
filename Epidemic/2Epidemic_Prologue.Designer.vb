<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Epidemic_Prologue2
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
        Me.lblPrologueText = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrologueText
        '
        Me.lblPrologueText.AutoSize = True
        Me.lblPrologueText.Location = New System.Drawing.Point(13, 13)
        Me.lblPrologueText.Name = "lblPrologueText"
        Me.lblPrologueText.Size = New System.Drawing.Size(72, 17)
        Me.lblPrologueText.TabIndex = 0
        Me.lblPrologueText.Text = "Exposition"
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(510, 641)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(210, 50)
        Me.btnContinue.TabIndex = 1
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'Epidemic_Prologue2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 703)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.lblPrologueText)
        Me.Name = "Epidemic_Prologue2"
        Me.Text = "Epidemic - Prologue"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrologueText As System.Windows.Forms.Label
    Friend WithEvents btnContinue As System.Windows.Forms.Button
End Class
