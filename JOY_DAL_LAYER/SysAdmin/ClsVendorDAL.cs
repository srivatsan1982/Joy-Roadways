using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JOY_BUS_LAYER.SysAdmin;
using System.Data;
using JOY_BUS_LAYER.Common;

namespace JOY_DAL_LAYER.SysAdmin
{
    public class ClsVendorDAL:IDisposable
    {
        public int FunPubVendorTransaction(ClsVendorEntity Vendor, out int VendorID)
        {
            VendorID = 0;
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
                DALModule.PARAMS.Add(PARAMETERS.P_OUTPUT, null);
                DALModule.EXECRESULT = DALModule.DPFactory.ExecuteNonQuery(PROCEDURES.PROC_ADD_EDIT_DELETE_VENDORDETAILS, DALModule.PARAMS);
                VendorID = Convert.ToInt32(DALModule.DPFactory.GetParameter(PARAMETERS.P_OUTPUT.Replace("|OUT", ""), "OUT", null).Value);
            }
            catch (Exception ex)
            {
                DALModule.DALlogger.Error("Error in ClsVendorDAL in FunPubVendorTransaction", ex);
            }
            return DALModule.EXECRESULT;
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
