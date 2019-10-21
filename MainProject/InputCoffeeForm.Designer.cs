namespace MainProject
{
    partial class InputCoffeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCancel = new System.Windows.Forms.Button();
            this.btAction = new System.Windows.Forms.Button();
            this.lbSort = new System.Windows.Forms.Label();
            this.tbSort = new System.Windows.Forms.TextBox();
            this.tbSugar = new System.Windows.Forms.TextBox();
            this.lbSugar = new System.Windows.Forms.Label();
            this.tbCream = new System.Windows.Forms.TextBox();
            this.lbCream = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKind = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(144, 272);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(126, 55);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btAction
            // 
            this.btAction.Location = new System.Drawing.Point(12, 272);
            this.btAction.Name = "btAction";
            this.btAction.Size = new System.Drawing.Size(126, 55);
            this.btAction.TabIndex = 2;
            this.btAction.Text = "Добавить";
            this.btAction.UseVisualStyleBackColor = true;
            this.btAction.Click += new System.EventHandler(this.BtAction_Click);
            // 
            // lbSort
            // 
            this.lbSort.AutoSize = true;
            this.lbSort.Location = new System.Drawing.Point(9, 23);
            this.lbSort.Name = "lbSort";
            this.lbSort.Size = new System.Drawing.Size(31, 13);
            this.lbSort.TabIndex = 3;
            this.lbSort.Text = "Сорт";
            // 
            // tbSort
            // 
            this.tbSort.Location = new System.Drawing.Point(12, 39);
            this.tbSort.Name = "tbSort";
            this.tbSort.Size = new System.Drawing.Size(258, 20);
            this.tbSort.TabIndex = 4;
            // 
            // tbSugar
            // 
            this.tbSugar.Location = new System.Drawing.Point(12, 137);
            this.tbSugar.Name = "tbSugar";
            this.tbSugar.Size = new System.Drawing.Size(258, 20);
            this.tbSugar.TabIndex = 8;
            // 
            // lbSugar
            // 
            this.lbSugar.AutoSize = true;
            this.lbSugar.Location = new System.Drawing.Point(12, 121);
            this.lbSugar.Name = "lbSugar";
            this.lbSugar.Size = new System.Drawing.Size(67, 13);
            this.lbSugar.TabIndex = 7;
            this.lbSugar.Text = "Сахар (0-10)";
            // 
            // tbCream
            // 
            this.tbCream.Location = new System.Drawing.Point(12, 190);
            this.tbCream.Name = "tbCream";
            this.tbCream.Size = new System.Drawing.Size(258, 20);
            this.tbCream.TabIndex = 10;
            // 
            // lbCream
            // 
            this.lbCream.AutoSize = true;
            this.lbCream.Location = new System.Drawing.Point(12, 174);
            this.lbCream.Name = "lbCream";
            this.lbCream.Size = new System.Drawing.Size(87, 13);
            this.lbCream.TabIndex = 9;
            this.lbCream.Text = "Слики (Да, Нет)";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(12, 237);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(258, 20);
            this.tbPrice.TabIndex = 12;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(12, 221);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(33, 13);
            this.lbPrice.TabIndex = 11;
            this.lbPrice.Text = "Цена";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Выберите вид";
            // 
            // cbKind
            // 
            this.cbKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKind.FormattingEnabled = true;
            this.cbKind.Items.AddRange(new object[] {
            "Черный",
            "Капуччино",
            "Латте",
            "Белый"});
            this.cbKind.Location = new System.Drawing.Point(15, 87);
            this.cbKind.Name = "cbKind";
            this.cbKind.Size = new System.Drawing.Size(255, 21);
            this.cbKind.TabIndex = 13;
            // 
            // InputCoffeeForm
            // 
            this.AcceptButton = this.btAction;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(284, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKind);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.tbCream);
            this.Controls.Add(this.lbCream);
            this.Controls.Add(this.tbSugar);
            this.Controls.Add(this.lbSugar);
            this.Controls.Add(this.tbSort);
            this.Controls.Add(this.lbSort);
            this.Controls.Add(this.btAction);
            this.Controls.Add(this.btCancel);
            this.Name = "InputCoffeeForm";
            this.Text = "Фильм";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btAction;
        private System.Windows.Forms.Label lbSort;
        private System.Windows.Forms.TextBox tbSort;
        private System.Windows.Forms.TextBox tbSugar;
        private System.Windows.Forms.Label lbSugar;
        private System.Windows.Forms.TextBox tbCream;
        private System.Windows.Forms.Label lbCream;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKind;
    }
}