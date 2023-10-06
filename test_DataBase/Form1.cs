using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace test_DataBase
{
    internal enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Form1 : Form
    {
        private readonly DataBase dataBase = new DataBase();
        private int selectedRow;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Номер", "Номер");
            dataGridView1.Columns.Add("Название_Продукции", "Название продукции");
            dataGridView1.Columns.Add("Количество", "Количество");
            dataGridView1.Columns.Add("Поставщик", "Поставщик");
            dataGridView1.Columns.Add("Цена", "Цена");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ClearFields()
        {
            textBoxNumber.Text = "";
            textBoxProdukciya.Text = "";
            textBoxQuantinity.Text = "";
            textBoxPostavshik.Text = "";
            textBoxPrice.Text = "";
        }

        private void ReadSingleRow(DataGridView dataGridView, IDataRecord iDataRecord)
        {
            dataGridView.Rows.Add(iDataRecord.GetInt32(0), iDataRecord.GetString(1), iDataRecord.GetInt32(2), iDataRecord.GetString(3), iDataRecord.GetInt32(4), RowState.Modified);
        }

        private void RefreshDataGrid(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            string queryString = $"select * from test_db";
            SqlCommand sqlCommand = new SqlCommand(queryString, dataBase.GetConnection());
            dataBase.OpenConnection();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                ReadSingleRow(dataGridView, sqlDataReader);
            }
            sqlDataReader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[selectedRow];
                textBoxNumber.Text = dataGridViewRow.Cells[0].Value.ToString();
                textBoxProdukciya.Text = dataGridViewRow.Cells[1].Value.ToString();
                textBoxQuantinity.Text = dataGridViewRow.Cells[2].Value.ToString();
                textBoxPostavshik.Text = dataGridViewRow.Cells[3].Value.ToString();
                textBoxPrice.Text = dataGridViewRow.Cells[4].Value.ToString();
            }
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
        }

        private void Search(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            string searchString = $"select * from test_db where concat (Номер, Название_Продукции, Количество, Поставщик, Цена) like '%" + textBoxSearch.Text + "%'";
            SqlCommand sqlCommand = new SqlCommand(searchString, dataBase.GetConnection());
            dataBase.OpenConnection();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                ReadSingleRow(dataGridView, sqlDataReader);
            }
            sqlDataReader.Close();
        }

        private void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
        }

        private void UpdateBase()
        {
            dataBase.OpenConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;
                if (rowState == RowState.Existed)
                {
                    continue;
                }
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from test_db where Номер = {id}";
                    var sqlCommand = new SqlCommand(deleteQuery, dataBase.GetConnection());
                    sqlCommand.ExecuteNonQuery();
                }
                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var naz = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var quantinity = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var postavshik = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var price = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var changeQuery = $"update test_db set Название_Продукции = '{naz}', Количество = '{quantinity}', Поставщик = '{postavshik}', Цена = '{price}' where Номер = '{id}'";
                    var sqlCommand = new SqlCommand(changeQuery, dataBase.GetConnection());
                    sqlCommand.ExecuteNonQuery();
                }
            }
            dataBase.CloseConnection();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DeleteRow();
            ClearFields();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            UpdateBase();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var id = textBoxNumber.Text;
            var naz = textBoxProdukciya.Text;
            var quantinity = textBoxQuantinity.Text;
            var postavshik = textBoxPostavshik.Text;
            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBoxPrice.Text, out int price))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, naz, quantinity, postavshik, price);
                    dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Цена должна иметь числовой формат!");
                }
            }
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}