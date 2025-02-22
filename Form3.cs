using DotNetEnv;
using System.Data;
using System.Data.SqlClient;

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
                MessageBox.Show("Bağlantı hatası: " + ex.Message);
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

                string query = "SELECT COUNT(password) as Count FROM TableAdminPasswordCheck WHERE password = @password";
                SqlCommand response = new(query, connection);
                response.Parameters.AddWithValue("@password", textBoxpassword.Text);

                int? checkresponse = (int)response.ExecuteScalar();

                if (checkresponse == 0)
                {
                    MessageBox.Show("Şifre yanlış!","Hata!");
                    return;
                }

                if (checkresponse == 1)
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
                MessageBox.Show("Veri okunamadı. Lütfen veritabanını kontrol edin. Eğer yetkii değilseniz lütfen IT departmaanı ile iletişime geçiniz! " +
                    "\n" +
                    "Hata Mesajı:" +
                    "\n" +
                    ex.Message, "HATA!");
            }
            finally
            {
                connection?.Close();
            }

        }


    }
}
