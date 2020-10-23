<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProfesor
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtIdprofesor = New System.Windows.Forms.TextBox()
        Me.TxtNombreProfesor = New System.Windows.Forms.TextBox()
        Me.TxtApellidoProfesor = New System.Windows.Forms.TextBox()
        Me.BtnIngresarDatos = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.DgvProfesor = New System.Windows.Forms.DataGridView()
        Me.BtnConsultaGeneral = New System.Windows.Forms.Button()
        Me.CmbEscuela = New System.Windows.Forms.ComboBox()
        Me.BtnVerificarVacios = New System.Windows.Forms.Button()
        Me.TxtBuscarProfesor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DgvProfesor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Profesor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Escuela:"
        '
        'TxtIdprofesor
        '
        Me.TxtIdprofesor.Location = New System.Drawing.Point(145, 31)
        Me.TxtIdprofesor.Name = "TxtIdprofesor"
        Me.TxtIdprofesor.Size = New System.Drawing.Size(191, 20)
        Me.TxtIdprofesor.TabIndex = 4
        '
        'TxtNombreProfesor
        '
        Me.TxtNombreProfesor.Location = New System.Drawing.Point(145, 72)
        Me.TxtNombreProfesor.Name = "TxtNombreProfesor"
        Me.TxtNombreProfesor.Size = New System.Drawing.Size(191, 20)
        Me.TxtNombreProfesor.TabIndex = 5
        '
        'TxtApellidoProfesor
        '
        Me.TxtApellidoProfesor.Location = New System.Drawing.Point(145, 113)
        Me.TxtApellidoProfesor.Name = "TxtApellidoProfesor"
        Me.TxtApellidoProfesor.Size = New System.Drawing.Size(191, 20)
        Me.TxtApellidoProfesor.TabIndex = 6
        '
        'BtnIngresarDatos
        '
        Me.BtnIngresarDatos.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnIngresarDatos.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresarDatos.Location = New System.Drawing.Point(355, 32)
        Me.BtnIngresarDatos.Name = "BtnIngresarDatos"
        Me.BtnIngresarDatos.Size = New System.Drawing.Size(100, 39)
        Me.BtnIngresarDatos.TabIndex = 8
        Me.BtnIngresarDatos.Text = "Ingresar"
        Me.BtnIngresarDatos.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnActualizar.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Location = New System.Drawing.Point(461, 31)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(100, 40)
        Me.BtnActualizar.TabIndex = 10
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnEliminar.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(567, 31)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(100, 41)
        Me.BtnEliminar.TabIndex = 11
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnConsultar
        '
        Me.BtnConsultar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnConsultar.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.Location = New System.Drawing.Point(673, 31)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(97, 41)
        Me.BtnConsultar.TabIndex = 12
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = False
        '
        'DgvProfesor
        '
        Me.DgvProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProfesor.Location = New System.Drawing.Point(355, 173)
        Me.DgvProfesor.Name = "DgvProfesor"
        Me.DgvProfesor.Size = New System.Drawing.Size(420, 207)
        Me.DgvProfesor.TabIndex = 13
        '
        'BtnConsultaGeneral
        '
        Me.BtnConsultaGeneral.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnConsultaGeneral.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultaGeneral.Location = New System.Drawing.Point(355, 78)
        Me.BtnConsultaGeneral.Name = "BtnConsultaGeneral"
        Me.BtnConsultaGeneral.Size = New System.Drawing.Size(415, 39)
        Me.BtnConsultaGeneral.TabIndex = 14
        Me.BtnConsultaGeneral.Text = "Consulta General"
        Me.BtnConsultaGeneral.UseVisualStyleBackColor = False
        '
        'CmbEscuela
        '
        Me.CmbEscuela.FormattingEnabled = True
        Me.CmbEscuela.Location = New System.Drawing.Point(145, 155)
        Me.CmbEscuela.Name = "CmbEscuela"
        Me.CmbEscuela.Size = New System.Drawing.Size(191, 21)
        Me.CmbEscuela.TabIndex = 15
        '
        'BtnVerificarVacios
        '
        Me.BtnVerificarVacios.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnVerificarVacios.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerificarVacios.Location = New System.Drawing.Point(161, 208)
        Me.BtnVerificarVacios.Name = "BtnVerificarVacios"
        Me.BtnVerificarVacios.Size = New System.Drawing.Size(151, 41)
        Me.BtnVerificarVacios.TabIndex = 16
        Me.BtnVerificarVacios.Text = "Verifica Vacios"
        Me.BtnVerificarVacios.UseVisualStyleBackColor = False
        '
        'TxtBuscarProfesor
        '
        Me.TxtBuscarProfesor.Location = New System.Drawing.Point(567, 133)
        Me.TxtBuscarProfesor.Name = "TxtBuscarProfesor"
        Me.TxtBuscarProfesor.Size = New System.Drawing.Size(203, 20)
        Me.TxtBuscarProfesor.TabIndex = 17
        Me.TxtBuscarProfesor.Text = "Ingresa el nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(363, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 23)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Buscar profesor por nombre:"
        '
        'FrmProfesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(802, 407)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtBuscarProfesor)
        Me.Controls.Add(Me.BtnVerificarVacios)
        Me.Controls.Add(Me.CmbEscuela)
        Me.Controls.Add(Me.BtnConsultaGeneral)
        Me.Controls.Add(Me.DgvProfesor)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnIngresarDatos)
        Me.Controls.Add(Me.TxtApellidoProfesor)
        Me.Controls.Add(Me.TxtNombreProfesor)
        Me.Controls.Add(Me.TxtIdprofesor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmProfesor"
        Me.Text = "FrmProfesor"
        CType(Me.DgvProfesor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtIdprofesor As TextBox
    Friend WithEvents TxtNombreProfesor As TextBox
    Friend WithEvents TxtApellidoProfesor As TextBox
    Friend WithEvents BtnIngresarDatos As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents DgvProfesor As DataGridView
    Friend WithEvents BtnConsultaGeneral As Button
    Friend WithEvents CmbEscuela As ComboBox
    Friend WithEvents BtnVerificarVacios As Button
    Friend WithEvents TxtBuscarProfesor As TextBox
    Friend WithEvents Label5 As Label
End Class
