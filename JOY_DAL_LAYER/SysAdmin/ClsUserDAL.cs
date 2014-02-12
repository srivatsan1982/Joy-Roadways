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
    public class ClsUserDAL : IDisposable
    {
        public ClsUserDAL()
        {
            DALModule.ConnName = ClsUtilities.GETPASS(ClsUtilities.FunPubGetFileContents(Application.StartupPath + @"\PROC.RDN")).Split('|');
            DALModule.Connection = DALModule.ConnName[0];
            DALModule.Connection += "Convert Zero Datetime=True";
            DALModule.DPFactory = new DataProvider(DALModule.Connection, DataProvider.DBType.MYSQL);
            DALModule.DALlogger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            DALModule.PARAMS = new Dictionary<string, Object>();
        }
        public DataSet FunPubUserTransaction(ClsUserEntity User)
        {
            //try
            //{
            //    DALModule.PARAMS.Add(PARAMETERS.P_MODE, Vendor.MODE);
            //    DALModule.PARAMS.Add(PARAMETERS.P_VNDID, Vendor.VNDID);
            //    DALModule.PARAMS.Add(PARAMETERS.P_VNDCODE, Vendor.VNDCODE);
            //    DALModule.PARAMS.Add(PARAMETERS.P_VNDNAME, Vendor.VNDNAME);
            //    DALModule.PARAMS.Add(PARAMETERS.P_VNDADD1, Vendor.VNDADD1);
            //    DALModule.PARAMS.Add(PARAMETERS.P_VNDADD2, Vendor.VNDADD2);
            //    DALModule.PARAMS.Add(PARAMETERS.P_VNDCITY, Vendor.VNDCITY);
            //    DALModule.PARAMS.Add(PARAMETERS.P_VNDPINCODE, Vendor.VNDPINCODE);
            //    DALModule.PARAMS.Add(PARAMETERS.P_VNDCOUNTRY, Vendor.VNDCOUNTRY);
            //    DALModule.PARAMS.Add(PARAMETERS.P_VNDEMAIL, Vendor.VNDEMAIL);
            //    DALModule.PARAMS.Add(PARAMETERS.P_VNDPHONE, Vendor.VNDPHONE);
            //    DALModule.PARAMS.Add(PARAMETERS.P_VNDMOBPHONE, Vendor.VNDMOBPHONE);
            //    DALModule.PARAMS.Add(PARAMETERS.P_VNDTINNO, Vendor.VNDTINNO);
            //    DALModule.PARAMS.Add(PARAMETERS.P_VNDBANKNAME, Vendor.VNDBANKNAME);
            //    DALModule.PARAMS.Add(PARAMETERS.P_VNDBANKBRANCH, Vendor.VNDBANKBRANCH);
            //    DALModule.PARAMS.Add(PARAMETERS.P_VNDBANKACCNO, Vendor.VNDBANKACCNO);
            //    DALModule.PARAMS.Add(PARAMETERS.P_VNDIFSCODE, Vendor.VNDIFSCODE);
            //    DALModule.PARAMS.Add(PARAMETERS.P_ACTIVE, Vendor.VNDACTIVE);
            //    DALModule.PARAMS.Add(PARAMETERS.P_CMPID, Vendor.COMPANYID);
            //    DALModule.PARAMS.Add(PARAMETERS.P_AID, Vendor.ADDERID);
            //    DALModule.PARAMS.Add(PARAMETERS.P_MID, Vendor.MODIFIERID);
            //    DALModule.DSRESULT = DALModule.DPFactory.FillDataset(DALModule.DPFactory.GetConnection(), PROCEDURES.PROC_ADD_EDIT_DELETE_USERDETAILS, CommandType.StoredProcedure, DALModule.PARAMS);
            //}
            //catch (Exception ex)
            //{
            //    DALModule.DALlogger.Error("Error in ClsVendorDAL in FunPubVendorTransaction", ex);
            //}
            return DALModule.DSRESULT;
        }

        public DataTable FunPubFetchUserDetails(ClsUserEntity User)
        {
            try
            {
                DALModule.PARAMS.Add(PARAMETERS.P_USERNAME, User.USERFIRSTNAME);
                DALModule.PARAMS.Add(PARAMETERS.P_USERID, User.USERFIRSTNAME);
                DALModule.PARAMS.Add(PARAMETERS.P_USERCODE, User.USERCODE);
                DALModule.PARAMS.Add(PARAMETERS.P_USERDOJ, User.USERDOJ);
                DALModule.PARAMS.Add(PARAMETERS.P_USERPWD, User.USERPWD);
                DALModule.PARAMS.Add(PARAMETERS.P_ALLFLDSTAT, User.ALLFIELDSTAT);
                DALModule.DTRESULT = DALModule.DPFactory.GetDataTable(PROCEDURES.PROC_FETCH_USER_DETAILS, DALModule.PARAMS);
            }
            catch (Exception ex)
            {
                DALModule.DALlogger.Error("Error in ClsUserDAL in FunPubFetchUserDetails", ex);
            }

            return DALModule.DTRESULT;
        }
        public void Dispose()
        {

        }
    }
}
