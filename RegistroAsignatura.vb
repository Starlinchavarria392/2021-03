Public Class RegistroAsignatura
    Dim CR As Byte 'Criterio
    Dim PK As Integer
    Dim I As Integer
    Friend Sub BUSQUEDA(ByVal CRITERIO As String)
        T.Tables.Clear()
        L.Items.Clear()
        SQL = "SELECT ID, NOMBRE, NIVEL, DURACION, MODALIDAD, REGIDA, APROBACION FROM ASIGNATURA WHERE " & CRITERIO & " = '" & BUSCO.Text & "'"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then

            For I = 0 To T.Tables(0).Rows.Count - 1
                L.Items.Add(T.Tables(0).Rows(I).Item(0))
                For J As Byte = 1 To 6
                    L.Items(L.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(I).Item(J))
                Next

            Next

        Else
            MsgBox("No existen resultados por mostrar.", vbInformation + vbOKOnly, "Buscando")
        End If
    End Sub
    Friend Sub ELIMINANDO()
        T.Tables.Clear()
        SQL = "SELECT NOMBRE FROM ASIGNATURA WHERE ID =" & PK & ""
        CARGAR_TABLA(T, SQL)
        If MsgBox("¿Desea eliminar la asignatura seleccionada? " & T.Tables(0).Rows(0).Item(0) & "  del sistema?", vbQuestion + vbYesNo, "Consulta") = vbYes Then
            SQL = "DELETE FROM ASIGNATURA WHERE ID = " & PK & ""
            EJECUTAR(SQL)
            Nuevo1()
            MsgBox("La asignatura ha sido eliminada", vbInformation + vbOKOnly, "Eliminando")
        End If
    End Sub
    Friend Sub VALIDA_LLENO()
        If NOMBRE.Text <> "" And DURACION.Text <> "__" And NOTA.Text <> "__" Then
            GUARDAR.Enabled = True
        Else
            GUARDAR.Enabled = False
        End If

        If NOMBRE.Text <> "" Or DURACION.Text <> "__" Or NOTA.Text <> "__" Then
            NUEVO.Enabled = True
        Else
            NUEVO.Enabled = False
        End If
    End Sub
    Friend Sub REFRESCAR()
        T.Tables.Clear()
        L.Items.Clear()
        SQL = "SELECT ID, NOMBRE, NIVEL, DURACION, MODALIDAD, REGIDA, APROBACION FROM ASIGNATURA"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                L.Items.Add(T.Tables(0).Rows(I).Item(0))
                For J As Byte = 1 To 6
                    L.Items(L.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(I).Item(J))
                Next
            Next
            MC_ELIMINAR.Enabled = True
        Else
            MC_ELIMINAR.Enabled = False
        End If
    End Sub
    Friend Sub MASCARA(ByVal ESTADO As Boolean)
        If ESTADO = True Then
            'BUSCO.Mask = "99"
        Else
            'BUSCO.Mask = ""
        End If
    End Sub
    Friend Sub Nuevo1()
        PK = 0
        NOMBRE.Clear()
        NIVEL.ResetText()
        DURACION.Clear()
        MODALIDAD.ResetText()
        REGIDA.ResetText()
        NOTA.Clear()
        REFRESCAR()
        ELIMINAR.Enabled = False
    End Sub
    Private Sub RegistroAsignatura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = PRINCIPAL
        Nuevo1()
    End Sub

    Private Sub BUSCO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BUSCO.SelectedIndexChanged

    End Sub
    Private Sub GUARDAR_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        T.Tables.Clear()
        SQL = "SELECT ID FROM ASIGNATURA WHERE ID = " & PK & ""
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then 'EXISTE EL DATO (ACTUALIZAR)
            SQL = "UPDATE ASIGNATURA SET NOMBRE = '" & NOMBRE.Text & "', NIVEL = '" & NIVEL.Text & "', DURACION = '" & Integer.Parse(DURACION.Text) & "', MODALIDAD = '" & MODALIDAD.Text & "', REGIDA = '" & REGIDA.Text & "', APROBACION = '" & Integer.Parse(NOTA.Text) & "' WHERE ID = " & PK & ""
        Else '(INSERTAR)
            SQL = "INSERT INTO ASIGNATURA (ID, NOMBRE, NIVEL, DURACION, MODALIDAD, REGIDA, APROBACION) VALUES(" & GENERAR_PK("ASIGNATURA") & ", '" & NOMBRE.Text & "', '" & NIVEL.Text & "', '" & DURACION.Text & "', '" & MODALIDAD.Text & "', '" & REGIDA.Text & "', '" & NOTA.Text & "')"
        End If
        EJECUTAR(SQL)
        Nuevo1()
        MsgBox("La información ha sido almacenada satisfactoriamente.", vbInformation + vbOKOnly, "Guardando")
    End Sub
    Private Sub L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L.SelectedIndexChanged
        On Error Resume Next
        If L.SelectedItems.Count > 0 Then
            PK = L.SelectedItems(0).SubItems(0).Text
            NOMBRE.Text = L.SelectedItems(0).SubItems(1).Text
            NIVEL.Text = L.SelectedItems(0).SubItems(2).Text
            DURACION.Text = L.SelectedItems(0).SubItems(3).Text
            MODALIDAD.Text = L.SelectedItems(0).SubItems(4).Text
            REGIDA.Text = L.SelectedItems(0).SubItems(5).Text
            NOTA.Text = L.SelectedItems(0).SubItems(6).Text
        End If
    End Sub

    Private Sub NOMBRE_TextChanged(sender As Object, e As EventArgs) Handles NOMBRE.TextChanged
        VALIDA_LLENO()
    End Sub

    Private Sub NIVEL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NIVEL.SelectedIndexChanged
        VALIDA_LLENO()
    End Sub

    Private Sub DURACION_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles DURACION.MaskInputRejected
        VALIDA_LLENO()
    End Sub

    Private Sub MODALIDAD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MODALIDAD.SelectedIndexChanged
        VALIDA_LLENO()
    End Sub
    Private Sub REGIDA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles REGIDA.SelectedIndexChanged
        VALIDA_LLENO()
    End Sub
    Private Sub NOTA_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles NOTA.MaskInputRejected
        VALIDA_LLENO()
    End Sub
    Private Sub NOMBRE1_CheckedChanged(sender As Object, e As EventArgs) Handles NOMBRE1.CheckedChanged
        MASCARA(False)
        CR = 1
    End Sub

    Private Sub NIVEL1_CheckedChanged(sender As Object, e As EventArgs) Handles NIVEL1.CheckedChanged
        MASCARA(False)
        CR = 2
    End Sub

    Private Sub MODALIDAD1_CheckedChanged(sender As Object, e As EventArgs) Handles MODALIDAD1.CheckedChanged
        MASCARA(False)
        CR = 3
    End Sub

    Private Sub NUEVO_Click(sender As Object, e As EventArgs) Handles NUEVO.Click
        Nuevo1()
    End Sub

    Private Sub MC_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MC.Opening

    End Sub

    Private Sub MC_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MC_ELIMINAR.Click
        ELIMINANDO()
    End Sub
    Private Sub ELIMINAR_Click(sender As Object, e As EventArgs) Handles ELIMINAR.Click
        ELIMINANDO()
    End Sub
End Class