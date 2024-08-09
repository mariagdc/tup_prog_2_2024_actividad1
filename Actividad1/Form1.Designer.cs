namespace Actividad1
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
            this.btnCliente = new System.Windows.Forms.Button();
            this.ReponerIngrediente = new System.Windows.Forms.Button();
            this.btnCocinar = new System.Windows.Forms.Button();
            this.tbxharina = new System.Windows.Forms.TextBox();
            this.tbxfruta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCliente.Location = new System.Drawing.Point(55, 80);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(79, 64);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Crear";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // ReponerIngrediente
            // 
            this.ReponerIngrediente.Location = new System.Drawing.Point(207, 80);
            this.ReponerIngrediente.Name = "ReponerIngrediente";
            this.ReponerIngrediente.Size = new System.Drawing.Size(93, 64);
            this.ReponerIngrediente.TabIndex = 1;
            this.ReponerIngrediente.Text = "Reponer Ingredientes";
            this.ReponerIngrediente.UseVisualStyleBackColor = true;
            this.ReponerIngrediente.Click += new System.EventHandler(this.ReponerIngrediente_Click);
            // 
            // btnCocinar
            // 
            this.btnCocinar.Location = new System.Drawing.Point(55, 198);
            this.btnCocinar.Name = "btnCocinar";
            this.btnCocinar.Size = new System.Drawing.Size(75, 23);
            this.btnCocinar.TabIndex = 2;
            this.btnCocinar.Text = "Cocinar";
            this.btnCocinar.UseVisualStyleBackColor = true;
            this.btnCocinar.Click += new System.EventHandler(this.btnCocinar_Click);
            // 
            // tbxharina
            // 
            this.tbxharina.Location = new System.Drawing.Point(275, 201);
            this.tbxharina.Name = "tbxharina";
            this.tbxharina.Size = new System.Drawing.Size(100, 20);
            this.tbxharina.TabIndex = 3;
            this.tbxharina.Text = "0";
            // 
            // tbxfruta
            // 
            this.tbxfruta.Location = new System.Drawing.Point(275, 277);
            this.tbxfruta.Name = "tbxfruta";
            this.tbxfruta.Size = new System.Drawing.Size(100, 20);
            this.tbxfruta.TabIndex = 4;
            this.tbxfruta.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fruta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Harina";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxfruta);
            this.Controls.Add(this.tbxharina);
            this.Controls.Add(this.btnCocinar);
            this.Controls.Add(this.ReponerIngrediente);
            this.Controls.Add(this.btnCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button ReponerIngrediente;
        private System.Windows.Forms.Button btnCocinar;
        public System.Windows.Forms.TextBox tbxharina;
        public System.Windows.Forms.TextBox tbxfruta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

