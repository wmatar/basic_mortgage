
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub PerformCalcButton_Click(sender As Object, e As EventArgs) Handles PerformCalcButton.Click
        'Specify constant values
        Const INTEREST_CALCS_PER_YEAR As Integer = 12
        Const PAYMENTS_PER_YEAR As Integer = 12

        'creat variables to hold the values entered by the user
        Dim p As Decimal = LoanAmount.Text
        Dim r As Decimal = Rate.Text / 100
        Dim t As Decimal = MortgageLength.Text

        Dim ratePerPeriod As Decimal
        ratePerPeriod = r / INTEREST_CALCS_PER_YEAR
        Dim payPeriods = t * PAYMENTS_PER_YEAR

        Dim annualRate As Decimal
        annualRate = Math.Exp(INTEREST_CALCS_PER_YEAR * Math.Log(1 + ratePerPeriod)) - 1
        Dim intPerPeriod As Decimal
        intPerPeriod = (Math.Exp(Math.Log(annualRate + 1) / payPeriods) - 1) * payPeriods

        'Now compute the total cost of the loan
        Dim intpermonth As Decimal = intPerPeriod / PAYMENTS_PER_YEAR

        Dim costpermonth As Decimal
        costpermonth = P * intpermonth / (1 - Math.Pow(intpermonth + 1, -payPeriods))

        'display the results in the results label web control
        Results.Text = "your mortgage is $" & costpermonth.ToString("#,####.##")

    End Sub
End Class
