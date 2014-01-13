using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JOY_BUS_LAYER.SysAdmin;
using JOY_DAL_LAYER.SysAdmin;
using System.Data;

namespace JOY_CONTROL_LAYER.SysAdmin
{
    public class ClsBranchController : IDisposable
    {
        /// <summary>
        /// Inserts the Branch details onto the database.
        /// </summary>
        /// <param name="Branch"></param>
        /// <param name="BranchID"></param>
        /// <returns></returns>
        public int FunPubbranchTransaction(ClsBranchEntity Branch, out int BranchID)
        {
            using (ClsBranchDAL DAL = new ClsBranchDAL())
            {
                return DAL.FunPubBranchTransaction(Branch, out BranchID);
            }

        }
        /// <summary>
        /// Fetches the Branch details from the database.
        /// </summary>
        /// <param name="Branch"></param>
        /// <returns></returns>
        public DataTable FunPubFetchBranch(ClsBranchEntity Branch)
        {
            using (ClsBranchDAL DAL = new ClsBranchDAL())
            {
                return DAL.FunPubFetchBranch(Branch);
            }

        }
        public void Dispose()
        {
        }
    }
}
