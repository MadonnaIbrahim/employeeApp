using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee
{
	public partial class searchDialgueBox : Form
	{
        string id;
        
        public searchDialgueBox()
		{
			InitializeComponent();
		}

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
           Id= textBox1.Text;
        }
    }
}
