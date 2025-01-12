using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProdTools
{
    internal class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Server=CASA;Database=DoctorAppBD;TrustServerCertificate=True;Trusted_Connection=true;MultipleActiveResultSets=true");
                cn.Open();
                //MessageBox.Show("connectado");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("no connectado" +ex.ToString());
            }
        }

        public int personaRegistrada(int id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from Especialidades", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        public void cargarEspecialidades(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from Especialidades", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }

    }
}
