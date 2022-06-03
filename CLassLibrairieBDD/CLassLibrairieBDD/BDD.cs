using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLassLibrairieBDD
{
    public class BDD
    {

        public static MySqlConnection macnx;


        public static bool initConnexion()
        {
            string serveur = "10.1.139.236";
            string login = "c1";
            string passwd = "mdp";
            string BD = "basec1";
            string chaineDeConnexion = $"server={serveur};uid={login};pwd={passwd};database={BD}";

            macnx = new MySqlConnection(chaineDeConnexion);

            try
            {
                macnx.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static bool fermerConnexion()
        {
            try
            {
                if (macnx.State == System.Data.ConnectionState.Open)
                {
                    macnx.Close();
                    macnx.Dispose();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }

        }



        public static string imageBDD(int numimage)
        {
            string sql;
            string url = " ";
            sql = $"select * from Image";
            MySqlCommand cmd = new MySqlCommand(sql, macnx);
            MySqlDataReader rdr = cmd.ExecuteReader();
            int i = 1;
            while (rdr.Read())
            {
                if (i == numimage)
                {
                    url = rdr.GetString(2);
                    break;
                }
                i++;
            }
            rdr.Close();
            cmd.Dispose();
            return url;
        }

        public static bool executeSQL(string sql)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, macnx);
                cmd.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }
       
    }
}
