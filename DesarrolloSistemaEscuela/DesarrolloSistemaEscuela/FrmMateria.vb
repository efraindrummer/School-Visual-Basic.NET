Imports MySql.Data.MySqlClient

Public Class FrmMateria
    Public Ma As New ClsMateria
    Private conexion As MySqlConnection
    Private comando As MySqlCommand
    Private da As MySqlDataAdapter
    Private dr As MySqlDataReader
    Private strSQL As String

    Private Sub BtnVerificarVacios_Click(sender As Object, e As EventArgs) Handles BtnVerificarVacios.Click
        If Me.VerificaVacios() = True Then
            If Me.verificaDatosNumericos = True Then
                Me.BtnInsertar.Enabled = True
            End If
        End If
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
    Function verificaDatosNumericos() As Boolean
        If Not IsNumeric(Me.TxtidMateria.Text) Then
            MsgBox("El id debe tener un valor numerico")
            Return False
        End If

        Return False
    End Function

    Private Sub FrmMateria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        Try
            conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")

            strSQL = "INSERT INTO materia (id_materia, nombre_m) VALUES (@id_materia, @nombre_m)"

            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_materia", TxtidMateria.Text)
            comando.Parameters.AddWithValue("@nombre_m", TxtNombreMateria.Text)

            conexion.Open()
            comando.ExecuteNonQuery()

            Ma.IdMateria = Me.TxtidMateria.Text
            Ma.nomMateria = Me.TxtNombreMateria.Text

            MsgBox("Datos Enviados son Id: " & Ma.IdMateria & " Nombre de Materia: " & Ma.nomMateria)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
            conexion = Nothing
            comando = Nothing
        End Try
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")

            strSQL = "UPDATE materia SET id_materia = @id_materia, nombre_m = @nombre_m WHERE id_materia = @id_materia"

            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_materia", TxtidMateria.Text)
            comando.Parameters.AddWithValue("@nombre_m", TxtNombreMateria.Text)

            conexion.Open()
            comando.ExecuteNonQuery()


            Ma.IdMateria = Me.TxtidMateria.Text
            Ma.nomMateria = Me.TxtNombreMateria.Text

            MsgBox("Datos Actualizados son Id: " & Ma.IdMateria & " Nombre de Materia: " & Ma.nomMateria)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
            conexion = Nothing
            comando = Nothing
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")

            strSQL = "DELETE FROM materia WHERE id_materia = @id_materia"
            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_materia", TxtidMateria.Text)

            conexion.Open()
            comando.ExecuteNonQuery()

            Ma.IdMateria = Me.TxtidMateria.Text

            MsgBox("El Id_materia " & Ma.IdMateria & "Selimino Corretamente")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
            conexion = Nothing
            comando = Nothing
        End Try
    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Try
            conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")

            strSQL = "SELECT * FROM materia WHERE id_materia = @id_materia"
            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_materia", TxtidMateria.Text)

            conexion.Open()
            dr = comando.ExecuteReader()

            Do While dr.Read
                TxtidMateria.Text = dr("id_materia")
                TxtNombreMateria.Text = dr("nombre_m")
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

    Private Sub BtnConsultaGeneralMateria_Click(sender As Object, e As EventArgs) Handles BtnConsultaGeneralMateria.Click
        Try
            conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")

            strSQL = "SELECT * FROM materia"

            Dim dt As New DataTable

            da = New MySqlDataAdapter(strSQL, conexion)

            da.Fill(dt)

            DgvMateria.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
            conexion = Nothing
            comando = Nothing
        End Try
    End Sub
    Function Filtro(ByVal busqueda As String) As DataTable
        conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")
        conexion.Open()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM materia WHERE nombre_m LIKE '%" & busqueda & "%'", conexion)
        da.Fill(dt)
        conexion.Close()
        Return dt
    End Function
    Private Sub TxtBuscarMateria_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarMateria.TextChanged
        If Filtro(TxtBuscarMateria.Text).Rows.Count > 0 Then
            DgvMateria.DataSource = Filtro(TxtBuscarMateria.Text)
        End If
    End Sub
End Class