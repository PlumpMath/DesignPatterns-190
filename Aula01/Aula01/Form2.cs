using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula01
{
    public partial class Form2 : Form
    {
        private static Form2 f_instancia = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public static Form2 Instancia {
          
            get {
                if (f_instancia == null) {
                    f_instancia = new Form2();
                }
                return f_instancia;
            }

        }
    }
}
