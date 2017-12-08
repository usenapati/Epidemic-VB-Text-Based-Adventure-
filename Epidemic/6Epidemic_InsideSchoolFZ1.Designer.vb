<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _6Epidemic_InsideSchoolFZ1
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
        Me.btnExplore = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblEncounter = New System.Windows.Forms.Label()
        Me.PbxBackgound = New System.Windows.Forms.PictureBox()
        Me.btnNoEnter = New System.Windows.Forms.Button()
        Me.btnYesEnter = New System.Windows.Forms.Button()
        CType(Me.PbxBackgound, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btnExplore
        '
        Me.btnExplore.Location = New System.Drawing.Point(12, 646)
        Me.btnExplore.Name = "btnExplore"
        Me.btnExplore.Size = New System.Drawing.Size(125, 45)
        Me.btnExplore.TabIndex = 1
        Me.btnExplore.Text = "Explore the School?"
        Me.btnExplore.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(595, 646)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(125, 45)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "Enter the Gym?"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lblEncounter
        '
        Me.lblEncounter.AutoSize = True
        Me.lblEncounter.Location = New System.Drawing.Point(12, 41)
        Me.lblEncounter.Name = "lblEncounter"
        Me.lblEncounter.Size = New System.Drawing.Size(73, 17)
        Me.lblEncounter.TabIndex = 3
        Me.lblEncounter.Text = "Encounter"
        '
        'PbxBackgound
        '
        Me.PbxBackgound.Location = New System.Drawing.Point(-2, -1)
        Me.PbxBackgound.Name = "PbxBackgound"
        Me.PbxBackgound.Size = New System.Drawing.Size(735, 704)
        Me.PbxBackgound.TabIndex = 4
        Me.PbxBackgound.TabStop = False
        '
        'btnNoEnter
        '
        Me.btnNoEnter.Location = New System.Drawing.Point(595, 595)
        Me.btnNoEnter.Name = "btnNoEnter"
        Me.btnNoEnter.Size = New System.Drawing.Size(125, 45)
        Me.btnNoEnter.TabIndex = 5
        Me.btnNoEnter.Text = "No"
        Me.btnNoEnter.UseVisualStyleBackColor = True
        '
        'btnYesEnter
        '
        Me.btnYesEnter.Location = New System.Drawing.Point(12, 595)
        Me.btnYesEnter.Name = "btnYesEnter"
        Me.btnYesEnter.Size = New System.Drawing.Size(125, 45)
        Me.btnYesEnter.TabIndex = 6
        Me.btnYesEnter.Text = "Yes"
        Me.btnYesEnter.UseVisualStyleBackColor = True
        '
        '_6Epidemic_InsideSchoolFZ1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 703)
        Me.Controls.Add(Me.btnYesEnter)
        Me.Controls.Add(Me.btnNoEnter)
        Me.Controls.Add(Me.lblEncounter)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.btnExplore)
        Me.Controls.Add(Me.btnStatus)
        Me.Controls.Add(Me.PbxBackgound)
        Me.Name = "_6Epidemic_InsideSchoolFZ1"
        Me.Text = "Epidemic - Inside the school - Furry Zone 1"
        CType(Me.PbxBackgound, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStatus As System.Windows.Forms.Button
    Friend WithEvents btnExplore As System.Windows.Forms.Button
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents lblEncounter As System.Windows.Forms.Label
    Friend WithEvents PbxBackgound As System.Windows.Forms.PictureBox
    Friend WithEvents btnNoEnter As System.Windows.Forms.Button
    Friend WithEvents btnYesEnter As System.Windows.Forms.Button
End Class
