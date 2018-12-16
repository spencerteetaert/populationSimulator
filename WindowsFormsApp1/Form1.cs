using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{ 
    public partial class Form1 : Form
    {
        public static List<double> blueGraphData;
        public static List<double> redGraphData;
        public static List<double> greenGraphData;
        public static List<double> yellowGraphData;
        public static List<double> pinkGraphData;

        int[] populations = new int[6];

        int gridSize = 10, tolerance;
        float cellSize;
        int[,] people;
        int[,] happiness;
        int[] total = new int[6];

        bool play, graphCheck;

        public Form1()
        {
            InitializeComponent();

            cellSize = (float)(500 / gridSizeDial.Value);
            gridSize = (int)gridSizeDial.Value;
            Populate();
            warningLbl.Hide();
        }

        /// <summary>
        /// Checks for every unhappy person, movese them to a random empty cell
        /// </summary>
        private void MovePeople()
        {
            List<Point> unhappyPeople = new List<Point>();

            for (int x = 0; x < gridSize; x++){
                for (int y = 0; y < gridSize; y++){
                    if (happiness[x, y] == 0 && people[x, y] != 0)
                        unhappyPeople.Add(new Point(x, y));
                }
            }

            while (unhappyPeople.Count > 0) {
                Random ran = new Random();
                int i = ran.Next(0, unhappyPeople.Count);
                FindNew(people[unhappyPeople[i].X, unhappyPeople[i].Y]);
                people[unhappyPeople[i].X, unhappyPeople[i].Y] = 0;
                unhappyPeople.Remove(new Point(unhappyPeople[i].X, unhappyPeople[i].Y));
            }
        }

        /// <summary>
        /// Finds empty cells
        /// </summary>
        /// <param name="type"></param>
        private void FindNew(int type)
        {
            Random ran = new Random();

            while (true)
            {
                int x = ran.Next(0, gridSize);
                int y = ran.Next(0, gridSize);
                if (people[x, y] == 0){
                    people[x, y] = type;
                    break;
                }
            }
        }

        /// <summary>
        /// Randomly populates the grid based off the percentages given by the user
        /// </summary>
        private void Populate()
        {
            Form1.blueGraphData = new List<double>();
            Form1.redGraphData = new List<double>();
            Form1.greenGraphData = new List<double>();
            Form1.yellowGraphData = new List<double>();
            Form1.pinkGraphData = new List<double>();

            people = new int[gridSize, gridSize];
            happiness = new int[gridSize, gridSize];

            populations[1] = (int)blueDial.Value;
            populations[2] = populations[1] + (int)redDial.Value;
            populations[3] = populations[2] + (int)greenDial.Value;
            populations[4] = populations[3] + (int)yellowDial.Value;
            populations[5] = populations[4] + (int)pinkDial.Value;
            populations[0] = 0;
            total = new int[6];

            Random rnd = new Random();
            for (int x = 0; x < gridSize; x++){
                for (int y = 0; y < gridSize; y++){
                    people[x, y] = 0;
                    int seed = rnd.Next(100);

                    for (int i = 1; i < populationsDial.Value + 1; i++){
                        if (seed >= populations[i - 1] & seed < populations[i]){
                            people[x, y] = i;
                            total[i] += 1;
                        }
                    }
                }
            }

            CalculateHappiness();
            this.Invalidate();
        }

        /// <summary>
        /// Calculates which people are happy, and what populations are happy
        /// </summary>
        private void CalculateHappiness()
        {
            int[] popHappiness = new int[6];
            int[,] neighbours = new int[gridSize, gridSize];

            tolerance = (int)toleranceBar.Value;

            for (int x = 0; x < gridSize; x++){
                for (int y = 0; y < gridSize; y++){
                    happiness[x, y] = 0;
                    if (people[x, y] == 0) continue;
                        for (int j = x - 1; j <= x + 1; j++){
                            for (int k = y - 1; k <= y + 1; k++){
                                if (j == x && k == y) continue;
                                if (people[(j + gridSize) % gridSize, (k + gridSize) % gridSize] == people[x, y] || people[(j + gridSize) % gridSize, (k + gridSize) % gridSize] == 0)
                                    neighbours[x, y] += 1;
                            }
                        }
                    if (neighbours[x, y] >= 8 - tolerance){
                        happiness[x, y] = people[x, y];
                        popHappiness[people[x, y]] += 1;
                    }
                }
            }
            Form1.blueGraphData.Add(((double)((double)popHappiness[1] / (double)total[1]) * 100));
            Form1.redGraphData.Add(((double)((double)popHappiness[2] / (double)total[2]) * 100));
            Form1.greenGraphData.Add(((double)((double)popHappiness[3] / (double)total[3]) * 100));
            Form1.yellowGraphData.Add(((double)((double)popHappiness[4] / (double)total[4]) * 100));
            Form1.pinkGraphData.Add(((double)((double)popHappiness[5] / (double)total[5]) * 100));
     

            bool flag = true;
            for (int i = 0; i < 6; i++)
            {
                if (((double)((double)popHappiness[i] / (double)total[i]) * 100) != 100 && total[i] > 0)
                    flag = false;
            }
            if (flag == true)
            {
                startStop();
                End();
            }

            blueHappinessLbl.Text = ((double)((double)popHappiness[1] / (double)total[1]) * 100).ToString("0.0") + "%";
            redHappinessLbl.Text = ((double)((double)popHappiness[2] / (double)total[2]) * 100).ToString("0.0") + "%";
            greenHappinessLbl.Text = ((double)((double)popHappiness[3] / (double)total[3]) * 100).ToString("0.0") + "%";
            yellowHappinessLbl.Text = ((double)((double)popHappiness[4] / (double)total[4]) * 100).ToString("0.0") + "%";
            pinkHappinessLbl.Text = ((double)((double)popHappiness[5] / (double)total[5]) * 100).ToString("0.0") + "%"; 
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            gr.TranslateTransform(0, menuStrip1.Height);
            for (int x = 0; x < gridSize; x++){
                for (int y = 0; y < gridSize; y++){
                    //gr.DrawRectangle(Pens.Black, x * 10, y * 10, 10, 10);
                    if (people[x, y] == 1)
                        gr.FillRectangle(Brushes.Blue, x * cellSize, y * cellSize, cellSize, cellSize);
                    if (people[x, y] == 2)
                        gr.FillRectangle(Brushes.Red, x * cellSize, y * cellSize, cellSize, cellSize);
                    if (people[x, y] == 3)
                        gr.FillRectangle(Brushes.Green, x * cellSize, y * cellSize, cellSize, cellSize);
                    if (people[x, y] == 4)
                        gr.FillRectangle(Brushes.Yellow, x * cellSize, y * cellSize, cellSize, cellSize);
                    if (people[x, y] == 5)
                        gr.FillRectangle(Brushes.Pink, x * cellSize, y * cellSize, cellSize, cellSize);
                }
            }

        }

        /// <summary>
        /// Disables/enables the colour population dials
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void populationsDial_ValueChanged(object sender, EventArgs e)
        {
            greenDial.Enabled = false;
            yellowDial.Enabled = false;
            pinkDial.Enabled = false;

            if (populationsDial.Value > 2)
                greenDial.Enabled = true;
            else
                greenDial.Value = 0;
            if (populationsDial.Value > 3)
                yellowDial.Enabled = true;
            else
                yellowDial.Value = 0;
            if (populationsDial.Value > 4)
                pinkDial.Enabled = true;
            else
                pinkDial.Value = 0;

            Populate();
        }

        /// <summary>
        /// Advances the simulation forward one step
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void moveBtn_Click(object sender, EventArgs e)
        {
            CalculateHappiness();
            MovePeople();
            this.Invalidate();
        }
        /// <summary>
        /// Resets the simulation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            toleranceBar.Value = 3;
            toleranceLbl.Text = "3";
            Populate();
            Begin();
        }
        /// <summary>
        /// Plays the simulation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            startStop();
        }
        /// <summary>
        /// T flip-flop for the play/stop button
        /// </summary>
        private void startStop()
        {
            if (button1.Text == "Stop")
            {
                play = false;
                button1.Text = "Play";
            }
            else
            {
                play = true;
                button1.Text = "Stop";
            }
        }
        /// <summary>
        /// Advances simulation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (play == true)
            {
                CalculateHappiness();
                MovePeople();
                this.Invalidate();
            }
        }
        /// <summary>
        /// Adjusts tolerance levels, recalculates happiness
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toleranceBar_Scroll(object sender, EventArgs e)
        {
            CalculateHappiness();
            toleranceLbl.Text = toleranceBar.Value.ToString();
        }
        /// <summary>
        /// Changes the population % of a given population, makes sure total doesn't exceed 95
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dialChange(object sender, EventArgs e)
        {
            var send = sender as NumericUpDown;
            int sumOfOther = (int)(blueDial.Value + redDial.Value + greenDial.Value + yellowDial.Value + pinkDial.Value - send.Value);

            if (send.Value + sumOfOther > 95)
            {
                send.Value = 95 - sumOfOther;
                warningLbl.Show();
                timer2.Enabled = true;
            }

            Populate();

            emptyLbl.Text = "Empty: " + (100 - (send.Value + sumOfOther)).ToString() + "%";
            filledLbl.Text = "Filled: " + (send.Value + sumOfOther).ToString() + "%";      
        }
        /// <summary>
        /// Ends the simulation, displays graph form
        /// </summary>
        private void End()
        {
            moveBtn.Enabled = false;
            button1.Enabled = false;
            toleranceBar.Enabled = false;
            if (graphCheck){
                Form2 graph = new Form2();
                graph.ShowDialog();
            }
        }
        /// <summary>
        /// Resizes the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridSizeDial_ValueChanged(object sender, EventArgs e)
        {
            cellSize = (float)(500 / gridSizeDial.Value);  
            gridSize = (int)gridSizeDial.Value;
            Populate();
            this.Invalidate();
        }
        /// <summary>
        /// Hides the warning label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            warningLbl.Hide();
            timer2.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }
        /// <summary>
        /// Enables graph
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (graphCheck == true)
                graphCheck = false;
            else
                graphCheck = true;
        }

        private void Begin()
        {
            moveBtn.Enabled = true;
            button1.Enabled = true;
            toleranceBar.Enabled = true;
        }
    }
}
