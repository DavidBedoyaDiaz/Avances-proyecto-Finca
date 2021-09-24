
namespace InterfazFincaCafetera_Borr
{
    partial class FrmRegistrarProduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarProduccion));
            this.BtnRegistrarProducción = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRegistrarProducción
            // 
            this.BtnRegistrarProducción.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.BtnRegistrarProducción.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistrarProducción.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.BtnRegistrarProducción.FlatAppearance.BorderSize = 2;
            this.BtnRegistrarProducción.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRegistrarProducción.Font = new System.Drawing.Font("Louis George Café", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarProducción.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.BtnRegistrarProducción.Location = new System.Drawing.Point(227, 152);
            this.BtnRegistrarProducción.Name = "BtnRegistrarProducción";
            this.BtnRegistrarProducción.Size = new System.Drawing.Size(327, 100);
            this.BtnRegistrarProducción.TabIndex = 0;
            this.BtnRegistrarProducción.Text = "Registrar Producción";
            this.BtnRegistrarProducción.UseVisualStyleBackColor = false;
            this.BtnRegistrarProducción.Click += new System.EventHandler(this.BtnRegistrarProducción_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalir.Font = new System.Drawing.Font("Louis George Café", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.BtnSalir.Location = new System.Drawing.Point(227, 284);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(327, 43);
            this.BtnSalir.TabIndex = 1;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmRegistrarProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(214)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnRegistrarProducción);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistrarProduccion";
            this.Text = "Registrar Produccion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRegistrarProducción;
        private System.Windows.Forms.Button BtnSalir;
    }
}