<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _5Epidemic_EntrancetoFZ
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
        Me.btnStatus = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.lblExpo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStatus
        '
        Me.btnStatus.Location = New System.Drawing.Point(645, 12)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Size = New System.Drawing.Size(75, 23)
        Me.btnStatus.TabIndex = 0
        Me.btnStatus.Text = "Status"
        Me.btnStatus.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(583, 639)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(137, 52)
        Me.btnContinue.TabIndex = 1
        Me.btnContinue.Text = "Cross the Gate"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'lblExpo
        '
        Me.lblExpo.AutoSize = True
        Me.lblExpo.Location = New System.Drawing.Point(12, 40)
        Me.lblExpo.Name = "lblExpo"
        Me.lblExpo.Size = New System.Drawing.Size(72, 17)
        Me.lblExpo.TabIndex = 2
        Me.lblExpo.Text = "Exposition"
        '
        '_5Epidemic_EntrancetoFZ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 703)
        Me.Controls.Add(Me.btnStatus)
        Me.Controls.Add(Me.lblExpo)
        Me.Controls.Add(Me.btnContinue)
        Me.Name = "_5Epidemic_EntrancetoFZ"
        Me.Text = "Epidemic - Entrance to Furry Zone"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStatus As System.Windows.Forms.Button
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents lblExpo As System.Windows.Forms.Label
End Class
