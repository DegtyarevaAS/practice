using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Practice
{
    class DbHelper
    {
        public static MySqlConnection GetConn()
        {
            MySqlConnectionStringBuilder db = new MySqlConnectionStringBuilder();

            db.Server = "pgsha.ru"; // хостинг БД
            db.UserID = "soft0095"; // Имя пользователя БД
            db.Database = "soft0095_practice"; // Имя БД
            db.Password = "uyqe2UHF"; // Пароль пользователя БД
            db.Port = 35006;

            db.CharacterSet = "utf8"; // Кодировка Базы Данных

            MySqlConnection conn = new MySqlConnection(db.ConnectionString);

            return conn;
        }
    }
}
