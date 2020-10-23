Imports MySql.Data.MySqlClient

Public Class FrmCurso
    Public Cu As New ClsCurso
    Private conexion As MySqlConnection
    Private comando As MySqlCommand
    Private da As MySqlDataAdapter
    Private dr As MySqlDataReader
    Private strSQL As String
    Private Sub FrmCurso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CmbIdNumSalon.DataSource = Me.CreaTabla1
        Me.CmbIdNumSalon.ValueMember = "id_num_salon"
        Me.CmbIdNumSalon.DisplayMember = "capacidad"
        Me.CmbIdNumSalon.SelectedIndex = 0

        Me.CmbIdMateria.DataSource = Me.CreaTabla2
        Me.CmbIdMateria.ValueMember = "id_materia"
        Me.CmbIdMateria.DisplayMember = "nombre_m"
        Me.CmbIdMateria.SelectedIndex = 0
    End Sub

    Private Function CreaTabla1() As Data.DataTable
        Dim t As New Data.DataTable
        conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")
        strSQL = "SELECT * FROM salon"

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

            strSQL = "INSERT INTO curso (id_curso, periodo, id_num_salon, id_materia) VALUES (@id_curso, @periodo, @id_num_salon, @id_materia)"

            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_curso", TxtId_curso.Text)
            comando.Parameters.AddWithValue("@periodo", TxtPeriodo.Text)
            comando.Parameters.AddWithValue("@id_num_salon", CmbIdNumSalon.SelectedIndex + 1)
            comando.Parameters.AddWithValue("@id_materia", CmbIdMateria.SelectedIndex + 1)

            conexion.Open()
            comando.ExecuteNonQuery()

            Cu.NumCurso = Me.TxtId_curso.Text
            Cu.PeriodoCurso = Me.TxtPeriodo.Text
            Cu.NumSalon = Me.CmbIdNumSalon.Text
            Cu.NumMateria = Me.CmbIdMateria.Text

            MsgBox("Datos Enviados son Id: " & Cu.NumCurso & " Periodo: " & Cu.PeriodoCurso & " Numero de salon: " & Cu.NumSalon & " Numero de Materia: " & Cu.NumMateria)

            TxtId_curso.Text = ""
            TxtPeriodo.Text = ""
            CmbIdNumSalon.Text = ""
            CmbIdMateria.Text = ""

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

            strSQL = "UPDATE curso SET id_curso = @id_curso, periodo = @periodo, id_num_salon = @id_num_salon, id_materia = @id_materia WHERE id_curso = @id_curso"

            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_curso", TxtId_curso.Text)
            comando.Parameters.AddWithValue("@periodo", TxtPeriodo.Text)
            comando.Parameters.AddWithValue("@id_num_salon", CmbIdNumSalon.SelectedIndex + 1)
            comando.Parameters.AddWithValue("@id_materia", CmbIdMateria.SelectedIndex + 1)

            conexion.Open()
            comando.ExecuteNonQuery()

            Cu.NumCurso = Me.TxtId_curso.Text
            Cu.PeriodoCurso = Me.TxtPeriodo.Text
            Cu.NumSalon = Me.CmbIdNumSalon.Text
            Cu.NumMateria = Me.CmbIdMateria.Text

            MsgBox("Los Datos Actualizados son Id: " & Cu.NumCurso & " Periodo: " & Cu.PeriodoCurso & " Numero de salon: " & Cu.NumSalon & " Numero de Materia: " & Cu.NumMateria)

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

            strSQL = "DELETE FROM curso WHERE id_curso = @id_curso"
            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_curso", TxtId_curso.Text)

            conexion.Open()
            comando.ExecuteNonQuery()

            Cu.NumCurso = Me.TxtId_curso.Text

            MsgBox("El curso numero: " & Cu.NumCurso & "Se elimino Corretamente")

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

            strSQL = "SELECT * FROM curso WHERE id_curso = @id_curso"
            comando = New MySqlCommand(strSQL, conexion)
            comando.Parameters.AddWithValue("@id_curso", TxtId_curso.Text)

            conexion.Open()
            dr = comando.ExecuteReader()

            Do While dr.Read
                TxtPeriodo.Text = dr("periodo")
                CmbIdNumSalon.Text = dr("id_num_salon")
                CmbIdMateria.Text = dr("id_materia")
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

    Private Sub BtnConsultaGeneralCurso_Click(sender As Object, e As EventArgs) Handles BtnConsultaGeneralCurso.Click
        Try
            conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")

            strSQL = "SELECT * FROM curso"

            Dim dt As New DataTable

            da = New MySqlDataAdapter(strSQL, conexion)

            da.Fill(dt)

            DgvCurso.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
            conexion = Nothing
            comando = Nothing
        End Try
    End Sub

    Private Sub TxtBuscarCurso_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarCurso.TextChanged
        If Filtro(TxtBuscarCurso.Text).Rows.Count > 0 Then
            DgvCurso.DataSource = Filtro(TxtBuscarCurso.Text)
        End If
    End Sub
    Function Filtro(ByVal busqueda As String) As DataTable
        conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")
        conexion.Open()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM curso WHERE periodo LIKE '%" & busqueda & "%'", conexion)
        da.Fill(dt)
        conexion.Close()
        Return dt
    End Function
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
        If Not IsNumeric(Me.TxtId_curso.Text) Then
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
End Class