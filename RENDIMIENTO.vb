Public Class RENDIMIENTO
    Dim T2, T3 As New DataSet
    Dim ID_RENDIMIENTO As Integer
    Private Sub RENDIMIENTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = PRINCIPAL
        NUEVO()
    End Sub
    Friend Sub REFRESCAR_CURSO()
        T.Tables.Clear()
        SQL = "SELECT ID, NOMBRE FROM ASIGNATURA"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                CURSO.Items.Add(T.Tables(0).Rows(I).Item(0) & " - " & T.Tables(0).Rows(I).Item(1))
            Next
        End If
    End Sub

    Friend Sub REFRESCAR_ESTUDIANTE()
        Dim Vector() As String
        Dim ID, DESCRIPCION As String
        Vector = Split(CURSO.Text, " - ", 2)
        ID = Vector(0)
        DESCRIPCION = Vector(1)
        CURSO.Tag = ID

        L.Items.Clear()
        T.Tables.Clear()
        SQL = "SELECT ID_ESTUDIANTE, PROMEDIO, ID FROM RENDIMIENTO WHERE ID_CURSO = " & ID & ""
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                T2.Tables.Clear()
                SQL = "SELECT NOMBRE, APELLIDO1, APELLIDO2 FROM ESTUDIANTES WHERE ID = " & T.Tables(0).Rows(I).Item(0) & ""
                CARGAR_TABLA(T2, SQL)
                L.Items.Add(T.Tables(0).Rows(I).Item(0)) 'ID DEL ESTUDIANTE
                L.Items(L.Items.Count - 1).SubItems.Add(T2.Tables(0).Rows(0).Item(1) & " " & T2.Tables(0).Rows(0).Item(2) & " " & T2.Tables(0).Rows(0).Item(0))
                L.Items(L.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(I).Item(1))
                L.Items(L.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(I).Item(2))
            Next
        End If
    End Sub

    Friend Sub REFRESCAR_EVALUACION()
        On Error Resume Next
        T.Tables.Clear()
        L2.Items.Clear()
        SQL = "SELECT ID_EVALUACION FROM CURSO_EVALUACION WHERE ID_CURSO = " & CURSO.Tag & ""
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            T2.Tables.Clear()
            SQL = "SELECT ID, ID_MAESTRO, DESCRIPCION, VALOR FROM DETALLE_EVALUACION WHERE ID_MAESTRO = " & T.Tables(0).Rows(0).Item(0) & ""
            CARGAR_TABLA(T2, SQL)
            For I = 0 To T2.Tables(0).Rows.Count - 1
                L2.Items.Add(T2.Tables(0).Rows(I).Item(0))
                L2.Items(L2.Items.Count - 1).SubItems.Add(T2.Tables(0).Rows(I).Item(1))
                L2.Items(L2.Items.Count - 1).SubItems.Add(T2.Tables(0).Rows(I).Item(2))
                L2.Items(L2.Items.Count - 1).SubItems.Add(T2.Tables(0).Rows(I).Item(3) & "%")

                T3.Tables.Clear()
                SQL = "SELECT NOTA FROM DESGLOSE WHERE ID_RENDIMIENTO = " & ID_RENDIMIENTO & " AND ID_DETALLE_EVALUACION = " & T2.Tables(0).Rows(I).Item(0) & ""
                CARGAR_TABLA(T3, SQL)
                If Not IsDBNull(T3.Tables(0).Rows(0).Item(0)) Then
                    L2.Items(L2.Items.Count - 1).SubItems.Add(T3.Tables(0).Rows(0).Item(0)) 'LA NOTA
                Else
                    L2.Items(L2.Items.Count - 1).SubItems.Add("0") 'LA NOTA
                End If

            Next
        End If
    End Sub
    Friend Sub NUEVO()
        REFRESCAR_CURSO()
    End Sub

    Private Sub NOTA_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub NOTA_TextChanged(sender As Object, e As EventArgs)
        If NOTA.Text <> "" Then
            GUARDAR.Enabled = True
        Else
            GUARDAR.Enabled = False
        End If
    End Sub

    Private Sub L_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles L.SelectedIndexChanged
        If L.SelectedItems.Count > 0 Then
            ESTUDIANTE.Tag = L.SelectedItems(0).SubItems(0).Text
            ESTUDIANTE.Text = L.SelectedItems(0).SubItems(1).Text
            ID_RENDIMIENTO = L.SelectedItems(0).SubItems(3).Text
            REFRESCAR_EVALUACION()
        End If
    End Sub

    Private Sub L2_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles L2.SelectedIndexChanged
        On Error Resume Next
        If L2.SelectedItems.Count > 0 Then
            CRITERIO.Tag = L2.SelectedItems(0).SubItems(0).Text 'ID_DETALLE
            CRITERIO.Text = L2.SelectedItems(0).SubItems(2).Text
            NOTA.Text = L2.SelectedItems(0).SubItems(4).Text
        End If
    End Sub

    Private Sub CURSO_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CURSO.SelectedIndexChanged
        REFRESCAR_ESTUDIANTE()
    End Sub

    Private Sub NOTA_MaskInputRejected_1(sender As Object, e As MaskInputRejectedEventArgs) Handles NOTA.MaskInputRejected

    End Sub

    Private Sub GUARDAR_Click(sender As Object, e As EventArgs)
        T.Tables.Clear()
        SQL = "SELECT ID FROM DESGLOSE WHERE ID_RENDIMIENTO = " & ID_RENDIMIENTO & " AND ID_DETALLE_EVALUACION = " & CRITERIO.Tag & ""
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count = 0 Then
            SQL = "INSERT INTO DESGLOSE (ID, ID_RENDIMIENTO, ID_DETALLE_EVALUACION, NOTA) VALUES (" & GENERAR_PK("DESGLOSE") & ", " & ID_RENDIMIENTO & ", " & CRITERIO.Tag & ", " & NOTA.Text & ")"
        Else
            SQL = "UPDATE DESGLOSE SET NOTA = " & NOTA.Text & " WHERE ID = " & T.Tables(0).Rows(0).Item(0) & ""
        End If
        EJECUTAR(SQL)

        T.Tables.Clear()
        SQL = "SELECT VALOR FROM DETALLE_EVALUACION WHERE ID = " & CRITERIO.Tag & ""
        CARGAR_TABLA(T, SQL)
        Dim VALOR As Integer = T.Tables(0).Rows(0).Item(0)
        Dim PORCENTAJE As Double = 0
        PORCENTAJE = NOTA.Text * VALOR / 100
        REFRESCAR_EVALUACION()
        NOTA.Text = 100
    End Sub
End Class
