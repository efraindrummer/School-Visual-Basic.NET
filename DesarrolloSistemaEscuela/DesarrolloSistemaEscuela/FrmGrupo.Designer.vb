<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGrupo
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
        Me.LblNumGrupo = New System.Windows.Forms.Label()
        Me.LblGrupo = New System.Windows.Forms.Label()
        Me.TxtIdGrupo = New System.Windows.Forms.TextBox()
        Me.TxtGrupo = New System.Windows.Forms.TextBox()
        Me.BtnVerificaVacios = New System.Windows.Forms.Button()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.DgvGrupo = New System.Windows.Forms.DataGridView()
        Me.BtnConsultaGeneralGrupo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBuscarGrupo = New System.Windows.Forms.TextBox()
        CType(Me.DgvGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNumGrupo
        '
        Me.LblNumGrupo.AutoSize = True
        Me.LblNumGrupo.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumGrupo.Location = New System.Drawing.Point(31, 33)
        Me.LblNumGrupo.Name = "LblNumGrupo"
        Me.LblNumGrupo.Size = New System.Drawing.Size(111, 19)
        Me.LblNumGrupo.TabIndex = 0
        Me.LblNumGrupo.Text = "Numero de grupo:"
        '
        'LblGrupo
        '
        Me.LblGrupo.AutoSize = True
        Me.LblGrupo.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGrupo.Location = New System.Drawing.Point(31, 70)
        Me.LblGrupo.Name = "LblGrupo"
        Me.LblGrupo.Size = New System.Drawing.Size(45, 19)
        Me.LblGrupo.TabIndex = 1
        Me.LblGrupo.Text = "Grupo:"
        '
        'TxtIdGrupo
        '
        Me.TxtIdGrupo.Location = New System.Drawing.Point(159, 33)
        Me.TxtIdGrupo.Name = "TxtIdGrupo"
        Me.TxtIdGrupo.Size = New System.Drawing.Size(143, 20)
        Me.TxtIdGrupo.TabIndex = 2
        '
        'TxtGrupo
        '
        Me.TxtGrupo.Location = New System.Drawing.Point(159, 69)
        Me.TxtGrupo.Name = "TxtGrupo"
        Me.TxtGrupo.Size = New System.Drawing.Size(143, 20)
        Me.TxtGrupo.TabIndex = 3
        '
        'BtnVerificaVacios
        '
        Me.BtnVerificaVacios.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnVerificaVacios.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerificaVacios.Location = New System.Drawing.Point(308, 43)
        Me.BtnVerificaVacios.Name = "BtnVerificaVacios"
        Me.BtnVerificaVacios.Size = New System.Drawing.Size(92, 36)
        Me.BtnVerificaVacios.TabIndex = 4
        Me.BtnVerificaVacios.Text = "Verificar"
        Me.BtnVerificaVacios.UseVisualStyleBackColor = False
        '
        'BtnInsertar
        '
        Me.BtnInsertar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnInsertar.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsertar.Location = New System.Drawing.Point(12, 122)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(85, 36)
        Me.BtnInsertar.TabIndex = 5
        Me.BtnInsertar.Text = "Insertar"
        Me.BtnInsertar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnEliminar.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(194, 122)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(87, 37)
        Me.BtnEliminar.TabIndex = 6
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnConsultar
        '
        Me.BtnConsultar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnConsultar.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.Location = New System.Drawing.Point(287, 122)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(86, 37)
        Me.BtnConsultar.TabIndex = 7
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnActualizar.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Location = New System.Drawing.Point(103, 122)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(85, 37)
        Me.BtnActualizar.TabIndex = 8
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'DgvGrupo
        '
        Me.DgvGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvGrupo.Location = New System.Drawing.Point(35, 288)
        Me.DgvGrupo.Name = "DgvGrupo"
        Me.DgvGrupo.Size = New System.Drawing.Size(338, 150)
        Me.DgvGrupo.TabIndex = 9
        '
        'BtnConsultaGeneralGrupo
        '
        Me.BtnConsultaGeneralGrupo.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnConsultaGeneralGrupo.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultaGeneralGrupo.Location = New System.Drawing.Point(12, 165)
        Me.BtnConsultaGeneralGrupo.Name = "BtnConsultaGeneralGrupo"
        Me.BtnConsultaGeneralGrupo.Size = New System.Drawing.Size(361, 37)
        Me.BtnConsultaGeneralGrupo.TabIndex = 10
        Me.BtnConsultaGeneralGrupo.Text = "Consulta General"
        Me.BtnConsultaGeneralGrupo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Buscar Grupo:"
        '
        'TxtBuscarGrupo
        '
        Me.TxtBuscarGrupo.Location = New System.Drawing.Point(138, 234)
        Me.TxtBuscarGrupo.Name = "TxtBuscarGrupo"
        Me.TxtBuscarGrupo.Size = New System.Drawing.Size(164, 20)
        Me.TxtBuscarGrupo.TabIndex = 12
        Me.TxtBuscarGrupo.Text = "por Letra"
        '
        'FrmGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(408, 478)
        Me.Controls.Add(Me.TxtBuscarGrupo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnConsultaGeneralGrupo)
        Me.Controls.Add(Me.DgvGrupo)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(Me.BtnVerificaVacios)
        Me.Controls.Add(Me.TxtGrupo)
        Me.Controls.Add(Me.TxtIdGrupo)
        Me.Controls.Add(Me.LblGrupo)
        Me.Controls.Add(Me.LblNumGrupo)
        Me.Name = "FrmGrupo"
        Me.Text = "FrmGrupo"
        CType(Me.DgvGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNumGrupo As Label
    Friend WithEvents LblGrupo As Label
    Friend WithEvents TxtIdGrupo As TextBox
    Friend WithEvents TxtGrupo As TextBox
    Friend WithEvents BtnVerificaVacios As Button
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents DgvGrupo As DataGridView
    Friend WithEvents BtnConsultaGeneralGrupo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBuscarGrupo As TextBox
End Class
