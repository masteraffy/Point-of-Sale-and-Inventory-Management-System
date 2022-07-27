using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Phosclay
{
    class controls
    {
        static bool isMax = false;
        static Point old_loc, default_loc;
        static Size old_size, default_size;

        public static void SetIntial(Form form)
        {
            old_loc = form.Location;
            old_size = form.Size;
            default_loc = form.Location;
            default_size = form.Size;
        }

        static void Maximize(Form form)
        {
            int x = SystemInformation.WorkingArea.Width;
            int y = SystemInformation.WorkingArea.Height;
            form.WindowState = FormWindowState.Normal;
            form.Location = new Point(0, 0);
            form.Size = new Size(x, y);
        }
        public static void DoMaximize(Form form, Button Maxbtn)
        {
            if (isMax == false)
            {
                old_loc = new Point(form.Location.X, form.Location.Y);
                old_size = new Size(form.Size.Width, form.Size.Height);
                Maximize(form);
                isMax = true;
            }
            else
            {
                form.Location = old_loc;
                form.Size = old_size;
                isMax = false;
            }
        }
    }
}
