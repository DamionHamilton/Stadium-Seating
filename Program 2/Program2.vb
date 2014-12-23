'Damion Hamilton
'Program used to Calculate Stadium Revenue from Ticket/Seat sales


Public Class Program2

    'Button1 = Calculate revenue; reads data from user input within Textbox1,Textbox2 and Textbox3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim A As Double 'number of seats in class A
        Dim B As Double 'number of seats in class B
        Dim C As Double 'number of seats in class C
        Dim suma As Double 'total class A seats Mult. by Price of class A seats
        Dim sumb As Double 'total class B seats Mult. by Price of class B seats
        Dim sumc As Double 'total class C seats Mult. by Price of class C seats
        Dim acost As Integer 'Pre set cost for class A seats
        Dim bcost As Integer 'Pre set cost for class B seats
        Dim ccost As Integer 'Pre set cost for class C seats
        Dim tr As Integer 'Total Revenue, All seats combined into total amount made from all seats in stadium

        'All Textboxs have pre set seating prices as follows

        A = (TextBox1.Text)
        B = CDbl(TextBox2.Text)
        C = CDbl(TextBox3.Text)

        'Dollar amount: Example 15 = $15.00

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

    'Button2 = Clear all textboxes of all data

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()


    End Sub

    'Button3 = Exit button, also displays message

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("Have a great day")
        End
    End Sub

    'Button4 = Print page

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PrintForm1.Print()

    End Sub

    'Button5 = Print preview

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    'Button7 = Directions, Shows message box with directions on how to use program

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        MsgBox("Enter number of tickets sold" & ControlChars.NewLine & "click calculate to view revenue." & ControlChars.NewLine & "This Program is based on a Seat Pricing" & ControlChars.NewLine & "which is already calculated within the program." & ControlChars.NewLine & "Class: A   $15" & ControlChars.NewLine & "Class: B   $12" & ControlChars.NewLine & "Class: C   $9", MsgBoxStyle.Information, "Direction")


    End Sub

    ' Button6 = Gives purpose for program

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        MsgBox("The Purpose of this program is to calculate stadium revenue.")
    End Sub


End Class
