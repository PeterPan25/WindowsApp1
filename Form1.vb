Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub LBname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Name.SelectedIndexChanged

    End Sub

    Private Sub LL_Kinderarzt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LL_Kinderarzt.LinkClicked

    End Sub

    Private Sub B_öffne_Click(sender As Object, e As EventArgs) Handles B_öffne.Click
        Dim name As String
        name = Me.LB_Name.Text
        Form(name).show

    End Sub
End Class
