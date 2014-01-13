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
        public int FunPubVendorTransaction(ClsVendorEntity Vendor, out int VendorID)
        {
            using (ClsVendorDAL DAL = new ClsVendorDAL())
            {
                return DAL.FunPubVendorTransaction(Vendor, out VendorID);
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
