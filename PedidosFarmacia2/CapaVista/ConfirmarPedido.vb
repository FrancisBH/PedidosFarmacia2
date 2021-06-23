Imports MySql.Data.MySqlClient

Public Class ConfirmarPedido
    Dim conexion As New MySqlConnection()
    Dim datos As DataSet
    Dim adaptador As MySqlDataAdapter

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click

        Try
            Dim ENTRADA As String = "Insert into productos(nombre, tipo, cantidad, distribuidor, sucursal) Values('" + txtNom.Text +
                "','" + txtTip.Text + "','" + txtCan.Text + "','" + txtDis.Text + "','" + txtSuc.Text + "')"

            Dim DT As New DataTable
            Dim ADAPTADOR As New MySqlDataAdapter(ENTRADA, conexion)

            ADAPTADOR.Fill(DT)
            conexion.Close()
            MsgBox("Datos insertados correctamente")

            txtNom.Text = ""
            txtNom.Text = ""
            txtCan.Text = ""
            txtTip.Text = ""
            txtDis.Text = ""
            txtSuc.Text = ""


        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            conexion.Dispose()
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Form1.Show()
        Me.Hide()

        Form1.txtNombreM.Text = ""
        Form1.txtCantidad.Text = ""
        Form1.rbtnCemefar.Checked = False
        Form1.rbtnCofarma.Checked = False
        Form1.rbtnEmpsephar.Checked = False
        Form1.chkPrincipal.Checked = False
        Form1.chkSecundaria.Checked = False

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub ConfirmarPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server=localhost;user=root;password=;database=medicamentosfarmacia"
            conexion.Open()


            Dim consulta As String
            consulta = "Select * from productos"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "productos")
            DataGridView1.DataSource = datos
            DataGridView1.DataMember = "productos"

        Catch ex As Exception
            MsgBox("No se pudo Conectar" & ex.Message)

        End Try

        txtNom.Text = Module1.nom
        txtCan.Text = Module1.canti
        txtTip.Text = Module1.type
        txtDis.Text = Module1.Distri
        txtSuc.Text = Module1.Sucur

    End Sub

End Class