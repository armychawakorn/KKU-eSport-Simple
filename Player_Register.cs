using KKU_eSport_Simple.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KKU_eSport_Simple
{
    public partial class Player_Register : Form
    {
        PlayerClass player;
        public Player_Register()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string LastName = textBox2.Text;
            string StudentID = textBox3.Text;
            string Major = textBox4.Text;
            string GameName = textBox5.Text;
            string Email = textBox6.Text;
            string Phone = textBox7.Text;
            int Age = int.Parse(textBox8.Text);

            player = new PlayerClass()
            {
                Name = Name,
                LastName = LastName,
                StudentID = StudentID,
                Major = Major,
                GameName = GameName,
                Email = Email,
                Phone = Phone,
                Age = Age
            };
            this.DialogResult = DialogResult.OK;
        }
        public PlayerClass getPlayer()
        {
            return player;
        }
    }
}
