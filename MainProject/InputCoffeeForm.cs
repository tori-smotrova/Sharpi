using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProject
{
    public partial class InputCoffeeForm : Form
    {
        public Coffee coffee = null;
        public InputCoffeeForm(Coffee coffee = null)
        {
            InitializeComponent();
            if (coffee != null)
            {
                tbSort.Text = coffee.Sort;
                cbKind.SelectedIndex = (int)coffee.Kind;
                tbSugar.Text = coffee.Sugar.ToString();
                tbCream.Text = Coffee.BoolToString(coffee.Cream);
                tbPrice.Text = coffee.Price.ToString();
            }
        }

        public void EditOrFind()
        {
            btAction.Text = "Изменить";
            this.ShowDialog();
        }
        private void BtAction_Click(object sender, EventArgs e)
        {
            int sugar = 0;
            double price = 0;
            if (tbSort.Text != "" && Coffee.StringIsBool(tbCream.Text) &&
                Int32.TryParse(tbSugar.Text, out sugar) && sugar >= 0 && sugar <= 10)
            {
                coffee = new Coffee(tbSort.Text, Coffee.StringToKind(cbKind.SelectedItem.ToString()), sugar, Coffee.StringToBool(tbCream.Text), price);
                DialogResult = DialogResult.OK;
                MessageBox.Show(cbKind.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Вы ввели некорректные данные. Повторите ввод.","Ошибка");
            }
        }
    }
}
