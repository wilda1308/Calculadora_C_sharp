namespace Calculadora2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnSigno = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnRaizCuadrada = new System.Windows.Forms.Button();
            this.btnElevadoCuadrado = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.SystemColors.Window;
            this.txtResultado.Location = new System.Drawing.Point(5, 70);
            this.txtResultado.MaxLength = 21;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(584, 61);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSigno
            // 
            this.btnSigno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSigno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSigno.Font = new System.Drawing.Font("Microsoft Yi Baiti", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSigno.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSigno.Location = new System.Drawing.Point(3, 505);
            this.btnSigno.Name = "btnSigno";
            this.btnSigno.Size = new System.Drawing.Size(142, 65);
            this.btnSigno.TabIndex = 2;
            this.btnSigno.Text = "+/-";
            this.btnSigno.UseVisualStyleBackColor = false;
            this.btnSigno.Click += new System.EventHandler(this.btnSigno_Click);
            // 
            // btnCero
            // 
            this.btnCero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCero.Font = new System.Drawing.Font("Microsoft Yi Baiti", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCero.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCero.Location = new System.Drawing.Point(151, 505);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(142, 65);
            this.btnCero.TabIndex = 3;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = false;
            this.btnCero.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnPunto
            // 
            this.btnPunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPunto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPunto.Font = new System.Drawing.Font("Microsoft Yi Baiti", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPunto.Location = new System.Drawing.Point(299, 505);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(142, 65);
            this.btnPunto.TabIndex = 4;
            this.btnPunto.Text = ",";
            this.btnPunto.UseVisualStyleBackColor = false;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIgual.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.Color.Black;
            this.btnIgual.Location = new System.Drawing.Point(447, 505);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(142, 65);
            this.btnIgual.TabIndex = 5;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Yi Baiti", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSuma.Location = new System.Drawing.Point(447, 434);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(142, 65);
            this.btnSuma.TabIndex = 9;
            this.btnSuma.Tag = "+";
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnTres
            // 
            this.btnTres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTres.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTres.Font = new System.Drawing.Font("Microsoft Yi Baiti", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTres.Location = new System.Drawing.Point(299, 434);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(142, 65);
            this.btnTres.TabIndex = 8;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnDos
            // 
            this.btnDos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDos.Font = new System.Drawing.Font("Microsoft Yi Baiti", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDos.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDos.Location = new System.Drawing.Point(151, 434);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(142, 65);
            this.btnDos.TabIndex = 7;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = false;
            this.btnDos.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnUno
            // 
            this.btnUno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUno.Font = new System.Drawing.Font("Microsoft Yi Baiti", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUno.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUno.Location = new System.Drawing.Point(3, 434);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(142, 65);
            this.btnUno.TabIndex = 6;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = false;
            this.btnUno.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnResta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResta.Font = new System.Drawing.Font("Microsoft Yi Baiti", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.ForeColor = System.Drawing.SystemColors.Window;
            this.btnResta.Location = new System.Drawing.Point(447, 363);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(142, 65);
            this.btnResta.TabIndex = 13;
            this.btnResta.Tag = "-";
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnSeis
            // 
            this.btnSeis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSeis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeis.Font = new System.Drawing.Font("Microsoft Yi Baiti", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSeis.Location = new System.Drawing.Point(299, 363);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(142, 65);
            this.btnSeis.TabIndex = 12;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnCinco
            // 
            this.btnCinco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCinco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCinco.Font = new System.Drawing.Font("Microsoft Yi Baiti", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCinco.Location = new System.Drawing.Point(151, 363);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(142, 65);
            this.btnCinco.TabIndex = 11;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnCuatro
            // 
            this.btnCuatro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCuatro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCuatro.Font = new System.Drawing.Font("Microsoft Yi Baiti", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuatro.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCuatro.Location = new System.Drawing.Point(3, 363);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(142, 65);
            this.btnCuatro.TabIndex = 10;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = false;
            this.btnCuatro.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMultiplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiplicacion.Font = new System.Drawing.Font("Microsoft Yi Baiti", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMultiplicacion.Location = new System.Drawing.Point(447, 292);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(142, 65);
            this.btnMultiplicacion.TabIndex = 17;
            this.btnMultiplicacion.Tag = "X";
            this.btnMultiplicacion.Text = "X";
            this.btnMultiplicacion.UseVisualStyleBackColor = false;
            this.btnMultiplicacion.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnNueve
            // 
            this.btnNueve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNueve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNueve.Font = new System.Drawing.Font("Microsoft Yi Baiti", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueve.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNueve.Location = new System.Drawing.Point(299, 292);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(142, 65);
            this.btnNueve.TabIndex = 16;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = false;
            this.btnNueve.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnOcho
            // 
            this.btnOcho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOcho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOcho.Font = new System.Drawing.Font("Microsoft Yi Baiti", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcho.ForeColor = System.Drawing.SystemColors.Window;
            this.btnOcho.Location = new System.Drawing.Point(151, 292);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(142, 65);
            this.btnOcho.TabIndex = 15;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = false;
            this.btnOcho.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnSiete
            // 
            this.btnSiete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSiete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiete.Font = new System.Drawing.Font("Microsoft Yi Baiti", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSiete.Location = new System.Drawing.Point(3, 292);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(142, 65);
            this.btnSiete.TabIndex = 14;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = false;
            this.btnSiete.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Yi Baiti", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDivision.Location = new System.Drawing.Point(447, 221);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(142, 65);
            this.btnDivision.TabIndex = 21;
            this.btnDivision.Tag = "/";
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnRaizCuadrada
            // 
            this.btnRaizCuadrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRaizCuadrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRaizCuadrada.Font = new System.Drawing.Font("Microsoft Yi Baiti", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaizCuadrada.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRaizCuadrada.Location = new System.Drawing.Point(299, 221);
            this.btnRaizCuadrada.Name = "btnRaizCuadrada";
            this.btnRaizCuadrada.Size = new System.Drawing.Size(142, 65);
            this.btnRaizCuadrada.TabIndex = 20;
            this.btnRaizCuadrada.Tag = "√";
            this.btnRaizCuadrada.Text = "√";
            this.btnRaizCuadrada.UseVisualStyleBackColor = false;
            this.btnRaizCuadrada.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnElevadoCuadrado
            // 
            this.btnElevadoCuadrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnElevadoCuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElevadoCuadrado.Font = new System.Drawing.Font("Microsoft Yi Baiti", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElevadoCuadrado.ForeColor = System.Drawing.SystemColors.Window;
            this.btnElevadoCuadrado.Location = new System.Drawing.Point(151, 221);
            this.btnElevadoCuadrado.Name = "btnElevadoCuadrado";
            this.btnElevadoCuadrado.Size = new System.Drawing.Size(142, 65);
            this.btnElevadoCuadrado.TabIndex = 19;
            this.btnElevadoCuadrado.Tag = "²";
            this.btnElevadoCuadrado.Text = "x²";
            this.btnElevadoCuadrado.UseVisualStyleBackColor = false;
            this.btnElevadoCuadrado.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Yi Baiti", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBorrar.Location = new System.Drawing.Point(3, 221);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(142, 65);
            this.btnBorrar.TabIndex = 18;
            this.btnBorrar.Text = "CE";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Yi Baiti", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnQuitar.Location = new System.Drawing.Point(447, 150);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(142, 65);
            this.btnQuitar.TabIndex = 23;
            this.btnQuitar.Text = "<-";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBorrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrarTodo.Font = new System.Drawing.Font("Microsoft Yi Baiti", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarTodo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBorrarTodo.Location = new System.Drawing.Point(299, 150);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(142, 65);
            this.btnBorrarTodo.TabIndex = 22;
            this.btnBorrarTodo.Text = "C";
            this.btnBorrarTodo.UseVisualStyleBackColor = false;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(594, 582);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnBorrarTodo);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnRaizCuadrada);
            this.Controls.Add(this.btnElevadoCuadrado);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnSigno);
            this.Controls.Add(this.txtResultado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnSigno;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnRaizCuadrada;
        private System.Windows.Forms.Button btnElevadoCuadrado;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnBorrarTodo;
    }
}

