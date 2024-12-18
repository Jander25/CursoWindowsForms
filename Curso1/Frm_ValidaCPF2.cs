﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curso1
{
    public partial class Frm_ValidaCPF2 : Form
    {
        public Frm_ValidaCPF2()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = "";
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            string vConteudo;
            vConteudo = Msk_CPF.Text;
            vConteudo = vConteudo.Replace(".", "").Replace("-", "");
            vConteudo = vConteudo.Trim();

            if(vConteudo == "") 
            {
                MessageBox.Show("Você deve Colocar um CPF", "Menssagem de Validação!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (vConteudo.Length != 11)
                {
                    MessageBox.Show("CPF Deve contem 11 Digitos ", "Menssagem de Validação!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Você deseja Realmente Validar o CPF?", "Menssagem De Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool validaCPf = false;
                        validaCPf = Cls_Uteis.Valida(Msk_CPF.Text);
                        if (validaCPf == true)
                        {
                            MessageBox.Show("CPF VÁLIDO", "Menssagem de Validação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("CPF INVÁLIDO", "Menssagem de Validação!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

               

                }



            }


        }
    }
}
