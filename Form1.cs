using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adaline
{
    public partial class Form1 : Form
    {
        Adaline ada;
        Bitmap bmpFondo;
        Bitmap bmpAnimacion;
        Bitmap bmpError;
        Pen planoPen;
        Brush ceroBrush;
        Brush unoBrush;
        List<Entradas> entradas;
        public Form1()
        {
            InitializeComponent();
            bmpFondo = new Bitmap(1000, 1000);
            bmpAnimacion = new Bitmap(1000, 1000);
            bmpError = new Bitmap(pictureBoxError.Width, pictureBoxError.Height);
            entradas = new List<Entradas>();
            pictureBoxCanvas.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxCanvas.BackgroundImage = bmpFondo;
            pictureBoxCanvas.Image = bmpAnimacion;
            pictureBoxError.Image = bmpError;
            planoPen = new Pen(Color.Black, 4);
            unoBrush = new SolidBrush(Color.Gray);
            ceroBrush = new SolidBrush(Color.Gold);
            listBoxEntradas.DataSource = null;
            dibujarCanvas();
        }

        void dibujarCanvas()
        {
            Graphics g = Graphics.FromImage(bmpFondo);

            g.Clear(Color.White);

            for (int i = 1; i < 10; i++)
            {
                g.DrawLine(planoPen, i * 100, 0, i * 100, 999);
                g.DrawLine(planoPen, 0, i * 100, 999, i * 100);
            }
            pictureBoxCanvas.Refresh();
        }

        private void buttonPesos_Click(object sender, EventArgs e)
        {
            ada = new Adaline((float)numericUpDownLR.Value);
            mostrarValores();
            dibujarCirculos();
            dibujarPlano();
        }

        private void mostrarValores()
        {
            labelW0.Text = ada.Pesos[0].ToString();
            labelW1.Text = ada.Pesos[1].ToString();
            labelW2.Text = ada.Pesos[2].ToString();
        }

        void dibujarPlano()
        {
            float y1, y2, x1, x2;

            Graphics g = Graphics.FromImage(bmpAnimacion);

            g.Clear(Color.Transparent);

            y1 = (ada.Pesos[0] - ada.Pesos[1] * -5) / ada.Pesos[2];
            y2 = (ada.Pesos[0] - ada.Pesos[1] * 5) / ada.Pesos[2];

            x1 = (ada.Pesos[0] - ada.Pesos[2] * -5) / ada.Pesos[1];
            x2 = (ada.Pesos[0] - ada.Pesos[2] * 5) / ada.Pesos[1];

            if (Math.Abs(y1) <= 5 && Math.Abs(y2) <= 5)
                g.DrawLine(planoPen, -5 * 100 + 500, y1 * 100 + 500, 5 * 100 + 500, y2 * 100 + 500);
            else
                g.DrawLine(planoPen, x1 * 100 + 500, -5 * 100 + 500, x2 * 100 + 500, 5 * 100 + 500);

            pictureBoxCanvas.Refresh();
        }

        private void dibujarCirculos()
        {
            Graphics g = Graphics.FromImage(bmpFondo);

            foreach (Entradas ent in entradas)
            {
                if (ent.Clase == 0)
                    g.FillEllipse(ceroBrush, ent.X * 100 + 490, ent.Y * 100 + 490, 20, 20);
                else
                    g.FillEllipse(unoBrush, ent.X * 100 + 490, ent.Y * 100 + 490, 20, 20);
            }

            pictureBoxCanvas.Refresh();
        }

        private void pictureBoxCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = Graphics.FromImage(bmpFondo);

            float x, y;

            x = (e.X * 2f - 500f) / 100f;
            y = (e.Y * 2f - 500f) / 100f;

            if (e.Button == MouseButtons.Left) //Clase 0
            {
                entradas.Add(new Entradas(0, x, y));
                g.FillEllipse(ceroBrush, e.X * 2 - 10, e.Y * 2 - 10, 20, 20);
            }
            if (e.Button == MouseButtons.Right) //Clase 1
            {
                entradas.Add(new Entradas(1, x, y));
                g.FillEllipse(unoBrush, e.X * 2 - 10, e.Y * 2 - 10, 20, 20);
            }

            listBoxEntradas.DataSource = null;
            listBoxEntradas.DataSource = entradas;
            pictureBoxCanvas.Refresh();
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            if (ada == null)
                return;

            float error = 1;
            int epoca, res;
            epoca = 1;

            while (epoca <= numericUpDownEpocas.Value && error > (float)numericUpDownError.Value)
            {
                dibujarPlano();
                error = 0;

                foreach (Entradas ent in entradas)
                {
                    res = evaluar(ent.X, ent.Y);
                    error += (ent.Clase - res) * (ent.Clase - res);
                    ada.actualizar(ent.Clase, ent.X, ent.Y);
                    dibujarPlano();
                }

                error = error / entradas.Count;
                dibujarError(error);
                epoca++;
            }

            epoca--;

            if (error < (float)numericUpDownError.Value)
            {
                string mess = "Convergio en epoca " + epoca.ToString();
                dibujarPlano();
                evaluarCanvas();
                dibujarCirculos();
                MessageBox.Show(mess);
            }
            else
                MessageBox.Show("No convirgio");
        }

        private void dibujarError(float error)
        {
            Graphics g = Graphics.FromImage(bmpError);

            g.Clear(Color.White);
            g.FillRectangle(unoBrush, 0, 200 - error * 200, 499, 199);

            pictureBoxError.Refresh();
        }

        private int evaluar(float x, float y)
        {
            if ((ada.Pesos[1] * x + ada.Pesos[2] * y - ada.Pesos[0]) >= 0)
                return 1;
            else
                return 0;
        }

        void evaluarCanvas()
        {
            float x, y, sig;

            for (float i = 0; i < 1000; i++)    //Y
                for (float j = 0; j < 1000; j++)  //X
                {
                    x = (j - 500) / 100;
                    y = (i - 500) / 100;

                    sig = ada.sigmoide(x, y);

                    if (sig >= 0.8)
                        bmpFondo.SetPixel((int)j, (int)i, Color.FromArgb(250, 0, 50));
                    else if(sig >= 0.6)
                        bmpFondo.SetPixel((int)j, (int)i, Color.FromArgb(200, 0, 100));
                    else if (sig >= 0.4)
                        bmpFondo.SetPixel((int)j, (int)i, Color.FromArgb(150, 0, 150));
                    else if (sig >= 0.2)
                        bmpFondo.SetPixel((int)j, (int)i, Color.FromArgb(100, 0, 200));
                    else
                        bmpFondo.SetPixel((int)j, (int)i, Color.FromArgb(50, 0, 250));
                }

            pictureBoxCanvas.Refresh();
        }

        private void numericUpDownLR_ValueChanged(object sender, EventArgs e)
        {
            if (ada == null)
                return;

            ada.RA = (float)numericUpDownError.Value;
        }
    }
}
