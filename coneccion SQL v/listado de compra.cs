using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


/*namespace coneccion_SQL_v
{
    public partial class listado_de_compra : Form
    {
        public listado_de_compra()
        {
            InitializeComponent();
            //EmpNameLbl.Text Login.Employee;
            GetCostumers();
            DisplayProduct();
        }



        SqlConnection Con = new SqlConnection(@"Data Source =.; Initial Catalog = bondAPPetite; Integrated Security = True");

        private void GetCostumers()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select custID from CostumerTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustId", typeof(int));
            dt.Load(Rdr);
            //CustIdCb.ValueMember = "CustId";
            //CustIdCB.DataSource = dt;
            Con.Close();

        }

        private void DisplayProduct()
        {
            Con.Open();
            string Query = "Select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            //ProductsDGV.DataSource = ds.Tables[0];
            Con.Close() ;
        }

        private void ver_ticket_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void listado_de_compra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bondAPPetiteDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.bondAPPetiteDataSet.Productos);

        }


        int prodid, prodqty, prodprice, total, pos = 60;

        private void Client_Click(object sender, EventArgs e)
        {

        }

        private void CustomerId_Click(object sender, EventArgs e)
        {

        }

        private void ProductsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //PrNameTb.Text = Transaction.SelectRows
        }

        string prodName;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Bond Appetite", new Font("Century Gothic", 12, FontStyle.Bold),Brushes.Red, new Point(80));
            e.Graphics.DrawString("Monto total", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26,40));
        foreach(DataGridView row in  BillDGV.Rows )
            {
                prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                prodName = "" + row.Cells["Column2"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
                total = prodqty = Convert.ToInt32(row.Cells["Column5"].Value);

            }
        
        }
    }
}
*/