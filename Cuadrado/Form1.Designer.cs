using System;
using System.Windows.Forms;
using System.Linq;

namespace Cuadrado
{
    partial class Form1 : Form
    {
        private Label labelTamaño;
        private Label[] labelCalificaciones;
        private Button buttonCalcular;
        private Label labelResultadoPromedio;
        private Label labelResultadoAltoBajo;
        private Label labelResultadoReprobado;
        private Label labelDistribucion;



        private void InitializeComponentCuadrado()
        {
            this.Text = "Calificaciones";
            this.Size = new System.Drawing.Size(800, 600);

            labelTamaño = new System.Windows.Forms.Label();
            labelTamaño.Text = "Tamaño";
            labelTamaño.Location = new System.Drawing.Point(300, 50);
            this.Controls.Add(labelTamaño);

            labelCalificaciones = new Label[12];
            string[] calificaciones = {
                "5.5, 8.6, 10",
                "8.0, 5.5, 10",
                "9.0, 4.1, 7.8",
                "10, 2.2, 8.1",
                "7.0, 9.2, 7.1",
                "9.0, 4.0, 6.0",
                "6.5, 5.0, 5.0",
                "4.0, 7.0, 4.0",
                "8.0, 8.0, 9.0",
                "10, 9.0, 9.2",
                "5.0, 10, 8.4",
                "9.0, 4.6, 7.5"
            };

            for (int i = 0; i < 12; i++)
            {
                labelCalificaciones[i] = new Label();
                labelCalificaciones[i].Text = calificaciones[i];
                labelCalificaciones[i].Size = new System.Drawing.Size(150, 15);
                labelCalificaciones[i].Location = new System.Drawing.Point(300, 80 + i * 15);
                this.Controls.Add(labelCalificaciones[i]);
            }

            buttonCalcular = new System.Windows.Forms.Button();
            buttonCalcular.Text = "Calcular";
            buttonCalcular.Location = new System.Drawing.Point(500, 150);
            this.Controls.Add(buttonCalcular);
            buttonCalcular.Click += CalculoCuadrado_Click;

            labelResultadoPromedio = new System.Windows.Forms.Label();
            labelResultadoPromedio.Size = new System.Drawing.Size(300, 200);
            labelResultadoPromedio.Location = new System.Drawing.Point(500, 250);
            this.Controls.Add(labelResultadoPromedio);

            labelResultadoAltoBajo = new System.Windows.Forms.Label();
            labelResultadoAltoBajo.Size = new System.Drawing.Size(300, 50);
            labelResultadoAltoBajo.Location = new System.Drawing.Point(800, 250);
            this.Controls.Add(labelResultadoAltoBajo);

            labelResultadoReprobado = new System.Windows.Forms.Label();
            labelResultadoReprobado.Size = new System.Drawing.Size(300, 200);
            labelResultadoReprobado.Location = new System.Drawing.Point(500, 550);
            this.Controls.Add(labelResultadoReprobado);

            labelDistribucion = new System.Windows.Forms.Label();
            labelDistribucion.Size = new System.Drawing.Size(300, 200);
            labelDistribucion.Location = new System.Drawing.Point(800, 400);
            this.Controls.Add(labelDistribucion);
        }

        private void CalculoCuadrado_Click(object sender, EventArgs e)
        {
            double[,] boletas = new double[,] {
                {5.5, 8.6, 10},
                {8.0, 5.5, 10},
                {9.0, 4.1, 7.8},
                {10, 2.2, 8.1},
                {7.0, 9.2, 7.1},
                {9.0, 4.0, 6.0},
                {6.5, 5.0, 5.0},
                {4.0, 7.0, 4.0},
                {8.0, 8.0, 9.0},
                {10, 9.0, 9.2},
                {5.0, 10, 8.4},
                {9.0, 4.6, 7.5}
            };

            BoletasResultado resultadoDato = new BoletasResultado();
            resultadoDato.PromedioAlumno(boletas, labelResultadoPromedio, labelResultadoAltoBajo, labelResultadoReprobado, labelDistribucion);
        }

        class BoletasResultado
        {
            public void PromedioAlumno(double[,] boletas, Label labelPromedio, Label labelAltoBajo, Label labelReprobado, Label labelDistribucion)
            {
                double[] promedioPorAlumno = new double[boletas.GetLength(0)];
                for (int i = 0; i < boletas.GetLength(0); ++i)
                {
                    double sumaDeCalificaciones = 0;
                    for (int j = 0; j < boletas.GetLength(1); ++j)
                    {
                        sumaDeCalificaciones += boletas[i, j];
                    }
                    promedioPorAlumno[i] = sumaDeCalificaciones / boletas.GetLength(1);
                }
                ImprimirPromedios(promedioPorAlumno, labelPromedio, labelAltoBajo, labelReprobado, labelDistribucion);
            }

            public void ImprimirPromedios(double[] promedioPorAlumno, Label labelPromedio, Label labelAltoBajo, Label labelReprobado, Label labelDistribucion)
            {
                labelPromedio.Text = ""; // Limpiar el texto anterior
                for (int i = 0; i < promedioPorAlumno.Length; ++i)
                {
                    labelPromedio.Text += $"Promedio del alumno {i + 1} es {promedioPorAlumno[i]}\n";
                }
                PromedioBajoAlto(promedioPorAlumno, labelAltoBajo, labelReprobado, labelDistribucion);
            }

            public void PromedioBajoAlto(double[] promedioPorAlumno, Label labelAltoBajo, Label labelReprobado, Label labelDistribucion)
            {
                double indiceAlto = promedioPorAlumno.Max();
                double indiceBajo = promedioPorAlumno.Min();

                labelAltoBajo.Text = $"El promedio mas alto es {indiceAlto} y el promedio mas bajo es {indiceBajo}\n";
                ParcialesReprobados(labelReprobado, labelDistribucion);
            }

            public void ParcialesReprobados(Label labelReprobado, Label labelDistribucion)
            {
                double[,] boletas = new double[,] {
                    {5.5, 8.6, 10},
                    {8.0, 5.5, 10},
                    {9.0, 4.1, 7.8},
                    {10, 2.2, 8.1},
                    {7.0, 9.2, 7.1},
                    {9.0, 4.0, 6.0},
                    {6.5, 5.0, 5.0},
                    {4.0, 7.0, 4.0},
                    {8.0, 8.0, 9.0},
                    {10, 9.0, 9.2},
                    {5.0, 10, 8.4},
                    {9.0, 4.6, 7.5}
                };

                labelReprobado.Text = ""; // Limpiar el texto anterior
                for (int i = 0; i < boletas.GetLength(0); ++i)
                {
                    for (int j = 0; j < boletas.GetLength(1); ++j)
                    {
                        if (boletas[i, j] < 7.0)
                        {
                            labelReprobado.Text += $"El alumno {i + 1} reprobó el parcial {j + 1}\n";
                        }
                    }
                }
                DistribucionCalificaciones(labelDistribucion);
            }

            public void DistribucionCalificaciones(Label labelDistribucion)
            {
                double[] promedioPorAlumno = new double[12]; // Reemplaza con tus promedios
                int[] conteoCalificaciones = new int[6]; // 6 rangos de calificaciones: 0-4.9, 5-5.9, 6-6.9, 7-7.9, 8-8.9, 9-10

                foreach (double promedio in promedioPorAlumno)
                {
                    if (promedio >= 0.0 && promedio <= 4.9)
                    {
                        conteoCalificaciones[0]++;
                    }
                    else if (promedio >= 5.0 && promedio <= 5.9)
                    {
                        conteoCalificaciones[1]++;
                    }
                    else if (promedio >= 6.0 && promedio <= 6.9)
                    {
                        conteoCalificaciones[2]++;
                    }
                    else if (promedio >= 7.0 && promedio <= 7.9)
                    {
                        conteoCalificaciones[3]++;
                    }
                    else if (promedio >= 8.0 && promedio <= 8.9)
                    {
                        conteoCalificaciones[4]++;
                    }
                    else if (promedio >= 9.0 && promedio <= 10.0)
                    {
                        conteoCalificaciones[5]++;
                    }
                }

                labelDistribucion.Text = ""; // Limpiar el texto anterior
                labelDistribucion.Text += "0 - 4.9: " + conteoCalificaciones[0] + " Alumnos\n";
                labelDistribucion.Text += "5.0 - 5.9: " + conteoCalificaciones[1] + " Alumnos\n";
                labelDistribucion.Text += "6.0 - 6.9: " + conteoCalificaciones[2] + " Alumnos\n";
                labelDistribucion.Text += "7.0 - 7.9: " + conteoCalificaciones[3] + " Alumnos\n";
                labelDistribucion.Text += "8.0 - 8.9: " + conteoCalificaciones[4] + " Alumnos\n";
                labelDistribucion.Text += "9.0 - 10.0: " + conteoCalificaciones[5] + " Alumnos\n";
            }
        }
    }
}
