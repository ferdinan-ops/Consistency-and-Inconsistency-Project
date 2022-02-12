Public Class Consistency

    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        Consistency_Game.Timer1.Enabled = False
        Consistency_Game.lbl_display.Text = 0
        Consistency_Game.lbl_time.Text = 0
        Consistency_Game.btdisplay.Hide()
        Consistency_Game.btoff.Hide()
        Consistency_Game.bton.Hide()
        Me.Hide()
        Consistency_Game.Show()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        End
    End Sub
End Class