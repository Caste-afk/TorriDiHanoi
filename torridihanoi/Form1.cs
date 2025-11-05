using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TorriDiHanoi
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private List<(int from, int to)> mosse = new List<(int from, int to)>();
        private int stepCorrente = 0;
        private List<int>[] matrice;
        private List<Panel> dischi = new List<Panel>();
        int MosseAttuali;

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 600;
            timer.Tick += Timer_Tick;
            MosseAttuali = 0;
        }

        
        static List<int>[] CreaMatrice(int n)
        {
            List<int>[] matrice = new List<int>[]
            {
                new List<int>(),
                new List<int>(),
                new List<int>()
            };
            for (int i = 1; i <= n; i++)
            {
                matrice[0].Add(i);
            }
            return matrice;
        }

        static int f(List<int>[] matrice, int n, int inizio, int fine, List<(int from, int to)> mosse)
        {
            if (n == 1)
            {
                mosse.Add((inizio, fine));
                MoveDisk(matrice, inizio, fine);
                return 1;
            }
            else
            {
                int cAttuale = 3 - inizio - fine;
                int mosseTot = f(matrice, n - 1, inizio, cAttuale, mosse);
                mosse.Add((inizio, fine));
                MoveDisk(matrice, inizio, fine);
                mosseTot += 1 + f(matrice, n - 1, cAttuale, fine, mosse);
                return mosseTot;
            }
        }

        static void MoveDisk(List<int>[] matrice, int inizio, int fine)
        {
            int discoTolto = matrice[inizio][matrice[inizio].Count - 1];
            matrice[fine].Add(discoTolto);
            matrice[inizio].RemoveAt(matrice[inizio].Count - 1);
        }

        private void btn_Avvia_Click(object sender, EventArgs e)
        {
            MosseAttuali = 0;
            int n = (int)nud_dischi.Value;
            dischi.ForEach(d => this.Controls.Remove(d));
            dischi.Clear();
            mosse.Clear();
            stepCorrente = 0;

            matrice = CreaMatrice(n);
            int mosseTot = f(CreaMatrice(n), n, 0, 2, mosse);
            lbl_mosseMinime.Text = $"Numero mosse stimate: {mosseTot}";

            AggiungiDischiAColonna(n);
            timer.Start();
        }

        private void AggiungiDischiAColonna(int n)
        {
            int altezzaDisco = 20;
            int baseY = pnl_c1.Bottom - 5;

            for (int i = 0; i < n; i++)
            {
                int valore = matrice[0][i];
                int larghezza = 120 - (valore - 1) * 15; //disco più grande = numero più piccolo

                Panel disco = new Panel
                {
                    Width = larghezza,
                    Height = altezzaDisco,
                    BackColor = Color.LightBlue,
                    Left = pnl_c1.Left + (pnl_c1.Width - larghezza) / 2,
                    Top = baseY - (i + 1) * altezzaDisco,
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = valore
                };
                this.Controls.Add(disco);
                dischi.Add(disco);
                disco.BringToFront();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (stepCorrente < mosse.Count)
            {
                var step = mosse[stepCorrente++];
                EseguiMossa(step.from, step.to);
            }
            else
            {
                timer.Stop();
            }
        }

        private void EseguiMossa(int from, int to)
        {
            if (matrice[from].Count == 0) return;

            int discoDaSpostare = matrice[from][matrice[from].Count - 1];
            Panel disco = dischi.Find(d => (int)d.Tag == discoDaSpostare);

            MoveDisk(matrice, from, to);
            AggiornaPosizioneDisco(disco, to);
        }

        private void AggiornaPosizioneDisco(Panel disco, int colonna)
        {
            int nDischiInColonna = matrice[colonna].Count;
            int altezzaDisco = disco.Height;
            int baseY = pnl_c1.Bottom - 5;

            int nuovaY = baseY - nDischiInColonna * altezzaDisco;

            int nuovaX = 0;
            if (colonna == 0) nuovaX = pnl_c1.Left + (pnl_c1.Width - disco.Width) / 2;
            if (colonna == 1) nuovaX = pnl_c2.Left + (pnl_c2.Width - disco.Width) / 2;
            if (colonna == 2) nuovaX = pnl_c3.Left + (pnl_c3.Width - disco.Width) / 2;

            
            int passi = 10;
            int dx = (nuovaX - disco.Left) / passi;
            int dy = (nuovaY - disco.Top) / passi;

            for (int i = 0; i < passi; i++)
            {
                disco.Left += dx;
                disco.Top += dy;
                Application.DoEvents();
                System.Threading.Thread.Sleep(20);
            }

            disco.Left = nuovaX;
            disco.Top = nuovaY;
            MosseAttuali++;
            lbl_MosseEffettive.Text = $"Numero mosse effettive: {MosseAttuali}";

        }
    }
}
