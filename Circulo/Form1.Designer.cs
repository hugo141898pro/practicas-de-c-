namespace programa;
using System;
partial class Form1
{

    private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label ejercicio10;
        private System.Windows.Forms.TextBox txtNumer;
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
    private void InitializeComponentCirculo()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1200, 450);
        this.Text = "ejercicio 10";

        ejercicio10 = new System.Windows.Forms.Label();
        ejercicio10.Text = "tamaño";
        ejercicio10.Location = new System.Drawing.Point(300, 50);
        this.Controls.Add(ejercicio10);

        ejercicio10 = new System.Windows.Forms.Label();
        ejercicio10.Text = "numeros";
        ejercicio10.Location = new System.Drawing.Point(600, 50);
        this.Controls.Add(ejercicio10);


        txtNumer = new System.Windows.Forms.TextBox();
        txtNumer.Location = new System.Drawing.Point(300, 80);
        txtNumer.Size = new System.Drawing.Size(200, 40);
        this.Controls.Add(txtNumer);

        txtNumer = new System.Windows.Forms.TextBox();
        txtNumer.Location = new System.Drawing.Point(600, 80);
        txtNumer.Size = new System.Drawing.Size(200, 40);
        this.Controls.Add(txtNumer);

        btnCalcular = new System.Windows.Forms.Button();
        btnCalcular.Text = "Verificar";
        btnCalcular.Location = new System.Drawing.Point(200, 130);
        btnCalcular.Size = new System.Drawing.Size(400, 30);

        btnCalcular.Click += datos_Click;
        this.Controls.Add(btnCalcular);

        lblResultado = new System.Windows.Forms.Label();
        lblResultado.Location = new System.Drawing.Point(200, 160);
        lblResultado.Size = new System.Drawing.Size(400, 30);
        this.Controls.Add(lblResultado);

    }
    #endregion
    static private void datos_Click(object sender, EventArgs e){
        propiosNumeros propios = new propiosNumeros();
        propios.verificarDatos();
    }
    class propiosNumeros(){
        static public void verificarDatos(){
            
        }
    }
}
