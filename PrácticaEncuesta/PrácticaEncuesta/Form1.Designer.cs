namespace PrácticaEncuesta
{
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
        	this.label1 = new System.Windows.Forms.Label();
        	this.estados = new System.Windows.Forms.NumericUpDown();
        	this.label2 = new System.Windows.Forms.Label();
        	this.nombre = new System.Windows.Forms.TextBox();
        	this.codigo = new System.Windows.Forms.TextBox();
        	this.label3 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label5 = new System.Windows.Forms.Label();
        	this.label6 = new System.Windows.Forms.Label();
        	this.enviar = new System.Windows.Forms.Button();
        	this.portugal = new System.Windows.Forms.CheckBox();
        	this.df = new System.Windows.Forms.RadioButton();
        	this.mty = new System.Windows.Forms.RadioButton();
        	this.gdl = new System.Windows.Forms.RadioButton();
        	this.chile = new System.Windows.Forms.CheckBox();
        	this.macedonia = new System.Windows.Forms.CheckBox();
        	this.reinoUnido = new System.Windows.Forms.CheckBox();
        	this.australia = new System.Windows.Forms.CheckBox();
        	this.calendario = new System.Windows.Forms.MonthCalendar();
        	this.nota = new System.Windows.Forms.Label();
        	((System.ComponentModel.ISupportInitialize)(this.estados)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.ForeColor = System.Drawing.Color.Black;
        	this.label1.Location = new System.Drawing.Point(302, 5);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(55, 16);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Código:";
        	// 
        	// estados
        	// 
        	this.estados.Location = new System.Drawing.Point(24, 297);
        	this.estados.Name = "estados";
        	this.estados.Size = new System.Drawing.Size(82, 20);
        	this.estados.TabIndex = 1;
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.ForeColor = System.Drawing.Color.Black;
        	this.label2.Location = new System.Drawing.Point(302, 49);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(60, 16);
        	this.label2.TabIndex = 0;
        	this.label2.Text = "Nombre:";
        	// 
        	// nombre
        	// 
        	this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.nombre.Location = new System.Drawing.Point(302, 24);
        	this.nombre.Name = "nombre";
        	this.nombre.Size = new System.Drawing.Size(148, 20);
        	this.nombre.TabIndex = 2;
        	// 
        	// codigo
        	// 
        	this.codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.codigo.Location = new System.Drawing.Point(302, 68);
        	this.codigo.Name = "codigo";
        	this.codigo.Size = new System.Drawing.Size(148, 20);
        	this.codigo.TabIndex = 2;
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.ForeColor = System.Drawing.Color.Black;
        	this.label3.Location = new System.Drawing.Point(12, 86);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(132, 16);
        	this.label3.TabIndex = 0;
        	this.label3.Text = "1- Capital de México:";
        	this.label3.Click += new System.EventHandler(this.Label3Click);
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label4.ForeColor = System.Drawing.Color.Black;
        	this.label4.Location = new System.Drawing.Point(12, 159);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(133, 16);
        	this.label4.TabIndex = 0;
        	this.label4.Text = "2- Paises de Europa:";
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label5.ForeColor = System.Drawing.Color.Black;
        	this.label5.Location = new System.Drawing.Point(12, 260);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(339, 16);
        	this.label5.TabIndex = 0;
        	this.label5.Text = "3- Cantidad de estados en los que se compone México:";
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label6.ForeColor = System.Drawing.Color.Black;
        	this.label6.Location = new System.Drawing.Point(12, 343);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(302, 16);
        	this.label6.TabIndex = 0;
        	this.label6.Text = "4- Día en que terminó la segunda guerra mundial: ";
        	// 
        	// enviar
        	// 
        	this.enviar.BackColor = System.Drawing.Color.Gainsboro;
        	this.enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.enviar.ForeColor = System.Drawing.Color.Black;
        	this.enviar.Location = new System.Drawing.Point(24, 575);
        	this.enviar.Name = "enviar";
        	this.enviar.Size = new System.Drawing.Size(153, 33);
        	this.enviar.TabIndex = 3;
        	this.enviar.Text = "Enviar";
        	this.enviar.UseVisualStyleBackColor = true;
        	this.enviar.Click += new System.EventHandler(this.enviar_Click);
        	// 
        	// portugal
        	// 
        	this.portugal.AutoSize = true;
        	this.portugal.ForeColor = System.Drawing.Color.Black;
        	this.portugal.Location = new System.Drawing.Point(12, 198);
        	this.portugal.Name = "portugal";
        	this.portugal.Size = new System.Drawing.Size(68, 17);
        	this.portugal.TabIndex = 4;
        	this.portugal.Text = "Portugal.";
        	this.portugal.UseVisualStyleBackColor = true;
        	// 
        	// df
        	// 
        	this.df.AutoSize = true;
        	this.df.ForeColor = System.Drawing.Color.Black;
        	this.df.Location = new System.Drawing.Point(12, 116);
        	this.df.Name = "df";
        	this.df.Size = new System.Drawing.Size(95, 17);
        	this.df.TabIndex = 5;
        	this.df.TabStop = true;
        	this.df.Text = "Distrito Federal";
        	this.df.UseVisualStyleBackColor = true;
        	this.df.CheckedChanged += new System.EventHandler(this.DfCheckedChanged);
        	// 
        	// mty
        	// 
        	this.mty.AutoSize = true;
        	this.mty.ForeColor = System.Drawing.Color.Black;
        	this.mty.Location = new System.Drawing.Point(224, 116);
        	this.mty.Name = "mty";
        	this.mty.Size = new System.Drawing.Size(72, 17);
        	this.mty.TabIndex = 5;
        	this.mty.TabStop = true;
        	this.mty.Text = "Monterrey";
        	this.mty.UseVisualStyleBackColor = true;
        	// 
        	// gdl
        	// 
        	this.gdl.AutoSize = true;
        	this.gdl.ForeColor = System.Drawing.Color.Black;
        	this.gdl.Location = new System.Drawing.Point(130, 116);
        	this.gdl.Name = "gdl";
        	this.gdl.Size = new System.Drawing.Size(82, 17);
        	this.gdl.TabIndex = 5;
        	this.gdl.TabStop = true;
        	this.gdl.Text = "Guadalajara";
        	this.gdl.UseVisualStyleBackColor = true;
        	// 
        	// chile
        	// 
        	this.chile.AutoSize = true;
        	this.chile.ForeColor = System.Drawing.Color.Black;
        	this.chile.Location = new System.Drawing.Point(12, 221);
        	this.chile.Name = "chile";
        	this.chile.Size = new System.Drawing.Size(52, 17);
        	this.chile.TabIndex = 4;
        	this.chile.Text = "Chile.";
        	this.chile.UseVisualStyleBackColor = true;
        	// 
        	// macedonia
        	// 
        	this.macedonia.AutoSize = true;
        	this.macedonia.ForeColor = System.Drawing.Color.Black;
        	this.macedonia.Location = new System.Drawing.Point(95, 221);
        	this.macedonia.Name = "macedonia";
        	this.macedonia.Size = new System.Drawing.Size(82, 17);
        	this.macedonia.TabIndex = 4;
        	this.macedonia.Text = "Macedonia.";
        	this.macedonia.UseVisualStyleBackColor = true;
        	// 
        	// reinoUnido
        	// 
        	this.reinoUnido.AutoSize = true;
        	this.reinoUnido.ForeColor = System.Drawing.Color.Black;
        	this.reinoUnido.Location = new System.Drawing.Point(95, 198);
        	this.reinoUnido.Name = "reinoUnido";
        	this.reinoUnido.Size = new System.Drawing.Size(88, 17);
        	this.reinoUnido.TabIndex = 4;
        	this.reinoUnido.Text = "Reino Unido.";
        	this.reinoUnido.UseVisualStyleBackColor = true;
        	// 
        	// australia
        	// 
        	this.australia.AutoSize = true;
        	this.australia.ForeColor = System.Drawing.Color.Black;
        	this.australia.Location = new System.Drawing.Point(189, 198);
        	this.australia.Name = "australia";
        	this.australia.Size = new System.Drawing.Size(69, 17);
        	this.australia.TabIndex = 4;
        	this.australia.Text = "Australia.";
        	this.australia.UseVisualStyleBackColor = true;
        	// 
        	// calendario
        	// 
        	this.calendario.Location = new System.Drawing.Point(24, 368);
        	this.calendario.Name = "calendario";
        	this.calendario.TabIndex = 6;
        	// 
        	// nota
        	// 
        	this.nota.AutoSize = true;
        	this.nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.nota.ForeColor = System.Drawing.Color.DarkBlue;
        	this.nota.Location = new System.Drawing.Point(24, 12);
        	this.nota.Name = "nota";
        	this.nota.Size = new System.Drawing.Size(0, 20);
        	this.nota.TabIndex = 0;
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.Gainsboro;
        	this.ClientSize = new System.Drawing.Size(462, 620);
        	this.Controls.Add(this.calendario);
        	this.Controls.Add(this.gdl);
        	this.Controls.Add(this.mty);
        	this.Controls.Add(this.df);
        	this.Controls.Add(this.australia);
        	this.Controls.Add(this.macedonia);
        	this.Controls.Add(this.reinoUnido);
        	this.Controls.Add(this.chile);
        	this.Controls.Add(this.portugal);
        	this.Controls.Add(this.enviar);
        	this.Controls.Add(this.codigo);
        	this.Controls.Add(this.nombre);
        	this.Controls.Add(this.estados);
        	this.Controls.Add(this.label6);
        	this.Controls.Add(this.label5);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.nota);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.ForeColor = System.Drawing.Color.White;
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        	this.Name = "Form1";
        	this.Text = "Encuesta";
        	((System.ComponentModel.ISupportInitialize)(this.estados)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown estados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.CheckBox portugal;
        private System.Windows.Forms.RadioButton df;
        private System.Windows.Forms.RadioButton mty;
        private System.Windows.Forms.RadioButton gdl;
        private System.Windows.Forms.CheckBox chile;
        private System.Windows.Forms.CheckBox macedonia;
        private System.Windows.Forms.CheckBox reinoUnido;
        private System.Windows.Forms.CheckBox australia;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Label nota;
    }
}

