<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSalon
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
        Me.TxtNumSalon = New System.Windows.Forms.TextBox()
        Me.TxtCapacidad = New System.Windows.Forms.TextBox()
        Me.TxtCupoActual = New System.Windows.Forms.TextBox()
        Me.CmbStatusSalon = New System.Windows.Forms.ComboBox()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.DgvSalon = New System.Windows.Forms.DataGridView()
        Me.BtnVerificaVacios = New System.Windows.Forms.Button()
        Me.BtnConsultaGeneralSalon = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBuscarSalon = New System.Windows.Forms.TextBox()
        CType(Me.DgvSalon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero de salon:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Capacidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cupo actual:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Status del salon:"
        '
        'TxtNumSalon
        '
        Me.TxtNumSalon.Location = New System.Drawing.Point(183, 29)
        Me.TxtNumSalon.Name = "TxtNumSalon"
        Me.TxtNumSalon.Size = New System.Drawing.Size(196, 20)
        Me.TxtNumSalon.TabIndex = 4
        '
        'TxtCapacidad
        '
        Me.TxtCapacidad.Location = New System.Drawing.Point(183, 57)
        Me.TxtCapacidad.Name = "TxtCapacidad"
        Me.TxtCapacidad.Size = New System.Drawing.Size(196, 20)
        Me.TxtCapacidad.TabIndex = 5
        '
        'TxtCupoActual
        '
        Me.TxtCupoActual.Location = New System.Drawing.Point(183, 88)
        Me.TxtCupoActual.Name = "TxtCupoActual"
        Me.TxtCupoActual.Size = New System.Drawing.Size(196, 20)
        Me.TxtCupoActual.TabIndex = 6
        '
        'CmbStatusSalon
        '
        Me.CmbStatusSalon.FormattingEnabled = True
        Me.CmbStatusSalon.Location = New System.Drawing.Point(183, 117)
        Me.CmbStatusSalon.Name = "CmbStatusSalon"
        Me.CmbStatusSalon.Size = New System.Drawing.Size(196, 21)
        Me.CmbStatusSalon.TabIndex = 7
        '
        'BtnIngresar
        '
        Me.BtnIngresar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnIngresar.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.Location = New System.Drawing.Point(45, 151)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(96, 44)
        Me.BtnIngresar.TabIndex = 8
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnActualizar.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Location = New System.Drawing.Point(147, 151)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(96, 44)
        Me.BtnActualizar.TabIndex = 9
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnEliminar.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(249, 151)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(96, 44)
        Me.BtnEliminar.TabIndex = 10
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnConsultar
        '
        Me.BtnConsultar.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnConsultar.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.Location = New System.Drawing.Point(351, 151)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(96, 44)
        Me.BtnConsultar.TabIndex = 11
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = False
        '
        'DgvSalon
        '
        Me.DgvSalon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSalon.Location = New System.Drawing.Point(17, 280)
        Me.DgvSalon.Name = "DgvSalon"
        Me.DgvSalon.Size = New System.Drawing.Size(508, 198)
        Me.DgvSalon.TabIndex = 12
        '
        'BtnVerificaVacios
        '
        Me.BtnVerificaVacios.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerificaVacios.Location = New System.Drawing.Point(406, 99)
        Me.BtnVerificaVacios.Name = "BtnVerificaVacios"
        Me.BtnVerificaVacios.Size = New System.Drawing.Size(114, 36)
        Me.BtnVerificaVacios.TabIndex = 13
        Me.BtnVerificaVacios.Text = "Verificar"
        Me.BtnVerificaVacios.UseVisualStyleBackColor = True
        '
        'BtnConsultaGeneralSalon
        '
        Me.BtnConsultaGeneralSalon.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnConsultaGeneralSalon.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultaGeneralSalon.Location = New System.Drawing.Point(45, 201)
        Me.BtnConsultaGeneralSalon.Name = "BtnConsultaGeneralSalon"
        Me.BtnConsultaGeneralSalon.Size = New System.Drawing.Size(403, 46)
        Me.BtnConsultaGeneralSalon.TabIndex = 15
        Me.BtnConsultaGeneralSalon.Text = "Consulta General"
        Me.BtnConsultaGeneralSalon.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 23)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Buscar Salon:"
        '
        'TxtBuscarSalon
        '
        Me.TxtBuscarSalon.Location = New System.Drawing.Point(148, 254)
        Me.TxtBuscarSalon.Name = "TxtBuscarSalon"
        Me.TxtBuscarSalon.Size = New System.Drawing.Size(300, 20)
        Me.TxtBuscarSalon.TabIndex = 17
        '
        'FrmSalon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(537, 493)
        Me.Controls.Add(Me.TxtBuscarSalon)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnConsultaGeneralSalon)
        Me.Controls.Add(Me.BtnVerificaVacios)
        Me.Controls.Add(Me.DgvSalon)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnIngresar)
        Me.Controls.Add(Me.CmbStatusSalon)
        Me.Controls.Add(Me.TxtCupoActual)
        Me.Controls.Add(Me.TxtCapacidad)
        Me.Controls.Add(Me.TxtNumSalon)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmSalon"
        Me.Text = "FrmSalon"
        CType(Me.DgvSalon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNumSalon As TextBox
    Friend WithEvents TxtCapacidad As TextBox
    Friend WithEvents TxtCupoActual As TextBox
    Friend WithEvents CmbStatusSalon As ComboBox
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents DgvSalon As DataGridView
    Friend WithEvents BtnVerificaVacios As Button
    Friend WithEvents BtnConsultaGeneralSalon As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBuscarSalon As TextBox
End Class
