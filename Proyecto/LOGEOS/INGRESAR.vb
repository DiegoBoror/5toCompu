Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class INGRESAR
    Dim con As New SqlConnection(My.Settings.conexion)
    Dim mensaje, sentencia As String
    Sub EjecutarSql(ByVal sql As String, ByVal msg As String)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        empleadonuevo.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txt_Contraseña.Text = ""
        txt_Usuario.Text = ""
    End Sub



    Private Sub txt_Contraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Contraseña.KeyPress
        txt_Contraseña.PasswordChar = "*"
        If InStr(1, "0123456789,-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        empleadonuevo.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim da As New SqlDataAdapter("select * from usuarios Where Nombre_usuario='" & txt_Usuario.Text & "' And contraseña='" & txt_Contraseña.Text & "'", con)
        Dim dt As New DataTable
        da.Fill(dt)
        If txt_Contraseña.Text = "" And txt_Usuario.Text = "" Then
            MsgBox("Ingrese Su USUARIO y CONTRASEÑA")
        Else
            If txt_Contraseña.Text = "" Then
                MsgBox("Ingrese su CONTRASEÑA")
            Else
                If txt_Usuario.Text = "" Then
                    MsgBox("Ingrese su USUARIO")

                End If
            End If
        End If
        Me.Hide()

        'Validar'
        Dim validar As Integer = dt.Rows.Count
        'If'
        If validar > 0 Then
            Dim tipo As String = dt(0)("Id_tipo")
            If tipo = 1 Then
                MsgBox("Bienvenido USUARIO")
                usuario.Show()
                txt_Usuario.Text = ""
                txt_Contraseña.Text = ""
                Me.Hide()
            Else
                If tipo = 2 Then
                    MsgBox("Bienvenido SECRETARI@")
                    SECRETARIAvb.Show()
                    txt_Usuario.Text = ""
                    txt_Contraseña.Text = ""
                    Me.Hide()
                ElseIf tipo = 3 Then
                    MsgBox("Bienvenido Administrador")
                    ADMINISTRADOR.Show()
                    txt_Usuario.Text = ""
                    txt_Contraseña.Text = ""
                    Me.Hide()
                End If
            End If
        End If
    End Sub

    Private Sub txt_Usuario_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_Usuario.MouseClick

        txt_Usuario.Text = ("")
    End Sub

    Private Sub txt_Usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_Usuario.TextChanged

    End Sub

    Private Sub txt_Contraseña_TextChanged(sender As Object, e As EventArgs) Handles txt_Contraseña.TextChanged

    End Sub

    Private Sub txt_Contraseña_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_Contraseña.MouseClick
        txt_Contraseña.Text = ("")
    End Sub
End Class