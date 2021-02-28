using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace Stutatisticer
{
    public class SqliteDataAccess
    {
        public static List<OgrenciModel> OgrenciYukle()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<OgrenciModel>("select * from Ogrenciler", new DynamicParameters());
                return output.ToList();
            }
            
        }

        public static void OgrenciKaydet(OgrenciModel ogrenci)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Ogrenciler (OgrenciAD) values (@Ad) ", ogrenci);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    }
}
