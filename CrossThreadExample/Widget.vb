Imports System.ComponentModel
Imports System.Threading

Public Class Widget
    Implements INotifyPropertyChanged
    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged

    ''' <summary>
    ''' Set once in application, we need a reference to the UI Thread SynchronizationContext
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared UIThreadContext As SynchronizationContext
    Private _title As String
    Private _content As String
    Sub NotifyPropertyChangedInUIThread(propName As String)
        'Always notify on UI thread, because propertychange will cause UI controls to update, which is only allowed in UI thread
        UIThreadContext.Send(AddressOf NotifyPropertyChanged, propName)
    End Sub
    Sub NotifyPropertyChanged(propName As Object)
        NotifyPropertyChanged(propName.ToString())
    End Sub
    Sub NotifyPropertyChanged(propName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propName))
    End Sub
    Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
            NotifyPropertyChangedInUIThread("Title")
        End Set
    End Property

    Property Content As String
        Get
            Return _content
        End Get
        Set(value As String)
            _content = value
            NotifyPropertyChangedInUIThread("Text")
        End Set
    End Property

End Class
