Public Class Form1
    Dim Player As Char = "X"

    Private Sub restart_btn_Click(sender As Object, e As EventArgs) Handles restart_btn.Click
        Reset()
        disp_turn()
    End Sub
    Public Function Reset()
        top_left.Text = ""
        top_mid.Text = ""
        top_right.Text = ""
        mid_left.Text = ""
        mid.Text = ""
        mid_right.Text = ""
        bot_left.Text = ""
        bot_mid.Text = ""
        bot_right.Text = ""
        Return True
    End Function
    Public Function disp_Turn()
        If (Player = "X") Then
            Player = "O"
        ElseIf (Player = "O") Then
            Player = "X"
        End If

        turn_disp.Text = "Player: " + Player
        Return Player
    End Function
End Class
