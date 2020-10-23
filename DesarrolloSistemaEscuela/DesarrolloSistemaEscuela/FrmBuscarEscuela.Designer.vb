<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarSalon
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
        Me.DgvTraeSln = New System.Windows.Forms.DataGridView()
        Me.TxtBuscarSalones = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DgvTraeSln, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvTraeSln
        '
        Me.DgvTraeSln.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTraeSln.Location = New System.Drawing.Point(12, 104)
        Me.DgvTraeSln.Name = "DgvTraeSln"
        Me.DgvTraeSln.Size = New System.Drawing.Size(440, 334)
        Me.DgvTraeSln.TabIndex = 0
        '
        'TxtBuscarSalones
        '
        Me.TxtBuscarSalones.Location = New System.Drawing.Point(12, 57)
        Me.TxtBuscarSalones.Name = "TxtBuscarSalones"
        Me.TxtBuscarSalones.Size = New System.Drawing.Size(305, 20)
        Me.TxtBuscarSalones.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "La busqueda funciona mediante el nombre, favor escribir correctamente"
        '
        'FrmBuscarSalon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(469, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBuscarSalones)
        Me.Controls.Add(Me.DgvTraeSln)
        Me.Name = "FrmBuscarSalon"
        Me.Text = "FrmBuscarSalon"
        CType(Me.DgvTraeSln, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvTraeSln As DataGridView
    Friend WithEvents TxtBuscarSalones As TextBox
    Friend WithEvents Label1 As Label
End Class
