using DotNetEnv;
using System.Data;
using System.Data.SqlClient;


namespace KutuphaneYonetimSistemi
{
    public partial class Form4 : Form
    {
        SqlConnection? connection;


        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
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
            try
            {
                if (connection == null || connection.State == ConnectionState.Closed)
                {
                    connection?.Open();
                }

                string query = "INSERT INTO TableKutuphaneYoneticileri (Kullaniciadi,Sifre) VALUES(@username,@password)";
                SqlCommand response = new(query, connection);
                response.Parameters.AddWithValue("@username", textBoxusername.Text);
                response.Parameters.AddWithValue("@password", textBoxpassword.Text);

                response.ExecuteNonQuery();
                MessageBox.Show("Hesap Oluşturuldu!");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Hata" + "\n" + ex.Message);
            } 
            finally
            {
                connection.Close();
            }

        }


    }
}
