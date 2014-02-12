using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JOY_BUS_LAYER.Common
{
    public sealed class PROCEDURES
    {
        #region [Company Master]
        public const string PROC_ADD_EDIT_DELETE_COMPANYDETAILS = "SP_ADD_EDIT_DELETE_COMPANYDETAILS";
        public const string PROC_FETCH_COMPANYDETAILS = "SP_FETCH_COMPANYDETAILS";
        #endregion

        #region [Branch Master]
        public const string PROC_ADD_EDIT_DELETE_BRANCHDETAILS = "SP_ADD_EDIT_DELETE_BRANCHDETAILS";
        public const string PROC_FETCH_BRANCHDETAILS = "SP_FETCH_BRANCHDETAILS";
        #endregion

        #region [Lorry Master]
        public const string PROC_ADD_EDIT_DELETE_LORRYDETAILS = "SP_ADD_EDIT_DELETE_LORRYDETAILS";
        public const string PROC_FETCH_LORRYDETAILS = "SP_FETCH_LORRYDETAILS";
        #endregion

        #region [Customer Master]
        public const string PROC_ADD_EDIT_DELETE_CUSTOMERDETAILS = "SP_ADD_EDIT_DELETE_CUSTOMERDETAILS";
        public const string PROC_FETCH_CUSTOMERDETAILS = "SP_FETCH_CUSTOMERDETAILS";
        #endregion

        #region [Vendor Master]
        public const string PROC_ADD_EDIT_DELETE_VENDORDETAILS = "SP_ADD_EDIT_DELETE_VENDORDETAILS";
        public const string PROC_FETCH_VENDORDETAILS = "SP_FETCH_VENDORDETAILS";
        #endregion

        #region [User Master]
        public const string PROC_FETCH_USER_DETAILS = "SP_FETCH_USER_DETAILS";
        #endregion
    }
}
