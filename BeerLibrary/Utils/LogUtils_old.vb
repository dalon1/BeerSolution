Module LogUtils_old
    Public Function GetLogErr(ByVal msg As String, ByVal ex As Exception) As String
        Dim log As String = ""
        log += String.Format("{0}-ERROR: {1}{2}", DateTime.Now.ToString("yyymmddHHmmssffffff"), msg, vbNewLine)
        log += String.Format("{0}Caused By: {1}{2}", vbTab, ex.Message, vbNewLine)
        Return log
    End Function

    Public Function GetLogSucc(ByVal msg As String) As String
        Dim log As String = ""
        log += String.Format("{0}-SUCCESS: {1}{2}", DateTime.Now.ToString("yyymmddHHmmssffffff"), msg, vbNewLine)
        Return log
    End Function
End Module
