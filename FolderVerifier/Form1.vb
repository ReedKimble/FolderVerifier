Imports System.IO

Public Class Form1
    Private isFolderAvailable As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(My.Settings.MonitorPath) OrElse Not IO.Directory.Exists(My.Settings.MonitorPath) Then
            SelectMonitorFolder()
        End If
        If String.IsNullOrEmpty(My.Settings.MonitorPath) OrElse Not IO.Directory.Exists(My.Settings.MonitorPath) Then
            MessageBox.Show("No monitored folder selected, exiting application.", "Folder Verifier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
        isFolderAvailable = True
        CheckTimer.Enabled = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CheckTimer_Tick(sender As Object, e As EventArgs) Handles CheckTimer.Tick
        If Not IO.Directory.Exists(My.Settings.MonitorPath) Then
            If isFolderAvailable Then
                CheckTimer.Enabled = False
                isFolderAvailable = False
                MessageBox.Show($"{My.Settings.MonitorPath} is no longer available!", "Folder Verifier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                CheckTimer.Enabled = True
            End If
        ElseIf Not isFolderAvailable Then
            isFolderAvailable = True
            MessageBox.Show($"Connection to {My.Settings.MonitorPath} has been restored.", "Folder Verifier", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ChangeFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeFolderToolStripMenuItem.Click
        SelectMonitorFolder()
    End Sub

    Private Sub SelectMonitorFolder()
        MonitorFolderBrowserDialog.Description = "Select Folder to Verify"
        If MonitorFolderBrowserDialog.ShowDialog() = DialogResult.OK Then
            My.Settings.MonitorPath = MonitorFolderBrowserDialog.SelectedPath
            My.Settings.Save()
        End If
    End Sub
End Class
