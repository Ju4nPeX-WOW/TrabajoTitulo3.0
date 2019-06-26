Public Class BsnHistoAjustes
    Dim DaoHistoAjustes As New DaoHistoAjustes

    Public Function obtHistPrecios()
        Return DaoHistoAjustes.obtHistPrecios()
    End Function

    Public Function obtHistStock()
        Return DaoHistoAjustes.obtHistStock()
    End Function

End Class
