using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalidadTotal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Bitmap img = new Bitmap(Application.StartupPath + @"\img\mar.jpg");//
            //this.BackgroundImage = img;//
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            string total = " ";
            string totaldolares = " ";
            string totaleuros = " ";
            double cotizacion = 0.0;
            double dolares = 0.0;
            double euros = 0.0;

            total = "Boleta a nombre de: " + txtNombres.Text + "\r\n" + "De la empresa: " + textBox1.Text + "\r\n" + "Con RUC: " + txtRUC.Text + "\r\n";

            if (rbtAsesorSi.Checked == true)
            {
                cotizacion = cotizacion + 150.0;
                total += "Se le adiciona 150 PEN por un asesor \r\n";
            }
            if (rbtAsesorNo.Checked == true)
            {
                cotizacion = cotizacion + 0.0;
                total += "El cliente no solicita un asesor \r\n";
            }
            if (rbtMeses6.Checked == true)
            {
                cotizacion = cotizacion + 0.0;
                total += "La compra tiene una garantia de 6 meses \r\n";
            }
            if (rbtMeses12.Checked == true)
            {
                cotizacion = cotizacion + 0.0;
                total += "La compra tiene una grantia de 12 meses \r\n";
            }
            if (rbtMeses24.Checked == true)
            {
                cotizacion = cotizacion + 0.0;
                total += "La compra tiene una grantia de 24 meses \r\n";
            }
            if (rbtMantSi.Checked == true)
            {
                cotizacion = cotizacion + 300.0;
                total += "El cliente solicita el servicio de mantenimiento mensual de 300 PEN por 6 meses \r\n";
            }
            if (rbtMantNo.Checked == true)
            {
                cotizacion = cotizacion + 0.0;
                total += "El cliente no solicita el servicio de mantenimiento mensual \r\n";
            }
            if (chkAll.Checked == true)
            {
                cotizacion = cotizacion + 2000.0;
                total += "El cliente agrego una PC All in one de 2000 PEN a su cotizacion de \r\n";
            }
            if (chkOficina.Checked == true)
            {
                cotizacion = cotizacion + 1200.0;
                total += "El cliente agrego una PC de Oficina de 1200 PEN a su cotizacion  \r\n";
            }
            if (chkGamer.Checked == true)
            {
                cotizacion = cotizacion + 5000.0;
                total += "El cliente agrego una PC Gamer de 5000 PEN a su cotizacion  \r\n";
            }
            if (chkPedido.Checked == true)
            {
                cotizacion = cotizacion + 1000.0;
                total += "El cliente agrego una PC Escolar de 1000 PEN a su cotizacion  \r\n";
            }
            if(chkModem.Checked == true)
            {
                cotizacion = cotizacion + 120.0;
                total += "El cliente agrego un Modem WiFi de 120 PEN a su cotizacion \r\n";
            }
            if(chkRepetidores.Checked == true)
            {
                cotizacion = cotizacion + 100.0;
                total += "El cliente agrego un repetidor WiFi de 100 PEN a su cotizacion \r\n";
            }
            if(chkCable.Checked == true)
            {
                cotizacion = cotizacion + 20.0;
                total += "El cliente agrego un cable de red de 20 PEN a su cotizacion \r\n";
            }
            if(chkSwitch.Checked == true)
            {
                cotizacion = cotizacion + 50.0;
                total += "El cliente agrego un switch de red de 50 PEN a su cotizacion \r\n";
            }
            if(chkOffice.Checked == true)
            {
                cotizacion = cotizacion + 190.0;
                total += "El cliente agrego una licencia de Office 365 de 190 PEN a su cotizacion \r\n";
            }    
            if(chkAdobe.Checked == true)
            {
                cotizacion = cotizacion + 300.0;
                total += "El cliente agergo una licencia de Adobe de 300 PEN a su cotizacion \r\n";
            }
            if(chkWindows.Checked == true)
            {
                cotizacion = cotizacion + 70.0;
                total += "El cliente agrego una licencia de Windows de 70 PEN a su cotizacion \r\n";
            }
            total += "El precio total de la cotizacion es de :" + cotizacion.ToString() + " PEN";

            dolares = cotizacion;

            euros = cotizacion;

            totaldolares += dolares / 3.59;

            totaleuros += euros / 4.32;

            txtCotizacion.Text = total;
            txtDolares.Text = totaldolares;
            txtEuros.Text = totaleuros;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCotizacion.Text = " ";
            textBox1.Text = " ";
            txtNombres.Text = " ";
            txtEuros.Text = " ";
            txtDolares.Text = " ";
            txtRUC.Text = " ";
            chkAll.Checked = false;
            chkAdobe.Checked = false;
            chkCable.Checked = false;
            chkGamer.Checked = false;
            chkModem.Checked = false;
            chkOffice.Checked = false;
            chkOficina.Checked = false;
            chkPedido.Checked = false;
            chkRepetidores.Checked = false;
            chkSwitch.Checked = false;
            chkTrabajo.Checked = false;
            chkWindows.Checked = false;
            rbtAsesorNo.Checked = false;
            rbtAsesorSi.Checked = false;
            rbtMantNo.Checked = false;
            rbtMantSi.Checked = false;
            rbtMeses12.Checked = false;
            rbtMeses24.Checked = false;
            rbtMeses6.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtEuros.Text = "0";
            txtDolares.Text = "0";
            txtCotizacion.Text = "Ingrese sus datos para cotizar";

        }

        private void btnDolares_Click(object sender, EventArgs e)
        {

        }

        private void chkCable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void txtRUC_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtDolares_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
