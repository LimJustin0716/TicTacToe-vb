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
            result_checker()

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

    Public Function result_checker()
        If top_left.Text = top_mid.Text And top_mid.Text = top_right.Text Then
            win(top_left, top_mid, top_right)
        ElseIf top_left.Text = mid.Text And mid.Text = bot_right.Text Then
            win(top_left, mid, bot_right)
        ElseIf mid_left.Text = mid.Text And mid.Text = mid_right.Text Then
            win(mid_left, mid, mid_right)
        ElseIf bot_left.Text = bot_mid.Text And bot_mid.Text = bot_right.Text Then
            win(bot_left, bot_mid, bot_right)
        ElseIf top_left.Text = mid_left.Text And mid_left.Text = bot_left.Text Then
            win(top_left, mid_left, bot_left)
        ElseIf top_mid.Text = mid.Text And mid.Text = bot_mid.Text Then
            win(top_mid, mid, bot_mid)
        ElseIf top_right.Text = mid_right.Text And mid_right.Text = bot_right.Text Then
            win(top_right, mid_right, bot_right)
        ElseIf top_right.Text = mid.Text And mid.Text = bot_left.Text Then
            win(top_right, mid, bot_left)
        End If
    End Function
    Public Function win(ByVal Button1 As Button, ByVal Button2 As Button, ByVal Button3 As Button)
        If Button1.Text = "" Or Button2.Text = "" Or Button3.Text = "" Then
        Else
            MessageBox.Show(Button1.Text.ToString + " is the Winner")
        End If

    End Function
End Class
