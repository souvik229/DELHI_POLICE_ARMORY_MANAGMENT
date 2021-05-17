
namespace DELHI_POLICE
{
    partial class TRANSACTION_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.transaction = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.issued_to_officer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.take_officer_id = new System.Windows.Forms.TextBox();
            this.take_g_code = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CLEAR_BUTTON = new System.Windows.Forms.Button();
            this.issue_button = new System.Windows.Forms.Button();
            this.return_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showlog_button = new System.Windows.Forms.Button();
            this.gun_issued = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // transaction
            // 
            this.transaction.AutoSize = true;
            this.transaction.BackColor = System.Drawing.Color.Transparent;
            this.transaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.transaction.Location = new System.Drawing.Point(755, 74);
            this.transaction.Name = "transaction";
            this.transaction.Size = new System.Drawing.Size(71, 20);
            this.transaction.TabIndex = 0;
            this.transaction.Text = "ISSUED";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(755, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ISSUED TO";
            // 
            // issued_to_officer
            // 
            this.issued_to_officer.AutoSize = true;
            this.issued_to_officer.BackColor = System.Drawing.Color.Transparent;
            this.issued_to_officer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issued_to_officer.ForeColor = System.Drawing.Color.Green;
            this.issued_to_officer.Location = new System.Drawing.Point(895, 190);
            this.issued_to_officer.Name = "issued_to_officer";
            this.issued_to_officer.Size = new System.Drawing.Size(51, 20);
            this.issued_to_officer.TabIndex = 2;
            this.issued_to_officer.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(895, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // take_officer_id
            // 
            this.take_officer_id.Location = new System.Drawing.Point(430, 67);
            this.take_officer_id.Name = "take_officer_id";
            this.take_officer_id.Size = new System.Drawing.Size(153, 20);
            this.take_officer_id.TabIndex = 4;
            // 
            // take_g_code
            // 
            this.take_g_code.Location = new System.Drawing.Point(430, 187);
            this.take_g_code.Name = "take_g_code";
            this.take_g_code.Size = new System.Drawing.Size(153, 20);
            this.take_g_code.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(288, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "OFFICER ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(288, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "G_CODE";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "SEARCH OFFICER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(430, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 54);
            this.button2.TabIndex = 9;
            this.button2.Text = "SEARCH FIREARM";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CLEAR_BUTTON
            // 
            this.CLEAR_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLEAR_BUTTON.Location = new System.Drawing.Point(0, 109);
            this.CLEAR_BUTTON.Name = "CLEAR_BUTTON";
            this.CLEAR_BUTTON.Size = new System.Drawing.Size(153, 54);
            this.CLEAR_BUTTON.TabIndex = 10;
            this.CLEAR_BUTTON.Text = "CLEAR";
            this.CLEAR_BUTTON.UseVisualStyleBackColor = true;
            this.CLEAR_BUTTON.Click += new System.EventHandler(this.CLEAR_BUTTON_Click);
            // 
            // issue_button
            // 
            this.issue_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue_button.Location = new System.Drawing.Point(65, 387);
            this.issue_button.Name = "issue_button";
            this.issue_button.Size = new System.Drawing.Size(153, 54);
            this.issue_button.TabIndex = 11;
            this.issue_button.Text = "ISSUE";
            this.issue_button.UseVisualStyleBackColor = true;
            this.issue_button.Click += new System.EventHandler(this.issue_button_Click);
            // 
            // return_button
            // 
            this.return_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_button.Location = new System.Drawing.Point(795, 387);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(153, 54);
            this.return_button.TabIndex = 12;
            this.return_button.Text = "RETURN";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 465);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1051, 168);
            this.dataGridView1.TabIndex = 13;
            // 
            // showlog_button
            // 
            this.showlog_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showlog_button.Location = new System.Drawing.Point(430, 387);
            this.showlog_button.Name = "showlog_button";
            this.showlog_button.Size = new System.Drawing.Size(153, 54);
            this.showlog_button.TabIndex = 14;
            this.showlog_button.Text = "ISSUE LOG";
            this.showlog_button.UseVisualStyleBackColor = true;
            this.showlog_button.Click += new System.EventHandler(this.showlog_button_Click);
            // 
            // gun_issued
            // 
            this.gun_issued.AutoSize = true;
            this.gun_issued.BackColor = System.Drawing.Color.Transparent;
            this.gun_issued.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gun_issued.ForeColor = System.Drawing.Color.Green;
            this.gun_issued.Location = new System.Drawing.Point(895, 74);
            this.gun_issued.Name = "gun_issued";
            this.gun_issued.Size = new System.Drawing.Size(51, 20);
            this.gun_issued.TabIndex = 15;
            this.gun_issued.Text = "label6";
            // 
            // TRANSACTION_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::DELHI_POLICE.Properties.Resources.images__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.gun_issued);
            this.Controls.Add(this.showlog_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.issue_button);
            this.Controls.Add(this.CLEAR_BUTTON);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.take_g_code);
            this.Controls.Add(this.take_officer_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.issued_to_officer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transaction);
            this.Name = "TRANSACTION_UserControl";
            this.Size = new System.Drawing.Size(1051, 633);
            this.Load += new System.EventHandler(this.TRANSACTION_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label transaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label issued_to_officer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox take_officer_id;
        private System.Windows.Forms.MaskedTextBox take_g_code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CLEAR_BUTTON;
        private System.Windows.Forms.Button issue_button;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showlog_button;
        private System.Windows.Forms.Label gun_issued;
    }
}
