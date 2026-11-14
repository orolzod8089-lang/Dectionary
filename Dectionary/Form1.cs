
using Microsoft.Data.Sqlite;
using System.Data;

namespace Dectionary
{
    public partial class Form1 : Form
    {
        private readonly string dbPath =
            Path.Combine(AppContext.BaseDirectory, "Dectionary.db");

        private string ConnectionString =>
            $"Data Source={dbPath}";

        public Form1()
        {
            InitializeComponent();

            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            btnSave.Click += btnSave_Click;

            txtSearch.TextChanged += txtSearch_TextChanged;
            cmbLanguage.SelectedIndexChanged += cmbLanguage_SelectedIndexChanged;
            dgvWords.SelectionChanged += dgvWords_SelectionChanged;

            InitializeDatabase();
            SetupGrids();

            cmbLanguage.SelectedIndex = 0;

            LoadWords();
            LoadSavedWords();
        }

        // DATABASE ҮҮСГЭХ
        private void InitializeDatabase()
        {
            using var con = new SqliteConnection(ConnectionString);
            con.Open();

            using var cmd = con.CreateCommand();

            cmd.CommandText = @"
                PRAGMA foreign_keys = ON;

                CREATE TABLE IF NOT EXISTS words (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    english TEXT NOT NULL,
                    mongolian TEXT NOT NULL,
                    russian TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS saved_words (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    word_id INTEGER NOT NULL UNIQUE,
                    FOREIGN KEY (word_id)
                    REFERENCES words(id) ON DELETE CASCADE
                );
            ";

            cmd.ExecuteNonQuery();
        }

        // ХҮСНЭГТИЙН ТОХИРГОО
        private void SetupGrids()
        {
            dgvWords.AutoGenerateColumns = false;

            colNumber.DataPropertyName = "Number";
            colEnglish.DataPropertyName = "English";
            colMongolian.DataPropertyName = "Mongolian";
            colRussian.DataPropertyName = "Russian";

            dgvSaved.AutoGenerateColumns = true;
            dgvSaved.AllowUserToAddRows = false;
            dgvSaved.ReadOnly = true;
            dgvSaved.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvSaved.MultiSelect = false;

            label3.Text = "Dectionary.db · words";
            label4.Text = "Dectionary.db · saved_words";
        }

        // ҮГСИЙГ УНШИХ
        private void LoadWords()
        {
            using var con = new SqliteConnection(ConnectionString);
            con.Open();

            using var cmd = con.CreateCommand();

            string sql = @"
                SELECT id AS Id,
                       ROW_NUMBER() OVER (ORDER BY id) AS Number,
                       english AS English,
                       mongolian AS Mongolian,
                       russian AS Russian
                FROM words
                WHERE 1=1
            ";

            string search = txtSearch.Text.Trim();

            if (search != "")
            {
                sql += @"
                    AND (
                        english LIKE @search
                        OR mongolian LIKE @search
                        OR russian LIKE @search
                    )";
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
            }

            if (cmbLanguage.Text == "Англи")
                sql += " AND english LIKE @language";
            else if (cmbLanguage.Text == "Монгол")
                sql += " AND mongolian LIKE @language";
            else if (cmbLanguage.Text == "Орос")
                sql += " AND russian LIKE @language";

            if (cmbLanguage.Text != "Бүгд" &&
                cmbLanguage.Text != "")
            {
                if (cmbLanguage.Text == "Англи")
                    cmd.Parameters.AddWithValue("@language", "%" + search + "%");
                else if (cmbLanguage.Text == "Монгол")
                    cmd.Parameters.AddWithValue("@language", "%" + search + "%");
                else if (cmbLanguage.Text == "Орос")
                    cmd.Parameters.AddWithValue("@language", "%" + search + "%");
            }

            sql += " ORDER BY id DESC";

            cmd.CommandText = sql;

            DataTable table = new DataTable();

            using var reader = cmd.ExecuteReader();
            table.Load(reader);

            dgvWords.DataSource = table;

            UpdateStatus();
        }

        // ХАДГАЛСАН ҮГСИЙГ УНШИХ
        private void LoadSavedWords()
        {
            using var con = new SqliteConnection(ConnectionString);
            con.Open();

            using var cmd = con.CreateCommand();

            cmd.CommandText = @"
        SELECT
            w.english AS Үг
        FROM saved_words s
        INNER JOIN words w ON s.word_id = w.id
        ORDER BY s.id DESC;
    ";

            DataTable table = new DataTable();

            using var reader = cmd.ExecuteReader();
            table.Load(reader);

            dgvSaved.DataSource = table;

            dgvSaved.AutoGenerateColumns = true;
            dgvSaved.AllowUserToAddRows = false;
            dgvSaved.ReadOnly = true;
            dgvSaved.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvSaved.MultiSelect = false;

            UpdateStatus();
        }

        // ҮГ НЭМЭХ
        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEnglish.Text) ||
                string.IsNullOrWhiteSpace(txtMongolian.Text) ||
                string.IsNullOrWhiteSpace(txtRussian.Text))
            {
                MessageBox.Show("Бүх талбарыг бөглөнө үү!");
                return;
            }

            using var con = new SqliteConnection(ConnectionString);
            con.Open();

            using var cmd = con.CreateCommand();

            cmd.CommandText = @"
                INSERT INTO words (english, mongolian, russian)
                VALUES (@en, @mn, @ru);
            ";

            cmd.Parameters.AddWithValue("@en", txtEnglish.Text.Trim());
            cmd.Parameters.AddWithValue("@mn", txtMongolian.Text.Trim());
            cmd.Parameters.AddWithValue("@ru", txtRussian.Text.Trim());

            cmd.ExecuteNonQuery();

            LoadWords();
            ClearFields();

            MessageBox.Show("Үг амжилттай нэмэгдлээ!");
        }

        // ҮГ ЗАСАХ
        private void btnEdit_Click(object? sender, EventArgs e)
        {
            if (dgvWords.CurrentRow?.DataBoundItem is not DataRowView row)
            {
                MessageBox.Show("Засах үгээ сонгоно уу!");
                return;
            }

            int id = Convert.ToInt32(row["Id"]);

            using var con = new SqliteConnection(ConnectionString);
            con.Open();

            using var cmd = con.CreateCommand();

            cmd.CommandText = @"
                UPDATE words
                SET english=@en,
                    mongolian=@mn,
                    russian=@ru
                WHERE id=@id;
            ";

            cmd.Parameters.AddWithValue("@en", txtEnglish.Text.Trim());
            cmd.Parameters.AddWithValue("@mn", txtMongolian.Text.Trim());
            cmd.Parameters.AddWithValue("@ru", txtRussian.Text.Trim());
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            LoadWords();
            LoadSavedWords();

            MessageBox.Show("Үг амжилттай засагдлаа!");
        }

        // ҮГ УСТГАХ
        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvWords.CurrentRow?.DataBoundItem is not DataRowView row)
            {
                MessageBox.Show("Устгах үгээ сонгоно уу!");
                return;
            }

            int id = Convert.ToInt32(row["Id"]);

            if (MessageBox.Show(
                "Сонгосон үгийг устгах уу?",
                "Баталгаажуулалт",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            using var con = new SqliteConnection(ConnectionString);
            con.Open();

            using var cmd = con.CreateCommand();

            cmd.CommandText = "DELETE FROM words WHERE id=@id;";
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            LoadWords();
            LoadSavedWords();
            ClearFields();
        }

        // САНАХ
        private void btnSave_Click(object? sender, EventArgs e)
        {
            if (dgvWords.CurrentRow?.DataBoundItem is not DataRowView row)
            {
                MessageBox.Show("Эхлээд үгээ сонгоно уу!");
                return;
            }

            int id = Convert.ToInt32(row["Id"]);

            using var con = new SqliteConnection(ConnectionString);
            con.Open();

            using var cmd = con.CreateCommand();

            cmd.CommandText = @"
        INSERT OR IGNORE INTO saved_words (word_id)
        VALUES (@id);
    ";

            cmd.Parameters.AddWithValue("@id", id);

            int result = cmd.ExecuteNonQuery();

            LoadSavedWords();

            if (result > 0)
                MessageBox.Show("Үг амжилттай хадгалагдлаа!");
            else
                MessageBox.Show("Энэ үг өмнө нь хадгалагдсан байна!");
        }
        // ТАЛБАР ЦЭВЭРЛЭХ
        private void btnClear_Click(object? sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtEnglish.Clear();
            txtMongolian.Clear();
            txtRussian.Clear();
            dgvWords.ClearSelection();
        }

        // ХАЙЛТ
        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            LoadWords();
        }

        private void cmbLanguage_SelectedIndexChanged(object? sender, EventArgs e)
        {
            LoadWords();
        }

        // СОНГОСОН ҮГИЙГ TEXTBOX-Д ХАРУУЛАХ
        private void dgvWords_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvWords.CurrentRow?.DataBoundItem is not DataRowView row)
                return;

            txtEnglish.Text = row["English"].ToString();
            txtMongolian.Text = row["Mongolian"].ToString();
            txtRussian.Text = row["Russian"].ToString();
        }

        // ТӨЛӨВ ШИНЭЧЛЭХ
        private void UpdateStatus()
        {
            int total = dgvWords.Rows.Count;
            int saved = dgvSaved.Rows.Count;

            lblStatus.Text = $"Нийт: {total} үг · Санасан: {saved}";
        }

        // DESIGNER-ТЭЙ ХОЛБОГДСОН EVENT
        private void label2_Click(object? sender, EventArgs e)
        {
        }

        private void statusStrip1_ItemClicked(
            object? sender,
            ToolStripItemClickedEventArgs e)
        {
        }
    }
}
