Public Class FrmHistoAjustes

    Dim dataset As New DataSet
    Dim BsnHistoAjustes As New BsnHistoAjustes
    Dim instructions As New Instructions

    Public Sub rellenarCmb()
        If TabControl1.SelectedIndex = 0 Then
            'cmbFiltroBusq.Items.Add("Id_producto")
            'cmbFiltroBusq.Items.Add("Fecha")
            'cmbFiltroBusq.Items.Add("Hora")
            'cmbFiltroBusq.Items.Add("Precio")
            'cmbFiltroBusq.Items.Add("Rut_empleado")
        Else

            'cmbFiltroBusq.Items.Add("Id_producto")
            'cmbFiltroBusq.Items.Add("Fecha")
            'cmbFiltroBusq.Items.Add("Hora")
            'cmbFiltroBusq.Items.Add("Cantidad")
            'cmbFiltroBusq.Items.Add("Razon")
            'cmbFiltroBusq.Items.Add("Stock")
            'cmbFiltroBusq.Items.Add("Rut_empleado")

        End If
    End Sub
    Private Sub BtnExitCat_Click(sender As Object, e As EventArgs) Handles BtnExitCat.Click
        Me.Close()
    End Sub

    Private Sub FrmHistoAjustes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rellenarCmb()
        dataset = BsnHistoAjustes.obtHistPrecios()
        dgvPrecios.Rows.Clear()
        dgvPrecios.DataSource = dataset.Tables(0).DefaultView
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged



        If TabControl1.SelectedIndex = 0 Or TabControl1.SelectedIndex = -1 Then

            dataset = BsnHistoAjustes.obtHistPrecios()
            dgvPrecios.DataSource = dataset.Tables(0).DefaultView
        Else

            If TabControl1.SelectedIndex = 1 Then

                dataset = BsnHistoAjustes.obtHistStock()
                dgvStock.DataSource = dataset.Tables(0).DefaultView
            End If

        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs)
        Dim columnas As String = "*"
        Dim busqueda As String ' = cmbFiltroBusq.SelectedItem
        Dim texto As String '= txtBusqueda.Text
        Dim tabla As String = ""

        If busqueda = Nothing Or texto.Equals("") Then

        Else
            If TabControl1.SelectedIndex = 0 Then
                tabla = "Ajuste_Precios"
                dataset = instructions.busquedaIncremental("*", tabla, busqueda, texto)
                dgvPrecios.DataSource = dataset.Tables(0).DefaultView
            Else
                If TabControl1.SelectedIndex = 1 Then
                    tabla = "Ajuste_Stock"
                    dataset = instructions.busquedaIncremental("*", tabla, busqueda, texto)
                    dgvStock.DataSource = dataset.Tables(0).DefaultView
                End If

            End If
        End If


    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs)
        If True Then 'txtBusqueda.Text = "" Then
            If TabControl1.SelectedIndex = 0 Or TabControl1.SelectedIndex = -1 Then

                dataset = BsnHistoAjustes.obtHistPrecios()
                dgvPrecios.DataSource = dataset.Tables(0).DefaultView
            Else

                If TabControl1.SelectedIndex = 1 Then

                    dataset = BsnHistoAjustes.obtHistStock()
                    dgvStock.DataSource = dataset.Tables(0).DefaultView
                End If

            End If
        End If
    End Sub


End Class
