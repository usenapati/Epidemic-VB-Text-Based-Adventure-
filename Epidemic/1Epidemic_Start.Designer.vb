<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartScreen
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
        Me.components = New System.ComponentModel.Container()
        Me.PBxStart = New System.Windows.Forms.PictureBox()
        Me.PbxIntro = New System.Windows.Forms.PictureBox()
        Me.TimerIntro = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PBxStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxIntro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBxStart
        '
        Me.PBxStart.BackColor = System.Drawing.Color.Black
        Me.PBxStart.Image = Global.Epidemic.My.Resources.Resources.START_Epidemic__1_
        Me.PBxStart.InitialImage = Global.Epidemic.My.Resources.Resources.START_Epidemic
        Me.PBxStart.Location = New System.Drawing.Point(250, 595)
        Me.PBxStart.Name = "PBxStart"
        Me.PBxStart.Size = New System.Drawing.Size(225, 138)
        Me.PBxStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBxStart.TabIndex = 1
        Me.PBxStart.TabStop = False
        '
        'PbxIntro
        '
        Me.PbxIntro.BackColor = System.Drawing.Color.Black
        Me.PbxIntro.Location = New System.Drawing.Point(1, 1)
        Me.PbxIntro.Margin = New System.Windows.Forms.Padding(4)
        Me.PbxIntro.Name = "PbxIntro"
        Me.PbxIntro.Size = New System.Drawing.Size(737, 705)
        Me.PbxIntro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxIntro.TabIndex = 2
        Me.PbxIntro.TabStop = False
        '
        'TimerIntro
        '
        Me.TimerIntro.Enabled = True
        Me.TimerIntro.Interval = 45
        '
        'StartScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 703)
        Me.Controls.Add(Me.PBxStart)
        Me.Controls.Add(Me.PbxIntro)
        Me.Name = "StartScreen"
        Me.Text = "Epidemic"
        CType(Me.PBxStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxIntro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PBxStart As System.Windows.Forms.PictureBox
    Friend WithEvents PbxIntro As System.Windows.Forms.PictureBox
    Friend WithEvents TimerIntro As System.Windows.Forms.Timer

End Class
