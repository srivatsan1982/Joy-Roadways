﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JOY_BUS_LAYER.SysAdmin;
using JOY_DAL_LAYER.SysAdmin;
using System.Data;

namespace JOY_CONTROL_LAYER.SysAdmin
{
    public class ClsCustomerController:IDisposable
    {
        public DataSet FunPubCustomerTransaction(ClsCustomerEntity Customer)
        {
            using (ClsCustomerDAL DAL = new ClsCustomerDAL())
            {
                return DAL.FunPubCustomerTransaction(Customer);
            }
        }
        public DataTable FunPubFetchCustomerDetails(ClsCustomerEntity Customer)
        {
            using (ClsCustomerDAL DAL = new ClsCustomerDAL())
            {
                return DAL.FunPubFetchCustomerDetails(Customer);
            }
        }

        public void Dispose()
        {
            
        }
    }
}
