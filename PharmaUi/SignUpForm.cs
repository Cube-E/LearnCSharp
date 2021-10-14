using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using PersonalDataLibrary.Models;
using PersonalDataLibrary.Validators;

namespace PharmaUi
{
    public partial class SignUpForm : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private PersonalDataValidator _validator;
        private readonly ILogger<SignUpForm> _logger;
        public SignUpForm (PersonalDataValidator validator, ILogger<SignUpForm> logger) {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
            _validator = validator;
            _logger = logger;
        }

        protected override void OnResize(EventArgs e) {
            //base.OnResize(e);
            //this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, this.Height, 15, 15)); //play with these values till you are happy
        }

        private void firstName_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e) {

        }

        private void submitButton_Click(object sender, EventArgs e) {
            PersonalDataModel model = _validator.getInstance (firstNameValue.Text, lastNameValue.Text);
            if (model == null) 
            {
                //log message
                MessageBox.Show("Invalid information was entered\nPlease retry");
                _logger?.LogInformation ("User submitted invalid information.");
                return;
            }
            //log message
            //add model to database
            MessageBox.Show("Buttom Clicked!");
            _logger.LogInformation ("User submitted valid information");
            return;

        }
    }
}
