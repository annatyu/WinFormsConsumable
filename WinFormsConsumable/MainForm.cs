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

            if (validator.CheckConsumableData(txtNameField.Text, txtCycleValueField.Text, cbPeriodTypeField.Text))
            {
                // Если данные валидны, добавляем строку в список
                listBoxItems.Items.Add($"{txtNameField.Text} — {txtCycleValueField.Text} {cbPeriodTypeField.Text}");
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
