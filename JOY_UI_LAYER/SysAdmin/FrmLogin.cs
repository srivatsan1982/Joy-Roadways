using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JOY_BUS_LAYER.Utilities;
namespace JOY_UI_LAYER.SysAdmin
{
    public partial class FrmLogin :  ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

            ClsCommonVariables.UIlogger.Info("FrmLogin-Form Load Event");
        }
    }
}
