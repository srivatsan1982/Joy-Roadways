using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JOY_BUS_LAYER.Common
{
    public sealed class PARAMETERS
    {
        #region[Common Parameters]
        public const string P_MODE = "P_MODE|IN";
        public const string P_CMPID = "P_CMPID|IN";
        public const string P_ACTIVE = "P_ACTIVE|IN";
        public const string P_AID = "P_AID|IN";
        public const string P_ADT = "P_ADT|IN";
        public const string P_MID = "P_MID|IN";
        public const string P_MDT = "P_MDT|IN";
        public const string P_OUTPUT = "P_OUTPUT|OUT";
        public const string P_ALLFLDSTAT = "P_ALLFLDSTAT|IN";
        #endregion

        #region [Company Master]
        public const string P_CMPNAME = "P_CMPNAME|IN";
        public const string P_CMPALIASNAME = "P_CMPALIASNAME|IN";
        public const string P_CMPLOGO = "P_CMPLOGO|IN";
        public const string P_CMPADD1 = "P_CMPADD1|IN";
        public const string P_CMPADD2 = "P_CMPADD2|IN";
        public const string P_CMPCITY = "P_CMPCITY|IN";
        public const string P_CMPPINCODE = "P_CMPPINCODE|IN";
        public const string P_CMPCOUNTRY = "P_CMPCOUNTRY|IN";
        public const string P_CMPEMAIL = "P_CMPEMAIL|IN";
        public const string P_CMPPHONE = "P_CMPPHONE|IN";
        public const string P_CMPMOBPHONE = "P_CMPMOBPHONE|IN";
        public const string P_CMPFAX = "P_CMPFAX|IN";
        public const string P_CMPTINNO = "P_CMPTINNO|IN";
        public const string P_CMPTNGSTNO = "P_CMPTNGSTNO|IN";
        public const string P_CMPPANNO = "P_CMPPANNO|IN";
        public const string P_CMPBANKNAME = "P_CMPBANKNAME|IN";
        public const string P_CMPBANKBRANCH = "P_CMPBANKBRANCH|IN";
        public const string P_CMPBANKACCNO = "P_CMPBANKACCNO|IN";
        public const string P_CMPBANKIFSCODE = "P_CMPBANKIFSCODE|IN";
        public const string P_CMPFNAME = "P_CMPFNAME|IN";
        public const string P_CMPFSIZE = "P_CMPFSIZE|IN";
        public const string P_CMPFSTYLE = "P_CMPFSTYLE|IN";
        public const string P_CMPADD1FNAME = "P_CMPADD1FNAME|IN";
        public const string P_CMPADD1FSIZE = "P_CMPADD1FSIZE|IN";
        public const string P_CMPADD1FSTYLE = "P_CMPADD1FSTYLE|IN";
        public const string P_CMPCURRNAME = "P_CMPCURRNAME|IN";
        public const string P_CMPCURRCODE = "P_CMPCURRCODE|IN";
        public const string P_CMPCURRSYM = "P_CMPCURRSYM|IN";
        public const string P_CMPCURRPAISE = "P_CMPCURRPAISE|IN";
        public const string P_CMPCURREXCHNG = "P_CMPCURREXCHNG|IN";
        
        #endregion

        #region [Branch Master]
        public const string P_BRANCHID = "P_BRANCHID|IN";
        public const string P_BRANCHCODE = "P_BRANCHCODE|IN";
        public const string P_BRANCHNAME = "P_BRANCHNAME|IN";
        public const string P_BRANCHCONTACTNAME = "P_BRANCHCONTACTNAME|IN";
        public const string P_BRANCHPHONE = "P_BRANCHPHONE|IN";
        public const string P_BRANCHMOBILEPHONE = "P_BRANCHMOBILEPHONE|IN";
        public const string P_BRANCHADD1 = "P_BRANCHADD1|IN";
        public const string P_BRANCHADD2 = "P_BRANCHADD2|IN";
        public const string P_BRANCHCITY = "P_BRANCHCITY|IN";
        public const string P_BRANCHPINCODE = "P_BRANCHPINCODE|IN";
        public const string P_BRANCHCOUNTRY = "P_BRANCHCOUNTRY|IN";
        #endregion

        #region [Lorry Master]
        public const string P_LRYID = "P_LRYID|IN";
        public const string P_LRYNAME = "P_LRYNAME|IN";
        public const string P_LRYOWNER = "P_LRYOWNER|IN";
        public const string P_LRYNUMBER = "P_LRYNUMBER|IN";
        public const string P_LRYDESC = "P_LRYDESC|IN";
        #endregion

        #region [Customer Master]
        public const string P_CUSTID = "P_CUSTID|IN";
        public const string P_CUSTCODE = "P_CUSTCODE|IN";
        public const string P_CUSTFIRSTNAME = "P_CUSTFIRSTNAME|IN";
        public const string P_CUSTLASTNAME = "P_CUSTLASTNAME|IN";
        public const string P_CUSTADD1 = "P_CUSTADD1|IN";
        public const string P_CUSTADD2 = "P_CUSTADD2|IN";
        public const string P_CUSTCITY = "P_CUSTCITY|IN";
        public const string P_CUSTPINCODE = "P_CUSTPINCODE|IN";
        public const string P_CUSTCOUNTRY = "P_CUSTCOUNTRY|IN";
        public const string P_CUSTEMAIL = "P_CUSTEMAIL|IN";
        public const string P_CUSTPHONE = "P_CUSTPHONE|IN";
        public const string P_CUSTMOBPHONE = "P_CUSTMOBPHONE|IN";
        #endregion

        #region [Vendor Master]
        public const string P_VNDID = "P_VNDID|IN";
        public const string P_VNDCODE = "P_VNDCODE|IN";
        public const string P_VNDNAME = "P_VNDNAME|IN";
        public const string P_VNDADD1 = "P_VNDADD1|IN";
        public const string P_VNDADD2 = "P_VNDADD2|IN";
        public const string P_VNDCITY = "P_VNDCITY|IN";
        public const string P_VNDPINCODE = "P_VNDPINCODE|IN";
        public const string P_VNDCOUNTRY = "P_VNDCOUNTRY|IN";
        public const string P_VNDEMAIL = "P_VNDEMAIL|IN";
        public const string P_VNDPHONE = "P_VNDPHONE|IN";
        public const string P_VNDMOBPHONE = "P_VNDMOBPHONE|IN";
        public const string P_VNDTINNO = "P_VNDTINNO|IN";
        public const string P_VNDBANKNAME = "P_VNDBANKNAME|IN";
        public const string P_VNDBANKBRANCH = "P_VNDBANKBRANCH|IN";
        public const string P_VNDBANKACCNO = "P_VNDBANKACCNO|IN";
        public const string P_VNDIFSCODE = "P_VNDIFSCODE|IN";
        #endregion
    }
}
