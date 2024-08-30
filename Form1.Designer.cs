namespace ProjetoInsulina
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
            label1 = new Label();
            Bombatxt = new Label();
            label3 = new Label();
            Relogio = new Label();
            label5 = new Label();
            NivelAcucar = new Label();
            label7 = new Label();
            NivelTxt = new Label();
            RelogioBombatxt = new Label();
            label2 = new Label();
            label4 = new Label();
            RespostaSistema = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(423, 291);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(165, 32);
            label1.TabIndex = 1;
            label1.Text = "Status Bomba:";
            // 
            // Bombatxt
            // 
            Bombatxt.AutoSize = true;
            Bombatxt.Font = new Font("Segoe UI", 10F);
            Bombatxt.Location = new Point(453, 346);
            Bombatxt.Margin = new Padding(4, 0, 4, 0);
            Bombatxt.Name = "Bombatxt";
            Bombatxt.Size = new Size(98, 28);
            Bombatxt.TabIndex = 2;
            Bombatxt.Text = "Desligada";
            Bombatxt.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(221, 117);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(153, 32);
            label3.TabIndex = 3;
            label3.Text = "Controladora";
            // 
            // Relogio
            // 
            Relogio.AutoSize = true;
            Relogio.Location = new Point(89, 221);
            Relogio.Margin = new Padding(4, 0, 4, 0);
            Relogio.Name = "Relogio";
            Relogio.Size = new Size(0, 32);
            Relogio.TabIndex = 4;
            Relogio.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 291);
            label5.Name = "label5";
            label5.Size = new Size(183, 32);
            label5.TabIndex = 5;
            label5.Text = "Nivel de açúcar:";
            label5.Click += label5_Click;
            // 
            // NivelAcucar
            // 
            NivelAcucar.AutoSize = true;
            NivelAcucar.Location = new Point(89, 342);
            NivelAcucar.Name = "NivelAcucar";
            NivelAcucar.Size = new Size(27, 32);
            NivelAcucar.TabIndex = 6;
            NivelAcucar.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(158, 342);
            label7.Name = "label7";
            label7.Size = new Size(78, 32);
            label7.TabIndex = 7;
            label7.Text = "mg/dl";
            // 
            // NivelTxt
            // 
            NivelTxt.AutoSize = true;
            NivelTxt.Location = new Point(221, 291);
            NivelTxt.Name = "NivelTxt";
            NivelTxt.Size = new Size(93, 32);
            NivelTxt.TabIndex = 9;
            NivelTxt.Text = "Normal";
            // 
            // RelogioBombatxt
            // 
            RelogioBombatxt.AutoSize = true;
            RelogioBombatxt.Location = new Point(495, 230);
            RelogioBombatxt.Margin = new Padding(4, 0, 4, 0);
            RelogioBombatxt.Name = "RelogioBombatxt";
            RelogioBombatxt.Size = new Size(0, 32);
            RelogioBombatxt.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 168);
            label2.Name = "label2";
            label2.Size = new Size(143, 32);
            label2.TabIndex = 11;
            label2.Text = "Cronometro";
            label2.Click += label2_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(402, 168);
            label4.Name = "label4";
            label4.Size = new Size(186, 32);
            label4.TabIndex = 12;
            label4.Text = "Ativação Bomba";
            // 
            // RespostaSistema
            // 
            RespostaSistema.AutoSize = true;
            RespostaSistema.Location = new Point(246, 43);
            RespostaSistema.Name = "RespostaSistema";
            RespostaSistema.Size = new Size(24, 32);
            RespostaSistema.TabIndex = 13;
            RespostaSistema.Text = "..";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 576);
            Controls.Add(RespostaSistema);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(RelogioBombatxt);
            Controls.Add(NivelTxt);
            Controls.Add(label7);
            Controls.Add(NivelAcucar);
            Controls.Add(label5);
            Controls.Add(Relogio);
            Controls.Add(label3);
            Controls.Add(Bombatxt);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label Bombatxt;
        private Label label3;
        private Label Relogio;
        private Label label5;
        private Label NivelAcucar;
        private Label label7;
        private Label NivelTxt;
        private Label RelogioBombatxt;
        private Label label2;
        private Label label4;
        private Label RespostaSistema;
    }
}
