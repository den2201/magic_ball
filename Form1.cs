using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Answer_Ball
{
    public partial class Form1 : Form
    {

        private string text = "Magic Box";

        public Form1()
        {
            InitializeComponent();
        }

        async private void Btn_magic_Click(object sender, EventArgs e)
        {
            btn_magic.Enabled = false;
        
            await Task.Run(() =>
            {
                for (int i = 1; i <= 100; i++)
                {
                    this.Invoke(new Action(() =>
                    {
                        updateProgressBar(i);
                        this.Text = i.ToString() +"%";
                       
                    }));
                    Thread.Sleep(20);
                }
            });
                MessageBox.Show("Prediction");
            this.Text = text;
            btn_magic.Enabled = true;
            this.progress_B.Value = 0;
        }

        private void updateProgressBar(int i)
        {

            progress_B.Value = i;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = text;

        }
    }
}





    
