using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//BUNU GULAY YAPTI_22.11.2017 (MemberID_Dondur(), MemberEkle())
namespace HotelReservation.DAL
{
    public class MemberManagement:Connection
    {
        public string MemberID_Dondur(string identity, string password) //SubmitLogin_Click tetiklenince çalışacak. 
        {
            string memberID = "";
            string komut = "select MemberID from Member where password=@password and IdentityNo=@identity ";
            SqlCommand cmd = new SqlCommand(komut, _conn);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@identity", identity);
            _conn.Open();
            if (cmd.ExecuteScalar() != null)
            {
                memberID = cmd.ExecuteScalar().ToString();
            }
            _conn.Close();

            return memberID;
        }

        public bool MemberEkle(string kimlikNo, string firstName, string lastName, string email, string phone, string password) //submitRegister_Click tetiklenince çalışacak. 
        {
            SqlCommand cmd = new SqlCommand("sp_AddMember", _conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@identityNo", kimlikNo);
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phone);
            SqlParameter outputSonuc = new SqlParameter();
            outputSonuc.ParameterName = "@sonuc";
            outputSonuc.SqlDbType = SqlDbType.Bit;
            outputSonuc.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outputSonuc);

            _conn.Open();
            cmd.ExecuteNonQuery();
            bool sonuc = (bool)outputSonuc.Value;
            _conn.Close();

            return sonuc;
        }
    }
}
