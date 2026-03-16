using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_1
{
    public partial class Form1 : Form
    {
        Random r;


        String a;
        String b;

        String line;

        int counter;
        int time;

        int highScore1=0;
        int highScore2 = 0;

        String topPlayer1;
        String topPlayer2;

        int h;
        int sum;
        int abc=1;
        int abc2 = 1;       

        List<int> scores1 = new List<int>(); // i lista me ta score gia to level 1

        List<String> ScoreBoard1 = new List<String>(); // i lista me ta onomata kai ta score gia to level 1

        List<int> scores2 = new List<int>();// i lista me ta score gia to level 2

        List<String> ScoreBoard2 = new List<String>();// i lista me ta score gia to level 2

        public Form1()
        {
            InitializeComponent();
            

            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

            r = new Random();

            if (File.Exists("SavedList1.txt") & (abc == 1))// i metafora ton kaliteron paxton tou paixnidiou apo ta arxeia stis listes(level 1)
            {

                String line;
                String abcdefg;
                System.IO.StreamReader file = new System.IO.StreamReader("SavedList1.txt");
                System.IO.StreamReader file2 = new System.IO.StreamReader("Numbers1.txt");
                while ((line = file.ReadLine()) != null)
                {
                    abcdefg = file2.ReadLine();
                    int integer = int.Parse(abcdefg);
                    ScoreBoard1.Add(line);
                    scores1.Add(integer);

                }
                abc = 5;
                file.Close();
                file2.Close();
            }


            if (File.Exists("SavedList2.txt") & (abc2 == 1)) // i metafora ton kaliteron paxton tou paixnidiou apo ta arxeia stis listes(level 2)
              
            {

                String line2;
                String abcdefg2;
                System.IO.StreamReader file = new System.IO.StreamReader("SavedList2.txt");
                System.IO.StreamReader file2 = new System.IO.StreamReader("Numbers2.txt");
                while ((line2 = file.ReadLine()) != null)
                {
                    abcdefg2 = file2.ReadLine();
                    int integer = int.Parse(abcdefg2);
                    ScoreBoard2.Add(line2);
                    scores2.Add(integer);

                }
                abc2 = 5;
                file.Close();
                file2.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)// to koumpi Start
        {

            




            if (radioButton1.Checked == true)// epilogi level 1
            {
                timer5.Enabled = true;
            }
            if (radioButton2.Checked == true)// epilogi level 2
            {
                timer7.Enabled = true;
            }

            radioButton1.Visible = false;// i emfanisi tis diadikasias tou paixnidiou
            radioButton2.Visible = false;
            pictureBox2.Visible = false;
            /*dice1.Visible = false;
            dice2.Visible = false;
            dice3.Visible = false;
            dice4.Visible = false;
            dice5.Visible = false;
            dice6.Visible = false;*/
            timer6.Enabled = true;
            timer9.Enabled = true;
            label1.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label1.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label21.Visible = true;
            label9.Visible = false;
            //label2.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            button2.Visible = false;
            
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)//to koumbi cancel
        {


            radioButton1.Visible = true;// to cancel tis diadikasias tou paixnidiou
            radioButton2.Visible = true;
            pictureBox2.Visible = true;
            button3.Visible = false;
            button2.Visible = true;
            timer5.Enabled = false;
            timer6.Enabled = false;
            timer7.Enabled = false;
            timer9.Enabled = false;
            label1.Visible = false;
            dice1.Visible = false;
            dice2.Visible = false;
            dice3.Visible = false;
            dice4.Visible = false;
            dice5.Visible = false;
            dice6.Visible = false;
            //label17.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = true;
          //  label2.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = false;
            label1.Text = 0.ToString();
            counter = 0;
            label5.Text = 0.ToString() + 0.ToString();
            time = 0;
        }

       

        private void timer6_Tick(object sender, EventArgs e)
        {


           
            
            button3.Visible = false;// to telos tou paixnidiou logo xronou kai i metafora stin othoni pou o paiktis grafei to onoma tou
            
            timer5.Enabled = false;
            timer6.Enabled = false;
            timer7.Enabled = false;
            timer9.Enabled = false;
            MessageBox.Show("Game Over");

            button4.Visible = true;
            label16.Visible = true;
            textBox1.Visible = true;





            label1.Visible = false;
            //label17.Visible = false;
            label5.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label21.Visible = false;
            dice1.Visible = false;
            dice2.Visible = false;
            dice3.Visible = false;
            dice4.Visible = false;
            dice5.Visible = false;
            dice6.Visible = false;


            label16.Visible = true;
            textBox1.Visible = true;

            
        }


        private void timer5_Tick(object sender, EventArgs e)// i emfanisi tou  tetragonou (level 1)
        {
            int dice = r.Next(1, 7);
            if (dice1.Visible == true)
            {
                dice1.Visible = false;
            }
            if (dice2.Visible == true)
            {
                dice2.Visible = false;
            }
            if (dice3.Visible == true)
            {
                dice3.Visible = false;
            }
            if (dice4.Visible == true)
            {
                dice4.Visible = false;
            }
            if (dice5.Visible == true)
            {
                dice5.Visible = false;
            }
            if (dice6.Visible == true)
            {
                dice6.Visible = false;
            }
            if (dice == 1)
            {
                dice1.Visible = true;
                dice1.Location = new Point(r.Next(1, 801), r.Next(75, 501));
            }
            if (dice == 2)
            {

                dice2.Visible = true;
                dice2.Location = new Point(r.Next(1, 801), r.Next(75, 501));
            }
            if (dice == 3)
            {
                dice3.Visible = true;
                dice3.Location = new Point(r.Next(1, 801), r.Next(75, 501));
            }
            if (dice == 4)
            {
                dice4.Visible = true;
                dice4.Location = new Point(r.Next(1, 801), r.Next(75, 501));
            }
            if (dice == 5)
            {
                dice5.Visible = true;
                dice5.Location = new Point(r.Next(1, 801), r.Next(75, 501));
            }
            if (dice == 6)
            {
                dice6.Visible = true;
                dice6.Location = new Point(r.Next(1, 801), r.Next(75, 501));
            }
            //label17.Visible = true;
            //label17.Location = new Point(r.Next(this.Width), r.Next(this.Height));
        }

        

        

        

        


        private void timer9_Tick(object sender, EventArgs e)// o timer pou metraei to xrono tou paixnidiou
        {
            time = time + 1;
            if (time < 10)
            {
                label5.Text = 0.ToString() + time.ToString();
            }
            else
            {
                label5.Text = time.ToString();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }


        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void timer7_Tick(object sender, EventArgs e)// i emfanisi tou  tetragonou (level 2)
        {
            int dice = r.Next(1, 7);
            if (dice1.Visible == true)
            {
                dice1.Visible = false;
            }
            if (dice2.Visible == true)
            {
                dice2.Visible = false;
            }
            if (dice3.Visible == true)
            {
                dice3.Visible = false;
            }
            if (dice4.Visible == true)
            {
                dice4.Visible = false;
            }
            if (dice5.Visible == true)
            {
                dice5.Visible = false;
            }
            if (dice6.Visible == true)
            {
                dice6.Visible = false;
            }
            if (dice == 1)
            {
                dice1.Visible = true;
                dice1.Location = new Point(r.Next(1,801), r.Next(75,501));
            }
            if (dice == 2)
            {

                dice2.Visible = true;
                dice2.Location = new Point(r.Next(1, 801), r.Next(75, 501));
            }
            if (dice == 3)
            {
                dice3.Visible = true;
                dice3.Location = new Point(r.Next(1, 801), r.Next(75, 501));
            }
            if (dice == 4)
            {
                dice4.Visible = true;
                dice4.Location = new Point(r.Next(1, 801), r.Next(75, 501));
            }
            if (dice == 5)
            {
                dice5.Visible = true;
                dice5.Location = new Point(r.Next(1, 801), r.Next(75, 501));
            }
            if (dice == 6)
            {
                dice6.Visible = true;
                dice6.Location = new Point(r.Next(1, 801), r.Next(75, 501));
            }
            //label17.Visible = true;
            //label17.Location = new Point(r.Next(this.Width), r.Next(this.Height));

        }

       

            
           

        


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {

                radioButton2.Checked = false;
                radioButton1.Checked = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {

                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)// to koumbi ok pou emfaniszetai meta to telos tou paixnidiou
        {



            radioButton1.Visible = true;// i epanafora tou arxikou menu
            radioButton2.Visible = true;
            button2.Visible = true;
            pictureBox2.Visible = true;
            label9.Visible = true;
           // label2.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label20.Visible = true;

            label1.Text = 0.ToString();
            if (radioButton1.Checked == true)
            {
                sum = 0;
                if (scores1.Count==0)// iprosthesi stoixeiou stin scores1 kai stin ScoreBoard1 otan einai kenes
                {
                    scores1.Add(counter);
                    ScoreBoard1.Add(textBox1.Text + " " + scores1[0].ToString());
                    
                }

                else//iprosthesi stoixeiou stin scores1 kai stin ScoreBoard1 otan einai den einai kenes
                {
                    int presize = scores1.Count; ;
                    scores1.Add(counter);
                    ScoreBoard1.Add("");

                    for (int i = 0; i < scores1.Count-1; i++)
                    {
                        if (scores1[presize] < scores1[i])
                        {
                            for (int j = ScoreBoard1.Count-1; j >i-1; j--)
                            {
                                if (j == i)
                                {
                                    break;
                                }
                                ScoreBoard1[j] = ScoreBoard1[j-1];
                                
                            }
                            ScoreBoard1[i] = "";
                            h = i;

                            break;
                        }
                        sum = sum + 1;
                        if (i==scores1.Count - 2)
                        {
                            ScoreBoard1[ScoreBoard1.Count-1]= textBox1.Text + " " + counter.ToString();
                        }

                    }


                    scores1.Sort();

                    if (sum< scores1.Count -1)
                    {
                        ScoreBoard1[h] = textBox1.Text + " " + counter.ToString();
                    }
                    

                    
                }


                


                if (counter > highScore1)// i metrisi tou highscore tou sigekrimenou gameplay
                {
                    highScore1 = counter;
                    

                    topPlayer1 = textBox1.Text + " " + highScore1.ToString();
                    label13.Text = topPlayer1;

                }


                // i apothikeysi ton liston scores1 kai ScoreBoard1 se txt arxeia
                TextWriter tw1 = new StreamWriter("SavedList1.txt");

                for (int i = 0; i < ScoreBoard1.Count; i++)
                {
                    String s;
                    s = ScoreBoard1[i];
                    tw1.WriteLine(s);

                }


                tw1.Close();

                TextWriter num1 = new StreamWriter("Numbers1.txt");
                for (int i = 0; i < scores1.Count; i++)
                {
                    int n;
                    n = scores1[i];
                    num1.WriteLine(n);

                }
                num1.Close();

            }

            if (radioButton2.Checked == true)
            {


                sum = 0;
                if (scores2.Count == 0)// iprosthesi stoixeiou stin scores2 kai stin ScoreBoard2 otan einai kenes
                {
                    scores2.Add(counter);
                    ScoreBoard2.Add(textBox1.Text + " " + scores2[0].ToString());
                }

                else//iprosthesi stoixeiou stin scores2 kai stin ScoreBoard2 otan einai den einai kenes
                {
                    int presize = scores2.Count; ;
                    scores2.Add(counter);
                    ScoreBoard2.Add("");

                    for (int i = 0; i < scores2.Count - 1; i++)
                    {
                        if (scores2[presize] < scores2[i])
                        {
                            for (int j = ScoreBoard2.Count - 1; j > i - 1; j--)
                            {
                                if (j == i)
                                {
                                    break;
                                }
                                ScoreBoard2[j] = ScoreBoard2[j - 1];

                            }
                            ScoreBoard2[i] = "";
                            h = i;

                            break;
                        }
                        sum = sum + 1;
                        if (i == scores2.Count - 2)
                        {
                            ScoreBoard2[ScoreBoard2.Count - 1] = textBox1.Text + " " + counter.ToString();
                        }

                    }


                    scores2.Sort();

                    if (sum < scores2.Count - 1)
                    {
                        ScoreBoard2[h] = textBox1.Text + " " + counter.ToString();
                    }



                }



                if (counter > highScore2)// i metrisi tou highscore tou sigekrimenou gameplay
                {
                    highScore2 = counter;
                    

                    topPlayer2 = textBox1.Text + " " + highScore2.ToString();
                    label15.Text = topPlayer2;
                }
            }

            counter = 0;
            label5.Text = 0.ToString() + 0.ToString();
            time = 0;



            button4.Visible = false;
            label16.Visible = false;
            textBox1.Visible = false;
            

            

            
            textBox1.Text = "";
            label18.Visible = true;
            label19.Visible = true;

            // i apothikeysi ton liston scores2 kai ScoreBoard2 se txt arxeia
            TextWriter tw2 = new StreamWriter("SavedList2.txt");

            for (int i = 0; i<ScoreBoard2.Count ; i++)
            {
                String s;
                int n;
                s = ScoreBoard2[i];
         
                tw2.WriteLine(s);

            }
                

            tw2.Close();




            TextWriter num2 = new StreamWriter("Numbers2.txt");
            for (int i = 0; i < scores2.Count; i++)
            {
                int n;
                n = scores2[i];
                num2.WriteLine(n);

            }
            num2.Close();



        }

        

       // private void label2_Click(object sender, EventArgs e)
       // {

       // }

       // private void label17_Click(object sender, EventArgs e)
       // {
            //counter++;
           // label1.Text = counter.ToString();
       // }

        private void label18_Click(object sender, EventArgs e)
        {

            



            a = "";// i emfanisi tou scoreboard level 1(ton kaluteron paixton tou paixnidiou gia to level 1)
            for (int i = ScoreBoard1.Count -1; i >= 0; i--)
            {
                
                a = a+ "     " + (ScoreBoard1.Count-i).ToString()+"."+ " "+ ScoreBoard1[i];
            }
            MessageBox.Show(a);

            

        }

        private void label19_Click(object sender, EventArgs e)
        {
            b = "";// i emfanisi tou scoreboard level 2(ton kaluteron paixton tou paixnidiou gia to level 2) 
            for (int i = ScoreBoard2.Count - 1; i >= 0; i--)
            {

                b = b + "     " + (ScoreBoard2.Count - i).ToString() + "." + " " + ScoreBoard2[i];
            }
            MessageBox.Show(b);
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        //oi aksies toy kathe zarioy
        private void dice1_Click(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
        }

        private void dice2_Click(object sender, EventArgs e)
        {
            counter=counter+2;
            label1.Text = counter.ToString();
        }

        private void dice3_Click(object sender, EventArgs e)
        {
            counter = counter + 3 ;
            label1.Text = counter.ToString();
        }

        private void dice4_Click(object sender, EventArgs e)
        {
            counter = counter + 4;
            label1.Text = counter.ToString();
        }

        private void dice6_Click(object sender, EventArgs e)
        {
            counter = counter + 6;
            label1.Text = counter.ToString();
        }

        private void dice5_Click(object sender, EventArgs e)
        {
            counter = counter + 5;
            label1.Text = counter.ToString();
        }
    }
    }
