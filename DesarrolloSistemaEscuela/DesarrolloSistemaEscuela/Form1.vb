Imports MySql.Data.MySqlClient
'SISTEMA DE COLEGIO  
'EFRAIN MAY MAYO - INGIENERIA EN COMPUTACION - 170869
'LUIS BENTANCUR - INGIENERIA EN SISTEMAS COMPUTACIONALES - 
Public Class FrmLogin
    'validacion de la conexion a la base de datos
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim conexion As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand

        comando.Connection = conexion

        Try
            conexion.ConnectionString = "Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;"
            conexion.Open()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        comando.CommandText = "SELECT * FROM usuario WHERE nombre_usuario='" + txtUsuario.Text + "'AND password='" + txtPassword.Text + "'"

        Dim r As MySqlDataReader

        r = comando.ExecuteReader

        If r.HasRows <> False Then
            r.Read()
            Timer1.Start()
            'FrmPrincipal.Show()
        Else
            MsgBox("Error, Datos incorrectos")

        End If


    End Sub
    'En esta evento del boton mostrar contraseña se muestra solamente la contraseña
    'siempre y palomee en el checkbox
    Private Sub cbMostrarContra_CheckedChanged(sender As Object, e As EventArgs) Handles cbMostrarContra.CheckedChanged
        If cbMostrarContra.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
    ' funcion del timer
    'la funcion timer me valida el tiempo en lo que tarda en acceder mi progress bar 1
    'Esto va dependiendo de la condicion que vaya a usar en mi boton de ingresar
    'si mla condicion del boton  ingresar en el evento click es la verdadera al iniciar la session
    ' se ejecutara la funcion timer y con la funcion hide() cerrara la ventana del login y me
    'redirigira al la ventana principal del sistema
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)

        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            Me.Hide()
            MsgBox("Bienvenido al Sistema: " & txtUsuario.Text)
            FrmPrincipal.Show()

        End If


    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    
    End Sub
End Class
