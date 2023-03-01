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
    public partial class FindPlayers : Form
    {
        PlayerClass player;
        public FindPlayers()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
            foreach(PlayerClass player_ in Players.Instance.listplayer)
            {
                dataGridView1.Rows.Add(player_.Name, player_.LastName, player_.StudentID, player_.Major, player_.GameName, player_.Email, player_.Phone, player_.Age);
            }
        }
        public PlayerClass GetPlayer()
        {
            return player;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayerClass pp = Players.Instance.listplayer[dataGridView1.CurrentRow.Index];
            player = pp;
            this.DialogResult = DialogResult.OK;
        }
    }
}
