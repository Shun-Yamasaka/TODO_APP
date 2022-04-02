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
    public partial class Form1 : Form
    {
        //staticで宣言することでインスタンスを固定
        public static DOING_Control doing_ctr;
        public static DONE_Control done_ctr;
        public static ParkingLot_Control park_ctr;
        public static TODO_Control todo_ctr;

        public static MenuControl menu_ctr;


        public Form1()
        {
            InitializeComponent();
            // コントロールをインスタンス化
            doing_ctr = new DOING_Control();
            done_ctr = new DONE_Control();
            park_ctr = new ParkingLot_Control();
            todo_ctr = new TODO_Control();
            menu_ctr = new MenuControl();

            // パネルにコントロールを追加
            panel1.Controls.Add(doing_ctr);
            panel1.Controls.Add(done_ctr);
            panel1.Controls.Add(park_ctr);
            panel1.Controls.Add(todo_ctr);
            panel1.Controls.Add(menu_ctr);

            // doingコントロールのみを見えるようにする
            doing_ctr.Visible = true;
            done_ctr.Visible = false;
            park_ctr.Visible = false;
            todo_ctr.Visible = false;
            menu_ctr.Visible = false;


        }
    }
}
