using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BinaryConverterLibrary
{
    [ToolboxBitmap(typeof(BinaryConverterControl), "BinaryConverterControl.ico")]
    public partial class BinaryConverterControl : UserControl
    {
        public BinaryConverterControl()
        {
            InitializeComponent(); // Виклик створеного дизайнера
            // Додатковий код ініціалізації (якщо потрібно)
        }

        // Властивість для роботи з десятковим числом
        public int DecimalValue
        {
            get => int.TryParse(textBoxDecimal.Text, out int value) ? value : 0;
            set
            {
                textBoxDecimal.Text = value.ToString();
                UpdateBinaryValue();
            }
        }

        // Властивість для роботи з двійковим рядком
        public string BinaryValue
        {
            get => textBoxBinary.Text;
            private set => textBoxBinary.Text = value;
        }

        // Обробка натискання кнопки
        private void btnConvert_Click(object sender, EventArgs e)
        {
            UpdateBinaryValue();
            OnConverted(EventArgs.Empty);
        }

        // Метод конвертації десяткового числа у двійковий рядок
        private void UpdateBinaryValue()
        {
            if (int.TryParse(textBoxDecimal.Text, out int value))
            {
                BinaryValue = Convert.ToString(value, 2);
            }
            else
            {
                BinaryValue = "Некоректне число";
            }
        }

        // Подія, що сповіщає про завершення конвертації
        public event EventHandler Converted;
        protected virtual void OnConverted(EventArgs e)
        {
            Converted?.Invoke(this, e);
        }
    }
}
