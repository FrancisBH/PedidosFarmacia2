Imports MySql.Data.MySqlClient
Public Class Form1

    'Dim ButtonGroup As Integer

    Dim verificacion As Boolean = False
    Dim medicamento, tipo, cantidad, distribuidor, sucursal As String

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If txtCantidad.Text = "" Or txtNombreM.Text = "" Then
            verificacion = False
            MsgBox("No puede dejar campos vacios", MsgBoxStyle.Exclamation, "Alerta")

        Else
            verificacion = True
        End If


        If verificacion = True Then

            medicamento = txtNombreM.Text
            tipo = CboxTipoM.Text
            cantidad = txtCantidad.Text

            'valor del radio buton

            If rbtnCofarma.Checked = True Then

                distribuidor = rbtnCofarma.Text

            ElseIf rbtnEmpsephar.Checked = True Then

                distribuidor = rbtnEmpsephar.Text

            ElseIf rbtnCemefar.Checked = True Then

                distribuidor = rbtnCemefar.Text


            End If

            'valor del cheeckbox

            If chkPrincipal.Checked = True Then

                sucursal = chkPrincipal.Text

            Else

                sucursal = chkSecundaria.Text

            End If


            MsgBox("Usted a seleccionado: " + medicamento + " de tipo " + tipo + ", la cantidad de: " + cantidad)

            Select Case True
                Case rbtnCofarma.Checked
                    MsgBox("Distribuidor seleccionado: Cofarma")
                Case rbtnEmpsephar.Checked
                    MsgBox("Distribuidor seleccionado: Empsephar")
                Case rbtnCemefar.Checked
                    MsgBox("Distribuidor seleccionado: Cemefar")
            End Select

            Select Case True
                Case chkPrincipal.Checked
                    MsgBox("Sucursal seleccionado: Principal")
                Case chkSecundaria.Checked
                    MsgBox("Sucursal seleccionado: Secundaria")
                Case chkPrincipal.Checked AndAlso chkSecundaria.Checked
                    MsgBox("Sucursal seleccionado: Principal y Secundaria")
            End Select


            Me.Hide()
            Dim frm As New ConfirmarPedido

            frm.Show()

            frm.txtNom.Text = medicamento
            frm.txtTip.Text = tipo
            frm.txtCan.Text = cantidad
            frm.txtDis.Text = distribuidor
            frm.txtSuc.Text = sucursal

        Else
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtNombreM.Text = ""
        txtCantidad.Text = ""
        rbtnCemefar.Checked = False
        rbtnCofarma.Checked = False
        rbtnEmpsephar.Checked = False
        chkPrincipal.Checked = False
        chkSecundaria.Checked = False
    End Sub

    Private Sub SoloLetras(sender As Object, e As KeyPressEventArgs) Handles txtNombreM.KeyPress
        SoloLetras(e)

    End Sub

    Private Sub SoloNumeros(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        SoloNumeros(e)

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim f2 As New Login
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    'Funcion para que solo permite el ingreso de caracteres tipo letra
    Sub SoloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    'Funcion para que solo permite el ingreso de caracteres tipo numerico
    Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub
End Class
