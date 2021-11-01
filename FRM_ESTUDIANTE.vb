Public Class FRM_ESTUDIANTE
    Dim CR As Byte 'Criterio
    Dim PK As Integer
    Dim I As Integer
    Friend Sub BUSQUEDA(ByVal CRITERIO As String)
        T.Tables.Clear()
        L.Items.Clear()
        SQL = "SELECT ID, IDENTIFICACION, NOMBRE, APELLIDO1, APELLIDO2, FECHA, MOVIL FROM ESTUDIANTES WHERE " & CRITERIO & " = '" & BUSCO.Text & "'"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            PR.Value = 0
            PR.Maximum = T.Tables(0).Rows.Count
            PR.Visible = True
            For I = 0 To T.Tables(0).Rows.Count - 1
                L.Items.Add(T.Tables(0).Rows(I).Item(0))
                For J As Byte = 1 To 6
                    L.Items(L.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(I).Item(J))
                Next
                PR.Value += 1
            Next
            PR.Visible = False
        Else
            MsgBox("No existen resultados por mostrar.", vbInformation + vbOKOnly, "Buscando")
        End If
    End Sub
    Friend Sub ELIMINANDO()
        T.Tables.Clear()
        SQL = "SELECT NOMBRE, APELLIDO1, APELLIDO2 FROM ESTUDIANTES WHERE ID =" & PK & ""
        CARGAR_TABLA(T, SQL)
        If MsgBox("¿Desea eliminar el estudiante seleccionado?" & T.Tables(0).Rows(0).Item(0) & "" & T.Tables(0).Rows(0).Item(1) & "" & T.Tables(0).Rows(0).Item(2) & " del sistema?", vbQuestion + vbYesNo, "Consulta") = vbYes Then
            SQL = "DELETE FROM ESTUDIANTES WHERE ID = " & PK & ""
            EJECUTAR(SQL)
            Nuevo1()
            MsgBox("El estudiante ha sido eliminado", vbInformation + vbOKOnly, "Eliminando")
        End If
    End Sub
    Friend Sub VALIDA_LLENO()
        If IDENTIFICACION.Text <> "" And NOMBRE.Text <> "" And P1.Text <> "" Then
            GUARDAR.Enabled = True
        Else
            GUARDAR.Enabled = False
        End If

        If IDENTIFICACION.Text <> "" Or NOMBRE.Text <> "" Or P1.Text <> "" Or P2.Text <> "" Or TEL.Text <> "" Then
            NUEVO.Enabled = True
        Else
            NUEVO.Enabled = False
        End If
    End Sub
    Friend Sub MASCARA(ByVal ESTADO As Boolean)
        If ESTADO = True Then
            BUSCO.Mask = "9999-9999"
        Else
            BUSCO.Mask = ""
        End If
    End Sub
    Friend Sub REFRESCAR()
        T.Tables.Clear()
        L.Items.Clear()
        SQL = "SELECT ID, IDENTIFICACION, NOMBRE, APELLIDO1, APELLIDO2, FECHA, MOVIL FROM ESTUDIANTES"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            PR.Value = 0
            PR.Maximum = T.Tables(0).Rows.Count
            PR.Visible = True
            For I = 0 To T.Tables(0).Rows.Count - 1
                L.Items.Add(T.Tables(0).Rows(I).Item(0))
                For J As Byte = 1 To 6
                    L.Items(L.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(I).Item(J))
                Next
                PR.Value += 1
            Next
            PR.Visible = False
            MC_ELIMINAR.Enabled = True
        Else
            MC_ELIMINAR.Enabled = False
        End If
    End Sub
    Friend Sub Nuevo1()
        PK = 0
        IDENTIFICACION.Clear()
        NOMBRE.Clear()
        P1.Clear()
        P2.Clear()
        TEL.Clear()
        FN.Value = Now 'NOW FECHA ACTUAL DEL SISTEMA
        'FOTO.BackgroundImage = My.Resources.REGISTRO
        FOTO.Image = My.Resources.REGISTRO
        REFRESCAR()
        ELIMINAR.Enabled = False
        IDENTIFICACION.Select()
    End Sub
    Private Sub FRM_ESTUDIANTES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = PRINCIPAL
        Nuevo1()
    End Sub
    Private Sub FOTOGRAFIA_Click(sender As Object, e As EventArgs) Handles FOTOGRAFIA.Click
        If ABRIR.ShowDialog = DialogResult.OK Then
            'FOTO.BackgroundImage = Image.FromFile(ABRIR.FileName)
            FOTO.Image = Image.FromFile(ABRIR.FileName)
            FOTOGRAFIA.Tag = ABRIR.FileName 'Guarda la ruta de la imagen
        End If
    End Sub
    Private Sub IDENTIFICACION_TextChanged(sender As Object, e As EventArgs) Handles IDENTIFICACION.TextChanged
        VALIDA_LLENO()
    End Sub
    Private Sub NOMBRE_TextChanged(sender As Object, e As EventArgs) Handles NOMBRE.TextChanged
        VALIDA_LLENO()
    End Sub
    Private Sub P1_TextChanged(sender As Object, e As EventArgs) Handles P1.TextChanged
        VALIDA_LLENO()
    End Sub
    Private Sub P2_TextChanged(sender As Object, e As EventArgs) Handles P2.TextChanged
        VALIDA_LLENO()
    End Sub
    Private Sub TEL_TextChanged(sender As Object, e As EventArgs) Handles TEL.TextChanged
        VALIDA_LLENO()
    End Sub
    Private Sub BUSCO_TextChanged(sender As Object, e As EventArgs) Handles BUSCO.TextChanged
        If BUSCO.Text <> "" Then
            BUSCAR.Enabled = True
        Else
            BUSCAR.Enabled = False
        End If
    End Sub
    Private Sub R_IDENTIFICACION_CheckedChanged(sender As Object, e As EventArgs) Handles R_IDENTIFICACION.CheckedChanged
        MASCARA(False)
        CR = 1
    End Sub
    Private Sub R_NOMBRE_CheckedChanged(sender As Object, e As EventArgs) Handles R_NOMBRE.CheckedChanged
        MASCARA(False)
        CR = 2
    End Sub
    Private Sub R_P1_CheckedChanged(sender As Object, e As EventArgs) Handles R_AP1.CheckedChanged
        MASCARA(False)
        CR = 3
    End Sub
    Private Sub R_TEL_CheckedChanged(sender As Object, e As EventArgs) Handles R_TEL.CheckedChanged
        MASCARA(True)
        CR = 4
    End Sub
    Private Sub GUARDAR_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        T.Tables.Clear()
        SQL = "SELECT ID FROM ESTUDIANTES WHERE ID = " & PK & ""
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then 'EXISTE EL DATO (ACTUALIZAR)
        SQL = "UPDATE ESTUDIANTES SET IDENTIFICACION = '" & IDENTIFICACION.Text & "', NOMBRE = '" & NOMBRE.Text & "', APELLIDO1 = '" & P1.Text & "', APELLIDO2 = '" & P2.Text & "', FECHA = '" & Format(FN.Value, "yyyy/MM/dd") & "', MOVIL = '" & TEL.Text & "', FOTO = '" & FOTOGRAFIA.Tag & "' WHERE ID = " & PK & ""
        Else '(INSERTAR)
            SQL = "INSERT INTO ESTUDIANTES (ID, IDENTIFICACION, NOMBRE, APELLIDO1, APELLIDO2, FECHA, MOVIL, FOTO) VALUES(" & GENERAR_PK("ESTUDIANTES") & ", '" & IDENTIFICACION.Text & "', '" & NOMBRE.Text & "', '" & P1.Text & "', '" & P2.Text & "', '" & Format(FN.Value, "yyyy/MM/dd") & "', '" & TEL.Text & "', '" & FOTOGRAFIA.Tag & "')"
        End If
        EJECUTAR(SQL)
        Nuevo1()
        MsgBox("La información ha sido almacenada satisfactoriamente.", vbInformation + vbOKOnly, "Guardando")
    End Sub
    Private Sub L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L.SelectedIndexChanged
        On Error Resume Next
        If L.SelectedItems.Count > 0 Then
            PK = L.SelectedItems(0).SubItems(0).Text
            IDENTIFICACION.Text = L.SelectedItems(0).SubItems(1).Text
            NOMBRE.Text = L.SelectedItems(0).SubItems(2).Text
            P1.Text = L.SelectedItems(0).SubItems(3).Text
            P2.Text = L.SelectedItems(0).SubItems(4).Text
            FN.Value = L.SelectedItems(0).SubItems(5).Text
            TEL.Text = L.SelectedItems(0).SubItems(6).Text

            T.Tables.Clear()
            SQL = "SELECT FOTO FROM ESTUDIANTES WHERE ID = " & PK & ""
            CARGAR_TABLA(T, SQL)
            If IsDBNull(T.Tables(0).Rows(0).Item(0)) Or T.Tables(0).Rows(0).Item(0) = "" Then
                'FOTO.BackgroundImage = My.Resources.REGISTRO
                FOTO.Image = My.Resources.REGISTRO
            Else
                'FOTO.BackgroundImage = Image.FromFile(T.Tables(0).Rows(0).Item(0))
                FOTO.Image = Image.FromFile(T.Tables(0).Rows(0).Item(0))
            End If
        End If
    End Sub
    Private Sub BUSCAR_Click(sender As Object, e As EventArgs) Handles BUSCAR.Click
        Dim CRITERIO As String = ""

        Select Case CR
            Case 1
                CRITERIO = "IDENTIFICACION"
            Case 2
                CRITERIO = "NOMBRE"
            Case 3
                CRITERIO = "APELLIDO1"
            Case 4
                CRITERIO = "MOVIL"
        End Select
        BUSQUEDA(CRITERIO)
    End Sub
    Private Sub NUEVO_Click(sender As Object, e As EventArgs) Handles NUEVO.Click
        Nuevo1()
    End Sub
    Private Sub BUSQUEDA_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles BUSCO.MaskInputRejected

    End Sub
    Private Sub FOTO_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ELIMINAR_Click(sender As Object, e As EventArgs) Handles ELIMINAR.Click
        ELIMINANDO()

    End Sub
    Private Sub FRM_ESTUDIANTE_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 127 Then
            If PK <> 0 Then
                ELIMINANDO()
            End If
        End If
    End Sub

    Private Sub MC_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MC_ELIMINAR.Click
        ELIMINANDO()
    End Sub

    Private Sub TEL_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles TEL.MaskInputRejected

    End Sub
End Class