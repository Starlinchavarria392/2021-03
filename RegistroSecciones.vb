Public Class RegistroSecciones
    Dim T As DataSet
    Dim SQL As String

    Friend Sub VALIDA_LLENO()
        If CB_NIVEL_SECCIONES.Text <> "" And TXT_SECCION_SECCIONES.Text <> "" Then
            GUARDAR.Enabled = True
            NUEVO.Enabled = True
        Else
            GUARDAR.Enabled = False
            NUEVO.Enabled = False
        End If
    End Sub



    Friend Sub REFRESCAR()
        T.Clear()
        LV_SECCIONES.Items.Clear()
        SQL = "SELECT ID, NIVEL, SECCION FROM SECCIONES"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                LV_SECCIONES.Items.Add(T.Tables(0).Rows(I).Item(0))
                For J = 1 To 2
                    LV_SECCIONES.Items(LV_SECCIONES.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(I).Item(J))
                Next
            Next
        End If
    End Sub



    Friend Sub NUEVO1()
        CB_NIVEL_SECCIONES.ResetText()
        TXT_SECCION_SECCIONES.Clear()
    End Sub

    Private Sub RegistroSecciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = PRINCIPAL
    End Sub

    Private Sub CB_NIVEL_SECCIONES_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_NIVEL_SECCIONES.SelectedIndexChanged
        VALIDA_LLENO()
    End Sub

    Private Sub TXT_SECCION_SECCIONES_TextChanged(sender As Object, e As EventArgs) Handles TXT_SECCION_SECCIONES.TextChanged
        VALIDA_LLENO()
    End Sub


    Private Sub CB_BÚSQUEDA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_BÚSQUEDA.SelectedIndexChanged

    End Sub
End Class