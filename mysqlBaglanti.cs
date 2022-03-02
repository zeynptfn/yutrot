using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace yutrotden
{
    class mysqlBaglanti
    {
        public MySqlConnection baglanti()
        {
            MySqlConnection baglan = new MySqlConnection("Server=Localhost; Database=test; UserID=root; Password= =Zt.2601/*,d");
            baglan.Open();
            return baglan;
        }
    }
}
