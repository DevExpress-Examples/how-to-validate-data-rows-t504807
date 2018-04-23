Public NotInheritable Class MainPage
    Inherits Page

    Private Sub GridControl_InvalidRowException(sender As Object, e As DevExpress.UI.Xaml.Grid.InvalidRowExceptionEventArgs)
        e.ErrorText = "StartDate must be less than EndDate." & vbCrLf & "Either StartDate or EndDate should be corrected."
    End Sub

    Private Sub GridControl_ValidateRow(sender As Object, e As DevExpress.UI.Xaml.Grid.Native.GridRowValidationEventArgs)
        Dim startDate As DateTime = (CType(e.Row, Task)).StartDate
        Dim endDate As DateTime = (CType(e.Row, Task)).EndDate
        e.IsValid = startDate < endDate
    End Sub
End Class
