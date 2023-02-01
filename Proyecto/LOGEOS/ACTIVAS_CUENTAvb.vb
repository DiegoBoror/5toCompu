Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.Data.Sql
Public Class ACTIVAS_CUENTAvb
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

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim da As New SqlDataAdapter("select * from NUEVOS_EMPLEADOS", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView2.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SECRETARIAvb.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If InStr(1, "1" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim da As New SqlDataAdapter("select * from ID_EN_USO", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.uso.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Sentencia = "insert into CUENTAS_ACTIVADAS values('" + TextBox1.Text + "','" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "' )"
        EjecutarSql(Sentencia, Mensaje)
        MsgBox("ACTIVACION CORRECTA")

        Sentencia = "insert into usuarios values('" + TextBox1.Text + "','" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "' )"
        EjecutarSql(Sentencia, Mensaje)

        Sentencia = "insert into ID_EN_USO values('" + TextBox1.Text + "')"
        EjecutarSql(Sentencia, Mensaje)

        Try
            Dim da As New SqlDataAdapter("select * from CUENTAS_ACTIVADAS", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub
End Class