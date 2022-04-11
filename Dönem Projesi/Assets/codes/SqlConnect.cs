using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.Data;
using System.Data.SqlClient;

namespace Assets.codes
{
    class SqlConnect:MonoBehaviour
    {
        private string connect = @"Data Source=IREM-\SQLSERVER; Initial Catalog=DönemProjesi; User ID=deneme2;Password=13579;Trusted_Connection=False;";

        void OyuncuKayit()
        {
            SqlConneciton sql = new SqlConneciton();
        }
    }
}
