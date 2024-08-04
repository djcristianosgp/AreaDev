using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_27_dashboard.DB
{
    public static class DbConfig
    {
        public static string ConnectionString { get; } = "Host=your_host;Port=5432;Username=your_username;Password=your_password;Database=your_database";
    }

}
