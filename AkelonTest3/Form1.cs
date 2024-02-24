using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AkelonTest3.Models;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2010.Excel;
using Irony.Parsing;
using static AkelonTest3.Models.ColumnIndices;

namespace AkelonTest3
{
    public partial class Form1 : Form
    {
        private string filePath;
        private XLWorkbook workbook;
        private IXLWorksheet products;
        private IXLWorksheet clients;
        private IXLWorksheet orders;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_ContactName.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        #region Download file
        private void button1_Click(object sender, EventArgs e)//кнопка загрузки файла
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog = ImportFile(openFileDialog);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Получаем путь к выбранному файлу
                filePath = openFileDialog.FileName;

                textBox_path.Text = filePath;

                try
                {
                    workbook = new XLWorkbook(filePath);
                    products = workbook.Worksheet("Товары");
                    clients = workbook.Worksheet("Клиенты");
                    orders = workbook.Worksheet("Заявки");

                    LoadProductNames();
                    LoadClientNames();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки данных из файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private OpenFileDialog ImportFile(OpenFileDialog openFileDialog_import)//импорт файла
        {
            openFileDialog_import.InitialDirectory = "c:\\";
            openFileDialog_import.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"; // Устанавливаем фильтр для файлов Excel
            openFileDialog_import.FilterIndex = 2;
            openFileDialog_import.RestoreDirectory = true;
            return openFileDialog_import;
        }

        private void LoadProductNames()//загрузка названий продуктов для комбо бокса продуктов
        {
            var productNameCells = products.Column(Products.Name).CellsUsed().Skip(1); // Пропускаем заголовок
            var productNames = productNameCells.Select(cell => cell.Value.ToString()).ToArray();

            comboBoxProducts.Items.Clear();
            comboBoxProducts.Items.AddRange(productNames);
        }

        private void LoadClientNames()//загрузка организаций клиентов для комбо бокса компаний
        {
            var contactNameCells = clients.Column(Clients.Name).CellsUsed().Skip(1); // Пропускаем заголовок
            var contactNames = contactNameCells.Select(sell => sell.Value.ToString()).ToArray();

            comboBox_ContactName.Items.Clear();
            comboBox_ContactName.Items.AddRange(contactNames);
        }
        #endregion
     

        #region Show Info
        private void buttonShowInfo_Click(object sender, EventArgs e)//кнопка показать информацию о продукте
        {
            string selectedProduct = GetSelectedProduct();

            if (string.IsNullOrEmpty(selectedProduct))
            {
                MessageBox.Show("Пожалуйста, выберите товар.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Инфомация о продукте
            var productInfo = GetProductInfo(selectedProduct);

            // Ищем заказы для выбранного товара
            var ordersForProduct = GetOrdersForProduct(productInfo.Item1);

            InfoText.Text = "";
            InfoText.AppendText ($"Товар: {selectedProduct}" + Environment.NewLine);//Объявляем по какому продукту ищем информацию

            foreach (var order in ordersForProduct)
            {
                string clientId = order.Cell(Orders.idClient).Value.ToString(); // Получаем название организации заказчика

                var clientInfo = GetClientInfo(clientId);

                if (clientInfo.Item2 != null)
                {
                    string countProduct = order.Cell(Orders.CountProduct).Value.ToString();
                    decimal strPrice = Convert.ToDecimal(productInfo.Item2.Cell(Products.Price).Value.ToString());
                    decimal price = strPrice * Convert.ToDecimal(countProduct);

                    var orderInfo = new OrderInfo
                    {
                        Id = order.Cell(Orders.idOrder).Value.ToString(),
                        OrganizationName = clientInfo.Item2.Cell(Clients.Name).Value.ToString(),
                        CountProducts = countProduct,
                        Price = price,
                        Date = order.Cell(Orders.Date).Value.ToString()
                    };

                    InfoText.AppendText(orderInfo.GetOrderInfoString());
                }
            }   
        }

        private string GetSelectedProduct()
        {
            return comboBoxProducts.SelectedItem?.ToString();
        }

        private (int, IXLRow) GetProductInfo(string selectedProduct)
        {
            var productInfo = products.RowsUsed()
                .FirstOrDefault(row => row.Cell(Products.Name).Value.ToString().Equals(selectedProduct, StringComparison.OrdinalIgnoreCase));

            if (productInfo != null)
            {
                int productId = productInfo.Cell(Products.idProduct).GetValue<int>();
                return (productId, productInfo);
            }
            else
            {
                return (-1, null); // Возврат значения -1 в случае, если продукт не найден
            }

        }

        private IEnumerable<IXLRow> GetOrdersForProduct(int selectedProductId)
        {
            return (IEnumerable<IXLRow>)orders.RowsUsed()
            .Where(row => row.Cell(Orders.idProduct).Value.ToString().Equals(selectedProductId.ToString(), StringComparison.OrdinalIgnoreCase));
        }

        private (string, IXLRow) GetClientInfo(string postClientId)
        {
            var clientId = clients.RowsUsed()
                .FirstOrDefault(row => row.Cell(Clients.idClient).Value.ToString().Equals(postClientId, StringComparison.OrdinalIgnoreCase));

            if (clientId != null)
            {
                string clientInfo = clientId.Cell(Clients.Name).ToString();
                return (clientInfo, clientId);
            }
            else
            {
                return ("", null); // Возврат значения -1 в случае, если продукт не найден
            }
        }
        #endregion


        #region Change Name
        private void buttonContactName_Click(object sender, EventArgs e)//кнопка смены контактного лица клиента
        {
            string selectedClient = GetSelectedClient();

            if (string.IsNullOrEmpty(selectedClient))
            {
                MessageBox.Show("Пожалуйста, выберите организацию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ChangeClientContactName(selectedClient);
        }

        private string GetSelectedClient()
        {
            return comboBox_ContactName.SelectedItem?.ToString();
        }

        private void ChangeClientContactName(string selectedClient)
        {
            var clientChange = ChangeClientContactFIO(selectedClient);

            if (clientChange != null)
            {
                if (!string.IsNullOrEmpty(textBox_NewContactName.Text))
                {
                    string oldContactName = clientChange.Cell(Clients.ContactName).Value.ToString();
                    clientChange.Cell(Clients.ContactName).Value = textBox_NewContactName.Text;

                    workbook.Save();
                    textChangeName.Text = "";
                    textChangeName.AppendText($"Контактное лицо клиента было успешно изменено с {Environment.NewLine + oldContactName} на {Environment.NewLine + textBox_NewContactName.Text}");
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите новое контактное лицо.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Клиент с указанным названием организации не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private IXLRow ChangeClientContactFIO(string contactClient)
        {
            return clients.RowsUsed()
                .FirstOrDefault(row => row.Cell(Clients.Name).Value.ToString().Equals(contactClient, StringComparison.OrdinalIgnoreCase));
        }
        #endregion


        #region Gold Client
        private void buttonGoldClient_Click(object sender, EventArgs e) //кнопка определения золотого клиента
        {
            DateTime selectedDate = dateTimePicker.Value;
            GetGoldenClient(selectedDate);
        }


        private void GetGoldenClient(DateTime selectedDate)
        {
            int year = selectedDate.Year;
            int month = selectedDate.Month;
            try
            {
                var ordersForMonth = orders.RowsUsed()
                    .Where(row =>
                    {
                        DateTime orderDate;
                        if (DateTime.TryParse(row.Cell(Orders.Date).Value.ToString(), out orderDate))
                        {
                            return orderDate.Year == year && orderDate.Month == month;
                        }
                        return false;
                    });

                var orderCountByClient = new Dictionary<string, int>();

                foreach (var order in ordersForMonth)
                {
                    string clientId = order.Cell(Orders.idClient).Value.ToString();
                    var clientInfo = GetClientInfo(clientId);

                    if (clientInfo.Item2 != null)
                    {
                        string clientName = clientInfo.Item2.Cell(Clients.Name).Value.ToString();

                        if (orderCountByClient.ContainsKey(clientName))
                        {
                            orderCountByClient[clientName]++;
                        }
                        else
                        {
                            orderCountByClient[clientName] = 1;
                        }
                    }
                }

                if (orderCountByClient.Count > 0)
                {
                    textChangeName.Text = "";
                    var goldenClient = orderCountByClient.OrderByDescending(gc => gc.Value).First();
                    textChangeName.AppendText($"Золотой клиент за {month}/{year}:{Environment.NewLine + goldenClient.Key + Environment.NewLine}" +
                        $"количество заказов: {goldenClient.Value}");
                }
                else
                {
                    MessageBox.Show($"Нет данных о заказах за указанный {month}/{year}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных из файла или файл не загружен: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InfoText_TextChanged(object sender, EventArgs e)
        {
            InfoText.Multiline = true;
            InfoText.ScrollBars = ScrollBars.Vertical;
        }

        private void comboBox_ContactName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textChangeName_TextChanged(object sender, EventArgs e)//добавление скролинга
        {
            InfoText.Multiline = true;
            InfoText.ScrollBars = ScrollBars.Vertical;
        }

        private void button1_Click_1(object sender, EventArgs e)//выход из приложения (крестик)
        {
            Application.Exit();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)//механизм передвигания окна без рамки
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
