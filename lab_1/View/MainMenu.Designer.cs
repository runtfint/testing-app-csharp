namespace lab_1
{
    partial class MainMenu
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
            label1 = new Label();
            label2 = new Label();
            createTestButton = new Button();
            testGridView = new DataGridView();
            label3 = new Label();
            editTestButton = new Button();
            deleteTestButton = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)testGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(178, 9);
            label1.Name = "label1";
            label1.Size = new Size(439, 49);
            label1.TabIndex = 0;
            label1.Text = "GOOGLE FORMS EATER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 426);
            label2.Name = "label2";
            label2.Size = new Size(214, 15);
            label2.TabIndex = 1;
            label2.Text = "POWERED BY гений seksa и H0pP3r145";
            // 
            // createTestButton
            // 
            createTestButton.BackColor = Color.LightCoral;
            createTestButton.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            createTestButton.Location = new Point(569, 122);
            createTestButton.Name = "createTestButton";
            createTestButton.Size = new Size(208, 59);
            createTestButton.TabIndex = 2;
            createTestButton.Text = "Создать тест";
            createTestButton.UseVisualStyleBackColor = false;
            createTestButton.Click += createTestButton_Click;
            // 
            // testGridView
            // 
            testGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            testGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            testGridView.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            testGridView.Location = new Point(26, 122);
            testGridView.Name = "testGridView";
            testGridView.RowTemplate.Height = 25;
            testGridView.Size = new Size(512, 266);
            testGridView.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 95);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 5;
            label3.Text = "Мои тесты";
            // 
            // editTestButton
            // 
            editTestButton.BackColor = Color.LightCoral;
            editTestButton.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            editTestButton.Location = new Point(569, 196);
            editTestButton.Name = "editTestButton";
            editTestButton.Size = new Size(208, 59);
            editTestButton.TabIndex = 6;
            editTestButton.Text = "Edit";
            editTestButton.UseVisualStyleBackColor = false;
            // 
            // deleteTestButton
            // 
            deleteTestButton.BackColor = Color.LightCoral;
            deleteTestButton.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            deleteTestButton.Location = new Point(569, 271);
            deleteTestButton.Name = "deleteTestButton";
            deleteTestButton.Size = new Size(208, 59);
            deleteTestButton.TabIndex = 7;
            deleteTestButton.Text = "Delete";
            deleteTestButton.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Мои тесты";
            Column1.Name = "Column1";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteTestButton);
            Controls.Add(editTestButton);
            Controls.Add(label3);
            Controls.Add(testGridView);
            Controls.Add(createTestButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainMenu";
            Text = "GOOGLE FORM EATER";
            Load += MainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)testGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button createTestButton;
        private DataGridView testGridView;
        private Label label3;
        private Button editTestButton;
        private Button deleteTestButton;
        private DataGridViewTextBoxColumn Column1;
    }
}