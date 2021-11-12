<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistroAsignatura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroAsignatura))
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.NUEVO = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.GUARDAR = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ELIMINAR = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BUSCAR = New System.Windows.Forms.ToolStripLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.REGIDA = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NOTA = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DURACION = New System.Windows.Forms.MaskedTextBox()
        Me.MODALIDAD = New System.Windows.Forms.ComboBox()
        Me.NIVEL = New System.Windows.Forms.ComboBox()
        Me.NOMBRE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.NIVEL1 = New System.Windows.Forms.RadioButton()
        Me.L = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MC = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MC_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.BUSCO = New System.Windows.Forms.ComboBox()
        Me.MODALIDAD1 = New System.Windows.Forms.RadioButton()
        Me.NOMBRE1 = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MC.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NUEVO, Me.ToolStripSeparator4, Me.GUARDAR, Me.ToolStripSeparator5, Me.ELIMINAR, Me.ToolStripSeparator6, Me.BUSCAR})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(382, 25)
        Me.ToolStrip2.TabIndex = 9
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'NUEVO
        '
        Me.NUEVO.Image = CType(resources.GetObject("NUEVO.Image"), System.Drawing.Image)
        Me.NUEVO.Name = "NUEVO"
        Me.NUEVO.Size = New System.Drawing.Size(62, 22)
        Me.NUEVO.Text = "Nuevo"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'GUARDAR
        '
        Me.GUARDAR.Image = CType(resources.GetObject("GUARDAR.Image"), System.Drawing.Image)
        Me.GUARDAR.Name = "GUARDAR"
        Me.GUARDAR.Size = New System.Drawing.Size(69, 22)
        Me.GUARDAR.Text = "Guardar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ELIMINAR
        '
        Me.ELIMINAR.Enabled = False
        Me.ELIMINAR.Image = CType(resources.GetObject("ELIMINAR.Image"), System.Drawing.Image)
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.Size = New System.Drawing.Size(70, 22)
        Me.ELIMINAR.Text = "Eliminar"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'BUSCAR
        '
        Me.BUSCAR.Enabled = False
        Me.BUSCAR.Image = CType(resources.GetObject("BUSCAR.Image"), System.Drawing.Image)
        Me.BUSCAR.Name = "BUSCAR"
        Me.BUSCAR.Size = New System.Drawing.Size(62, 22)
        Me.BUSCAR.Text = "Buscar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.NOTA)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DURACION)
        Me.GroupBox1.Controls.Add(Me.MODALIDAD)
        Me.GroupBox1.Controls.Add(Me.NIVEL)
        Me.GroupBox1.Controls.Add(Me.NOMBRE)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 23)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(364, 152)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos la asignatura"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.REGIDA)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(201, 56)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(159, 53)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Modadlidad anual"
        '
        'REGIDA
        '
        Me.REGIDA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.REGIDA.FormattingEnabled = True
        Me.REGIDA.Items.AddRange(New Object() {"CUATRIMESTRE", "SEMESTRE"})
        Me.REGIDA.Location = New System.Drawing.Point(71, 22)
        Me.REGIDA.Margin = New System.Windows.Forms.Padding(2)
        Me.REGIDA.Name = "REGIDA"
        Me.REGIDA.Size = New System.Drawing.Size(84, 21)
        Me.REGIDA.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 22)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Regida por"
        '
        'NOTA
        '
        Me.NOTA.Location = New System.Drawing.Point(310, 123)
        Me.NOTA.Margin = New System.Windows.Forms.Padding(2)
        Me.NOTA.Mask = "99"
        Me.NOTA.Name = "NOTA"
        Me.NOTA.Size = New System.Drawing.Size(24, 20)
        Me.NOTA.TabIndex = 10
        Me.NOTA.ValidatingType = GetType(Integer)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(206, 123)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Nota de aprobación"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(115, 87)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "semanas"
        '
        'DURACION
        '
        Me.DURACION.Location = New System.Drawing.Point(84, 84)
        Me.DURACION.Margin = New System.Windows.Forms.Padding(2)
        Me.DURACION.Mask = "99"
        Me.DURACION.Name = "DURACION"
        Me.DURACION.Size = New System.Drawing.Size(27, 20)
        Me.DURACION.TabIndex = 7
        Me.DURACION.ValidatingType = GetType(Integer)
        '
        'MODALIDAD
        '
        Me.MODALIDAD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MODALIDAD.FormattingEnabled = True
        Me.MODALIDAD.Items.AddRange(New Object() {"PRESENCIAL", "EN LINEA"})
        Me.MODALIDAD.Location = New System.Drawing.Point(84, 117)
        Me.MODALIDAD.Margin = New System.Windows.Forms.Padding(2)
        Me.MODALIDAD.Name = "MODALIDAD"
        Me.MODALIDAD.Size = New System.Drawing.Size(74, 21)
        Me.MODALIDAD.TabIndex = 6
        '
        'NIVEL
        '
        Me.NIVEL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NIVEL.FormattingEnabled = True
        Me.NIVEL.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.NIVEL.Location = New System.Drawing.Point(84, 50)
        Me.NIVEL.Margin = New System.Windows.Forms.Padding(2)
        Me.NIVEL.Name = "NIVEL"
        Me.NIVEL.Size = New System.Drawing.Size(74, 21)
        Me.NIVEL.TabIndex = 5
        '
        'NOMBRE
        '
        Me.NOMBRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NOMBRE.Location = New System.Drawing.Point(83, 21)
        Me.NOMBRE.Margin = New System.Windows.Forms.Padding(2)
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.Size = New System.Drawing.Size(277, 20)
        Me.NOMBRE.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 123)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Modalidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 89)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Duración"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nivel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.NIVEL1)
        Me.GroupBox3.Controls.Add(Me.L)
        Me.GroupBox3.Controls.Add(Me.BUSCO)
        Me.GroupBox3.Controls.Add(Me.MODALIDAD1)
        Me.GroupBox3.Controls.Add(Me.NOMBRE1)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 179)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(364, 221)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Busqueda"
        '
        'NIVEL1
        '
        Me.NIVEL1.AutoSize = True
        Me.NIVEL1.Location = New System.Drawing.Point(84, 39)
        Me.NIVEL1.Margin = New System.Windows.Forms.Padding(2)
        Me.NIVEL1.Name = "NIVEL1"
        Me.NIVEL1.Size = New System.Drawing.Size(49, 17)
        Me.NIVEL1.TabIndex = 6
        Me.NIVEL1.TabStop = True
        Me.NIVEL1.Text = "Nivel"
        Me.NIVEL1.UseVisualStyleBackColor = True
        '
        'L
        '
        Me.L.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.L.ContextMenuStrip = Me.MC
        Me.L.FullRowSelect = True
        Me.L.GridLines = True
        Me.L.HideSelection = False
        Me.L.Location = New System.Drawing.Point(20, 58)
        Me.L.Margin = New System.Windows.Forms.Padding(2)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(341, 163)
        Me.L.TabIndex = 5
        Me.L.UseCompatibleStateImageBehavior = False
        Me.L.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ID"
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nombre"
        Me.ColumnHeader1.Width = 116
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nivel"
        Me.ColumnHeader2.Width = 63
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Semana"
        Me.ColumnHeader4.Width = 83
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Modalidad"
        Me.ColumnHeader5.Width = 101
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Regida"
        Me.ColumnHeader6.Width = 114
        '
        'MC
        '
        Me.MC.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MC_ELIMINAR})
        Me.MC.Name = "MC"
        Me.MC.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MC.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.MC.RenderStyle.ColorTable = Nothing
        Me.MC.RenderStyle.RoundedEdges = True
        Me.MC.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.MC.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MC.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.MC.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.MC.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.MC.ShowItemToolTips = False
        Me.MC.Size = New System.Drawing.Size(118, 26)
        '
        'MC_ELIMINAR
        '
        Me.MC_ELIMINAR.Enabled = False
        Me.MC_ELIMINAR.Image = CType(resources.GetObject("MC_ELIMINAR.Image"), System.Drawing.Image)
        Me.MC_ELIMINAR.Name = "MC_ELIMINAR"
        Me.MC_ELIMINAR.Size = New System.Drawing.Size(117, 22)
        Me.MC_ELIMINAR.Text = "Eliminar"
        '
        'BUSCO
        '
        Me.BUSCO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BUSCO.FormattingEnabled = True
        Me.BUSCO.Location = New System.Drawing.Point(236, 36)
        Me.BUSCO.Margin = New System.Windows.Forms.Padding(2)
        Me.BUSCO.Name = "BUSCO"
        Me.BUSCO.Size = New System.Drawing.Size(126, 21)
        Me.BUSCO.TabIndex = 4
        '
        'MODALIDAD1
        '
        Me.MODALIDAD1.AutoSize = True
        Me.MODALIDAD1.Location = New System.Drawing.Point(134, 39)
        Me.MODALIDAD1.Margin = New System.Windows.Forms.Padding(2)
        Me.MODALIDAD1.Name = "MODALIDAD1"
        Me.MODALIDAD1.Size = New System.Drawing.Size(74, 17)
        Me.MODALIDAD1.TabIndex = 3
        Me.MODALIDAD1.TabStop = True
        Me.MODALIDAD1.Text = "Modalidad"
        Me.MODALIDAD1.UseVisualStyleBackColor = True
        '
        'NOMBRE1
        '
        Me.NOMBRE1.AutoSize = True
        Me.NOMBRE1.Location = New System.Drawing.Point(20, 39)
        Me.NOMBRE1.Margin = New System.Windows.Forms.Padding(2)
        Me.NOMBRE1.Name = "NOMBRE1"
        Me.NOMBRE1.Size = New System.Drawing.Size(62, 17)
        Me.NOMBRE1.TabIndex = 2
        Me.NOMBRE1.TabStop = True
        Me.NOMBRE1.Text = "Nombre"
        Me.NOMBRE1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 21)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Criterio de busqueda"
        '
        'RegistroAsignatura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 409)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "RegistroAsignatura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de asignatura"
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MC.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents NUEVO As ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents GUARDAR As ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ELIMINAR As ToolStripLabel
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents BUSCAR As ToolStripLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NOMBRE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents REGIDA As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents NOTA As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DURACION As MaskedTextBox
    Friend WithEvents MODALIDAD As ComboBox
    Friend WithEvents NIVEL As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents NIVEL1 As RadioButton
    Friend WithEvents L As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents BUSCO As ComboBox
    Friend WithEvents MODALIDAD1 As RadioButton
    Friend WithEvents NOMBRE1 As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents MC As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MC_ELIMINAR As ToolStripMenuItem
End Class
