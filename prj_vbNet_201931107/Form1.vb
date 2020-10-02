Public Class Frmcoba
    Private Sub Btntampilkan_Click(sender As Object, e As EventArgs) Handles Btntampilkan.Click
        MessageBox.Show(txtnama.Text & vbCrLf & cbojeniskelamin.Text & vbCrLf & cbofakultas.Text,
                        "Hasilkan Pengisian", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Frmcoba_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
