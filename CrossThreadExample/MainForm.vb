Imports System.ComponentModel
Imports System.Threading

Public Class MainForm
    Private WithEvents BackgroundWorker As New BackgroundWorker

    Private Widgets As New BindingList(Of Widget)


    Sub New()


        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'Set the static UIThreadContext, the current thread is the UI Thread 
        Widget.UIThreadContext = SynchronizationContext.Current
        MainBindingSource.DataSource = Widgets
        MainListBox.DisplayMember = "Title"
        TestLabel.DataBindings.Add("Text", MainBindingSource, "Title")
        TestRichTextBox.DataBindings.Add("Text", MainBindingSource, "Content")
    End Sub

    Private Sub StartBackgroundWork(workset As Workset)
        BackgroundWorker.RunWorkerAsync(workset)
    End Sub

    Private Sub BackgroundWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker.DoWork
        Dim workset = TryCast(e.Argument, Workset)
        Select Case workset.Action
            Case workset.Actions.Add
                Dim w = New Widget
                w.Title = "New"
                w.Content = "New widget"
                workset.Widget = w
            Case workset.Actions.Update
                workset.Widget.Title = "Updated widget"
                workset.Widget.Content = String.Format("Updated on {0}", Now)
        End Select
        e.Result = workset
    End Sub

    Private Sub BackgroundWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted
        Dim workset = TryCast(e.Result, Workset)
        Select Case workset.Action
            Case workset.Actions.Add
                Widgets.Add(workset.Widget)
        End Select
    End Sub
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        StartBackgroundWork(New Workset With {.Action = Workset.Actions.Add})
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        StartBackgroundWork(New Workset() With
                                {.Action = Workset.Actions.Update,
                                 .Widget = TryCast(MainBindingSource.Current, Widget)})
    End Sub
End Class
