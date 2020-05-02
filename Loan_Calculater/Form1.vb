Public Class Form1
    Private Sub bttnShowPayment_Click(ByVal sender As Object,
                                     ByVal e As System.EventArgs) Handles bttnShowPayment.Click
        Dim Payment As Double
        Dim LoanIRate As Double
        Dim LoanDuration As Integer
        Dim LoanAmount As Integer
        If IsNumeric(txtAmount.Text) Then
            LoanAmount = Convert.ToInt32(txtAmount.Text)
        Else
            MsgBox("Invalid amount, please re-enter")
            txtAmount.Focus()
            txtAmount.SelectAll()
            Exit Sub
        End If

        If IsNumeric(txtRate.Text) Then
            LoanIRate = 0.01 * Convert.ToDecimal(txtRate.Text) / 12
        Else
            MsgBox("Invalid amount, please re-enter")
            txtAmount.Focus()
            txtAmount.SelectAll()
            Exit Sub
        End If

        'If IsNumeric(txtDuration.Text) Then
        LoanDuration = DateDiff(DateInterval.Month, DTPick1.Value, DTPick2.Value)
        txtDuration.Text = LoanDuration.ToString
        'Else
        '    MsgBox("Invalid amount, please re-enter")
        '    txtAmount.Focus()
        '    txtAmount.SelectAll()
        '    Exit Sub
        'End If

        Dim payEarly As DueDate
        If chkPayEarly.Checked Then
            payEarly = DueDate.BegOfPeriod
        Else
            payEarly = DueDate.EndOfPeriod
        End If
        Payment = Pmt(LoanIRate, LoanDuration, -LoanAmount, 0, payEarly)
        txtPayment.Text = Payment.ToString("#.00")
    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged, txtRate.TextChanged
        txtPayment.Clear()
    End Sub

    Private Sub bttnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bttnExit.Click
        Me.Close()
    End Sub

End Class
