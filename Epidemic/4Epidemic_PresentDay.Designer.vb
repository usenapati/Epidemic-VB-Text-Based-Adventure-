<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Epidemic_PresentDay4
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
        Me.btnFZ = New System.Windows.Forms.Button()
        Me.lblPresent = New System.Windows.Forms.Label()
        Me.btnGO1 = New System.Windows.Forms.Button()
        Me.btnQZ = New System.Windows.Forms.Button()
        Me.btnStatus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFZ
        '
        Me.btnFZ.Location = New System.Drawing.Point(510, 641)
        Me.btnFZ.Name = "btnFZ"
        Me.btnFZ.Size = New System.Drawing.Size(210, 50)
        Me.btnFZ.TabIndex = 0
        Me.btnFZ.Text = "Furry Zone"
        Me.btnFZ.UseVisualStyleBackColor = True
        '
        'lblPresent
        '
        Me.lblPresent.AutoSize = True
        Me.lblPresent.Location = New System.Drawing.Point(13, 13)
        Me.lblPresent.Name = "lblPresent"
        Me.lblPresent.Size = New System.Drawing.Size(72, 17)
        Me.lblPresent.TabIndex = 1
        Me.lblPresent.Text = "Exposition"
        '
        'btnGO1
        '
        Me.btnGO1.Location = New System.Drawing.Point(12, 641)
        Me.btnGO1.Name = "btnGO1"
        Me.btnGO1.Size = New System.Drawing.Size(210, 50)
        Me.btnGO1.TabIndex = 2
        Me.btnGO1.Text = """Didn't like the kid anyway."""
        Me.btnGO1.UseVisualStyleBackColor = True
        '
        'btnQZ
        '
        Me.btnQZ.Location = New System.Drawing.Point(261, 641)
        Me.btnQZ.Name = "btnQZ"
        Me.btnQZ.Size = New System.Drawing.Size(210, 50)
        Me.btnQZ.TabIndex = 3
        Me.btnQZ.Text = "Qurantine Zone"
        Me.btnQZ.UseVisualStyleBackColor = True
        '
        'btnStatus
        '
        Me.btnStatus.Location = New System.Drawing.Point(645, 12)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Size = New System.Drawing.Size(75, 23)
        Me.btnStatus.TabIndex = 4
        Me.btnStatus.Text = "Status"
        Me.btnStatus.UseVisualStyleBackColor = True
        '
        'Epidemic_PresentDay4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 703)
        Me.Controls.Add(Me.btnStatus)
        Me.Controls.Add(Me.btnQZ)
        Me.Controls.Add(Me.btnGO1)
        Me.Controls.Add(Me.lblPresent)
        Me.Controls.Add(Me.btnFZ)
        Me.Name = "Epidemic_PresentDay4"
        Me.Text = "Epidemic - Present Day"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFZ As System.Windows.Forms.Button
    Friend WithEvents lblPresent As System.Windows.Forms.Label
    Friend WithEvents btnGO1 As System.Windows.Forms.Button
    Friend WithEvents btnQZ As System.Windows.Forms.Button
    Friend WithEvents btnStatus As System.Windows.Forms.Button
End Class
