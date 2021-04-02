﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using webTRON_Management_Software.Models;
using webTRON_Management_Software.Views.Others;

namespace webTRON_Management_Software.Views.Landing_Window
{
    public partial class LandingWindow : Form
    {

        //Instantiating User Class
        User newUser = new User();
        public LandingWindow()
        {
            InitializeComponent();
        }

        //Login Button Click Event
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //Instantiate object properties
            newUser.userID = userIDTextBox.Text;
            newUser.password = passwordTextBox.Text;

            //Validating user input
            if (newUser.userID == "" || newUser.password == "")
            {
                MessageBox.Show("Fll all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                //Check valid user or nont
                bool isSucess = newUser.CheckUser(newUser);
                if (isSucess)
                {
                    //check wheather the user login is first time or not into the system
                    bool isFirstTime = newUser.IsFirstTimeLogin(newUser.userID);
                    if (isFirstTime)
                    {
                        newUser.StoreLogInInfo(newUser.userID);

                    }
                    else
                    {
                        newUser.UpdateLogInInfo(newUser.userID);

                    }
                    //Authorize User
                    AuthorizeUser();

                }
                else
                {
                    MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        //Minimize button click event
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Close button click event
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Method to authorize user
        private void AuthorizeUser()
        {
            //Get User Role
            string userRole = newUser.GetUserRole(newUser.userID);
            switch (userRole)
            {
                case "Admin":
                    this.Hide();
                    AdminDashboard adminDashBoard = new AdminDashboard();
                    adminDashBoard.Show();
                    break;
                case "Doctor":
                    this.Hide();
                    DoctorDashboard doctorDashboard = new DoctorDashboard();
                    doctorDashboard.Show();
                    break;
                case "Accountant":
                    this.Hide();
                    AccountantDashboard accountDashboard = new AccountantDashboard();
                    accountDashboard.Show();
                    break;
                case "Management":
                    this.Hide();
                    ManagementDashboard managementDashboard = new ManagementDashboard();
                    managementDashboard.Show();
                     break;
                case "Other":
                    this.Hide();
                    Dashboard otherDashboard = new Dashboard();
                    otherDashboard.Show();
                   break;

            }

        }
        //Method to handle click event
        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.Show();
        }
    }
}
