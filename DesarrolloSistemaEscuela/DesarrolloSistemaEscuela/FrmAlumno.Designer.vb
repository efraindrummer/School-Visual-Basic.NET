<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlumno
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
        Me.LblIdAlumnos = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblCorreo = New System.Windows.Forms.Label()
        Me.LblEdad = New System.Windows.Forms.Label()
        Me.LblNumEscuela = New System.Windows.Forms.Label()
        Me.LblGrupo = New System.Windows.Forms.Label()
        Me.TxtIdAlumno = New System.Windows.Forms.TextBox()
        Me.TxtNombreAlumno = New System.Windows.Forms.TextBox()
        Me.TxtApellidoAlumno = New System.Windows.Forms.TextBox()
        Me.TxtCorreoAlumno = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnVerificar = New System.Windows.Forms.Button()
        Me.rbUniversidad = New System.Windows.Forms.RadioButton()
        Me.rbPreparatoria = New System.Windows.Forms.RadioButton()
        Me.rbSecundaria = New System.Windows.Forms.RadioButton()
        Me.rbPrimaria = New System.Windows.Forms.RadioButton()
        Me.CmbEscuelaAlumno = New System.Windows.Forms.ComboBox()
        Me.CmbGrupoAlumno = New System.Windows.Forms.ComboBox()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.BtnConsultaGeneralAlumno = New System.Windows.Forms.Button()
        Me.DgvAlumno = New System.Windows.Forms.DataGridView()
        Me.TxtEdadAlumno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBuscarAlumno = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvAlumno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblIdAlumnos
        '
        Me.LblIdAlumnos.AutoSize = True
        Me.LblIdAlumnos.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIdAlumnos.Location = New System.Drawing.Point(24, 27)
        Me.LblIdAlumnos.Name = "LblIdAlumnos"
        Me.LblIdAlumnos.Size = New System.Drawing.Size(68, 19)
        Me.LblIdAlumnos.TabIndex = 0
        Me.LblIdAlumnos.Text = "Id Alumno:"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(25, 66)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(56, 19)
        Me.LblNombre.TabIndex = 1
        Me.LblNombre.Text = "Nombre:"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApellido.Location = New System.Drawing.Point(25, 106)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(58, 19)
        Me.LblApellido.TabIndex = 2
        Me.LblApellido.Text = "Apellido:"
        '
        'LblCorreo
        '
        Me.LblCorreo.AutoSize = True
        Me.LblCorreo.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCorreo.Location = New System.Drawing.Point(26, 146)
        Me.LblCorreo.Name = "LblCorreo"
        Me.LblCorreo.Size = New System.Drawing.Size(49, 19)
        Me.LblCorreo.TabIndex = 3
        Me.LblCorreo.Text = "Correo:"
        '
        'LblEdad
        '
        Me.LblEdad.AutoSize = True
        Me.LblEdad.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEdad.Location = New System.Drawing.Point(27, 186)
        Me.LblEdad.Name = "LblEdad"
        Me.LblEdad.Size = New System.Drawing.Size(41, 19)
        Me.LblEdad.TabIndex = 4
        Me.LblEdad.Text = "Edad:"
        '
        'LblNumEscuela
        '
        Me.LblNumEscuela.AutoSize = True
        Me.LblNumEscuela.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumEscuela.Location = New System.Drawing.Point(27, 403)
        Me.LblNumEscuela.Name = "LblNumEscuela"
        Me.LblNumEscuela.Size = New System.Drawing.Size(56, 19)
        Me.LblNumEscuela.TabIndex = 6
        Me.LblNumEscuela.Text = "Escuela:"
        '
        'LblGrupo
        '
        Me.LblGrupo.AutoSize = True
        Me.LblGrupo.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGrupo.Location = New System.Drawing.Point(30, 443)
        Me.LblGrupo.Name = "LblGrupo"
        Me.LblGrupo.Size = New System.Drawing.Size(45, 19)
        Me.LblGrupo.TabIndex = 7
        Me.LblGrupo.Text = "Grupo:"
        '
        'TxtIdAlumno
        '
        Me.TxtIdAlumno.Location = New System.Drawing.Point(161, 26)
        Me.TxtIdAlumno.Name = "TxtIdAlumno"
        Me.TxtIdAlumno.Size = New System.Drawing.Size(171, 20)
        Me.TxtIdAlumno.TabIndex = 8
        '
        'TxtNombreAlumno
        '
        Me.TxtNombreAlumno.Location = New System.Drawing.Point(161, 65)
        Me.TxtNombreAlumno.Name = "TxtNombreAlumno"
        Me.TxtNombreAlumno.Size = New System.Drawing.Size(171, 20)
        Me.TxtNombreAlumno.TabIndex = 9
        '
        'TxtApellidoAlumno
        '
        Me.TxtApellidoAlumno.Location = New System.Drawing.Point(161, 105)
        Me.TxtApellidoAlumno.Name = "TxtApellidoAlumno"
        Me.TxtApellidoAlumno.Size = New System.Drawing.Size(171, 20)
        Me.TxtApellidoAlumno.TabIndex = 10
        '
        'TxtCorreoAlumno
        '
        Me.TxtCorreoAlumno.Location = New System.Drawing.Point(161, 145)
        Me.TxtCorreoAlumno.Name = "TxtCorreoAlumno"
        Me.TxtCorreoAlumno.Size = New System.Drawing.Size(171, 20)
        Me.TxtCorreoAlumno.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnVerificar)
        Me.GroupBox1.Controls.Add(Me.rbUniversidad)
        Me.GroupBox1.Controls.Add(Me.rbPreparatoria)
        Me.GroupBox1.Controls.Add(Me.rbSecundaria)
        Me.GroupBox1.Controls.Add(Me.rbPrimaria)
        Me.GroupBox1.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(28, 228)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 156)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NIVEL EDUCATIVO"
        '
        'BtnVerificar
        '
        Me.BtnVerificar.Location = New System.Drawing.Point(247, 84)
        Me.BtnVerificar.Name = "BtnVerificar"
        Me.BtnVerificar.Size = New System.Drawing.Size(151, 40)
        Me.BtnVerificar.TabIndex = 4
        Me.BtnVerificar.Text = "Verificar Vacios"
        Me.BtnVerificar.UseVisualStyleBackColor = True
        '
        'rbUniversidad
        '
        Me.rbUniversidad.AutoSize = True
        Me.rbUniversidad.Location = New System.Drawing.Point(117, 113)
        Me.rbUniversidad.Name = "rbUniversidad"
        Me.rbUniversidad.Size = New System.Drawing.Size(94, 23)
        Me.rbUniversidad.TabIndex = 3
        Me.rbUniversidad.TabStop = True
        Me.rbUniversidad.Text = "Universidad" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.rbUniversidad.UseVisualStyleBackColor = True
        '
        'rbPreparatoria
        '
        Me.rbPreparatoria.AutoSize = True
        Me.rbPreparatoria.Location = New System.Drawing.Point(81, 84)
        Me.rbPreparatoria.Name = "rbPreparatoria"
        Me.rbPreparatoria.Size = New System.Drawing.Size(101, 23)
        Me.rbPreparatoria.TabIndex = 2
        Me.rbPreparatoria.TabStop = True
        Me.rbPreparatoria.Text = "Preparatoria"
        Me.rbPreparatoria.UseVisualStyleBackColor = True
        '
        'rbSecundaria
        '
        Me.rbSecundaria.AutoSize = True
        Me.rbSecundaria.Location = New System.Drawing.Point(52, 55)
        Me.rbSecundaria.Name = "rbSecundaria"
        Me.rbSecundaria.Size = New System.Drawing.Size(91, 23)
        Me.rbSecundaria.TabIndex = 1
        Me.rbSecundaria.TabStop = True
        Me.rbSecundaria.Text = "Secundaria"
        Me.rbSecundaria.UseVisualStyleBackColor = True
        '
        'rbPrimaria
        '
        Me.rbPrimaria.AutoSize = True
        Me.rbPrimaria.Location = New System.Drawing.Point(13, 26)
        Me.rbPrimaria.Name = "rbPrimaria"
        Me.rbPrimaria.Size = New System.Drawing.Size(78, 23)
        Me.rbPrimaria.TabIndex = 0
        Me.rbPrimaria.TabStop = True
        Me.rbPrimaria.Text = "Primaria"
        Me.rbPrimaria.UseVisualStyleBackColor = True
        '
        'CmbEscuelaAlumno
        '
        Me.CmbEscuelaAlumno.FormattingEnabled = True
        Me.CmbEscuelaAlumno.Location = New System.Drawing.Point(161, 403)
        Me.CmbEscuelaAlumno.Name = "CmbEscuelaAlumno"
        Me.CmbEscuelaAlumno.Size = New System.Drawing.Size(171, 21)
        Me.CmbEscuelaAlumno.TabIndex = 16
        '
        'CmbGrupoAlumno
        '
        Me.CmbGrupoAlumno.FormattingEnabled = True
        Me.CmbGrupoAlumno.Location = New System.Drawing.Point(161, 441)
        Me.CmbGrupoAlumno.Name = "CmbGrupoAlumno"
        Me.CmbGrupoAlumno.Size = New System.Drawing.Size(172, 21)
        Me.CmbGrupoAlumno.TabIndex = 17
        '
        'BtnInsertar
        '
        Me.BtnInsertar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnInsertar.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsertar.Location = New System.Drawing.Point(354, 26)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(102, 40)
        Me.BtnInsertar.TabIndex = 18
        Me.BtnInsertar.Text = "Insertar"
        Me.BtnInsertar.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnActualizar.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Location = New System.Drawing.Point(354, 73)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(102, 40)
        Me.BtnActualizar.TabIndex = 19
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnEliminar.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(354, 119)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(102, 40)
        Me.BtnEliminar.TabIndex = 20
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnConsultar
        '
        Me.BtnConsultar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnConsultar.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.Location = New System.Drawing.Point(354, 165)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(102, 40)
        Me.BtnConsultar.TabIndex = 21
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = False
        '
        'BtnConsultaGeneralAlumno
        '
        Me.BtnConsultaGeneralAlumno.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnConsultaGeneralAlumno.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultaGeneralAlumno.Location = New System.Drawing.Point(538, 14)
        Me.BtnConsultaGeneralAlumno.Name = "BtnConsultaGeneralAlumno"
        Me.BtnConsultaGeneralAlumno.Size = New System.Drawing.Size(507, 43)
        Me.BtnConsultaGeneralAlumno.TabIndex = 22
        Me.BtnConsultaGeneralAlumno.Text = "Consulta General"
        Me.BtnConsultaGeneralAlumno.UseVisualStyleBackColor = False
        '
        'DgvAlumno
        '
        Me.DgvAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAlumno.Location = New System.Drawing.Point(485, 119)
        Me.DgvAlumno.Name = "DgvAlumno"
        Me.DgvAlumno.Size = New System.Drawing.Size(599, 410)
        Me.DgvAlumno.TabIndex = 23
        '
        'TxtEdadAlumno
        '
        Me.TxtEdadAlumno.Location = New System.Drawing.Point(160, 186)
        Me.TxtEdadAlumno.Name = "TxtEdadAlumno"
        Me.TxtEdadAlumno.Size = New System.Drawing.Size(172, 20)
        Me.TxtEdadAlumno.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(524, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 23)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Buscar Alumno:"
        '
        'TxtBuscarAlumno
        '
        Me.TxtBuscarAlumno.Location = New System.Drawing.Point(642, 85)
        Me.TxtBuscarAlumno.Name = "TxtBuscarAlumno"
        Me.TxtBuscarAlumno.Size = New System.Drawing.Size(236, 20)
        Me.TxtBuscarAlumno.TabIndex = 26
        Me.TxtBuscarAlumno.Text = "por nombre"
        '
        'FrmAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1096, 539)
        Me.Controls.Add(Me.TxtBuscarAlumno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtEdadAlumno)
        Me.Controls.Add(Me.DgvAlumno)
        Me.Controls.Add(Me.BtnConsultaGeneralAlumno)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(Me.CmbGrupoAlumno)
        Me.Controls.Add(Me.CmbEscuelaAlumno)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtCorreoAlumno)
        Me.Controls.Add(Me.TxtApellidoAlumno)
        Me.Controls.Add(Me.TxtNombreAlumno)
        Me.Controls.Add(Me.TxtIdAlumno)
        Me.Controls.Add(Me.LblGrupo)
        Me.Controls.Add(Me.LblNumEscuela)
        Me.Controls.Add(Me.LblEdad)
        Me.Controls.Add(Me.LblCorreo)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblIdAlumnos)
        Me.Name = "FrmAlumno"
        Me.Text = "FrmAlumno"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvAlumno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblIdAlumnos As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblCorreo As Label
    Friend WithEvents LblEdad As Label
    Friend WithEvents LblNumEscuela As Label
    Friend WithEvents LblGrupo As Label
    Friend WithEvents TxtIdAlumno As TextBox
    Friend WithEvents TxtNombreAlumno As TextBox
    Friend WithEvents TxtApellidoAlumno As TextBox
    Friend WithEvents TxtCorreoAlumno As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnVerificar As Button
    Friend WithEvents rbUniversidad As RadioButton
    Friend WithEvents rbPreparatoria As RadioButton
    Friend WithEvents rbSecundaria As RadioButton
    Friend WithEvents rbPrimaria As RadioButton
    Friend WithEvents CmbEscuelaAlumno As ComboBox
    Friend WithEvents CmbGrupoAlumno As ComboBox
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents BtnConsultaGeneralAlumno As Button
    Friend WithEvents DgvAlumno As DataGridView
    Friend WithEvents TxtEdadAlumno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBuscarAlumno As TextBox
End Class
