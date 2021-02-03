Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Global_ID
    Dim conn As MySqlConnection
    Public Shared userID As Integer
    Public Shared Function validation_allspecial(ByVal str_text As String) As Boolean
        For i As Integer = 0 To str_text.Length - 1

            If str_text(i) = "?" Or str_text(i) = "." Or str_text(i) = "!" Or str_text(i) = "*" Or str_text(i) = "/" Or str_text(i) = "-" Or str_text(i) = "+" Or str_text(i) = "\" Or str_text(i) = " " Or str_text(i) = "^" Or str_text(i) = "@" Or str_text(i) = "~" Or str_text(i) = "`" Or str_text(i) = "#" Or str_text(i) = "$" Or str_text(i) = "%" Or str_text(i) = "(" Or str_text(i) = ")" Or str_text(i) = "'" Or str_text(i) = "|" Or str_text(i) = "_" Or str_text(i) = "." Or str_text(i) = "<" Or str_text(i) = ">" Or str_text(i) = ":" Or str_text(i) = ";" Or str_text(i) = "[" Or str_text(i) = "]" Or str_text(i) = "{" Or str_text(i) = "}" Then
                Return False
            End If
        Next
        Return True
    End Function
    Public Shared Function validation_LONG_TEXT(ByVal str_text As String) As Boolean
        For i As Integer = 0 To str_text.Length - 1

            If str_text(i) = "?" Or str_text(i) = "!" Or str_text(i) = "*" Or str_text(i) = "/" Or str_text(i) = "+" Or str_text(i) = "\" Or str_text(i) = "^" Or str_text(i) = "@" Or str_text(i) = "~" Or str_text(i) = "`" Or str_text(i) = "#" Or str_text(i) = "$" Or str_text(i) = "%" Or str_text(i) = "|" Or str_text(i) = "<" Or str_text(i) = ">" Or str_text(i) = ";" Or str_text(i) = "[" Or str_text(i) = "]" Or str_text(i) = "{" Or str_text(i) = "}" Then
                Return False
            End If
        Next
        Return True
    End Function
    Public Shared Function validation_Email(ByVal str_text As String) As Boolean
        Dim counter = 0
        For i As Integer = 0 To str_text.Length - 1

            If str_text(i) = "?" Or str_text(i) = "!" Or str_text(i) = "*" Or str_text(i) = "/" Or str_text(i) = "+" Or str_text(i) = "\" Or str_text(i) = "^" Or str_text(i) = "~" Or str_text(i) = "`" Or str_text(i) = "#" Or str_text(i) = "$" Or str_text(i) = "%" Or str_text(i) = "|" Or str_text(i) = "<" Or str_text(i) = ">" Or str_text(i) = ";" Or str_text(i) = "[" Or str_text(i) = "]" Or str_text(i) = "{" Or str_text(i) = "}" Then
                Return False
            End If
        Next
        For x As Integer = 0 To str_text.Length - 1
            If str_text(x) = "@" Then
                counter = counter + 1
            End If
        Next
        If counter = 1 Then
            Return True
        Else
            Return False
        End If
        Return True
    End Function
    Public Shared Function validation_names(ByVal str_text As String) As Boolean
        For i As Integer = 0 To str_text.Length - 1

            If str_text(i) = "?" Or str_text(i) = "." Or str_text(i) = "!" Or str_text(i) = "*" Or str_text(i) = "/" Or str_text(i) = "-" Or str_text(i) = "+" Or str_text(i) = "\" Or str_text(i) = "^" Or str_text(i) = "@" Or str_text(i) = "~" Or str_text(i) = "`" Or str_text(i) = "#" Or str_text(i) = "$" Or str_text(i) = "%" Or str_text(i) = "(" Or str_text(i) = ")" Or str_text(i) = "'" Or str_text(i) = "|" Or str_text(i) = "_" Or str_text(i) = "." Or str_text(i) = "<" Or str_text(i) = ">" Or str_text(i) = ":" Or str_text(i) = ";" Or str_text(i) = "[" Or str_text(i) = "]" Or str_text(i) = "{" Or str_text(i) = "}" Or str_text(i) = "1" Or str_text(i) = "2" Or str_text(i) = "3" Or str_text(i) = "4" Or str_text(i) = "4" Or str_text(i) = "5" Or str_text(i) = "6" Or str_text(i) = "7" Or str_text(i) = "8" Or str_text(i) = "9" Or str_text(i) = "0" Then
                Return False
            End If
        Next
        Return True
    End Function
End Class
