using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JOY_BUS_LAYER.Common;
using JOY_BUS_LAYER.Utilities;
using JOY_BUS_LAYER.SysAdmin;
using JOY_DAL_LAYER.DataAccessComponent;

namespace JOY_DAL_LAYER.SysAdmin
{
    public class ClsCompanyDAL : IDisposable
    {
        public ClsCompanyDAL()
        {
            DALModule.ConnName = ClsUtilities.GETPASS(ClsUtilities.FunPubGetFileContents(Environment.CurrentDirectory + @"\PROC.RDN")).Split('|');
            DALModule.Connection = DALModule.ConnName[0];
            DALModule.DPFactory = new DataProvider(DALModule.Connection, DataProvider.DBType.MYSQL);
            DALModule.DALlogger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            DALModule.PARAMS = new Dictionary<string, Object>();
        }

        /// <summary>
        /// Inserts the Company details onto the database
        /// </summary>
        /// <param name="Company"></param>
        /// <param name="CompanyID"></param>
        /// <returns></returns>
        public int FunPubCompanyTransaction(ClsCompanyEntity Company, out int CompanyID)
        {
            CompanyID = 0;
            try
            {
                DALModule.PARAMS.Add(PARAMETERS.P_MODE, Company.MODE);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPNAME, Company.COMPANYNAME);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPALIASNAME, Company.COMPANYALIAS);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPLOGO, Company.COMPANYLOGO);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPADD1, Company.COMPANYADD1);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPADD2, Company.COMPANYADD2);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPCITY, Company.COMPANYCITY);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPPINCODE, Company.COMPANYPIN);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPCOUNTRY, Company.COMPANYCOUNTRY);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPEMAIL, Company.COMPANYEMAIL);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPPHONE, Company.COMPANYPHONE);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPMOBPHONE, Company.COMPANYMOBPHONE);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPFAX, Company.COMPANYFAX);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPTINNO, Company.COMPANYTINNO);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPTNGSTNO, Company.COMPANYTNGSTNO);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPPANNO, Company.COMPANYPANNO);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPBANKNAME, Company.COMPANYBANKNAME);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPBANKBRANCH, Company.COMPANYBANKBRANCH);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPBANKACCNO, Company.COMPANYBANKACCOUNT);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPBANKIFSCODE, Company.COMPANYBANKIFSC);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPFNAME, Company.CMPFONTNAME);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPFSIZE, Company.CMPFONTSIZE);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPFSTYLE, Company.CMPFONTSTYLE);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPADD1FNAME, Company.CMPADD1FONTNAME);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPADD1FSIZE, Company.CMPADD1FONTSIZE);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPADD1FSTYLE, Company.CMPADD1FONTSTYLE);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPCURRNAME, Company.COMPANYCURRNAME);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPCURRCODE, Company.COMPANYCURRCODE);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPCURRSYM, Company.COMPANYCURRSYM);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPCURRPAISE, Company.COMPANYCURRPAISE);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPCURREXCHNG, Company.COMPANYCURREXCHGRATE);
                DALModule.PARAMS.Add(PARAMETERS.P_ACTIVE, Company.COMPANYACTIVE);
                DALModule.PARAMS.Add(PARAMETERS.P_AID, Company.ADDERID);
                DALModule.PARAMS.Add(PARAMETERS.P_MID, Company.MODIFIERID);
                DALModule.PARAMS.Add(PARAMETERS.P_OUTPUT, null);
                DALModule.EXECRESULT = DALModule.DPFactory.ExecuteNonQuery(PROCEDURES.PROC_ADD_EDIT_DELETE_COMPANYDETAILS, DALModule.PARAMS);
                CompanyID = Convert.ToInt32(DALModule.DPFactory.GetParameter(PARAMETERS.P_OUTPUT.Replace("|OUT", ""), "OUT", null).Value);
            }
            catch (Exception ex)
            {
                DALModule.DALlogger.Error("Error in ClsCompanyDAL in FunPubCompanyTransaction", ex);
            }
            return DALModule.EXECRESULT;

        }

        /// <summary>
        /// Fetches the Branch details from the database.
        /// </summary>
        /// <param name="Company"></param>
        /// <returns></returns>
        public DataTable FunPubFetchCompany(ClsCompanyEntity Company)
        {
            try
            {
                DALModule.PARAMS.Add(PARAMETERS.P_ACTIVE, Company.COMPANYACTIVE);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPID, Company.COMPANYID);
                DALModule.PARAMS.Add(PARAMETERS.P_CMPNAME, Company.COMPANYNAME);
                DALModule.PARAMS.Add(PARAMETERS.P_ADT, Company.ADDEDDATE);
                DALModule.PARAMS.Add(PARAMETERS.P_MDT, Company.MODIFIEDDATE);
                DALModule.PARAMS.Add(PARAMETERS.P_ALLFLDSTAT, Company.ALLFIELDSTAT);
                DALModule.DTRESULT = DALModule.DPFactory.GetDataTable(PROCEDURES.PROC_FETCH_COMPANYDETAILS, DALModule.PARAMS);
            }
            catch (Exception ex)
            {
                DALModule.DALlogger.Error("Error in ClsCompanyDAL in FunPubFetchCompany", ex);
            }

            return DALModule.DTRESULT;
        }

        public void Dispose()
        {

        }
    }
}
