<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistroHorario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroHorario))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LV_HORARIO = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CB_BÚSQUEDA = New System.Windows.Forms.ComboBox()
        Me.R_RECINTO = New System.Windows.Forms.RadioButton()
        Me.R_INICIO = New System.Windows.Forms.RadioButton()
        Me.R_DÍA = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CB_NÚMERO = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CB_RECINTO = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DT_FIN = New System.Windows.Forms.DateTimePicker()
        Me.DT_INICIO = New System.Windows.Forms.DateTimePicker()
        Me.DÍA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.NUEVO = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.GUARDAR = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ELIMINAR = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BUSCAR = New System.Windows.Forms.ToolStripLabel()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LV_HORARIO)
        Me.GroupBox2.Controls.Add(Me.CB_BÚSQUEDA)
        Me.GroupBox2.Controls.Add(Me.R_RECINTO)
        Me.GroupBox2.Controls.Add(Me.R_INICIO)
        Me.GroupBox2.Controls.Add(Me.R_DÍA)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(339, 240)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Búsquedad"
        '
        'LV_HORARIO
        '
        Me.LV_HORARIO.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.LV_HORARIO.FullRowSelect = True
        Me.LV_HORARIO.GridLines = True
        Me.LV_HORARIO.HideSelection = False
        Me.LV_HORARIO.Location = New System.Drawing.Point(23, 64)
        Me.LV_HORARIO.Name = "LV_HORARIO"
        Me.LV_HORARIO.Size = New System.Drawing.Size(311, 170)
        Me.LV_HORARIO.TabIndex = 9
        Me.LV_HORARIO.UseCompatibleStateImageBehavior = False
        Me.LV_HORARIO.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Día"
        Me.ColumnHeader1.Width = 67
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Inicio"
        Me.ColumnHeader2.Width = 86
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Fin"
        Me.ColumnHeader3.Width = 77
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Recinto"
        Me.ColumnHeader4.Width = 99
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Número"
        Me.ColumnHeader5.Width = 76
        '
        'CB_BÚSQUEDA
        '
        Me.CB_BÚSQUEDA.FormattingEnabled = True
        Me.CB_BÚSQUEDA.Location = New System.Drawing.Point(224, 31)
        Me.CB_BÚSQUEDA.Name = "CB_BÚSQUEDA"
        Me.CB_BÚSQUEDA.Size = New System.Drawing.Size(110, 21)
        Me.CB_BÚSQUEDA.TabIndex = 8
        '
        'R_RECINTO
        '
        Me.R_RECINTO.AutoSize = True
        Me.R_RECINTO.Location = New System.Drawing.Point(160, 32)
        Me.R_RECINTO.Name = "R_RECINTO"
        Me.R_RECINTO.Size = New System.Drawing.Size(62, 17)
        Me.R_RECINTO.TabIndex = 3
        Me.R_RECINTO.TabStop = True
        Me.R_RECINTO.Text = "Recinto"
        Me.R_RECINTO.UseVisualStyleBackColor = True
        '
        'R_INICIO
        '
        Me.R_INICIO.AutoSize = True
        Me.R_INICIO.Location = New System.Drawing.Point(68, 32)
        Me.R_INICIO.Name = "R_INICIO"
        Me.R_INICIO.Size = New System.Drawing.Size(90, 17)
        Me.R_INICIO.TabIndex = 2
        Me.R_INICIO.TabStop = True
        Me.R_INICIO.Text = "Hora de inicio"
        Me.R_INICIO.UseVisualStyleBackColor = True
        '
        'R_DÍA
        '
        Me.R_DÍA.AutoSize = True
        Me.R_DÍA.Location = New System.Drawing.Point(24, 32)
        Me.R_DÍA.Name = "R_DÍA"
        Me.R_DÍA.Size = New System.Drawing.Size(41, 17)
        Me.R_DÍA.TabIndex = 1
        Me.R_DÍA.TabStop = True
        Me.R_DÍA.Text = "Dia"
        Me.R_DÍA.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Criterio de búsqueda"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CB_NÚMERO)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CB_RECINTO)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DT_FIN)
        Me.GroupBox1.Controls.Add(Me.DT_INICIO)
        Me.GroupBox1.Controls.Add(Me.DÍA)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 105)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del horario"
        '
        'CB_NÚMERO
        '
        Me.CB_NÚMERO.FormattingEnabled = True
        Me.CB_NÚMERO.Location = New System.Drawing.Point(243, 70)
        Me.CB_NÚMERO.Name = "CB_NÚMERO"
        Me.CB_NÚMERO.Size = New System.Drawing.Size(91, 21)
        Me.CB_NÚMERO.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(194, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Número"
        '
        'CB_RECINTO
        '
        Me.CB_RECINTO.FormattingEnabled = True
        Me.CB_RECINTO.Location = New System.Drawing.Point(86, 70)
        Me.CB_RECINTO.Name = "CB_RECINTO"
        Me.CB_RECINTO.Size = New System.Drawing.Size(102, 21)
        Me.CB_RECINTO.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(165, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Hora finalización"
        '
        'DT_FIN
        '
        Me.DT_FIN.CustomFormat = ""
        Me.DT_FIN.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DT_FIN.Location = New System.Drawing.Point(256, 46)
        Me.DT_FIN.Name = "DT_FIN"
        Me.DT_FIN.Size = New System.Drawing.Size(78, 20)
        Me.DT_FIN.TabIndex = 5
        Me.DT_FIN.Value = New Date(2021, 9, 21, 19, 41, 0, 0)
        '
        'DT_INICIO
        '
        Me.DT_INICIO.CustomFormat = ""
        Me.DT_INICIO.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DT_INICIO.Location = New System.Drawing.Point(86, 46)
        Me.DT_INICIO.Name = "DT_INICIO"
        Me.DT_INICIO.Size = New System.Drawing.Size(73, 20)
        Me.DT_INICIO.TabIndex = 4
        Me.DT_INICIO.Value = New Date(2021, 9, 21, 19, 41, 0, 0)
        '
        'DÍA
        '
        Me.DÍA.Location = New System.Drawing.Point(86, 21)
        Me.DÍA.Name = "DÍA"
        Me.DÍA.Size = New System.Drawing.Size(248, 20)
        Me.DÍA.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Recinto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hora inicio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Día"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NUEVO, Me.ToolStripSeparator4, Me.GUARDAR, Me.ToolStripSeparator5, Me.ELIMINAR, Me.ToolStripSeparator6, Me.BUSCAR})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(358, 25)
        Me.ToolStrip2.TabIndex = 7
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'NUEVO
        '
        Me.NUEVO.Enabled = False
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
        Me.GUARDAR.Enabled = False
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
        'RegistroHorario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 387)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "RegistroHorario"
        Me.Text = "Registro de Horario"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LV_HORARIO As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents CB_BÚSQUEDA As ComboBox
    Friend WithEvents R_RECINTO As RadioButton
    Friend WithEvents R_INICIO As RadioButton
    Friend WithEvents R_DÍA As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CB_NÚMERO As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CB_RECINTO As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DT_FIN As DateTimePicker
    Friend WithEvents DT_INICIO As DateTimePicker
    Friend WithEvents DÍA As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents NUEVO As ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents GUARDAR As ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ELIMINAR As ToolStripLabel
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents BUSCAR As ToolStripLabel
End Class
