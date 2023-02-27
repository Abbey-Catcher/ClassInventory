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

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name, team, position;
            int age;

            name = nameInput.Text;
            team = teamInput.Text;
            position = positionInput.Text;
            age = Convert.ToInt32(ageInput.Text);

            Player newPlayer = new Player(name, team, position, age);
            players.Add(newPlayer);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach (Player p in players)
            {
                if (p.name == removeInput.Text)
                {
                    players.Remove(p);
                    break;
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions. 
            //---------------------------

            Player player = players.Find(n => n.name == nameInput.Text);

            outputLabel.Text = "";
            
            outputLabel.Text += player.name;
            //foreach (Player n in player)
            
            //Player p = players.Find(p => p.name == nameInput.Text);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";

            foreach (Player p in players)
            {
                outputLabel.Text += $"{p.name} {p.age} {p.team} {p.position}\n";
            }
        }
    }
}
