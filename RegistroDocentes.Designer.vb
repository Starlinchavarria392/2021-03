<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistroDocentes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroDocentes))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NUEVO = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GUARDAR = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ELIMINAR = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BUSCAR = New System.Windows.Forms.ToolStripLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.L = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MC = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MC_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.BUSCO = New System.Windows.Forms.MaskedTextBox()
        Me.R_TEL = New System.Windows.Forms.RadioButton()
        Me.R_AP1 = New System.Windows.Forms.RadioButton()
        Me.R_NOMBRE = New System.Windows.Forms.RadioButton()
        Me.R_IDENTIFICACION = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FOTO = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.FOTOGRAFIA = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.P2 = New System.Windows.Forms.TextBox()
        Me.TEL = New System.Windows.Forms.MaskedTextBox()
        Me.FN = New System.Windows.Forms.DateTimePicker()
        Me.P1 = New System.Windows.Forms.TextBox()
        Me.NOMBRE = New System.Windows.Forms.TextBox()
        Me.IDENTIFICACION = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ABRIR = New System.Windows.Forms.OpenFileDialog()
        Me.PR = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MC.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.FOTO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NUEVO, Me.ToolStripSeparator1, Me.GUARDAR, Me.ToolStripSeparator2, Me.ELIMINAR, Me.ToolStripSeparator3, Me.BUSCAR})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(556, 25)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NUEVO
        '
        Me.NUEVO.Image = CType(resources.GetObject("NUEVO.Image"), System.Drawing.Image)
        Me.NUEVO.Name = "NUEVO"
        Me.NUEVO.Size = New System.Drawing.Size(62, 22)
        Me.NUEVO.Text = "Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'GUARDAR
        '
        Me.GUARDAR.Image = CType(resources.GetObject("GUARDAR.Image"), System.Drawing.Image)
        Me.GUARDAR.Name = "GUARDAR"
        Me.GUARDAR.Size = New System.Drawing.Size(69, 22)
        Me.GUARDAR.Text = "Guardar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ELIMINAR
        '
        Me.ELIMINAR.Enabled = False
        Me.ELIMINAR.Image = CType(resources.GetObject("ELIMINAR.Image"), System.Drawing.Image)
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.Size = New System.Drawing.Size(70, 22)
        Me.ELIMINAR.Text = "Eliminar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BUSCAR
        '
        Me.BUSCAR.Enabled = False
        Me.BUSCAR.Image = CType(resources.GetObject("BUSCAR.Image"), System.Drawing.Image)
        Me.BUSCAR.Name = "BUSCAR"
        Me.BUSCAR.Size = New System.Drawing.Size(62, 22)
        Me.BUSCAR.Text = "Buscar"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.L)
        Me.GroupBox3.Controls.Add(Me.BUSCO)
        Me.GroupBox3.Controls.Add(Me.R_TEL)
        Me.GroupBox3.Controls.Add(Me.R_AP1)
        Me.GroupBox3.Controls.Add(Me.R_NOMBRE)
        Me.GroupBox3.Controls.Add(Me.R_IDENTIFICACION)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 218)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(549, 288)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Búsqueda"
        '
        'L
        '
        Me.L.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.L.ContextMenuStrip = Me.MC
        Me.L.FullRowSelect = True
        Me.L.GridLines = True
        Me.L.HideSelection = False
        Me.L.Location = New System.Drawing.Point(19, 70)
        Me.L.Margin = New System.Windows.Forms.Padding(2)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(520, 216)
        Me.L.TabIndex = 6
        Me.L.UseCompatibleStateImageBehavior = False
        Me.L.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Identificacion"
        Me.ColumnHeader2.Width = 92
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nombre"
        Me.ColumnHeader3.Width = 66
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Primer Apellido"
        Me.ColumnHeader4.Width = 94
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Segundo Apellido"
        Me.ColumnHeader5.Width = 114
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Nacimiento"
        Me.ColumnHeader6.Width = 68
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Telefono Movil"
        Me.ColumnHeader7.Width = 175
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
        Me.MC.Size = New System.Drawing.Size(181, 48)
        '
        'MC_ELIMINAR
        '
        Me.MC_ELIMINAR.Enabled = False
        Me.MC_ELIMINAR.Image = CType(resources.GetObject("MC_ELIMINAR.Image"), System.Drawing.Image)
        Me.MC_ELIMINAR.Name = "MC_ELIMINAR"
        Me.MC_ELIMINAR.Size = New System.Drawing.Size(180, 22)
        Me.MC_ELIMINAR.Text = "Eliminar"
        '
        'BUSCO
        '
        Me.BUSCO.Location = New System.Drawing.Point(360, 41)
        Me.BUSCO.Margin = New System.Windows.Forms.Padding(2)
        Me.BUSCO.Mask = "9999-9999"
        Me.BUSCO.Name = "BUSCO"
        Me.BUSCO.Size = New System.Drawing.Size(179, 20)
        Me.BUSCO.TabIndex = 5
        '
        'R_TEL
        '
        Me.R_TEL.AutoSize = True
        Me.R_TEL.Checked = True
        Me.R_TEL.Location = New System.Drawing.Point(265, 41)
        Me.R_TEL.Margin = New System.Windows.Forms.Padding(2)
        Me.R_TEL.Name = "R_TEL"
        Me.R_TEL.Size = New System.Drawing.Size(95, 17)
        Me.R_TEL.TabIndex = 4
        Me.R_TEL.TabStop = True
        Me.R_TEL.Text = "Telefono Movil"
        Me.R_TEL.UseVisualStyleBackColor = True
        '
        'R_AP1
        '
        Me.R_AP1.AutoSize = True
        Me.R_AP1.Location = New System.Drawing.Point(167, 41)
        Me.R_AP1.Margin = New System.Windows.Forms.Padding(2)
        Me.R_AP1.Name = "R_AP1"
        Me.R_AP1.Size = New System.Drawing.Size(94, 17)
        Me.R_AP1.TabIndex = 3
        Me.R_AP1.Text = "Primer Apellido"
        Me.R_AP1.UseVisualStyleBackColor = True
        '
        'R_NOMBRE
        '
        Me.R_NOMBRE.AutoSize = True
        Me.R_NOMBRE.Location = New System.Drawing.Point(104, 41)
        Me.R_NOMBRE.Margin = New System.Windows.Forms.Padding(2)
        Me.R_NOMBRE.Name = "R_NOMBRE"
        Me.R_NOMBRE.Size = New System.Drawing.Size(62, 17)
        Me.R_NOMBRE.TabIndex = 2
        Me.R_NOMBRE.Text = "Nombre"
        Me.R_NOMBRE.UseVisualStyleBackColor = True
        '
        'R_IDENTIFICACION
        '
        Me.R_IDENTIFICACION.AutoSize = True
        Me.R_IDENTIFICACION.Location = New System.Drawing.Point(16, 41)
        Me.R_IDENTIFICACION.Margin = New System.Windows.Forms.Padding(2)
        Me.R_IDENTIFICACION.Name = "R_IDENTIFICACION"
        Me.R_IDENTIFICACION.Size = New System.Drawing.Size(88, 17)
        Me.R_IDENTIFICACION.TabIndex = 1
        Me.R_IDENTIFICACION.Text = "Identificacion"
        Me.R_IDENTIFICACION.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 18)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Criterio de Busqueda"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.FOTO)
        Me.GroupBox2.Controls.Add(Me.FOTOGRAFIA)
        Me.GroupBox2.Location = New System.Drawing.Point(378, 23)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(171, 192)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fotografia del docente"
        '
        'FOTO
        '
        Me.FOTO.Image = CType(resources.GetObject("FOTO.Image"), System.Drawing.Image)
        Me.FOTO.ImageRotate = 0!
        Me.FOTO.Location = New System.Drawing.Point(10, 18)
        Me.FOTO.Name = "FOTO"
        Me.FOTO.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.FOTO.ShadowDecoration.Parent = Me.FOTO
        Me.FOTO.Size = New System.Drawing.Size(143, 145)
        Me.FOTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FOTO.TabIndex = 13
        Me.FOTO.TabStop = False
        '
        'FOTOGRAFIA
        '
        Me.FOTOGRAFIA.Location = New System.Drawing.Point(19, 167)
        Me.FOTOGRAFIA.Margin = New System.Windows.Forms.Padding(2)
        Me.FOTOGRAFIA.Name = "FOTOGRAFIA"
        Me.FOTOGRAFIA.Size = New System.Drawing.Size(134, 23)
        Me.FOTOGRAFIA.TabIndex = 12
        Me.FOTOGRAFIA.Text = "Fotografia"
        Me.FOTOGRAFIA.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.P2)
        Me.GroupBox4.Controls.Add(Me.TEL)
        Me.GroupBox4.Controls.Add(Me.FN)
        Me.GroupBox4.Controls.Add(Me.P1)
        Me.GroupBox4.Controls.Add(Me.NOMBRE)
        Me.GroupBox4.Controls.Add(Me.IDENTIFICACION)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 22)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(364, 193)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos del docente"
        '
        'P2
        '
        Me.P2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.P2.Location = New System.Drawing.Point(150, 97)
        Me.P2.Margin = New System.Windows.Forms.Padding(2)
        Me.P2.Name = "P2"
        Me.P2.Size = New System.Drawing.Size(211, 20)
        Me.P2.TabIndex = 11
        '
        'TEL
        '
        Me.TEL.Location = New System.Drawing.Point(150, 151)
        Me.TEL.Margin = New System.Windows.Forms.Padding(2)
        Me.TEL.Mask = "9999-9999"
        Me.TEL.Name = "TEL"
        Me.TEL.Size = New System.Drawing.Size(76, 20)
        Me.TEL.TabIndex = 10
        '
        'FN
        '
        Me.FN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FN.Location = New System.Drawing.Point(150, 122)
        Me.FN.Margin = New System.Windows.Forms.Padding(2)
        Me.FN.Name = "FN"
        Me.FN.Size = New System.Drawing.Size(97, 20)
        Me.FN.TabIndex = 9
        '
        'P1
        '
        Me.P1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.P1.Location = New System.Drawing.Point(150, 74)
        Me.P1.Margin = New System.Windows.Forms.Padding(2)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(211, 20)
        Me.P1.TabIndex = 8
        '
        'NOMBRE
        '
        Me.NOMBRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NOMBRE.Location = New System.Drawing.Point(150, 51)
        Me.NOMBRE.Margin = New System.Windows.Forms.Padding(2)
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.Size = New System.Drawing.Size(211, 20)
        Me.NOMBRE.TabIndex = 7
        '
        'IDENTIFICACION
        '
        Me.IDENTIFICACION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IDENTIFICACION.Location = New System.Drawing.Point(150, 28)
        Me.IDENTIFICACION.Margin = New System.Windows.Forms.Padding(2)
        Me.IDENTIFICACION.MaxLength = 20
        Me.IDENTIFICACION.Name = "IDENTIFICACION"
        Me.IDENTIFICACION.Size = New System.Drawing.Size(211, 20)
        Me.IDENTIFICACION.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 99)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Segundo Apellido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 122)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha de Nacimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 151)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Teléfono Movil"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 76)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Primer Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre completo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 31)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Identificacion"
        '
        'PR
        '
        Me.PR.BorderRadius = 10
        Me.PR.Location = New System.Drawing.Point(297, 2)
        Me.PR.Name = "PR"
        Me.PR.ShadowDecoration.Parent = Me.PR
        Me.PR.Size = New System.Drawing.Size(252, 20)
        Me.PR.TabIndex = 11
        Me.PR.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.PR.Visible = False
        '
        'RegistroDocentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 515)
        Me.Controls.Add(Me.PR)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "RegistroDocentes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Regsitro de docentes"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MC.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.FOTO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NUEVO As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents GUARDAR As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ELIMINAR As ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents BUSCAR As ToolStripLabel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents L As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents BUSCO As MaskedTextBox
    Friend WithEvents R_TEL As RadioButton
    Friend WithEvents R_AP1 As RadioButton
    Friend WithEvents R_NOMBRE As RadioButton
    Friend WithEvents R_IDENTIFICACION As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents FOTOGRAFIA As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents P2 As TextBox
    Friend WithEvents TEL As MaskedTextBox
    Friend WithEvents FN As DateTimePicker
    Friend WithEvents P1 As TextBox
    Friend WithEvents NOMBRE As TextBox
    Friend WithEvents IDENTIFICACION As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ABRIR As OpenFileDialog
    Friend WithEvents MC As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MC_ELIMINAR As ToolStripMenuItem
    Friend WithEvents PR As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents FOTO As Guna.UI2.WinForms.Guna2CirclePictureBox
End Class
