<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroEvaluacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroEvaluacion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.COMPONENTE_EVALUACION = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VALOR_PORCENTUAL = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BUSCO = New System.Windows.Forms.ComboBox()
        Me.L = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MC = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MC_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.COMPONENTE = New System.Windows.Forms.RadioButton()
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
        Me.MC.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.COMPONENTE_EVALUACION)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.VALOR_PORCENTUAL)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 28)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(291, 104)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del componente evaluativo"
        '
        'COMPONENTE_EVALUACION
        '
        Me.COMPONENTE_EVALUACION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.COMPONENTE_EVALUACION.Location = New System.Drawing.Point(20, 76)
        Me.COMPONENTE_EVALUACION.Margin = New System.Windows.Forms.Padding(2)
        Me.COMPONENTE_EVALUACION.Name = "COMPONENTE_EVALUACION"
        Me.COMPONENTE_EVALUACION.Size = New System.Drawing.Size(260, 20)
        Me.COMPONENTE_EVALUACION.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre del componente evaluativo"
        '
        'VALOR_PORCENTUAL
        '
        Me.VALOR_PORCENTUAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VALOR_PORCENTUAL.FormattingEnabled = True
        Me.VALOR_PORCENTUAL.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100"})
        Me.VALOR_PORCENTUAL.Location = New System.Drawing.Point(106, 23)
        Me.VALOR_PORCENTUAL.Margin = New System.Windows.Forms.Padding(2)
        Me.VALOR_PORCENTUAL.Name = "VALOR_PORCENTUAL"
        Me.VALOR_PORCENTUAL.Size = New System.Drawing.Size(63, 21)
        Me.VALOR_PORCENTUAL.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor porcentual"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BUSCO)
        Me.GroupBox2.Controls.Add(Me.L)
        Me.GroupBox2.Controls.Add(Me.COMPONENTE)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 139)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(291, 234)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda"
        '
        'BUSCO
        '
        Me.BUSCO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BUSCO.FormattingEnabled = True
        Me.BUSCO.Location = New System.Drawing.Point(158, 37)
        Me.BUSCO.Name = "BUSCO"
        Me.BUSCO.Size = New System.Drawing.Size(121, 21)
        Me.BUSCO.TabIndex = 7
        '
        'L
        '
        Me.L.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.L.ContextMenuStrip = Me.MC
        Me.L.FullRowSelect = True
        Me.L.GridLines = True
        Me.L.HideSelection = False
        Me.L.Location = New System.Drawing.Point(20, 61)
        Me.L.Margin = New System.Windows.Forms.Padding(2)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(260, 169)
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
        Me.ColumnHeader2.Text = "Componente evaluativo"
        Me.ColumnHeader2.Width = 164
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Porcentaje"
        Me.ColumnHeader3.Width = 94
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
        'COMPONENTE
        '
        Me.COMPONENTE.AutoSize = True
        Me.COMPONENTE.Location = New System.Drawing.Point(20, 38)
        Me.COMPONENTE.Margin = New System.Windows.Forms.Padding(2)
        Me.COMPONENTE.Name = "COMPONENTE"
        Me.COMPONENTE.Size = New System.Drawing.Size(85, 17)
        Me.COMPONENTE.TabIndex = 4
        Me.COMPONENTE.TabStop = True
        Me.COMPONENTE.Text = "Componente"
        Me.COMPONENTE.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 19)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Criterio de busqueda"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NUEVO, Me.ToolStripSeparator4, Me.GUARDAR, Me.ToolStripSeparator5, Me.ELIMINAR, Me.ToolStripSeparator6, Me.BUSCAR})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(312, 25)
        Me.ToolStrip2.TabIndex = 4
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
        'RegistroEvaluacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 383)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RegistroEvaluacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Evaluacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MC.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents COMPONENTE_EVALUACION As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents VALOR_PORCENTUAL As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents L As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents COMPONENTE As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents NUEVO As ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents GUARDAR As ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ELIMINAR As ToolStripLabel
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents BUSCAR As ToolStripLabel
    Friend WithEvents BUSCO As ComboBox
    Friend WithEvents MC As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MC_ELIMINAR As ToolStripMenuItem
End Class
