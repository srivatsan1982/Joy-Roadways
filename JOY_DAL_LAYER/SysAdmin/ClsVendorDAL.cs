using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JOY_BUS_LAYER.SysAdmin;
using System.Data;
using JOY_BUS_LAYER.Common;
using JOY_BUS_LAYER.Utilities;
using JOY_DAL_LAYER.DataAccessComponent;

namespace JOY_DAL_LAYER.SysAdmin
{
    public class ClsVendorDAL:IDisposable
    {
        public ClsVendorDAL()
        {
            DALModule.ConnName = ClsUtilities.GETPASS(ClsUtilities.FunPubGetFileContents(Application.StartupPath + @"\PROC.RDN")).Split('|');
            DALModule.Connection = DALModule.ConnName[0];
            DALModule.Connection += "Convert Zero Datetime=True";
            DALModule.DPFactory = new DataProvider(DALModule.Connection, DataProvider.DBType.MYSQL);
            DALModule.DALlogger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            DALModule.PARAMS = new Dictionary<string, Object>();
        }
        public DataSet FunPubVendorTransaction(ClsVendorEntity Vendor)
        {
            try
            {
                DALModule.PARAMS.Add(PARAMETERS.P_MODE, Vendor.MODE);
                DALModule.PARAMS.Add(PARAMETERS.P_VNDID, Vendor.VNDID);
                DALModule.PARAMS.Add(PARAMETERS.P_VNDCODE, Vendor.VNDCODE);
                DALModule.PARAMS.Add(PARAMETERS.P_VNDNAME, Vendor.VNDNAME);
                DALModule.PARAMS.Add(PARAMETERS.P_VNDADD1, Vendor.VNDADD1);
                DALModule.PARAMS.Add(PARAMETERS.P_VNDADD2, Vendor.VNDADD2);
                DALModule.PARAMS.Add(PARAMETERS.P_VNDCITY, Vendor.VNDCITY);
                DALModule.PARAMS.Add(PARAMETERS.P_VNDPINCODE, Vendor.VNDPINCODE);
                DALModule.PARAMS.Add(PARAMETERS.P_VNDCOUNTRY, Vendor.VNDCOUNTRY);
                DALModule.PARAMS.Add(PARAMETERS.P_VNDEMAIL, Vendor.VNDEMAIL);
                DALModule.PARAMS.Add(PARAMETERS.P_VNDPHONE, Vendor.VNDPHONE);
                DALModule.PARAMS.Add(PARAMETERS.P_VNDMOBPHONE, Vendor.VNDMOBPHONE);
                DALModule.PARAMS.Add(PARAMETERS.P_VNDTINNO, Vendor.VNDTINNO);
                DALModule.PARAMS.Add(PARAMETERS.P_VNDBANKNAME, Vendor.VNDBANKNAME);
                DALModule.PARAMS.Add(PARAMETERS.P_VNDBANKBRANCH, Vendor.VNDBANKBRANCH);
                DALModule.PARAMS.Add(PARAMETERS.P_VNDBANKACCNO, Vendor.VNDBANKACCNO);
                DALModule.PARAMS.Add(PARAMETERS.P_VNDIFSCODE, Vendor.VNDIFSCODE);
                DALModule.PARAMS.Add(PARAMETERS.P_ACTIVE, Vendor.VNDACTIVE);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPID, Vendor.COMPANYID);
                DALModule.PARAMS.Add(PARAMETERS.P_AID, Vendor.ADDERID);
                DALModule.PARAMS.Add(PARAMETERS.P_MID, Vendor.MODIFIERID);
                DALModule.DSRESULT = DALModule.DPFactory.FillDataset(DALModule.DPFactory.GetConnection(), PROCEDURES.PROC_ADD_EDIT_DELETE_VENDORDETAILS, CommandType.StoredProcedure, DALModule.PARAMS);
            }
            catch (Exception ex)
            {
                DALModule.DALlogger.Error("Error in ClsVendorDAL in FunPubVendorTransaction", ex);
            }
            return DALModule.DSRESULT;
        }
        public DataTable FunPubFetchVendorDetails(ClsVendorEntity Vendor)
        {
            try
            {
                DALModule.PARAMS.Add(PARAMETERS.P_CMPID, Vendor.COMPANYID);
                DALModule.PARAMS.Add(PARAMETERS.P_VNDCODE, Vendor.VNDCODE);
                DALModule.PARAMS.Add(PARAMETERS.P_VNDNAME, Vendor.VNDNAME);
                DALModule.PARAMS.Add(PARAMETERS.P_ADT, Vendor.ADDEDDATE);
                DALModule.PARAMS.Add(PARAMETERS.P_MDT, Vendor.MODIFIEDDATE);
                DALModule.PARAMS.Add(PARAMETERS.P_ALLFLDSTAT, Vendor.ALLFIELDSTAT);
                DALModule.DTRESULT = DALModule.DPFactory.GetDataTable(PROCEDURES.PROC_FETCH_VENDORDETAILS, DALModule.PARAMS);
            }
            catch (Exception ex)
            {
                DALModule.DALlogger.Error("Error in ClsVendorDAL in FunPubFetchVendorDetails", ex);
            }

            return DALModule.DTRESULT;
        }
        public void Dispose()
        {

        }
    }
}
