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

namespace ResimFormu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbMarka.SelectedIndex >= 0)
            {

                ModelDoldur();
                YilDoldur();
                ResimGoster();
            }
        }
        
        void ModelDoldur()
        {
            //SqlDataAdapter adp = new SqlDataAdapter(string.Format("select Model from arabalar where MarkaID={0}",cbMarka.SelectedValue.ToString()),con);
            //con.Open();
            //DataSet ds = new DataSet();
            //adp.Fill(ds);
            //cbMarka.DisplayMember = "Model";
            //cbMarka.ValueMember = "MarkaID";
            //cbMarka.DataSource = ds;
            //con.Close();


            SqlCommand cmd2 = new SqlCommand();
            con.Open();
            cmd2.Connection = con;
            cmd2.CommandText = string.Format("select Model from Arabalar where Marka='{0}'", Convert.ToString(cbMarka.SelectedItem));

            cmd2.ExecuteNonQuery();


            SqlDataReader dr = cmd2.ExecuteReader();


            while (dr.Read())
            {
                txt2Model.Text = dr["Model"].ToString();
            }
            con.Close();    
        }

        void YilDoldur()
        {
            SqlCommand cmd2 = new SqlCommand();
            con.Open();
            cmd2.Connection = con;
            cmd2.CommandText = string.Format("select Yıl from Arabalar where Marka='{0}'", Convert.ToString(cbMarka.SelectedItem));

            cmd2.ExecuteNonQuery();


            SqlDataReader dr = cmd2.ExecuteReader();


            while (dr.Read())
            {
              txt2Yil.Text = dr["Yıl"].ToString();
            }
            con.Close();  
        }


        void ResimGoster()
        {

            SqlCommand cmd2 = new SqlCommand();
            con.Open();
            cmd2.Connection = con;
            cmd2.CommandText =string.Format("select Foto from Arabalar where Marka='{0}'",Convert.ToString(cbMarka.SelectedItem));
                      
           cmd2.ExecuteNonQuery();


            SqlDataReader dr = cmd2.ExecuteReader();


            while (dr.Read())
            {
              pb2Resim.ImageLocation = dr["Foto"].ToString();
            }
            con.Close();
            pb2Resim.Show();
        }


         SqlConnection con = new SqlConnection("server=DESKTOP-ADS5CUN\\SQLEXPRESS; database=net11db; integrated security=true");
        private void Form2_Load(object sender, EventArgs e)
        {

            
            SqlCommand cmd = new SqlCommand("select Marka from Arabalar", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbMarka.Items.Add(dr["Marka"]);
            }
            con.Close();
           
           
        }
          
    }
}
