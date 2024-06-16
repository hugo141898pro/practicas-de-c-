namespace Triangulo;

partial class Form1
{

    private System.ComponentModel.IContainer components = null;

    /*perimetro*/
    private System.Windows.Forms.Label perimetro;
    private System.Windows.Forms.Label text1;
    private System.Windows.Forms.Label text2;
    private System.Windows.Forms.Label text3;
    private System.Windows.Forms.TextBox lado1;
    private System.Windows.Forms.TextBox lado2;
    private System.Windows.Forms.TextBox lado3;
    private System.Windows.Forms.Button Calcular1;
    private System.Windows.Forms.Label resultado1;

    /*area*/
    private System.Windows.Forms.Label area;
    private System.Windows.Forms.Label tipoBase;
    private System.Windows.Forms.TextBox textbase;
    private System.Windows.Forms.Label altura;
    private System.Windows.Forms.TextBox Altura;
    private System.Windows.Forms.Button Calcular2;
    private System.Windows.Forms.Label resultado2;
    


    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponentTriangulo()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Triangulo";

        /*perimetro*/

        perimetro = new System.Windows.Forms.Label();
        perimetro.Text = "Perimetro";
        perimetro.Location = new System.Drawing.Point(100, 10);
        this.Controls.Add(perimetro);

        text1 = new System.Windows.Forms.Label();
        text1.Text = "lado 1";
        text1.Location = new System.Drawing.Point(100, 50);
        this.Controls.Add(text1);

        lado1 = new System.Windows.Forms.TextBox();
        lado1.Location = new System.Drawing.Point(100, 90);
        lado1.Size = new System.Drawing.Size(100, 50);
        this.Controls.Add(lado1);

        text2 = new System.Windows.Forms.Label();
        text2.Text = "lado 2";
        text2.Location = new System.Drawing.Point(250, 50);
        this.Controls.Add(text2);

        lado2 = new System.Windows.Forms.TextBox();
        lado2.Location = new System.Drawing.Point(250, 90);
        lado2.Size = new System.Drawing.Size(100, 50);
        this.Controls.Add(lado2);

        text3 = new System.Windows.Forms.Label();
        text3.Text = "lado 3";
        text3.Location = new System.Drawing.Point(390, 50);
        this.Controls.Add(text3);
        
        lado3 = new System.Windows.Forms.TextBox();
        lado3.Location = new System.Drawing.Point(390, 90);
        lado3.Size = new System.Drawing.Size(100, 50);
        this.Controls.Add(lado3);

        Calcular1 = new System.Windows.Forms.Button();
        Calcular1.Text = "Calcular";
        Calcular1.Location = new System.Drawing.Point(100, 150);
        Calcular1.Size = new System.Drawing.Size(70, 40);
        this.Controls.Add(Calcular1);
        Calcular1.Click += CalculoDePerimetro_Click;

        resultado1 = new System.Windows.Forms.Label();
        resultado1.Location = new System.Drawing.Point(100, 200);
        resultado1.Size = new System.Drawing.Size(100, 60);
        this.Controls.Add(resultado1);


        area = new System.Windows.Forms.Label();
        area.Text = "Area";
        area.Location = new System.Drawing.Point(100, 300);
        this.Controls.Add(area);

        tipoBase = new System.Windows.Forms.Label();
        tipoBase.Text = "Base";
        tipoBase.Location = new System.Drawing.Point(100, 350);
        this.Controls.Add(tipoBase);

        textbase = new System.Windows.Forms.TextBox();
        textbase.Location = new System.Drawing.Point(100, 390);
        this.Controls.Add(textbase);

        altura = new System.Windows.Forms.Label();
        altura.Text = "Altura";
        altura.Location = new System.Drawing.Point(200, 350);
        this.Controls.Add(altura);

        Altura = new System.Windows.Forms.TextBox();
        Altura.Location = new System.Drawing.Point(200, 390);
        this.Controls.Add(Altura);

        Calcular2 = new System.Windows.Forms.Button();
        Calcular2.Text = "Calcular";
        Calcular2.Location = new System.Drawing.Point(100, 460);
        this.Controls.Add(Calcular2);
        Calcular2.Click += CalculoDeArea_Click;

        resultado2 = new System.Windows.Forms.Label();
        resultado2.Location = new System.Drawing.Point(100, 510);
        resultado1.Size = new System.Drawing.Size(70, 30);
        this.Controls.Add(resultado2);
    }

    #endregion
    private void CalculoDePerimetro_Click(object sender, EventArgs e)
    {
        if(double.TryParse(lado1.Text, out double ladoUno) && double.TryParse(lado2.Text, out double ladoDos) && double.TryParse(lado3.Text, out double ladoTres))
        {
            double perimetro = ladoUno + ladoDos + ladoTres;
            resultado1.Text = $"perimetro: {perimetro}";
        } 
        else 
        {
            resultado1.Text = "ingrese un dato valido";
        }
    }

    private void CalculoDeArea_Click(object sender, EventArgs e)
    {
        if(double.TryParse(textbase.Text, out double tbase) && double.TryParse(Altura.Text, out double datoAltura))
        {
            double area = (tbase * datoAltura) / 2;
            resultado2.Text = $"El area es: {area}";
        } else {
            resultado2.Text = "ingrese un dato valido";
        }
    } 
}
