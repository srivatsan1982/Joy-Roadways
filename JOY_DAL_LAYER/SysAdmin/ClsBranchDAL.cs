using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JOY_BUS_LAYER.SysAdmin;
using System.Data;
using JOY_BUS_LAYER.Common;


namespace JOY_DAL_LAYER.SysAdmin
{
    public class ClsBranchDAL:IDisposable
    {
        /// <summary>
        /// Inserts the Branch details onto the database
        /// </summary>
        /// <param name="Branch"></param>
        /// <param name="BranchID"></param>
        /// <returns></returns>
        public int FunPubBranchTransaction(ClsBranchEntity Branch, out int BranchID)
        {
            BranchID = 0;
            try
            {
                DALModule.PARAMS.Add(PARAMETERS.P_MODE, Branch.MODE);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPID, Branch.COMPANYID);
                DALModule.PARAMS.Add(PARAMETERS.P_BRANCHID, Branch.BRANCHID);
                DALModule.PARAMS.Add(PARAMETERS.P_BRANCHCODE, Branch.BRANCHCODE);
                DALModule.PARAMS.Add(PARAMETERS.P_BRANCHNAME, Branch.BRANCHNAME);
                DALModule.PARAMS.Add(PARAMETERS.P_BRANCHCONTACTNAME, Branch.BRANCHCONTACTNAME);
                DALModule.PARAMS.Add(PARAMETERS.P_BRANCHPHONE, Branch.BRANCHPHONE);
                DALModule.PARAMS.Add(PARAMETERS.P_BRANCHMOBILEPHONE, Branch.BRANCHMOBILEPHONE);
                DALModule.PARAMS.Add(PARAMETERS.P_BRANCHADD1, Branch.BRANCHADD1);
                DALModule.PARAMS.Add(PARAMETERS.P_BRANCHADD2, Branch.BRANCHADD2);
                DALModule.PARAMS.Add(PARAMETERS.P_BRANCHCITY, Branch.BRANCHCITY);
                DALModule.PARAMS.Add(PARAMETERS.P_BRANCHPINCODE, Branch.BRANCHPINCODE);
                DALModule.PARAMS.Add(PARAMETERS.P_BRANCHCOUNTRY, Branch.BRANCHCOUNTRY);
                DALModule.PARAMS.Add(PARAMETERS.P_ACTIVE, Branch.BRANCHACTIVE);
                DALModule.PARAMS.Add(PARAMETERS.P_AID, Branch.ADDERID);
                DALModule.PARAMS.Add(PARAMETERS.P_MID, Branch.MODIFIERID);
                DALModule.PARAMS.Add(PARAMETERS.P_OUTPUT, null);
                DALModule.EXECRESULT = DALModule.DPFactory.ExecuteNonQuery(PROCEDURES.PROC_ADD_EDIT_DELETE_BRANCHDETAILS, DALModule.PARAMS);
                BranchID = Convert.ToInt32(DALModule.DPFactory.GetParameter(PARAMETERS.P_OUTPUT.Replace("|OUT", ""), "OUT", null).Value);
            }
            catch (Exception ex)
            {
                DALModule.DALlogger.Error("Error in ClsBranchDAL in FunPubbranchTransaction", ex);
            }
            return DALModule.EXECRESULT;
        }
        
        /// <summary>
        /// Fetches the Branch details from the database.
        /// </summary>
        /// <param name="Branch"></param>
        /// <returns></returns>
        public DataTable FunPubFetchBranch(ClsBranchEntity Branch)
        {
            try
            {
                DALModule.PARAMS.Add(PARAMETERS.P_ACTIVE, Branch.BRANCHACTIVE);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPID, Branch.COMPANYID);
                DALModule.PARAMS.Add(PARAMETERS.P_BRANCHNAME, Branch.BRANCHNAME);
                DALModule.PARAMS.Add(PARAMETERS.P_ADT, Branch.ADDEDDATE);
                DALModule.PARAMS.Add(PARAMETERS.P_MDT, Branch.MODIFIEDDATE);
                DALModule.PARAMS.Add(PARAMETERS.P_ALLFLDSTAT, Branch.ALLFIELDSTAT);
                DALModule.DTRESULT = DALModule.DPFactory.GetDataTable(PROCEDURES.PROC_FETCH_BRANCHDETAILS, DALModule.PARAMS);
            }
            catch (Exception ex)
            {
                DALModule.DALlogger.Error("Error in ClsBranchDAL in FunPubFetchBranch", ex);
            }

            return DALModule.DTRESULT;
        }

        public void Dispose()
        {
            
        }
    }
}
