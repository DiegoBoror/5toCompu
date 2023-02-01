Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.Data.Sql
Public Class registronuevo
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
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Sentencia = "insert into NUEVOS_EMPLEADOS values('" + TextBox1.Text + "','" + TextBox2.Text + "', '" + TextBox5.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "' )"
        Mensaje = "Datos insertados Correctamente"
        EjecutarSql(Sentencia, Mensaje)
        Try
            Dim da As New SqlDataAdapter("select * from ", con)
            Dim ds As New DataSet
            da.Fill(ds)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class