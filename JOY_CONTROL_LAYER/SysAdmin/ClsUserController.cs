using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using JOY_DAL_LAYER.SysAdmin;
using JOY_BUS_LAYER.SysAdmin;

namespace JOY_CONTROL_LAYER.SysAdmin
{
    public class ClsUserController:IDisposable
    {
        public DataSet FunPubUserTransaction(ClsUserEntity User)
        {
            using (ClsUserDAL DAL = new ClsUserDAL())
            {
                return DAL.FunPubUserTransaction(User);
            }

        }
        public DataTable FunPubFetchUserDetails(ClsUserEntity User)
        {
            using (ClsUserDAL DAL = new ClsUserDAL())
            {
                return DAL.FunPubFetchUserDetails(User);
            }
        }
        public void Dispose()
        {

        }
    }
}
