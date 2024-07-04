namespace TRABALHO
{
    partial class Form5
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
            this.aceler = new System.Windows.Forms.Button();
            this.circunfer = new System.Windows.Forms.Button();
            this.potenciar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.volt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aceler
            // 
            this.aceler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aceler.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aceler.Location = new System.Drawing.Point(337, 226);
            this.aceler.Name = "aceler";
            this.aceler.Size = new System.Drawing.Size(136, 49);
            this.aceler.TabIndex = 3;
            this.aceler.Text = "Aceleração";
            this.aceler.UseVisualStyleBackColor = true;
            this.aceler.Click += new System.EventHandler(this.aceler_Click);
            // 
            // circunfer
            // 
            this.circunfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.circunfer.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.circunfer.Location = new System.Drawing.Point(120, 226);
            this.circunfer.Name = "circunfer";
            this.circunfer.Size = new System.Drawing.Size(136, 49);
            this.circunfer.TabIndex = 4;
            this.circunfer.Text = "Circunferência";
            this.circunfer.UseVisualStyleBackColor = true;
            this.circunfer.Click += new System.EventHandler(this.circunfer_Click);
            // 
            // potenciar
            // 
            this.potenciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.potenciar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.potenciar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.potenciar.Location = new System.Drawing.Point(552, 226);
            this.potenciar.Name = "potenciar";
            this.potenciar.Size = new System.Drawing.Size(136, 49);
            this.potenciar.TabIndex = 5;
            this.potenciar.Text = "Potênciação";
            this.potenciar.UseVisualStyleBackColor = true;
            this.potenciar.Click += new System.EventHandler(this.potenciar_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titulo.Location = new System.Drawing.Point(-3, 66);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(808, 54);
            this.titulo.TabIndex = 6;
            this.titulo.Text = "Selecione a equação que você tem dúvida";
            this.titulo.Click += new System.EventHandler(this.titulo_Click);
            // 
            // volt
            // 
            this.volt.BackColor = System.Drawing.Color.Black;
            this.volt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.volt.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.volt.ForeColor = System.Drawing.Color.White;
            this.volt.Location = new System.Drawing.Point(704, -1);
            this.volt.Name = "volt";
            this.volt.Size = new System.Drawing.Size(101, 39);
            this.volt.TabIndex = 7;
            this.volt.Text = "Voltar";
            this.volt.UseVisualStyleBackColor = false;
            this.volt.Click += new System.EventHandler(this.volt_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.volt);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.potenciar);
            this.Controls.Add(this.circunfer);
            this.Controls.Add(this.aceler);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button aceler;
        private Button circunfer;
        private Button potenciar;
        private Label titulo;
        private Button volt;
    }
}