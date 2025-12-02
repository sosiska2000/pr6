using MySql.Data.MySqlClient;
using System;


namespace RegIn.Classes
{
    public class User
    {
        public int Id { get; set; } 
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public byte[] Image {  get; set; }
        public DateTime DateUpdate {  get; set; }
        public DateTime DateCreate {  get; set; }
        public CorrectLogin HandlerCorrectLogin;
        public InCorrectLogin HandlerInCorrectLogin;
        public delegate void CorrectLogin();
        public delegate void InCorrectLogin();

        public void GetUserLogin(string login)
        {
            this.Id = -1;
            this.Login = String.Empty;
            this.Password = String.Empty;
            this.Name = String.Empty;
            this.Image = new byte[0];

            MySqlConnection connection = Connection.OpenConnection();
            if (Connection.OpenConnection(connection))
            {
                MySqlDataReader userData = Connection.Query("SELECT * FROM 'users' WHERE 'login' = {login}", connection);
                if (userData.HasRows)
                {
                    userData.Read();
                    this.Id = userData.GetInt32(0);
                    this.Login = userData.GetString(1);
                    this.Password = userData.GetString(2);
                    this.Name = userData.GetString(3);
                    if(userData.IsDBNull(4) == false)
                    {
                        this.Image = new byte[64 * 1024];
                        userData.GetBytes(4, 0, Image, 0, Image.Length);
                    }
                    this.DateUpdate = userData.GetDateTime(5);
                    this.DateCreate = userData.GetDateTime(6);

                    HandlerCorrectLogin.Invoke();
                }
                else HandlerCorrectLogin.Invoke();
            }
            else
            {
                HandlerCorrectLogin.Invoke();
            }
        }
    }
}
