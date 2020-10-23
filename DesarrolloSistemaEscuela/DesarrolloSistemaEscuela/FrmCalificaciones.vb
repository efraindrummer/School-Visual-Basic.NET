Imports MySql.Data.MySqlClient

Public Class FrmCalificaciones
    Public Ca As New ClsCalificaciones
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
        If Not IsNumeric(Me.txtNumCalificacion.Text) Then
            MsgBox("El id debe tener un valor numerico")
            Return False
        End If

        If Not IsNumeric(Me.TxtCalificacion.Text) Then
            MsgBox("La calificacion debe tener un valor numerico")
            Return False
        End If

        Return False
    End Function

    Private Sub FrmCalificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CmbStatusAL.DataSource = Me.CreaTabla1
        Me.CmbStatusAL.ValueMember = "id_est_alum"
        Me.CmbStatusAL.DisplayMember = "status_alumno"
        Me.CmbStatusAL.SelectedIndex = 0

        Me.CmbAlumnoId.DataSource = Me.CreaTabla2
        Me.CmbAlumnoId.ValueMember = "id_alumno"
        Me.CmbAlumnoId.DisplayMember = "nombre"
        Me.CmbAlumnoId.SelectedIndex = 0

        Me.CmbProfesorID.DataSource = Me.CreaTabla3
        Me.CmbProfesorID.ValueMember = "id_profesor"
        Me.CmbProfesorID.DisplayMember = "nombre_profesor"
        Me.CmbProfesorID.SelectedIndex = 0

        Me.CmbMateriaID.DataSource = Me.CreaTabla4
        Me.CmbMateriaID.ValueMember = "id_materia"
        Me.CmbMateriaID.DisplayMember = "nombre_m"
        Me.CmbMateriaID.SelectedIndex = 0
    End Sub

    Private Function CreaTabla1() As Data.DataTable
        Dim t As New Data.DataTable
        conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")
        strSQL = "SELECT * FROM estatus_alumno"

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
        strSQL = "SELECT * FROM alumno"

        da = New MySqlDataAdapter(strSQL, conexion)

        da.Fill(t)
        conexion.Close()
        conexion = Nothing
        comando = Nothing

        Return t
    End Function

    Private Function CreaTabla3() As Data.DataTable
        Dim t As New Data.DataTable
        conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")
        strSQL = "SELECT * FROM profesor"

        da = New MySqlDataAdapter(strSQL, conexion)

        da.Fill(t)
        conexion.Close()
        conexion = Nothing
        comando = Nothing

        Return t
    End Function

    Private Function CreaTabla4() As Data.DataTable
        Dim t As New Data.DataTable
        conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")
        strSQL = "SELECT * FROM materia"

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

            strSQL = "INSERT INTO calificaciones (id_calificacion, calificacion, id_est_alum, id_alumno, id_profesor, id_materia) VALUES (@id_calificacion, @calificacion, @id_est_alum, @id_alumno, @id_profesor, @id_materia)"

            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_calificacion", txtNumCalificacion.Text)
            comando.Parameters.AddWithValue("@calificacion", TxtCalificacion.Text)
            comando.Parameters.AddWithValue("@id_est_alum", CmbStatusAL.SelectedIndex + 1)
            comando.Parameters.AddWithValue("@id_alumno", CmbAlumnoId.SelectedIndex + 1)
            comando.Parameters.AddWithValue("@id_profesor", CmbProfesorID.SelectedIndex + 1)
            comando.Parameters.AddWithValue("@id_materia", CmbMateriaID.SelectedIndex + 1)

            conexion.Open()
            comando.ExecuteNonQuery()

            Ca.id = Me.txtNumCalificacion.Text
            Ca.calificacion = Me.TxtCalificacion.Text
            Ca.id_status_alum = Me.CmbStatusAL.Text
            Ca.id_alum = Me.CmbAlumnoId.Text
            Ca.id_profe = Me.CmbProfesorID.Text
            Ca.id_mat = Me.CmbMateriaID.Text


            MsgBox("Datos Enviados Correctamente, id: " & Ca.id & " Calificacion: " & Ca.calificacion & " status salumno: " & Ca.id_status_alum & " id Alumno: " & Ca.id_alum & " Id Profesor: " & Ca.id_profe & " Id Materia: " & Ca.id_mat)

            txtNumCalificacion.Text = ""
            TxtCalificacion.Text = ""
            CmbStatusAL.Text = ""
            CmbAlumnoId.Text = ""
            CmbProfesorID.Text = ""
            CmbMateriaID.Text = ""

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

            strSQL = "UPDATE calificaciones SET id_calificacion = @id_calificacion, calificacion = @calificacion, id_est_alum = @id_est_alum, id_alumno = @id_alumno, id_profesor = @id_profesor, id_materia = @id_materia WHERE id_calificacion = @id_calificacion"

            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_calificacion", txtNumCalificacion.Text)
            comando.Parameters.AddWithValue("@calificacion", TxtCalificacion.Text)
            comando.Parameters.AddWithValue("@id_est_alum", CmbStatusAL.SelectedIndex + 1)
            comando.Parameters.AddWithValue("@id_alumno", CmbAlumnoId.SelectedIndex + 1)
            comando.Parameters.AddWithValue("@id_profesor", CmbProfesorID.SelectedIndex + 1)
            comando.Parameters.AddWithValue("@id_materia", CmbMateriaID.SelectedIndex + 1)

            conexion.Open()
            comando.ExecuteNonQuery()

            Ca.id = Me.txtNumCalificacion.Text
            Ca.calificacion = Me.TxtCalificacion.Text
            Ca.id_status_alum = Me.CmbStatusAL.Text
            Ca.id_alum = Me.CmbAlumnoId.Text
            Ca.id_profe = Me.CmbProfesorID.Text
            Ca.id_mat = Me.CmbMateriaID.Text


            MsgBox("Datos Actualizados Correctamente, id: " & Ca.id & " Calificacion: " & Ca.calificacion & " status salumno: " & Ca.id_status_alum & " id Alumno: " & Ca.id_alum & " Id Profesor: " & Ca.id_profe & " Id Materia: " & Ca.id_mat)

            txtNumCalificacion.Text = ""
            TxtCalificacion.Text = ""
            CmbStatusAL.Text = ""
            CmbAlumnoId.Text = ""
            CmbProfesorID.Text = ""
            CmbMateriaID.Text = ""

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

            strSQL = "DELETE FROM calificaciones WHERE id_calificacio = @id_calificacion"
            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_calificacion", txtNumCalificacion.Text)

            conexion.Open()
            comando.ExecuteNonQuery()

            Ca.id = Me.txtNumCalificacion.Text
            MsgBox("La calificacion : " & Ca.id & " se elimino Correctamente")

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

            strSQL = "SELECT * FROM calificaciones WHERE id_calificacion = @id_calificacion"
            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_calificacion", txtNumCalificacion.Text)

            conexion.Open()
            dr = comando.ExecuteReader()

            Do While dr.Read
                txtNumCalificacion.Text = dr("id_calificacion")
                TxtCalificacion.Text = dr("calificacion")
                CmbStatusAL.Text = dr("id_est_alum")
                CmbAlumnoId.Text = dr("id_alumno")
                CmbProfesorID = dr("id_profesor")
                CmbMateriaID.Text = dr("id_materia")
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

    Private Sub BtnConsultaGeneralCalificaciones_Click(sender As Object, e As EventArgs) Handles BtnConsultaGeneralCalificaciones.Click
        Try
            conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")

            strSQL = "SELECT * FROM calificaciones"

            Dim dt As New DataTable

            da = New MySqlDataAdapter(strSQL, conexion)

            da.Fill(dt)

            DgvCalificaciones.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
            conexion = Nothing
            comando = Nothing
        End Try
    End Sub

    Private Sub TxtBuscarCalificacion_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarCalificacion.TextChanged
        If Filtro(TxtBuscarCalificacion.Text).Rows.Count > 0 Then
            DgvCalificaciones.DataSource = Filtro(TxtBuscarCalificacion.Text)
        End If
    End Sub
    Function Filtro(ByVal busqueda As String) As DataTable
        conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")
        conexion.Open()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM calificaciones WHERE calificacion LIKE '%" & busqueda & "%'", conexion)
        da.Fill(dt)
        conexion.Close()
        Return dt
    End Function
End Class