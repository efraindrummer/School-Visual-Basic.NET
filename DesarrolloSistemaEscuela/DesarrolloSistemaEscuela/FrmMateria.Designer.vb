<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMateria
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
        Me.LblNumMateria = New System.Windows.Forms.Label()
        Me.TxtidMateria = New System.Windows.Forms.TextBox()
        Me.LblNomMateria = New System.Windows.Forms.Label()
        Me.TxtNombreMateria = New System.Windows.Forms.TextBox()
        Me.BtnVerificarVacios = New System.Windows.Forms.Button()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.DgvMateria = New System.Windows.Forms.DataGridView()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.BtnConsultaGeneralMateria = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBuscarMateria = New System.Windows.Forms.TextBox()
        CType(Me.DgvMateria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNumMateria
        '
        Me.LblNumMateria.AutoSize = True
        Me.LblNumMateria.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumMateria.Location = New System.Drawing.Point(23, 43)
        Me.LblNumMateria.Name = "LblNumMateria"
        Me.LblNumMateria.Size = New System.Drawing.Size(78, 19)
        Me.LblNumMateria.TabIndex = 0
        Me.LblNumMateria.Text = "Id Materia: "
        '
        'TxtidMateria
        '
        Me.TxtidMateria.Location = New System.Drawing.Point(168, 44)
        Me.TxtidMateria.Name = "TxtidMateria"
        Me.TxtidMateria.Size = New System.Drawing.Size(160, 20)
        Me.TxtidMateria.TabIndex = 1
        '
        'LblNomMateria
        '
        Me.LblNomMateria.AutoSize = True
        Me.LblNomMateria.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNomMateria.Location = New System.Drawing.Point(23, 79)
        Me.LblNomMateria.Name = "LblNomMateria"
        Me.LblNomMateria.Size = New System.Drawing.Size(138, 19)
        Me.LblNomMateria.TabIndex = 2
        Me.LblNomMateria.Text = "Nombre de la Materia:"
        '
        'TxtNombreMateria
        '
        Me.TxtNombreMateria.Location = New System.Drawing.Point(168, 78)
        Me.TxtNombreMateria.Name = "TxtNombreMateria"
        Me.TxtNombreMateria.Size = New System.Drawing.Size(160, 20)
        Me.TxtNombreMateria.TabIndex = 3
        '
        'BtnVerificarVacios
        '
        Me.BtnVerificarVacios.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnVerificarVacios.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerificarVacios.Location = New System.Drawing.Point(365, 44)
        Me.BtnVerificarVacios.Name = "BtnVerificarVacios"
        Me.BtnVerificarVacios.Size = New System.Drawing.Size(122, 37)
        Me.BtnVerificarVacios.TabIndex = 4
        Me.BtnVerificarVacios.Text = "Verificar"
        Me.BtnVerificarVacios.UseVisualStyleBackColor = False
        '
        'BtnInsertar
        '
        Me.BtnInsertar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnInsertar.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsertar.Location = New System.Drawing.Point(27, 138)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(114, 42)
        Me.BtnInsertar.TabIndex = 5
        Me.BtnInsertar.Text = "Insertar"
        Me.BtnInsertar.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnActualizar.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Location = New System.Drawing.Point(147, 138)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(114, 42)
        Me.BtnActualizar.TabIndex = 6
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnEliminar.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(267, 138)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(114, 42)
        Me.BtnEliminar.TabIndex = 7
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'DgvMateria
        '
        Me.DgvMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMateria.Location = New System.Drawing.Point(27, 292)
        Me.DgvMateria.Name = "DgvMateria"
        Me.DgvMateria.Size = New System.Drawing.Size(474, 187)
        Me.DgvMateria.TabIndex = 8
        '
        'BtnConsultar
        '
        Me.BtnConsultar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnConsultar.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.Location = New System.Drawing.Point(387, 138)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(114, 42)
        Me.BtnConsultar.TabIndex = 9
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = False
        '
        'BtnConsultaGeneralMateria
        '
        Me.BtnConsultaGeneralMateria.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnConsultaGeneralMateria.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultaGeneralMateria.Location = New System.Drawing.Point(27, 186)
        Me.BtnConsultaGeneralMateria.Name = "BtnConsultaGeneralMateria"
        Me.BtnConsultaGeneralMateria.Size = New System.Drawing.Size(474, 40)
        Me.BtnConsultaGeneralMateria.TabIndex = 10
        Me.BtnConsultaGeneralMateria.Text = "Consulta General"
        Me.BtnConsultaGeneralMateria.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Buscar Materia:"
        '
        'TxtBuscarMateria
        '
        Me.TxtBuscarMateria.Location = New System.Drawing.Point(158, 257)
        Me.TxtBuscarMateria.Name = "TxtBuscarMateria"
        Me.TxtBuscarMateria.Size = New System.Drawing.Size(190, 20)
        Me.TxtBuscarMateria.TabIndex = 12
        Me.TxtBuscarMateria.Text = "Escriba la materia"
        '
        'FrmMateria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(519, 505)
        Me.Controls.Add(Me.TxtBuscarMateria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnConsultaGeneralMateria)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.DgvMateria)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(Me.BtnVerificarVacios)
        Me.Controls.Add(Me.TxtNombreMateria)
        Me.Controls.Add(Me.LblNomMateria)
        Me.Controls.Add(Me.TxtidMateria)
        Me.Controls.Add(Me.LblNumMateria)
        Me.Name = "FrmMateria"
        Me.Text = "FrmMateria"
        CType(Me.DgvMateria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNumMateria As Label
    Friend WithEvents TxtidMateria As TextBox
    Friend WithEvents LblNomMateria As Label
    Friend WithEvents TxtNombreMateria As TextBox
    Friend WithEvents BtnVerificarVacios As Button
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents DgvMateria As DataGridView
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents BtnConsultaGeneralMateria As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBuscarMateria As TextBox
End Class
