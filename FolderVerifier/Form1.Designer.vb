<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TrayNotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MainContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonitorFolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.CheckTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ChangeFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MainContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TrayNotifyIcon
        '
        Me.TrayNotifyIcon.ContextMenuStrip = Me.MainContextMenuStrip
        Me.TrayNotifyIcon.Icon = CType(resources.GetObject("TrayNotifyIcon.Icon"), System.Drawing.Icon)
        Me.TrayNotifyIcon.Text = "Folder Verifier"
        Me.TrayNotifyIcon.Visible = True
        '
        'MainContextMenuStrip
        '
        Me.MainContextMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MainContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeFolderToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.MainContextMenuStrip.Name = "MainContextMenuStrip"
        Me.MainContextMenuStrip.Size = New System.Drawing.Size(241, 107)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(240, 32)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'CheckTimer
        '
        Me.CheckTimer.Interval = 1000
        '
        'ChangeFolderToolStripMenuItem
        '
        Me.ChangeFolderToolStripMenuItem.Name = "ChangeFolderToolStripMenuItem"
        Me.ChangeFolderToolStripMenuItem.Size = New System.Drawing.Size(240, 32)
        Me.ChangeFolderToolStripMenuItem.Text = "Change Folder..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(237, 6)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 35)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.Text = "Folder Verifier"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.MainContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TrayNotifyIcon As NotifyIcon
    Friend WithEvents MainContextMenuStrip As ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonitorFolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents CheckTimer As Timer
    Friend WithEvents ChangeFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
End Class
