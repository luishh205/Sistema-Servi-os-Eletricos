using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class FormExibir : Form
    {
        public FormExibir()
        {
            InitializeComponent();
        }
        private string[] dadosRecebidos;

        // Construtor que recebe os dados como argumento
        public FormExibir(string[] dados)
        {
            InitializeComponent();
          
            dadosRecebidos = dados;
            //Fios
            labelFio1.Text = dados[0];
            labelFio2.Text = dados[1];
            labelFio4.Text = dados[2];
            labelFio6.Text = dados[3];
            labelFioOutro.Text = dados[4];
            //Placa
            labelPlaca1.Text = dados[5];
            labelPlaca2.Text = dados[6];
            labelPlaca3.Text = dados[7];
            labelPlaca6.Text = dados[8];
            labelPlaccaOutro.Text = dados[9];
            //Modulos
            labelTomada.Text = dados[10];
            labelSimples.Text = dados[11];
            labelParalelo.Text = dados[12];
            labelModuloOutro.Text = dados[13];
            labelIntermediario.Text = dados[14];
            //dijuntor
            label63A.Text = dados[15];
            labelDijuntorOutro.Text = dados[16];
            label32A.Text = dados[17];
            label25A.Text = dados[18];
            label16A.Text = dados[19];
            //luminarias
            label24S.Text = dados[20];
            label18WS.Text = dados[21];
            label24L.Text = dados[22];
            labelLuminariaOutra.Text = dados[23];
            label18L.Text = dados[24];
            
        }

    }
}
