Imports MySql.Data.MySqlClient
Public Class FrmConsulta1
    Private conexion As MySqlConnection
    Private da As MySqlDataAdapter
    Private strSQL As String
    Private Sub FrmConsulta1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnConsulta1_Click(sender As Object, e As EventArgs) Handles BtnConsulta1.Click
        Try
            conexion = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")

            'strSQL = "SELECT a.nombre, a.apellido, a.id_alumno, c.calificacion, m.nombre_m 
            'From escuela.alumno a INNER Join escuela.calificaciones AS c ON a.id_alumno = c.id_calificacion 
            'INNER Join escuela.materia AS m ON c.id_materia = m.id_materia Where c.calificacion = 
            '(Select MAX(calificacion) From escuela.calificaciones Where calificacion > 90)ORDER BY a.nombre ASC;"
            strSQL = "Select * FROM los_mas_altos;"

            Dim dt As New DataTable

            da = New MySqlDataAdapter(strSQL, conexion)

            da.Fill(dt)

            DgvConsulta1.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Function Filtro(ByVal busqueda As String) As DataTable
        conexion = New MySqlConnection("Server= localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")
        conexion.Open()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("Select * FROM los_mas_altos WHERE nombre Like '%" & busqueda & "%'", conexion)
        da.Fill(dt)
        conexion.Close()
        Return dt
    End Function

    Private Sub TxtBuscaConsulta1_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscaConsulta1.TextChanged
        If Filtro(TxtBuscaConsulta1.Text).Rows.Count > 0 Then
            DgvConsulta1.DataSource = Filtro(TxtBuscaConsulta1.Text)
        End If
    End Sub


End Class