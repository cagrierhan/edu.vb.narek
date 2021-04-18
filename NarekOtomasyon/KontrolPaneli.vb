Public Class KontrolPaneli
    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnSt.Click
        Sterilizasyon.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnKy.Click
        KaynatmaKazanı.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click, BtnSg.Click
        SogutmaKazanı.Show()
        Me.Hide()
    End Sub

    Private Sub KontrolPaneli_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub BtnHam_Click(sender As Object, e As EventArgs) Handles BtnHam.Click
        MalKabul.Show()
        Me.Hide()
    End Sub

    Private Sub BtnMx_Click(sender As Object, e As EventArgs) Handles BtnMx.Click
        KarışımKazanı.Show()
        Me.Hide()
    End Sub

    Private Sub BtnSs_Click(sender As Object, e As EventArgs) Handles BtnSs.Click
        Siseleme.Show()
        Me.Hide()
    End Sub

    Private Sub BtnPc_Click(sender As Object, e As EventArgs) Handles BtnPc.Click
        Paketleme.Show()
        Me.Hide()
    End Sub
End Class
