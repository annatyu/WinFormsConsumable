namespace WinFormsConsumable
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveConsumable_Click(object sender, EventArgs e)
        {
            // Вызываем ваш метод проверки из ЛР №3
            ConsumableValidator validator = new ConsumableValidator();
            // Передаем текст из полей формы в ваш валидатор из ЛР №3
            string name = txtNameField.Text;
            string cycle = txtCycleValueField.Text;
            string period = cbPeriodTypeField.Text; // Будет "мес." или "нед."

            try
            {
                // Проверяем данные. Если метод возвращает bool:
                if (validator.CheckConsumableData(name, cycle, period))
                {
                    // Формируем точно такую же строку, какую ищет ваш тест!
                    listBoxItems.Items.Add($"{name} — {cycle} {period}");
                }
            }
            catch (Exception ex)
            {
                // Если внутри валидатора вылетает исключение (как вы писали в ЛР3), 
                // выводим его, чтобы не блокировать интерфейс
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void txtNameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCycleValueField_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPeriodTypeField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
