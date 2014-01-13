using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JOY_BUS_LAYER.SysAdmin;
using System.Data;
using JOY_BUS_LAYER.Common;


namespace JOY_DAL_LAYER.SysAdmin
{
    public class ClsCustomerDAL:IDisposable
    {
        public int FunPubCustomerTransaction(ClsCustomerEntity Customer, out int CustomerID)
        {
            CustomerID = 0;
            try
            {
                DALModule.PARAMS.Add(PARAMETERS.P_MODE, Customer.MODE);
                DALModule.PARAMS.Add(PARAMETERS.P_CUSTID, Customer.CUSTID);
                DALModule.PARAMS.Add(PARAMETERS.P_CUSTCODE, Customer.CUSTCODE);
                DALModule.PARAMS.Add(PARAMETERS.P_BRANCHID, Customer.BRANCHID);
                DALModule.PARAMS.Add(PARAMETERS.P_CUSTFIRSTNAME, Customer.CUSTFIRSTNAME);
                DALModule.PARAMS.Add(PARAMETERS.P_CUSTLASTNAME, Customer.CUSTLASTNAME);
                DALModule.PARAMS.Add(PARAMETERS.P_CUSTADD1, Customer.CUSTADD1);
                DALModule.PARAMS.Add(PARAMETERS.P_CUSTADD2, Customer.CUSTADD2);
                DALModule.PARAMS.Add(PARAMETERS.P_CUSTCITY, Customer.CUSTCITY);
                DALModule.PARAMS.Add(PARAMETERS.P_CUSTPINCODE, Customer.CUSTPINCODE);
                DALModule.PARAMS.Add(PARAMETERS.P_CUSTCOUNTRY, Customer.CUSTCOUNTRY);
                DALModule.PARAMS.Add(PARAMETERS.P_CUSTEMAIL, Customer.CUSTEMAIL);
                DALModule.PARAMS.Add(PARAMETERS.P_CUSTPHONE, Customer.CUSTPHONE);
                DALModule.PARAMS.Add(PARAMETERS.P_CUSTMOBPHONE, Customer.CUSTMOBPHONE);
                DALModule.PARAMS.Add(PARAMETERS.P_ACTIVE, Customer.CUSTACTIVE);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPID, Customer.COMPANYID);
                DALModule.PARAMS.Add(PARAMETERS.P_AID, Customer.ADDERID);
                DALModule.PARAMS.Add(PARAMETERS.P_MID, Customer.MODIFIERID);
                DALModule.PARAMS.Add(PARAMETERS.P_OUTPUT, null);
                DALModule.EXECRESULT = DALModule.DPFactory.ExecuteNonQuery(PROCEDURES.PROC_ADD_EDIT_DELETE_CUSTOMERDETAILS, DALModule.PARAMS);
                CustomerID = Convert.ToInt32(DALModule.DPFactory.GetParameter(PARAMETERS.P_OUTPUT.Replace("|OUT", ""), "OUT", null).Value);
            }
            catch (Exception ex)
            {
                DALModule.DALlogger.Error("Error in ClsCustomerDAL in FunPubCustomerTransaction", ex);
            }
            return DALModule.EXECRESULT;
        }
        public DataTable FunPubFetchCustomerDetails(ClsCustomerEntity Customer)
        {
            try
            {
                DALModule.PARAMS.Add(PARAMETERS.P_CMPID, Customer.COMPANYID);
                DALModule.PARAMS.Add(PARAMETERS.P_BRANCHID, Customer.BRANCHID);
                DALModule.PARAMS.Add(PARAMETERS.P_CUSTCODE, Customer.CUSTCODE);
                DALModule.PARAMS.Add(PARAMETERS.P_CUSTFIRSTNAME, Customer.CUSTFIRSTNAME);
                DALModule.PARAMS.Add(PARAMETERS.P_ADT, Customer.ADDEDDATE);
                DALModule.PARAMS.Add(PARAMETERS.P_MDT, Customer.MODIFIEDDATE);
                DALModule.PARAMS.Add(PARAMETERS.P_ALLFLDSTAT, Customer.ALLFIELDSTAT);
                DALModule.DTRESULT = DALModule.DPFactory.GetDataTable(PROCEDURES.PROC_FETCH_CUSTOMERDETAILS, DALModule.PARAMS);
            }
            catch (Exception ex)
            {
                DALModule.DALlogger.Error("Error in ClsCustomerDAL in FunPubFetchCustomerDetails", ex);
            }

            return DALModule.DTRESULT;
        }
        public void Dispose()
        {

        }
    }
}
