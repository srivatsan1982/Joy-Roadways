using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JOY_BUS_LAYER.SysAdmin;
using System.Data;
using JOY_BUS_LAYER.Common;


namespace JOY_DAL_LAYER.SysAdmin
{
    public class ClsLorryDAL : IDisposable
    {
        public int FunPubLorryTransaction(ClsLorryEntity Lorry, out int LorryID)
        {
            LorryID = 0;
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
                DALModule.PARAMS.Add(PARAMETERS.P_OUTPUT, null);
                DALModule.EXECRESULT = DALModule.DPFactory.ExecuteNonQuery(PROCEDURES.PROC_ADD_EDIT_DELETE_LORRYDETAILS, DALModule.PARAMS);
                LorryID = Convert.ToInt32(DALModule.DPFactory.GetParameter(PARAMETERS.P_OUTPUT.Replace("|OUT", ""), "OUT", null).Value);
            }
            catch (Exception ex)
            {
                DALModule.DALlogger.Error("Error in ClsLorryDAL in FunPubLorryTransaction", ex);
            }
            return DALModule.EXECRESULT;
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
