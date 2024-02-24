namespace AkelonTest3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.path = new System.Windows.Forms.Button();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.buttonShowInfo = new System.Windows.Forms.Button();
            this.InfoText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_ContactName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonContactName = new System.Windows.Forms.Button();
            this.textBox_NewContactName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textChangeName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGoldClient = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(12, 43);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.ReadOnly = true;
            this.textBox_path.Size = new System.Drawing.Size(500, 20);
            this.textBox_path.TabIndex = 0;
            this.textBox_path.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(518, 43);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(39, 20);
            this.path.TabIndex = 1;
            this.path.Text = "...";
            this.path.UseVisualStyleBackColor = true;
            this.path.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(12, 99);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(172, 28);
            this.comboBoxProducts.TabIndex = 2;
            this.comboBoxProducts.SelectedIndexChanged += new System.EventHandler(this.comboBoxProducts_SelectedIndexChanged);
            // 
            // buttonShowInfo
            // 
            this.buttonShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowInfo.Location = new System.Drawing.Point(190, 98);
            this.buttonShowInfo.Name = "buttonShowInfo";
            this.buttonShowInfo.Size = new System.Drawing.Size(46, 29);
            this.buttonShowInfo.TabIndex = 3;
            this.buttonShowInfo.Text = "Info";
            this.buttonShowInfo.UseVisualStyleBackColor = true;
            this.buttonShowInfo.Click += new System.EventHandler(this.buttonShowInfo_Click);
            // 
            // InfoText
            // 
            this.InfoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoText.Location = new System.Drawing.Point(12, 133);
            this.InfoText.Multiline = true;
            this.InfoText.Name = "InfoText";
            this.InfoText.ReadOnly = true;
            this.InfoText.Size = new System.Drawing.Size(224, 405);
            this.InfoText.TabIndex = 4;
            this.InfoText.TextChanged += new System.EventHandler(this.InfoText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Путь к файлу";
            // 
            // comboBox_ContactName
            // 
            this.comboBox_ContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_ContactName.FormattingEnabled = true;
            this.comboBox_ContactName.Location = new System.Drawing.Point(250, 100);
            this.comboBox_ContactName.Name = "comboBox_ContactName";
            this.comboBox_ContactName.Size = new System.Drawing.Size(307, 28);
            this.comboBox_ContactName.TabIndex = 7;
            this.comboBox_ContactName.SelectedIndexChanged += new System.EventHandler(this.comboBox_ContactName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(247, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Название организации";
            // 
            // buttonContactName
            // 
            this.buttonContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonContactName.Location = new System.Drawing.Point(518, 164);
            this.buttonContactName.Name = "buttonContactName";
            this.buttonContactName.Size = new System.Drawing.Size(39, 29);
            this.buttonContactName.TabIndex = 9;
            this.buttonContactName.Text = "OK";
            this.buttonContactName.UseVisualStyleBackColor = true;
            this.buttonContactName.Click += new System.EventHandler(this.buttonContactName_Click);
            // 
            // textBox_NewContactName
            // 
            this.textBox_NewContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_NewContactName.Location = new System.Drawing.Point(250, 164);
            this.textBox_NewContactName.Name = "textBox_NewContactName";
            this.textBox_NewContactName.Size = new System.Drawing.Size(262, 29);
            this.textBox_NewContactName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(247, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Новое контактное лицо (ФИО)";
            // 
            // textChangeName
            // 
            this.textChangeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textChangeName.Location = new System.Drawing.Point(250, 310);
            this.textChangeName.Multiline = true;
            this.textChangeName.Name = "textChangeName";
            this.textChangeName.ReadOnly = true;
            this.textChangeName.Size = new System.Drawing.Size(304, 228);
            this.textChangeName.TabIndex = 12;
            this.textChangeName.TextChanged += new System.EventHandler(this.textChangeName_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 26);
            this.button1.TabIndex = 13;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(221, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "AkelonTest";
            // 
            // buttonGoldClient
            // 
            this.buttonGoldClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGoldClient.Location = new System.Drawing.Point(468, 242);
            this.buttonGoldClient.Name = "buttonGoldClient";
            this.buttonGoldClient.Size = new System.Drawing.Size(89, 26);
            this.buttonGoldClient.TabIndex = 15;
            this.buttonGoldClient.Text = "Gold Client";
            this.buttonGoldClient.UseVisualStyleBackColor = true;
            this.buttonGoldClient.Click += new System.EventHandler(this.buttonGoldClient_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(246, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Определить золотого клиента ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(250, 242);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(212, 26);
            this.dateTimePicker.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(247, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Поле информации";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 550);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonGoldClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textChangeName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_NewContactName);
            this.Controls.Add(this.buttonContactName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_ContactName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoText);
            this.Controls.Add(this.buttonShowInfo);
            this.Controls.Add(this.comboBoxProducts);
            this.Controls.Add(this.path);
            this.Controls.Add(this.textBox_path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Информация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.Button path;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.Button buttonShowInfo;
        private System.Windows.Forms.TextBox InfoText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_ContactName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonContactName;
        private System.Windows.Forms.TextBox textBox_NewContactName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textChangeName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGoldClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label7;
    }
}

