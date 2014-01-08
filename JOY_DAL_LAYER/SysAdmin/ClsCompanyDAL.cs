using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JOY_BUS_LAYER.SysAdmin;

namespace JOY_DAL_LAYER.SysAdmin
{
    public class ClsCompanyDAL:IDisposable
    {
        public ClsCompanyDAL()
        {

        }
        public int FunPubCompanyTransaction(ClsCompanyEntity Company, out int CompanyID)
        {
            CompanyID = 1;
            return CompanyID;
        }

        public List<ClsCompanyEntity> FunPubFetchCompany(int? CompanyID)
        {
            return new List<ClsCompanyEntity>();
        }

        public DataTable FunPubFetchCompany(ClsCompanyEntity Company)
        {
            return new DataTable();
        }

        public void Dispose()
        {
            
        }
    }
}
