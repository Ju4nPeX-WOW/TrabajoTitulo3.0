Public Class FormBase

    Protected listaDeObjetosForm As List(Of Object) ' Lista de objetos en la cual hare refencia a los elementos del form
    'botones - txtbox - label's , etc . Existe un FormBase del cual se heredan 
    'metodos para habilitar o desabilitar estos elementos , todos los form los usan por eso está así.
    Protected listaTSMDelForm As List(Of Object) ' Lo mismo pero con los tmsAgregar, tmsEditar , tmsEliminar
    Protected listaDeObjetosRellenables As List(Of Object)
    Protected dataset_padre As DataSet     ' Todos cargar un dataset al parecer

    Private Sub FormTamaño_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New System.Drawing.Point(150, 45)
    End Sub

    Protected Sub DesbloquearBotones(coleccion As List(Of Object))
        For i = 0 To coleccion.Count - 1
            coleccion(i).Enabled = True
        Next
    End Sub

    Protected Sub BloquearBotones(coleccion As List(Of Object))
        For i = 0 To coleccion.Count - 1
            coleccion(i).Enabled = False
        Next
    End Sub

    Protected Sub OpcionesMenuStrip(tms As List(Of Object), estado As String)
        If (estado = "bloqueadas") Then
            For i = 0 To tms.Count - 1
                tms(i).Enabled = False
            Next
        ElseIf (estado = "desbloqueadas") Then
            For i = 0 To tms.Count - 1
                tms(i).Enabled = True
            Next
        End If
    End Sub

    Protected Sub RellenarDatos(list As List(Of Object), lista_ingreso As String())
        For l = 0 To list.Count - 1
            list(l).Text = lista_ingreso(l)
        Next
    End Sub
    Protected Sub LimpiarDatos(list As List(Of Object), lista_ingreso As String())
        For l = 0 To list.Count - 1
            list(l).Text = lista_ingreso(l)
        Next
    End Sub

    Protected Sub RellenarDGV(dtaset As DataSet, dgv As Object)
        'ObtenerDataSet(1, "")


        For i = 0 To dataset_padre.Tables(0).Rows.Count - 1
            dgv.Rows.Add(dataset_padre.Tables(0)(i)(0).ToString, dataset_padre.Tables(0)(i)(1).ToString, dataset_padre.Tables(0)(i)(2).ToString)

            'MsgBox(dataset.Tables(0)(i)(2).ToString)
        Next

        If dgv.Rows.Count > 0 Then
            dgv.Rows(0).Selected = False
        End If

    End Sub
    Protected Sub SeleccionarCMB(cmb As ComboBox, idSeleccionado As String)
        Dim id As String
        Dim indice As Short
        For i = 0 To cmb.Items.Count - 1

            id = cmb.Items(i).ToString()
            id = id.Substring(0, InStr(1, id, "-") - 1)
            'MsgBox("Id del CMB: " + id)

            If idSeleccionado = Int(id) Then
                indice = i
            End If

        Next
        If indice >= 0 Then
            cmb.SelectedIndex = indice
        End If

    End Sub
End Class