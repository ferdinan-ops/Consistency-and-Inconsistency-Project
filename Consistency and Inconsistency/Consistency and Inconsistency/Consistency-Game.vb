Public Class Consistency_Game
    Dim w As Integer
    Dim nilai_on As Integer
    Dim banyak_konsisten As Integer = 0
    Dim banyak_incon As Integer = 0
    Dim jumlah(6) As Integer
    Dim main As Double
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Timer1.Start()
        lbl_time.Text = Val(lbl_time.Text) + 1
    End Sub
    Sub display()
        If lbl_display.Text = 1 Or lbl_display.Text = 5 Or lbl_display.Text = 9 Then
            btdisplay.BaseColor = Color.LimeGreen
            btdisplay.OnHoverBaseColor = Color.LimeGreen
            btdisplay.Text = "Start"
        ElseIf lbl_display.Text = 2 Or lbl_display.Text = 6 Or lbl_display.Text = 10 Then
            btdisplay.BaseColor = Color.Red
            btdisplay.OnHoverBaseColor = Color.Red
            btdisplay.Text = "Stop"
        ElseIf lbl_display.Text = 3 Or lbl_display.Text = 7 Then
            btdisplay.BaseColor = Color.LimeGreen
            btdisplay.OnHoverBaseColor = Color.LimeGreen
            btdisplay.Text = "Stop"
        ElseIf lbl_display.Text = 4 Or lbl_display.Text = 8 Then
            btdisplay.BaseColor = Color.Red
            btdisplay.OnHoverBaseColor = Color.Red
            btdisplay.Text = "Start"
        End If
    End Sub
    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        lbl_display.Text = "1"
        Timer1.Enabled = True
        btdisplay.Show()
        btoff.Show()
        bton.Show()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Start()
        w = 1300
        If greencar.Left < w Then
            greencar.Left += 10
        Else
            greencar.Left = -300
        End If
    End Sub

    Private Sub bton_Click(sender As Object, e As EventArgs) Handles bton.Click
        If lbl_display.Text = 1 Or lbl_display.Text = 5 Or lbl_display.Text = 9 Then
            btoff.Enabled = False
            TimerON.Enabled = True
            Timer2.Enabled = True
        ElseIf lbl_display.Text = 2 Or lbl_display.Text = 6 Or lbl_display.Text = 10 Then
            TimerON.Enabled = False
            banyak_konsisten += 1
            Consistency_Hasil.lbl_banyak_konsisten.Text = banyak_konsisten
            Consistency_Hasil.waktu_konsis.Text = Val(lbl_time.Text)
        ElseIf lbl_display.Text = 3 Or lbl_display.Text = 7 Or lbl_display.Text = 4 Or lbl_display.Text = 8 Then
            TimerON.Enabled = False
            banyak_incon += 1
            Consistency_Hasil.lbl_banyak_incon.Text = banyak_incon
            Consistency_Hasil.waktu_incon.Text = Val(lbl_time.Text)
        End If
    End Sub

    Private Sub btoff_Click(sender As Object, e As EventArgs) Handles btoff.Click
        If lbl_display.Text = 2 Or lbl_display.Text = 6 Then
            bton.Enabled = False
            TimerOFF.Enabled = True
            Timer2.Enabled = False
        ElseIf lbl_display.Text = 1 Or lbl_display.Text = 5 Or lbl_display.Text = 9 Then
            TimerOFF.Enabled = True
            banyak_konsisten += 1
            Consistency_Hasil.lbl_banyak_konsisten.Text = banyak_konsisten
            Consistency_Hasil.waktu_konsis.Text = Val(lbl_time.Text)
        ElseIf lbl_display.Text = 3 Or lbl_display.Text = 7 Or lbl_display.Text = 4 Or lbl_display.Text = 8 Then
            TimerOFF.Enabled = True
            banyak_incon += 1
            Consistency_Hasil.lbl_banyak_incon.Text = banyak_incon
            Consistency_Hasil.waktu_incon.Text = Val(lbl_time.Text)
        ElseIf lbl_display.Text = 10 Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            Timer4.Enabled = False
            TimerON.Enabled = False
            TimerOFF.Enabled = False
            Dim tanya
            tanya = MessageBox.Show("Anda Telah Menyelesaikan Permainan. Ingin Melihat Hasil ??", "Selamat !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If tanya = vbYes Then
                Me.Hide()
                Consistency_Hasil.Show()
            Else
                Timer1.Enabled = False
                lbl_display.Text = 0
                lbl_time.Text = 0
                btdisplay.Hide()
                btoff.Hide()
                bton.Hide()
            End If
            
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3.Start()
        Timer3.Interval = 1000
        If lbl_waktutunggu.Text < 5 Then
            lbl_waktutunggu.Text = Val(lbl_waktutunggu.Text) + 1
        Else
            Timer3.Enabled = False
            lbl_display.Text += 1
            Call display()
            Timer4.Enabled = True
            lbl_waktutunggu.Text = 0
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer4.Start()
        Timer4.Interval = 1000
        If lbl_waktutunggu.Text < 5 Then
            lbl_waktutunggu.Text = Val(lbl_waktutunggu.Text) + 1
        Else
            Timer4.Enabled = False
            lbl_display.Text += 1
            Call display()
            lbl_waktutunggu.Text = 0
        End If
    End Sub

    Private Sub TimerON_Tick(sender As Object, e As EventArgs) Handles TimerON.Tick
        TimerON.Start()
        TimerON.Interval = 1000
        If lbl_waktutunggu.Text < 5 Then
            lbl_waktutunggu.Text = Val(lbl_waktutunggu.Text) + 1
        Else
            TimerON.Enabled = False
            lbl_display.Text += 1
            Call display()
            btoff.Enabled = True
            lbl_waktutunggu.Text = 0
        End If
    End Sub

    Private Sub TimerOFF_Tick(sender As Object, e As EventArgs) Handles TimerOFF.Tick
        TimerOFF.Start()
        TimerOFF.Interval = 1000
        If lbl_waktutunggu.Text < 5 Then
            lbl_waktutunggu.Text = Val(lbl_waktutunggu.Text) + 1
        Else
            TimerOFF.Enabled = False
            lbl_display.Text += 1
            Call display()
            bton.Enabled = True
            lbl_waktutunggu.Text = 0
            Timer3.Enabled = True
        End If
    End Sub

    Private Sub Consistency_Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btdisplay.Hide()
        btoff.Hide()
        bton.Hide()
    End Sub

    Private Sub GunaTransfarantPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaTransfarantPictureBox1.Click
        Consistency___Petunjuk.Show()

    End Sub
End Class