<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCurso
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtId_curso = New System.Windows.Forms.TextBox()
        Me.TxtPeriodo = New System.Windows.Forms.TextBox()
        Me.CmbIdNumSalon = New System.Windows.Forms.ComboBox()
        Me.CmbIdMateria = New System.Windows.Forms.ComboBox()
        Me.BtnVerificar = New System.Windows.Forms.Button()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.DgvCurso = New System.Windows.Forms.DataGridView()
        Me.BtnConsultaGeneralCurso = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBuscarCurso = New System.Windows.Forms.TextBox()
        CType(Me.DgvCurso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero del curso:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Perido escolar:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Numero de salon:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Materia:"
        '
        'TxtId_curso
        '
        Me.TxtId_curso.Location = New System.Drawing.Point(207, 24)
        Me.TxtId_curso.Name = "TxtId_curso"
        Me.TxtId_curso.Size = New System.Drawing.Size(140, 20)
        Me.TxtId_curso.TabIndex = 4
        '
        'TxtPeriodo
        '
        Me.TxtPeriodo.Location = New System.Drawing.Point(207, 66)
        Me.TxtPeriodo.Name = "TxtPeriodo"
        Me.TxtPeriodo.Size = New System.Drawing.Size(140, 20)
        Me.TxtPeriodo.TabIndex = 5
        '
        'CmbIdNumSalon
        '
        Me.CmbIdNumSalon.FormattingEnabled = True
        Me.CmbIdNumSalon.Location = New System.Drawing.Point(207, 108)
        Me.CmbIdNumSalon.Name = "CmbIdNumSalon"
        Me.CmbIdNumSalon.Size = New System.Drawing.Size(140, 21)
        Me.CmbIdNumSalon.TabIndex = 6
        '
        'CmbIdMateria
        '
        Me.CmbIdMateria.FormattingEnabled = True
        Me.CmbIdMateria.Location = New System.Drawing.Point(207, 153)
        Me.CmbIdMateria.Name = "CmbIdMateria"
        Me.CmbIdMateria.Size = New System.Drawing.Size(140, 21)
        Me.CmbIdMateria.TabIndex = 7
        '
        'BtnVerificar
        '
        Me.BtnVerificar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnVerificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerificar.Location = New System.Drawing.Point(206, 199)
        Me.BtnVerificar.Name = "BtnVerificar"
        Me.BtnVerificar.Size = New System.Drawing.Size(104, 43)
        Me.BtnVerificar.TabIndex = 8
        Me.BtnVerificar.Text = "Verificar"
        Me.BtnVerificar.UseVisualStyleBackColor = False
        '
        'BtnInsertar
        '
        Me.BtnInsertar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnInsertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsertar.Location = New System.Drawing.Point(22, 294)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(92, 43)
        Me.BtnInsertar.TabIndex = 9
        Me.BtnInsertar.Text = "Insertar"
        Me.BtnInsertar.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Location = New System.Drawing.Point(120, 294)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(92, 43)
        Me.BtnActualizar.TabIndex = 10
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(218, 294)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(92, 43)
        Me.BtnEliminar.TabIndex = 11
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnConsultar
        '
        Me.BtnConsultar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.Location = New System.Drawing.Point(316, 294)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(92, 43)
        Me.BtnConsultar.TabIndex = 12
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = False
        '
        'DgvCurso
        '
        Me.DgvCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCurso.Location = New System.Drawing.Point(419, 97)
        Me.DgvCurso.Name = "DgvCurso"
        Me.DgvCurso.Size = New System.Drawing.Size(419, 165)
        Me.DgvCurso.TabIndex = 13
        '
        'BtnConsultaGeneralCurso
        '
        Me.BtnConsultaGeneralCurso.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnConsultaGeneralCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultaGeneralCurso.Location = New System.Drawing.Point(419, 24)
        Me.BtnConsultaGeneralCurso.Name = "BtnConsultaGeneralCurso"
        Me.BtnConsultaGeneralCurso.Size = New System.Drawing.Size(417, 42)
        Me.BtnConsultaGeneralCurso.TabIndex = 14
        Me.BtnConsultaGeneralCurso.Text = "Consulta General"
        Me.BtnConsultaGeneralCurso.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(427, 294)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 24)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Buscar Curso:"
        '
        'TxtBuscarCurso
        '
        Me.TxtBuscarCurso.Location = New System.Drawing.Point(561, 299)
        Me.TxtBuscarCurso.Name = "TxtBuscarCurso"
        Me.TxtBuscarCurso.Size = New System.Drawing.Size(140, 20)
        Me.TxtBuscarCurso.TabIndex = 16
        Me.TxtBuscarCurso.Text = "por periodo"
        '
        'FrmCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(848, 371)
        Me.Controls.Add(Me.TxtBuscarCurso)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnConsultaGeneralCurso)
        Me.Controls.Add(Me.DgvCurso)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(Me.BtnVerificar)
        Me.Controls.Add(Me.CmbIdMateria)
        Me.Controls.Add(Me.CmbIdNumSalon)
        Me.Controls.Add(Me.TxtPeriodo)
        Me.Controls.Add(Me.TxtId_curso)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCurso"
        Me.Text = "FrmCurso"
        CType(Me.DgvCurso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtId_curso As TextBox
    Friend WithEvents TxtPeriodo As TextBox
    Friend WithEvents CmbIdNumSalon As ComboBox
    Friend WithEvents CmbIdMateria As ComboBox
    Friend WithEvents BtnVerificar As Button
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents DgvCurso As DataGridView
    Friend WithEvents BtnConsultaGeneralCurso As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBuscarCurso As TextBox
End Class
