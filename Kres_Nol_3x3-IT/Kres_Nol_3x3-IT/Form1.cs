using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kres_Nol_3x3_IT
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

      OffAll();

      label1.Text = "Нажмите для начала";

      GameStart();
    }

    int cout = 0;

    public void GameStart()
    {
      if (Proverka() == 1 || Proverka() == 2 || Proverka() == 3)
        return;
      if (cout == 4)
      {
        return;
      }
      if (cout == 0)
      {
        cout = 2;
      }
      else
      {
        Randomaized();
      }
    }
    public void Randomaized()
    {     
      Random rand = new Random();

      while (true)
      {
        switch (rand.Next(1,9))
        {
          case 1:
            if (button1.Enabled == false)
            {
              continue;
            }
            button1.Enabled = false;
            button1.BackColor = Color.Red;
            button1.Text = "0";
            cout += 2;
            break;
          case 2:
            if (button2.Enabled == false)
            {
              continue;
            }
            button2.Enabled = false;
            button2.BackColor = Color.Red;
            button2.Text = "0";
            cout += 2;
            break;
          case 3:
            if (button3.Enabled == false)
            {
              continue;
            }
            button3.Enabled = false;
            button3.BackColor = Color.Red;
            button3.Text = "0";
            cout += 2;
            break;
          case 4:
            if (button4.Enabled == false)
            {
              continue;
            }
            button4.Enabled = false;
            button4.BackColor = Color.Red;
            button4.Text = "0";
            cout += 2;
            break;
          case 5:
            if (button5.Enabled == false)
            {
              continue;
            }
            button5.Enabled = false;
            button5.BackColor = Color.Red;
            button5.Text = "0";
            cout += 2;
            break;
          case 6:
            if (button6.Enabled == false)
            {
              continue;
            }
            button6.Enabled = false;
            button6.BackColor = Color.Red;
            button6.Text = "0";
            cout += 2;
            break;
          case 7:
            if (button7.Enabled == false)
            {
              continue;
            }
            button7.Enabled = false;
            button7.BackColor = Color.Red;
            button7.Text = "0";
            cout += 2;
            break;
          case 8:
            if (button8.Enabled == false)
            {
              continue;
            }
            button8.Enabled = false;
            button8.BackColor = Color.Red;
            button8.Text = "0";
            cout += 2;
            break;
          case 9:
            if (button9.Enabled == false)
            {
              continue;
            }
            button9.Enabled = false;
            button9.BackColor = Color.Red;
            button9.Text = "0";
            cout += 2;
            break;
        }
        if (cout == 4)
        {
          if (Proverka() == 1 || Proverka() == 2 || Proverka() == 3)
            return;
          else
          cout = 2;
          break;
        }
        else
        {
          continue;
        }
      }
    }
    public int Proverka()
    {
      if
        (
        button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||
        button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
        button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||

        button1.Text == "X" && button4.Text == "X" && button7.Text == "X" ||
        button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
        button3.Text == "X" && button6.Text == "X" && button9.Text == "X" ||

        button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
        button7.Text == "X" && button5.Text == "X" && button3.Text == "X"
        )
      {
        label1.Text = "Ты победил!";
        return 1;
      }
      if
        (
        button1.Text == "0" && button2.Text == "0" && button3.Text == "0" ||
        button4.Text == "0" && button5.Text == "0" && button6.Text == "0" ||
        button7.Text == "0" && button8.Text == "0" && button9.Text == "0" ||

        button1.Text == "0" && button4.Text == "0" && button7.Text == "0" ||
        button2.Text == "0" && button5.Text == "0" && button8.Text == "0" ||
        button3.Text == "0" && button6.Text == "0" && button9.Text == "0" ||

        button1.Text == "0" && button5.Text == "0" && button9.Text == "0" ||
        button7.Text == "0" && button5.Text == "0" && button3.Text == "0"
        )
      {
        label1.Text = "Ты проиграл!";
        return 2;
      }
      if
        (
        button1.Enabled == false && button2.Enabled == false && button3.Enabled == false &&
        button4.Enabled == false && button5.Enabled == false && button6.Enabled == false &&
        button7.Enabled == false && button8.Enabled == false && button9.Enabled == false
        )
      {
        label1.Text = "Ничья!";
        return 3;
      }
      return 4;
    }
    public void OffAll()
    {
      button1.Hide();
      button2.Hide();
      button3.Hide();
      button4.Hide();
      button5.Hide();
      button6.Hide();
      button7.Hide();
      button8.Hide();
      button9.Hide();
    }
    public void OnAll()
    {
      button1.Show();
      button2.Show();
      button3.Show();
      button4.Show();
      button5.Show();
      button6.Show();
      button7.Show();
      button8.Show();
      button9.Show();
    }
    private void button1_Click(object sender, EventArgs e)
    {
      button1.Enabled = false;
      button1.Text = "X";
      button1.BackColor = Color.Green;
      GameStart();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      button2.Enabled = false;
      button2.Text = "X";
      button2.BackColor = Color.Green;
      GameStart();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      button3.Enabled = false;
      button3.Text = "X";
      button3.BackColor = Color.Green;
      GameStart();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      button4.Enabled = false;
      button4.Text = "X";
      button4.BackColor = Color.Green;
      GameStart();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      button5.Enabled = false;
      button5.Text = "X";
      button5.BackColor = Color.Green;
      GameStart();
    }

    private void button6_Click(object sender, EventArgs e)
    {
      button6.Enabled = false;
      button6.Text = "X";
      button6.BackColor = Color.Green;
      GameStart();
    }

    private void button7_Click(object sender, EventArgs e)
    {
      button7.Enabled = false;
      button7.Text = "X";
      button7.BackColor = Color.Green;
      GameStart();
    }

    private void button8_Click(object sender, EventArgs e)
    {
      button8.Enabled = false;
      button8.Text = "X";
      button8.BackColor = Color.Green;
      GameStart();
    }

    private void button9_Click(object sender, EventArgs e)
    {
      button9.Enabled = false;
      button9.Text = "X";
      button9.BackColor = Color.Green;
      GameStart();
    }

    private void button10_Click(object sender, EventArgs e)
    {
      label1.Text = "Ты играешь за зеленые крестики!";
      button10.Hide();
      OnAll();
    }
  }
}
