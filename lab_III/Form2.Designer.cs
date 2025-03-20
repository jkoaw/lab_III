namespace lab_III
{
    partial class Form2
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
            textBox_imie = new TextBox();
            textBox_nazwisko = new TextBox();
            textBox_wiek = new TextBox();
            textBox_stanowisko = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button_ok = new Button();
            button_back = new Button();
            SuspendLayout();
            // 
            // textBox_imie
            // 
            textBox_imie.Location = new Point(387, 121);
            textBox_imie.Name = "textBox_imie";
            textBox_imie.Size = new Size(100, 23);
            textBox_imie.TabIndex = 0;
            // 
            // textBox_nazwisko
            // 
            textBox_nazwisko.Location = new Point(387, 171);
            textBox_nazwisko.Name = "textBox_nazwisko";
            textBox_nazwisko.Size = new Size(100, 23);
            textBox_nazwisko.TabIndex = 1;
            // 
            // textBox_wiek
            // 
            textBox_wiek.Location = new Point(387, 222);
            textBox_wiek.Name = "textBox_wiek";
            textBox_wiek.Size = new Size(100, 23);
            textBox_wiek.TabIndex = 2;
            // 
            // textBox_stanowisko
            // 
            textBox_stanowisko.Location = new Point(387, 270);
            textBox_stanowisko.Name = "textBox_stanowisko";
            textBox_stanowisko.Size = new Size(100, 23);
            textBox_stanowisko.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(516, 121);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 4;
            label1.Text = "Imie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(516, 179);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(516, 230);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 6;
            label3.Text = "Wiek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(516, 278);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 7;
            label4.Text = "Stanowisko";
            // 
            // button_ok
            // 
            button_ok.Location = new Point(173, 386);
            button_ok.Name = "button_ok";
            button_ok.Size = new Size(75, 23);
            button_ok.TabIndex = 8;
            button_ok.Text = "Zatwierdz";
            button_ok.UseVisualStyleBackColor = true;
            button_ok.Click += button_ok_Click;
            // 
            // button_back
            // 
            button_back.Location = new Point(427, 382);
            button_back.Name = "button_back";
            button_back.Size = new Size(75, 23);
            button_back.TabIndex = 9;
            button_back.Text = "Wroc";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_back);
            Controls.Add(button_ok);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_stanowisko);
            Controls.Add(textBox_wiek);
            Controls.Add(textBox_nazwisko);
            Controls.Add(textBox_imie);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_imie;
        private TextBox textBox_nazwisko;
        private TextBox textBox_wiek;
        private TextBox textBox_stanowisko;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button_ok;
        private Button button_back;
    }
}