Public Class Form1

    Dim FirstNum As Decimal
    Dim SecondNum As Decimal
    Dim Operations As Integer
    Dim Operator_Selector As Boolean = False

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' txtDisplay.Text = ""
    End Sub

    

    Private Sub cmd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd2.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "2"
        Else
            txtDisplay.Text = "2"

        End If

    End Sub

    Private Sub txt3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt3.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "3"
        Else
            txtDisplay.Text = "3"

        End If
    End Sub

    Private Sub txt4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt4.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "4"
        Else
            txtDisplay.Text = "4"

        End If
    End Sub

    Private Sub cmdC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdC.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text = "0"
        End If
    End Sub

    Private Sub cmd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click

        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "1"
        Else
            txtDisplay.Text = "1"

        End If
    End Sub

    Private Sub cmdOpSum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpSum.Click
        FirstNum = txtDisplay.Text
        txtDisplay.Text = "0"
        Operator_Selector = True
        Operations = 1  '=+

    End Sub

    Private Sub cmdOpMulti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpMulti.Click
        FirstNum = txtDisplay.Text
        txtDisplay.Text = "0"
        Operator_Selector = True
        Operations = 2  '=*

    End Sub

    Private Sub cmdEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnter.Click
        If Operator_Selector = True Then

            SecondNum = txtDisplay.Text
            If Operations = 1 Then
                txtDisplay.Text = FirstNum + SecondNum
            ElseIf Operations = 2 Then
                txtDisplay.Text = FirstNum * SecondNum
            End If
            Operator_Selector = False
        End If
    End Sub
End Class
