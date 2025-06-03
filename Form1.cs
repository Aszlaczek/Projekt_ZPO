using System.Runtime.Serialization.Json;
using System.Windows.Forms;

namespace Projekt_AWzorek_167366
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // read from the config file and set the default font from confing file

            if (Program.Config != null)
            {
                this.Size = new Size(Program.Config.width, Program.Config.height);
            }
            else
            {
                this.Font = new Font(Program.Config.font, 15.0f);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            AddedFormcs addedFormcs = new AddedFormcs();
            addedFormcs.ShowDialog();
        }
    }

}
