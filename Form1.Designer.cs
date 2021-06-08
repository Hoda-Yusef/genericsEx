
namespace genericsEx
{
    partial class Form1
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
            this.lbl_numbers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_string = new System.Windows.Forms.TextBox();
            this.txt_outNumber = new System.Windows.Forms.TextBox();
            this.txt_outString = new System.Windows.Forms.TextBox();
            this.btn_insertNum = new System.Windows.Forms.Button();
            this.btn_removeNum = new System.Windows.Forms.Button();
            this.btn_insertStr = new System.Windows.Forms.Button();
            this.btn_removeStr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_numbers
            // 
            this.lbl_numbers.AutoSize = true;
            this.lbl_numbers.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numbers.Location = new System.Drawing.Point(564, 62);
            this.lbl_numbers.Name = "lbl_numbers";
            this.lbl_numbers.Size = new System.Drawing.Size(143, 33);
            this.lbl_numbers.TabIndex = 0;
            this.lbl_numbers.Text = "תור מספרים";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(564, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "תור מחרוזות";
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(414, 71);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(135, 20);
            this.txt_number.TabIndex = 2;
            this.txt_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_number_KeyPress);
            // 
            // txt_string
            // 
            this.txt_string.Location = new System.Drawing.Point(414, 189);
            this.txt_string.Name = "txt_string";
            this.txt_string.Size = new System.Drawing.Size(135, 20);
            this.txt_string.TabIndex = 3;
            this.txt_string.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_string_KeyPress);
            // 
            // txt_outNumber
            // 
            this.txt_outNumber.Location = new System.Drawing.Point(12, 75);
            this.txt_outNumber.Name = "txt_outNumber";
            this.txt_outNumber.ReadOnly = true;
            this.txt_outNumber.Size = new System.Drawing.Size(135, 20);
            this.txt_outNumber.TabIndex = 4;
            // 
            // txt_outString
            // 
            this.txt_outString.Location = new System.Drawing.Point(12, 192);
            this.txt_outString.Name = "txt_outString";
            this.txt_outString.ReadOnly = true;
            this.txt_outString.Size = new System.Drawing.Size(135, 20);
            this.txt_outString.TabIndex = 5;
            // 
            // btn_insertNum
            // 
            this.btn_insertNum.BackColor = System.Drawing.Color.Navy;
            this.btn_insertNum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_insertNum.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insertNum.Location = new System.Drawing.Point(294, 62);
            this.btn_insertNum.Name = "btn_insertNum";
            this.btn_insertNum.Size = new System.Drawing.Size(107, 35);
            this.btn_insertNum.TabIndex = 6;
            this.btn_insertNum.Text = "הכנס לתור";
            this.btn_insertNum.UseVisualStyleBackColor = false;
            this.btn_insertNum.Click += new System.EventHandler(this.btn_insertNum_Click);
            // 
            // btn_removeNum
            // 
            this.btn_removeNum.BackColor = System.Drawing.Color.Navy;
            this.btn_removeNum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_removeNum.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeNum.Location = new System.Drawing.Point(165, 63);
            this.btn_removeNum.Name = "btn_removeNum";
            this.btn_removeNum.Size = new System.Drawing.Size(107, 35);
            this.btn_removeNum.TabIndex = 7;
            this.btn_removeNum.Text = "הוצא מתור";
            this.btn_removeNum.UseVisualStyleBackColor = false;
            this.btn_removeNum.Click += new System.EventHandler(this.btn_removeNum_Click);
            // 
            // btn_insertStr
            // 
            this.btn_insertStr.BackColor = System.Drawing.Color.Navy;
            this.btn_insertStr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_insertStr.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insertStr.Location = new System.Drawing.Point(294, 183);
            this.btn_insertStr.Name = "btn_insertStr";
            this.btn_insertStr.Size = new System.Drawing.Size(107, 35);
            this.btn_insertStr.TabIndex = 8;
            this.btn_insertStr.Text = "הכנס לתור";
            this.btn_insertStr.UseVisualStyleBackColor = false;
            this.btn_insertStr.Click += new System.EventHandler(this.btn_insertStr_Click);
            // 
            // btn_removeStr
            // 
            this.btn_removeStr.BackColor = System.Drawing.Color.Navy;
            this.btn_removeStr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_removeStr.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeStr.Location = new System.Drawing.Point(165, 183);
            this.btn_removeStr.Name = "btn_removeStr";
            this.btn_removeStr.Size = new System.Drawing.Size(107, 35);
            this.btn_removeStr.TabIndex = 9;
            this.btn_removeStr.Text = "הוצא מתור";
            this.btn_removeStr.UseVisualStyleBackColor = false;
            this.btn_removeStr.Click += new System.EventHandler(this.btn_removeStr_Click);
            // 
            // Form1
            // 
            this.AccessibleName = "frm_myFrame";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(728, 309);
            this.Controls.Add(this.btn_removeStr);
            this.Controls.Add(this.btn_insertStr);
            this.Controls.Add(this.btn_removeNum);
            this.Controls.Add(this.btn_insertNum);
            this.Controls.Add(this.txt_outString);
            this.Controls.Add(this.txt_outNumber);
            this.Controls.Add(this.txt_string);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_numbers);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_numbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_outNumber;
        private System.Windows.Forms.TextBox txt_outString;
        private System.Windows.Forms.Button btn_insertNum;
        private System.Windows.Forms.Button btn_removeNum;
        private System.Windows.Forms.Button btn_insertStr;
        private System.Windows.Forms.Button btn_removeStr;
        public System.Windows.Forms.TextBox txt_number;
        public System.Windows.Forms.TextBox txt_string;
    }
}

