
namespace DELHI_POLICE
{
    partial class appbody
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
            this.titlebarapp = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.armory_button = new System.Windows.Forms.Button();
            this.officer_button = new System.Windows.Forms.Button();
            this.transaction_button = new System.Windows.Forms.Button();
            this.setting_button = new System.Windows.Forms.Button();
            this.controlpanel = new System.Windows.Forms.Panel();
            this.about_button = new System.Windows.Forms.Button();
            this.logoffappbutton = new System.Windows.Forms.Button();
            this.minimizeappbutton = new System.Windows.Forms.Button();
            this.closeappbutton = new System.Windows.Forms.Button();
            this.titlebarapp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlebarapp
            // 
            this.titlebarapp.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.titlebarapp.Controls.Add(this.logoffappbutton);
            this.titlebarapp.Controls.Add(this.minimizeappbutton);
            this.titlebarapp.Controls.Add(this.closeappbutton);
            this.titlebarapp.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebarapp.Location = new System.Drawing.Point(0, 0);
            this.titlebarapp.Name = "titlebarapp";
            this.titlebarapp.Size = new System.Drawing.Size(1248, 41);
            this.titlebarapp.TabIndex = 0;
            this.titlebarapp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlebarapp_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.about_button);
            this.panel1.Controls.Add(this.setting_button);
            this.panel1.Controls.Add(this.transaction_button);
            this.panel1.Controls.Add(this.officer_button);
            this.panel1.Controls.Add(this.armory_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 633);
            this.panel1.TabIndex = 1;
            // 
            // armory_button
            // 
            this.armory_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.armory_button.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.armory_button.Location = new System.Drawing.Point(0, 0);
            this.armory_button.Name = "armory_button";
            this.armory_button.Size = new System.Drawing.Size(197, 80);
            this.armory_button.TabIndex = 2;
            this.armory_button.Text = "ARMORY";
            this.armory_button.UseVisualStyleBackColor = true;
            this.armory_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // officer_button
            // 
            this.officer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.officer_button.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officer_button.Location = new System.Drawing.Point(0, 77);
            this.officer_button.Name = "officer_button";
            this.officer_button.Size = new System.Drawing.Size(197, 80);
            this.officer_button.TabIndex = 3;
            this.officer_button.Text = "OFFICER";
            this.officer_button.UseVisualStyleBackColor = true;
            this.officer_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // transaction_button
            // 
            this.transaction_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transaction_button.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_button.Location = new System.Drawing.Point(0, 153);
            this.transaction_button.Name = "transaction_button";
            this.transaction_button.Size = new System.Drawing.Size(197, 80);
            this.transaction_button.TabIndex = 3;
            this.transaction_button.Text = "TRANSACTIONS";
            this.transaction_button.UseVisualStyleBackColor = true;
            this.transaction_button.Click += new System.EventHandler(this.transaction_button_Click);
            // 
            // setting_button
            // 
            this.setting_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting_button.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setting_button.Location = new System.Drawing.Point(0, 229);
            this.setting_button.Name = "setting_button";
            this.setting_button.Size = new System.Drawing.Size(197, 84);
            this.setting_button.TabIndex = 3;
            this.setting_button.Text = "SETTING";
            this.setting_button.UseVisualStyleBackColor = true;
            this.setting_button.Click += new System.EventHandler(this.setting_button_Click);
            // 
            // controlpanel
            // 
            this.controlpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlpanel.Location = new System.Drawing.Point(197, 41);
            this.controlpanel.Name = "controlpanel";
            this.controlpanel.Size = new System.Drawing.Size(1051, 633);
            this.controlpanel.TabIndex = 2;
            // 
            // about_button
            // 
            this.about_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about_button.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_button.Location = new System.Drawing.Point(0, 309);
            this.about_button.Name = "about_button";
            this.about_button.Size = new System.Drawing.Size(197, 84);
            this.about_button.TabIndex = 5;
            this.about_button.Text = "ABOUT";
            this.about_button.UseVisualStyleBackColor = true;
            this.about_button.Click += new System.EventHandler(this.about_button_Click);
            // 
            // logoffappbutton
            // 
            this.logoffappbutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.logoffappbutton.BackgroundImage = global::DELHI_POLICE.Properties.Resources.logout;
            this.logoffappbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoffappbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoffappbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoffappbutton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.logoffappbutton.Location = new System.Drawing.Point(1116, 3);
            this.logoffappbutton.Name = "logoffappbutton";
            this.logoffappbutton.Size = new System.Drawing.Size(41, 33);
            this.logoffappbutton.TabIndex = 2;
            this.logoffappbutton.UseVisualStyleBackColor = false;
            this.logoffappbutton.Click += new System.EventHandler(this.logoffappbutton_Click);
            // 
            // minimizeappbutton
            // 
            this.minimizeappbutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.minimizeappbutton.BackgroundImage = global::DELHI_POLICE.Properties.Resources.minimize;
            this.minimizeappbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizeappbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeappbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeappbutton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.minimizeappbutton.Location = new System.Drawing.Point(1163, 4);
            this.minimizeappbutton.Name = "minimizeappbutton";
            this.minimizeappbutton.Size = new System.Drawing.Size(38, 32);
            this.minimizeappbutton.TabIndex = 3;
            this.minimizeappbutton.UseVisualStyleBackColor = false;
            this.minimizeappbutton.Click += new System.EventHandler(this.minimizeappbutton_Click);
            // 
            // closeappbutton
            // 
            this.closeappbutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.closeappbutton.BackgroundImage = global::DELHI_POLICE.Properties.Resources.delete;
            this.closeappbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeappbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeappbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeappbutton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.closeappbutton.Location = new System.Drawing.Point(1207, 4);
            this.closeappbutton.Name = "closeappbutton";
            this.closeappbutton.Size = new System.Drawing.Size(38, 32);
            this.closeappbutton.TabIndex = 1;
            this.closeappbutton.UseVisualStyleBackColor = false;
            this.closeappbutton.Click += new System.EventHandler(this.closeappbutton_Click);
            // 
            // appbody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1248, 674);
            this.Controls.Add(this.controlpanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titlebarapp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "appbody";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "appbody";
            this.titlebarapp.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlebarapp;
        private System.Windows.Forms.Button logoffappbutton;
        private System.Windows.Forms.Button minimizeappbutton;
        private System.Windows.Forms.Button closeappbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button about_button;
        private System.Windows.Forms.Button setting_button;
        private System.Windows.Forms.Button transaction_button;
        private System.Windows.Forms.Button officer_button;
        private System.Windows.Forms.Button armory_button;
        private System.Windows.Forms.Panel controlpanel;
    }
}