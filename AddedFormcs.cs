using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_AWzorek_167366
{
    public partial class AddedFormcs : Form
    {
        public AddedFormcs()
        {
            InitializeComponent();

        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Inp_name.Text = "";
            this.Inp_desc.Text = "";
            this.Close();
        }

        private void Inp_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_add_Click(object sender, EventArgs e)
        {

            if (this.Inp_name.Text == "")
            {
                MessageBox.Show("Proszę wpisać nazwę nawyku", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            


            // show info message
            MessageBox.Show("Dodano nowy nawyk: " + this.Inp_name.Text + "\nOpis: " + this.Inp_desc.Text, "Dodano nowy nawyk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Habit newHabit = new Habit(this.Inp_name.Text, this.Inp_desc.Text);
            Program.HabitList.AddHabit(newHabit);

            Program.HabitList.WriteToFile();

            // clear inputs
            this.Inp_name.Text = "";
            this.Inp_desc.Text = "";

            // close form
            this.Close();

        }
    }
}
