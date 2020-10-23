<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalificaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCalificaciones))
        Me.LblNumCalificacion = New System.Windows.Forms.Label()
        Me.LblCalificacion = New System.Windows.Forms.Label()
        Me.LblStatusAlum = New System.Windows.Forms.Label()
        Me.LblNumAlum = New System.Windows.Forms.Label()
        Me.LblProfe = New System.Windows.Forms.Label()
        Me.LblMateria = New System.Windows.Forms.Label()
        Me.txtNumCalificacion = New System.Windows.Forms.TextBox()
        Me.TxtCalificacion = New System.Windows.Forms.TextBox()
        Me.CmbStatusAL = New System.Windows.Forms.ComboBox()
        Me.CmbAlumnoId = New System.Windows.Forms.ComboBox()
        Me.CmbProfesorID = New System.Windows.Forms.ComboBox()
        Me.CmbMateriaID = New System.Windows.Forms.ComboBox()
        Me.BtnVerificarVacios = New System.Windows.Forms.Button()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.BtnConsultaGeneralCalificaciones = New System.Windows.Forms.Button()
        Me.DgvCalificaciones = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBuscarCalificacion = New System.Windows.Forms.TextBox()
        CType(Me.DgvCalificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNumCalificacion
        '
        Me.LblNumCalificacion.AutoSize = True
        Me.LblNumCalificacion.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumCalificacion.Location = New System.Drawing.Point(31, 31)
        Me.LblNumCalificacion.Name = "LblNumCalificacion"
        Me.LblNumCalificacion.Size = New System.Drawing.Size(143, 19)
        Me.LblNumCalificacion.TabIndex = 0
        Me.LblNumCalificacion.Text = "Numero de calificacion:"
        '
        'LblCalificacion
        '
        Me.LblCalificacion.AutoSize = True
        Me.LblCalificacion.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCalificacion.Location = New System.Drawing.Point(31, 68)
        Me.LblCalificacion.Name = "LblCalificacion"
        Me.LblCalificacion.Size = New System.Drawing.Size(78, 19)
        Me.LblCalificacion.TabIndex = 1
        Me.LblCalificacion.Text = "Calificacion:"
        '
        'LblStatusAlum
        '
        Me.LblStatusAlum.AutoSize = True
        Me.LblStatusAlum.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatusAlum.Location = New System.Drawing.Point(32, 109)
        Me.LblStatusAlum.Name = "LblStatusAlum"
        Me.LblStatusAlum.Size = New System.Drawing.Size(115, 19)
        Me.LblStatusAlum.TabIndex = 2
        Me.LblStatusAlum.Text = "Status del alumno:"
        '
        'LblNumAlum
        '
        Me.LblNumAlum.AutoSize = True
        Me.LblNumAlum.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumAlum.Location = New System.Drawing.Point(33, 150)
        Me.LblNumAlum.Name = "LblNumAlum"
        Me.LblNumAlum.Size = New System.Drawing.Size(53, 19)
        Me.LblNumAlum.TabIndex = 3
        Me.LblNumAlum.Text = "Alumno:"
        '
        'LblProfe
        '
        Me.LblProfe.AutoSize = True
        Me.LblProfe.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProfe.Location = New System.Drawing.Point(34, 191)
        Me.LblProfe.Name = "LblProfe"
        Me.LblProfe.Size = New System.Drawing.Size(62, 19)
        Me.LblProfe.TabIndex = 4
        Me.LblProfe.Text = "Profesor:"
        '
        'LblMateria
        '
        Me.LblMateria.AutoSize = True
        Me.LblMateria.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMateria.Location = New System.Drawing.Point(35, 232)
        Me.LblMateria.Name = "LblMateria"
        Me.LblMateria.Size = New System.Drawing.Size(59, 19)
        Me.LblMateria.TabIndex = 5
        Me.LblMateria.Text = "Materia:"
        '
        'txtNumCalificacion
        '
        Me.txtNumCalificacion.Location = New System.Drawing.Point(216, 30)
        Me.txtNumCalificacion.Name = "txtNumCalificacion"
        Me.txtNumCalificacion.Size = New System.Drawing.Size(154, 20)
        Me.txtNumCalificacion.TabIndex = 6
        '
        'TxtCalificacion
        '
        Me.TxtCalificacion.Location = New System.Drawing.Point(216, 68)
        Me.TxtCalificacion.Name = "TxtCalificacion"
        Me.TxtCalificacion.Size = New System.Drawing.Size(154, 20)
        Me.TxtCalificacion.TabIndex = 7
        '
        'CmbStatusAL
        '
        Me.CmbStatusAL.FormattingEnabled = True
        Me.CmbStatusAL.Location = New System.Drawing.Point(216, 107)
        Me.CmbStatusAL.Name = "CmbStatusAL"
        Me.CmbStatusAL.Size = New System.Drawing.Size(153, 21)
        Me.CmbStatusAL.TabIndex = 8
        '
        'CmbAlumnoId
        '
        Me.CmbAlumnoId.FormattingEnabled = True
        Me.CmbAlumnoId.Location = New System.Drawing.Point(216, 148)
        Me.CmbAlumnoId.Name = "CmbAlumnoId"
        Me.CmbAlumnoId.Size = New System.Drawing.Size(154, 21)
        Me.CmbAlumnoId.TabIndex = 9
        '
        'CmbProfesorID
        '
        Me.CmbProfesorID.FormattingEnabled = True
        Me.CmbProfesorID.Location = New System.Drawing.Point(216, 189)
        Me.CmbProfesorID.Name = "CmbProfesorID"
        Me.CmbProfesorID.Size = New System.Drawing.Size(153, 21)
        Me.CmbProfesorID.TabIndex = 10
        '
        'CmbMateriaID
        '
        Me.CmbMateriaID.FormattingEnabled = True
        Me.CmbMateriaID.Location = New System.Drawing.Point(216, 230)
        Me.CmbMateriaID.Name = "CmbMateriaID"
        Me.CmbMateriaID.Size = New System.Drawing.Size(153, 21)
        Me.CmbMateriaID.TabIndex = 11
        '
        'BtnVerificarVacios
        '
        Me.BtnVerificarVacios.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnVerificarVacios.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerificarVacios.Location = New System.Drawing.Point(234, 268)
        Me.BtnVerificarVacios.Name = "BtnVerificarVacios"
        Me.BtnVerificarVacios.Size = New System.Drawing.Size(111, 37)
        Me.BtnVerificarVacios.TabIndex = 12
        Me.BtnVerificarVacios.Text = "Verificar"
        Me.BtnVerificarVacios.UseVisualStyleBackColor = False
        '
        'BtnInsertar
        '
        Me.BtnInsertar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnInsertar.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsertar.Location = New System.Drawing.Point(12, 325)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(106, 37)
        Me.BtnInsertar.TabIndex = 13
        Me.BtnInsertar.Text = "lnsertar"
        Me.BtnInsertar.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnActualizar.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Location = New System.Drawing.Point(124, 325)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(110, 37)
        Me.BtnActualizar.TabIndex = 14
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnEliminar.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(240, 325)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(109, 37)
        Me.BtnEliminar.TabIndex = 15
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnConsultar
        '
        Me.BtnConsultar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnConsultar.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.Location = New System.Drawing.Point(355, 325)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(109, 37)
        Me.BtnConsultar.TabIndex = 16
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = False
        '
        'BtnConsultaGeneralCalificaciones
        '
        Me.BtnConsultaGeneralCalificaciones.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnConsultaGeneralCalificaciones.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultaGeneralCalificaciones.Location = New System.Drawing.Point(466, 31)
        Me.BtnConsultaGeneralCalificaciones.Name = "BtnConsultaGeneralCalificaciones"
        Me.BtnConsultaGeneralCalificaciones.Size = New System.Drawing.Size(455, 36)
        Me.BtnConsultaGeneralCalificaciones.TabIndex = 17
        Me.BtnConsultaGeneralCalificaciones.Text = "Consulta General"
        Me.BtnConsultaGeneralCalificaciones.UseVisualStyleBackColor = False
        '
        'DgvCalificaciones
        '
        Me.DgvCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCalificaciones.Location = New System.Drawing.Point(466, 82)
        Me.DgvCalificaciones.Name = "DgvCalificaciones"
        Me.DgvCalificaciones.Size = New System.Drawing.Size(455, 197)
        Me.DgvCalificaciones.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(501, 334)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 23)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Buscar calificacion"
        '
        'TxtBuscarCalificacion
        '
        Me.TxtBuscarCalificacion.Location = New System.Drawing.Point(651, 336)
        Me.TxtBuscarCalificacion.Name = "TxtBuscarCalificacion"
        Me.TxtBuscarCalificacion.Size = New System.Drawing.Size(242, 20)
        Me.TxtBuscarCalificacion.TabIndex = 20
        Me.TxtBuscarCalificacion.Text = "por numero"
        '
        'FrmCalificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(949, 456)
        Me.Controls.Add(Me.TxtBuscarCalificacion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvCalificaciones)
        Me.Controls.Add(Me.BtnConsultaGeneralCalificaciones)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(Me.BtnVerificarVacios)
        Me.Controls.Add(Me.CmbMateriaID)
        Me.Controls.Add(Me.CmbProfesorID)
        Me.Controls.Add(Me.CmbAlumnoId)
        Me.Controls.Add(Me.CmbStatusAL)
        Me.Controls.Add(Me.TxtCalificacion)
        Me.Controls.Add(Me.txtNumCalificacion)
        Me.Controls.Add(Me.LblMateria)
        Me.Controls.Add(Me.LblProfe)
        Me.Controls.Add(Me.LblNumAlum)
        Me.Controls.Add(Me.LblStatusAlum)
        Me.Controls.Add(Me.LblCalificacion)
        Me.Controls.Add(Me.LblNumCalificacion)
        Me.Name = "FrmCalificaciones"
        Me.Text = "FrmCalificaciones"
        CType(Me.DgvCalificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNumCalificacion As Label
    Friend WithEvents LblCalificacion As Label
    Friend WithEvents LblStatusAlum As Label
    Friend WithEvents LblNumAlum As Label
    Friend WithEvents LblProfe As Label
    Friend WithEvents LblMateria As Label
    Friend WithEvents txtNumCalificacion As TextBox
    Friend WithEvents TxtCalificacion As TextBox
    Friend WithEvents CmbStatusAL As ComboBox
    Friend WithEvents CmbAlumnoId As ComboBox
    Friend WithEvents CmbProfesorID As ComboBox
    Friend WithEvents CmbMateriaID As ComboBox
    Friend WithEvents BtnVerificarVacios As Button
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents BtnConsultaGeneralCalificaciones As Button
    Friend WithEvents DgvCalificaciones As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBuscarCalificacion As TextBox
End Class
