using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Samochodzik
{

    public partial class Form1 : Form
    {
        private Bitmap originalImage;
        private Bitmap rotatedImage;
        public Form1()
        {
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
            InitializeComponent();
            originalImage = new Bitmap(pictureBox2.Image);
            rotatedImage = new Bitmap(originalImage); // Tworzymy kopię obrazka
            pictureBox2.BringToFront();

        }

        private void Form1_KeyDown1(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Focus();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    Console.WriteLine("działa");
                    KeyPressed = false;
                    break;
                case Keys.Down:
                    DownKeyPressed = true;
                    break;
                case Keys.Left:

                    LeftKeyPressed = true;
                    break;
                case Keys.Right:

                    RightKeyPressed = true;
                    break;
                   
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    KeyPressed = true;
                    break;
                case Keys.Down:
                    DownKeyPressed = false;
                    break;
                case Keys.Left:
                    LeftKeyPressed = false;

                    break;
                case Keys.Right:
                    RightKeyPressed = false;
                    break;
                   
            }
        }
        private bool KeyPressed = true;
        private bool LeftKeyPressed = false;
        private bool RightKeyPressed = false;
        private bool DownKeyPressed = false;
        private bool EndGame = false;


        private bool line1 = false;
        private bool line2 = false;
        private bool line3 = false;  // tutaj taki prymitywny mechanizm zeby podczas dawania samochodu od goru nie wpadaly na siebie(do poprawy oczywiscie)
        private bool line4 = true;

        void moveline(int speed)
        {
            if (pictureBox1.Top > 600)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox3.Top > 600)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top > 600)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }

            if (pictureBox5.Top > 600)
            {
                pictureBox5.Top = 0;
            }
            else
            {
                pictureBox5.Top += speed;
            }

            if (pictureBox6.Top > 600)
            {
                pictureBox6.Top = 0;
            }
            else
            {
                pictureBox6.Top += speed;
            }

            if (pictureBox7.Top > 600)
            {
                pictureBox7.Top = 0;
            }
            else
            {
                pictureBox7.Top += speed;
            }

            if (pictureBox8.Top > 600)
            {
                pictureBox8.Top = 0;
            }
            else
            {
                pictureBox8.Top += speed;
            }

            if (pictureBox9.Top > 600)
            {
                pictureBox9.Top = 0;
            }
            else
            {
                pictureBox9.Top += speed;
            }
               if (pictureBox15.Top > 600)
            {
                pictureBox15.Top = 0;
            }
            else
            {
                pictureBox15.Top += speed;
            }

            if (pictureBox12.Top > 600)
            {
                pictureBox12.Top = 0;
            }
            else
            {
                pictureBox12.Top += speed;
            }

            if (pictureBox18.Top > 600)
            {
                pictureBox18.Top = 0;
            }
            else
            {
                pictureBox18.Top += speed;
            }

            if (pictureBox13.Top > 600)
            {
                pictureBox13.Top = 0;
            }
            else
            {
                pictureBox13.Top += speed;
            }


        }
        void CrashCar(List<PictureBox> pictureBoxes)
        {
            foreach (var pictureBox in pictureBoxes)
            {
                int randomSpeed = GenerateRandomValue();
                int Line = GenerateRandomValue2();
                if (pictureBox.Top > 645 || pictureBox.Top < 0)
                {
                    
                    if(pictureBox.Top > 645)
                    {
                        if(Line == 1)
                        {
                            if(line1 == true)
                            {
                                pictureBox.Top = 0;
                                pictureBox.Left = 23;
                                line1 = false;
                                line2 = true;
                                line3 = true;
                                line4 = true;
                            }
                            else
                            pictureBox.Top = 0;
                            pictureBox.Left = 107;
                            line1 = true;
                            line2 = false;
                            line3 = true;
                            line4 = true;

                        }
                        if (Line == 2)
                        {
                            if (line2 == true)
                            {
                                pictureBox.Top = 0;
                                pictureBox.Left = 107;
                                line1 = true;
                                line2 = false;
                                line3 = true;
                                line4 = true;
                            }
                            else
                            pictureBox.Top = 0;
                            pictureBox.Left = 188;
                            line1 = true;
                            line2 = true;
                            line3 = false;
                            line4 = true;
                        }
                        if (Line == 3)
                        {
                            if (line3 == true)
                            {
                                pictureBox.Top = 0;
                                pictureBox.Left = 188;
                                line1 = true;
                                line2 = true;
                                line3 = false;
                                line4 = true;
                            }
                            else
                            pictureBox.Top = 0;
                            pictureBox.Left = 272;
                            line1 = true;
                            line2 = true;
                            line3 = true;
                            line4 = false;
                        }
                        if (Line == 4)
                        {
                            if (line4 == true)
                            {
                                pictureBox.Top = 0;
                                pictureBox.Left = 272;
                                line1 = true;
                                line2 = true;
                                line3 = true;
                                line4 = false;
                            }
                            else
                            pictureBox.Top = 0;
                            pictureBox.Left = 23;
                            line1 = false;
                            line2 = true;
                            line3 = true;
                            line4 = true;
                        }
                    }
                    pictureBox.Top = 0;

                }
                else
                {
                    if (Acceleration > 3) {
                        pictureBox.Top += Acceleration - randomSpeed;
                    }
                    else
                        pictureBox.Top += Acceleration;

                }
            }
        }
        public int Acceleration = 0;
        private int rotationAngle = 0;
        private double distance = 1;
        private Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            distance += Acceleration;
            speedLabel.Text = (Acceleration * 2).ToString(); // tu jest tempomat
            label2.Text = distance.ToString();
            if (KeyPressed == true)
            {
                Acceleration--;
                if (Acceleration <= 0)
                {
                    Acceleration = 0;
                }
                else
                   
                moveline(Acceleration);
                CrashCar(new List<PictureBox> {   pictureBox14,  pictureBox16, pictureBox17 });
            }

            if (KeyPressed == false)
            {
                Acceleration++;


                moveline(Acceleration);
                CrashCar(new List<PictureBox> {   pictureBox14,  pictureBox16, pictureBox17 });
            }
            if (LeftKeyPressed)
            {

                if (rotationAngle >= -45 & Acceleration > 2)
                {
                    rotationAngle -= 4; // Zwiększamy kąt obrotu o 5 stopni
                    RotatePictureBox(rotationAngle);
                }



            }
            else if (RightKeyPressed)
            {
                if (rotationAngle <= 45 & Acceleration > 2)
                {
                    rotationAngle += 4; // Zwiększamy kąt obrotu o 5 stopni
                    RotatePictureBox(rotationAngle);
                }

            }
            if (rotationAngle >= 0)
            {
                pictureBox2.Left += (rotationAngle * Acceleration) / 25;
            }
            else
            {
                pictureBox2.Left -= (Math.Abs(rotationAngle) * Acceleration) / 25;
            }
            if(DownKeyPressed)
            {
                Acceleration = Acceleration - (Acceleration/12);
            }
            if (CheckCollisionWithObstacles())
            {
                if (EndGame == false)
                {
                    EndGame = true;
                    Acceleration = 0;
                    timer1.Stop(); // Zatrzymuje timer, aby zatrzymać grę}
                    MessageBox.Show("Game Over! UDERZYLES");
                    
                }
                
              
            }


        }
        private int GenerateRandomValue()
        {
            return random.Next(1, 40); // Generowanie losowej liczby całkowitej z przedziału od 1 do 40
        }
        private int GenerateRandomValue2()
        {
            return random.Next(1, 6); // Generowanie losowej liczby całkowitej z przedziału od 1 do 6
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
       
        private void RotatePictureBox(int angle)
        {
            // Tworzymy macierz transformacji
            System.Drawing.Drawing2D.Matrix matrix = new System.Drawing.Drawing2D.Matrix();
            matrix.Translate(originalImage.Width / -2, originalImage.Height / -2, System.Drawing.Drawing2D.MatrixOrder.Append); // Przesunięcie do środka obrazka
            matrix.Rotate(angle, System.Drawing.Drawing2D.MatrixOrder.Append); // Obrót
            matrix.Translate(originalImage.Width / 2, originalImage.Height / 2, System.Drawing.Drawing2D.MatrixOrder.Append); // Przesunięcie z powrotem na miejsce

            // Tworzymy obiekt graficzny na podstawie rotatedImage
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                // Czyścimy obrazek
                g.Clear(Color.Transparent);
                // Zastosowanie macierzy transformacji
                g.Transform = matrix;
                // Rysujemy obrócony obrazek
                g.DrawImage(originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height));
            }

            // Przypisujemy obrócony obrazek z powrotem do pictureBox
            pictureBox2.Image = rotatedImage;
        }
        private bool CheckCollisionWithObstacles()
        {
            Rectangle rect1 = pictureBox2.Bounds;
            Rectangle rect2 = pictureBox10.Bounds;
            Rectangle rect3 = pictureBox11.Bounds;
            Rectangle rect4 = pictureBox16.Bounds;
            Rectangle rect5 = pictureBox17.Bounds;
            Rectangle rect6 = pictureBox14.Bounds;

            rect2.Inflate(-10, -10);
            rect3.Inflate(-10, -10);
            rect4.Inflate(-10, -10);
            rect5.Inflate(-10, -10);
            rect6.Inflate(-10, -10);

            return rect1.IntersectsWith(rect2) || rect1.IntersectsWith(rect3) || rect1.IntersectsWith(rect4) || rect1.IntersectsWith(rect4) || rect1.IntersectsWith(rect5) || rect1.IntersectsWith(rect6);


        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}