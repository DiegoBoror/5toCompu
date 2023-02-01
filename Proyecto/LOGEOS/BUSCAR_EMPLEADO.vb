Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.Data.Sql
Public Class BUSCAR_EMPLEADO
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Sentencia = "update NUEVOS_EMPLEADOS set Id_empleado= '" + TextBox1.Text + "',Nombre='" + TextBox2.Text + "',Apellido='" + TextBox5.Text + "',Tipo_empleo='" + TextBox3.Text + "',Codigo=" + TextBox5.Text + "'"
        Mensaje = "Datos actualizado correctamente"
        EjecutarSql(Sentencia, Mensaje)
        Try
            Dim da As New SqlDataAdapter("Select * from NUEVOS_EMPLEADOS", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Sentencia = "Delete NUEVOS_EMPLEADOS where Id_empleado = '" + TextBox1.Text + "'"
        Mensaje = "Datos Eliminados Correctamente"
        EjecutarSql(Sentencia, Mensaje)
        Try
            Dim da As New SqlDataAdapter("select * from NUEVOS_EMPLEADOS", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SECRETARIAvb.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim da As New SqlDataAdapter("select * from NUEVOS_EMPLEADOS", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class