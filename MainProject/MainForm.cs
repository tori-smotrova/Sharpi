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
    public partial class MainForm : Form
    {
        // Класс для работы с файлами
        FileManager fm = null;
        FileType fileType;
        public MainForm()
        {
            InitializeComponent();
            dgv.TopLeftHeaderCell.Value = "№";
            fm = new FileManager(dgv, "");
            fm.SetRowCheck(Coffee.CheckRow);
            fm.SetRowToObject(Coffee.RowToCoffee);
            fm.SetObjectToRow(Coffee.CoffeeToRow);
        }
        // Обновление индексов
        public void RefreshIndex()
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            InputCoffeeForm inForm = new InputCoffeeForm();
            if (inForm.ShowDialog() == DialogResult.OK)
            {
                dgv.Rows.Add(Coffee.CoffeeToRow(inForm.coffee, dgv));
            }
            inForm.Dispose();
        }
        private void ChangeRow(DataGridViewRow row)
        {
            InputCoffeeForm inForm = new InputCoffeeForm(Coffee.RowToCoffee(row));
            inForm.EditOrFind();
            if (inForm.DialogResult == DialogResult.OK)
            {
                int index = row.Index;
                dgv.Rows.RemoveAt(index);
                dgv.Rows.Insert(index, Coffee.CoffeeToRow(inForm.coffee, dgv));
                RefreshIndex();
            }
            inForm.Dispose();
        }
        private void Dgv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChangeRow(dgv.SelectedRows[0]);
        }
        private void BtDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    dgv.Rows.Remove(row);
                }
                RefreshIndex();
            }
        }
        private List<DataGridViewRow> backList = new List<DataGridViewRow>();
        private void BtTask_Click(object sender, EventArgs e)
        {
            InputKindForm inputKindForm = new InputKindForm();
            if (!(inputKindForm.ShowDialog() == DialogResult.OK && inputKindForm.kind != enumKind.Null))
            {
                if (inputKindForm.DialogResult != DialogResult.OK)
                {
                    MessageBox.Show("Были введены некорректные данные!");
                }
                return;
            }
            enumKind kind = inputKindForm.kind;
            InputForm inputForm = new InputForm("Введите максимальную цену");
            int tempNum = 0;
            if (!(inputForm.ShowDialog() == DialogResult.OK && Int32.TryParse(inputForm.inText, out tempNum) && tempNum >=0))
            {
                if (inputForm.DialogResult != DialogResult.OK)
                {
                    MessageBox.Show("Были введены некорректные данные!");
                }
                return;
            }
            List<DataGridViewRow> rowList = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!(Coffee.StringToKind(row.Cells[1].Value.ToString()) == kind && Double.Parse(row.Cells[4].Value.ToString()) <= tempNum))
                {
                    rowList.Add(row);
                    backList.Add(Coffee.CoffeeToRow(Coffee.RowToCoffee(row), dgv));
                }
            }
            foreach(DataGridViewRow row in rowList)
            {
                dgv.Rows.Remove(row);
            }
            dgv.Sort(dgv.Columns[4], ListSortDirection.Ascending);
        }

        private void MenuOpenText_Click(object sender, EventArgs e)
        {
            fileType = FileType.Text;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fm.Filepath = openFileDialog.FileName;
                fm.Load(fileType);
            }
        }

        private void MenuSaveAsText_Click(object sender, EventArgs e)
        {
            fileType = FileType.Text;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fm.Filepath = saveFileDialog.FileName;
                fm.Save(fileType);
            }
        }

        private void MenuSaveAsBinary_Click(object sender, EventArgs e)
        {
            fileType = FileType.Binary;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fm.Filepath = saveFileDialog.FileName;
                fm.Save(fileType);
            }
        }

        private void MenuOpenBinary_Click(object sender, EventArgs e)
        {
            fileType = FileType.Binary;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fm.Filepath = openFileDialog.FileName;
                fm.Load(fileType);
            }
        }

        private void MenuOpenXml_Click(object sender, EventArgs e)
        {
            fileType = FileType.XML;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fm.Filepath = openFileDialog.FileName;
                fm.Load(fileType);
            }
        }

        private void MenuSaveAsXml_Click(object sender, EventArgs e)
        {
            fileType = FileType.XML;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fm.Filepath = saveFileDialog.FileName;
                fm.Save(fileType);
            }
        }

        private void Dgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            stripLabel.Text = "Количество элементов: " + dgv.Rows.Count;
        }

        private void Dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            stripLabel.Text = "Количество элементов: " + dgv.Rows.Count;
        }

        private void MenuClear_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
        }

        private void MenuCreate_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
        }

        private void MenuSave_Click(object sender, EventArgs e)
        {
            if (fm.Filepath != "")
            {
                fm.Save(fileType);
            }
        }

        private void СброситьФильтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (backList.Count != 0)
            {
                foreach (var row in backList)
                {
                    dgv.Rows.Add(row);
                }
            }
        }
    }
}
