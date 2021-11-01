Public Class RegistroEvaluacion
    Dim T As New DataSet
    Dim SQL As String
    Dim PK As Integer
    Dim CR As Byte
    Friend Sub ELIMINANDO()
        T.Tables.Clear()
        SQL = "SELECT CRITERIO FROM EVALUACION WHERE ID =" & PK & ""
        CARGAR_TABLA(T, SQL)
        If MsgBox("¿Desea eliminar la evaluacion seleccionada? " & T.Tables(0).Rows(0).Item(0) & "  del sistema?", vbQuestion + vbYesNo, "Consulta") = vbYes Then
            SQL = "DELETE FROM EVALUACION WHERE ID = " & PK & ""
            EJECUTAR(SQL)
            Nuevo1()
            MsgBox("La evaluacion ha sido eliminada", vbInformation + vbOKOnly, "Eliminando")
        End If
    End Sub
    Friend Sub BUSQUEDA(ByVal CRITERIO As String)
        T.Tables.Clear()
        L.Items.Clear()
        SQL = "SELECT ID, CRITERIO, VALOR FROM EVALUACION WHERE " & CRITERIO & " = '" & BUSCO.Text & "'"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                L.Items.Add(T.Tables(0).Rows(I).Item(0))
                For J As Byte = 1 To 2
                    L.Items(L.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(I).Item(J))
                Next
            Next
        Else
            MsgBox("No existen resultados por mostrar.", vbInformation + vbOKOnly, "Buscando")
        End If
    End Sub
    Friend Sub VALIDA_LLENO()
        If VALOR_PORCENTUAL.Text <> "" And COMPONENTE_EVALUACION.Text <> "" Then
            GUARDAR.Enabled = True
            NUEVO.Enabled = True
        Else
            GUARDAR.Enabled = False
            NUEVO.Enabled = False
        End If
    End Sub
    Friend Sub REFRESCAR()
        T.Tables.Clear()
        L.Items.Clear()
        SQL = "SELECT ID, CRITERIO, VALOR FROM EVALUACION"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                L.Items.Add(T.Tables(0).Rows(I).Item(0))
                For J = 1 To 2
                    L.Items(L.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(I).Item(J))
                Next
            Next
            MC_ELIMINAR.Enabled = True
        Else
            MC_ELIMINAR.Enabled = False
        End If
    End Sub
    Friend Sub Nuevo1()
        PK = 0
        VALOR_PORCENTUAL.ResetText()
        COMPONENTE_EVALUACION.Clear()
        REFRESCAR()
        ELIMINAR.Enabled = False
    End Sub
    Private Sub BUSCO_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub COMPONENTE_EVALUACION_TextChanged(sender As Object, e As EventArgs) Handles COMPONENTE_EVALUACION.TextChanged
        VALIDA_LLENO()
    End Sub

    Private Sub VALOR_PORCENTUAL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VALOR_PORCENTUAL.SelectedIndexChanged
        VALIDA_LLENO()
    End Sub

    Private Sub BUSCO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BUSCO.SelectedIndexChanged

    End Sub

    Private Sub RegistroEvaluacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = PRINCIPAL
        Nuevo1()
    End Sub
    Private Sub GUARDAR_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        T.Tables.Clear()
        SQL = "SELECT ID FROM EVALUACION WHERE ID = " & PK & ""
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then 'EXISTE EL DATO (ACTUALIZAR)
            SQL = "UPDATE EVALUACION SET CRITERIO = '" & COMPONENTE_EVALUACION.Text & "', VALOR = '" & Integer.Parse(VALOR_PORCENTUAL.Text) & "' WHERE ID = " & PK & ""
        Else '(INSERTAR)
            SQL = "INSERT INTO EVALUACION (ID, CRITERIO, VALOR) VALUES(" & GENERAR_PK("EVALUACION") & ", '" & COMPONENTE_EVALUACION.Text & "', '" & VALOR_PORCENTUAL.Text & "')"
        End If
        EJECUTAR(SQL)
        Nuevo1()
        MsgBox("La información ha sido almacenada satisfactoriamente.", vbInformation + vbOKOnly, "Guardando")
    End Sub
    Private Sub L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L.SelectedIndexChanged
        On Error Resume Next
        If L.SelectedItems.Count > 0 Then
            PK = L.SelectedItems(0).SubItems(0).Text
            COMPONENTE_EVALUACION.Text = L.SelectedItems(0).SubItems(1).Text
            VALOR_PORCENTUAL.Text = L.SelectedItems(0).SubItems(2).Text
        End If
    End Sub

    Private Sub COMPONENTE_CheckedChanged(sender As Object, e As EventArgs) Handles COMPONENTE.CheckedChanged
        CR = 1
    End Sub
    Private Sub MC_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MC_ELIMINAR.Click
        ELIMINANDO()
    End Sub

    Private Sub ELIMINAR_Click(sender As Object, e As EventArgs) Handles ELIMINAR.Click
        ELIMINANDO()
    End Sub

    Private Sub NUEVO_Click(sender As Object, e As EventArgs) Handles NUEVO.Click
        Nuevo1()
    End Sub

    Private Sub MC_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MC.Opening

    End Sub
End Class