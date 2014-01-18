using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JOY_BUS_LAYER.SysAdmin;
using JOY_DAL_LAYER.SysAdmin;
using System.Data;

namespace JOY_CONTROL_LAYER.SysAdmin
{
    public class ClsVendorController:IDisposable
    {
        public DataSet FunPubVendorTransaction(ClsVendorEntity Vendor)
        {
            using (ClsVendorDAL DAL = new ClsVendorDAL())
            {
                return DAL.FunPubVendorTransaction(Vendor);
            }

        }
        public DataTable FunPubFetchVendorDetails(ClsVendorEntity Vendor)
        {
            using (ClsVendorDAL DAL = new ClsVendorDAL())
            {
                return DAL.FunPubFetchVendorDetails(Vendor);
            }
        }

        public void Dispose()
        {
            
        }
    }
}
