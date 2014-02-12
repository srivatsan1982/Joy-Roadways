using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
namespace JOY_BUS_LAYER.Utilities
{
    public class ClsCommonVariables
    {
        public static Color INFOCUS = Color.Lavender;
        public static Color OUTFOCUS = Color.White;
        public static log4net.ILog UIlogger;
        public DataTable DTUSERS;
        public DataTable DTLEDGERS;
        public DataTable DTDEPTS;
        public DataTable DTDESG;
        public DataTable DTCARDS;
        public DataTable DTUNITS;
        public DataTable DTMATCAT;
        public DataTable DTBRANDS;
        public DataTable DTGROUPS;
        public int USERID;
        public string FNAME;
        public string FTAG;
        public DataSet DSRESULT;
        public DataTable DTRESULT;
        //113
        public const Keys KEY_OPTION = Keys.F2;
        public const Keys KEY_FYPRD = Keys.F9;
        public const Keys KEY_OPENDT = Keys.F10;
        public const Keys KEY_INSERT = Keys.Insert;
        public const Keys KEY_HISTORY = Keys.F12;
        public const Keys KEY_QUIT = Keys.F4;
        public const Keys KEY_DELETE = Keys.Delete;
        public const Keys KEY_MASTER = Keys.Insert;
        public const Keys KEY_REC_INSERT = Keys.F6;
        public const Keys KEY_REC_DELETE = Keys.F7;
        //13
        public const Keys KEY_ENTER = Keys.Enter;
        public const Keys KEY_ESC = Keys.Escape;
        public const short KEY_QUERY_VALUE = 0x1;
        public const short KEY_SET_VALUE = 0x2;
        public const short KEY_CREATE_SUB_KEY = 0x4;
        public const short KEY_ENUMERATE_SUB_KEYS = 0x8;
        public const short KEY_NOTIFY = 0x10;
        public const short KEY_CREATE_LINK = 0x20;
        public const int SYNCHRONIZE = 0x100000;
        public const int ADD = 1;
        public const int MODIFY = 2;
        public const int DELETE = 3;
        public const int VIEW = 4;
        public int LOGINID;
        public int LOGINCMPID;
        public int LOGINGROUPID;
        public string ExSql;
        public string ASQL;
        public bool PRNTFLAG = true;
        public int FPRD;
        public int TPRD;
        public static bool SAVED = false;
        public static string REP = string.Empty;
        public static int CurFrmNo = 0;
        public static int FrmNo = 0;
       
    }
}
