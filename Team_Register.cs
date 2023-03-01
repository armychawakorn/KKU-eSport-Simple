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
    public partial class Team_Register : Form ///ทีมที่เป็นหน้าลงทะเบียนทีม
    {
        TeamClass team;
        List<PlayerClass> listplayer = new List<PlayerClass>();
        public Team_Register()
        {
            InitializeComponent();
            for(int i = 0; i < 5; i++)
            {
                PlayerClass player = new PlayerClass();
                player.Name = "";
                player.LastName = "";
                player.StudentID = "";
                player.Major = "";
                player.GameName = "";
                player.Email = "";
                player.Phone = "";
                player.Age = 0;
                listplayer.Add(player);
            }
        }

        private void button6_Click(object sender, EventArgs e) //ปุ่มSubmit
        {
            string TeamName = textBox1.Text;
            team = new TeamClass();
            team.TeamName = TeamName;
            team.Members = this.listplayer;
            this.team = team;
            this.DialogResult = DialogResult.OK;
        }

        private void EventOnClickFind(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.Name == "button1")
            {
                FindPlayer(0, textBox2);
            }
            else if(btn.Name == "button2")
            {
                FindPlayer(1, textBox3);
            }
            else if(btn.Name == "button3")
            {
                FindPlayer(2, textBox4);
            }
            else if(btn.Name == "button4")
            {
                FindPlayer(3, textBox5);
            }
            else if(btn.Name == "button5")
            {
                FindPlayer(4, textBox6);
            }
        }
        private void FindPlayer(int index, TextBox textbox)
        {
            FindPlayers fp = new FindPlayers();
            fp.ShowDialog();
            if(fp.DialogResult == DialogResult.OK)
            {
                listplayer[index] = fp.GetPlayer();
                textbox.Text = listplayer[index].Name;
            }
        }

        public TeamClass getTeam()
        {
            return this.team;
        }
    }
}
