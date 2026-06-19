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
            SuspendLayout();
            // 
            // listBoxItems
            // 
            listBoxItems.AccessibleName = "listBoxItems";
            listBoxItems.FormattingEnabled = true;
            listBoxItems.Location = new Point(77, 52);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(315, 104);
            listBoxItems.TabIndex = 0;
            listBoxItems.SelectedIndexChanged += listBoxItems_SelectedIndexChanged;
            // 
            // txtNameField
            // 
            txtNameField.AccessibleName = "txtNameField";
            txtNameField.Location = new Point(77, 177);
            txtNameField.Name = "txtNameField";
            txtNameField.Size = new Size(125, 27);
            txtNameField.TabIndex = 1;
            txtNameField.TextChanged += txtNameField_TextChanged;
            // 
            // txtCycleValueField
            // 
            txtCycleValueField.AccessibleName = "txtCycleValueField";
            txtCycleValueField.Location = new Point(75, 220);
            txtCycleValueField.Name = "txtCycleValueField";
            txtCycleValueField.Size = new Size(127, 27);
            txtCycleValueField.TabIndex = 2;
            txtCycleValueField.TextChanged += txtCycleValueField_TextChanged;
            // 
            // cbPeriodTypeField
            // 
            cbPeriodTypeField.AccessibleName = "cbPeriodTypeField";
            cbPeriodTypeField.FormattingEnabled = true;
            cbPeriodTypeField.Location = new Point(80, 275);
            cbPeriodTypeField.Name = "cbPeriodTypeField";
            cbPeriodTypeField.Size = new Size(181, 28);
            cbPeriodTypeField.TabIndex = 3;
            cbPeriodTypeField.SelectedIndexChanged += cbPeriodTypeField_SelectedIndexChanged;
            // 
            // btnSaveConsumable
            // 
            btnSaveConsumable.AccessibleName = "btnSaveConsumable";
            btnSaveConsumable.Location = new Point(79, 326);
            btnSaveConsumable.Name = "btnSaveConsumable";
            btnSaveConsumable.Size = new Size(94, 29);
            btnSaveConsumable.TabIndex = 4;
            btnSaveConsumable.Text = "button1";
            btnSaveConsumable.UseVisualStyleBackColor = true;
            btnSaveConsumable.Click += btnSaveConsumable_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
