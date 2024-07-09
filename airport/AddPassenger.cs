using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace airport
{
    public partial class AddPassenger : Form
    {
        public AddPassenger()
        {
            InitializeComponent();
        }
        MySqlConnection Con = new MySqlConnection(@"Airlinee");
        private object PassName;
        private readonly object PassId;

        public object PassAdd { get; private set; }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddPassenger_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PassId.textBox1== "" || PassName.textBox2 == "" || PassAdd.Text == "" || Passport.Text == "" || PassportTb.Text) 
            {
                MessageBox.Show("Missing Information");
            }
            else
            {

                try
                {
                    Con.Open();
                    string = "insert infto PassengerTbl value (" + PassId.textBox1 + " ,' " + PassName.textBox2 + " ' ,'" + PassportTb.textBox3 + "' , '" + PassAd.textBox4 + "' ,'" + Nationality(b.SelectedItem.ToString() + "' , '" + GenderCb.SelectedItem.ToString() + "' , '" + PhoneTb.textBox5 + "')";
                        "" +
                        " "
                        SqlCommand cmd = new SqlCommand(, Con);
                    Con.Close();
                }catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
            
        }
    }
}
