Public Class Form1

    Private dblResultado As Double = 0
    Private dblNumero As Double = 0
    Private strOperador As String = String.Empty
    Private blnLimpa As Boolean = True
    Private blnDecimal As Boolean = False
    Private strNumero As String = "1"

    Private blnOperador As Boolean = False

    Private Sub btnDivisao_Click(sender As Object, e As EventArgs) Handles btnDivisao.Click

        If strNumero = "1" And blnOperador = True Then
            dblResultado = Convert.ToDouble(TextBox1.Text)
        ElseIf strNumero = "2" And blnOperador = True Then
            dblResultado = Convert.ToDouble(TextBox1.Text)
            dblResultado = dblResultado / dblNumero
            TextBox1.Text = dblNumero
            dblNumero = 0
        End If
        strOperador = "/"
        blnLimpa = True
        blnDecimal = False
        blnOperador = False
    End Sub

    Private Sub limpar_Click(sender As Object, e As EventArgs) Handles limpar.Click
        dblNumero = 0
        dblResultado = 0
        strOperador = String.Empty
        TextBox1.Text = "0"
        blnLimpa = True
    End Sub

    Private Sub Multiplicacao_Click(sender As Object, e As EventArgs) Handles Multiplicacao.Click
        If strNumero = "1" And blnOperador = True Then
            dblResultado = Convert.ToDouble(TextBox1.Text)


        ElseIf strNumero = "2" And blnOperador = True Then
            dblResultado = Convert.ToDouble(TextBox1.Text)
            dblResultado = dblResultado * dblNumero
            TextBox1.Text = dblNumero
            dblNumero = 0
        End If
        strOperador = "*"
        blnLimpa = True
        blnDecimal = False
        blnOperador = False
    End Sub

    Private Sub Num1_Click(sender As Object, e As EventArgs) Handles Num1.Click
        If blnLimpa = True Then
            TextBox1.Text = "1"
            blnLimpa = False


        Else
            TextBox1.Text = TextBox1.Text & "1"
        End If
        blnOperador = True
    End Sub

    Private Sub Num0_Click(sender As Object, e As EventArgs) Handles Num0.Click
        If blnLimpa = True Then
            TextBox1.Text = "0"
            blnLimpa = False



        Else
            TextBox1.Text = TextBox1.Text & "0"
        End If
        blnOperador = True
    End Sub

    Private Sub Num2_Click(sender As Object, e As EventArgs) Handles Num2.Click
        If blnLimpa = True Then
            TextBox1.Text = "2"
            blnLimpa = False


        Else
            TextBox1.Text = TextBox1.Text & "2"
        End If
        blnOperador = True

    End Sub

    Private Sub Num3_Click(sender As Object, e As EventArgs) Handles Num3.Click
        If blnLimpa = True Then
            TextBox1.Text = "3"
            blnLimpa = False



        Else
            TextBox1.Text = TextBox1.Text & "3"
        End If
        blnOperador = True
    End Sub

    Private Sub Num4_Click(sender As Object, e As EventArgs) Handles Num4.Click
        If blnLimpa = True Then
            TextBox1.Text = "4"
            blnLimpa = False



        Else
            TextBox1.Text = TextBox1.Text & "4"
        End If
        blnOperador = True
    End Sub

    Private Sub Num5_Click(sender As Object, e As EventArgs) Handles Num5.Click
        If blnLimpa = True Then
            TextBox1.Text = "5"
            blnLimpa = False


        Else
            TextBox1.Text = TextBox1.Text & "5"
        End If
        blnOperador = True
    End Sub

    Private Sub Num6_Click(sender As Object, e As EventArgs) Handles Num6.Click
        If blnLimpa = True Then
            TextBox1.Text = "6"
            blnLimpa = False


        Else
            TextBox1.Text = TextBox1.Text & "6"
        End If
        blnOperador = True
    End Sub

    Private Sub Num7_Click(sender As Object, e As EventArgs) Handles Num7.Click
        If blnLimpa = True Then
            TextBox1.Text = "7"
            blnLimpa = False


        Else
            TextBox1.Text = TextBox1.Text & "7"
        End If
        blnOperador = True
    End Sub

    Private Sub Num8_Click(sender As Object, e As EventArgs) Handles Num8.Click
        If blnLimpa = True Then
            TextBox1.Text = "8"
            blnLimpa = False


        Else
            TextBox1.Text = TextBox1.Text & "8"
        End If
        blnOperador = True
    End Sub

    Private Sub Num9_Click(sender As Object, e As EventArgs) Handles Num9.Click
        If blnLimpa = True Then
            TextBox1.Text = "9"
            blnLimpa = False


        Else
            TextBox1.Text = TextBox1.Text & "9"
        End If
        blnOperador = True
    End Sub

    Private Sub Soma_Click(sender As Object, e As EventArgs) Handles Soma.Click
        If strNumero = "1" And blnOperador = True Then
            dblResultado = Convert.ToDouble(TextBox1.Text)

        ElseIf strNumero = "2" And blnOperador = True Then
            dblResultado = Convert.ToDouble(TextBox1.Text)
            dblResultado = dblResultado + dblNumero
            TextBox1.Text = dblNumero
            dblNumero = 0
        End If
        strOperador = "+"
        blnLimpa = True
        blnDecimal = False
        blnOperador = False
    End Sub

    Private Sub menos_Click(sender As Object, e As EventArgs) Handles menos.Click


        If strNumero = "1" And blnOperador = True Then


            dblResultado = Convert.ToDouble(TextBox1.Text)

        ElseIf strNumero = "2" And blnOperador = True Then
            dblResultado = Convert.ToDouble(TextBox1.Text)
            dblResultado = dblResultado - dblNumero
            TextBox1.Text = dblNumero
            dblNumero = 0
        End If
        strOperador = "-"
        blnLimpa = True
        blnDecimal = False
        blnOperador = False
    End Sub

    Private Sub virgula_Click(sender As Object, e As EventArgs) Handles virgula.Click
        If blnDecimal = False Then
            TextBox1.Text = TextBox1.Text & "."
            blnDecimal = True
        End If
    End Sub

    Private Sub Resultado_Click(sender As Object, e As EventArgs) Handles Resultado.Click
        If strOperador = "+" And dblNumero = 0 Then
            dblResultado = dblResultado + Convert.ToDouble(TextBox1.Text)
        ElseIf strOperador = "-" And dblNumero = 0 Then
            dblResultado = dblResultado - Convert.ToDouble(TextBox1.Text)
        ElseIf strOperador = "*" And dblNumero = 0 Then
            dblResultado = dblResultado * Convert.ToDouble(TextBox1.Text)
        ElseIf strOperador = "/" And dblNumero = 0 Then
            dblResultado = dblResultado / Convert.ToDouble(TextBox1.Text)
        End If
        TextBox1.Text = dblResultado
        blnLimpa = True
        blnOperador = False
    End Sub
End Class
