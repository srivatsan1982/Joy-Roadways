using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JOY_BUS_LAYER.SysAdmin
{
    public class ClsUserEntity:IDisposable
    {
        public int MODE { get; set; }
        public int USERID { get; set; }
        public string USERCODE { get; set; }
        public string USERFIRSTNAME { get; set; }
        public string USERLASTNAME { get; set; }
        public string USERDOJ { get; set; }
        public string USERDOB { get; set; }
        public string USERROLE { get; set; }
        public string USEREMAIL { get; set; }
        public string USERPHONE { get; set; }
        public string USERPWD { get; set; }
        public int COMPANYID { get; set; }
        public bool USERACTIVE { get; set; }
        public int ADDERID { get; set; }
        public DateTime? ADDEDDATE { get; set; }
        public int MODIFIERID { get; set; }
        public DateTime? MODIFIEDDATE { get; set; }
        public int ALLFIELDSTAT { get; set; }
        
        public void Dispose()
        {
        }
    }
}
