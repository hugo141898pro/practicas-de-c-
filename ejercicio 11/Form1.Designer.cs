namespace ejercicio_11;

partial class Form1 : Form
{

    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private Button calcular;
    private Label mostrarMatriz;
    private Label sumaDeFila;
    private Label sumaDeColumna;
    private Label promedioDeFila;
    private Label promedioDeColumnaDato;

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";

        calcular = new System.Windows.Forms.Button();
        calcular.Text = "Calcular";
        calcular.Size = new System.Drawing.Size(90, 90);
        calcular.Location = new System.Drawing.Point(20,50);
        this.Controls.Add(calcular);
        calcular.Click += CalculosOperativos;

        mostrarMatriz = new System.Windows.Forms.Label();
        mostrarMatriz.Size = new System.Drawing.Size(165, 500);
        mostrarMatriz.Location = new System.Drawing.Point(150, 10);
        this.Controls.Add(mostrarMatriz);

        sumaDeFila = new System.Windows.Forms.Label();
        sumaDeFila.Size = new System.Drawing.Size(190, 80);
        sumaDeFila.Location = new System.Drawing.Point(350, 10);
        this.Controls.Add(sumaDeFila);

        sumaDeColumna = new System.Windows.Forms.Label();
        sumaDeColumna.Size = new System.Drawing.Size(200, 200);
        sumaDeColumna.Location = new System.Drawing.Point(550, 10);
        this.Controls.Add(sumaDeColumna);

        promedioDeFila = new System.Windows.Forms.Label();
        promedioDeFila.Size = new System.Drawing.Size(200,  250);
        promedioDeFila.Location = new System.Drawing.Point(350, 150);
        this.Controls.Add(promedioDeFila);

        promedioDeColumnaDato = new System.Windows.Forms.Label();
        promedioDeColumnaDato.Size = new System.Drawing.Size(200,  250);
        promedioDeColumnaDato.Location = new System.Drawing.Point(550, 300);
        this.Controls.Add(promedioDeColumnaDato);


    }

    private void CalculosOperativos(object sender, EventArgs e){        
        double[,] matriz = new double[5, 10];
        double[] guardarFila = new double[matriz.GetLength(0)];
        double[] guardarColumna = new double[matriz.GetLength(1)];
        double[] guardarPromediosFila = new double[guardarFila.Length];
        double[] guardarPromediosColumna = new double[guardarColumna.Length];

        Logica logica = new Logica();
        logica.rellenarMatriz(matriz, mostrarMatriz);
        logica.mostrarMatriz(matriz, mostrarMatriz);
        logica.sumarDato(matriz, guardarFila, guardarColumna);
        logica.resultadoDeSumarFilasyColumnas(guardarFila, guardarColumna, sumaDeFila, sumaDeColumna);
        logica.promedio(guardarFila, guardarColumna, guardarPromediosFila, guardarPromediosColumna);
        logica.mostrarPromedio(guardarPromediosFila, guardarPromediosColumna, promedioDeFila, promedioDeColumnaDato);
    }

    class Logica
    {
    public void rellenarMatriz(double[,] matriz, Label mostrarMatriz)
    {
        Random random = new Random();
        for (int i = 0; i < matriz.GetLength(0); ++i)
        {
            for (int j = 0; j < matriz.GetLength(1); ++j)
            {
                matriz[i, j] = random.Next(1, 101);
            }
        }
    }
    public void mostrarMatriz(double[,] matriz, Label mostrarMatriz)
    {
        mostrarMatriz.Text = "";
            for (int i = 0; i < matriz.GetLength(0); ++i)
            {
                for (int j = 0; j < matriz.GetLength(1); ++j)
                {
                    mostrarMatriz.Text += matriz[i, j] + " ";
                }
                mostrarMatriz.Text += "\n";
            }
    }
    public void sumarDato(double[,] matriz, double[] guardarFila, double[] guardarColumna){

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
    }

    public void resultadoDeSumarFilasyColumnas(double[] guardarFila, double[] guardarColumnas, Label sumaDeFilas, Label sumaDeColumna){

            for (int i = 0; i < guardarFila.Length; ++i)
            {
                sumaDeFilas.Text += $" Resultado de la fila {i + 1} es: {guardarFila[i]}";
            }


            for (int i = 0; i < guardarColumnas.Length; ++i)
            {
                sumaDeColumna.Text += $" Resultado de la columna {i + 1} es: {guardarColumnas[i]}";
            }
    }
    public void promedio(double[] guardarFila, double[] guardarColumnas, double[] guardarPromediosFila, double[] guardarPromediosColumna)
        {

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
        }
        public void mostrarPromedio(double[] promedioFila, double[] promedioColumna, Label promedioDeFila, Label promedioDeColumnaDato)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("      Promedio de filas    ");
            Console.WriteLine("---------------------------");
            for (int i = 0; i < promedioFila.Length; ++i)
            {
                promedioDeFila.Text += $"Promedio de la fila {i + 1} es {promedioFila[i]}";
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine("      Promedio de columnas ");
            Console.WriteLine("---------------------------");
            for (int i = 0; i < promedioColumna.Length; ++i)
            {
                promedioDeColumnaDato.Text += $"Promedio de la columna {i + 1} es {promedioColumna[i]}";
            }
        }
    
    }
    #endregion
}
