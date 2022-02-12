Public Class Consistency_Hasil

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Me.Hide()
        Consistency.Show()
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Consistency_Game.Timer1.Enabled = False
        Consistency_Game.lbl_display.Text = 0
        Consistency_Game.lbl_time.Text = 0
        Consistency_Game.btdisplay.Hide()
        Consistency_Game.btoff.Hide()
        Consistency_Game.bton.Hide()
        Me.Hide()
        Consistency_Game.Show()
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        End
    End Sub
End Class