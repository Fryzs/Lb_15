using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lb_15
{
    public partial class Form2 : Form
    {

        //Лист всіх юзерів
        List<User> users = new List<User>();

        public int userRoleId = -1;
        public int UserCounting = 0;
        public struct User
        {
            public string Login;
            public string Password;
            public int Access;

            public User(string login, string password, int access)
            {
                Login = login;
                Password = password;
                Access = access;
            }

        }
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Перевірка 
            foreach (var user in users)
            {
                if (user.Login == Login.Text && user.Password == Password.Text)
                {
                    userRoleId = user.Access;
                    break; 
                }else MessageBox.Show("Wrong login or password");
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] UserTXT = File.ReadAllLines("User.TXT");

            for (int i = 0; i < UserTXT.Length; i++)
            {
                if (UserTXT[i] == "/")
                {
                    i++;
                    users.Add(new User(UserTXT[i], UserTXT[i + 1], int.Parse(UserTXT[i + 2])));
                    i += 4;
                    UserCounting++;

                }

            }
        }
    }
}
