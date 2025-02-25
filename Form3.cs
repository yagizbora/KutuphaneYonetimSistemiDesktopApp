using DotNetEnv;
using System.Data;
using KutuphaneYonetimSistemi.Models;
using Microsoft.Data.SqlClient;

namespace KutuphaneYonetimSistemi
{
    public partial class Form3 : Form
    {
        SqlConnection? connection;


        public Form3()
        {
            InitializeComponent();
        }

        Form4? formcreateuser;


        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                Env.Load();
                string connectionString = Env.GetString("DB_CONNECTION_STRING");

                if (string.IsNullOrEmpty(connectionString))
                {
                    MessageBox.Show("Bağlantı dizesi null veya boş. Lütfen .env dosyasını kontrol edin.");
                    return;
                }

                connection = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + "\n" + (ex?.Message ?? "Bilinmeyen bir hata oluştu."));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool truepassword = false;
            try
            {
                if (connection == null || connection.State == ConnectionState.Closed)
                {
                    connection?.Open();
                }
                List<AdminUserAuthModels> auth = new List<AdminUserAuthModels> ();

                AdminUserAuthModels checkpassword = new AdminUserAuthModels
                {
                    password = textBoxpassword.Text.Trim()
                };

                if(string.IsNullOrEmpty(checkpassword.password))
                {
                    MessageBox.Show("Şifre boş olamaz!","Hata!");
                    return;
                }

                string query = "SELECT COUNT(password) as Count FROM TableAdminPasswordCheck WHERE password = @password";
                SqlCommand response = new(query, connection);
                response.Parameters.AddWithValue("@password", checkpassword.password);
                int? checkresponse = (int)response.ExecuteScalar();



                if (checkresponse == 0)
                {
                    MessageBox.Show("Şifre yanlış!","Hata!");
                    return;
                }

                if (checkresponse >= 1)
                {
                    truepassword = true;
                }

                if (truepassword == true)
                {
                    formcreateuser = new Form4();

                    formcreateuser.Show();
                    this.Hide();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + "\n" + (ex?.Message ?? "Bilinmeyen bir hata oluştu."));

            }
            finally
            {
                connection?.Close();
            }

        }
    }
}
