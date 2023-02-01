Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.Data.Sql
Public Class empleadonuevo
    Dim con As New SqlConnection(My.Settings.conexion)
    Dim Sentencia, Mensaje As String

    Private Sub EjecutarSql(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Sentencia = "insert into NUEVOS_EMPLEADOS values('" + TextBox1.Text + "','" + TextBox2.Text + "', '" + TextBox5.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "' )"
        EjecutarSql(Sentencia, Mensaje)
        MsgBox("TU CUENTA SE ACTIVARA EN 2 DIAS PARA
PODER ACCEDER, GRACIAS POR TU TIEMPO :)")
        If TextBox1.Text = "" Then
            MsgBox("DATO INCORRECTO RECARGUE LA PAGINA")
        End If

        Sentencia = "Insert into ID_EN_USO values('" + TextBox1.Text + "')"
        EjecutarSql(Sentencia, Mensaje)
        Try
            Dim da As New SqlDataAdapter("select * from NUEVOS_EMPLEADOS", con)
            Dim ds As New DataSet
            da.Fill(ds)
        Catch ex As Exception

        End Try
    End Sub
End Class