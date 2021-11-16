Public Class PRINCIPAL
    Private Sub M_ESTUDIANTES_Click(sender As Object, e As EventArgs) Handles M_ESTUDIANTES.Click
        FRM_ESTUDIANTE.Show()
    End Sub

    Private Sub M_PRINCIPAL_REGISTRO_Click(sender As Object, e As EventArgs) Handles M_PRINCIPAL_REGISTRO.Click

    End Sub

    Private Sub PRINCIPAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
    End Sub

    Private Sub M_DOCENTE_Click(sender As Object, e As EventArgs) Handles M_DOCENTE.Click
        RegistroDocentes.Show()
    End Sub

    Private Sub M_ASIGNATURA_Click(sender As Object, e As EventArgs) Handles M_ASIGNATURA.Click
        RegistroAsignatura.Show()
    End Sub

    Private Sub EvaluacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EvaluacionToolStripMenuItem.Click
        RegistroEvaluacion.Show()
    End Sub

    Private Sub RendimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RendimientoToolStripMenuItem.Click

    End Sub

    Private Sub RegistroAcademicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroAcademicoToolStripMenuItem.Click
        RENDIMIENTO.Show()
    End Sub
End Class