Public Class WiSpot

    Private Sub StartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartButton.Click
        Dim Hname As String = H_name.Text
        Dim Pas As String = Pass.Text
        Dim Cmd As String = "netsh wlan set hostednetwork mode=allow ssid=" + Hname + " key=" + Pas
        Shell(Cmd)
        Shell("cmd /c netsh wlan start hostednetwork")
        StartButton.Enabled = False
        Check_Button()
    End Sub

    Private Sub StopButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopButton.Click
        Shell("cmd /c netsh wlan stop hostednetwork")
        StopButton.Enabled = False
        StartButton.Enabled = True
    End Sub

    Private Sub Check_Button()
        If StartButton.Enabled = False Then
            StopButton.Enabled = True
        End If
    End Sub
    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        AboutBox.Show()
    End Sub
End Class
