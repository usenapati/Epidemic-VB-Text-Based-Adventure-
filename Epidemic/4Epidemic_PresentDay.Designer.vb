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
        Me.PbxBackpack = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PbxBackpack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblPresent.Location = New System.Drawing.Point(12, 18)
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
        Me.btnQZ.Location = New System.Drawing.Point(259, 641)
        Me.btnQZ.Name = "btnQZ"
        Me.btnQZ.Size = New System.Drawing.Size(210, 50)
        Me.btnQZ.TabIndex = 3
        Me.btnQZ.Text = "Look around Qurantine Zone"
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
        'PbxBackpack
        '
        Me.PbxBackpack.Image = Global.Epidemic.My.Resources.Resources.Backpack
        Me.PbxBackpack.Location = New System.Drawing.Point(33, 432)
        Me.PbxBackpack.Name = "PbxBackpack"
        Me.PbxBackpack.Size = New System.Drawing.Size(90, 112)
        Me.PbxBackpack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxBackpack.TabIndex = 5
        Me.PbxBackpack.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Epidemic.My.Resources.Resources.QZ
        Me.PictureBox2.Location = New System.Drawing.Point(-5, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(741, 708)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Epidemic_PresentDay4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 703)
        Me.Controls.Add(Me.PbxBackpack)
        Me.Controls.Add(Me.btnStatus)
        Me.Controls.Add(Me.btnQZ)
        Me.Controls.Add(Me.btnGO1)
        Me.Controls.Add(Me.lblPresent)
        Me.Controls.Add(Me.btnFZ)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Epidemic_PresentDay4"
        Me.Text = "Epidemic - Present Day"
        CType(Me.PbxBackpack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFZ As System.Windows.Forms.Button
    Friend WithEvents lblPresent As System.Windows.Forms.Label
    Friend WithEvents btnGO1 As System.Windows.Forms.Button
    Friend WithEvents btnQZ As System.Windows.Forms.Button
    Friend WithEvents btnStatus As System.Windows.Forms.Button
    Friend WithEvents PbxBackpack As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
