namespace SimonDice_C_
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
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.lbl_puntaje = new System.Windows.Forms.Label();
            this.p_3 = new System.Windows.Forms.PictureBox();
            this.p_2 = new System.Windows.Forms.PictureBox();
            this.p_1 = new System.Windows.Forms.PictureBox();
            this.p_0 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_0)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar.Location = new System.Drawing.Point(74, 678);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(435, 73);
            this.btn_iniciar.TabIndex = 4;
            this.btn_iniciar.Text = "Iniciar_Juego";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // lbl_puntaje
            // 
            this.lbl_puntaje.AutoSize = true;
            this.lbl_puntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_puntaje.Location = new System.Drawing.Point(305, 29);
            this.lbl_puntaje.Name = "lbl_puntaje";
            this.lbl_puntaje.Size = new System.Drawing.Size(48, 48);
            this.lbl_puntaje.TabIndex = 5;
            this.lbl_puntaje.Text = "--";
            // 
            // p_3
            // 
            this.p_3.Image = global::SimonDice_C_.Properties.Resources.Rostros_Thor;
            this.p_3.Location = new System.Drawing.Point(308, 382);
            this.p_3.Name = "p_3";
            this.p_3.Size = new System.Drawing.Size(267, 283);
            this.p_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p_3.TabIndex = 3;
            this.p_3.TabStop = false;
            this.p_3.Click += new System.EventHandler(this.p_0_Click);
            this.p_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_3_MouseDown);
            this.p_3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_3_MouseUp);
            // 
            // p_2
            // 
            this.p_2.Image = global::SimonDice_C_.Properties.Resources.Rostros_Hulk;
            this.p_2.Location = new System.Drawing.Point(29, 382);
            this.p_2.Name = "p_2";
            this.p_2.Size = new System.Drawing.Size(218, 275);
            this.p_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p_2.TabIndex = 2;
            this.p_2.TabStop = false;
            this.p_2.Click += new System.EventHandler(this.p_0_Click);
            this.p_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_2_MouseDown);
            this.p_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_2_MouseUp);
            // 
            // p_1
            // 
            this.p_1.Image = global::SimonDice_C_.Properties.Resources.Rostros_Iron_Man;
            this.p_1.Location = new System.Drawing.Point(387, 87);
            this.p_1.Name = "p_1";
            this.p_1.Size = new System.Drawing.Size(188, 276);
            this.p_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p_1.TabIndex = 1;
            this.p_1.TabStop = false;
            this.p_1.Click += new System.EventHandler(this.p_0_Click);
            this.p_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_1_MouseDown);
            this.p_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_1_MouseUp);
            // 
            // p_0
            // 
            this.p_0.Image = global::SimonDice_C_.Properties.Resources.Rostros_Capitan_America;
            this.p_0.Location = new System.Drawing.Point(43, 86);
            this.p_0.Name = "p_0";
            this.p_0.Size = new System.Drawing.Size(204, 277);
            this.p_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p_0.TabIndex = 0;
            this.p_0.TabStop = false;
            this.p_0.Click += new System.EventHandler(this.p_0_Click);
            this.p_0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_0_MouseDown);
            this.p_0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_0_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 763);
            this.Controls.Add(this.lbl_puntaje);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.p_3);
            this.Controls.Add(this.p_2);
            this.Controls.Add(this.p_1);
            this.Controls.Add(this.p_0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p_0;
        private System.Windows.Forms.PictureBox p_1;
        private System.Windows.Forms.PictureBox p_2;
        private System.Windows.Forms.PictureBox p_3;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Label lbl_puntaje;
    }
}

