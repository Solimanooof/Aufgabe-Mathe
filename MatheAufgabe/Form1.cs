namespace MatheAufgabe
{
    public partial class Form1 : Form
    {
        public int AnzalderWerten;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnStuetzEingebe_Click(object sender, EventArgs e)
        {
            dataGridViewWerten.Rows.Clear();
            if (textBoxAnzahlderWerten.Text !=null)
            {
                AnzalderWerten = int.Parse(textBoxAnzahlderWerten.Text);
                for (int i = 0; i < AnzalderWerten; i++)
                {
                    this.dataGridViewWerten.Rows.Add();
                }
               
            }

                    
        }

        private void btnBasisPolynom_Click(object sender, EventArgs e)
        {
            textBoxLagrange.Text=String.Empty;
            Interpolation interpolation = new Interpolation();
             double[] XWerten = new double[AnzalderWerten];
             double[] YWerten = new double[AnzalderWerten];
             int i = 0;
             foreach (DataGridViewRow row in dataGridViewWerten.Rows)
             {
                 XWerten[i] = double.Parse(row.Cells[0].Value.ToString());
                 YWerten[i] = double.Parse(row.Cells[1].Value.ToString());
                 i++;
             }



            textBoxLagrange.Text = interpolation.lagrange(XWerten, YWerten);
            
            

        }
    }
}