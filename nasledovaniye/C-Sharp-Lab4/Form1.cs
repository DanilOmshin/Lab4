using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace C_Sharp_Lab4
{
    public partial class Form1 : Form
    {
        List<Sweets> sweetsList = new List<Sweets>();

        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void btnRep_Click(object sender, EventArgs e)
        {
            this.sweetsList.Clear();
            var rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                switch (rnd.Next() % 3)
                {
                    case 0:
                        this.sweetsList.Add(Chocolate.Generate());
                        break;
                    case 1:
                        this.sweetsList.Add(Backery.Generate());
                        break;
                    case 2:
                        this.sweetsList.Add(Fruits.Generate());
                        break;
                }
            }
            ShowInfo();
        }

        private void ShowInfo()
        {
            int chocolateCount = 0;
            int backeryCount = 0;
            int fruitsCount = 0;

            foreach (var sweets in this.sweetsList)
            {
                if (sweets is Chocolate)
                {
                    chocolateCount += 1;
                }
                else if (sweets is Backery)
                {
                    backeryCount += 1;
                }
                else if (sweets is Fruits)
                {
                    fruitsCount += 1;
                }
            }

            txtInfo.Text = "Шклд\tВпчка\tФрукты";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", chocolateCount, backeryCount, fruitsCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.sweetsList.Count == 0)
            {
                txtOut.Text = "Автомат пуст";
                pictureBox1.Load(@"C:\pictures\empty.jpg");
                return;
            }
            var sweet = this.sweetsList[0];
            if (this.sweetsList.Count > 1)
            {
                var sweetNext = this.sweetsList[1];
                txtQueue.Text = sweetNext.GetNext();
            }
            else
            {
                txtQueue.Text = "Автомат пуст";
            }
            this.sweetsList.RemoveAt(0);
            txtOut.Text = sweet.GetInfo();

            ShowInfo();
            if (sweet.GetNext() == "Следующее: Молочный шоколад" || sweet.GetNext() == "Следующее: Тёмный шоколад")
            {
                pictureBox1.Load(@"C:\pictures\chockorehi.jpg");
            }
            else if (sweet.GetNext() == "Следующее: Булочка")
            {
                pictureBox1.Load(@"C:\pictures\bulochka.jpg");
            }
            else if (sweet.GetNext() == "Следующее: Пирожок")
            {
                pictureBox1.Load(@"C:\pictures\pirojok.jpg");
            }
            else if (sweet.GetNext() == "Следующее: Ватрушка")
            {
                pictureBox1.Load(@"C:\pictures\vatrushka.jpg");
            }
            else if (sweet.GetNext() == "Следующее: Манго")
            {
                pictureBox1.Load(@"C:\pictures\mango.jpg");
            }
            else if (sweet.GetNext() == "Следующее: Киви")
            {
                pictureBox1.Load(@"C:\pictures\kiwi.jpg");
            }
            else if (sweet.GetNext() == "Следующее: Ананас")
            {
                pictureBox1.Load(@"C:\pictures\pineapple.jpg");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtQueue_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

