using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace JOY_BUS_LAYER.Utilities
{
    public class ClsUtilities:IDisposable
    {
        public void PaintControl(Control cntrl)
        {
            Pen mypen = new Pen(Color.White, 1);
            cntrl.CreateGraphics().DrawLine(mypen, 0, 0, 0, cntrl.Height);
            cntrl.CreateGraphics().DrawLine(mypen, 0, 0, cntrl.Width, 0);
            mypen = new Pen(Color.Black, 3);
            cntrl.CreateGraphics().DrawLine(mypen, cntrl.Width, 0, cntrl.Width, cntrl.Height);
            cntrl.CreateGraphics().DrawLine(mypen, 0, cntrl.Height, cntrl.Width, cntrl.Height);
        }

        public void Dispose()
        {
            
        }
    }
}
