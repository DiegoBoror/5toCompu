Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.Data.Sql
Public Class Aumento_de_rolvb
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Sentencia = "insert into tipos_usuarios values('" + TextBox1.Text + "','" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "' )"
        EjecutarSql(Sentencia, Mensaje)
        If TextBox1.Text = "" Then
            MsgBox("DATO INCORRECTO RECARGUE LA PAGINA")
        End If
        Try
            Dim da As New SqlDataAdapter("select * tipos_usuarios", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView3.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ADMINISTRADOR.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SECRETARIAvb.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim da As New SqlDataAdapter("select * from tipos_usuarios", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim da As New SqlDataAdapter("select * from NUEVOS_EMPLEADOS", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView2.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub
End Class