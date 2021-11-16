<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RENDIMIENTO
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
        Me.GUARDAR = New Guna.UI2.WinForms.Guna2Button()
        Me.NOTA = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CRITERIO = New System.Windows.Forms.Label()
        Me.ESTUDIANTE = New System.Windows.Forms.Label()
        Me.L2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.L = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CURSO = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GUARDAR
        '
        Me.GUARDAR.BorderRadius = 20
        Me.GUARDAR.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot
        Me.GUARDAR.CheckedState.Parent = Me.GUARDAR
        Me.GUARDAR.CustomImages.Parent = Me.GUARDAR
        Me.GUARDAR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.GUARDAR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.GUARDAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GUARDAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.GUARDAR.DisabledState.Parent = Me.GUARDAR
        Me.GUARDAR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GUARDAR.ForeColor = System.Drawing.Color.White
        Me.GUARDAR.HoverState.Parent = Me.GUARDAR
        Me.GUARDAR.Location = New System.Drawing.Point(207, 460)
        Me.GUARDAR.Margin = New System.Windows.Forms.Padding(2)
        Me.GUARDAR.Name = "GUARDAR"
        Me.GUARDAR.ShadowDecoration.Parent = Me.GUARDAR
        Me.GUARDAR.Size = New System.Drawing.Size(86, 37)
        Me.GUARDAR.TabIndex = 18
        Me.GUARDAR.Text = "Guardar"
        '
        'NOTA
        '
        Me.NOTA.Location = New System.Drawing.Point(122, 460)
        Me.NOTA.Margin = New System.Windows.Forms.Padding(2)
        Me.NOTA.Mask = "999"
        Me.NOTA.Name = "NOTA"
        Me.NOTA.Size = New System.Drawing.Size(30, 20)
        Me.NOTA.TabIndex = 17
        Me.NOTA.Text = "100"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 460)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nota obtenida:"
        '
        'CRITERIO
        '
        Me.CRITERIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CRITERIO.Location = New System.Drawing.Point(21, 412)
        Me.CRITERIO.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CRITERIO.Name = "CRITERIO"
        Me.CRITERIO.Size = New System.Drawing.Size(290, 24)
        Me.CRITERIO.TabIndex = 15
        Me.CRITERIO.Text = "Criterio de evaluación no elegido"
        Me.CRITERIO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ESTUDIANTE
        '
        Me.ESTUDIANTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ESTUDIANTE.Location = New System.Drawing.Point(27, 250)
        Me.ESTUDIANTE.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ESTUDIANTE.Name = "ESTUDIANTE"
        Me.ESTUDIANTE.Size = New System.Drawing.Size(290, 35)
        Me.ESTUDIANTE.TabIndex = 14
        Me.ESTUDIANTE.Text = "Sin estudiante"
        Me.ESTUDIANTE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L2
        '
        Me.L2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.L2.FullRowSelect = True
        Me.L2.GridLines = True
        Me.L2.HideSelection = False
        Me.L2.Location = New System.Drawing.Point(24, 287)
        Me.L2.Margin = New System.Windows.Forms.Padding(2)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(291, 123)
        Me.L2.TabIndex = 13
        Me.L2.UseCompatibleStateImageBehavior = False
        Me.L2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ID_DETALLE"
        Me.ColumnHeader7.Width = 0
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ID_MAESTRO"
        Me.ColumnHeader8.Width = 0
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Criterio de evaluación"
        Me.ColumnHeader9.Width = 253
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Valor"
        Me.ColumnHeader10.Width = 69
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Nota"
        '
        'L
        '
        Me.L.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader1})
        Me.L.FullRowSelect = True
        Me.L.GridLines = True
        Me.L.HideSelection = False
        Me.L.Location = New System.Drawing.Point(26, 42)
        Me.L.Margin = New System.Windows.Forms.Padding(2)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(289, 206)
        Me.L.TabIndex = 12
        Me.L.UseCompatibleStateImageBehavior = False
        Me.L.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ID-ESTUDIANTE"
        Me.ColumnHeader2.Width = 0
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nombre del estudiante"
        Me.ColumnHeader3.Width = 286
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Promedio"
        Me.ColumnHeader4.Width = 94
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID_RENDIMIENTO"
        Me.ColumnHeader1.Width = 0
        '
        'CURSO
        '
        Me.CURSO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CURSO.FormattingEnabled = True
        Me.CURSO.Location = New System.Drawing.Point(87, 6)
        Me.CURSO.Margin = New System.Windows.Forms.Padding(2)
        Me.CURSO.Name = "CURSO"
        Me.CURSO.Size = New System.Drawing.Size(228, 21)
        Me.CURSO.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Asignatura;"
        '
        'RENDIMIENTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 511)
        Me.Controls.Add(Me.GUARDAR)
        Me.Controls.Add(Me.NOTA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CRITERIO)
        Me.Controls.Add(Me.ESTUDIANTE)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.L)
        Me.Controls.Add(Me.CURSO)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Name = "RENDIMIENTO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RENDIMIENTO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GUARDAR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents NOTA As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CRITERIO As Label
    Friend WithEvents ESTUDIANTE As Label
    Friend WithEvents L2 As ListView
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents L As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents CURSO As ComboBox
    Friend WithEvents Label1 As Label
End Class
