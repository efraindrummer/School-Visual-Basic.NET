<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEscuelaAlta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEscuelaAlta))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdEscuela = New System.Windows.Forms.TextBox()
        Me.txtNomEscuela = New System.Windows.Forms.TextBox()
        Me.dgvEscuela = New System.Windows.Forms.DataGridView()
        Me.btnMostrarTabla = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminarEscuela = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnActualizarEscuela = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rbUniversidad = New System.Windows.Forms.RadioButton()
        Me.rbPreparatoria = New System.Windows.Forms.RadioButton()
        Me.rbSecundaria = New System.Windows.Forms.RadioButton()
        Me.rbPrimaria = New System.Windows.Forms.RadioButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TxtBuscarEscuela = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvEscuela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID ESCUELA: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOMBRE DE LA ESCUELA:"
        '
        'txtIdEscuela
        '
        Me.txtIdEscuela.Location = New System.Drawing.Point(233, 42)
        Me.txtIdEscuela.Name = "txtIdEscuela"
        Me.txtIdEscuela.Size = New System.Drawing.Size(192, 20)
        Me.txtIdEscuela.TabIndex = 4
        '
        'txtNomEscuela
        '
        Me.txtNomEscuela.Location = New System.Drawing.Point(233, 76)
        Me.txtNomEscuela.Name = "txtNomEscuela"
        Me.txtNomEscuela.Size = New System.Drawing.Size(192, 20)
        Me.txtNomEscuela.TabIndex = 5
        '
        'dgvEscuela
        '
        Me.dgvEscuela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEscuela.Location = New System.Drawing.Point(12, 387)
        Me.dgvEscuela.Name = "dgvEscuela"
        Me.dgvEscuela.Size = New System.Drawing.Size(454, 280)
        Me.dgvEscuela.TabIndex = 8
        '
        'btnMostrarTabla
        '
        Me.btnMostrarTabla.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnMostrarTabla.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarTabla.Location = New System.Drawing.Point(23, 319)
        Me.btnMostrarTabla.Name = "btnMostrarTabla"
        Me.btnMostrarTabla.Size = New System.Drawing.Size(443, 35)
        Me.btnMostrarTabla.TabIndex = 9
        Me.btnMostrarTabla.Text = "Mostrar Datos "
        Me.btnMostrarTabla.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnAgregar.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(23, 278)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(110, 35)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnEliminarEscuela
        '
        Me.btnEliminarEscuela.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnEliminarEscuela.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarEscuela.Location = New System.Drawing.Point(255, 278)
        Me.btnEliminarEscuela.Name = "btnEliminarEscuela"
        Me.btnEliminarEscuela.Size = New System.Drawing.Size(107, 35)
        Me.btnEliminarEscuela.TabIndex = 11
        Me.btnEliminarEscuela.Text = "Eliminar"
        Me.btnEliminarEscuela.UseVisualStyleBackColor = False
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnConsultar.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Location = New System.Drawing.Point(364, 278)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(100, 35)
        Me.btnConsultar.TabIndex = 12
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'btnActualizarEscuela
        '
        Me.btnActualizarEscuela.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnActualizarEscuela.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarEscuela.Location = New System.Drawing.Point(139, 278)
        Me.btnActualizarEscuela.Name = "btnActualizarEscuela"
        Me.btnActualizarEscuela.Size = New System.Drawing.Size(110, 35)
        Me.btnActualizarEscuela.TabIndex = 13
        Me.btnActualizarEscuela.Text = "Actualizar"
        Me.btnActualizarEscuela.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.rbUniversidad)
        Me.GroupBox1.Controls.Add(Me.rbPreparatoria)
        Me.GroupBox1.Controls.Add(Me.rbSecundaria)
        Me.GroupBox1.Controls.Add(Me.rbPrimaria)
        Me.GroupBox1.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(27, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 156)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NIVEL EDUCATIVO"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(247, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 40)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Verificar Vacios"
        Me.Button1.UseVisualStyleBackColor = True
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
        'TxtBuscarEscuela
        '
        Me.TxtBuscarEscuela.Location = New System.Drawing.Point(139, 361)
        Me.TxtBuscarEscuela.Name = "TxtBuscarEscuela"
        Me.TxtBuscarEscuela.Size = New System.Drawing.Size(327, 20)
        Me.TxtBuscarEscuela.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 357)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Buscar Escuela:"
        '
        'FrmEscuelaAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(476, 671)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtBuscarEscuela)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnActualizarEscuela)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnEliminarEscuela)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnMostrarTabla)
        Me.Controls.Add(Me.dgvEscuela)
        Me.Controls.Add(Me.txtNomEscuela)
        Me.Controls.Add(Me.txtIdEscuela)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmEscuelaAlta"
        Me.Text = "FrmEscuelaAlta"
        CType(Me.dgvEscuela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdEscuela As TextBox
    Friend WithEvents txtNomEscuela As TextBox
    Friend WithEvents dgvEscuela As DataGridView
    Friend WithEvents btnMostrarTabla As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminarEscuela As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents btnActualizarEscuela As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbUniversidad As RadioButton
    Friend WithEvents rbPreparatoria As RadioButton
    Friend WithEvents rbSecundaria As RadioButton
    Friend WithEvents rbPrimaria As RadioButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtBuscarEscuela As TextBox
    Friend WithEvents Label3 As Label
End Class
