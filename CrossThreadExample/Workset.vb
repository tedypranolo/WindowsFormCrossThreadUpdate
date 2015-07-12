''' <summary>
''' Argument Class for Background worker
''' </summary>
''' <remarks></remarks>
Public Class Workset
    Public Enum Actions
        Add
        Update
    End Enum

    ''' <summary>
    ''' Widget to be updated (Actions.Update), or the result of creating new widget (Actions.Add)
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property Widget As Widget
    Property Action As Actions
End Class
