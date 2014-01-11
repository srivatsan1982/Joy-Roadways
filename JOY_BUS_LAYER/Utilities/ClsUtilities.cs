using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using Microsoft.VisualBasic;
namespace JOY_BUS_LAYER.Utilities
{
    public sealed class ClsUtilities : IDisposable
    {
        #region [Variables]
        private string SCODE;
        private int J;
        private string GroupbyColumns;
        static string Content;
        #endregion

        public static void PaintControl(Control cntrl)
        {
            Pen mypen = new Pen(Color.White, 1);
            cntrl.CreateGraphics().DrawLine(mypen, 0, 0, 0, cntrl.Height);
            cntrl.CreateGraphics().DrawLine(mypen, 0, 0, cntrl.Width, 0);
            mypen = new Pen(Color.Black, 3);
            cntrl.CreateGraphics().DrawLine(mypen, cntrl.Width, 0, cntrl.Width, cntrl.Height);
            cntrl.CreateGraphics().DrawLine(mypen, 0, cntrl.Height, cntrl.Width, cntrl.Height);
        }

        public static string GETPASS(string PWD)
        {
            string functionReturnValue = null;

            functionReturnValue = "";
            string SECPASS = null;
            string SKEY = null;
            int LSKEY = 0;
            int N = 0;
            int M = 0;
            int K = 0;
            SKEY = "MAHI";
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

        public static string SETPASS(string PWD)
        {
            string functionReturnValue = null;

            functionReturnValue = "";
            string SECPASS = null;
            string SKEY = null;
            int LSKEY = 0;
            int N = 0;
            int M = 0;
            int K = 0;
            SKEY = "MAHI";
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
        public static string FunPubGetFileContents(string File_name)
        {
            try
            {
                using (StreamReader reader = new StreamReader(File_name))
                {
                    Content = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Content;
        }
        public void Dispose()
        {

        }
    }
}
