﻿Public Class Hitung_Nilai_Sii_Taqiyah_201931107

    Dim UTS, UAS, TUGAS As Integer
    Dim HASIL As Double
    Dim GRADE As String
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub BTN_HAPUS_Click(sender As Object, e As EventArgs) Handles BTN_HAPUS.Click
        TXT_UTS.Text = ""
        TXT_UAS.Text = ""
        TXT_TUGAS.Text = ""
        TXT_AKHIR.Text = ""
        TXT_GRADE.Text = ""
    End Sub

    Private Sub BTN_TAMPIL_Click(sender As Object, e As EventArgs) Handles BTN_TAMPIL.Click
        TXT_AKHIR.Text = HASIL
        If HASIL >= 81 Then
            GRADE = "A"
        ElseIf HASIL >= 76 Then
            GRADE = "A-"
        ElseIf HASIL >= 72 Then
            GRADE = "B+"
        ElseIf HASIL >= 68 Then
            GRADE = "B"
        ElseIf HASIL >= 65 Then
            GRADE = "B-"
        End If
        TXT_GRADE.Text = GRADE
    End Sub

    Private Sub Hitung_Nilai_Sii_Taqiyah_201931107_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTN_PROSES_Click(sender As Object, e As EventArgs) Handles BTN_PROSES.Click
        UTS = TXT_UTS.Text
        UAS = TXT_UAS.Text
        TUGAS = TXT_TUGAS.Text
        HASIL = (UTS + UAS + TUGAS) / 3
    End Sub
End Class