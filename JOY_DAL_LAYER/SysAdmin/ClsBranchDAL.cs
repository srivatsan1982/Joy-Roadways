using System;
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
    public class ClsBranchDAL : IDisposable
    {
        public ClsBranchDAL()
        {
            DALModule.ConnName = ClsUtilities.GETPASS(ClsUtilities.FunPubGetFileContents(Application.StartupPath + @"\PROC.RDN")).Split('|');
            DALModule.Connection = DALModule.ConnName[0];
            DALModule.Connection += "Convert Zero Datetime=True";
            DALModule.DPFactory = new DataProvider(DALModule.Connection, DataProvider.DBType.MYSQL);
            DALModule.DALlogger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            DALModule.PARAMS = new Dictionary<string, Object>();
        }
        /// <summary>
        /// Inserts the Branch details onto the database
        /// </summary>
        /// <param name="Branch"></param>
        /// <param name="BranchID"></param>
        /// <returns></returns>
        public DataSet FunPubBranchTransaction(ClsBranchEntity Branch)
        {
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
                DALModule.DSRESULT = DALModule.DPFactory.FillDataset(DALModule.DPFactory.GetConnection(), PROCEDURES.PROC_ADD_EDIT_DELETE_BRANCHDETAILS, CommandType.StoredProcedure, DALModule.PARAMS);
            }
            catch (Exception ex)
            {
                DALModule.DALlogger.Error("Error in ClsBranchDAL in FunPubBranchTransaction", ex);
            }
            return DALModule.DSRESULT;
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
                DALModule.PARAMS.Add(PARAMETERS.P_BRANCHID, Branch.BRANCHID);
                DALModule.PARAMS.Add(PARAMETERS.P_BRANCHNAME, Branch.BRANCHNAME);
                DALModule.PARAMS.Add(PARAMETERS.P_BRANCHCODE, Branch.BRANCHCODE);
                DALModule.PARAMS.Add(PARAMETERS.P_SDT, Branch.ADDEDDATE);
                DALModule.PARAMS.Add(PARAMETERS.P_FDT, Branch.MODIFIEDDATE);
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
