using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace PassBook
{
    class config
    {
        public MySqlConnection con;
        public config()
        {
            try
            {
                string str = "server=localhost;User Id=Rade;pwd=875254Broj#;database=passbook";
                con = new MySqlConnection(str);
                con.Open();
                MessageBox.Show("Connection successful");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
