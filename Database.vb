Imports System.Data.SQLite
Module Database
    Public BindSrc As BindingSource
    Public dbName As String = "info.db"
    Public dbPath As String = Application.StartupPath & "/" & dbName
    Public connString As String = "Data Source=" & dbPath & ";Version=3"

    Public connection As New SQLiteConnection(connString)
    Public command As New SQLiteCommand("", connection)
    Public ReadOnly Storedusername As String = ""

    Public ReadOnly Property DBUsername(username As String, password As String) As Boolean
        Get
            connection.Open()
            If connection.State = ConnectionState.Open And Not String.IsNullOrEmpty(LoginForm.username.Text) And Not String.IsNullOrEmpty(LoginForm.password.Text) Then
                command.Connection = connection
                command.CommandText = "SELECT username, password FROM Users"
                Dim rdr As SQLiteDataReader = command.ExecuteReader
                Using rdr
                    While rdr.Read()
                        Dim foundUsername As String = rdr("username").ToString.Trim
                        Dim foundPassword As String = rdr("password").ToString.Trim
                        username = foundUsername
                        If foundUsername = username.Trim And foundPassword = password.Trim Then
                            connection.Close()
                            Return True
                        End If
                    End While
                End Using
            End If
            connection.Close()
            Return False
        End Get
        'Set(value As String)
        '    'TODO'
        'End Set
    End Property
    Public ReadOnly Property isUserValid(username As String, password As String) As Boolean
        Get
            connection.Open()
            command.CommandText = "SELECT COUNT(*) FROM Users WHERE username = @username"
            command.Parameters.AddWithValue("@username", username)

            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
            MessageBox.Show(count)
            If count = 0 And Not LoginForm.isLeft Then
                ' Username does not exist, insert new record
                command.CommandText = "INSERT INTO Users (username, password) VALUES (@username, @password)"
                command.Parameters.Clear()
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)
                command.ExecuteNonQuery()
                connection.Close()
                Return True
            Else
                ' Username already exists
                connection.Close()
                Return False
            End If
        End Get
    End Property


End Module
