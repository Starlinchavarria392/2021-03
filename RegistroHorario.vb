Public Class RegistroHorario

    Dim T As DataSet
    Dim SQL As String

    Friend Sub VALIDA_LLENO()
        'Está en revision por dudas
        If DÍA.Text <> "" And CB_RECINTO.Text <> "" And CB_NÚMERO.Text <> "" And CB_BÚSQUEDA.Text <> "" Then
            GUARDAR.Enabled = True
            NUEVO.Enabled = True
        Else
            GUARDAR.Enabled = False
            NUEVO.Enabled = False
        End If

    End Sub
    Friend Sub REFRESCAR()
        T.Clear()
        LV_HORARIO.Items.Clear()
        SQL = "SELECT ID, DIA, INICIO, FIN, RECINTO, NUM_RECINTO FROM HORARIO"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                LV_HORARIO.Items.Add(T.Tables(0).Rows(I).Item(0))
                For J = 1 To 5
                    LV_HORARIO.Items(LV_HORARIO.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(I).Item(J))
                Next
            Next
        End If
    End Sub
    Friend Sub Nuevo1()
        DÍA.Clear()
        DT_INICIO.Value = Now
        DT_FIN.Value = Now
        CB_RECINTO.ResetText()
        CB_NÚMERO.ResetText()


    End Sub


    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles R_INICIO.CheckedChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub RegistroHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = PRINCIPAL
    End Sub

    Private Sub TXT_DÍA_TextChanged(sender As Object, e As EventArgs) Handles DÍA.TextChanged
        VALIDA_LLENO()
    End Sub

    Private Sub CB_RECINTO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_RECINTO.SelectedIndexChanged
        VALIDA_LLENO()
    End Sub

    Private Sub CB_NÚMERO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_NÚMERO.SelectedIndexChanged
        VALIDA_LLENO()
    End Sub

    Private Sub CB_BÚSQUEDA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_BÚSQUEDA.SelectedIndexChanged
        VALIDA_LLENO()
    End Sub
End Class