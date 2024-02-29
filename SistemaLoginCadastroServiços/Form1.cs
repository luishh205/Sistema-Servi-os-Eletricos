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
    
    public partial class Form1 : Form
    {
        public string[] dados { get; private set; }

        public Form1()
        {
            InitializeComponent();
            dados = new string[25];
        }
        
        public void LimpaCampos()
        {
            #region limpa campo
            //text fio
            textBoxFio1.Clear();
            textBoxFio2.Clear();
            textBoxFio4.Clear();
            textBoxFio6.Clear();
            textBoxFioOutro.Clear();
            //text placa
            textBoxPlaca1.Clear();
            textBoxPlaca2.Clear();
            textBoxPlaca3.Clear();
            textBoxPlaca6.Clear();
            textBoxPlacaOutro.Clear();
            // modulos
            textBoxT.Clear();
            textBoxS.Clear();
            textBoxP.Clear();
            textBoxOutro.Clear();
            textBoxI.Clear();
            //Dijunntor
            textBox63A.Clear();
            textBoxDijuntorOutro.Clear();
            textBox32A.Clear();
            textBox25A.Clear();
            textBox16A.Clear();
            //Luminarias
            textBoxSobrepor24W.Clear();
            textBoxSobrepor18W.Clear();
            textBoxInbutir24W.Clear();
            textBoxLuminariaOutra.Clear();
            textBoxInbutir18W.Clear();
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        public void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (true)
            {
               
                dados[0] = textBoxFio1.Text;
                dados[1] = textBoxFio2.Text;
                dados[2] = textBoxFio4.Text;
                dados[3] = textBoxFio6.Text;
                dados[4] = textBoxFioOutro.Text;

                dados[5] = textBoxPlaca1.Text;
                dados[6] = textBoxPlaca2.Text;
                dados[7] = textBoxPlaca3.Text;
                dados[8] = textBoxPlaca6.Text;
                dados[9] = textBoxPlacaOutro.Text;

                dados[10] = textBoxT.Text;
                dados[11] = textBoxS.Text;
                dados[12] = textBoxP.Text;
                dados[13] = textBoxOutro.Text;
                dados[14] = textBoxI.Text;

                dados[15] = textBox63A.Text;
                dados[16] = textBoxDijuntorOutro.Text;
                dados[17] = textBox32A.Text;
                dados[18] = textBox25A.Text;
                dados[19] = textBox16A.Text;

                dados[20] = textBoxSobrepor24W.Text;
                dados[21] = textBoxSobrepor18W.Text;
                dados[22] = textBoxInbutir24W.Text;
                dados[23] = textBoxLuminariaOutra.Text;
                dados[24] = textBoxInbutir18W.Text;
            }
          

            LimpaCampos();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //FormExibir Formulario = new FormExibir();
            //Formulario.Show();

            FormExibir formularioExibir = new FormExibir(dados);
            formularioExibir.Show();

        }
      
    }
}
