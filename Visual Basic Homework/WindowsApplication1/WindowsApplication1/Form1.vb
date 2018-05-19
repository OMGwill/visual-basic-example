'author: Will Luttmann

Public Class Form1
    Dim Num1 As Double          'declares an integer variable type Double
    Dim Num2 As Double          'declares an integer variable type Double



    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

        Num1 = TextBox2.Text            'sets num1 to text in textbox2
        TextBox4.Text = Num1 + Num2     'updates textbox4

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Button1.BackColor = Color.LightBlue         'changes button color
        TextBox1.Text = "You Clicked the button"    'updates textbox1

    End Sub


    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

        Num2 = TextBox3.Text            'sets num2 to text in textbox3
        TextBox4.Text = Num1 + Num2     'updates textbox4

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then

            PictureBox1.Image = My.Resources.confuseddog            'sets image to picture previously stored in resources
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage  'adjusts image size to picture box

        End If
    End Sub


    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        PictureBox1.Image = My.Resources.Kids_Show_2014
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ProgressBar1.Increment(13)      'increments progress bar by 13% on each click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim myform As New Form2     'creates new form object
        myform.Show()               'displays form

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected

        If MonthCalendar1.SelectionRange.Start = MonthCalendar1.SelectionRange.End Then     'if start date is the same as end date, 1 date is selected
            Label3.Text = "Date Selected: " + MonthCalendar1.SelectionStart                 'updates label3 with selection
        Else
            Label3.Text = "Dates selected from " + MonthCalendar1.SelectionRange.Start + " to" + MonthCalendar1.SelectionRange.End  'updates label3 with selection
        End If

    End Sub

End Class
