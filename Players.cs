using KKU_eSport_Simple.Class;
using Newtonsoft.Json;

namespace KKU_eSport_Simple
{
    public partial class Players : Form
    {
        public static Players Instance;
        public List<PlayerClass> listplayer = new List<PlayerClass>();
        public Players()
        {
            InitializeComponent();
            Instance = this;
        }

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player_Register pr = new Player_Register();
            pr.ShowDialog();
            if(pr.DialogResult == DialogResult.OK)
            {
                listplayer.Add(pr.getPlayer());
                RefreshDataGrid();
            }
        }
        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();
            foreach(PlayerClass player_ in listplayer)
            {
                dataGridView1.Rows.Add(player_.Name, player_.LastName, player_.StudentID, player_.Major, player_.GameName, player_.Email, player_.Phone, player_.Age);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Players";
            savefile.Filter = "Json|*.json";
            savefile.ShowDialog();
            if(savefile.FileName != "")
            {
                string json = JsonConvert.SerializeObject(listplayer, Formatting.Indented);
                File.WriteAllText(savefile.FileName, json);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.FileName = "Players";
            openfile.Filter = "Json|*.json";
            openfile.ShowDialog();
            if(openfile.FileName != "")
            {
                listplayer = JsonConvert.DeserializeObject<List<PlayerClass>>(File.ReadAllText(openfile.FileName));
                RefreshDataGrid();
            }
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teams tm = new Teams();
            tm.ShowDialog();
        }
    }
}