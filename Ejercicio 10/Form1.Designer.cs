namespace Ejercicio_10;

partial class Form1
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
    private Label verificarCuadroMagico;
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

        verificarCuadroMagico = new System.Windows.Forms.Label();
        verificarCuadroMagico.Size = new System.Drawing.Size(190, 80);
        verificarCuadroMagico.Location = new System.Drawing.Point(350, 10);
        this.Controls.Add(verificarCuadroMagico);

    }

    private void CalculosOperativos(object sender, EventArgs e){
        ejemplosProfa profa = new ejemplosProfa();
        profa.MostrarMatriz(mostrarMatriz);
        profa.VerificarCuadroMagico(verificarCuadroMagico);
    }
    class ejemplosProfa{
        private int[,] numeros;
        public ejemplosProfa()
        {
            numeros = new int[,] { { 4, 9, 2 }, { 3, 5, 7 }, { 8, 1, 6 } };
        }

        public void MostrarMatriz(Label mostrarMatriz)
        {
            Console.WriteLine("Matriz de ejemplo:");
            for (int i = 0; i < numeros.GetLength(0); ++i)
            {
                for (int j = 0; j < numeros.GetLength(1); ++j)
                {
                    mostrarMatriz.Text += numeros[i, j] + " ";
                }
                mostrarMatriz.Text += "\n";
            }
        }
        
        public void VerificarCuadroMagico(Label verificarCuadroMagico)
        {
            int n = numeros.GetLength(0);

            // Calcular la suma de la primera fila para obtener la constante mágica
            int constanteMagica = 0;
            for (int j = 0; j < n; ++j)
            {
                constanteMagica += numeros[0, j];
            }

            // Verificar las sumas de filas
            for (int i = 1; i < n; ++i)
            {
                int sumaFila = 0;
                for (int j = 0; j < n; ++j)
                {
                    sumaFila += numeros[i, j];
                }
                if (sumaFila != constanteMagica)
                {
                    verificarCuadroMagico.Text = "No es un cuadro mágico.";
                    return;
                }
            }

            // Verificar las sumas de columnas
            for (int j = 0; j < n; ++j)
            {
                int sumaColumna = 0;
                for (int i = 0; i < n; ++i)
                {
                    sumaColumna += numeros[i, j];
                }
                if (sumaColumna != constanteMagica)
                {
                    verificarCuadroMagico.Text = "No es un cuadro mágico.";
                    return;
                }
            }

            // Verificar la suma de la diagonal principal
            int sumaDiagonalPrincipal = 0;
            for (int i = 0; i < n; ++i)
            {
                sumaDiagonalPrincipal += numeros[i, i];
            }

            if (sumaDiagonalPrincipal != constanteMagica)
            {
                verificarCuadroMagico.Text = "No es un cuadro mágico.";
                return;
            }

            // Verificar la suma de la diagonal secundaria
            int sumaDiagonalSecundaria = 0;
            for (int i = 0; i < n; ++i)
            {
                sumaDiagonalSecundaria += numeros[i, n - i - 1];
            }

            if (sumaDiagonalSecundaria != constanteMagica)
            {
                verificarCuadroMagico.Text = "No es un cuadro mágico.";
                return;
            }

            // Si pasó todas las verificaciones, es un cuadro mágico
            verificarCuadroMagico.Text = $"Es un cuadro mágico con constante mágica {constanteMagica}";
        }

    }
    

    #endregion
}
