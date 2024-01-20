using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Amipanas_Hotel
{
    class GuestsClass
    {
        DbConnection connect = new DbConnection();

        public DataTable roomByType(int type)
        {
            string selectQuery = "SELECT * FROM `room` WHERE `RoomType` = @type AND `RoomStatus`='خالی'";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = type;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // Insert a new guest
        public bool insertGuest(string id, string fname, string lname, int roomID, string phone, string city)
        {
            string insertQuery = "INSERT INTO `guests`(`ID`, `Name`, `Family`,`RoomID`, `Phone`, `city`) VALUES (@id,@fname,@lname,@rID,@ph,@ct)";
            MySqlCommand command = new MySqlCommand(insertQuery, connect.GetConnection());
            //@id,@fname,@lname,@ph,@ct
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@rID", MySqlDbType.Int32).Value = roomID;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@ct", MySqlDbType.VarChar).Value = city;

            connect.OpenCon();
            if(command.ExecuteNonQuery() == 1)
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
        public void roomUpdate(int roomNo)
        {
            string roomUpdateQuery = "UPDATE `room` SET `RoomStatus`='پر' WHERE `RoomID`= @rID";
            MySqlCommand cmd = new MySqlCommand(roomUpdateQuery, connect.GetConnection());
            //@id,@fname,@lname,@ph,@ct
            cmd.Parameters.Add("@rID", MySqlDbType.Int32).Value = roomNo;
            connect.OpenCon();
            if (cmd.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                //return true;
            }
        }

        public DataTable getGuest()
        {
            string selectQuery = "SELECT * FROM `guests`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public bool editGuest(string id, string fname, string lname, int roomID, string phone, string city)
        {
            string editQuery = "UPDATE `guests` SET `ID`=@id,`Name`=@fname,`Family`=@lname,`Phone`=@ph,`City`=@ct WHERE `ID`=@id";
            MySqlCommand command = new MySqlCommand(editQuery, connect.GetConnection());
            //@id,@fname,@lname,@ph,@ct
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@rID", MySqlDbType.Int32).Value = roomID;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@ct", MySqlDbType.VarChar).Value = city;

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
        public bool removeGuest(string id)
        {
            string removeQuery = "DELETE FROM `guests` WHERE `ID`=@id";
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
