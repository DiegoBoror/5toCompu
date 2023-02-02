Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Text.RegularExpressions

Public Class nuevos_empleado_secretaria
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
        SECRETARIAvb.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If InStr(1, "0123456789,-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress

        If InStr(1, "0123456789,-" & Chr(12), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        Dim formato As String = "m^[\w._%-]+@[ \w.-]+\.[a-zA-Z]{2,4}$"
        If Regex.IsMatch(TextBox7.Text, formato) Then
            MessageBox.Show("correo ivalido")
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If InStr(1, "0123456789,-+ " & Chr(15), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Sentencia = "Delete NUEVOS_EMPLEADOS where Id_empleado = '" + TextBox1.Text + "'"
        Mensaje = "Datos Eliminados Correctamente"
        EjecutarSql(Sentencia, Mensaje)

        Sentencia = "Delete ID_EN_USO where Id = '" + TextBox1.Text + "'"

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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim da As New SqlDataAdapter("select * from NUEVOS_EMPLEADOS", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Sentencia = "update NUEVOS_EMPLEADOS set Id_empleado='" + TextBox1.Text + "',Nombre='" + TextBox2.Text + "',Apelllido= '" + TextBox5.Text + "', Tipo_empleo='" + TextBox3.Text + "',Codigo= '" + TextBox4.Text + "',Telefono='" + TextBox6.Text + "',Correo='" + TextBox7.Text + "'"
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

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Sentencia = "insert into NUEVOS_EMPLEADOS values('" + TextBox1.Text + "','" + TextBox2.Text + "', '" + TextBox5.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "' )"
        EjecutarSql(Sentencia, Mensaje)

        Sentencia = "insert into ID_EN_USO values('" + TextBox1.Text + "' )"
        EjecutarSql(Sentencia, Mensaje)
        MsgBox("datos ingresados")
        If TextBox1.Text = "" Then
            MsgBox("DATO INCORRECTO RECARGUE LA PAGINA")
        Else
            MsgBox("ERROR")
        End If
        Try
            Dim da As New SqlDataAdapter("select * from NUEVOS_EMPLEADOS", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub
End Class