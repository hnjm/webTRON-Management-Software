﻿
namespace webTRON_Management_Software.Views.Others
{
    partial class ChangePassword
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.DragableChangePassword = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.sidebarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSignOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.activePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.actveForm = new System.Windows.Forms.Label();
            this.activeUserPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.activeUserName = new System.Windows.Forms.Label();
            this.currentPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.newPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.btnChangePassword = new Guna.UI2.WinForms.Guna2Button();
            this.verificationCodePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.verificationCodeTextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.verificationCodeTextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.verificationCodeTextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnVerify = new Guna.UI2.WinForms.Guna2Button();
            this.lblEnterVerificationCode = new System.Windows.Forms.Label();
            this.verificationCodeTextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.sidebarPanel.SuspendLayout();
            this.activePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).BeginInit();
            this.verificationCodePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DragableChangePassword
            // 
            this.DragableChangePassword.TargetControl = null;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1288, 9);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnExit.TabIndex = 37;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.SignOut);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1223, 27);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(21, 4);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimize.TabIndex = 38;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.Controls.Add(this.btnSignOut);
            this.sidebarPanel.Controls.Add(this.btnSettings);
            this.sidebarPanel.Controls.Add(this.btnDashboard);
            this.sidebarPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.sidebarPanel.Location = new System.Drawing.Point(0, -2);
            this.sidebarPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.ShadowDecoration.Parent = this.sidebarPanel;
            this.sidebarPanel.Size = new System.Drawing.Size(91, 655);
            this.sidebarPanel.TabIndex = 39;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Animated = true;
            this.btnSignOut.CheckedState.Parent = this.btnSignOut;
            this.btnSignOut.CustomImages.Parent = this.btnSignOut;
            this.btnSignOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.HoverState.Parent = this.btnSignOut;
            this.btnSignOut.Image = global::webTRON_Management_Software.Properties.Resources.exit_icon;
            this.btnSignOut.ImageOffset = new System.Drawing.Point(10, -10);
            this.btnSignOut.Location = new System.Drawing.Point(0, 576);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.ShadowDecoration.Parent = this.btnSignOut;
            this.btnSignOut.Size = new System.Drawing.Size(91, 59);
            this.btnSignOut.TabIndex = 24;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.TextOffset = new System.Drawing.Point(-8, 10);
            this.btnSignOut.Click += new System.EventHandler(this.SignOut);
            // 
            // btnSettings
            // 
            this.btnSettings.Animated = true;
            this.btnSettings.CheckedState.Parent = this.btnSettings;
            this.btnSettings.CustomImages.Parent = this.btnSettings;
            this.btnSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(131)))), ((int)(((byte)(228)))));
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.HoverState.Parent = this.btnSettings;
            this.btnSettings.Image = global::webTRON_Management_Software.Properties.Resources.settings_icon;
            this.btnSettings.ImageOffset = new System.Drawing.Point(10, -12);
            this.btnSettings.Location = new System.Drawing.Point(0, 228);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ShadowDecoration.Parent = this.btnSettings;
            this.btnSettings.Size = new System.Drawing.Size(91, 59);
            this.btnSettings.TabIndex = 23;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextOffset = new System.Drawing.Point(-8, 10);
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Animated = true;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Image = global::webTRON_Management_Software.Properties.Resources.dashboard_icon;
            this.btnDashboard.ImageOffset = new System.Drawing.Point(15, -12);
            this.btnDashboard.Location = new System.Drawing.Point(0, 142);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(91, 59);
            this.btnDashboard.TabIndex = 21;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextOffset = new System.Drawing.Point(-6, 10);
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // activePanel
            // 
            this.activePanel.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.rectangle_curved_large;
            this.activePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.activePanel.Controls.Add(this.actveForm);
            this.activePanel.Controls.Add(this.activeUserPicture);
            this.activePanel.Controls.Add(this.activeUserName);
            this.activePanel.Location = new System.Drawing.Point(88, -1);
            this.activePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activePanel.Name = "activePanel";
            this.activePanel.ShadowDecoration.Parent = this.activePanel;
            this.activePanel.Size = new System.Drawing.Size(220, 98);
            this.activePanel.TabIndex = 40;
            // 
            // actveForm
            // 
            this.actveForm.AutoSize = true;
            this.actveForm.BackColor = System.Drawing.Color.Transparent;
            this.actveForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actveForm.ForeColor = System.Drawing.Color.White;
            this.actveForm.Location = new System.Drawing.Point(85, 49);
            this.actveForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.actveForm.Name = "actveForm";
            this.actveForm.Size = new System.Drawing.Size(83, 25);
            this.actveForm.TabIndex = 21;
            this.actveForm.Text = "Settings";
            // 
            // activeUserPicture
            // 
            this.activeUserPicture.BackColor = System.Drawing.Color.Transparent;
            this.activeUserPicture.Image = global::webTRON_Management_Software.Properties.Resources.man_picture;
            this.activeUserPicture.Location = new System.Drawing.Point(9, 16);
            this.activeUserPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activeUserPicture.Name = "activeUserPicture";
            this.activeUserPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.activeUserPicture.ShadowDecoration.Parent = this.activeUserPicture;
            this.activeUserPicture.Size = new System.Drawing.Size(65, 55);
            this.activeUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.activeUserPicture.TabIndex = 0;
            this.activeUserPicture.TabStop = false;
            // 
            // activeUserName
            // 
            this.activeUserName.AutoSize = true;
            this.activeUserName.BackColor = System.Drawing.Color.Transparent;
            this.activeUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeUserName.ForeColor = System.Drawing.Color.White;
            this.activeUserName.Location = new System.Drawing.Point(85, 11);
            this.activeUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.activeUserName.Name = "activeUserName";
            this.activeUserName.Size = new System.Drawing.Size(65, 29);
            this.activeUserName.TabIndex = 1;
            this.activeUserName.Text = "John";
            // 
            // currentPasswordTextBox
            // 
            this.currentPasswordTextBox.Animated = true;
            this.currentPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.currentPasswordTextBox.DefaultText = "";
            this.currentPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.currentPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.currentPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.currentPasswordTextBox.DisabledState.Parent = this.currentPasswordTextBox;
            this.currentPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.currentPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.currentPasswordTextBox.FocusedState.Parent = this.currentPasswordTextBox;
            this.currentPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.currentPasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.currentPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.currentPasswordTextBox.HoverState.Parent = this.currentPasswordTextBox;
            this.currentPasswordTextBox.Location = new System.Drawing.Point(573, 166);
            this.currentPasswordTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.currentPasswordTextBox.Name = "currentPasswordTextBox";
            this.currentPasswordTextBox.PasswordChar = '\0';
            this.currentPasswordTextBox.PlaceholderText = "Current Password";
            this.currentPasswordTextBox.SelectedText = "";
            this.currentPasswordTextBox.ShadowDecoration.Parent = this.currentPasswordTextBox;
            this.currentPasswordTextBox.Size = new System.Drawing.Size(344, 44);
            this.currentPasswordTextBox.TabIndex = 42;
            this.currentPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblCurrentPassword.Location = new System.Drawing.Point(569, 116);
            this.lblCurrentPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(211, 29);
            this.lblCurrentPassword.TabIndex = 48;
            this.lblCurrentPassword.Text = "Current Password:";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblConfirmPassword.Location = new System.Drawing.Point(569, 334);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(216, 29);
            this.lblConfirmPassword.TabIndex = 47;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Animated = true;
            this.confirmPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmPasswordTextBox.DefaultText = "";
            this.confirmPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.confirmPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.confirmPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmPasswordTextBox.DisabledState.Parent = this.confirmPasswordTextBox;
            this.confirmPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmPasswordTextBox.FocusedState.Parent = this.confirmPasswordTextBox;
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.confirmPasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.confirmPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmPasswordTextBox.HoverState.Parent = this.confirmPasswordTextBox;
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(576, 380);
            this.confirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '\0';
            this.confirmPasswordTextBox.PlaceholderText = "Confirm Password";
            this.confirmPasswordTextBox.SelectedText = "";
            this.confirmPasswordTextBox.ShadowDecoration.Parent = this.confirmPasswordTextBox;
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(344, 44);
            this.confirmPasswordTextBox.TabIndex = 44;
            this.confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Animated = true;
            this.newPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newPasswordTextBox.DefaultText = "";
            this.newPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.newPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.newPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPasswordTextBox.DisabledState.Parent = this.newPasswordTextBox;
            this.newPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newPasswordTextBox.FocusedState.Parent = this.newPasswordTextBox;
            this.newPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.newPasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.newPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newPasswordTextBox.HoverState.Parent = this.newPasswordTextBox;
            this.newPasswordTextBox.Location = new System.Drawing.Point(575, 278);
            this.newPasswordTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '\0';
            this.newPasswordTextBox.PlaceholderText = "New Password";
            this.newPasswordTextBox.SelectedText = "";
            this.newPasswordTextBox.ShadowDecoration.Parent = this.newPasswordTextBox;
            this.newPasswordTextBox.Size = new System.Drawing.Size(344, 44);
            this.newPasswordTextBox.TabIndex = 43;
            this.newPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblNewPassword.Location = new System.Drawing.Point(571, 228);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(182, 29);
            this.lblNewPassword.TabIndex = 46;
            this.lblNewPassword.Text = "New Password:";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Animated = true;
            this.btnChangePassword.CheckedState.Parent = this.btnChangePassword;
            this.btnChangePassword.CustomImages.Parent = this.btnChangePassword;
            this.btnChangePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.HoverState.Parent = this.btnChangePassword;
            this.btnChangePassword.Location = new System.Drawing.Point(576, 473);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.ShadowDecoration.Parent = this.btnChangePassword;
            this.btnChangePassword.Size = new System.Drawing.Size(344, 65);
            this.btnChangePassword.TabIndex = 45;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // verificationCodePanel
            // 
            this.verificationCodePanel.Controls.Add(this.verificationCodeTextBox2);
            this.verificationCodePanel.Controls.Add(this.verificationCodeTextBox3);
            this.verificationCodePanel.Controls.Add(this.verificationCodeTextBox4);
            this.verificationCodePanel.Controls.Add(this.btnVerify);
            this.verificationCodePanel.Controls.Add(this.lblEnterVerificationCode);
            this.verificationCodePanel.Controls.Add(this.verificationCodeTextBox1);
            this.verificationCodePanel.Location = new System.Drawing.Point(371, 42);
            this.verificationCodePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.verificationCodePanel.Name = "verificationCodePanel";
            this.verificationCodePanel.ShadowDecoration.Parent = this.verificationCodePanel;
            this.verificationCodePanel.Size = new System.Drawing.Size(748, 591);
            this.verificationCodePanel.TabIndex = 49;
            this.verificationCodePanel.Visible = false;
            // 
            // verificationCodeTextBox2
            // 
            this.verificationCodeTextBox2.Animated = true;
            this.verificationCodeTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.verificationCodeTextBox2.DefaultText = "";
            this.verificationCodeTextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.verificationCodeTextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.verificationCodeTextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox2.DisabledState.Parent = this.verificationCodeTextBox2;
            this.verificationCodeTextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox2.FocusedState.Parent = this.verificationCodeTextBox2;
            this.verificationCodeTextBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.verificationCodeTextBox2.ForeColor = System.Drawing.Color.Black;
            this.verificationCodeTextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox2.HoverState.Parent = this.verificationCodeTextBox2;
            this.verificationCodeTextBox2.Location = new System.Drawing.Point(293, 233);
            this.verificationCodeTextBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.verificationCodeTextBox2.Name = "verificationCodeTextBox2";
            this.verificationCodeTextBox2.PasswordChar = '\0';
            this.verificationCodeTextBox2.PlaceholderText = "";
            this.verificationCodeTextBox2.SelectedText = "";
            this.verificationCodeTextBox2.ShadowDecoration.Parent = this.verificationCodeTextBox2;
            this.verificationCodeTextBox2.Size = new System.Drawing.Size(51, 47);
            this.verificationCodeTextBox2.TabIndex = 1;
            this.verificationCodeTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.verificationCodeTextBox2.TextChanged += new System.EventHandler(this.VerificationCodeTextBox2_TextChanged);
            // 
            // verificationCodeTextBox3
            // 
            this.verificationCodeTextBox3.Animated = true;
            this.verificationCodeTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.verificationCodeTextBox3.DefaultText = "";
            this.verificationCodeTextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.verificationCodeTextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.verificationCodeTextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox3.DisabledState.Parent = this.verificationCodeTextBox3;
            this.verificationCodeTextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox3.FocusedState.Parent = this.verificationCodeTextBox3;
            this.verificationCodeTextBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.verificationCodeTextBox3.ForeColor = System.Drawing.Color.Black;
            this.verificationCodeTextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox3.HoverState.Parent = this.verificationCodeTextBox3;
            this.verificationCodeTextBox3.Location = new System.Drawing.Point(371, 233);
            this.verificationCodeTextBox3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.verificationCodeTextBox3.Name = "verificationCodeTextBox3";
            this.verificationCodeTextBox3.PasswordChar = '\0';
            this.verificationCodeTextBox3.PlaceholderText = "";
            this.verificationCodeTextBox3.SelectedText = "";
            this.verificationCodeTextBox3.ShadowDecoration.Parent = this.verificationCodeTextBox3;
            this.verificationCodeTextBox3.Size = new System.Drawing.Size(51, 47);
            this.verificationCodeTextBox3.TabIndex = 2;
            this.verificationCodeTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.verificationCodeTextBox3.TextChanged += new System.EventHandler(this.VerificationCodeTextBox3_TextChanged);
            // 
            // verificationCodeTextBox4
            // 
            this.verificationCodeTextBox4.Animated = true;
            this.verificationCodeTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.verificationCodeTextBox4.DefaultText = "";
            this.verificationCodeTextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.verificationCodeTextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.verificationCodeTextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox4.DisabledState.Parent = this.verificationCodeTextBox4;
            this.verificationCodeTextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox4.FocusedState.Parent = this.verificationCodeTextBox4;
            this.verificationCodeTextBox4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.verificationCodeTextBox4.ForeColor = System.Drawing.Color.Black;
            this.verificationCodeTextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox4.HoverState.Parent = this.verificationCodeTextBox4;
            this.verificationCodeTextBox4.Location = new System.Drawing.Point(439, 233);
            this.verificationCodeTextBox4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.verificationCodeTextBox4.Name = "verificationCodeTextBox4";
            this.verificationCodeTextBox4.PasswordChar = '\0';
            this.verificationCodeTextBox4.PlaceholderText = "";
            this.verificationCodeTextBox4.SelectedText = "";
            this.verificationCodeTextBox4.ShadowDecoration.Parent = this.verificationCodeTextBox4;
            this.verificationCodeTextBox4.Size = new System.Drawing.Size(51, 47);
            this.verificationCodeTextBox4.TabIndex = 3;
            this.verificationCodeTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.verificationCodeTextBox4.TextChanged += new System.EventHandler(this.VerificationCodeTextBox4_TextChanged);
            // 
            // btnVerify
            // 
            this.btnVerify.Animated = true;
            this.btnVerify.CheckedState.Parent = this.btnVerify;
            this.btnVerify.CustomImages.Parent = this.btnVerify;
            this.btnVerify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.HoverState.Parent = this.btnVerify;
            this.btnVerify.Location = new System.Drawing.Point(220, 354);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.ShadowDecoration.Parent = this.btnVerify;
            this.btnVerify.Size = new System.Drawing.Size(271, 65);
            this.btnVerify.TabIndex = 14;
            this.btnVerify.Text = "Verify";
            this.btnVerify.Click += new System.EventHandler(this.BtnVerify_Click);
            // 
            // lblEnterVerificationCode
            // 
            this.lblEnterVerificationCode.AutoSize = true;
            this.lblEnterVerificationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblEnterVerificationCode.Location = new System.Drawing.Point(213, 178);
            this.lblEnterVerificationCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterVerificationCode.Name = "lblEnterVerificationCode";
            this.lblEnterVerificationCode.Size = new System.Drawing.Size(266, 29);
            this.lblEnterVerificationCode.TabIndex = 13;
            this.lblEnterVerificationCode.Text = "Enter Verification Code:";
            // 
            // verificationCodeTextBox1
            // 
            this.verificationCodeTextBox1.Animated = true;
            this.verificationCodeTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.verificationCodeTextBox1.DefaultText = "";
            this.verificationCodeTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.verificationCodeTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.verificationCodeTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox1.DisabledState.Parent = this.verificationCodeTextBox1;
            this.verificationCodeTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox1.FocusedState.Parent = this.verificationCodeTextBox1;
            this.verificationCodeTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.verificationCodeTextBox1.ForeColor = System.Drawing.Color.Black;
            this.verificationCodeTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox1.HoverState.Parent = this.verificationCodeTextBox1;
            this.verificationCodeTextBox1.Location = new System.Drawing.Point(220, 233);
            this.verificationCodeTextBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.verificationCodeTextBox1.Name = "verificationCodeTextBox1";
            this.verificationCodeTextBox1.PasswordChar = '\0';
            this.verificationCodeTextBox1.PlaceholderText = "";
            this.verificationCodeTextBox1.SelectedText = "";
            this.verificationCodeTextBox1.ShadowDecoration.Parent = this.verificationCodeTextBox1;
            this.verificationCodeTextBox1.Size = new System.Drawing.Size(51, 47);
            this.verificationCodeTextBox1.TabIndex = 0;
            this.verificationCodeTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.verificationCodeTextBox1.TextChanged += new System.EventHandler(this.VerificationCodeTextBox1_TextChanged);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 769);
            this.Controls.Add(this.verificationCodePanel);
            this.Controls.Add(this.currentPasswordTextBox);
            this.Controls.Add(this.lblCurrentPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.activePanel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMinimize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.sidebarPanel.ResumeLayout(false);
            this.activePanel.ResumeLayout(false);
            this.activePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).EndInit();
            this.verificationCodePanel.ResumeLayout(false);
            this.verificationCodePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl DragableChangePassword;
        private Guna.UI2.WinForms.Guna2PictureBox btnExit;
        private Guna.UI2.WinForms.Guna2PictureBox btnMinimize;
        private Guna.UI2.WinForms.Guna2Panel sidebarPanel;
        private Guna.UI2.WinForms.Guna2Button btnSignOut;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Panel activePanel;
        private System.Windows.Forms.Label actveForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox activeUserPicture;
        private System.Windows.Forms.Label activeUserName;
        private Guna.UI2.WinForms.Guna2TextBox currentPasswordTextBox;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox confirmPasswordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox newPasswordTextBox;
        private System.Windows.Forms.Label lblNewPassword;
        private Guna.UI2.WinForms.Guna2Button btnChangePassword;
        private Guna.UI2.WinForms.Guna2Panel verificationCodePanel;
        private Guna.UI2.WinForms.Guna2TextBox verificationCodeTextBox2;
        private Guna.UI2.WinForms.Guna2TextBox verificationCodeTextBox3;
        private Guna.UI2.WinForms.Guna2TextBox verificationCodeTextBox4;
        private Guna.UI2.WinForms.Guna2Button btnVerify;
        private System.Windows.Forms.Label lblEnterVerificationCode;
        private Guna.UI2.WinForms.Guna2TextBox verificationCodeTextBox1;
    }
}