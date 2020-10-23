Imports MySql.Data.MySqlClient

Public Class FrmProfesor
    Public Pr As New ClsProfesor
    Private conexionP As MySqlConnection
    Private comandoP As MySqlCommand
    Private dap As MySqlDataAdapter
    Private drp As MySqlDataReader
    Private strSQL As String

    Private Sub BtnIngresarDatos_Click(sender As Object, e As EventArgs) Handles BtnIngresarDatos.Click
        Try
            conexionP = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")

            strSQL = "INSERT INTO profesor (id_profesor, nombre_profesor, apellido_profesor, id_escuela) VALUES (@id_profesor, @nombre_profesor, @apellido_profesor, @id_escuela)"

            comandoP = New MySqlCommand(strSQL, conexionP)
            comandoP.Parameters.AddWithValue("@id_profesor", TxtIdprofesor.Text)
            comandoP.Parameters.AddWithValue("@nombre_profesor", TxtNombreProfesor.Text)
            comandoP.Parameters.AddWithValue("@apellido_profesor", TxtApellidoProfesor.Text)
            comandoP.Parameters.AddWithValue("@id_escuela", CmbEscuela.SelectedIndex + 1)

            conexionP.Open()
            comandoP.ExecuteNonQuery()

            Pr.nombreprf = Me.TxtNombreProfesor.Text
            Pr.apellidoprf = Me.TxtApellidoProfesor.Text
            Pr.id_escuelaprf = Me.CmbEscuela.Text

            MsgBox("Datos Enviados son Nombre: " & Pr.nombreprf & " Apellido: " & Pr.apellidoprf & "Escuela: " & Pr.id_escuelaprf)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexionP.Close()
            conexionP = Nothing
            comandoP = Nothing
        End Try
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            conexionP = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")

            strSQL = "UPDATE profesor SET id_profesor = @id_profesor, nombre_profesor = @nombre_profesor, apellido_profesor = @apellido_profesor, id_escuela = @id_escuela WHERE id_profesor = @id_profesor"

            comandoP = New MySqlCommand(strSQL, conexionP)

            comandoP.Parameters.AddWithValue("@id_profesor", TxtIdprofesor.Text)
            comandoP.Parameters.AddWithValue("@nombre_profesor", TxtNombreProfesor.Text)
            comandoP.Parameters.AddWithValue("@apellido_profesor", TxtApellidoProfesor)
            comandoP.Parameters.AddWithValue("@id_escuela", CmbEscuela.SelectedIndex + 1)

            conexionP.Open()
            comandoP.ExecuteNonQuery()

            Pr.nombreprf = Me.TxtNombreProfesor.Text
            Pr.apellidoprf = Me.TxtApellidoProfesor.Text
            Pr.id_escuelaprf = Me.CmbEscuela.Text

            MsgBox("Datos Actualizados son Nombre: " & Pr.nombreprf & " Apellido: " & Pr.apellidoprf & "Escuela: " & Pr.id_escuelaprf)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexionP.Close()
            conexionP = Nothing
            comandoP = Nothing
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        Try
            conexionP = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")

            strSQL = "DELETE FROM profesor WHERE id_profesor = @id_profesor"
            comandoP = New MySqlCommand(strSQL, conexionP)
            comandoP.Parameters.AddWithValue("@id_profesor", TxtIdprofesor.Text)

            conexionP.Open()
            comandoP.ExecuteNonQuery()
            Pr.idProfe = Me.TxtIdprofesor.Text

            MsgBox("El profesor" & Pr.idProfe & "Selimino Corretamente")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexionP.Close()
            conexionP = Nothing
            comandoP = Nothing
        End Try
    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Try
            conexionP = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")

            strSQL = "SELECT * FROM profesor WHERE id_profesor = @id_profesor"
            comandoP = New MySqlCommand(strSQL, conexionP)
            comandoP.Parameters.AddWithValue("@id_profesor", TxtIdprofesor.Text)

            conexionP.Open()
            drp = comandoP.ExecuteReader()

            Do While drp.Read
                TxtNombreProfesor.Text = drp("nombre_profesor")
                TxtApellidoProfesor.Text = drp("apellido_profesor")
                CmbEscuela.Text = drp("id_escuela")
            Loop

            MsgBox("Datos Consultados Correctamente")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexionP.Close()
            conexionP = Nothing
            comandoP = Nothing
        End Try
    End Sub

    Private Sub BtnConsultaGeneral_Click(sender As Object, e As EventArgs) Handles BtnConsultaGeneral.Click
        Try
            conexionP = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")

            strSQL = "SELECT * FROM profesor"

            Dim dt As New DataTable

            dap = New MySqlDataAdapter(strSQL, conexionP)

            dap.Fill(dt)

            DgvProfesor.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexionP.Close()
            conexionP = Nothing
            comandoP = Nothing
        End Try
    End Sub

    Private Function CreaTabla() As Data.DataTable
        Dim t As New Data.DataTable
        conexionP = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")
        strSQL = "SELECT * FROM escuela"

        dap = New MySqlDataAdapter(strSQL, conexionP)

        dap.Fill(t)
        conexionP.Close()
        conexionP = Nothing
        comandoP = Nothing

        Return t
    End Function
    Private Sub FrmProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CmbEscuela.DataSource = Me.CreaTabla
        Me.CmbEscuela.ValueMember = "id_escuela"
        Me.CmbEscuela.DisplayMember = "nombre"
        Me.CmbEscuela.SelectedIndex = 0
    End Sub

    Private Sub CmbEscuela_SelectedIndexChanged(sender As Object, e As EventArgs)

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

    Private Sub BtnVerificarVacios_Click(sender As Object, e As EventArgs) Handles BtnVerificarVacios.Click
        If Me.VerificaVacios() = True Then
            If Me.verificaDatosNumericos = True Then
                Me.BtnIngresarDatos.Enabled = True
            End If
        End If
    End Sub

    Private Sub CmbEscuela_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CmbEscuela.SelectedIndexChanged

    End Sub

    Private Sub TxtBuscarProfesor_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarProfesor.TextChanged
        If Filtro(TxtBuscarProfesor.Text).Rows.Count > 0 Then
            DgvProfesor.DataSource = Filtro(TxtBuscarProfesor.Text)
        End If
    End Sub
    Function Filtro(ByVal busqueda As String) As DataTable
        conexionP = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")
        conexionP.Open()
        Dim dtP As New DataTable
        Dim daP As New MySqlDataAdapter("SELECT * FROM profesor WHERE nombre_profesor LIKE '%" & busqueda & "%'", conexionP)
        daP.Fill(dtP)
        conexionP.Close()
        Return dtP
    End Function
    Function verificaDatosNumericos() As Boolean
        If Not IsNumeric(Me.TxtIdprofesor.Text) Then
            MsgBox("El id debe tener un valor numerico")
            Return False
        End If

        Return False
    End Function
End Class