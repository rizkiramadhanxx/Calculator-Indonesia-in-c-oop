using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1903040168
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_jumlah_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt16(txt_bil1.Text);
                int y = Convert.ToInt16(txt_bil2.Text);
                int z = x + y;
                String h = Convert.ToString(z);
                hasil.Text = h;
            }
            catch (Exception ex)
            {
                hasil.Text = "input yang anda masukan salah";
            }
            finally
            {
                hasil.Text += "\n\nTerima Kasih";
            }

        }

        private void btn_kurang_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt16(txt_bil1.Text);
                int y = Convert.ToInt16(txt_bil2.Text);
                int z = x - y;
                String h = Convert.ToString(z);
                hasil.Text = h;
            }
            catch (Exception ex)
            {
                hasil.Text = "input yang anda masukan salah";
            }
            finally
            {
                hasil.Text += "\n\nTerima Kasih";
            }
        }

        private void btn_bagi_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt16(txt_bil1.Text);
                int y = Convert.ToInt16(txt_bil2.Text);
                int z = x / y;
                String h = Convert.ToString(z);
                hasil.Text = h;
            }
            catch (Exception ex)
            {
                hasil.Text = "input yang anda masukan salah";
            }
            finally
            {
                hasil.Text += "\n\nTerima Kasih";
            }
        }

        private void btn_kali_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt16(txt_bil1.Text);
                int y = Convert.ToInt16(txt_bil2.Text);
                int z = x * y;
                String h = Convert.ToString(z);
                hasil.Text = h;
            }
            catch (Exception ex)
            {
                hasil.Text = "input yang anda masukan salah";
            }
            finally
            {
                hasil.Text += "\n\nTerima Kasih";
            }
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt16(txt_bil1.Text);
                int y = Convert.ToInt16(txt_bil2.Text);
                int z = x % y;
                String h = Convert.ToString(z);
                hasil.Text = h;
            }
            catch (Exception ex)
            {
                hasil.Text = "input yang anda masukan salah";
            }
            finally
            {
                hasil.Text += "\n\nTerima Kasih";
            }
        }

        private void btn_akar_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txt_bil1.Text);
                double b = Convert.ToDouble(txt_bil2.Text);
                double c = Math.Pow(a, 1/b);
                String z = Convert.ToString(c);
                hasil.Text = z;
            }
            catch (Exception ex)
            {
                hasil.Text = "input yang anda masukan salah";
            }
            finally
            {
                hasil.Text += "\n\nTerima Kasih";
            }
            
        }

        private void btn_pangkat_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txt_bil1.Text);
                double b = Convert.ToDouble(txt_bil2.Text);
                double c = Math.Pow(a, b);
                String z = Convert.ToString(c);
                hasil.Text = z;


            }
            catch (Exception ex)
            {
                hasil.Text = "input yang anda masukan salah";
            }
            finally
            {
                hasil.Text += "\n\nTerima Kasih";
            }
            
        }

    }
}
