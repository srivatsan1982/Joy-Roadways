using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using JOY_UI_LAYER.SysAdmin;
using JOY_UI_LAYER.Common;

namespace JOY_UI_LAYER
{
    public class ProgramModule
    {

        public string[] SET_SECURITY = new string[1];
        public const int ALLOWMULTICMP = 0;
        public const int ALLOWMULTICOUNTER = 0;
        public string ITEM_ENTRY_PWD = "";
        public int Uid;
        public int POS;
        public byte TOTDISCNTASAMT;
        public bool kp;
        public int USRLVL;
        public string USRNM;
        public string CNTRS;
        public string APPDATE;
        public string PERIOD;
        public string SYSPATH;
        public string CURRYR;
        public byte FRMCONTCALL;
        public byte BKGTRANS;
        public byte IMPSBCALL;
        public byte FRMCPTCALL;
        public byte FRMBRCALL;
        public byte FRMVOYCALL;
        public byte FRMCARRIERCALL;
        public byte FRMPOFCALL;
        public byte FRMFORCALL;
        public byte FRMCFCALL;
        public byte FRMSPCALL;
        public byte FRMCSIGNCALL;
        public byte FRMNTFYCALL;
        public byte FRMFCSIGNCALL;
        public byte FRMPRODCALL;
        public string MsgboxCaption = "Joy Roadways Logistics";
        public string REP;
        public bool PRNTFLG;
        public byte BILLADJSTFLG;
        public int FLDTYPE;
        public int CDTYE;
        public string FRMCAP;
        public PictureBox LOGOPICT;
        private bool NOTOK;
        public bool CNTRLFLG;
        public bool EDITDS;
        public object FrmMdiMain;
        public bool ISITLITE;
        string AA;
        string EXIST;
        string SCODE;
        string Time;
        public bool MLSIAMOD;
        public bool SAVED;
        public bool DELETED;
        public string LMsg;
        public LstItemData CLS = new LstItemData("", "");
        public FrmMdiMain objFrmMdiMain = new FrmMdiMain();
        //public ManagementObjectSearcher objMOS;
        //public ManagementObjectCollection objMOC;
        //public ManagementObject objMO;
        public string DateFormat;
        public bool DateSetDt;
        public object ActiveChildForm;
        public FrmHlpGrd sFrmHlpGrd = new FrmHlpGrd();
        public OleDbTransaction Tran;
        public System.IO.TextReader TReader;
        public System.IO.TextWriter TWriter;
        public const int IS_MISSING_OPTIONAL_PARAM_INT = 0;
        public int MNUTAG;
        public long SELFY;
        public string RD;
        public string CMD;
        public byte IAUTOCBM;
        public byte IFREEDAYS;
        public byte IPDFREEDAYS;
        public byte EAUTOCBM;
        public byte IFRTSUM;
        public byte SEPRCPT;
        public byte EBLNO;
        public byte CCPRI;
        public byte CCSEC;
        public string LINECODE;
        public string SARNNO;
        public string CARNNO;
        public string SRVTAXNO;
        public byte IDORCPT;
        public byte DTNCALC;
        public byte ISFBILL;
        public string LOCALE;
        public byte ERNDAMT;
        public byte IRNDAMT;
        public byte IBNK;
        public byte EBNK;
        public byte IKEYPRESS;
        public byte EKEYPRESS;
        public string CCFNAME;
        public string CAFNAME;
        public byte CCFSTYLE;
        public byte CCFSIZE;
        public byte CAFSIZE;
        public byte CAFSTYLE;
        public bool CADDATBTM;
        public bool SHOWRPT;
        public string CBM_SETTING;
        public string CURRENCY_NAME;
        public string CURRENCY_SYMBOL;
        public string CURRENCY_CODE;
        public string CURRENCY_PAISE;
        public string LOCAL_PORT;
        public float EXCHANGE_RATE;
        public string CFNAME;
        public string AFNAME;
        public byte CFSIZE;
        public byte AFSIZE;
        public byte CFSTYLE;
        public byte AFSTYLE;
        public bool ADDATBTM;
        public string CollFrdt;
        public string CollTodt;
        public string CollCountr;
        public int CollCounter;
        public int Collbank;
        public const int ADD = 1;
        public const int MODIFY = 2;
        public const int DELETE = 3;
        public const int VIEW = 4;
        public int CMPID;
        public string SELECTEDLOCATION;
        public Color INFOCUS = Color.Lavender;
        public Color OUTFOCUS = Color.White;
        public string MCS;
        public bool VALFLG;
        public string MsgData;
        public string LOCALIP;
        public string DB_FLDNAME;
        public string DB_FLDTYPE;
        public string TYPEMSG;
        public int DB_FLDPREC;
        public int DB_FLDSCALE;
        public int counter;
        public System.DateTime JBYR;
        public bool EOUSAM;
        public bool EOUIVV;
        public bool RESTRICT;
        public bool CANFLG;
        // Key is preserved when system is rebooted
        public string RemoteHost;
        public int NOUSR;
        public byte OVERWRITE;
        public bool SendComplete;
        public bool ISITOK;
        public bool LOADED;
        public const string FIRSTTIME = "01";
        public const string SYSVALID = "02";
        public const string SYSNOTVALID = "03";
        public const string QUIT = "04";
        public const string MESSAGE = "05";
        public const string MYNAME = "06";
        public const string SYSDEMO = "07";
        public const string SYSCNTEXCD = "08";
        public const string SYSOVERWRITE = "09";
        public const string CHNGLICENCE = "10";
        public string APPPATH;
        public string APPNAME;
        public string PATCHDT;
        public struct FFLOC
        {
            public string LOCATION;
            public string DSN;
            public string LICENSE;
            public string SERVERNAME;
        }
        public dynamic HKEY_LOCAL_MACHINE = "&H80000002";
        public object LGM;
        public object Frm;
        public FFLOC[] LOCS;
        public byte COUNTERID;
        public byte BILLTYPE;
        public byte MINITMROWS;
        public string COUNTERTYPE;
        public string COUNTER_NAME;
        public string FOOTNOTE;
        public string NINES;
        public string SERVERIP;
        public string SCODE1;
        public string STATEDESC;
        public string STATEDESC1;
        public string NATURECONT;
        public string NATUREID;
        public bool MASFLG;
        public bool DBFLG;
        public bool ZEROCOL;
        public bool CLNTFLAG;
        public bool TFLAG;
        public bool RFLAG;
        public bool SAVEFLAG;
        public string EXQRY;
        public string HLPOledb;
        public float GRDHEIGHT;
        public const string RPASS = "SKUMAR";
        public string[] DATATYPES = new string[4];
        const int ERROR_SUCCESS = 0;
        // Unicode nul terminated string
        const int REG_SZ = 1;
        // 32-bit number
        const int REG_DWORD = 4;

        const string gREGKEYSYSINFOLOC = "SOFTWARE\\Microsoft\\Shared Tools Location";
        const string gREGVALSYSINFOLOC = "MSINFO";
        const string gREGKEYSYSINFO = "SOFTWARE\\Microsoft\\Shared Tools\\MSINFO";
        const string gREGVALSYSINFO = "PATH";

        public struct Critter
        {
            public int Xp;
            public int Yp;
            public int Width;
            public int Height;
            public int Xmove;
            public int Ymove;
        }
        // ERROR: Not supported in C#: DeclareDeclaration
        public string COMPANY_NAME;
        public int COMPANYID;
        public string UPLS_STATE;
        public string ADDRESS;
        public string PH;
        public string FAX;
        public string EMAIL;
        public string REGCODE;
        public string AGENTCODE;
        string TT;
        string[] RR;
        public string OraService;
        public string OraUser;
        public string OraPass;
        public int ContBLNo;
        public string ContBlName;
        public string ContType;
        public float ContChrg;
        public byte CONTSAVE;
        public string BLNOVAL;
        public string CARGOFLG;
        public object Fso;
        public string HLPDATA1;
        public string HLPDATA2;
        public string USRNAME;
        public string HLPDATA3;
        public string ostr;
        public string FRMRIGHTS;
        public string RIGHTS;
        public string LSTR;
        public string RT;
        public string[] SLOC;
        public string MM;
        public string YY;
        public string CRDID;
        public string FLD2;
        public string FLD3;
        public string subkey_name;
        public string REPLACESERVER;
        public string HLPWHERE;
        public string HLPORDER;
        public string MODFRM;
        TextReader EL;
        int I;
        int J;
        //Use in Flat Error
        public byte ErrCall;
        public object BR;
        public bool chnf;
        public string txtcat;
        public string txtrbi;
        public string txtrbidt;
        public const int STANDARD_RIGHTS_ALL = 0x1f0000;
        //******************** From Keys**************************** 'V.Senthil
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
        //todo public const string SYNCHRONIZE = "0x100000";
        //public const bool KEY_ALL_ACCESS = ((STANDARD_RIGHTS_ALL | KEY_QUERY_VALUE | KEY_SET_VALUE | KEY_CREATE_SUB_KEY | KEY_ENUMERATE_SUB_KEYS | KEY_NOTIFY | KEY_CREATE_LINK) & (!SYNCHRONIZE));
        //***********************************    
        //FOR GETMACADD98
        public string USERMANAGER;
        public byte CALLBYSETTING;
        private const int NCBASTAT = 0x33;
        private const int NCBNAMSZ = 16;
        private const int HEAP_ZERO_MEMORY = 0x8;
        private const int HEAP_GENERATE_EXCEPTIONS = 0x4;
        private const int NCBRESET = 0x32;
        public struct ShowForms
        {
            // Form Object
            public dynamic ObjFrm;
            // Form Name
            public string FrmName;
            // Form Tag
            public string frmTag;
        }
        public ShowForms[] ShwFrm;
        public int FrmNo;
        //FrmNo-count of form child's ,CurFrmNo-Current From Number
        public int CurFrmNo;

        public bool SkeySt;
        // using Shortcutkeys 
        public bool skey;
        //*********************************************** 'D.Senthil
        public string ERRMSG;
        public string FLD;
        public string str;
        public string SS;
        public string TEMPSTR;
        public DialogResult ch;
        public string BLID;

        public OleDbDataReader ShippersRs;
        public struct REPOBJ
        {
            public Form[] ITEMS;
            public string[] PEXQRY;
            public string[] RIGHTS;
        }
        //'************************************************ 
        //Public Structure FormsCollection

        //End Structure

        //Public Forms As FormsCollection
        public string HLPDATA4;
        public int JOBNO;
        public int INVSRNo;
        public int ACTINVNO;
        public int LID;
        public int ITEMSRNO;
        public int PMV;
        public string SCHEMECODE;
        public string RITCCODE;
        public decimal ITMTOTAL;
        public string RITCODE;
        public int CLNTID;
        public string CLNTNAME;
        public string CLNTADD1;
        public string CLNTADD2;
        public string CLNTBR1;
        public string CLNTADD3;
        public string CLNTCITY;
        public string CLNTPIN;
        public int ITEMSRNO1;
        public int PMV1;
        public string SCHEMECODE1;
        public string RITCCODE1;
        public string[] ones = new string[10];
        public string[] abones = new string[10];
        public string[] tens = new string[10];
        public string[] ext = new string[5];
        public string[] cons = new string[5];

        [DllImport("user32", EntryPoint = "SendMessageA")]
        private static extern long SendMessage(long hwnd, long wMsg, long wParam, long lParam);
        [DllImport("user32", EntryPoint = "SetForegroundWindow")]
        private static extern long SetForegroundWindow(IntPtr hwnd);
        [DllImport("inpout32.dll", EntryPoint = "Inp32")]
        private static extern byte Inp(int PortAddress);
        [DllImport("inpout32.dll", EntryPoint = "Out32")]
        private static extern long Out(int PortAddress, byte Value);
        [DllImport("advapi32", EntryPoint = "RegOpenKeyExA")]
        private static extern long RegOpenKeyEx(long hKey, string lpSubKey, long ulOptions, long samDesired, long phkResult);
        [DllImport("advapi32", EntryPoint = "RegQueryValueExA")]
        private static extern long RegQueryValueEx(long hKey, string lpValueName, long lpReserved, long lpType, string lpData, long lpcbData);
        [DllImport("advapi32")]
        private static extern long RegCloseKey(long hKey);
        [DllImport("kernel32", EntryPoint = "GetComputerNameA")]
        private static extern int GetComputerName(string lpBuffer, int nSize);
        [DllImport("kernel32")]
        private static extern void Sleep(int dwMilliseconds);
        [DllImport("advapi32", EntryPoint = "RegSetValueExA")]
        private static extern long RegSetValueEx(long hKey, string lpValueName, long lpReserved, long lpType, string lpData, long lpcbData);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmCompanyMaster());
        }

        /// <summary>
        /// To get the command part of a string
        /// </summary>
        /// Created On : 22/12/2013
        /// Created by : Srivatsan.S
        /// <returns></returns>
        public string GetCmd(string DataStr)
        {
            string MsgCmd = null;
            MsgCmd = DataStr.Substring(0, 1);
            if (DataStr.Length > 3)
            {
                MsgData = DataStr.Substring(4, (DataStr.Length) - 1);
            }
            return MsgCmd;
        }

        /// <summary>
        /// To check if the Application is already running
        /// </summary>
        /// Created On : 22/12/2013
        /// Created by : Srivatsan.S
        /// <returns></returns>
        public bool AppIsAlreadyRunning()
        {
            Process c = Process.GetCurrentProcess();
            foreach (Process p in Process.GetProcessesByName(c.ProcessName))
            {
                if (p.Id != c.Id)
                {
                    if (p.MainModule.FileName.ToLower().Equals(c.MainModule.FileName.ToLower()))
                    {
                        SetForegroundWindow(p.MainWindowHandle);
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Initializes the array variables for string formation. The Connect() function in Fastbilling has been named as InitializeVariables
        /// </summary>
        /// Created On : 22/12/2013
        /// Created by : Srivatsan.S
        /// <returns></returns>
        public bool InitializeVariables()
        {
            bool functionReturnValue = false;
            string STR = null;
            string FSTR = null;
            string ENCSTR = null;
            dynamic ADD1 = null;
            dynamic ADD2 = null;
            dynamic ADD3 = null;
            dynamic PH = null;
            dynamic FAX = null;
            dynamic EMAIL = null;
            int I = 0;
            int J = 0;
            int L = 0;
            int POS = 0;
            try
            {

                ENCSTR = "SRIVASINI INFOTECH";
                L = ENCSTR.Length;
                functionReturnValue = true;
                ones[1] = " One ";
                ones[2] = " Two ";
                ones[3] = " Three ";
                ones[4] = " Four ";
                ones[5] = " Five ";
                ones[6] = " Six ";
                ones[7] = " Seven ";
                ones[8] = " Eight ";
                ones[9] = " Nine ";


                abones[1] = " Eleven ";
                abones[2] = " Twelve ";
                abones[3] = " Thirteen ";
                abones[4] = " Fourteen ";
                abones[5] = " Fifteen ";
                abones[6] = " Sixteen ";
                abones[7] = " Seventeen ";
                abones[8] = " Eighteen ";
                abones[9] = " Nineteen ";

                tens[1] = " Ten ";
                tens[2] = " Twenty ";
                tens[3] = " Thirty ";
                tens[4] = " Fourty ";
                tens[5] = " Fifty ";
                tens[6] = " Sixty ";
                tens[7] = " Seventy ";
                tens[8] = " Eighty ";
                tens[9] = " Ninety ";

                ext[1] = " Hundred ";
                ext[2] = " Thousand ";
                ext[3] = " Lakh ";
                ext[4] = " Crore ";

                cons[1] = " and ";
                cons[2] = " Paise ";
                cons[3] = " Only ";
                cons[4] = " Rupees ";

                MINITMROWS = 5;
                return functionReturnValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to initialize the variables", MsgboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                functionReturnValue = false;
            }
            return functionReturnValue;
        }

        //  todo      public void DATAHLP(string Title, string Oledb, string WHEREFLD, string FILTERFLD, string ORDERFLD, ref int? NEWVAL, ref byte? UNIONFLG)
        //{
        //            NEWVAL=1;
        //            UNIONFLG=0;
        //    Array.Resize(ref RR, 22);
        //    sFrmHlpGrd = new FrmHlpGrd();
        //    Oledb =Oledb.Trim();
        //    TT = Oledb.Replace(Oledb, "SELECT", "SELECT TOP 200", , 1);
        //    TT = TT.Replace(TT, "SELECT TOP 200 DISTINCT", "SELECT DISTINCT TOP 200", , 1);
        //    Oledb = TT;
        //    if (!string.IsNullOrEmpty(WHEREFLD.Trim()))
        //        WHEREFLD = WHEREFLD + " AND ";
        //    HLPOledb = Oledb.Trim() + " WHERE " + WHEREFLD.Trim();
        //    HLPORDER = ORDERFLD;
        //    sFrmHlpGrd.UnionFlag = UNIONFLG;
        //    sFrmHlpGrd.NEWVAL = NEWVAL;
        //    sFrmHlpGrd.GRDHT = sFrmHlpGrd.DBGrid.Height;
        //    string[] ss = null;
        //    int i = 0;
        //    ss = Title.Split('|');
        //    for (i = 0; i <= ss.GetUpperBound(ss.Length); i++) {
        //        if (i == 0) {
        //            sFrmHlpGrd.Text = ss[0];
        //        } else if (i == 1) {
        //            sFrmHlpGrd.LblFld1.Text = ss[1];
        //        } else if (i == 2) {
        //            sFrmHlpGrd.LblFld2.Text = ss[2];
        //        } else if (i == 3) {
        //            sFrmHlpGrd.LblFld3.Text = ss[3];
        //        }
        //    }

        //    long RECCNT = 0;

        //    EXQRY = HLPOledb + " " + FILTERFLD.Trim() + " " + ORDERFLD.Trim();
        //    OledbDA = new OleDbDataAdapter(EXQRY, OledbCon);
        //    sFrmHlpGrd.HlpRs = new DataSet();
        //    try {
        //        OledbDA.Fill(sFrmHlpGrd.HlpRs);
        //    } catch (Exception ex) {
        //    }

        //    sFrmHlpGrd.DBGrid.DataSource = sFrmHlpGrd.HlpRs.Tables(0);
        //    RECCNT = sFrmHlpGrd.HlpRs.Tables(0).Rows.Count;
        //    //RECCNT = sFrmHlpGrd.DBGrid.RowCount
        //    if (!(RECCNT == 0)) {
        //        //FrmHlpGrd.DBGrid.a= 0
        //        //FrmHlpGrd.DBGrid.Col = 0
        //        //FrmHlpGrd.TxtHCell.Text = FrmHlpGrd.DBGrid.Columns(0).Text
        //        //FrmHlpGrd.TxtHCell.Text = FrmHlpGrd.DBGrid.Columns(0).Selected.ToString
        //    }

        //    //FrmHlpGrd.DBGrid.RecordSelectors = False
        //    //FrmHlpGrd.DBGrid.AllowUpdate = False
        //    sFrmHlpGrd.DBGrid.AllowUserToAddRows = false;
        //    sFrmHlpGrd.DBGrid.AllowUserToDeleteRows = false;
        //    sFrmHlpGrd.DBGrid.AllowUserToResizeRows = false;
        //    //FrmHlpGrd.DBGrid.Splits(0).AllowSizing = False
        //    //FrmHlpGrd.DBGrid.Columns(0).AllowSizing = False
        //    //FrmHlpGrd.DBGrid.Columns(1).AllowSizing = False
        //    sFrmHlpGrd.DBGrid.ScrollBars = ScrollBars.Vertical;
        //    //sFrmHlpGrd.DBGrid.ScrollBars = dbgVertical
        //    if (NEWVAL == 3) {
        //        if (sFrmHlpGrd.DBGrid.RowCount <= 16) {
        //            sFrmHlpGrd.DBGrid.Columns(2).Width = sFrmHlpGrd.TxtFld3.Width - 5;
        //        } else {
        //            sFrmHlpGrd.DBGrid.Columns(2).Width = sFrmHlpGrd.TxtFld3.Width - 12;
        //        }
        //        sFrmHlpGrd.DBGrid.Columns(1).Width = sFrmHlpGrd.TxtFld2.Width;
        //        sFrmHlpGrd.DBGrid.Columns(0).Width = sFrmHlpGrd.TxtFld1.Width;
        //        sFrmHlpGrd.DBGrid.Columns(3).Visible = false;
        //        sFrmHlpGrd.DBGrid.Width = sFrmHlpGrd.TxtFld1.Width + sFrmHlpGrd.TxtFld2.Width + sFrmHlpGrd.TxtFld3.Width - 1;
        //        //+ 5
        //        sFrmHlpGrd.windFrame.Width = sFrmHlpGrd.DBGrid.Width + 20 + 5;
        //        sFrmHlpGrd.TxtFld2.Visible = true;
        //        sFrmHlpGrd.LblFld2.Visible = true;
        //        sFrmHlpGrd.TxtFld3.Visible = true;
        //        sFrmHlpGrd.LblFld3.Visible = true;
        //        sFrmHlpGrd.Width = sFrmHlpGrd.DBGrid.Width + 30 + 5;
        //    } else if (NEWVAL == 2) {
        //        if (sFrmHlpGrd.DBGrid.RowCount <= 16) {
        //            sFrmHlpGrd.DBGrid.Columns(1).Width = sFrmHlpGrd.TxtFld2.Width - 5;
        //        } else {
        //            sFrmHlpGrd.DBGrid.Columns(1).Width = sFrmHlpGrd.TxtFld2.Width - 12;
        //        }
        //        //sFrmHlpGrd.DBGrid.Columns(1).Width = sFrmHlpGrd.TxtFld2.Width - 5
        //        sFrmHlpGrd.DBGrid.Columns(0).Width = sFrmHlpGrd.TxtFld1.Width;
        //        sFrmHlpGrd.DBGrid.Columns(2).Visible = false;
        //        //FrmHlpGrd.DBGrid.Columns(3).Visible = False
        //        sFrmHlpGrd.DBGrid.Width = sFrmHlpGrd.TxtFld1.Width + sFrmHlpGrd.TxtFld2.Width - 1;
        //        //+ 5
        //        sFrmHlpGrd.windFrame.Width = sFrmHlpGrd.DBGrid.Width + 20 + 5;
        //        sFrmHlpGrd.TxtFld2.Visible = true;
        //        sFrmHlpGrd.LblFld2.Visible = true;
        //        sFrmHlpGrd.TxtFld3.Visible = false;
        //        sFrmHlpGrd.LblFld3.Visible = false;
        //        sFrmHlpGrd.Width = sFrmHlpGrd.DBGrid.Width + 30 + 5;
        //    } else {
        //        if (sFrmHlpGrd.DBGrid.RowCount <= 16) {
        //            sFrmHlpGrd.DBGrid.Columns(0).Width = sFrmHlpGrd.TxtFld1.Width;
        //        } else {
        //            sFrmHlpGrd.DBGrid.Columns(0).Width = sFrmHlpGrd.TxtFld1.Width - 7;
        //        }
        //        sFrmHlpGrd.TxtFld2.Visible = false;
        //        sFrmHlpGrd.LblFld2.Visible = false;
        //        sFrmHlpGrd.TxtFld3.Visible = false;
        //        sFrmHlpGrd.LblFld3.Visible = false;
        //        sFrmHlpGrd.DBGrid.Width = sFrmHlpGrd.TxtFld1.Width - 1;
        //        sFrmHlpGrd.windFrame.Width = sFrmHlpGrd.DBGrid.Width + 20 + 5;
        //        sFrmHlpGrd.DBGrid.Columns(1).Visible = false;
        //        //sFrmHlpGrd.DBGrid.Columns(0).Width = sFrmHlpGrd.TxtFld1.Width
        //        sFrmHlpGrd.Width = sFrmHlpGrd.DBGrid.Width + 30 + 5;
        //        sFrmHlpGrd.TOTREC.Width = sFrmHlpGrd.TxtFld1.Width + 5;
        //    }
        //    //FrmHlpGrd.TxtHCell.Visible = False
        //    //FrmHlpGrd.TxtHCell.Width = FrmHlpGrd.DBGrid.Columns(0).Width
        //    //        FrmHlpGrd.TxtHCell.Left = FrmHlpGrd.DBGrid.Columns(0).Left + 85
        //    //FrmHlpGrd.TxtHCell.Left = FrmHlpGrd.DBGrid.Columns(0)
        //    int ADJ = 0;
        //    if (RECCNT == 1) {
        //        ADJ = 50;
        //    } else {
        //        ADJ = 100;
        //    }
        //    try {
        //        GRDHEIGHT = (sFrmHlpGrd.DBGrid.RowCount * RECCNT) + ADJ;
        //        if (GRDHEIGHT < sFrmHlpGrd.GRDHT) {
        //            sFrmHlpGrd.DBGrid.Height = 300;
        //            //GRDHEIGHT
        //        //FrmHlpGrd.DBGrid.ScrollBars = dbgNone
        //        } else {
        //            sFrmHlpGrd.DBGrid.Height = sFrmHlpGrd.GRDHT;
        //        }

        //        sFrmHlpGrd.TOTREC.Text = Strings.Trim(sFrmHlpGrd.DBGrid.RowCount) + "  Record(s) Found";
        //        int POS = 0;
        //        POS = Strings.InStr(1, Strings.Trim(FILTERFLD), "LIKE '", 1) + 6;

        //        sFrmHlpGrd.TxtFld1.Text = Strings.UCase(Strings.Mid(Strings.Trim(FILTERFLD), POS, Strings.InStr(1, Strings.Trim(FILTERFLD), "%", 1) - POS));
        //        sFrmHlpGrd.TxtFld1.SelectionStart = Strings.Len(sFrmHlpGrd.TxtFld1.Text);

        //        if (RECCNT == 0) {
        //            HLPDATA1 = "";
        //            HLPDATA2 = "";
        //            HLPDATA3 = "";
        //            HLPDATA4 = "";
        //            Interaction.MsgBox("No Records Found ! ", Constants.vbInformation);
        //        } else {
        //            sFrmHlpGrd.ShowDialog();
        //        }
        //    } catch (Exception ex) {
        //        Interaction.MsgBox(ex.Message);
        //    }

        //}

        /// <summary>
        /// To validate the values which are sent to the database
        /// </summary>
        /// <param name="FLDVALUE"></param>
        /// <returns></returns>
        public bool FVALIDATE(string FLDVALUE)
        {
            int valueParsed;
            bool functionReturnValue = false;

            functionReturnValue = true;
            if (DB_FLDTYPE.ToUpper() == "SMALLINT")
            {
                if (!string.IsNullOrEmpty(FLDVALUE.Trim()))
                    if (int.TryParse(FLDVALUE, out valueParsed) == false) { TYPEMSG = " should be Numeric Value ! "; functionReturnValue = false; return functionReturnValue; }
                if (Convert.ToInt32(FLDVALUE) > Convert.ToInt32(DATATYPES[0])) { TYPEMSG = " must be less than " + DATATYPES[0]; functionReturnValue = false; return functionReturnValue; }
            }
            else if (DB_FLDTYPE.ToUpper() == "INT")
            {
                if (!string.IsNullOrEmpty(FLDVALUE.Trim()))
                    if (int.TryParse(FLDVALUE, out valueParsed) == false) { TYPEMSG = " should be Numeric Value ! "; functionReturnValue = false; return functionReturnValue; }
                if (Convert.ToInt32(FLDVALUE) > Convert.ToInt32(DATATYPES[1])) { TYPEMSG = " must be less than " + DATATYPES[1]; functionReturnValue = false; return functionReturnValue; }
            }
            else if (DB_FLDTYPE.ToUpper() == "BIGNINT")
            {
                if (!string.IsNullOrEmpty(FLDVALUE.Trim()))
                    if (int.TryParse(FLDVALUE, out valueParsed) == false) { TYPEMSG = " should be Numeric Value ! "; functionReturnValue = false; return functionReturnValue; }
                if (Convert.ToInt32(DB_FLDTYPE) > Convert.ToInt32(DATATYPES[2])) { TYPEMSG = " must be less than " + DATATYPES[2]; functionReturnValue = false; return functionReturnValue; }
            }
            else if (DB_FLDTYPE.ToUpper() == "TINYINT")
            {
                if (!string.IsNullOrEmpty(FLDVALUE.Trim()))
                    if (int.TryParse(FLDVALUE, out valueParsed) == false) { TYPEMSG = " should be Numeric Value ! "; functionReturnValue = false; return functionReturnValue; }
                if (Convert.ToInt32(FLDVALUE) > Convert.ToInt32(DATATYPES[3])) { TYPEMSG = " must be less than " + DATATYPES[3]; functionReturnValue = false; return functionReturnValue; }
            }
            else if (DB_FLDTYPE.ToUpper() == "VARCHAR" | DB_FLDTYPE.ToUpper() == "NVARCHAR" | DB_FLDTYPE.ToUpper() == "CHAR")
            {
                if (FLDVALUE.Length > DB_FLDPREC) { TYPEMSG = " must be less than " + DB_FLDPREC + 1 + " Characters !"; functionReturnValue = false; return functionReturnValue; }
            }
            else if (DB_FLDTYPE.ToUpper() == "NUMERIC")
            {
                if (!string.IsNullOrEmpty(FLDVALUE.Trim()))
                    if (int.TryParse(FLDVALUE, out valueParsed) == false) { TYPEMSG = " should be Numeric Value ! "; functionReturnValue = false; return functionReturnValue; }
                if (Convert.ToInt32(FLDVALUE) > Convert.ToInt32(NINES.Substring(0, DB_FLDPREC - DB_FLDSCALE))) { TYPEMSG = " must be less than " + NINES.Substring(0, DB_FLDPREC - DB_FLDSCALE) + "." + NINES.Substring(0, DB_FLDSCALE); functionReturnValue = false; return functionReturnValue; }
            }
            TYPEMSG = "";
            return functionReturnValue;
        }

        public bool FindFrm(string frmName, string frmTag = "")
        {
            bool functionReturnValue = false;

            // ERROR: Not supported in C#: OnErrorStatement

            functionReturnValue = false;
            int i = 0;

            for (i = 1; i <= ShwFrm.GetUpperBound(ShwFrm.Length); i++)
            {
                if (ShwFrm[i].FrmName.ToUpper() == frmName.ToUpper())
                {
                    if (ShwFrm[i].frmTag.ToUpper() != frmTag.ToUpper())
                    {
                        if (ShwFrm[i].ObjFrm.SAVEFLAG == true & TFLAG == false)
                        {
                            SAVED = true;
                            RFLAG = false;
                            //objFrmMdiMain.Image1.SendToBack();
                            ShwFrm[i].ObjFrm.BringToFront();
                            ch = MessageBox.Show("Do You Want To Save ?", MsgboxCaption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                            if (ch == DialogResult.Yes)
                            {
                                ShwFrm[i].ObjFrm.CmdSave_Click(ShwFrm[i].ObjFrm, new System.EventArgs());
                                if (!SAVED)
                                {
                                    //objFrmMdiMain.Image1.SendToBack();
                                    ShwFrm[i].ObjFrm.BringToFront();
                                    return functionReturnValue;
                                }
                            }
                            else if (ch == DialogResult.Cancel)
                            {
                                CANFLG = true;
                                return functionReturnValue;
                            }
                            else if (ch == DialogResult.No)
                            {
                                return functionReturnValue;
                            }
                        }

                        ShwFrm[i].ObjFrm.Close();
                        ShwFrm[i].ObjFrm = null;
                        ShwFrm[i].ObjFrm.Dispose();
                        if (FrmNo > 1)
                            FrmNo = FrmNo - 1;
                        functionReturnValue = true;
                        break; // TODO: might not be correct. Was : Exit For
                    }
                    else
                    {
                        CurFrmNo = i;
                        return functionReturnValue;
                    }
                }
            }
            if (functionReturnValue)
            {
                if (FrmNo == ShwFrm.GetUpperBound(ShwFrm.Length) & i == ShwFrm.GetUpperBound(ShwFrm.Length))
                {
                    Array.Resize(ref ShwFrm, FrmNo);
                }
                else if (i < ShwFrm.GetUpperBound(ShwFrm.Length))
                {
                    for (int j = i; j <= ShwFrm.GetUpperBound(ShwFrm.Length) - 1; j++)
                    {
                        ShwFrm[j].ObjFrm = ShwFrm[j + 1].ObjFrm;
                        ShwFrm[j].FrmName = ShwFrm[j + 1].FrmName;
                    }
                    Array.Resize(ref ShwFrm, FrmNo);
                }
            }
            return functionReturnValue;
        }

        public void CHKVALID(string S1, ref object S2)
        {
            if (S1 == "SKUMAR")
            {
                NOTOK = false;
                Fso = new System.Object();
                if (Convert.ToInt32(S2) != 0)
                    LGM = S2;
            }
            else
            {
                NOTOK = true;
                Fso = null;
            }

        }

        private void ACCESSDENIED()
        {
            MessageBox.Show("You do not have rights to access this method !", MsgboxCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }

        private void Class1_Initialize()
        {
            NOTOK = true;
            RD = "0";

        }

        public void SetKeyValue(long key_root, string key_name, string subkey_name, string Value)
        {
            long hKey = 0;
            long length = 0;
            long value_type = 0;

            //Dim key_num As Integer

            // open the key


            if (RegOpenKeyEx(key_root, key_name, 0L, KEY_QUERY_VALUE, hKey) != ERROR_SUCCESS)
            {
                return;

            }
            length = Value.Length;
            value_type = 1;
            if (RegSetValueEx(hKey, subkey_name, 0, value_type, Value, length) != ERROR_SUCCESS)
            {
                return;
            }
            RegCloseKey(hKey);
        }
        public bool DESTRUCT()
        {
            bool functionReturnValue = false;

            functionReturnValue = false;
            if (NOTOK) { ACCESSDENIED(); return functionReturnValue; }
            if (!string.IsNullOrEmpty(SELECTEDLOCATION))
            {
                for (I = 0; I <= LOCS.GetUpperBound(LOCS.Length); I++)
                {
                    if (LOCS[I].LOCATION == SELECTEDLOCATION)
                    {
                        if (LOCS[I].DSN == "OledbFR")
                        {
                        }
                        else
                        {
                            for (J = 0; J <= LOCS.GetUpperBound(LOCS.Length); J++)
                            {
                                if (LOCS[J].DSN == "OledbFR")
                                {
                                    subkey_name = LOCS[J].DSN;
                                    REPLACESERVER = LOCS[J].SERVERNAME;
                                    SetKeyValue(HKEY_LOCAL_MACHINE, "Software\\ODBC\\ODBC.INI\\" + subkey_name, "Server", REPLACESERVER);
                                    break; // TODO: might not be correct. Was : Exit For
                                }
                            }
                        }
                        break; // TODO: might not be correct. Was : Exit For
                    }
                }
            }
            functionReturnValue = true;
            return functionReturnValue;

        }
        //public bool CHKSEC(object S1, object S2, ref string[] SS)
        //{
        //    bool functionReturnValue = false;
        //    string[] TT = null;
        //    functionReturnValue = false;
        //    if (NOTOK) { ACCESSDENIED(); return functionReturnValue; }
        //    dynamic FLD2 = null;
        //    dynamic FLD3 = null;
        //    dynamic FLD5 = null;
        //    FLD2 = S1;
        //    FLD3 = S2;
        //    REC = null;
        //    // REC.Open("SELECT * FROM SECURITY WHERE FLD2 = '" & FLD2 & "' AND FLD3 = '" & FLD3 & "'", DB, adOpenDynamic, adLockOptimistic)

        //    ostr = "SELECT * FROM SECURITY WHERE FLD2 = '" + FLD2 + "' AND FLD3 = '" + FLD3 + "'";
        //    OleDbConnection DB2 = default(OleDbConnection);
        //    DataSet ds1 = new DataSet();
        //    DB2 = LGM.DB;
        //    OledbAdp = new OleDbDataAdapter(ostr, DB2);
        //    OledbAdp.Fill(ds1, "SECURITY");
        //    DB2 = null;
        //    for (I = 0; I <= Information.UBound(SS); I++)
        //    {
        //        TT = Strings.Split(SS[I], "|");
        //        if (I == 0)
        //            FRMRIGHTS = TT[3];
        //        if (TT[4] != "NULL")
        //            FLD5 = SETPASS(Convert.ToString(TT[4]));
        //        else
        //            FLD5 = "";
        //        //  REC.Find("FLD5='" & FLD5 & "'")
        //        if (ds1.Tables[0].Rows.Count == 0)
        //        {
        //            ostr = "insert into SECURITY values('" + TT[0] + "','" + FLD2 + "','" + FLD3 + "','" + SETPASS(Convert.ToString(TT[3])) + "','" + FLD5 + "')";
        //            OledbCMD = new OleDbCommand(ostr, LGM.db);
        //            OledbCMD.ExecuteNonQuery();
        //        }
        //        else
        //        {
        //            if (!Information.IsDBNull(ds1.Tables[0].Rows[0][3].ToString()))
        //            {
        //                if (ds1.Tables[0].Rows[0][3].ToString() != SETPASS(Convert.ToString(TT[3])) | ds1.Tables[0].Rows[0][0].ToString() != TT[0])
        //                {
        //                    ostr = "Update security set FLD1='" + TT[0] + "',FLD4='" + SETPASS(Convert.ToString(TT[3])) + "' WHERE FLD2 = '" + FLD2 + "' AND FLD3 = '" + FLD3 + "' ";
        //                    OledbCMD = new OleDbCommand(ostr, LGM.DB);
        //                    OledbCMD.ExecuteNonQuery();

        //                }
        //            }
        //            else
        //            {
        //                ostr = "Update security set FLD1='" + TT[0] + "',FLD4='" + SETPASS(Convert.ToString(TT[3])) + "' WHERE FLD2 = '" + FLD2 + "' AND FLD3 = '" + FLD3 + "' ";
        //                OledbCMD = new OleDbCommand(ostr, LGM.DB);
        //                OledbCMD.ExecuteNonQuery();

        //            }
        //        }
        //    }

        //    functionReturnValue = true;
        //    return functionReturnValue;


        //}

        public bool GETUSRLST(ref int S1, ref string S2, byte S3 = 0)
        {
            bool functionReturnValue = false;

            functionReturnValue = false;
            if (NOTOK) { ACCESSDENIED(); return functionReturnValue; }
            //If S3 <> 0 Then CALLBYSETTING = S3
            CALLBYSETTING = S3;
            if (ISITLITE)
            {
                Uid = 1;
                USRNAME = "Lite Version";
                ISITOK = true;
            }
            else
            {
                LOADED = false;
                ISITOK = false;
                FrmUser Frm = new FrmUser();
                Frm.ShowDialog();

                //'Do Until LOADED
                //'    '' DoEvents()
                //'Loop
            }
            S1 = Uid;
            S2 = USRNAME;
            // Dim D As Date
            // D = CDate(APPDATE)
            //  MM = Month(D)
            try
            {
                MM = Convert.ToDateTime(APPDATE).Month.ToString();

            }
            catch (Exception ex)
            {
            }


            if (Convert.ToInt32(MM) >= 1 & Convert.ToInt32(MM) <= 9)
            {
                YY = Convert.ToDateTime(APPDATE).Year.ToString();
            }
            else
            {
                YY = Convert.ToDateTime(APPDATE).Year.ToString();
            }
            string s = "";
            s = @"01/04/" + YY;
            PERIOD = Convert.ToDateTime(s).ToString("dd/MM/yyyy");
            functionReturnValue = ISITOK;
            return functionReturnValue;

        }

        public void GCD(ref string S1, ref string S2, ref string S3, ref string S4, ref string S5, ref string S6)
        {
            if (NOTOK)
            {
                ACCESSDENIED(); return;
            }
            //If COMPANY_NAME = "TRANSOCEAN FREIGHT SERVICES Pvt Ltd" Then
            //    RESTRICT = False
            //Else
            //    RESTRICT = True
            //End If
            FrmSCompany OBJFrmSCompany = new FrmSCompany();
            OBJFrmSCompany.Show();

            //DSet = New DataSet()
            //OledbDA = New OleDbDataAdapter("SELECT CMPID,CNAME,ADD1,ADD2,CITY,PH,FAX,EMAIL,CURRNM,CURSYM,CURCD,CURPAISE,REGCODE FROM FBILL_COMPANY_MASTER WHERE CMPID=" & CMPID, OledbCon)
            //OledbDA.Fill(DSet)
            //CMPID = Convert.ToInt32(DSet.Tables(0).Rows(0)("CMPID"))
            //COMPANY_NAME = Convert.ToString(DSet.Tables(0).Rows(0)("CNAME"))
            //ADDRESS = Convert.ToString(DSet.Tables(0).Rows(0)("ADD1")) & " " & Convert.ToString(DSet.Tables(0).Rows(0)("ADD2")) & " " & Convert.ToString(DSet.Tables(0).Rows(0)("CITY"))
            //PH = Convert.ToString(DSet.Tables(0).Rows(0)("PH"))
            //FAX = Convert.ToString(DSet.Tables(0).Rows(0)("FAX"))
            //EMAIL = Convert.ToString(DSet.Tables(0).Rows(0)("EMAIL"))
            //CURRENCY_NAME = Convert.ToString(DSet.Tables(0).Rows(0)("CURRNM"))
            //CURRENCY_SYMBOL = Convert.ToString(DSet.Tables(0).Rows(0)("CURSYM"))
            //CURRENCY_CODE = Convert.ToString(DSet.Tables(0).Rows(0)("CURCD"))
            //CURRENCY_PAISE = Convert.ToString(DSet.Tables(0).Rows(0)("CURPAISE"))
            //REGCODE = Convert.ToString(DSet.Tables(0).Rows(0)("REGCODE"))
            //intialisation for variables used for amt to text
            ones[1] = " One ";
            ones[2] = " Two ";
            ones[3] = " Three ";
            ones[4] = " Four ";
            ones[5] = " Five ";
            ones[6] = " Six ";
            ones[7] = " Seven ";
            ones[8] = " Eight ";
            ones[9] = " Nine ";

            abones[1] = " Eleven ";
            abones[2] = " Twelve ";
            abones[3] = " Thirteen ";
            abones[4] = " Fourteen ";
            abones[5] = " Fifteen ";
            abones[6] = " Sixteen ";
            abones[7] = " Seventeen ";
            abones[8] = " Eighteen ";
            abones[9] = " Nineteen ";

            tens[1] = " Ten ";
            tens[2] = " Twenty ";
            tens[3] = " Thirty ";
            tens[4] = " Forty ";
            tens[5] = " Fifty ";
            tens[6] = " Sixty ";
            tens[7] = " Seventy ";
            tens[8] = " Eighty ";
            tens[9] = " Ninty ";

            ext[1] = " Hundred ";
            ext[2] = " Thousand ";
            ext[3] = " Lakh ";
            ext[4] = " Crore ";

            cons[1] = " and ";
            cons[2] = ICase(CURRENCY_PAISE).ToString();
            //" Sents " '" Paise "
            cons[3] = " Only ";
            cons[4] = "";
            //Rupees

        }

        //private string CHKAFRM(string FRM)
        //{
        //    string functionReturnValue = null;

        //    functionReturnValue = "";
        //    if (NOTOK) { ACCESSDENIED(); return functionReturnValue; }
        //    if (ISITLITE)
        //    {
        //        functionReturnValue = FRMRIGHTS;
        //        return functionReturnValue;
        //    }
        //    if (string.IsNullOrEmpty(Strings.Trim(FRM)))
        //        return functionReturnValue;
        //    string GETFRM = "";
        //    int POS = 0;

        //    try
        //    {
        //        GETFRM = DATACHK("SELECT FORMS FROM USRDTL WHERE USRID=" + Uid + " AND CMPID=" + CMPID, true);
        //    }
        //    catch (Exception ex)
        //    {
        //        Interaction.MsgBox(ex.Message);
        //    }
        //    if (string.IsNullOrEmpty(GETFRM))
        //        GETFRM = DATACHK("SELECT G.FORMS FROM GROUPS G, USRMGR U WHERE G.GROUPID = U.GROUPID AND U.USRID = " + Uid, true);

        //    if (!string.IsNullOrEmpty(Strings.Trim(GETFRM)))
        //    {
        //        POS = Strings.InStr(1, GETFRM, FRM, Constants.vbTextCompare);
        //        if (!(POS == 0))
        //        {
        //            GETFRM = Strings.Mid(GETFRM, POS);
        //            GETFRM = Strings.Mid(GETFRM, 1, Strings.InStr(1, GETFRM, "@", Constants.vbTextCompare) - 1);
        //            RR = Strings.Split(GETFRM, "~");
        //            for (I = 0; I <= Information.UBound(RR); I++)
        //            {
        //                if (Strings.InStr(RR[I], FRM) == 1)
        //                {
        //                    RT = Strings.Mid(RR[I], Strings.InStr(1, RR[I], FRM) + Strings.Len(FRM) + 1);
        //                    break; // TODO: might not be correct. Was : Exit For
        //                }
        //            }
        //            functionReturnValue = RT;
        //        }
        //    }
        //    return functionReturnValue;

        //}
       
        public string SETPASS(string PWD)
        {
            string functionReturnValue = null;

            functionReturnValue = "";
            if (NOTOK) { ACCESSDENIED(); return functionReturnValue; }
            string SECPASS = null;
            string SKEY = null;
            int LSKEY = 0;
            int N = 0;
            int M = 0;
            int K = 0;
            SKEY = "SKUMAR";
            LSKEY = SKEY.Length;
            SECPASS = "";
            N = 1;
            K = PWD.Length;
            for (M = 1; M <= K; M++)
            {
                SECPASS = SECPASS + Strings.Chr(Strings.Asc(Strings.Mid(PWD, M, 1)) + Strings.Asc(Strings.Mid(SKEY, N, 1)));
                N = N + 1;
                if (N > LSKEY)
                    N = 1;
            }
            functionReturnValue = SECPASS;
            return functionReturnValue;

        }
        public string GETPASS(string PWD)
        {
            string functionReturnValue = null;

            functionReturnValue = "";
            if (NOTOK) { ACCESSDENIED(); return functionReturnValue; }
            string SECPASS = null;
            string SKEY = null;
            int LSKEY = 0;
            int N = 0;
            int M = 0;
            int K = 0;
            SKEY = "SKUMAR";
            LSKEY = Strings.Len(SKEY);
            SECPASS = "";
            N = 1;
            K = Strings.Len(PWD);
            for (M = 1; M <= K; M++)
            {
                SECPASS = SECPASS + Strings.Chr(Strings.Asc(Strings.Mid(PWD, M, 1)) - Strings.Asc(Strings.Mid(SKEY, N, 1)));
                N = N + 1;
                if (N > LSKEY)
                    N = 1;
            }
            functionReturnValue = SECPASS;
            return functionReturnValue;
        }
        public object SPLITSTR(object STRVAL, byte NOCHR)
        {
            string RESULT = null;
            RESULT = "";
            for (int I = 1; I <= Strings.Len(STRVAL); I++)
            {
                RESULT = RESULT + Strings.Mid(STRVAL.ToString(), I, 1) + Strings.Space(NOCHR);
            }
            return Strings.Trim(RESULT);
        }
       public bool CONTVALID(string S1, string S2, ref object S3)
        {
            bool functionReturnValue = false;

            functionReturnValue = false;
            if (NOTOK) { ACCESSDENIED(); return functionReturnValue; }
            int[] NAMEVAL = new int[26];
            dynamic TOTVAL = null;
            dynamic K = null;
            dynamic I = null;
            dynamic LASTVAL = null;
            dynamic JJ = null;
            TOTVAL = 0;
            K = 0;
            JJ = 10;
            for (I = 0; I <= Information.UBound(NAMEVAL); I++)
            {
                NAMEVAL[I] = JJ;
                JJ = JJ + 1;
                if (JJ % 11 == 0)
                    JJ = JJ + 1;
            }
            S1 = Strings.Trim(S1);
            S2 = Strings.Replace(Strings.Trim(S2), "-", "");
            for (I = 1; I <= 4; I++)
            {
                TOTVAL = TOTVAL + NAMEVAL[Strings.Asc(Strings.Mid(S1, I, 1)) - 65] * (Math.Pow(2, K));
                K = K + 1;
            }
            for (I = 1; I <= 6; I++)
            {
                TOTVAL = TOTVAL + Conversion.Val(Strings.Mid(S2, I, 1)) * (Math.Pow(2, K));
                K = K + 1;
            }
            LASTVAL = TOTVAL % 11;
            if (LASTVAL == 10)
                LASTVAL = 0;
            S3 = Strings.Trim(LASTVAL);
            if (LASTVAL == Conversion.Val(Strings.Trim(Strings.Right(S2, 1))))
                functionReturnValue = true;
            return functionReturnValue;

        }
        public string ENSTR(string FSTR)
        {
            string functionReturnValue = null;
            functionReturnValue = "";
            if (NOTOK)
            {
                ACCESSDENIED();
                return functionReturnValue;
            }

            byte[] RCHR = null;
            byte rc = 0;
            byte EXIST = 0;
            string RSTR = null;
            RCHR = new byte[Strings.Len(FSTR) + 1];
            RSTR = "";
            for (I = 1; I <= Strings.Len(FSTR); I++)
            {
                do
                {
                    EXIST = 0;
                    VBMath.Randomize();
                    rc = Convert.ToByte(VBMath.Rnd() * (255 - Strings.Asc(Strings.Mid(FSTR, I, 1))));
                    for (J = 1; J <= Information.UBound(RCHR); J++)
                    {
                        if (RCHR[J] == rc)
                        {
                            EXIST = 1;
                            break; // TODO: might not be correct. Was : Exit For
                        }
                    }
                } while (EXIST == 1);
                RSTR = RSTR + Strings.Chr(rc) + Strings.Chr(Strings.Asc(Strings.Mid(FSTR, I, 1)) + rc);
                RCHR[I] = rc;
            }
            functionReturnValue = RSTR;
            return functionReturnValue;

        }
        public string DESTR(string FSTR)
        {
            string functionReturnValue = null;
            functionReturnValue = "";
            if (NOTOK) { ACCESSDENIED(); return functionReturnValue; }
            string RSTR = "0";
            byte rc = 0;
            for (I = 1; I <= Strings.Len(FSTR); I += 2)
            {
                rc = Convert.ToByte(Strings.Asc(Strings.Mid(FSTR, I, 1)));
                RSTR = Convert.ToString(RSTR + Strings.Chr(Strings.Asc(Strings.Mid(FSTR, I + 1, 1)) - rc));
            }
            functionReturnValue = RSTR;
            return functionReturnValue;

        }
        public string SETRCD(string A)
        {
            string functionReturnValue = null;
            //set reg code
            functionReturnValue = "";
            if (NOTOK) { ACCESSDENIED(); return functionReturnValue; }
            for (I = 1; I <= Strings.Len(A); I++)
            {
                SCODE = SCODE + Strings.Trim(Strings.Mid(A, I, 1));
            }
            dynamic LL = null;
            dynamic ESTR = null;
            string FSTR = "0";
            ESTR = "SKUMAR";
            LL = Strings.Len(ESTR);
            J = 1;
            for (I = 1; I <= Strings.Len(SCODE); I++)
            {
                FSTR = FSTR + Strings.Chr(Strings.Asc(Strings.Mid(SCODE, I, 1)) + Strings.Asc(Strings.Mid(ESTR, J, 1)));
                J = J + 1;
                if (J > LL)
                    J = 1;
            }
            SCODE = FSTR;
            FSTR = "";
            for (I = 1; I <= Strings.Len(SCODE); I++)
            {
                FSTR = FSTR + Conversion.Hex(Strings.Asc(Strings.Mid(SCODE, I, 1)));
            }
            functionReturnValue = FSTR;
            return functionReturnValue;

        }
        public string GETRCD(string A)
        {
            string functionReturnValue = null;
            //get reg code
            functionReturnValue = "";
            if (NOTOK)
            {
                ACCESSDENIED();
                return functionReturnValue;
            }

            for (int I = 1; I <= Strings.Len(A); I += 2)
            {
                SCODE = SCODE + Strings.Chr(Convert.ToInt32("&H" + Strings.Mid(A, I, 2)));
            }
            string FSTR = "0";
            dynamic LL = null;
            dynamic ESTR = null;
            string[] AA = null;
            ESTR = "SKUMAR";
            LL = Strings.Len(ESTR);
            J = 1;
            for (I = 1; I <= Strings.Len(SCODE); I++)
            {
                FSTR = FSTR + Strings.Chr(Strings.Asc(Strings.Mid(SCODE, I, 1)) - Strings.Asc(Strings.Mid(ESTR, J, 1)));
                J = J + 1;
                if (J > LL)
                    J = 1;
            }
            A = FSTR;
            SCODE = "";
            AA = Strings.Split(FSTR, "-");
            for (I = 1; I <= Information.UBound(AA); I++)
            {
                SCODE = SCODE + Strings.Trim(("-" + AA[I]));
            }
            //For I = 1 To Len(A) Step 2
            //    Scode = Scode + Trim(Not Mid(A, I, 2))
            //Next
            functionReturnValue = SCODE;
            return functionReturnValue;
        }
        public DataSet ImportExcelXLS(string FileName, string hasHeaders)
        {
            System.Data.OleDb.OleDbConnection MyConnection = null;
            System.Data.DataSet DtSet = null;
            System.Data.OleDb.OleDbDataAdapter MyCommand = null;
            try
            {
                MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + FileName + ";Extended Properties=Excel 8.0;");
                MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Table1$]", MyConnection);
                MyCommand.TableMappings.Add("Table", "TestTable");
                DtSet = new System.Data.DataSet();
                MyCommand.Fill(DtSet);
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
            }
            return DtSet;
        }
        public void ExportDatasetToExcel(DataSet ds, string strExcelFile)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strExcelFile + ";Extended Properties=Excel 8.0;");
            conn.Open();
            string[] strTableQ = new string[ds.Tables.Count + 1];
            int i = 0;
            //making table query
            for (i = 0; i <= ds.Tables.Count - 1; i++)
            {
                strTableQ[i] = "CREATE TABLE [" + ds.Tables[i].TableName + "](";
                int j = 0;
                for (j = 0; j <= ds.Tables[i].Columns.Count - 1; j++)
                {
                    DataColumn dCol = null;
                    dCol = ds.Tables[i].Columns[j];
                    strTableQ[i] += " [" + dCol.ColumnName + "] varchar(255) , ";
                }
                strTableQ[i] = strTableQ[i].Substring(0, strTableQ[i].Length - 2);
                strTableQ[i] += ")";
                OleDbCommand cmd = new OleDbCommand(strTableQ[i], conn);
                cmd.ExecuteNonQuery();
            }
            //making insert query
            string[] strInsertQ = new string[ds.Tables.Count];
            for (i = 0; i <= ds.Tables.Count - 1; i++)
            {
                strInsertQ[i] = "Insert Into " + ds.Tables[i].TableName + " Values (";
                for (int k = 0; k <= ds.Tables[i].Columns.Count - 1; k++)
                {
                    strInsertQ[i] += "@" + ds.Tables[i].Columns[k].ColumnName + " , ";
                }
                strInsertQ[i] = strInsertQ[i].Substring(0, strInsertQ[i].Length - 2);
                strInsertQ[i] += ")";
            }
            //Now inserting data
            for (i = 0; i <= ds.Tables.Count - 1; i++)
            {
                for (int j = 0; j <= ds.Tables[i].Rows.Count - 1; j++)
                {
                    OleDbCommand cmd = new OleDbCommand(strInsertQ[i], conn);
                    for (int k = 0; k <= ds.Tables[i].Columns.Count - 1; k++)
                    {
                        cmd.Parameters.AddWithValue("@" + ds.Tables[i].Columns[k].ColumnName.ToString(), ds.Tables[i].Rows[j][k].ToString());
                    }
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
            }
            conn.Close();
        }
        public object ICase(object STRVAL)
        {
            object functionReturnValue = null;
            //INIT CASE

            functionReturnValue = "";
            if (NOTOK) { ACCESSDENIED(); return functionReturnValue; }
            string C = null;
            //* 1
            int FLG = 0;
            STRVAL = Strings.UCase(Strings.Trim(STRVAL.ToString()));
            FLG = 1;
            for (int I = 2; I <= Strings.Len(STRVAL); I++)
            {
                C = Strings.Mid(STRVAL.ToString(), I, 1);
                if (FLG==1)
                    C = Strings.LCase(C);
                if (C == " ")
                    FLG = 0;
                else
                    FLG = 1;
            }
            functionReturnValue = STRVAL;
            return functionReturnValue;

        }


    }
}
