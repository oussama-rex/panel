using KeyAuth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;
namespace LoginForm1
{
    
    public partial class Form1 : Form 
    {
        
        private bool isInitialized = false;

        public static api KeyAuthApp = new api(
        name: "Kaoutar Batata's Application",
        ownerid: "G0GdHd40Z5",
                 "02761aea1069af7a16c93f6a7a995e2ef1439b363efc928056d6e8ee572a2e8",
                
                  "1.0" // Application version. Used for automatic downloads see video here https://www.youtube.com/watch?v=kW195PLCBKs
                       //path: @"Your_Path_Here" // (OPTIONAL) see tutorial here https://www.youtube.com/watch?v=I9rxt821gMk&t=1s

 );
        public Form1()
        {
            InitializeComponent();
        }
        
        private async void Form1_Load(object sender, EventArgs e)
        {
             await KeyAuthApp.init();
            isInitialized = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void guna2Button1_Click(object sender, EventArgs e)

        {
            KeyAuthApp.init();
            KeyAuthApp.login(username.Text, password.Text);
            if (KeyAuthApp.response.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            { 
            MessageBox.Show("tomas wait waiiit" + KeyAuthApp.response.message);
           }
        }
         
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            register main = new register();
            main.Show();
            this.Hide();
        }
    }
}