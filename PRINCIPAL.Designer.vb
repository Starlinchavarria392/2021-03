<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRINCIPAL
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PRINCIPAL))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.M_PRINCIPAL_REGISTRO = New System.Windows.Forms.ToolStripMenuItem()
        Me.M_HORARIO = New System.Windows.Forms.ToolStripMenuItem()
        Me.M_SECCIONES = New System.Windows.Forms.ToolStripMenuItem()
        Me.M_ASIGNATURA = New System.Windows.Forms.ToolStripMenuItem()
        Me.M_DOCENTE = New System.Windows.Forms.ToolStripMenuItem()
        Me.M_ESTUDIANTES = New System.Windows.Forms.ToolStripMenuItem()
        Me.EvaluacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RendimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroAcademicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.M_PRINCIPAL_REGISTRO, Me.RendimientoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(788, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'M_PRINCIPAL_REGISTRO
        '
        Me.M_PRINCIPAL_REGISTRO.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.M_HORARIO, Me.M_SECCIONES, Me.M_ASIGNATURA, Me.M_DOCENTE, Me.M_ESTUDIANTES, Me.EvaluacionToolStripMenuItem})
        Me.M_PRINCIPAL_REGISTRO.Image = CType(resources.GetObject("M_PRINCIPAL_REGISTRO.Image"), System.Drawing.Image)
        Me.M_PRINCIPAL_REGISTRO.Name = "M_PRINCIPAL_REGISTRO"
        Me.M_PRINCIPAL_REGISTRO.Size = New System.Drawing.Size(82, 24)
        Me.M_PRINCIPAL_REGISTRO.Text = "Registro"
        '
        'M_HORARIO
        '
        Me.M_HORARIO.Image = CType(resources.GetObject("M_HORARIO.Image"), System.Drawing.Image)
        Me.M_HORARIO.Name = "M_HORARIO"
        Me.M_HORARIO.Size = New System.Drawing.Size(184, 26)
        Me.M_HORARIO.Text = "Horario"
        Me.M_HORARIO.Visible = False
        '
        'M_SECCIONES
        '
        Me.M_SECCIONES.Image = CType(resources.GetObject("M_SECCIONES.Image"), System.Drawing.Image)
        Me.M_SECCIONES.Name = "M_SECCIONES"
        Me.M_SECCIONES.Size = New System.Drawing.Size(184, 26)
        Me.M_SECCIONES.Text = "Secciones"
        Me.M_SECCIONES.Visible = False
        '
        'M_ASIGNATURA
        '
        Me.M_ASIGNATURA.Image = CType(resources.GetObject("M_ASIGNATURA.Image"), System.Drawing.Image)
        Me.M_ASIGNATURA.Name = "M_ASIGNATURA"
        Me.M_ASIGNATURA.Size = New System.Drawing.Size(184, 26)
        Me.M_ASIGNATURA.Text = "Asignatura"
        '
        'M_DOCENTE
        '
        Me.M_DOCENTE.Image = CType(resources.GetObject("M_DOCENTE.Image"), System.Drawing.Image)
        Me.M_DOCENTE.Name = "M_DOCENTE"
        Me.M_DOCENTE.Size = New System.Drawing.Size(184, 26)
        Me.M_DOCENTE.Text = "Docente"
        '
        'M_ESTUDIANTES
        '
        Me.M_ESTUDIANTES.Image = CType(resources.GetObject("M_ESTUDIANTES.Image"), System.Drawing.Image)
        Me.M_ESTUDIANTES.Name = "M_ESTUDIANTES"
        Me.M_ESTUDIANTES.Size = New System.Drawing.Size(184, 26)
        Me.M_ESTUDIANTES.Text = "Estudiantes"
        '
        'EvaluacionToolStripMenuItem
        '
        Me.EvaluacionToolStripMenuItem.Image = CType(resources.GetObject("EvaluacionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EvaluacionToolStripMenuItem.Name = "EvaluacionToolStripMenuItem"
        Me.EvaluacionToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.EvaluacionToolStripMenuItem.Text = "Evaluacion"
        '
        'RendimientoToolStripMenuItem
        '
        Me.RendimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroAcademicoToolStripMenuItem})
        Me.RendimientoToolStripMenuItem.Name = "RendimientoToolStripMenuItem"
        Me.RendimientoToolStripMenuItem.Size = New System.Drawing.Size(87, 24)
        Me.RendimientoToolStripMenuItem.Text = "Rendimiento"
        '
        'RegistroAcademicoToolStripMenuItem
        '
        Me.RegistroAcademicoToolStripMenuItem.Name = "RegistroAcademicoToolStripMenuItem"
        Me.RegistroAcademicoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RegistroAcademicoToolStripMenuItem.Text = "Registro academico"
        '
        'PRINCIPAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(788, 674)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "PRINCIPAL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Academico"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents M_PRINCIPAL_REGISTRO As ToolStripMenuItem
    Friend WithEvents M_HORARIO As ToolStripMenuItem
    Friend WithEvents M_SECCIONES As ToolStripMenuItem
    Friend WithEvents M_ASIGNATURA As ToolStripMenuItem
    Friend WithEvents M_DOCENTE As ToolStripMenuItem
    Friend WithEvents M_ESTUDIANTES As ToolStripMenuItem
    Friend WithEvents EvaluacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RendimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroAcademicoToolStripMenuItem As ToolStripMenuItem
End Class
