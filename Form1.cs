using System.Windows.Forms;

namespace SudokuVR
{
    public partial class Form1 : Form
    {
        int contador = 0;
        int counta = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //while (contador < 2)
            //{
                //if (contador == 0)
                //{
                    System.Diagnostics.Process.Start("SudokuVr.exe");
                    escribeArchivo();
                //}
                    
                

                //contador++;
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void escribeArchivo()
        {
            if(counta == 1) { 
                string Ruta = "Informe.txt";
                StreamWriter escribeA = new StreamWriter(Ruta, true);
                escribeA.WriteLine(DateTime.Now.ToString());
                escribeA.Close();
                counta++;
            }
        }
    }
}