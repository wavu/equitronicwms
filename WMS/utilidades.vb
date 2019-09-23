Imports System.Data.Sql
Imports System.Data
Imports System.Data.SqlClient
Imports SAPbobsCOM
Imports System.Text


Public Class utilidades

    'Dim ObjCon As New SqlConnection("Data Source=localhost;Initial Catalog=EQUITRONIC;User Id=sa;Password=SAPB1Admin;Trusted_Connection=False")
    'Dim ObjConrep As New SqlConnection("Data Source=localhost;Initial Catalog=replica;User Id=sa;Password=SAPB1Admin;Trusted_Connection=False")
    Dim ObjCon As New SqlConnection("Data Source=localhost;Initial Catalog=PRUEBAS_EQ2;User Id=sa;Password=Equitronic*2014$$;Trusted_Connection=False")
    Dim ObjConrep As New SqlConnection("Data Source=localhost;Initial Catalog=rep_equitronic;User Id=sa;Password=Equitronic*2014$$;Trusted_Connection=False")
    Public Function consultar(ByVal SqlCom As SqlCommand) As DataSet
        SqlCom.Connection() = ObjCon
        SqlCom.Connection.Open()
        Dim dsdatos As New DataSet
        Try
            Dim da As New SqlDataAdapter(SqlCom)
            da.Fill(dsdatos)
        Catch ex As Exception

        End Try
        SqlCom.Connection.Close()
        Return dsdatos
    End Function

    Public Function consultarrep(ByVal SqlCom As SqlCommand) As DataSet
        SqlCom.Connection() = ObjConrep
        SqlCom.Connection.Open()
        Dim dsdatos As New DataSet
        Try
            Dim da As New SqlDataAdapter(SqlCom)
            da.Fill(dsdatos)
        Catch ex As Exception

        End Try
        SqlCom.Connection.Close()
        Return dsdatos
    End Function

    Public Function insertarrep(ByVal SqlCom As SqlCommand) As Boolean
        Dim resultado As Boolean
        SqlCom.Connection() = ObjConrep
        SqlCom.Connection.Open()
        Try
            SqlCom.ExecuteNonQuery()
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        SqlCom.Connection.Close()
        Return resultado
    End Function


    Public oCompany As SAPbobsCOM.Company
    Public lerr As Long, sErr As String

    Public Function conectar(ByVal user As String, ByVal password As String) As Boolean
        oCompany = New SAPbobsCOM.Company
        With oCompany
            '.Server = "ITACHI"
            .Server = "192.168.0.100"
            .CompanyDB = "EQUITRONIC"
            .UserName = user
            .Password = password
            .DbServerType = BoDataServerTypes.dst_MSSQL2012
            .UseTrusted = False
            .DbUserName = "sa"
            '.DbPassword = "SAPB1Admin"
            .DbPassword = "Equitronic*2014$$"
            '.UseTrusted = True
            .language = BoSuppLangs.ln_Spanish_La

            lerr = oCompany.Connect()
            If lerr <> 0 Then
                Call oCompany.GetLastError(lerr, sErr)
                MsgBox(sErr)
                Return False
            Else
                Return True
            End If
        End With
    End Function

    Public Function desconectar() As Boolean
        oCompany.Disconnect()
        Return True
    End Function

    Public Function DataTableToHTMLTable(ByVal inTable As System.Data.DataTable) As String
        Dim dString As New StringBuilder
        dString.Append("<table border=""1"">")
        dString.Append(GetHeader(inTable))
        dString.Append(GetBody(inTable))
        dString.Append("</table>")
        Return dString.ToString
    End Function

    Private Function GetHeader(ByVal dTable As System.Data.DataTable) As String
        Dim dString As New StringBuilder

        dString.Append("<thead><tr>")
        For Each dColumn As System.Data.DataColumn In dTable.Columns
            dString.AppendFormat("<th>{0}</th>", dColumn.ColumnName)
        Next
        dString.Append("</tr></thead>")

        Return dString.ToString
    End Function

    Private Function GetBody(ByVal dTable As System.Data.DataTable) As String
        Dim dString As New StringBuilder

        dString.Append("<tbody>")

        For Each dRow As DataRow In dTable.Rows
            dString.Append("<tr>")
            For dCount As Integer = 0 To dTable.Columns.Count - 1
                dString.AppendFormat("<td>{0}</td>", dRow(dCount))
            Next
            dString.Append("</tr>")
        Next
        dString.Append("</tbody>")

        Return dString.ToString()
    End Function
End Class