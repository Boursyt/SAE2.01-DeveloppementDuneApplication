using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLassLibrairieBDD
{
    public class BDD
    {

        private static MySqlConnection macnx;


        public static bool initConnexion()
        {
            string serveur = "10.1.139.235";
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

        public static bool AjoutPartie()
        {
            return true;
        }
    }


    public class Class1
    {
    }
}
