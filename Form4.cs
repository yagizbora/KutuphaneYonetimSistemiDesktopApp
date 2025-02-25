using DotNetEnv;
using KutuphaneYonetimSistemi.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace KutuphaneYonetimSistemi
{
    public partial class Form4 : Form
    {
        SqlConnection? connection;


        public Form4()
        {
            InitializeComponent();
        }

        public void getalluser()
        {
            if (connection == null || connection.State == ConnectionState.Closed)
            {
                connection?.Open();
            }
            string query = "SELECT id, KullaniciAdi, Sifre FROM TableKutuphaneYoneticileri";
            SqlCommand response = new SqlCommand(query, connection);
            SqlDataReader reader = response.ExecuteReader();
            List<AdminUserModels> userlist = new List<AdminUserModels>();
            while (reader.Read())
            {
                AdminUserModels user = new AdminUserModels
                {
                    id = reader["id"] != DBNull.Value ? Convert.ToInt32(reader["id"]) : (int?)null,
                    KullanıcıAdı = reader["KullaniciAdi"].ToString(),
                    Şifre = reader["Sifre"].ToString()
                };
                userlist.Add(user);
            }
            reader.Close();
            dataGridView1.DataSource = userlist;
            DataTable dt = new DataTable();
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

                if (!string.IsNullOrEmpty(connectionString))
                {
                    getalluser();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + "\n" + (ex?.Message ?? "Bilinmeyen bir hata oluştu."));
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

                List<CreateUserModels> userModels = new List<CreateUserModels>();

                CreateUserModels createuser = new CreateUserModels
                {
                    username = textBoxusername.Text.Trim(),
                    password = textBoxpassword.Text.Trim()
                };

                if (string.IsNullOrEmpty(createuser.username) || string.IsNullOrEmpty(createuser.password)) 
                {
                    MessageBox.Show("Kullanıcı adı veya şifre boş olamaz!","Hata!");
                    return;
                }

                string query = "INSERT INTO TableKutuphaneYoneticileri (Kullaniciadi,Sifre) VALUES(@username,@password)";
                SqlCommand response = new(query, connection);
                response.Parameters.AddWithValue("@username", createuser.username);
                response.Parameters.AddWithValue("@password", createuser.password);

                response.ExecuteNonQuery();
                DialogResult result = MessageBox.Show("Hesap Oluşturuldu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    DialogResult result2 = MessageBox.Show("Giriş ekranına dönmek ister misiz? başka bir hesap açılacak mı?" + "\n" + "Giriş ekranına dönüş için Evet" + "\n" +
                        "Başka hesap açılışı için Hayır a tıklayınız", "Soru", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result2 == DialogResult.OK)
                    {
                        this.Hide();
                    }
                    else
                    {
                        getalluser();
                    }
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
        private void button2_Click(object sender, EventArgs e)
        {
            string? id = labeluserid.Text.ToString();
            string? newusername = textBoxEditusername.Text.ToString();
            string? newpassword = textBoxEditpassword.Text.ToString();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(newusername) || string.IsNullOrEmpty(newpassword))
            {
                MessageBox.Show("Lütfen değiştirmek istediğiniz kullanıcıyı seçiniz", "Hata");
                return;
            }
            if (!string.IsNullOrEmpty(id) || !string.IsNullOrEmpty(newusername) || !string.IsNullOrEmpty(newpassword))
            {
                try
                {
                    if (connection == null || connection.State == ConnectionState.Closed)
                    {
                        connection?.Open();
                    }
                    string query = "UPDATE TableKutuphaneYoneticileri SET kullaniciadi = @newusername,Sifre = @newpassword WHERE id = @id";
                    SqlCommand request = new(query, connection);
                    request.Parameters.AddWithValue("@newusername", newusername);
                    request.Parameters.AddWithValue("@newpassword", newpassword);
                    request.Parameters.AddWithValue("@id", id);
                    int affectedRows = request.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Kullanıcı bilgileri başarı ile değiştirldi!", "Uyarı");
                        getalluser();
                    }
                    else if (affectedRows == 0)
                    {
                        MessageBox.Show("Kullanıcı bilgileri değiştirelemedi veya bulunamadı bu sorun tekrarlanması halinde lütfen IT yöneticiniz ile iletişime geçin", "Uyarı",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Error);
                        getalluser();
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

        private void button3_Click(object sender, EventArgs e)
        {
            string id = labeluserid.Text.ToString();

            if (string.IsNullOrEmpty(id) || id == "-")
            {
                MessageBox.Show("Lütfen bir kullanıcı seçiniz", "Hata");
            }
            else
            {
                try
                {
                    if (connection == null || connection.State == ConnectionState.Closed)
                    {
                        connection?.Open();
                    }

                    string query = "DELETE FROM TableKutuphaneYoneticileri WHERE id = @id";
                    SqlCommand request = new(query, connection);
                    request.Parameters.AddWithValue("@id", id);

                    int affectedRows = request.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Kullanıcı başarı ile silindi!", "Uyarı");
                        getalluser();
                    }
                    else if (affectedRows == 0)
                    {
                        MessageBox.Show("Kullanıcı silinemedi veya bulunamadı bu sorun tekrarlanması halinde lütfen IT yöneticiniz ile iletişime geçin", "Uyarı",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Error);
                        getalluser();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Refresh();
                labeluserid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                textBoxEditusername.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();
                textBoxEditpassword.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxEditusername.Text = DBNull.Value.ToString();
            textBoxEditpassword.Text = DBNull.Value.ToString();
            labeluserid.Text = "-";
            dataGridView1.Refresh();
            getalluser();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection == null || connection.State == ConnectionState.Closed)
                {
                    connection?.Open();
                }
                string query = "SELECT * FROM TableKutuphaneYoneticileri WHERE 1=1";
                List<AdminUserModelsFilters> userlist = new List<AdminUserModelsFilters>();

                AdminUserModelsFilters filters = new AdminUserModelsFilters
                {
                    KullaniciAdi = textBoxfilterusername.Text.Trim(),
                    Sifre = textBoxfilterpassword.Text.Trim()
                };

                List<string> conditions = new List<string>();
                SqlCommand request = new SqlCommand();
                request.Connection = connection;

                if (!string.IsNullOrEmpty(textBoxfilterusername.Text))
                {
                    conditions.Add("Kullaniciadi LIKE @filterusername");
                    request.Parameters.AddWithValue("@filterusername", filters.KullaniciAdi + "%");
                }
                if (!string.IsNullOrEmpty(textBoxfilterpassword.Text))
                {
                    conditions.Add("Sifre LIKE @filterpassword");
                    request.Parameters.AddWithValue("@filterpassword", filters.Sifre + "%");
                }
                if (conditions.Count > 0)
                {
                    query += " AND " + string.Join(" AND ", conditions);
                }

                request.CommandText = query;
                SqlDataAdapter response = new(request);
                DataTable dt = new DataTable();
                response?.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Kayıt bulunamadı.");
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

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxfilterpassword.Text = "";
            textBoxfilterusername.Text = "";
            getalluser();
        }
    }
}
