using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLBH.DAL
{
    /// <summary>
    /// Lớp sử dụng để thực hiện kết nối với CSDL.
    /// </summary>
    class Database 
    {
        public static SqlConnection Connect()
        {
            return new SqlConnection();
        }
    }
}
