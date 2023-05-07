using DTA_2022_23_Battleship.Model.DataBase;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.Text;

namespace DTA_2022_23_Battleship.Model
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        private string Hash(string password)
        {
            MD5 MD5Hash = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(password);
            byte[] hash = MD5Hash.ComputeHash(inputBytes);
            return Convert.ToHexString(hash);
        }
        private void EnterClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text)
                || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Fill in all the fields!");
                return;
            }
            var passsword = Hash(textBoxPassword.Text);
            var user = DataBaseService.DataBaseContext.Users.
                FirstOrDefault(u => u.Name == textBoxLogin.Text
                && u.Password == passsword);

            if (user is null)
            {
                MessageBox.Show("User is not found!");
                return;
            }
            if (!user.IsAсtive)
            {
                MessageBox.Show("User deactivated!");
                return;
            }

            MessageBox.Show("Login successfully!");
            Hide();
            var batteship = new BattleshipGame(new Game(), user);
            batteship.ShowDialog();
            Close();
        }

        private void RegistrationClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text)
                            || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Fill in all the fields!");
                return;
            }
            try
            {
                var user = new User();
                user.Name = textBoxLogin.Text;
                user.Password = Hash(textBoxPassword.Text);

                user.BornDate = dateTimePicker1.Value;
                user.IsAdministration = checkBoxAdmin.Checked;
                user.IsAсtive = true;
                if (DataBaseService.DataBaseContext.Users.Where(u => u.Name == user.Name).FirstOrDefault() is not null)
                {
                    MessageBox.Show("The database already has a user with the given name!");
                    return;
                }

                DataBaseService.DataBaseContext.Users.Add(user);
                DataBaseService.DataBaseContext.SaveChanges();

                MessageBox.Show("Registration successfully completed!");

                Hide();
                var batteship = new BattleshipGame(new Game(), user);
                batteship.ShowDialog();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            // гарантируем, что база данных создана
            DataBaseService.DataBaseContext.Database.EnsureCreated();
            // загружаем данные из БД
            DataBaseService.DataBaseContext.Statistics.Load();
            DataBaseService.DataBaseContext.Users.Load();

            DataBaseService.DataBaseContext.SaveChanges();
        }
    }
}
