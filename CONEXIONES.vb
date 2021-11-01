Module CONEXIONES
    Public Db As New OleDb.OleDbConnection
    Public SQL As String
    Public T As New DataSet
    Friend Sub CONECTAR()
        Dim Ruta As String
        Ruta = "File Name=" &
        Application.StartupPath & "\ruta.udl"
        Db.ConnectionString = Ruta
        Db.Open()
        Exit Sub
    End Sub
    Friend Sub DESCONECTAR()
        Db.Close()
    End Sub
    Public ruta As String
    Public Property SetGetRuta As String
        Get
            Return ruta
        End Get
        Set(value As String)
            ruta = value
        End Set
    End Property
    Friend Sub CARGAR_TABLA(ByRef Tabla_Temporal As DataSet, ByVal Sql As String)
        CONECTAR()
        Dim Consulta As New OleDb.OleDbDataAdapter(Sql, Db)
        Consulta.Fill(Tabla_Temporal) 'un DataSet
        DESCONECTAR()
    End Sub
    Friend Sub EJECUTAR(ByVal Sql As String)
        CONECTAR()
        Dim Comando As New OleDb.OleDbCommand(Sql, Db)
        Comando.ExecuteNonQuery()
        DESCONECTAR()
    End Sub
    Friend Function GENERAR_PK(ByVal TABLA As String) As Integer
        T.Tables.Clear()
        SQL = "SELECT ID FROM " & TABLA & ""
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count = 0 Then
            GENERAR_PK = 1
        Else
            T.Tables.Clear()
            SQL = "SELECT MAX(ID) FROM " & TABLA & ""
            CARGAR_TABLA(T, SQL)
            GENERAR_PK = T.Tables(0).Rows(0).Item(0) + 1
        End If
    End Function
End Module