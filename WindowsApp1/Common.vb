Module Common

    Public Sub ShowMessage(str As String)
        Try
            If Not str.Equals("") Then
                MsgBox(str)
            Else
                MsgBox("Nothing message !")
            End If
        Catch e As NullReferenceException
            MsgBox("Error ! Message is Null !")
        Catch ex As Exception

        End Try
    End Sub


End Module
