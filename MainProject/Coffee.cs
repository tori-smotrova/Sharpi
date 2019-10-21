using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProject
{
    [Serializable]
    public enum enumKind { Black, Сappuccino, Latte, White, Null = -1}
    [Serializable]
    public class Coffee
    {
        private string sort;
        private enumKind kind;
        private int sugar;
        private bool cream;
        private double price;

        public string Sort
        {
            get
            {
                return sort;
            }
            set
            {
                if (value != "")
                {
                    sort = value;
                }
            }
        }
        public enumKind Kind
        {
            get
            {
                return kind;
            }
            set
            {
                value = kind;
            }
        }
        public int Sugar
        {
            get
            {
                return sugar;
            }
            set
            {
                if (sugar >= 0 && sugar <= 10)
                {
                    sugar = value;
                }
            }
        }
        public bool Cream
        {
            get
            {
                return cream;
            }
            set
            {
                cream = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (price >= 0)
                {
                    price = value;
                }
            }
        }
        public Coffee()
        {
            Sort = "Default";
            Kind = enumKind.Null;
            Sugar = 0;
            Cream = false;
            Price = 0;
        }
        public Coffee(string sort, enumKind kind, int sugar, bool cream, double price)
        {
            this.sort = sort;
            this.kind = kind;
            this.sugar = sugar;
            this.cream = cream;
            this.price = price;
        }
        public static enumKind StringToKind(string kind)
        {
            kind = kind.Trim();
            if (kind.ToLower() == "черный")
            {
                return enumKind.Black;
            }
            if (kind.ToLower() == "капучино")
            {
                return enumKind.Сappuccino;
            }
            if (kind.ToLower() == "латте")
            {
                return enumKind.Latte;
            }
            if (kind.ToLower() == "белый")
            {
                return enumKind.White;
            }
            return enumKind.Null;
        }
        public static string KindToString(enumKind kind)
        {
            if (kind == enumKind.Black)
            {
                return "Черное";
            }
            if (kind == enumKind.Сappuccino)
            {
                return "Капучино";
            }
            if (kind == enumKind.Latte)
            {
                return "Латте";
            }
            if (kind == enumKind.White)
            {
                return "Белое";
            }
            return "Неизвестно";
        }
        public static bool StringIsBool(string str)
        {
            return str.Trim().ToLower() == "да" || str.Trim().ToLower() == "нет";
        }
        public static string BoolToString(bool OK)
        {
            if (OK)
            {
                return "Да";
            }
            return "Нет";
        }
        public static bool StringToBool(string str)
        {
            if (str.ToLower() == "да")
            {
                return true;
            }
            return false;
        }

        // Проверка строки на правильность
        public static bool CheckRow(DataGridViewRow row)
        {
            if (row.Cells[0].Value.ToString() == "")
            {
                return false;
            }
            if (StringToKind(row.Cells[1].Value.ToString()) == enumKind.Null)
            {
                row.Cells[1].Value = "Неизвестно";
            }
            int tempNum = 0;
            if (!(Int32.TryParse(row.Cells[2].Value.ToString(), out tempNum) && tempNum >= 0 && tempNum <= 10))
            {
                return false;
            }
            if (!StringIsBool(row.Cells[3].Value.ToString()))
            {
                return false;
            }
            double tempDouble;
            if (!(Double.TryParse(row.Cells[4].Value.ToString(), out tempDouble) && tempDouble >= 0))
            {
                return false;
            }
            return true;
        }

        // Перевод из строки в экзмепляр Coffee
        public static Coffee RowToCoffee(DataGridViewRow row)
        {
            string sort = row.Cells[0].Value.ToString();
            enumKind kind = StringToKind(row.Cells[1].Value.ToString());
            int sugar = Int32.Parse(row.Cells[2].Value.ToString());
            bool cream = StringToBool(row.Cells[3].Value.ToString());
            double price = Double.Parse(row.Cells[4].Value.ToString());
            return new Coffee(sort, kind, sugar, cream, price);
        }
        // Перевод из Coffee в строку
        public static DataGridViewRow CoffeeToRow(object obj, DataGridView dgv)
        {
            Coffee coffee = (Coffee)obj;
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgv);
            row.HeaderCell.Value = (dgv.RowCount + 1).ToString();
            row.Cells[0].Value = coffee.Sort;
            row.Cells[1].Value = KindToString(coffee.Kind);
            row.Cells[2].Value = coffee.Sugar.ToString();
            row.Cells[3].Value = BoolToString(coffee.Cream);
            row.Cells[4].Value = coffee.price.ToString();
            return row;
        }
    }
}
