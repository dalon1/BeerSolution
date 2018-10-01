Public Class Log
    Public Property Msg As String
    Public Property Ex As Exception

    Public Sub New(ByVal _Msg As String, ByVal _Ex As Exception)
        Msg = _Msg
        Ex = _Ex
    End Sub

    Public Sub New(ByVal _Msg As String)
        ' Default
        Msg = _Msg

    End Sub

    Public Overrides Function ToString() As String
        Dim log As String = ""
        log += String.Format("{0}-{1}: {2}{3}", DateTime.Now.ToString("yyymmddHHmmssffffff"), If(Ex Is Nothing, "SUCCESS", "ERROR"), Msg, vbNewLine)
        If Ex IsNot Nothing Then
            log += String.Format("{0}Caused By: {1}{2}", vbTab, Ex.Message, vbNewLine)
        End If
        Return log
    End Function
End Class
