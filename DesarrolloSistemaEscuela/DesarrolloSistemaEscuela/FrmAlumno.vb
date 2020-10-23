Imports MySql.Data.MySqlClient

Public Class FrmAlumno
    Public Al As New ClsAlumno
    Private conexion As MySqlConnection
    Private comando As MySqlCommand
    Private da As MySqlDataAdapter
    Private dr As MySqlDataReader
    Private strSQL As String
    Public NivelEducativo As String

    Function verificaDatosNumericos() As Boolean
        If Not IsNumeric(Me.TxtIdAlumno.Text) Then
            MsgBox("El id debe tener un valor numerico")
            Return False
        End If

        If Not IsNumeric(Me.TxtEdadAlumno.Text) Then
            MsgBox("El id debe tener un valor numerico")
            Return False
        End If

        Return False
    End Function
    Private Sub BtnVerificar_Click(sender As Object, e As EventArgs) Handles BtnVerificar.Click
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

    Private Sub FrmAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.CmbEdadAlumno.DataSource = Me.creaTabla
        'Me.CmbEdadAlumno.DisplayMember = "edad"
        'Me.CmbEdadAlumno.SelectedIndex = 0

        Me.CmbEscuelaAlumno.DataSource = Me.CreaTabla1
        Me.CmbEscuelaAlumno.ValueMember = "id_escuela"
        Me.CmbEscuelaAlumno.DisplayMember = "nombre"
        Me.CmbEscuelaAlumno.SelectedIndex = 0

        Me.CmbGrupoAlumno.DataSource = Me.CreaTabla2
        Me.CmbGrupoAlumno.ValueMember = "id_grupo"
        Me.CmbGrupoAlumno.DisplayMember = "clasificacion_letra_mayuscula"
        Me.CmbGrupoAlumno.SelectedIndex = 0
    End Sub

    Private Function CreaTabla1() As Data.DataTable
        Dim t As New Data.DataTable
        conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")
        strSQL = "SELECT * FROM escuela"

        da = New MySqlDataAdapter(strSQL, conexion)

        da.Fill(t)
        conexion.Close()
        conexion = Nothing
        comando = Nothing

        Return t
    End Function

    Private Function CreaTabla2() As Data.DataTable
        Dim t As New Data.DataTable
        conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")
        strSQL = "SELECT * FROM grupo"

        da = New MySqlDataAdapter(strSQL, conexion)

        da.Fill(t)
        conexion.Close()
        conexion = Nothing
        comando = Nothing

        Return t
    End Function

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        Try
            conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")

            strSQL = "INSERT INTO alumno (id_alumno, nombre, apellido, correo, edad, nivel_educativo, id_escuela, id_grupo) VALUES (@id_alumno, @nombre, @apellido, @correo, @edad, @nivel_educativo, @id_escuela, @id_grupo)"

            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_alumno", TxtIdAlumno.Text)
            comando.Parameters.AddWithValue("@nombre", TxtNombreAlumno.Text)
            comando.Parameters.AddWithValue("@apellido", TxtApellidoAlumno.Text)
            comando.Parameters.AddWithValue("@correo", TxtCorreoAlumno.Text)
            comando.Parameters.AddWithValue("@edad", TxtEdadAlumno.Text)
            comando.Parameters.AddWithValue("@nivel_educativo", NivelEducativo)
            comando.Parameters.AddWithValue("@id_escuela", CmbEscuelaAlumno.SelectedIndex + 1)
            comando.Parameters.AddWithValue("@id_grupo", CmbGrupoAlumno.SelectedIndex + 1)

            conexion.Open()
            comando.ExecuteNonQuery()

            Al.id = Me.TxtIdAlumno.Text
            Al.nombreA = Me.TxtApellidoAlumno.Text
            Al.apellidoA = Me.TxtApellidoAlumno.Text
            Al.correoA = Me.TxtCorreoAlumno.Text
            Al.edadA = Me.TxtEdadAlumno.Text
            Al.nivel_educativoA = Me.NivelEducativo
            Al.id_escuelaA = Me.CmbEscuelaAlumno.Text
            Al.id_grupoA = Me.CmbGrupoAlumno.Text

            MsgBox("Datos Enviados Correctamente, id: " & Al.id & " Nombre: " & Al.nombreA & " Apellido: " & Al.apellidoA & " Correo: " & Al.correoA & " Edad: " & Al.edadA & " Nivel Educativo: " & Al.nivel_educativoA & " Numero de escuela: " & Al.id_escuelaA & " Grupo: " & Al.id_grupoA)

            TxtIdAlumno.Text = vbEmpty
            TxtNombreAlumno.Text = ""
            TxtApellidoAlumno.Text = ""
            TxtCorreoAlumno.Text = ""
            TxtEdadAlumno.Text = vbEmpty
            NivelEducativo = ""
            CmbEscuelaAlumno.Text = ""
            CmbGrupoAlumno.Text = ""


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

            strSQL = "UPDATE alumno SET id_alumno = @id_alumno, nombre = @nombre, apellido = @apellido, correo = @correo, edad = @edad, nivel_educativo = @nivel_educativo, id_escuela = @id_escuela, id_grupo = @id_grupo WHERE id_alumno = @id_alumno"
            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_alumno", TxtIdAlumno.Text)
            comando.Parameters.AddWithValue("@nombre", TxtNombreAlumno.Text)
            comando.Parameters.AddWithValue("@apellido", TxtApellidoAlumno.Text)
            comando.Parameters.AddWithValue("@correo", TxtCorreoAlumno.Text)
            comando.Parameters.AddWithValue("@edad", TxtEdadAlumno.Text)
            comando.Parameters.AddWithValue("@nivel_educativo", NivelEducativo)
            comando.Parameters.AddWithValue("@id_escuela", CmbEscuelaAlumno.SelectedIndex + 1)
            comando.Parameters.AddWithValue("@id_grupo", CmbGrupoAlumno.SelectedIndex + 1)

            conexion.Open()
            comando.ExecuteNonQuery()

            Al.id = Me.TxtIdAlumno.Text
            Al.nombreA = Me.TxtApellidoAlumno.Text
            Al.apellidoA = Me.TxtApellidoAlumno.Text
            Al.correoA = Me.TxtCorreoAlumno.Text
            Al.edadA = Me.TxtEdadAlumno.Text
            Al.nivel_educativoA = Me.NivelEducativo
            Al.id_escuelaA = Me.CmbEscuelaAlumno.Text
            Al.id_grupoA = Me.CmbGrupoAlumno.Text

            MsgBox("Datos Actualizados Correctamente, id: " & Al.id & " Nombre: " & Al.nombreA & " Apellido: " & Al.apellidoA & " Correo: " & Al.correoA & " Edad: " & Al.edadA & " Nivel Educativo: " & Al.nivel_educativoA & " Numero de escuela: " & Al.id_escuelaA & " Grupo: " & Al.id_grupoA)

            TxtIdAlumno.Text = vbEmpty
            TxtNombreAlumno.Text = ""
            TxtApellidoAlumno.Text = ""
            TxtCorreoAlumno.Text = ""
            TxtEdadAlumno.Text = vbEmpty
            NivelEducativo = ""
            CmbEscuelaAlumno.Text = ""
            CmbGrupoAlumno.Text = ""

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

            strSQL = "DELETE FROM alumno WHERE id_alumno = @id_alumno"
            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_alumno", TxtIdAlumno.Text)

            conexion.Open()
            comando.ExecuteNonQuery()

            Al.id = Me.TxtIdAlumno.Text
            MsgBox("Alumno eliminado, se elimino el id: " & Al.id & "Correctamente")

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

            strSQL = "SELECT * FROM alumno WHERE id_alumno = @id_alumno"
            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_alumno", TxtIdAlumno.Text)

            conexion.Open()
            dr = comando.ExecuteReader()

            Do While dr.Read
                TxtNombreAlumno.Text = dr("nombre")
                TxtApellidoAlumno.Text = dr("apellido")
                TxtCorreoAlumno.Text = dr("correo")
                TxtEdadAlumno.Text = dr("edad")
                NivelEducativo = dr("nivel_educativo")
                CmbEscuelaAlumno.Text = dr("id_escuela")
                CmbGrupoAlumno.Text = dr("id_grupo")
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

    Private Sub BtnConsultaGeneralAlumno_Click(sender As Object, e As EventArgs) Handles BtnConsultaGeneralAlumno.Click
        Try
            conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")

            strSQL = "SELECT * FROM alumno"

            Dim dt As New DataTable

            da = New MySqlDataAdapter(strSQL, conexion)

            da.Fill(dt)

            DgvAlumno.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
            conexion = Nothing
            comando = Nothing
        End Try
    End Sub

    Private Sub DgvAlumno_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvAlumno.CellContentClick

    End Sub

    Private Sub TxtBuscarAlumno_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarAlumno.TextChanged
        If Filtro(TxtBuscarAlumno.Text).Rows.Count > 0 Then
            DgvAlumno.DataSource = Filtro(TxtBuscarAlumno.Text)
        End If
    End Sub

    Function Filtro(ByVal busqueda As String) As DataTable
        conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")
        conexion.Open()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM alumno WHERE nombre LIKE '%" & busqueda & "%'", conexion)
        da.Fill(dt)
        conexion.Close()
        Return dt
    End Function
End Class