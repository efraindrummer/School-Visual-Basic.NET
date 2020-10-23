Imports MySql.Data.MySqlClient

Public Class FrmGrupo
    Public Gp As New ClsGrupo
    Private conexion As MySqlConnection
    Private comando As MySqlCommand
    Private da As MySqlDataAdapter
    Private dr As MySqlDataReader
    Private strSQL As String
    Private Sub BtnVerificaVacios_Click(sender As Object, e As EventArgs) Handles BtnVerificaVacios.Click
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
        If Not IsNumeric(Me.TxtIdGrupo.Text) Then
            MsgBox("El id debe tener un valor numerico")
            Return False
        End If

        Return False
    End Function

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        Try
            conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")

            strSQL = "INSERT INTO grupo (id_grupo, clasificacion_letra_mayuscula) VALUES (@id_grupo, @clasificacion_letra_mayuscula)"

            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_grupo", TxtIdGrupo.Text)
            comando.Parameters.AddWithValue("@clasificacion_letra_mayuscula", TxtGrupo.Text)

            conexion.Open()
            comando.ExecuteNonQuery()

            Gp.IdGrupo = Me.TxtIdGrupo.Text
            Gp.Clasificacion = Me.TxtGrupo.Text

            MsgBox("Datos Enviados son Id: " & Gp.IdGrupo & " Clasificacion: " & Gp.Clasificacion)


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

            strSQL = "UPDATE grupo SET id_grupo = @id_grupo, clasificacion_letra_mayuscula = @clasificacion_letra_mayuscula WHERE id_grupo = @id_grupo"

            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_grupo", TxtIdGrupo.Text)
            comando.Parameters.AddWithValue("@clasificacion_letra_mayuscula", TxtGrupo.Text)

            conexion.Open()
            comando.ExecuteNonQuery()

            Gp.IdGrupo = Me.TxtIdGrupo.Text
            Gp.Clasificacion = Me.TxtGrupo.Text

            MsgBox("Datos Actualizados son Id: " & Gp.IdGrupo & " Clasificacion: " & Gp.Clasificacion)

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

            strSQL = "DELETE FROM grupo WHERE id_grupo = @id_grupo"
            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_grupo", TxtIdGrupo.Text)

            conexion.Open()
            comando.ExecuteNonQuery()

            Gp.IdGrupo = Me.TxtIdGrupo.Text

            MsgBox("El Id_grupo " & Gp.IdGrupo & "Se elimino Corretamente")

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

            strSQL = "SELECT * FROM grupo WHERE id_grupo = @id_grupo"
            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_grupo", TxtIdGrupo.Text)

            conexion.Open()
            dr = comando.ExecuteReader()

            Do While dr.Read
                TxtIdGrupo.Text = dr("id_grupo")
                TxtGrupo.Text = dr("clasificacion_letra_mayuscula")
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

    Private Sub BtnConsultaGeneralGrupo_Click(sender As Object, e As EventArgs) Handles BtnConsultaGeneralGrupo.Click
        Try
            conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")

            strSQL = "SELECT * FROM grupo"

            Dim dt As New DataTable

            da = New MySqlDataAdapter(strSQL, conexion)

            da.Fill(dt)

            DgvGrupo.DataSource = dt

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
        Dim da As New MySqlDataAdapter("SELECT * FROM grupo WHERE clasificacion_letra_mayuscula LIKE '%" & busqueda & "%'", conexion)
        da.Fill(dt)
        conexion.Close()
        Return dt
    End Function

    Private Sub TxtBuscarGrupo_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarGrupo.TextChanged
        If Filtro(TxtBuscarGrupo.Text).Rows.Count > 0 Then
            DgvGrupo.DataSource = Filtro(TxtBuscarGrupo.Text)
        End If
    End Sub
End Class