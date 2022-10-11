using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DispositivosMoviles.Models
{
    public class UserDrago
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }

        public string Usuario { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string ApPaterno { get; set; }

        public string ApMaterno { get; set; }

        public string Edad { get; set; }

        public string Pais { get; set; }

        public DateTime Fecha_De_Creacion { get; set; }
    }
}
