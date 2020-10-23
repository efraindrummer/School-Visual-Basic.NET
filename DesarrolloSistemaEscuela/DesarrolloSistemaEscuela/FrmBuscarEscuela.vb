Imports MySql.Data.MySqlClient

Public Class FrmBuscarSalon
    Public con As MySqlConnection
    Private Sub FrmBuscarSalon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New MySqlConnection("Server=localhost; Database=escuela; Uid=SistemaEscolar; Pwd=12345;")
    End Sub

    Private Sub TxtBuscarSalones_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarSalones.TextChanged
        If Filtro(TxtBuscarSalones.Text).Rows.Count > 0 Then
            DgvTraeSln.DataSource = Filtro(TxtBuscarSalones.Text)
        End If
    End Sub

    Function Filtro(ByVal busqueda As String) As DataTable
        con.Open()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM salon WHERE capacidad LIKE '%" & busqueda & "%'", con)
        da.Fill(dt)
        con.Close()
        Return dt
    End Function

    Private Sub DgvTraeSln_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTraeSln.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class