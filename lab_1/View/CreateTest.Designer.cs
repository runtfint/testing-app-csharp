namespace lab_1.View
{
    partial class CreateTest
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(150, 28);
            label1.TabIndex = 0;
            label1.Text = "Название теста";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(377, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 2;
            label2.Text = "Текстовка вопроса 1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(377, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 153);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 5;
            label3.Text = "Ответы";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(170, 153);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 13;
            label4.Text = "Верные ответы";
            // 
            // button2
            // 
            button2.Location = new Point(12, 380);
            button2.Name = "button2";
            button2.Size = new Size(140, 23);
            button2.TabIndex = 16;
            button2.Text = "Завершить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 171);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(377, 150);
            dataGridView1.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(12, 327);
            button1.Name = "button1";
            button1.Size = new Size(140, 23);
            button1.TabIndex = 18;
            button1.Text = "Следующий вопрос";
            button1.UseVisualStyleBackColor = true;
            // 
            // CreateTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(701, 415);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "CreateTest";
            Text = "CreateTest";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button1;
    }
}