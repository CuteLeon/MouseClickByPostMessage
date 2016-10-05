Public Class Form1
    Private Declare Function PostMessage Lib "user32" Alias "PostMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Private Const WM_LBUTTONDOWN = &H201
    Private Const WM_LBUTTONUP = &H202

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        PostMessage(Button2.Handle, WM_LBUTTONDOWN, 0, 0)
    End Sub

    Private Sub Button1_MouseUp(sender As Object, e As MouseEventArgs) Handles Button1.MouseUp
        PostMessage(Button2.Handle, WM_LBUTTONUP, 0, 0)
    End Sub

    Private Sub Button2_MouseDown(sender As Object, e As MouseEventArgs) Handles Button2.MouseDown
        Me.Text = "按钮2接收到鼠标按下消息"
    End Sub

    Private Sub Button2_MouseUp(sender As Object, e As MouseEventArgs) Handles Button2.MouseUp
        Me.Text = "按钮2接收到鼠标抬起消息"
    End Sub

End Class
