Imports MySql.Data.MySqlClient
Public Class FrmSalon
    Public EscSalon As New ClsSalon
    Private conexion As MySqlConnection
    Private comando As MySqlCommand
    Private da As MySqlDataAdapter
    Private dr As MySqlDataReader
    Private strSQL As String
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Try
            conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")

            strSQL = "INSERT INTO salon (id_num_salon, capacidad, cupo_actual, fk_status_salon) VALUES (@id_num_salon, @capacidad, @cupo_actual, @fk_status_salon)"

            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_num_salon", TxtNumSalon.Text)
            comando.Parameters.AddWithValue("@capacidad", TxtCapacidad.Text)
            comando.Parameters.AddWithValue("@cupo_actual", TxtCupoActual.Text)
            comando.Parameters.AddWithValue("@fk_status_salon", CmbStatusSalon.SelectedIndex + 1)

            conexion.Open()
            comando.ExecuteNonQuery()

            EscSalon.idSln = Me.TxtNumSalon.Text
            EscSalon.CapacidadSalon = Me.TxtCapacidad.Text
            EscSalon.CupoActualSalon = Me.TxtCupoActual.Text
            EscSalon.StaSalon = Me.CmbStatusSalon.Text

            MsgBox("Datos Enviados Correctamente, Numero de salon: " & EscSalon.idSln & "Capacidad: " & EscSalon.CapacidadSalon & " Cupo Actual: " & EscSalon.CupoActualSalon & "Estatus: " & EscSalon.StaSalon)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
            conexion = Nothing
            comando = Nothing
        End Try
    End Sub

    Private Function CreaTabla() As Data.DataTable
        Dim t As New Data.DataTable
        conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")
        strSQL = "SELECT * FROM estatus_salon"

        da = New MySqlDataAdapter(strSQL, conexion)

        da.Fill(t)
        conexion.Close()
        conexion = Nothing
        comando = Nothing

        Return t
    End Function

    Private Sub FrmSalon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CmbStatusSalon.DataSource = Me.CreaTabla
        Me.CmbStatusSalon.ValueMember = "id_est_salon"
        Me.CmbStatusSalon.DisplayMember = "status_salon"
        Me.CmbStatusSalon.SelectedIndex = 0
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

    Private Sub BtnVerificaVacios_Click(sender As Object, e As EventArgs) Handles BtnVerificaVacios.Click
        If Me.VerificaVacios() = True Then
            If Me.verificaDatosNumericos = True Then
                Me.BtnIngresar.Enabled = True
            End If
        End If
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")

            strSQL = "UPDATE salon SET id_num_salon = @id_num_salon, capacidad = @capacidad, cupo_actual = @cupo_actual, fk_status_salon = @fk_status_salon WHERE id_num_salon = @id_num_salon"
            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_num_salon", TxtNumSalon.Text)
            comando.Parameters.AddWithValue("@capacidad", TxtCapacidad.Text)
            comando.Parameters.AddWithValue("@cupo_actual", TxtCupoActual.Text)
            comando.Parameters.AddWithValue("@fk_status_salon", CmbStatusSalon.SelectedIndex + 1)

            conexion.Open()
            comando.ExecuteNonQuery()

            EscSalon.idSln = Me.TxtNumSalon.Text
            EscSalon.CapacidadSalon = Me.TxtCapacidad.Text
            EscSalon.CupoActualSalon = Me.TxtCupoActual.Text
            EscSalon.StaSalon = Me.CmbStatusSalon.Text

            MsgBox("Datos Enviados Correctamente, Numero de salon: " & EscSalon.idSln & "Capacidad: " & EscSalon.CapacidadSalon & " Cupo Actual: " & EscSalon.CupoActualSalon & "Estatus: " & EscSalon.StaSalon)

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

            strSQL = "DELETE FROM salon WHERE id_num_salon = @id_num_salon"
            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_num_salon", TxtNumSalon.Text)

            conexion.Open()
            comando.ExecuteNonQuery()
            EscSalon.idSln = Me.TxtNumSalon.Text

            MsgBox("El Salon " & EscSalon.idSln & " Se elimino Corretamente")

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

            strSQL = "SELECT * FROM salon WHERE id_num_salon = @id_num_salon"
            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_num_salon", TxtNumSalon.Text)

            conexion.Open()
            dr = comando.ExecuteReader()

            Do While dr.Read
                TxtCapacidad.Text = dr("capacidad")
                TxtCupoActual.Text = dr("cupo_actual")
                CmbStatusSalon.Text = dr("fk_status_salon")
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

    Private Sub BtnConsultaGeneralSalon_Click(sender As Object, e As EventArgs) Handles BtnConsultaGeneralSalon.Click
        Try
            conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")

            strSQL = "SELECT * FROM salon"

            Dim dt As New DataTable

            da = New MySqlDataAdapter(strSQL, conexion)

            da.Fill(dt)

            DgvSalon.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
            conexion = Nothing
            comando = Nothing
        End Try
    End Sub

    Function verificaDatosNumericos() As Boolean
        If Not IsNumeric(Me.TxtNumSalon.Text) Then
            MsgBox("El id debe tener un valor numerico")
            Return False
        End If

        Return False
    End Function

    Private Sub LblAnuncio_Click(sender As Object, e As EventArgs)

    End Sub

    Function Filtro(ByVal busqueda As String) As DataTable
        conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")
        conexion.Open()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM salon WHERE id_num_salon LIKE '%" & busqueda & "%'", conexion)
        da.Fill(dt)
        conexion.Close()
        Return dt
    End Function

    Private Sub TxtBuscarSalon_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarSalon.TextChanged
        If Filtro(TxtBuscarSalon.Text).Rows.Count > 0 Then
            DgvSalon.DataSource = Filtro(TxtBuscarSalon.Text)
        End If
    End Sub
End Class