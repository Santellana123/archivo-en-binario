Imports System.IO

Public Class Form1
    Private Sub btnLeer_Click(sender As Object, e As EventArgs) Handles btnLeer.Click

        Dim fs As FileStream = New FileStream("datos.bin", FileMode.Open, FileAccess.Read)
        Dim br As BinaryReader = New BinaryReader(fs)
        txtNombre.Text = br.ReadString()
        txtEdad.Text = br.ReadInt32().ToString()
        chkActivo.Checked = br.ReadBoolean()
        br.Close()
        fs.Close()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim fs As FileStream = New FileStream("datos.bin", FileMode.Create, FileAccess.Write)
        Dim bw As BinaryWriter = New BinaryWriter(fs)
        bw.Write(txtNombre.Text)
        bw.Write(CInt(txtEdad.Text))
        bw.Write(chkActivo.Checked)
        bw.Close()
        fs.Close()

        MessageBox.Show("Los datos han sido guardados en el archivo 'datos.bin'")
    End Sub
End Class
