<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroSecciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroSecciones))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CB_NIVEL_SECCIONES = New System.Windows.Forms.ComboBox()
        Me.TXT_SECCION_SECCIONES = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LV_SECCIONES = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CB_BÚSQUEDA = New System.Windows.Forms.ComboBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.NUEVO = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.GUARDAR = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ELIMINAR = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BUSCAR = New System.Windows.Forms.ToolStripLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CB_NIVEL_SECCIONES)
        Me.GroupBox1.Controls.Add(Me.TXT_SECCION_SECCIONES)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 24)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(288, 57)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Seccion"
        '
        'CB_NIVEL_SECCIONES
        '
        Me.CB_NIVEL_SECCIONES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_NIVEL_SECCIONES.FormattingEnabled = True
        Me.CB_NIVEL_SECCIONES.Location = New System.Drawing.Point(51, 22)
        Me.CB_NIVEL_SECCIONES.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CB_NIVEL_SECCIONES.Name = "CB_NIVEL_SECCIONES"
        Me.CB_NIVEL_SECCIONES.Size = New System.Drawing.Size(72, 21)
        Me.CB_NIVEL_SECCIONES.TabIndex = 3
        '
        'TXT_SECCION_SECCIONES
        '
        Me.TXT_SECCION_SECCIONES.Location = New System.Drawing.Point(184, 22)
        Me.TXT_SECCION_SECCIONES.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TXT_SECCION_SECCIONES.Name = "TXT_SECCION_SECCIONES"
        Me.TXT_SECCION_SECCIONES.Size = New System.Drawing.Size(66, 20)
        Me.TXT_SECCION_SECCIONES.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Seccion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nivel"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LV_SECCIONES)
        Me.GroupBox2.Controls.Add(Me.CB_BÚSQUEDA)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 86)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(288, 229)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda"
        '
        'LV_SECCIONES
        '
        Me.LV_SECCIONES.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.LV_SECCIONES.FullRowSelect = True
        Me.LV_SECCIONES.GridLines = True
        Me.LV_SECCIONES.HideSelection = False
        Me.LV_SECCIONES.Location = New System.Drawing.Point(20, 66)
        Me.LV_SECCIONES.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LV_SECCIONES.Name = "LV_SECCIONES"
        Me.LV_SECCIONES.Size = New System.Drawing.Size(268, 159)
        Me.LV_SECCIONES.TabIndex = 5
        Me.LV_SECCIONES.UseCompatibleStateImageBehavior = False
        Me.LV_SECCIONES.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ID"
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nivel"
        Me.ColumnHeader1.Width = 186
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Seccion"
        Me.ColumnHeader2.Width = 115
        '
        'CB_BÚSQUEDA
        '
        Me.CB_BÚSQUEDA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_BÚSQUEDA.FormattingEnabled = True
        Me.CB_BÚSQUEDA.Location = New System.Drawing.Point(133, 41)
        Me.CB_BÚSQUEDA.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CB_BÚSQUEDA.Name = "CB_BÚSQUEDA"
        Me.CB_BÚSQUEDA.Size = New System.Drawing.Size(118, 21)
        Me.CB_BÚSQUEDA.TabIndex = 4
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(69, 43)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(64, 17)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Seccion"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(20, 43)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(49, 17)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Nivel"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 26)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Criterio de busqueda"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NUEVO, Me.ToolStripSeparator4, Me.GUARDAR, Me.ToolStripSeparator5, Me.ELIMINAR, Me.ToolStripSeparator6, Me.BUSCAR})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(309, 25)
        Me.ToolStrip2.TabIndex = 8
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
        'RegistroSecciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 331)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RegistroSecciones"
        Me.Text = "Registro Secciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CB_NIVEL_SECCIONES As ComboBox
    Friend WithEvents TXT_SECCION_SECCIONES As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LV_SECCIONES As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents CB_BÚSQUEDA As ComboBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents NUEVO As ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents GUARDAR As ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ELIMINAR As ToolStripLabel
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents BUSCAR As ToolStripLabel
End Class
