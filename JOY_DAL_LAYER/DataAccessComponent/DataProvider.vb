Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports MySql.Data.MySqlClient
Namespace INV_DATA_LAYER.DataAccessComponent
    Public Class DataProvider
        Implements IDisposable

#Region "[Variables and Objects]"
        Private _DatabaseType As DBType = DBType.SQLSERVER
        Private _ConnectionString As String = ""
        Dim command As IDbCommand = Nothing
        Dim connection As IDbConnection = Nothing
        Dim dataSet As DataSet = Nothing
        Dim adapter As IDataAdapter = Nothing
        Dim parameter As IDataParameter = Nothing
        Dim transaction As IDbTransaction
        Dim res As Integer
#End Region

        Public Enum DBType
            OLEDB
            SQLSERVER
            ORACLE
            MYSQL
        End Enum

        Sub New()
            ' TODO: Complete member initialization 
        End Sub

        Public Property DatabaseType As DBType
            Get
                Return Me._DatabaseType
            End Get
            Set(ByVal value As DBType)
                Me._DatabaseType = value
            End Set
        End Property

        Public Property ConnectionString As String
            Get
                Return Me._ConnectionString
            End Get
            Set(ByVal value As String)
                Me._ConnectionString = value
            End Set
        End Property

        Public Sub New(ByVal ConnectString As String, ByVal Database As DBType)
            Me.ConnectionString = ConnectString
            Me.DatabaseType = Database
        End Sub

        Public Function ExecuteNonQuery(ByVal CmdText As String) As Integer

            Try
                connection = Me.GetConnection()
                command = Me.GetCommand(CmdText, connection)
                connection.Open()
                res = command.ExecuteNonQuery()
            Catch ex As Exception
                System.Diagnostics.Debug.WriteLine(ex.Message)
                res = 0
            Finally
                If (command IsNot Nothing) Then
                    command.Dispose()
                End If
                If (connection IsNot Nothing) Then
                    connection.Dispose()
                End If

            End Try
            Return res
        End Function

        Public Function ExecuteNonQuerySP(ByVal procedureName As String, ByVal parameters As IDictionary(Of String, Object)) As Integer

            Try
                connection = Me.GetConnection()
                transaction = connection.BeginTransaction()
                command = Me.GetCommand(procedureName, parameters)
                connection.Open()
                res = command.ExecuteNonQuery()
                transaction.Commit()
            Catch ex As Exception
                transaction.Rollback()
                res = 0
            Finally
                If (command IsNot Nothing) Then
                    command.Dispose()
                End If
                If (connection IsNot Nothing) Then
                    connection.Dispose()
                End If
            End Try
            Return res
        End Function

        Public Function ExecuteNonQuery(ByVal CmdText As String, ByRef transaction As IDbTransaction) As Integer

            Try
                transaction = connection.BeginTransaction()
                connection = Me.GetConnection()
                command = Me.GetCommand(CmdText, connection)
                command.Transaction = transaction
                connection.Open()
                res = command.ExecuteNonQuery()
                res = 1
                transaction.Commit()
            Catch ex As Exception
                transaction.Rollback()
                res = 0
            Finally
                If (command IsNot Nothing) Then
                    command.Dispose()
                End If
                If (connection IsNot Nothing) Then
                    connection.Dispose()
                End If
            End Try
            Return res
        End Function
        Public Function ExecuteNonQuery(ByVal commandText As String, ByVal parameters As IDictionary(Of String, Object)) As Integer


            Try

                connection = Me.GetConnection()

                command = Me.GetCommand(commandText, parameters)
                command.Connection = connection
                command.Transaction = transaction
                connection.Open()
                transaction = connection.BeginTransaction()
                res = command.ExecuteNonQuery()
                res = 1
                transaction.Commit()
            Catch ex As Exception
                transaction.Rollback()
                res = 0
            Finally
                If (command IsNot Nothing) Then
                    command.Dispose()
                End If
                If (connection IsNot Nothing) Then
                    connection.Dispose()
                End If

            End Try
            Return res
        End Function
        Public Function ExecuteReader(ByVal CmdText As String) As IDataReader
            Try
                connection = Me.GetConnection()
                command = Me.GetCommand(CmdText, connection)
                connection.Open()
                Return command.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
            Catch ex As Exception
                System.Diagnostics.Debug.WriteLine(ex.Message)
                Return Nothing
            Finally
                If (command IsNot Nothing) Then
                    command.Dispose()
                End If
                If (connection IsNot Nothing) Then
                    connection.Dispose()
                End If
            End Try
        End Function

        Public Function ExecuteScalar(ByVal CmdText As String) As Object
            Try
                connection = Me.GetConnection()
                command = Me.GetCommand(CmdText, connection)
                connection.Open()
                Return command.ExecuteScalar()
            Catch ex As Exception
                System.Diagnostics.Debug.WriteLine(ex.Message)
                Return 0
            Finally
                If (command IsNot Nothing) Then
                    command.Dispose()
                End If
                If (connection IsNot Nothing) Then
                    connection.Dispose()
                End If
            End Try
        End Function

        Public Function FillDataSet(ByVal CmdText As String) As DataSet
            Try
                connection = Me.GetConnection()
                command = Me.GetCommand(CmdText, connection)
                adapter = Me.GetDataAdapter(command)

                dataSet = New DataSet()
                adapter.Fill(dataSet)
                Return dataSet
            Catch ex As Exception
                System.Diagnostics.Debug.WriteLine(ex.Message)
                Return Nothing
            Finally
                If (command IsNot Nothing) Then
                    command.Dispose()
                End If
                If (connection IsNot Nothing) Then
                    connection.Dispose()
                End If
            End Try
        End Function

        Public Function GetConnection() As IDbConnection
            Select Case (Me.DatabaseType)
                Case DBType.SQLSERVER
                    connection = New SqlConnection(Me.ConnectionString)
                Case DBType.ORACLE
                    connection = New OracleConnection(Me.ConnectionString)
                Case DBType.OLEDB
                    connection = New OleDbConnection(Me.ConnectionString)
                Case DBType.MYSQL
                    connection = New MySqlConnection(Me.ConnectionString)
            End Select
            Return connection
        End Function

        Private Function GetCommand(ByVal CmdText As String, ByVal Connection As IDbConnection) As IDbCommand
            Select Case (Me.DatabaseType)
                Case DBType.SQLSERVER
                    command = New SqlCommand(CmdText, CType(Connection, SqlConnection))
                Case DBType.OLEDB
                    command = New OleDbCommand(CmdText, CType(Connection, OleDbConnection))
                Case DBType.MYSQL
                    command = New MySqlCommand(CmdText, CType(Connection, MySqlConnection))
            End Select
            Return command
        End Function

        Private Function GetCommand(ByVal CmdText As String) As IDbCommand
            Select Case (Me.DatabaseType)
                Case DBType.SQLSERVER
                    command = New SqlCommand(CmdText)
                Case DBType.OLEDB
                    command = New OleDbCommand(CmdText)
                Case DBType.MYSQL
                    command = New MySqlCommand(CmdText)
            End Select
            Return command
        End Function

        Public Function GetCommand(ByVal commandText As String, ByVal parameters As IDictionary(Of String, Object)) As IDbCommand
            Dim command As IDbCommand = Me.GetCommand(commandText)
            command.CommandType = CommandType.StoredProcedure
            For Each parameterName As String In parameters.Keys
                Dim PARAMS As String() = parameterName.Split("|")
                command.Parameters.Add(Me.GetParameter(PARAMS(0), PARAMS(1), _
                                                       parameters(parameterName)))
            Next parameterName
            Return command
        End Function

        Public Function GetDataTable(ByVal procedureName As String, ByVal parameters As IDictionary(Of String, Object)) As DataTable
            Dim command As IDbCommand = Me.GetCommand(procedureName, parameters)
            connection = Me.GetConnection()
            connection.Open()

            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure

            Dim reader As IDataReader = command.ExecuteReader(CommandBehavior.KeyInfo Or _
                                                               CommandBehavior.CloseConnection)
            Dim table As New DataTable()

            table.Load(reader)
            reader.Close()

            Return table
        End Function

        Private Function GetDataAdapter(ByVal command As IDbCommand) As IDataAdapter
            Select Case (Me.DatabaseType)
                Case DBType.SQLSERVER
                    adapter = New SqlDataAdapter(CType(command, SqlCommand))
                Case DBType.OLEDB
                    adapter = New OleDbDataAdapter(CType(command, OleDbCommand))
                Case DBType.MYSQL
                    adapter = New MySqlDataAdapter(CType(command, MySqlCommand))
            End Select
            Return adapter
        End Function

        Private Function FillDataset(ByVal connection As IDbConnection, ByVal StoredProc As String, ByVal CmdType As CommandType, ByVal parameters As IDictionary(Of String, Object)) As IDataAdapter
            command = Me.GetCommand(StoredProc, parameters)
            command.CommandType = CmdType
            command.Connection = connection
            adapter = Me.GetDataAdapter(command)

            dataSet = New DataSet()
            adapter.Fill(dataSet)
            Return dataSet
        End Function

        Public Function GetParameter() As IDataParameter
            Select Case (Me.DatabaseType)
                Case DBType.SQLSERVER
                    parameter = New SqlParameter()
                Case DBType.OLEDB
                    parameter = New OleDbParameter()
                Case DBType.MYSQL
                    parameter = New MySqlParameter()
            End Select
            Return parameter
        End Function

        Public Function GetParameter(ByVal parameterName As String, ByVal Direct As String, ByVal value As Object) As IDataParameter
            Dim parameter As IDataParameter = Me.GetParameter()
            parameter.ParameterName = parameterName
            Select Case Direct
                Case "IN"
                    parameter.Direction = ParameterDirection.Input
                Case "OUT"
                    parameter.Direction = ParameterDirection.Output
                Case Else
                    parameter.Direction = ParameterDirection.Input
            End Select
            parameter.Value = value
            Return parameter
        End Function

#Region "IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls
        ' IDisposable
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    ' TODO: dispose managed state (managed objects).
                End If

                ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
                ' TODO: set large fields to null.
            End If
            Me.disposedValue = True
        End Sub

        ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
        'Protected Overrides Sub Finalize()
        '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        '    Dispose(False)
        '    MyBase.Finalize()
        'End Sub

        ' This code added by Visual Basic to correctly implement the disposable pattern.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region

    End Class
End Namespace


