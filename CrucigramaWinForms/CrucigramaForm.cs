namespace CrucigramaWinForms
{
    public partial class CrucigramaForm : Form
    {
        private DataGridView grid;
        private Button btnVerificar;
        private Button btnReiniciar;
        private Label lblPistas;

        public CrucigramaForm()
        {
            InitializeComponent();
            dataGridView1_CellContentClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Verificación en proceso...");
            // Aquí se agregarán validaciones futuras
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = "";
                }
            }
        }

 /*       private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }*/

        private void dataGridView1_CellContentClick()
        {
            this.Text = "Crucigrama";
            this.Size = new Size(600, 600);

            grid = new DataGridView
            {
                ColumnCount = 10,
                RowCount = 10,
                Size = new Size(400, 400),
                Location = new Point(20, 20),
                AllowUserToAddRows = false,
                AllowUserToResizeColumns = false,
                AllowUserToResizeRows = false,
                ReadOnly = false,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter },
            };
            this.Controls.Add(grid);

            lblPistas = new Label
            {
                Text = "Pistas:\n1. Horizontal: Animal que ladra (4 letras)\n2. Vertical: Ave nocturna (3 letras)",
                Location = new Point(20, 450),
                AutoSize = true
            };
            this.Controls.Add(lblPistas);

            btnVerificar = new Button
            {
                Text = "Verificar",
                Location = new Point(450, 100)
            };
            btnVerificar.Click += button1_Click;
            this.Controls.Add(btnVerificar);

            btnReiniciar = new Button
            {
                Text = "Reiniciar",
                Location = new Point(450, 150)
            };
            btnReiniciar.Click += button2_Click;
            this.Controls.Add(btnReiniciar);
        }
    }
}
