Public Class Program2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim A As Double
        Dim B As Double
        Dim C As Double
        Dim suma As Double
        Dim sumb As Double
        Dim sumc As Double
        Dim acost As Integer
        Dim bcost As Integer
        Dim ccost As Integer
        Dim tr As Integer


        A = (TextBox1.Text)
        B = CDbl(TextBox2.Text)
        C = CDbl(TextBox3.Text)
        acost = 15
        bcost = 12
        ccost = 9


        suma = A * acost
        sumb = B * bcost
        sumc = C * ccost
        tr = suma + sumb + sumc


        TextBox4.Text = Format(suma, "currency")
        TextBox5.Text = Format(sumb, "currency")
        TextBox6.Text = Format(sumc, "currency")
        TextBox7.Text = Format(tr, "currency")



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("Have a great day")
        End
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        printform1.print()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        MsgBox("Enter number of tickets sold" & ControlChars.NewLine & " then click calculate to view revenue.", MsgBoxStyle.Information, "Direction")


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        MsgBox("The Purpose of this program is to calculate stadium revenue.")
    End Sub


End Class
