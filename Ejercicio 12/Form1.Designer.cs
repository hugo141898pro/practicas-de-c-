namespace Ejercicio_12;

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
    private Label imprimirVentas;
    private Label menorVenta;
    private Label mayorVenta;
    private Label ventaTotal;
    private Label ventaPorDia;
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

        imprimirVentas = new System.Windows.Forms.Label();
        imprimirVentas.Size = new System.Drawing.Size(165, 500);
        imprimirVentas.Location = new System.Drawing.Point(150, 10);
        this.Controls.Add(imprimirVentas);

        menorVenta = new System.Windows.Forms.Label();
        menorVenta.Size = new System.Drawing.Size(190, 80);
        menorVenta.Location = new System.Drawing.Point(350, 10);
        this.Controls.Add(menorVenta);

        mayorVenta = new System.Windows.Forms.Label();
        mayorVenta.Size = new System.Drawing.Size(200, 100);
        mayorVenta.Location = new System.Drawing.Point(550, 10);
        this.Controls.Add(mayorVenta);

        ventaTotal = new System.Windows.Forms.Label();
        ventaTotal.Size = new System.Drawing.Size(200,  250);
        ventaTotal.Location = new System.Drawing.Point(350, 150);
        this.Controls.Add(ventaTotal);

        ventaPorDia = new System.Windows.Forms.Label();
        ventaPorDia.Size = new System.Drawing.Size(260,  250);
        ventaPorDia.Location = new System.Drawing.Point(550, 180);
        this.Controls.Add(ventaPorDia);

    }
    private void CalculosOperativos(object sender, EventArgs e){
        int[,] numeros = new int[,] {
            {5, 16, 10, 12, 24}, 
            {40, 55, 10, 11, 51},
            {15, 41, 78, 14, 51},
            {35, 22, 81, 15, 12},
            {50, 12,71, 10, 20},
            {70, 40, 60, 28, 22},
            {50, 50, 50, 36, 25},
            {40,70, 40, 11, 20},
            {20, 20, 30, 12, 18},
            {10, 40, 32, 13, 16},
            {50, 3, 24, 15, 82},
            {40, 46, 15, 46, 22}
        };
        int numeroMayorParaMenor = 9999;
        int numeroMayorParaMayor = 0;
        string[] dias = {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes"};
        string[] meses = {"Enero", "Febrero", "Marzo", "Abrir", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
        ventasResumen venta = new ventasResumen();
        venta.imprimirDatos(numeros, imprimirVentas);
        venta.menorYmayor(ref numeroMayorParaMenor, ref numeroMayorParaMayor ,numeros);
        venta.ImprimirMayorMenor(numeroMayorParaMenor, numeroMayorParaMayor, numeros, dias, meses, menorVenta, mayorVenta);
        venta.VentaTotal(numeros, ventaTotal);
        venta.imprimirVentaPordia(numeros, ventaPorDia);
    }
    class ventasResumen{
        public void imprimirDatos(int[,] numeros, Label imprimirVenta){

            for(int i = 0; i < numeros.GetLength(0); ++i){
                for(int j = 0; j < numeros.GetLength(1); ++j){
                    imprimirVenta.Text += numeros[i, j] + " ";
                }

            }

        }
        public void menorYmayor(ref int numeroMayorParaMenor, ref int numeroMayorParaMayor, int[,] numeros){
            for(int i = 0; i < numeros.GetLength(0); ++i){
                for(int j = 0; j < numeros.GetLength(1); ++j){
                    if(numeros[i, j] < numeroMayorParaMenor){
                        numeroMayorParaMenor = numeros[i, j];
                    }
                    if(numeros[i, j] > numeroMayorParaMayor){
                        numeroMayorParaMayor = numeros[i, j];
                    }
                }
            }
        }

        public void ImprimirMayorMenor(int menor, int mayor, int[,] numeros, string[] dias, string[] meses, Label menorVenta, Label mayorVenta){


            for(int i = 0; i < numeros.GetLength(0); ++i){
                for(int j = 0; j < numeros.GetLength(1); ++j){
                    if(numeros[i, j] == menor){
                        menorVenta.Text += $"La menor venta fue {menor} del el dia {dias[j]} del mes {meses[i]}";
                    }
                    if(numeros[i, j] == mayor){
                        mayorVenta.Text += $"La mayor venta fue {mayor} del el dia {dias[j]} del mes {meses[i]}";
                    }
                    
                }
            }
        }
        public void VentaTotal(int[,] numeros, Label ventaTotal){
            int IndiceSuma = 0;
            Console.WriteLine("--------------------");
            Console.WriteLine("     venta total    ");
            Console.WriteLine("--------------------");
            for(int i = 0; i < numeros.GetLength(0); ++i){
                for(int j = 0; j < numeros.GetLength(1); ++j){
                    IndiceSuma += numeros[i, j];
                }
            }
            ventaTotal.Text = $"La venta total fue de: ${IndiceSuma}";
        }
        public void imprimirVentaPordia(int[,] numeros, Label ventaPorDia){
            string[] dias = {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes"};
            int[] ventasPorDias = new int[numeros.GetLength(1)];
            Console.WriteLine("--------------------");
            Console.WriteLine("   venta por dias   ");
            Console.WriteLine("--------------------");
            for(int j = 0; j < numeros.GetLength(1); ++j){
                for(int i = 0; i < numeros.GetLength(0); ++i){
                    ventasPorDias[j] += numeros[i, j];
                }
            }

            Console.WriteLine("Las ventas por dias de la semana");
            for(int i = 0; i < ventasPorDias.Length; ++i){
                ventaPorDia.Text += $"{dias[i]}: ${ventasPorDias[i]}.00";
            }
        }
    }

    #endregion
}
