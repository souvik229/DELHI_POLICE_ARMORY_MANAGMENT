
namespace DELHI_POLICE
{
    partial class SETTING_UserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.PASSWORD_IN_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.USERNAME_IN_textbox = new System.Windows.Forms.TextBox();
            this.CHANGE_USERNAME_BUTTON = new System.Windows.Forms.Button();
            this.CHANGE_PASSWORD_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(404, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHANGE PASSWORD";
            // 
            // PASSWORD_IN_textbox
            // 
            this.PASSWORD_IN_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORD_IN_textbox.Location = new System.Drawing.Point(409, 442);
            this.PASSWORD_IN_textbox.Name = "PASSWORD_IN_textbox";
            this.PASSWORD_IN_textbox.Size = new System.Drawing.Size(230, 27);
            this.PASSWORD_IN_textbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(404, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "CHANGE USERNAME";
            // 
            // USERNAME_IN_textbox
            // 
            this.USERNAME_IN_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAME_IN_textbox.Location = new System.Drawing.Point(403, 123);
            this.USERNAME_IN_textbox.Name = "USERNAME_IN_textbox";
            this.USERNAME_IN_textbox.Size = new System.Drawing.Size(230, 27);
            this.USERNAME_IN_textbox.TabIndex = 3;
            // 
            // CHANGE_USERNAME_BUTTON
            // 
            this.CHANGE_USERNAME_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHANGE_USERNAME_BUTTON.Location = new System.Drawing.Point(45, 104);
            this.CHANGE_USERNAME_BUTTON.Name = "CHANGE_USERNAME_BUTTON";
            this.CHANGE_USERNAME_BUTTON.Size = new System.Drawing.Size(158, 46);
            this.CHANGE_USERNAME_BUTTON.TabIndex = 4;
            this.CHANGE_USERNAME_BUTTON.Text = "CHANGE";
            this.CHANGE_USERNAME_BUTTON.UseVisualStyleBackColor = true;
            this.CHANGE_USERNAME_BUTTON.Click += new System.EventHandler(this.CHANGE_USERNAME_BUTTON_Click);
            // 
            // CHANGE_PASSWORD_BUTTON
            // 
            this.CHANGE_PASSWORD_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHANGE_PASSWORD_BUTTON.Location = new System.Drawing.Point(45, 423);
            this.CHANGE_PASSWORD_BUTTON.Name = "CHANGE_PASSWORD_BUTTON";
            this.CHANGE_PASSWORD_BUTTON.Size = new System.Drawing.Size(158, 46);
            this.CHANGE_PASSWORD_BUTTON.TabIndex = 5;
            this.CHANGE_PASSWORD_BUTTON.Text = "CHANGE";
            this.CHANGE_PASSWORD_BUTTON.UseVisualStyleBackColor = true;
            this.CHANGE_PASSWORD_BUTTON.Click += new System.EventHandler(this.CHANGE_PASSWORD_BUTTON_Click);
            // 
            // SETTING_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImage = global::DELHI_POLICE.Properties.Resources.thumb2_neon_light_background_neon_lasers_bright_purple_background_neon_backgrounds;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.CHANGE_PASSWORD_BUTTON);
            this.Controls.Add(this.CHANGE_USERNAME_BUTTON);
            this.Controls.Add(this.USERNAME_IN_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PASSWORD_IN_textbox);
            this.Controls.Add(this.label1);
            this.Name = "SETTING_UserControl";
            this.Size = new System.Drawing.Size(1051, 633);
            this.Load += new System.EventHandler(this.SETTING_UserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PASSWORD_IN_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox USERNAME_IN_textbox;
        private System.Windows.Forms.Button CHANGE_USERNAME_BUTTON;
        private System.Windows.Forms.Button CHANGE_PASSWORD_BUTTON;
    }
}
