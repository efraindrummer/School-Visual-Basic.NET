Public Class FrmPrincipal

    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        My.Forms.FrmEscuelaAlta.ShowDialog()
    End Sub

    Private Sub ModificacionToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AltaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem1.Click
        My.Forms.FrmProfesor.ShowDialog()

    End Sub

    Private Sub ESCUELAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ESCUELAToolStripMenuItem.Click

    End Sub

    Private Sub SALONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALONToolStripMenuItem.Click

    End Sub

    Private Sub AltaToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem3.Click
        My.Forms.FrmSalon.ShowDialog()
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AltaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem2.Click
        My.Forms.FrmMateria.ShowDialog()
    End Sub

    Private Sub AltaToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem4.Click
        My.Forms.FrmGrupo.ShowDialog()
    End Sub

    Private Sub AltaToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem5.Click
        My.Forms.FrmCurso.ShowDialog()
    End Sub

    Private Sub AltaToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem6.Click
        My.Forms.FrmAlumno.ShowDialog()
    End Sub

    Private Sub AltaToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem7.Click
        My.Forms.FrmCalificaciones.ShowDialog()
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        My.Forms.FrmBuscarSalon.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.FrmConsulta1.ShowDialog()
    End Sub
End Class