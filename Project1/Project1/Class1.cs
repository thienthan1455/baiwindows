using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    class Class1 : Form
    {
        static void Main()
        {
            //tao form windows
            Class1 form = new Class1();
            form.Text = "Em oi em an gi";

            //tao button
            Button button = new Button();
            button.Text = "Click";
            form.Controls.Add(button);
          

            Application.Run(form);

            //tao button


        }
    }
}
