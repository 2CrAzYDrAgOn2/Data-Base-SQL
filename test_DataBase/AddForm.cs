using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace test_DataBase
{
    public partial class AddForm : Form
    {
        private readonly DataBase dataBase = new DataBase();

        public AddForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            dataBase.OpenConnection();
            var naz = textBoxProdukciya.Text;
            var postavshik = textBoxPostavshik.Text;
            if (int.TryParse(textBoxPrice.Text, out int price) && int.TryParse(textBoxQuantinity.Text, out int quantinity))
            {
                var addQuery = $"insert into test_db (Название_Продукции, Количество, Поставщик, Цена) values ('{naz}', '{quantinity}', '{postavshik}', '{price}')";
                var sqlCommand = new SqlCommand(addQuery, dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Цена должна иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataBase.CloseConnection();
        }
    }
}