using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;



namespace BD_MDS
{
    public partial class Form1 : Form
    {
        conexion c = new conexion();
        SqlConnection cn;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
            cn = new SqlConnection("Data Source=ANURBANO\\BD_ANURBANO;Initial Catalog=BD_MDS;Integrated Security=True");

        }

        private void cbo_componente_servicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                cmd = cn.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM CATEGORIZACIONES_MDS WHERE COMPONENTE_DEL_SERVICIO like ('" + cbo_componente_servicio.Text + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                dgv_casos.DataSource = dt;
                lbl_total_registro.Text = this.dgv_casos.Rows.Count.ToString();
                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE LOGRO CONEXIÓN CON LA BASE DE DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbo_sintoma_detalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                cmd = cn.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM CATEGORIZACIONES_MDS WHERE SINTOMA_O_DETALLE like ('" + cbo_sintoma_detalle.Text + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                dgv_casos.DataSource = dt;
                lbl_total_registro.Text = this.dgv_casos.Rows.Count.ToString();
                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE LOGRO CONEXIÓN CON LA BASE DE DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txt_sintoma_o_detalle_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                cmd = cn.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM CATEGORIZACIONES_MDS WHERE SINTOMA_O_DETALLE like ('%" + txt_sintoma_o_detalle.Text + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                dgv_casos.DataSource = dt;
                lbl_total_registro.Text = this.dgv_casos.Rows.Count.ToString();
                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE LOGRO CONEXIÓN CON LA BASE DE DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbo_servicio_negocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                cmd = cn.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM CATEGORIZACIONES_MDS WHERE SERVICIO_DE_NEGOCIO like ('" + cbo_servicio_negocio.Text + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                dgv_casos.DataSource = dt;
                lbl_total_registro.Text = this.dgv_casos.Rows.Count.ToString();
                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE LOGRO CONEXIÓN CON LA BASE DE DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_especialistas_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                cmd = cn.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Lista_Especialistas";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                dgv_casos.DataSource = dt;
                lbl_total_registro.Text = this.dgv_casos.Rows.Count.ToString();
                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE LOGRO CONEXIÓN CON LA BASE DE DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}


     