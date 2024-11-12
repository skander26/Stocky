using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_de_stock
{
    internal class Bd
    {
        public SqlConnection cnn = new SqlConnection(@"Data Source = SKON\SA; database=stock;User Id=sa;Password=nges1111; Integrated Security = False");

        public void ouverture_bd(SqlConnection cnx)
        {
            if (!(cnx.State == System.Data.ConnectionState.Open))
            {
                cnx.Open();
            }


        }
    }
}
