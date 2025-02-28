using DotNetEnv;
using KutuphaneYonetimSistemi.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace KutuphaneYonetimSistemi
{
    public partial class Form2 : Form
    {
        SqlConnection? connection;

        public Form2()
        {
            InitializeComponent();
        }

        // METHOD AREA
        public void Showdata()
        {
            try
            {
                if (connection == null || connection.State == ConnectionState.Closed)
                {
                    connection?.Open();
                }
                string query = "" +
                     "SELECT book.ID," +
                     "book.KitapAdi as [Kitap Adı]," +
                     "book.YazarAdi as [Yazar Adı]," +
                     "book.YazarSoyadi as [Yazar Soyadı]," +
                     "book.ISBN,book.Durum," +
                     "book.OduncAlan as [Ödünç Alan]," +
                     "book.OduncAlmaTarihi as [Ödünç Alma Tarihi]," +
                     "book.KitapTurKodu as [Kitap Tür Kodu], " +
                      "booktype.Aciklama as [Açıklama]" +
                    "FROM TableKitaplar book JOIN TableKitapTurleri booktype ON booktype.KitapTurKodu = book.KitapTurKodu";
                SqlCommand response = new(query, connection);
                SqlDataReader result = response.ExecuteReader();
                dataGridViewKitaplar.DataSource = null;
                dataGridViewKitaplar.Columns.Clear();

                List<BookModels> bookresult = new List<BookModels>();

                while (result.Read())
                {
                    BookModels books = new BookModels
                    {
                        ID = result["ID"] != DBNull.Value ? Convert.ToInt32(result["ID"]) : null,
                        KitapAdi = result["Kitap Adı"].ToString(),
                        YazarAdi = result["Yazar Adı"].ToString(),
                        YazarSoyadi = result["Yazar Soyadı"].ToString(),
                        ISBN = result["ISBN"].ToString(),
                        Durum = result["Durum"] != DBNull.Value ? Convert.ToBoolean(result["Durum"]) : null,
                        OduncAlan = result["Ödünç Alan"].ToString(),
                        OduncAlmaTarihi = result["Ödünç Alma Tarihi"] != DBNull.Value
                            ? DateOnly.FromDateTime(Convert.ToDateTime(result["Ödünç Alma Tarihi"]))
                            : (DateOnly?)null,
                        KitapTurKodu = result["Kitap Tür Kodu"] != DBNull.Value ? (int?)result["Kitap Tür Kodu"] : null,
                        Aciklama = result["Açıklama"].ToString()
                    };
                    bookresult.Add(books);
                }

                dataGridViewKitaplar.AutoGenerateColumns = false;

                dataGridViewKitaplar.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "ID",
                    DataPropertyName = "ID",
                    DisplayIndex = 0
                });

                dataGridViewKitaplar.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Kitap Adı",
                    DataPropertyName = "KitapAdi",
                    DisplayIndex = 1
                });

                dataGridViewKitaplar.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Yazar Adı",
                    DataPropertyName = "YazarAdi",
                    DisplayIndex = 2
                });

                dataGridViewKitaplar.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Yazar Soyadı",
                    DataPropertyName = "YazarSoyadi",
                    DisplayIndex = 3
                });

                dataGridViewKitaplar.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "ISBN",
                    DataPropertyName = "ISBN",
                    DisplayIndex = 4
                });

                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
                {
                    HeaderText = "Durum",
                    DataPropertyName = "Durum",
                    TrueValue = true,
                    FalseValue = false,
                    DisplayIndex = 5 
                };
                dataGridViewKitaplar.Columns.Add(checkBoxColumn);

                dataGridViewKitaplar.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Ödünç Alan",
                    DataPropertyName = "OduncAlan",
                    DisplayIndex = 6
                });

                dataGridViewKitaplar.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Ödünç Alma Tarihi",
                    DataPropertyName = "OduncAlmaTarihi",
                    DisplayIndex = 7
                });

                dataGridViewKitaplar.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Kitap Tür Kodu",
                    DataPropertyName = "KitapTurKodu",
                    DisplayIndex = 8
                });

                dataGridViewKitaplar.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Açıklama",
                    DataPropertyName = "Aciklama",
                    DisplayIndex = 9
                });

                dataGridViewKitaplar.DataSource = bookresult;
                DataTable dt = new DataTable();
            }catch(Exception ex)
            {
                MessageBox.Show("Hata: " + "\n" + (ex?.Message ?? "Bilinmeyen bir hata oluştu."));
                Console.WriteLine(ex?.Message);
            }
            finally
            {
                connection?.Close();
            }
        }
        public void Showtypebook()
        {
            string query = "SELECT * FROM TableKitapTurleri";
            SqlDataAdapter response = new(query, connection);
            DataTable dt = new DataTable();
            response?.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        public static (bool isValid, string message) CheckKitapId(string kitapId)
        {
            try
            {
                if (string.IsNullOrEmpty(kitapId) || kitapId == "-")
                {
                    return (false, "Geçersiz kitap ID");
                }

                return (true, "Başarılı");
            }
            catch (Exception ex)
            {
                return (false, $"Hata oluştu: {ex.Message}");
            }
        }


        private bool IsBookAvailable(int id)
        {
            try
            {
                if (connection == null || connection.State == ConnectionState.Closed)
                {
                    connection?.Open();
                }

                string query = "SELECT Durum FROM TableKitaplar WHERE ID = @id";
                SqlCommand response = new(query, connection);
                response.Parameters.AddWithValue("id", id);

                Object result = response.ExecuteScalar();

                if (result != null)
                {
                    bool isAvailable = Convert.ToBoolean(result);
                    return isAvailable;
                }
                else
                {
                    MessageBox.Show("Kitap bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + "\n" + (ex?.Message ?? "Bilinmeyen bir hata oluştu."));
                return false;
            }
            finally
            {
                connection?.Close();
            }

        }
        // METHOD AREA



        private void Form2_Load(object sender, EventArgs e)
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
                    Showdata();

                    dataGridViewKitaplar.ReadOnly = true;
                    dataGridView1.ReadOnly = true;

                    Showtypebook();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası: " + ex.Message);
            }
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void buttonKitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                connection?.Open();
                string query = "SELECT COUNT(*) as count FROM TableKitapTurleri WHERE KitapTurKodu = @KitapTurKodu";
                SqlCommand response = new SqlCommand(query, connection);
                response.Parameters.AddWithValue("@KitapTurKodu", textBoxKitapTurKodu.Text);

                int check = (int)response.ExecuteScalar();

                if (check == 0)
                {
                    MessageBox.Show("Kitap Tür kodu yanlış");
                    return;
                }

                // Boş alan kontrolü
                if (string.IsNullOrWhiteSpace(textBoxKitapAdi.Text) ||
                    string.IsNullOrWhiteSpace(textBoxYazarAdi.Text) ||
                    string.IsNullOrWhiteSpace(textBoxYazarSoyadi.Text) ||
                    string.IsNullOrWhiteSpace(textBoxISBN.Text) ||
                    string.IsNullOrWhiteSpace(textBoxKitapTurKodu.Text))
                {
                    MessageBox.Show("Tüm alanlar doldurulmalıdır!");
                    return;
                }

                string addquery = "INSERT INTO TableKitaplar (KitapAdi, YazarAdi, YazarSoyadi, ISBN, Durum, KitapTurKodu) " +
                                  "VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";

                SqlCommand responses = new SqlCommand(addquery, connection);
                responses.Parameters.AddWithValue("@p1", textBoxKitapAdi.Text);
                responses.Parameters.AddWithValue("@p2", textBoxYazarAdi.Text);
                responses.Parameters.AddWithValue("@p3", textBoxYazarSoyadi.Text);
                responses.Parameters.AddWithValue("@p4", textBoxISBN.Text);
                responses.Parameters.AddWithValue("@p5", "True");
                responses.Parameters.AddWithValue("@p6", textBoxKitapTurKodu.Text);

                responses?.ExecuteNonQuery();
                MessageBox.Show("Kitap başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + "\n" + (ex?.Message ?? "Bilinmeyen bir hata oluştu."));

            }
            finally
            {
                connection?.Close();
            }

            Showdata();
        }


        private void dataGridViewKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chooseline = dataGridViewKitaplar.SelectedCells[0].RowIndex;
            kitapid.Text = dataGridViewKitaplar.Rows[chooseline].Cells[0].Value?.ToString();
            textBoxKitapAdi.Text = dataGridViewKitaplar.Rows[chooseline].Cells[1].Value?.ToString();
            textBoxYazarAdi.Text = dataGridViewKitaplar.Rows[chooseline].Cells[2].Value?.ToString();
            textBoxYazarSoyadi.Text = dataGridViewKitaplar.Rows[chooseline].Cells[3].Value?.ToString();
            textBoxISBN.Text = dataGridViewKitaplar.Rows[chooseline].Cells[4].Value?.ToString();
            textBoxKitapTurKodu.Text = dataGridViewKitaplar.Rows[chooseline].Cells[8].Value?.ToString();
            textBoxOduncAlan.Text = dataGridViewKitaplar.Rows[chooseline].Cells[6].Value?.ToString();

            if (dataGridViewKitaplar.Rows[chooseline].Cells[7].Value != DBNull.Value &&
                dataGridViewKitaplar.Rows[chooseline].Cells[7].Value != null)
            {
                DateTime tarih = Convert.ToDateTime(dataGridViewKitaplar.Rows[chooseline].Cells[7].Value);

                if (tarih >= dateTimePicker1.MinDate && tarih <= dateTimePicker1.MaxDate)
                {
                    dateTimePicker1.Value = tarih;
                }
                else
                {
                    dateTimePicker1.Value = DateTime.Today; 
                }
            }
            else
            {
                dateTimePicker1.Value = DateTime.Today; 
            }


        }

        private void buttonKitapBilgiGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (kitapid.Text == "-" || string.IsNullOrEmpty(kitapid.Text))
                {
                    MessageBox.Show("Kitap seçmeden güncelleme işlemi yapılamaz!");
                }
                else
                {
                    connection?.Open();
                    string query = "UPDATE TableKitaplar SET KitapAdi = @p1, YazarAdi = @p2, YazarSoyadi = @p3, ISBN = @p4, KitapTurKodu = @p5 WHERE ID = @p6";
                    SqlCommand response = new SqlCommand(query, connection);
                    response.Parameters.AddWithValue("@p1", textBoxKitapAdi.Text);
                    response.Parameters.AddWithValue("@p2", textBoxYazarAdi.Text);
                    response.Parameters.AddWithValue("@p3", textBoxYazarSoyadi.Text);
                    response.Parameters.AddWithValue("@p4", textBoxISBN.Text);
                    response.Parameters.AddWithValue("@p5", textBoxKitapTurKodu.Text);
                    response.Parameters.AddWithValue("@p6", kitapid.Text);
                    response?.ExecuteNonQuery();
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
            Showdata();
        }

        private void buttonKitabiOduncVer_Click(object sender, EventArgs e)
        {
            try
            {
                if (kitapid.Text == "-" || string.IsNullOrEmpty(kitapid.Text))
                {
                    MessageBox.Show("Kitap seçmeden güncelleme işlemi yapılamaz!");
                }

                else
                {
                    connection?.Open();
                    string query = "UPDATE TableKitaplar SET OduncAlan = @p1, OduncAlmaTarihi = @p2,Durum = @p3 WHERE ID = @p4";
                    SqlCommand response = new SqlCommand(query, connection);
                    response.Parameters.AddWithValue("@p1", textBoxOduncAlan.Text);
                    response.Parameters.AddWithValue("@p2", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                    response.Parameters.AddWithValue("@p3", "False");
                    response.Parameters.AddWithValue("@p4", kitapid.Text);
                    response?.ExecuteNonQuery();
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
            Showdata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxBookType.Text))
            {
                MessageBox.Show("Kitap Türü boş olamaz!");
                return;
            }
            try
            {
                connection?.Open();
                string query = "INSERT INTO TableKitapTurleri (Aciklama) VALUES(@BookType)";

                SqlCommand request = new SqlCommand(query, connection);
                request.Parameters.AddWithValue("@BookType", textBoxBookType.Text);
                int response = request.ExecuteNonQuery();
                if (response == 1)
                {
                    textBoxBookType.Text = "";
                    Showtypebook();
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

        [Obsolete]
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (kitapid.Text == "-" || string.IsNullOrEmpty(kitapid.Text))
                {
                    MessageBox.Show("Kitap seçmeden hesaplama işlemi yapılamaz!");
                }
                else
                {
                    if (connection == null || connection.State == ConnectionState.Closed)
                    {
                        connection?.Open();
                    }
                    string query = "UPDATE TableKitaplar SET OduncAlan = @p1, OduncAlmaTarihi = @p2, Durum = @p3 WHERE ID = @p4"
                    SqlCommand response = new SqlCommand(
                        query,
                        connection);

                    response.Parameters.AddWithValue("@p1", DBNull.Value);
                    response.Parameters.Add("@p2", SqlDbType.Date).Value = DBNull.Value;
                    response.Parameters.AddWithValue("@p3", true);
                    response.Parameters.AddWithValue("@p4", kitapid.Text);
                    response?.ExecuteNonQuery();
                    textBoxOduncAlan.Text = "";
                    labelgecikmebedeli.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + "\n" + (ex?.Message ?? "Bilinmeyen bir hata oluştu."));
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection?.Close();
                }
            }
            Showdata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kitapid.Text == "-" || string.IsNullOrEmpty(kitapid.Text))
            {
                MessageBox.Show("Kitap seçmeden hesaplama yapılamaz işlemi yapılamaz!");
            }
            else
            {
                DateTime todaydate = DateTime.Now;
                int calculateday = (int)(todaydate - dateTimePicker1.Value.Date).TotalDays;

                if (calculateday > 10)
                {
                    int delayallowance = (int)(calculateday - 10) * 1;
                    labelgecikmebedeli.Text = delayallowance.ToString();
                }
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonara_Click(object sender, EventArgs e)
        {
            try
            {
                connection?.Open();

                string query = "SELECT * FROM TableKitaplar WHERE 1=1";

                List<string> conditions = new List<string>();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                if (!string.IsNullOrWhiteSpace(textBoxKitapAdi.Text))
                {
                    conditions.Add("KitapAdi LIKE @KitapAdi");
                    command.Parameters.AddWithValue("@KitapAdi", textBoxKitapAdi.Text + "%");
                }
                if (!string.IsNullOrWhiteSpace(textBoxYazarAdi.Text))
                {
                    conditions.Add("YazarAdi LIKE @YazarAdi");
                    command.Parameters.AddWithValue("@YazarAdi", textBoxYazarAdi.Text + "%");
                }
                if (!string.IsNullOrWhiteSpace(textBoxYazarSoyadi.Text))
                {
                    conditions.Add("YazarSoyAdi LIKE @YazarSoyAdi");
                    command.Parameters.AddWithValue("@YazarSoyAdi", textBoxYazarSoyadi.Text + "%");
                }
                if (!string.IsNullOrWhiteSpace(textBoxISBN.Text))
                {
                    conditions.Add("ISBN LIKE @ISBN");
                    command.Parameters.AddWithValue("@ISBN", textBoxISBN.Text + "%");
                }
                if (!string.IsNullOrWhiteSpace(textBoxKitapTurKodu.Text))
                {
                    conditions.Add("KitapTurKodu LIKE @KitapTurKodu");
                    command.Parameters.AddWithValue("@KitapTurKodu", textBoxKitapTurKodu.Text + "%");
                }

                if (conditions.Count > 0)
                {
                    query += " AND " + string.Join(" AND ", conditions);
                }

                command.CommandText = query;

                SqlDataAdapter response = new(command);
                DataTable dt = new DataTable();
                response?.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewKitaplar.DataSource = dt;
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


        private void buttonKitapSilme_Click(object sender, EventArgs e)
        {
            try
            {
                if (kitapid.Text == "-" || string.IsNullOrEmpty(kitapid.Text))
                {
                    MessageBox.Show("Kitap seçmeden hesaplama işlemi yapılamaz!");
                }
                else
                {
                    int kitapId = int.Parse(kitapid.Text);
                    if (!IsBookAvailable(kitapId))
                    {
                        MessageBox.Show("Bu kitap ödünç alınamaz! Silinemez!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (connection == null || connection.State == ConnectionState.Closed)
                    {
                        connection?.Open();
                    }
                    string query = "DELETE FROM TableKitaplar WHERE ID = @id";
                    SqlCommand response = new(query, connection);
                    response.Parameters.AddWithValue("@id", kitapid.Text);
                    int affectedRows = response.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        DialogResult result = MessageBox.Show("Kitap başarıyla silindi! Devam etmek ister misiniz?",
                                                             "Başarılı",
                                                             MessageBoxButtons.OKCancel,
                                                             MessageBoxIcon.Information);

                        if (result == DialogResult.OK)
                        {
                            Showdata();
                            Showtypebook();
                        }
                        else
                        {
                            Showdata();
                            Showtypebook();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Silinecek kitap bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void buttonClearFilter_Click(object sender, EventArgs e)
        {
            var (isValid, message) = CheckKitapId(kitapid?.Text?.ToString() ?? "");
            string kitapidtext = kitapid?.Text?.ToString() ?? "";

            if (!isValid || string.IsNullOrWhiteSpace(kitapidtext) || string.IsNullOrEmpty(textBoxKitapAdi?.Text))
            {
                DialogResult result = MessageBox.Show("Bir kitap seçmeden temizle butonu kullanılamaz!", "Hata", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    DialogResult result1 = MessageBox.Show("Tüm verileri tekrardan yenilememi ister misiniz?", "Soru?", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {

                        Showtypebook();
                        Showdata();
                    }
                }
                return;
            }

            if ((textBoxKitapAdi != null && !string.IsNullOrEmpty(textBoxKitapAdi.Text))
                || (textBoxKitapTurKodu != null && !string.IsNullOrEmpty(textBoxKitapTurKodu.Text))
                || (textBoxISBN != null && !string.IsNullOrEmpty(textBoxISBN.Text))
                || (textBoxYazarAdi != null && !string.IsNullOrEmpty(textBoxYazarAdi.Text))
                || (textBoxYazarSoyadi != null && !string.IsNullOrEmpty(textBoxYazarSoyadi.Text))
                || (textBoxOduncAlan != null && !string.IsNullOrEmpty(textBoxOduncAlan.Text)))
            {
                if (textBoxISBN != null) textBoxISBN.Text = "";
                if (textBoxKitapAdi != null) textBoxKitapAdi.Text = "";
                if (textBoxKitapTurKodu != null) textBoxKitapTurKodu.Text = "";
                if (textBoxOduncAlan != null) textBoxOduncAlan.Text = "";
                if (textBoxYazarAdi != null) textBoxYazarAdi.Text = "";
                if (textBoxYazarSoyadi != null) textBoxYazarSoyadi.Text = "";
                if (kitapid != null) kitapid.Text = "-";
            }
        }

        private void buttonDeleteBookType_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("Lütfen bir satır seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int chooseline = dataGridView1.SelectedCells[0].RowIndex;
            string? id = dataGridView1.Rows[chooseline].Cells[0].Value?.ToString();

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Lütfen Kitap Türü seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                connection?.Open();

                string query = "DELETE FROM TableKitapTurleri WHERE KitapTurKodu = @id";
                SqlCommand response = new(query, connection);
                response.Parameters.AddWithValue("@id", id);
                int checkresult = response.ExecuteNonQuery();

                if (checkresult > 0)
                {
                    MessageBox.Show("Kitap Türü başarı ile silindi");
                    Showtypebook();
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int chooseline = dataGridView1.SelectedCells[0].RowIndex;
            string? id = dataGridView1.Rows[chooseline].Cells[0].Value?.ToString();

            textBoxKitapTurKodu.Text = id?.ToString();
        }
    }
}