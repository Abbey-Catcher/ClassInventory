using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassInventory
{
    public partial class Form1 : Form
    {
        // Global Variabales go here
        List<Player> players = new List<Player>();
        //List<age> Age = new List<age>(new int[]);

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name, team, position;
            int age = Convert.ToInt32(ageInput.Text);

            name = nameInput.Text;
            team = teamInput.Text;
            position = positionInput.Text;

            Player newPlayer = new Player(name, age, team, position);
            newPlayer.name = name;

            displayPlayers();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach (Player p in players)
            {
                if (p.name == nameInput.Text)
                {
                    players.Remove(p);
                }
            }

            displayPlayers();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions. 
            //---------------------------

        }

        private void showButton_Click(object sender, EventArgs e)
        {

        }

        private void displayPlayers()
        {
            outputLabel.Text = "";

            foreach (Player p in players)
            {
                outputLabel.Text += $"{p.name} {p.age} {p.team} {p.position}\n";
            }
        }
    }
}
