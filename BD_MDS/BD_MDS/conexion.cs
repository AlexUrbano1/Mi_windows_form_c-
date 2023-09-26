using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;


namespace BD_MDS
{
    internal class conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter da;

        public conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=ANURBANO\\BD_ANURBANO;Initial Catalog=BD_MDS;Integrated Security=True");
            }

            catch (Exception ex)
            {
                MessageBox.Show("NO SE LOGRO CONEXION A LA BASE DE DATOS" + ex.ToString());

            }

        }

    }
}
