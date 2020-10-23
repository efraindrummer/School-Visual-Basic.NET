Imports MySql.Data.MySqlClient

Public Class FrmEscuelaAlta
    'llamado de la clase ClsEscuela para validacion de datos
    Public Esc As New ClsEscuela
    'fin de llamdo de clase
    Private conexion As MySqlConnection
    Private comando As MySqlCommand
    Private da As MySqlDataAdapter
    Private dr As MySqlDataReader
    Private strSQL As String
    Public NivelEducativo As String

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Try
            conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")

            strSQL = "INSERT INTO escuela (id_escuela, nombre, nivel_educativo) VALUES (@id_escuela, @nombre, @nivel_educativo)"

            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_escuela", txtIdEscuela.Text)
            comando.Parameters.AddWithValue("@nombre", txtNomEscuela.Text)
            comando.Parameters.AddWithValue("@nivel_educativo", NivelEducativo)

            conexion.Open()
            comando.ExecuteNonQuery()

            Esc.nombreEsc = Me.txtNomEscuela.Text
            Esc.nivel_Edu_esc = Me.NivelEducativo
            MsgBox("Datos Enviados Correctamente, Nombre de la escuela: " & Esc.nombreEsc & "y  Nivel Edicativo: " & Esc.nivel_Edu_esc)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
            conexion = Nothing
            comando = Nothing
        End Try

    End Sub

    Private Sub btnActualizarEscuela_Click(sender As Object, e As EventArgs) Handles btnActualizarEscuela.Click
        Try
            conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")

            strSQL = "UPDATE escuela SET id_escuela = @id_escuela, nombre = @nombre, nivel_educativo = @nivel_educativo WHERE id_escuela = @id_escuela"
            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_escuela", txtIdEscuela.Text)
            comando.Parameters.AddWithValue("@nombre", txtNomEscuela.Text)
            comando.Parameters.AddWithValue("@nivel_educativo", NivelEducativo)

            conexion.Open()
            comando.ExecuteNonQuery()

            Esc.nombreEsc = Me.txtNomEscuela.Text
            Esc.nivel_Edu_esc = Me.NivelEducativo
            MsgBox("Datos Actualizados Correctamente, Nombre de la escuela: " & Esc.nombreEsc & "y  Nivel Edicativo: " & Esc.nivel_Edu_esc)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
            conexion = Nothing
            comando = Nothing
        End Try
    End Sub

    Private Sub btnEliminarEscuela_Click(sender As Object, e As EventArgs) Handles btnEliminarEscuela.Click
        Try
            conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")

            strSQL = "DELETE FROM escuela WHERE id_escuela = @id_escuela"
            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_escuela", txtIdEscuela.Text)

            conexion.Open()
            comando.ExecuteNonQuery()
            MsgBox("Datos Eliminados Correctamente")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
            conexion = Nothing
            comando = Nothing
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")

            strSQL = "SELECT * FROM escuela WHERE id_escuela = @id_escuela"
            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_escuela", txtIdEscuela.Text)

            conexion.Open()
            dr = comando.ExecuteReader()

            Do While dr.Read
                txtNomEscuela.Text = dr("nombre")
                NivelEducativo = dr("nivel_educativo")
            Loop

            MsgBox("Datos Consultados Correctamente")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
            conexion = Nothing
            comando = Nothing
        End Try
    End Sub

    Private Sub btnMostrarTabla_Click(sender As Object, e As EventArgs) Handles btnMostrarTabla.Click
        Try
            conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")

            strSQL = "SELECT * FROM escuela"

            Dim dt As New DataTable

            da = New MySqlDataAdapter(strSQL, conexion)

            da.Fill(dt)

            dgvEscuela.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
            conexion = Nothing
            comando = Nothing
        End Try
    End Sub

    Private Sub rbPrimaria_CheckedChanged(sender As Object, e As EventArgs) Handles rbPrimaria.CheckedChanged
        NivelEducativo = "Primaria"
    End Sub

    Private Sub rbSecundaria_CheckedChanged(sender As Object, e As EventArgs) Handles rbSecundaria.CheckedChanged
        NivelEducativo = "Secundaria"
    End Sub

    Private Sub rbPreparatoria_CheckedChanged(sender As Object, e As EventArgs) Handles rbPreparatoria.CheckedChanged
        NivelEducativo = "Preparatoria"
    End Sub

    Private Sub rbUniversidad_CheckedChanged(sender As Object, e As EventArgs) Handles rbUniversidad.CheckedChanged
        NivelEducativo = "Universidad"
    End Sub

    Private Sub FrmEscuelaAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Function VerificaVacios() As Boolean
        Dim t As Control
        For Each t In Me.Controls
            If TypeOf t Is TextBox Then
                If Trim(t.Text) = "" Then
                    MsgBox("Debe de capturar este dato")
                    t.Select()
                End If
            End If
        Next
        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.VerificaVacios() = True Then
            If Me.verificaDatosNumericos = True Then
                Me.btnAgregar.Enabled = True
            End If
        End If
    End Sub

    Function verificaDatosNumericos() As Boolean
        If Not IsNumeric(Me.txtIdEscuela.Text) Then
            MsgBox("El id debe tener un valor numerico")
            Return False
        End If
        Return False
    End Function

    Function Filtro(ByVal busqueda As String) As DataTable
        conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")
        conexion.Open()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM escuela WHERE nombre LIKE '%" & busqueda & "%'", conexion)
        da.Fill(dt)
        conexion.Close()
        Return dt
    End Function

    Private Sub dgvEscuela_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEscuela.CellContentClick

    End Sub

    Private Sub TxtBuscarEscuela_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarEscuela.TextChanged
        If Filtro(TxtBuscarEscuela.Text).Rows.Count > 0 Then
            dgvEscuela.DataSource = Filtro(TxtBuscarEscuela.Text)
        End If
    End Sub
End Class