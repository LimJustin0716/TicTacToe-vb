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
    Public Function disp_turn()
        If (Player = "X") Then
            Player = "O"
        ElseIf (Player = "O") Then
            Player = "X"
        End If

        turn_disp.Text = "Player: " + Player
        Return Player
    End Function

    Public Function PrintButtonText(ByVal btn As Button)
        If btn.Text = "" Then
            btn.Text = Player
            disp_turn()
        End If
        Return True
    End Function

    Private Sub top_left_Click(sender As Object, e As EventArgs) Handles top_left.Click
        PrintButtonText(top_left)
    End Sub

    Private Sub top_mid_Click(sender As Object, e As EventArgs) Handles top_mid.Click
        PrintButtonText(top_mid)
    End Sub

    Private Sub top_right_Click(sender As Object, e As EventArgs) Handles top_right.Click
        PrintButtonText(top_right)
    End Sub

    Private Sub mid_left_Click(sender As Object, e As EventArgs) Handles mid_left.Click
        PrintButtonText(mid_left)
    End Sub

    Private Sub mid_Click(sender As Object, e As EventArgs) Handles mid.Click
        PrintButtonText(mid)
    End Sub

    Private Sub mid_right_Click(sender As Object, e As EventArgs) Handles mid_right.Click
        PrintButtonText(mid_right)
    End Sub

    Private Sub bot_left_Click(sender As Object, e As EventArgs) Handles bot_left.Click
        PrintButtonText(bot_left)
    End Sub

    Private Sub bot_mid_Click(sender As Object, e As EventArgs) Handles bot_mid.Click
        PrintButtonText(bot_mid)
    End Sub

    Private Sub bot_right_Click(sender As Object, e As EventArgs) Handles bot_right.Click
        PrintButtonText(bot_right)
    End Sub
End Class
