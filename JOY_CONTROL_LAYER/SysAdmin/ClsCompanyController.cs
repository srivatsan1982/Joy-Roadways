﻿#region [Namespaces]
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JOY_BUS_LAYER.SysAdmin;
using JOY_DAL_LAYER.SysAdmin;
using System.Data;
#endregion

namespace JOY_CONTROL_LAYER.SysAdmin
{
    public class ClsCompanyController:IDisposable
    {
        #region [Constructor]
        public ClsCompanyController()
        {

        }
        
        #endregion


        #region [Controller Functions]
        /// <summary>
        /// To Add a Company to the database.
        /// </summary>
        /// <param name="Company"></param>
        /// <returns>Company Insertion Status</returns>
        public DataSet FunPubCompanyTransaction(ClsCompanyEntity Company)
        {
            using (ClsCompanyDAL DAL = new ClsCompanyDAL())
            {
                return DAL.FunPubCompanyTransaction(Company);
            }

        }
        /// <summary>
        /// To Fetch all Companies from the database.
        /// </summary>
        /// <param name="Company"></param>
        /// <returns>Company Details</returns>
        public DataTable FunPubFetchCompany(ClsCompanyEntity Company)
        {
            using (ClsCompanyDAL DAL = new ClsCompanyDAL())
            {
                return DAL.FunPubFetchCompany(Company);
            }

        }
        #endregion

        #region [IDisposible Interface Implementation]
        public void Dispose()
        {

        } 
        #endregion
    }
}
