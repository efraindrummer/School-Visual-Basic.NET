<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConsulta1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsulta1))
        Me.DgvConsulta1 = New System.Windows.Forms.DataGridView()
        Me.BtnConsulta1 = New System.Windows.Forms.Button()
        Me.TxtBuscaConsulta1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DgvConsulta1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvConsulta1
        '
        Me.DgvConsulta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConsulta1.Location = New System.Drawing.Point(12, 58)
        Me.DgvConsulta1.Name = "DgvConsulta1"
        Me.DgvConsulta1.Size = New System.Drawing.Size(535, 380)
        Me.DgvConsulta1.TabIndex = 0
        '
        'BtnConsulta1
        '
        Me.BtnConsulta1.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnConsulta1.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsulta1.Location = New System.Drawing.Point(12, 25)
        Me.BtnConsulta1.Name = "BtnConsulta1"
        Me.BtnConsulta1.Size = New System.Drawing.Size(143, 27)
        Me.BtnConsulta1.TabIndex = 1
        Me.BtnConsulta1.Text = "Ejecutar Consulta"
        Me.BtnConsulta1.UseVisualStyleBackColor = False
        '
        'TxtBuscaConsulta1
        '
        Me.TxtBuscaConsulta1.Location = New System.Drawing.Point(215, 28)
        Me.TxtBuscaConsulta1.Name = "TxtBuscaConsulta1"
        Me.TxtBuscaConsulta1.Size = New System.Drawing.Size(332, 20)
        Me.TxtBuscaConsulta1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("AR CENA", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(150, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Buscar:"
        '
        'FrmConsulta1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(562, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBuscaConsulta1)
        Me.Controls.Add(Me.BtnConsulta1)
        Me.Controls.Add(Me.DgvConsulta1)
        Me.Name = "FrmConsulta1"
        Me.Text = "FrmConsulta1"
        CType(Me.DgvConsulta1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvConsulta1 As DataGridView
    Friend WithEvents BtnConsulta1 As Button
    Friend WithEvents TxtBuscaConsulta1 As TextBox
    Friend WithEvents Label1 As Label
End Class
