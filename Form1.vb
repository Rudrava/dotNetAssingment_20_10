Public Class Form1
    Dim inpBuffer As Integer
    Dim arrIndex As Integer
    Dim arr(5) As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        arrIndex = -1
    End Sub

    Private Sub add1d()
        If IsNumeric(Input.Text) Then

            inpBuffer = Convert.ToInt64(Input.Text)

            If arrIndex = 5 Then
                AddElementButton.Enabled = False
                Input.Clear()
                ArrayExceedErr.Visible = True
                Input.Enabled = False


            Else
                ArrEmptyErr.Visible = False
                ArrayExceedErr.Visible = False
                arrIndex += 1
                arr(arrIndex) = inpBuffer

                Input.Focus()
                Input.Clear()
                ArrayOutput.Items.Add(arr(arrIndex))
            End If

        Else
            MsgBox("Enter Numeric values only please !!!", MsgBoxStyle.Information)
            Input.Clear()

        End If
    End Sub

    Private Sub AddElementButton_Click(sender As Object, e As EventArgs) Handles AddElementButton.Click
        add1d()
    End Sub

    Private Sub SortTrueButton_Click(sender As Object, e As EventArgs) Handles SortTrueButton.Click
        If arrIndex = -1 Then
            ArrEmptyErr.Visible = True
        End If

        ArrayOutput.Sorted = True

    End Sub
End Class
