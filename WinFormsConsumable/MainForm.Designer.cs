namespace WinFormsConsumable
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxItems = new ListBox();
            txtNameField = new TextBox();
            txtCycleValueField = new TextBox();
            cbPeriodTypeField = new ComboBox();
            btnSaveConsumable = new Button();
            labelList = new Label();
            labelName = new Label();
            labelValue = new Label();
            labelPeriod = new Label();
            SuspendLayout();
            // 
            // listBoxItems
            // 
            listBoxItems.AccessibleName = "listBoxItems";
            listBoxItems.FormattingEnabled = true;
            listBoxItems.Location = new Point(12, 40);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(315, 104);
            listBoxItems.TabIndex = 0;
            listBoxItems.SelectedIndexChanged += listBoxItems_SelectedIndexChanged;
            // 
            // txtNameField
            // 
            txtNameField.AccessibleName = "txtNameField";
            txtNameField.Location = new Point(15, 199);
            txtNameField.Name = "txtNameField";
            txtNameField.Size = new Size(152, 27);
            txtNameField.TabIndex = 1;
            txtNameField.TextChanged += txtNameField_TextChanged;
            // 
            // txtCycleValueField
            // 
            txtCycleValueField.AccessibleName = "txtCycleValueField";
            txtCycleValueField.Location = new Point(15, 254);
            txtCycleValueField.Name = "txtCycleValueField";
            txtCycleValueField.Size = new Size(127, 27);
            txtCycleValueField.TabIndex = 2;
            txtCycleValueField.TextChanged += txtCycleValueField_TextChanged;
            // 
            // cbPeriodTypeField
            // 
            cbPeriodTypeField.AccessibleName = "cbPeriodTypeField";
            cbPeriodTypeField.FormattingEnabled = true;
            cbPeriodTypeField.Items.AddRange(new object[] { "мес.", "нед.", "день" });
            cbPeriodTypeField.Location = new Point(230, 253);
            cbPeriodTypeField.Name = "cbPeriodTypeField";
            cbPeriodTypeField.Size = new Size(181, 28);
            cbPeriodTypeField.TabIndex = 3;
            cbPeriodTypeField.SelectedIndexChanged += cbPeriodTypeField_SelectedIndexChanged;
            // 
            // btnSaveConsumable
            // 
            btnSaveConsumable.AccessibleName = "btnSaveConsumable";
            btnSaveConsumable.Location = new Point(153, 392);
            btnSaveConsumable.Name = "btnSaveConsumable";
            btnSaveConsumable.Size = new Size(111, 46);
            btnSaveConsumable.TabIndex = 4;
            btnSaveConsumable.Text = "Добавить";
            btnSaveConsumable.UseVisualStyleBackColor = true;
            btnSaveConsumable.Click += btnSaveConsumable_Click;
            // 
            // labelList
            // 
            labelList.AccessibleName = "labelList";
            labelList.AutoSize = true;
            labelList.Location = new Point(14, 17);
            labelList.Name = "labelList";
            labelList.Size = new Size(153, 20);
            labelList.TabIndex = 5;
            labelList.Text = "Список расходников";
            // 
            // labelName
            // 
            labelName.AccessibleName = "labelName";
            labelName.AutoSize = true;
            labelName.Location = new Point(15, 176);
            labelName.Name = "labelName";
            labelName.Size = new Size(162, 20);
            labelName.TabIndex = 6;
            labelName.Text = "Название расходника";
            // 
            // labelValue
            // 
            labelValue.AccessibleName = "labelValue";
            labelValue.AutoSize = true;
            labelValue.Location = new Point(15, 229);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(87, 20);
            labelValue.TabIndex = 7;
            labelValue.Text = "Ввод числа";
            // 
            // labelPeriod
            // 
            labelPeriod.AccessibleName = "labelPeriod";
            labelPeriod.AutoSize = true;
            labelPeriod.Location = new Point(230, 215);
            labelPeriod.Name = "labelPeriod";
            labelPeriod.Size = new Size(120, 20);
            labelPeriod.TabIndex = 8;
            labelPeriod.Text = "Выбор периода";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 450);
            Controls.Add(labelPeriod);
            Controls.Add(labelValue);
            Controls.Add(labelName);
            Controls.Add(labelList);
            Controls.Add(btnSaveConsumable);
            Controls.Add(cbPeriodTypeField);
            Controls.Add(txtCycleValueField);
            Controls.Add(txtNameField);
            Controls.Add(listBoxItems);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxItems;
        private TextBox txtNameField;
        private TextBox txtCycleValueField;
        private ComboBox cbPeriodTypeField;
        private Button btnSaveConsumable;
        private Label labelList;
        private Label labelName;
        private Label labelValue;
        private Label labelPeriod;
    }
}
