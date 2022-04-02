using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASKBoard
{
    public partial class DOING_Control : UserControl
    {
        public DOING_Control()
        {
            InitializeComponent();
        }

        private void TODO_Page_Click(object sender, EventArgs e)
        {
            Form1.menu_ctr.Visible = false;
            Form1.park_ctr.Visible = false;
            Form1.todo_ctr.Visible = true;
            Form1.doing_ctr.Visible = false;
            Form1.done_ctr.Visible = false;
        }

        private void Menu_Page_Click(object sender, EventArgs e)
        {
            Form1.menu_ctr.Visible = true;
            Form1.park_ctr.Visible = false;
            Form1.todo_ctr.Visible = false;
            Form1.doing_ctr.Visible = false;
            Form1.done_ctr.Visible = false;
        }

        private void DONE_Page_Click(object sender, EventArgs e)
        {
            Form1.menu_ctr.Visible = false;
            Form1.park_ctr.Visible = false;
            Form1.todo_ctr.Visible = false;
            Form1.doing_ctr.Visible = false;
            Form1.done_ctr.Visible = true;
        }
    }
}
