namespace programa
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label longitudDato;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponentRectangulo()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 400);
            this.Text = "ejercicio 12";

       
            btnCalcular = new System.Windows.Forms.Button();
            btnCalcular.Text = "Calcular";
            btnCalcular.Location = new System.Drawing.Point(300, 250);
            btnCalcular.Size = new System.Drawing.Size(400, 30);
            btnCalcular.Click += BtnCalcularRectangulo_Click;
            this.Controls.Add(btnCalcular);

          
            lblResultado = new System.Windows.Forms.Label();
            lblResultado.Location = new System.Drawing.Point(300, 240);
            lblResultado.Size = new System.Drawing.Size(200, 90);
            this.Controls.Add(lblResultado);
        }

        #endregion

        // Evento de clic del botón de cálculo
        private void BtnCalcularRectangulo_Click(object sender, EventArgs e)
        {
            double[,] matriz = new double[5, 10];
            Logicas logica = new Logicas();
            logica.rellenarMatriz(matriz);
        }

    class Logicas
    {
        public void rellenarMatriz(double[,] matriz)
        {
            Random random = new Random();
            for (int i = 0; i < matriz.GetLength(0); ++i)
            {
                for (int j = 0; j < matriz.GetLength(1); ++j)
                {
                    matriz[i, j] = random.Next(1, 101);
                }
            }
            mostrarMatriz(matriz);
        }

        public void mostrarMatriz(double[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); ++i)
            {
                for (int j = 0; j < matriz.GetLength(1); ++j)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            operacionesMatematicas(matriz);
        }

        public void operacionesMatematicas(double[,] matriz)
        {
            sumarDato(matriz);
        }

        public void sumarDato(double[,] matriz)
        {
            double[] guardarFila = new double[matriz.GetLength(0)];
            double[] guardarColumna = new double[matriz.GetLength(1)];

            for (int i = 0; i < matriz.GetLength(0); ++i)
            {
                double sumaDefilas = 0;
                for (int j = 0; j < matriz.GetLength(1); ++j)
                {
                    sumaDefilas += matriz[i, j];
                    guardarColumna[j] += matriz[i, j];
                }
                guardarFila[i] = sumaDefilas;
            }

            resultadoDeSumarFilasyColumnas(guardarFila, guardarColumna);
        }

        public void resultadoDeSumarFilasyColumnas(double[] guardarFila, double[] guardarColumnas)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("      Suma de las filas    ");
            Console.WriteLine("---------------------------");
            for (int i = 0; i < guardarFila.Length; ++i)
            {
                Console.WriteLine($"Resultado de la fila {i + 1} es {guardarFila[i]}");
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine("      Suma de las columnas ");
            Console.WriteLine("---------------------------");
            for (int i = 0; i < guardarColumnas.Length; ++i)
            {
                Console.WriteLine($"Resultado de la columna {i + 1} es {guardarColumnas[i]}");
            }
            promedio(guardarFila, guardarColumnas);
        }

        public void promedio(double[] guardarFila, double[] guardarColumnas)
        {
            double[] guardarPromediosFila = new double[guardarFila.Length];
            double[] guardarPromediosColumna = new double[guardarColumnas.Length];

            // Calcular promedio de filas
            for (int i = 0; i < guardarFila.Length; ++i)
            {
                guardarPromediosFila[i] = guardarFila[i] / guardarFila.Length;
            }

            // Calcular promedio de columnas
            for (int i = 0; i < guardarColumnas.Length; ++i)
            {
                guardarPromediosColumna[i] = guardarColumnas[i] / guardarColumnas.Length;
            }

            mostrarPromedio(guardarPromediosFila, guardarPromediosColumna);
        }

        public void mostrarPromedio(double[] promedioFila, double[] promedioColumna)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("      Promedio de filas    ");
            Console.WriteLine("---------------------------");
            for (int i = 0; i < promedioFila.Length; ++i)
            {
                Console.WriteLine($"Promedio de la fila {i + 1} es {promedioFila[i]}");
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine("      Promedio de columnas ");
            Console.WriteLine("---------------------------");
            for (int i = 0; i < promedioColumna.Length; ++i)
            {
                Console.WriteLine($"Promedio de la columna {i + 1} es {promedioColumna[i]}");
            }
        }
    }

    }
}
