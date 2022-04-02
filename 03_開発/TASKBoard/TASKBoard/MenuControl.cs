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
    public partial class MenuControl : UserControl
    {
        public MenuControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ParkingLot_Controlを表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Parking_Page_Click(object sender, EventArgs e)
        {
            Form1.menu_ctr.Visible = false;
            Form1.park_ctr.Visible = true;
            Form1.todo_ctr.Visible = false;
            Form1.doing_ctr.Visible = false;
            Form1.done_ctr.Visible = false;
        }

        /// <summary>
        /// TODO_Controlを表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TODO_Page_Click(object sender, EventArgs e)
        {
            Form1.menu_ctr.Visible = false;
            Form1.park_ctr.Visible = false;
            Form1.todo_ctr.Visible = true;
            Form1.doing_ctr.Visible = false;
            Form1.done_ctr.Visible = false;
        }

        /// <summary>
        /// DOING_Controlを表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DOING_Page_Click(object sender, EventArgs e)
        {
            Form1.menu_ctr.Visible = false;
            Form1.park_ctr.Visible = false;
            Form1.todo_ctr.Visible = false;
            Form1.doing_ctr.Visible = true;
            Form1.done_ctr.Visible = false;
        }

        /// <summary>
        /// DONE_Controlを表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
