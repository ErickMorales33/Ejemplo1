namespace actividades
{
    partial class FormEstudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textoControl = new System.Windows.Forms.TextBox();
            this.textoNombre = new System.Windows.Forms.TextBox();
            this.textoEdad = new System.Windows.Forms.TextBox();
            this.textoGenero = new System.Windows.Forms.TextBox();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F);
            this.label2.Location = new System.Drawing.Point(43, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "No. Control";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F);
            this.label5.Location = new System.Drawing.Point(52, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Género";
            // 
            // textoControl
            // 
            this.textoControl.Location = new System.Drawing.Point(174, 107);
            this.textoControl.Name = "textoControl";
            this.textoControl.Size = new System.Drawing.Size(179, 20);
            this.textoControl.TabIndex = 5;
            // 
            // textoNombre
            // 
            this.textoNombre.Location = new System.Drawing.Point(174, 156);
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.Size = new System.Drawing.Size(179, 20);
            this.textoNombre.TabIndex = 6;
            // 
            // textoEdad
            // 
            this.textoEdad.Location = new System.Drawing.Point(174, 202);
            this.textoEdad.Name = "textoEdad";
            this.textoEdad.Size = new System.Drawing.Size(179, 20);
            this.textoEdad.TabIndex = 7;
            // 
            // textoGenero
            // 
            this.textoGenero.Location = new System.Drawing.Point(174, 251);
            this.textoGenero.Name = "textoGenero";
            this.textoGenero.Size = new System.Drawing.Size(179, 20);
            this.textoGenero.TabIndex = 8;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonMostrar.ForeColor = System.Drawing.Color.Khaki;
            this.buttonMostrar.Location = new System.Drawing.Point(300, 278);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(75, 23);
            this.buttonMostrar.TabIndex = 9;
            this.buttonMostrar.Text = "Mostrar";
            this.buttonMostrar.UseVisualStyleBackColor = false;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // FormEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(440, 313);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.textoGenero);
            this.Controls.Add(this.textoEdad);
            this.Controls.Add(this.textoNombre);
            this.Controls.Add(this.textoControl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEstudiante";
            this.Text = "Datos del estudiante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textoControl;
        private System.Windows.Forms.TextBox textoNombre;
        private System.Windows.Forms.TextBox textoEdad;
        private System.Windows.Forms.TextBox textoGenero;
        private System.Windows.Forms.Button buttonMostrar;
    }
}

