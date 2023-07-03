Public Class Form1
    Private Sub Btn_addgrp_Click(sender As Object, e As EventArgs) Handles Btn_addgrp.Click
        'Declaring array for group name, 2 judge marks and average marks
        Dim grpname(4) As String
        Dim gpmark(4, 1) As Integer
        Dim avgmark(4) As Double

        For index = 0 To 4
            Dim grpname1 As String = InputBox("Enter group name")
            grpname(index) = grpname1

            For indexMark = 0 To 1
                Dim mark As Integer = InputBox("Enter Judge Mark" & (indexMark + 1))
                gpmark(index, indexMark) = mark
            Next indexMark

            Dim avg As Double = (gpmark(index, 0) + gpmark(index, 1)) / 2
            avgmark(index) = avg
        Next index

        Dim highestmarkIndex As Integer = 0 ' Changed to Integer type
        Dim highestmark As String = grpname(0)

        For indexavg = 1 To 4 ' Start from index 1
            If avgmark(indexavg) > avgmark(highestmarkIndex) Then
                highestmarkIndex = indexavg
                highestmark = grpname(indexavg)
            End If
        Next indexavg

        For i = 0 To 4
            LstGroup.Items.Add(i + 1 & ".)" & grpname(i))

            For j = 0 To 1
                LstGroup.Items.Add("Judge " & (j + 1) & " Mark: " & gpmark(i, j))
            Next j

            LstGroup.Items.Add("Average Mark: " & avgmark(i))
            LstGroup.Items.Add("")
        Next i

        Dim winner As String = grpname(highestmarkIndex)
        lblwinner.Text = "The winner is " & winner & " with an average mark of " & avgmark(highestmarkIndex)
    End Sub

    Private Sub Btn_reset_Click(sender As Object, e As EventArgs) Handles Btn_reset.Click
        'reset the winner and listbox
        lblwinner.Text = ""
        LstGroup.Items.Clear()
    End Sub
End Class
