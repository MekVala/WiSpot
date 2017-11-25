<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WiSpot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WiSpot))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Note = New System.Windows.Forms.Label()
        Me.Host_Name = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.H_name = New System.Windows.Forms.TextBox()
        Me.Pass = New System.Windows.Forms.TextBox()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.Note2 = New System.Windows.Forms.Label()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(95, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(193, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Note
        '
        Me.Note.AutoSize = True
        Me.Note.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Note.Location = New System.Drawing.Point(70, 124)
        Me.Note.Name = "Note"
        Me.Note.Size = New System.Drawing.Size(240, 30)
        Me.Note.TabIndex = 1
        Me.Note.Text = "Note : Please Check Your Wireless Adapter " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           Supports Hostnetworking."
        '
        'Host_Name
        '
        Me.Host_Name.AutoSize = True
        Me.Host_Name.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Host_Name.ForeColor = System.Drawing.Color.Red
        Me.Host_Name.Location = New System.Drawing.Point(12, 180)
        Me.Host_Name.Name = "Host_Name"
        Me.Host_Name.Size = New System.Drawing.Size(118, 26)
        Me.Host_Name.TabIndex = 2
        Me.Host_Name.Text = "Host Name :"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.ForeColor = System.Drawing.Color.Red
        Me.Password.Location = New System.Drawing.Point(26, 223)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(104, 26)
        Me.Password.TabIndex = 3
        Me.Password.Text = "Password :"
        '
        'H_name
        '
        Me.H_name.Location = New System.Drawing.Point(136, 186)
        Me.H_name.Name = "H_name"
        Me.H_name.Size = New System.Drawing.Size(203, 20)
        Me.H_name.TabIndex = 4
        '
        'Pass
        '
        Me.Pass.Location = New System.Drawing.Point(136, 229)
        Me.Pass.Name = "Pass"
        Me.Pass.Size = New System.Drawing.Size(203, 20)
        Me.Pass.TabIndex = 5
        '
        'StartButton
        '
        Me.StartButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.Location = New System.Drawing.Point(73, 284)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(100, 30)
        Me.StartButton.TabIndex = 6
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopButton.Location = New System.Drawing.Point(210, 284)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(100, 30)
        Me.StopButton.TabIndex = 7
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'Note2
        '
        Me.Note2.AutoSize = True
        Me.Note2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Note2.Location = New System.Drawing.Point(60, 332)
        Me.Note2.Name = "Note2"
        Me.Note2.Size = New System.Drawing.Size(265, 30)
        Me.Note2.TabIndex = 9
        Me.Note2.Text = "Stopping Hosted Network May Take Some Time. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Have Patience."
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.FileToolStripMenuItem.Text = "About"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 437)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(384, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "Menu"
        '
        'WiSpot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(384, 461)
        Me.Controls.Add(Me.Note2)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.Pass)
        Me.Controls.Add(Me.H_name)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Host_Name)
        Me.Controls.Add(Me.Note)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "WiSpot"
        Me.Text = "WiSpot"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Note As System.Windows.Forms.Label
    Friend WithEvents Host_Name As System.Windows.Forms.Label
    Friend WithEvents Password As System.Windows.Forms.Label
    Friend WithEvents H_name As System.Windows.Forms.TextBox
    Friend WithEvents Pass As System.Windows.Forms.TextBox
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents StopButton As System.Windows.Forms.Button
    Friend WithEvents Note2 As System.Windows.Forms.Label
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip

End Class
