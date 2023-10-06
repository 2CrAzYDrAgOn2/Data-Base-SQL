namespace test_DataBase
{
    partial class AddForm
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
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelPostavshik = new System.Windows.Forms.Label();
            this.labelQuantinity = new System.Windows.Forms.Label();
            this.labelProdukciya = new System.Windows.Forms.Label();
            this.textBoxProdukciya = new System.Windows.Forms.TextBox();
            this.textBoxQuantinity = new System.Windows.Forms.TextBox();
            this.textBoxPostavshik = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(210, 480);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(36, 13);
            this.labelPrice.TabIndex = 19;
            this.labelPrice.Text = "Цена:";
            // 
            // labelPostavshik
            // 
            this.labelPostavshik.AutoSize = true;
            this.labelPostavshik.Location = new System.Drawing.Point(177, 441);
            this.labelPostavshik.Name = "labelPostavshik";
            this.labelPostavshik.Size = new System.Drawing.Size(68, 13);
            this.labelPostavshik.TabIndex = 18;
            this.labelPostavshik.Text = "Поставщик:";
            // 
            // labelQuantinity
            // 
            this.labelQuantinity.AutoSize = true;
            this.labelQuantinity.Location = new System.Drawing.Point(177, 402);
            this.labelQuantinity.Name = "labelQuantinity";
            this.labelQuantinity.Size = new System.Drawing.Size(69, 13);
            this.labelQuantinity.TabIndex = 17;
            this.labelQuantinity.Text = "Количество:";
            // 
            // labelProdukciya
            // 
            this.labelProdukciya.AutoSize = true;
            this.labelProdukciya.Location = new System.Drawing.Point(130, 363);
            this.labelProdukciya.Name = "labelProdukciya";
            this.labelProdukciya.Size = new System.Drawing.Size(116, 13);
            this.labelProdukciya.TabIndex = 16;
            this.labelProdukciya.Text = "Название продукции:";
            // 
            // textBoxProdukciya
            // 
            this.textBoxProdukciya.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxProdukciya.Location = new System.Drawing.Point(252, 351);
            this.textBoxProdukciya.Name = "textBoxProdukciya";
            this.textBoxProdukciya.Size = new System.Drawing.Size(391, 33);
            this.textBoxProdukciya.TabIndex = 15;
            // 
            // textBoxQuantinity
            // 
            this.textBoxQuantinity.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuantinity.Location = new System.Drawing.Point(252, 390);
            this.textBoxQuantinity.Name = "textBoxQuantinity";
            this.textBoxQuantinity.Size = new System.Drawing.Size(391, 33);
            this.textBoxQuantinity.TabIndex = 14;
            // 
            // textBoxPostavshik
            // 
            this.textBoxPostavshik.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPostavshik.Location = new System.Drawing.Point(252, 429);
            this.textBoxPostavshik.Name = "textBoxPostavshik";
            this.textBoxPostavshik.Size = new System.Drawing.Size(391, 33);
            this.textBoxPostavshik.TabIndex = 13;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.Location = new System.Drawing.Point(252, 468);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(391, 33);
            this.textBoxPrice.TabIndex = 12;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(283, 661);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(202, 56);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(208, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(175, 25);
            this.labelTitle.TabIndex = 20;
            this.labelTitle.Text = "Создание записи:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(209, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Отдел №1";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelPostavshik);
            this.Controls.Add(this.labelQuantinity);
            this.Controls.Add(this.labelProdukciya);
            this.Controls.Add(this.textBoxProdukciya);
            this.Controls.Add(this.textBoxQuantinity);
            this.Controls.Add(this.textBoxPostavshik);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.buttonSave);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelPostavshik;
        private System.Windows.Forms.Label labelQuantinity;
        private System.Windows.Forms.Label labelProdukciya;
        private System.Windows.Forms.TextBox textBoxProdukciya;
        private System.Windows.Forms.TextBox textBoxQuantinity;
        private System.Windows.Forms.TextBox textBoxPostavshik;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
    }
}