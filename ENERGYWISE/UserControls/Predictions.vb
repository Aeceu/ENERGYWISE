Public Class Predictions
    Public Sub New()
        InitializeComponent()

        Dim Yearly As Double = Math.Round((Usage.total_kwh * 11.3168) * 365, 2)
        Dim Monthly As Double = Math.Round((Usage.total_kwh * 11.3168) * 30, 2)
        Dim Daily As Double = Math.Round(Usage.total_kwh * 11.3168, 2)

        Label2.Text = "₱ " + Monthly.ToString()
        Label5.Text = "₱ " + Daily.ToString()
        Label7.Text = "₱ " + Yearly.ToString()



    End Sub

End Class
