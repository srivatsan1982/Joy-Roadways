﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JOY_BUS_LAYER.SysAdmin;
using System.Data;
using JOY_BUS_LAYER.Common;
using JOY_BUS_LAYER.Utilities;
using JOY_DAL_LAYER.DataAccessComponent;
using System.Windows.Forms;

namespace JOY_DAL_LAYER.SysAdmin
{
    public class ClsLorryDAL : IDisposable
    {
        public ClsLorryDAL()
        {
            DALModule.ConnName = ClsUtilities.GETPASS(ClsUtilities.FunPubGetFileContents(Application.StartupPath + @"\PROC.RDN")).Split('|');
            DALModule.Connection = DALModule.ConnName[0];
            DALModule.Connection += "Convert Zero Datetime=True";
            DALModule.DPFactory = new DataProvider(DALModule.Connection, DataProvider.DBType.MYSQL);
            DALModule.DALlogger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            DALModule.PARAMS = new Dictionary<string, Object>();
        }

        public DataSet FunPubLorryTransaction(ClsLorryEntity Lorry)
        {
            try
            {
                DALModule.PARAMS.Add(PARAMETERS.P_MODE, Lorry.MODE);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPID, Lorry.COMPANYID);
                DALModule.PARAMS.Add(PARAMETERS.P_LRYID, Lorry.LRYID);
                DALModule.PARAMS.Add(PARAMETERS.P_LRYNAME, Lorry.LRYNAME);
                DALModule.PARAMS.Add(PARAMETERS.P_LRYOWNER, Lorry.LRYOWNER);
                DALModule.PARAMS.Add(PARAMETERS.P_LRYNUMBER, Lorry.LRYNUMBER);
                DALModule.PARAMS.Add(PARAMETERS.P_LRYDESC, Lorry.LRYDESC);
                DALModule.PARAMS.Add(PARAMETERS.P_ACTIVE, Lorry.LORRYACTIVE);
                DALModule.PARAMS.Add(PARAMETERS.P_AID, Lorry.ADDERID);
                DALModule.PARAMS.Add(PARAMETERS.P_MID, Lorry.MODIFIERID);
                DALModule.DSRESULT = DALModule.DPFactory.FillDataset(DALModule.DPFactory.GetConnection(), PROCEDURES.PROC_ADD_EDIT_DELETE_LORRYDETAILS, CommandType.StoredProcedure, DALModule.PARAMS);
            }
            catch (Exception ex)
            {
                DALModule.DALlogger.Error("Error in ClsLorryDAL in FunPubLorryTransaction", ex);
            }
            return DALModule.DSRESULT;
        }
        public DataTable FunPubFetchLorryDetails(ClsLorryEntity lorry)
        {
            try
            {
                DALModule.PARAMS.Add(PARAMETERS.P_CMPID, lorry.COMPANYID);
                DALModule.PARAMS.Add(PARAMETERS.P_LRYNAME, lorry.LRYNAME);
                DALModule.PARAMS.Add(PARAMETERS.P_LRYNUMBER, lorry.LRYNUMBER);
                DALModule.PARAMS.Add(PARAMETERS.P_LRYOWNER, lorry.LRYOWNER);
                DALModule.PARAMS.Add(PARAMETERS.P_ADT, lorry.ADDEDDATE);
                DALModule.PARAMS.Add(PARAMETERS.P_MDT, lorry.MODIFIEDDATE);
                DALModule.PARAMS.Add(PARAMETERS.P_ALLFLDSTAT, lorry.ALLFIELDSTAT);
                DALModule.DTRESULT = DALModule.DPFactory.GetDataTable(PROCEDURES.PROC_FETCH_LORRYDETAILS, DALModule.PARAMS);
            }
            catch (Exception ex)
            {
                DALModule.DALlogger.Error("Error in ClsLorryDAL in FunPubFetchLorryDetails", ex);
            }

            return DALModule.DTRESULT;
        }
        public void Dispose()
        {

        }
    }
}
