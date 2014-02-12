Imports System
Imports System.IO
Imports INV_DATA_LAYER.INV_DATA_LAYER.DataAccessComponent
Imports INV_BUS_ENTITY
Imports INV_BUS_ENTITY.INV_BUS_ENTITY.Utilities

''' <summary>
''' Created by : S.Srivatsan
''' Created On : 11/04/2013
''' Description: This is the DAL class which contains the commmon functions for Data Fetching 
''' </summary>
''' <remarks></remarks>
''' 

Public Class ClsCommonDAFunctions
#Region "Common Variables"
    Dim strval As String
#End Region

#Region "Constructor"
    Public Sub New()
        ConnName = Utility.GETPASS(Utility.FunPubGetFileContents(Application.StartupPath & "\PROC.RDN")).Split("|")
        Connection = ConnName(0)
        DPFactory = New DataProvider(Connection, DataProvider.DBType.MYSQL)
        DALlogger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        PARAMS = New Dictionary(Of String, Object)()
    End Sub
#End Region
#Region "Common Functions"
    ''' <summary>
    ''' Created by : S.Srivatsan
    ''' Created On : 11/04/2013
    ''' Description: This is used to return a single value
    ''' </summary>
    ''' <param name="strQuery"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FunPubFetchID(ByVal strQuery As String) As String
        Try
            DSRESULT = DPFactory.FillDataSet(strQuery)
        Catch ex As Exception
            DALlogger.Error("Error in ClsSysAdminDAL in FunPubFetchForms", ex)
        End Try
        strval = DSRESULT.Tables(0).Rows(0).ToString()
        Return strval
    End Function

#End Region
End Class
