namespace TorriDiHanoi
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
            lbl_mosseMinime = new Label();
            nud_dischi = new NumericUpDown();
            btn_Avvia = new Button();
            pnl_c1 = new Panel();
            pnl_c2 = new Panel();
            pnl_c3 = new Panel();
            lbl_MosseEffettive = new Label();
            ((System.ComponentModel.ISupportInitialize)nud_dischi).BeginInit();
            SuspendLayout();
            // 
            // lbl_mosseMinime
            // 
            lbl_mosseMinime.AutoSize = true;
            lbl_mosseMinime.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_mosseMinime.Location = new Point(522, 23);
            lbl_mosseMinime.Name = "lbl_mosseMinime";
            lbl_mosseMinime.Size = new Size(257, 30);
            lbl_mosseMinime.TabIndex = 0;
            lbl_mosseMinime.Text = "Numero mosse stimate:  ";
            // 
            // nud_dischi
            // 
            nud_dischi.Location = new Point(147, 23);
            nud_dischi.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            nud_dischi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_dischi.Name = "nud_dischi";
            nud_dischi.Size = new Size(75, 23);
            nud_dischi.TabIndex = 1;
            nud_dischi.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btn_Avvia
            // 
            btn_Avvia.Location = new Point(38, 21);
            btn_Avvia.Name = "btn_Avvia";
            btn_Avvia.Size = new Size(75, 23);
            btn_Avvia.TabIndex = 2;
            btn_Avvia.Text = "Avvia";
            btn_Avvia.UseVisualStyleBackColor = true;
            btn_Avvia.Click += btn_Avvia_Click;
            // 
            // pnl_c1
            // 
            pnl_c1.BackColor = Color.SaddleBrown;
            pnl_c1.Location = new Point(114, 297);
            pnl_c1.Name = "pnl_c1";
            pnl_c1.Size = new Size(35, 265);
            pnl_c1.TabIndex = 3;
            // 
            // pnl_c2
            // 
            pnl_c2.BackColor = Color.SaddleBrown;
            pnl_c2.Location = new Point(372, 297);
            pnl_c2.Name = "pnl_c2";
            pnl_c2.Size = new Size(35, 265);
            pnl_c2.TabIndex = 4;
            // 
            // pnl_c3
            // 
            pnl_c3.BackColor = Color.SaddleBrown;
            pnl_c3.Location = new Point(623, 297);
            pnl_c3.Name = "pnl_c3";
            pnl_c3.Size = new Size(35, 265);
            pnl_c3.TabIndex = 4;
            // 
            // lbl_MosseEffettive
            // 
            lbl_MosseEffettive.AutoSize = true;
            lbl_MosseEffettive.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_MosseEffettive.Location = new Point(522, 66);
            lbl_MosseEffettive.Name = "lbl_MosseEffettive";
            lbl_MosseEffettive.Size = new Size(261, 30);
            lbl_MosseEffettive.TabIndex = 5;
            lbl_MosseEffettive.Text = "Numero mosse effettive: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 609);
            Controls.Add(lbl_MosseEffettive);
            Controls.Add(pnl_c3);
            Controls.Add(pnl_c2);
            Controls.Add(pnl_c1);
            Controls.Add(btn_Avvia);
            Controls.Add(nud_dischi);
            Controls.Add(lbl_mosseMinime);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nud_dischi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_mosseMinime;
        private NumericUpDown nud_dischi;
        private Button btn_Avvia;
        private Panel pnl_c1;
        private Panel pnl_c2;
        private Panel pnl_c3;
        private Label lbl_MosseEffettive;
    }
}