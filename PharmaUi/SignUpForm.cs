using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
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

        public SignUpForm() {
            InitializeComponent();
           //this.FormBorderStyle = FormBorderStyle.None;
           Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
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
            PersonalDataValidator personalDataValidator = new PersonalDataValidator();
            if(!personalDataValidator.validateInfo(firstNameValue.Text, lastNameValue.Text))
            {
                MessageBox.Show("Invalid information was entered\nPlease retry");
                return;
            } 
            MessageBox.Show("Buttom Clicked!");
            return;

        }
    }
}
