namespace TRABALHO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aceler = new System.Windows.Forms.Button();
            this.circunfer = new System.Windows.Forms.Button();
            this.potenciar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tutor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULADORA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(153, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecione o tipo de calculo";
            // 
            // aceler
            // 
            this.aceler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aceler.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aceler.Location = new System.Drawing.Point(55, 205);
            this.aceler.Name = "aceler";
            this.aceler.Size = new System.Drawing.Size(136, 49);
            this.aceler.TabIndex = 2;
            this.aceler.Text = "Aceleração";
            this.aceler.UseVisualStyleBackColor = true;
            this.aceler.Click += new System.EventHandler(this.aceler_Click);
            // 
            // circunfer
            // 
            this.circunfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.circunfer.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.circunfer.Location = new System.Drawing.Point(250, 205);
            this.circunfer.Name = "circunfer";
            this.circunfer.Size = new System.Drawing.Size(136, 49);
            this.circunfer.TabIndex = 3;
            this.circunfer.Text = "Circunferência";
            this.circunfer.UseVisualStyleBackColor = true;
            this.circunfer.Click += new System.EventHandler(this.circunfer_Click);
            // 
            // potenciar
            // 
            this.potenciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.potenciar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.potenciar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.potenciar.Location = new System.Drawing.Point(443, 205);
            this.potenciar.Name = "potenciar";
            this.potenciar.Size = new System.Drawing.Size(136, 49);
            this.potenciar.TabIndex = 4;
            this.potenciar.Text = "Potênciação";
            this.potenciar.UseVisualStyleBackColor = true;
            this.potenciar.Click += new System.EventHandler(this.potenciar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(44, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(157, 115);
            this.panel3.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(222, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 90);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(433, 278);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 115);
            this.panel2.TabIndex = 9;
            // 
            // tutor
            // 
            this.tutor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tutor.Location = new System.Drawing.Point(250, 440);
            this.tutor.Name = "tutor";
            this.tutor.Size = new System.Drawing.Size(136, 47);
            this.tutor.TabIndex = 10;
            this.tutor.Text = "Tutorial";
            this.tutor.UseVisualStyleBackColor = true;
            this.tutor.Click += new System.EventHandler(this.tutor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(652, 529);
            this.Controls.Add(this.tutor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.potenciar);
            this.Controls.Add(this.circunfer);
            this.Controls.Add(this.aceler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button aceler;
        private Button circunfer;
        private Button potenciar;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private Button tutor;
    }
}