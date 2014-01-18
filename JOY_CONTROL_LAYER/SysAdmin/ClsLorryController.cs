using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JOY_BUS_LAYER.SysAdmin;
using JOY_DAL_LAYER.SysAdmin;
using System.Data;

namespace JOY_CONTROL_LAYER.SysAdmin
{
    public class ClsLorryController : IDisposable
    {
        public DataSet FunPubLorryTransaction(ClsLorryEntity Lorry)
        {
            using (ClsLorryDAL DAL = new ClsLorryDAL())
            {
                return DAL.FunPubLorryTransaction(Lorry);
            }
        }
        public DataTable FunPubFetchLorryDetails(ClsLorryEntity Lorry)
        {
            using (ClsLorryDAL DAL = new ClsLorryDAL())
            {
                return DAL.FunPubFetchLorryDetails(Lorry);
            }
        }
        public void Dispose()
        {

        }
    }
}
