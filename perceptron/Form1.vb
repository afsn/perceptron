Public Class Form1
    
    Private Sub entrenar_Click(sender As System.Object, e As System.EventArgs) Handles entrenar.Click
        vbias = Convert.ToDouble(biasinicial.Text)
        vw1 = Convert.ToDouble(w1inicial.Text)
        vw2 = Convert.ToDouble(w2inicial.Text)
        vniu = Convert.ToDouble(niuinicial.Text)

        vx1 = Convert.ToInt32(x1.Text)
        vx2 = Convert.ToInt32(x2.Text)
        vyd = Convert.ToInt32(yd.Text)

        vu = vx1 * vw1 + vx2 * vw2 + vbias

        If vu < 0 Then
            vy = 0
        Else
            vy = 1
        End If

        ve = vyd - vy
        While ve <> 0
            traine()
        End While
        y.Text = vy
        bias.Text = vbias
        w1.Text = vw1
        w2.Text = vw2
        u.Text = vu
    End Sub

    Public Sub traine()
        incw1 = incw1 + vniu * ve * vx1
        incw2 = incw2 + vniu * ve * vx2
        incbias = incbias + vniu * ve

        vw1 = vw1 + incw1
        vw2 = vw2 + incw2
        vbias = vbias + incbias

        vu = vx1 * vw1 + vx2 * vw2 + vbias

        If vu < 0 Then
            vy = 0
        Else
            vy = 1
        End If

        ve = vyd - vy
    End Sub
End Class
