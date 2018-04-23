Imports DevExpress.Mvvm

Public Class MainViewModel
    Protected _Tasks As List(Of Task)
    Public ReadOnly Property Tasks() As List(Of Task)
        Get
            If Me._Tasks Is Nothing Then
                Me._Tasks = New List(Of Task)()
                Dim r As New Random()
                Dim i As Integer = 0
                While i < 10
                    Me._Tasks.Add(New Task() With {
                        .TaskName = "Task #" + i.ToString(),
                        .StartDate = DateTime.Today.AddDays(r.[Next](4)),
                        .EndDate = DateTime.Today.AddDays(r.[Next](10) + 4)
                    })
                    i = i + 1
                End While
            End If
            Return _Tasks
        End Get
    End Property
End Class

Public Class Task
    Inherits BindableBase

    Protected _TaskName As String
    Public Property TaskName() As String
        Get
            Return Me._TaskName
        End Get
        Set
            Me.SetProperty(Me._TaskName, Value, "TaskName")
        End Set
    End Property


    Protected _StartDate As DateTime
    Public Property StartDate() As DateTime
        Get
            Return Me._StartDate
        End Get
        Set
            Me.SetProperty(Me._StartDate, Value, "StartDate")
        End Set
    End Property


    Protected _EndDate As DateTime
    Public Property EndDate() As DateTime
        Get
            Return Me._EndDate
        End Get
        Set
            Me.SetProperty(Me._EndDate, Value, "EndDate")
        End Set
    End Property
End Class
