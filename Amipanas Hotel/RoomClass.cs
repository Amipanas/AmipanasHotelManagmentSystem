using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Amipanas_Hotel
{
    class RoomClass
    {
        DbConnection connect = new DbConnection();
        public DataTable getRoomType()
        {
            string selectQuery = "SELECT * FROM `category`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public bool addRoom(int no, int type, string phone, string status)
        {
            string insertQuery = "INSERT INTO `room`(`RoomID`, `RoomType`, `RoomPhone`, `RoomStatus`) VALUES (@no,@type,@ph,@sts)";
            MySqlCommand command = new MySqlCommand(insertQuery, connect.GetConnection());
            //@no,@type,@ph,@sts
            command.Parameters.Add("@no", MySqlDbType.VarChar).Value = no;
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@sts", MySqlDbType.VarChar).Value = status;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }
        }
        public DataTable getRoomList()
        {
            string selectQuery = "SELECT * FROM `room`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public bool editRoom(int no, int type, string phone, string status)
        {
            string insertQuery = "UPDATE `room` SET `RoomID`=@no, `RoomType`=@type,`RoomPhone`=@ph,`RoomStatus`=@sts WHERE `RoomID`=@no";
            MySqlCommand command = new MySqlCommand(insertQuery, connect.GetConnection());
            //@no,@type,@ph,@sts
            command.Parameters.Add("@no", MySqlDbType.VarChar).Value = no;
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@sts", MySqlDbType.VarChar).Value = status;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }
        }
        public bool removeRoom(string id)
        {
            string removeQuery = "DELETE FROM `room` WHERE `RoomID`=@id";
            MySqlCommand command = new MySqlCommand(removeQuery, connect.GetConnection());
            //@id
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }
        }
    }
}
