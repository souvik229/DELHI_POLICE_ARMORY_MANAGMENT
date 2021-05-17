
namespace DELHI_POLICE
{
    partial class ARMORY_UserControl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GUN_CODE_SEARCH_TEXTBOX = new System.Windows.Forms.TextBox();
            this.search_gun = new System.Windows.Forms.Button();
            this.ADD_ARMORY_button = new System.Windows.Forms.Button();
            this.CLEAR_TEXT_BOX_button = new System.Windows.Forms.Button();
            this.UPDATE_ARMORY_button = new System.Windows.Forms.Button();
            this.DELETE_ARMORY_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lable5 = new System.Windows.Forms.Label();
            this.GUN_CODE_TAKE_textBox = new System.Windows.Forms.TextBox();
            this.PRECINCT_ID_TAKE_textBox = new System.Windows.Forms.TextBox();
            this.NAME_TAKE_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1051, 169);
            this.dataGridView1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(193, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Gun_code";
            this.label9.Click += new System.EventHandler(this.g_code_ARMORY_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(336, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "GUN_ID";
            this.label8.Click += new System.EventHandler(this.GUN_ID_TAKE_ARMORY_Click);
            // 
            // GUN_CODE_SEARCH_TEXTBOX
            // 
            this.GUN_CODE_SEARCH_TEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GUN_CODE_SEARCH_TEXTBOX.Location = new System.Drawing.Point(286, 42);
            this.GUN_CODE_SEARCH_TEXTBOX.Name = "GUN_CODE_SEARCH_TEXTBOX";
            this.GUN_CODE_SEARCH_TEXTBOX.Size = new System.Drawing.Size(395, 26);
            this.GUN_CODE_SEARCH_TEXTBOX.TabIndex = 3;
            // 
            // search_gun
            // 
            this.search_gun.Location = new System.Drawing.Point(395, 85);
            this.search_gun.Name = "search_gun";
            this.search_gun.Size = new System.Drawing.Size(147, 29);
            this.search_gun.TabIndex = 4;
            this.search_gun.Text = "SEARCH";
            this.search_gun.UseVisualStyleBackColor = true;
            this.search_gun.Click += new System.EventHandler(this.search_gun_Click);
            // 
            // ADD_ARMORY_button
            // 
            this.ADD_ARMORY_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_ARMORY_button.Location = new System.Drawing.Point(49, 358);
            this.ADD_ARMORY_button.Name = "ADD_ARMORY_button";
            this.ADD_ARMORY_button.Size = new System.Drawing.Size(120, 33);
            this.ADD_ARMORY_button.TabIndex = 5;
            this.ADD_ARMORY_button.Text = "ADD";
            this.ADD_ARMORY_button.UseVisualStyleBackColor = true;
            this.ADD_ARMORY_button.Click += new System.EventHandler(this.ADD_ARMORY_button_Click);
            // 
            // CLEAR_TEXT_BOX_button
            // 
            this.CLEAR_TEXT_BOX_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLEAR_TEXT_BOX_button.Location = new System.Drawing.Point(49, 526);
            this.CLEAR_TEXT_BOX_button.Name = "CLEAR_TEXT_BOX_button";
            this.CLEAR_TEXT_BOX_button.Size = new System.Drawing.Size(120, 33);
            this.CLEAR_TEXT_BOX_button.TabIndex = 6;
            this.CLEAR_TEXT_BOX_button.Text = "CLEAR";
            this.CLEAR_TEXT_BOX_button.UseVisualStyleBackColor = true;
            this.CLEAR_TEXT_BOX_button.Click += new System.EventHandler(this.CLEAR_TEXT_BOX_button_Click);
            // 
            // UPDATE_ARMORY_button
            // 
            this.UPDATE_ARMORY_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATE_ARMORY_button.Location = new System.Drawing.Point(49, 413);
            this.UPDATE_ARMORY_button.Name = "UPDATE_ARMORY_button";
            this.UPDATE_ARMORY_button.Size = new System.Drawing.Size(120, 33);
            this.UPDATE_ARMORY_button.TabIndex = 6;
            this.UPDATE_ARMORY_button.Text = "UPDATE";
            this.UPDATE_ARMORY_button.UseVisualStyleBackColor = true;
            this.UPDATE_ARMORY_button.Click += new System.EventHandler(this.UPDATE_ARMORY_button_Click);
            // 
            // DELETE_ARMORY_button
            // 
            this.DELETE_ARMORY_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETE_ARMORY_button.Location = new System.Drawing.Point(49, 469);
            this.DELETE_ARMORY_button.Name = "DELETE_ARMORY_button";
            this.DELETE_ARMORY_button.Size = new System.Drawing.Size(120, 33);
            this.DELETE_ARMORY_button.TabIndex = 7;
            this.DELETE_ARMORY_button.Text = "DELETE";
            this.DELETE_ARMORY_button.UseVisualStyleBackColor = true;
            this.DELETE_ARMORY_button.Click += new System.EventHandler(this.DELETE_ARMORY_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(336, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "NAME";
            // 
            // lable5
            // 
            this.lable5.AutoSize = true;
            this.lable5.BackColor = System.Drawing.Color.Transparent;
            this.lable5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable5.Location = new System.Drawing.Point(336, 517);
            this.lable5.Name = "lable5";
            this.lable5.Size = new System.Drawing.Size(110, 20);
            this.lable5.TabIndex = 9;
            this.lable5.Text = "PRECINCT ID";
            // 
            // GUN_CODE_TAKE_textBox
            // 
            this.GUN_CODE_TAKE_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GUN_CODE_TAKE_textBox.Location = new System.Drawing.Point(452, 375);
            this.GUN_CODE_TAKE_textBox.Name = "GUN_CODE_TAKE_textBox";
            this.GUN_CODE_TAKE_textBox.Size = new System.Drawing.Size(395, 26);
            this.GUN_CODE_TAKE_textBox.TabIndex = 10;
            // 
            // PRECINCT_ID_TAKE_textBox
            // 
            this.PRECINCT_ID_TAKE_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRECINCT_ID_TAKE_textBox.Location = new System.Drawing.Point(452, 514);
            this.PRECINCT_ID_TAKE_textBox.Name = "PRECINCT_ID_TAKE_textBox";
            this.PRECINCT_ID_TAKE_textBox.Size = new System.Drawing.Size(395, 26);
            this.PRECINCT_ID_TAKE_textBox.TabIndex = 10;
            // 
            // NAME_TAKE_textBox
            // 
            this.NAME_TAKE_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAME_TAKE_textBox.Location = new System.Drawing.Point(452, 442);
            this.NAME_TAKE_textBox.Name = "NAME_TAKE_textBox";
            this.NAME_TAKE_textBox.Size = new System.Drawing.Size(395, 26);
            this.NAME_TAKE_textBox.TabIndex = 11;
            // 
            // ARMORY_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImage = global::DELHI_POLICE.Properties.Resources.e271fda72f1e158b5f0569cc72d36d7f;
            this.Controls.Add(this.NAME_TAKE_textBox);
            this.Controls.Add(this.PRECINCT_ID_TAKE_textBox);
            this.Controls.Add(this.GUN_CODE_TAKE_textBox);
            this.Controls.Add(this.lable5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DELETE_ARMORY_button);
            this.Controls.Add(this.UPDATE_ARMORY_button);
            this.Controls.Add(this.CLEAR_TEXT_BOX_button);
            this.Controls.Add(this.ADD_ARMORY_button);
            this.Controls.Add(this.search_gun);
            this.Controls.Add(this.GUN_CODE_SEARCH_TEXTBOX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ARMORY_UserControl";
            this.Size = new System.Drawing.Size(1051, 633);
            this.Load += new System.EventHandler(this.ARMORY_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox GUN_CODE_SEARCH_TEXTBOX;
        private System.Windows.Forms.Button search_gun;
        private System.Windows.Forms.Button ADD_ARMORY_button;
        private System.Windows.Forms.Button CLEAR_TEXT_BOX_button;
        private System.Windows.Forms.Button UPDATE_ARMORY_button;
        private System.Windows.Forms.Button DELETE_ARMORY_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lable5;
        private System.Windows.Forms.TextBox GUN_CODE_TAKE_textBox;
        private System.Windows.Forms.TextBox PRECINCT_ID_TAKE_textBox;
        private System.Windows.Forms.TextBox NAME_TAKE_textBox;
    }
}
