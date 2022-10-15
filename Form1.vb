Public Class Form1
    Public x, y, mem As Single
    Public sign As String

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If x <> 0 And Label1.Text <> "" Then
            y = Label1.Text
            If sign = "plus" Then
                x = x + y
            ElseIf sign = "minus" Then
                x = x - y
            ElseIf sign = "multy" Then
                x = x * y
            ElseIf sign = "division" Then
                If y = 0 Then
                    Label1.Text = "Ошибка"
                    Return
                End If
                x = x / y
            ElseIf sign = "x^y" Then
                x = x ^ y
            End If

            Label1.Text = x
        End If
    End Sub
    'AC'
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        x = 0
        y = 0
        Label1.Text = ""
    End Sub
    '+'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Label1.Text <> "" Then
            sign = "plus"
            x = Label1.Text
            Label1.Text = ""
        End If
    End Sub
    '-'
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If Label1.Text <> "" Then
            sign = "minus"
            x = Label1.Text
            Label1.Text = ""
        End If
    End Sub
    '*'
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If Label1.Text <> "" Then
            sign = "multy"
            x = Label1.Text
            Label1.Text = ""
        End If
    End Sub
    '/'
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If Label1.Text <> "" Then
            sign = "division"
            x = Label1.Text
            Label1.Text = ""
        End If
    End Sub
    'x^2'
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If Label1.Text <> "" Then
            sign = "square"
            x = Label1.Text
            x = x ^ 2
            Label1.Text = x
        End If
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If Label1.Text <> "" Then
            Label1.Text = Label1.Text + ","
        End If
    End Sub
    'sqrt'
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If Label1.Text <> "" Then
            sign = "sqrt"
            x = Label1.Text
            x = x ^ (1 / 2)
            Label1.Text = x
        End If
    End Sub
    'cbrt'
    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        If Label1.Text <> "" Then
            sign = "cbrt"
            x = Label1.Text
            x = x ^ (1 / 3)
            Label1.Text = x
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text &= sender.Text
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text &= sender.Text
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Label1.Text &= sender.Text
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Label1.Text &= sender.Text
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Label1.Text &= sender.Text
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Label1.Text &= sender.Text
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Label1.Text &= sender.Text
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Label1.Text &= sender.Text
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label1.Text &= sender.Text
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label1.Text &= sender.Text
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 332
        Label1.Width = 298
        GroupBox2.Visible = False
    End Sub
    'mc'
    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        mem = 0
    End Sub
    'm+'
    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        mem = mem + Label1.Text
    End Sub
    'm-'
    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        mem = mem - Label1.Text
    End Sub
    'mr'
    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Label1.Text = mem
    End Sub
    'ms'
    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        mem = Label1.Text
    End Sub
    '|x|'
    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        x = Label1.Text
        If x < 0 Then
            Label1.Text = x * (-1)
        End If
        'Label1.Text = Math.Abs(Label1.Text)'
    End Sub
    '+/-'
    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        If Label1.Text <> "" Then
            sign = "plus-minus"
            x = Label1.Text
            x = x * (-1)
            Label1.Text = x
        End If
    End Sub
    '1/x'
    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        If Label1.Text <> "" Then
            x = Label1.Text
            Label1.Text = 1 / x
        End If
    End Sub
    'factorial !'
    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click

    End Sub
    '10^x'
    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        If Label1.Text <> "" Then
            x = Label1.Text
            Label1.Text = 10 ^ x
        End If

    End Sub
    'x^y'
    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        If Label1.Text <> "" Then
            sign = "x^y"
            x = Label1.Text
            Label1.Text = ""
        End If
    End Sub
    'log10'
    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If Label1.Text <> "" Then
            x = Label1.Text
            Label1.Text = Math.Log10(x)
        End If
    End Sub
    'log(e)'
    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        If Label1.Text <> "" Then
            x = Label1.Text
            Label1.Text = Math.Log(x)
        End If

    End Sub
    'sin'
    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        If Label1.Text <> "" Then
            x = Label1.Text
            Label1.Text = Math.Round(Math.Sin(x), 2)
        End If
    End Sub
    'cos'
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If Label1.Text <> "" Then
            x = Label1.Text
            Label1.Text = Math.Round(Math.Cos(x), 2)
        End If
    End Sub
    'tan'
    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If Label1.Text <> "" Then
            x = Label1.Text
            Label1.Text = Math.Round(Math.Tan(x), 2)
        End If
    End Sub

    'Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs)
    'If TrackBar1.Value = 9 Then
    'Me.Opacity = 1
    'Else
    'Me.Opacity = "0," + Convert.ToString(TrackBar1.Value)
    'Me.Text = TrackBar1.Value
    'Label1.Text = Me.Opacity
    'End I
    'End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        If GroupBox2.Visible = False Then
            Me.Width = 638
            Label1.Width = 602
            GroupBox2.Visible = True
        Else
            Me.Width = 332
            Label1.Width = 298
            GroupBox2.Visible = False
        End If
    End Sub

End Class
