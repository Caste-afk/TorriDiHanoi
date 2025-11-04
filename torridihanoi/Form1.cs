namespace TorriDiHanoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<int>[] matrice = new List<int>[]
            {
                new List<int> { 1, 2, 3, 4, 5 },
                new List<int>(),
                new List<int>()
            };

            int mosseTot = f(matrice, 0);
            MessageBox.Show($"{mosseTot}");
        }


        static int f(List<int>[] matrice, int x)
        {

            int gSopra = matrice[x][0];

            if (x >= 3)
            {
                x = 0;
            }
            else x++;

            int gNuovo;

            if(matrice[x].Count == 0)
            {
                gNuovo = 0;
            }else
            {
                gNuovo = matrice[x][0];//il nuovo è uguale al disco della colonna dopo alla posizione 0 (primo inserito)
            }

            if (gNuovo < gSopra)
            {
                return 1;
            }
            matrice[x][matrice[x].Count] = gSopra;

            return f(matrice, x + 1);
        }
    }
}