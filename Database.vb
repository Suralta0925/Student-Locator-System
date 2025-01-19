Imports System.Data.SQLite
Module Database
    Public BindSrc As BindingSource
    Public dbName As String = "info.db"
    Public dbPath As String = Application.StartupPath & "/" & dbName
    Public connString As String = "Data Source=" & dbPath & ";Version=3"

    Public connection As New SQLiteConnection(connString)
    Public command As New SQLiteCommand("", connection)
End Module
