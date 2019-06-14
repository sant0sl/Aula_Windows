using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class Validador
    {
        //VALIDADOR DE CPF - if (Validador.IsCpf(txtCPF.Text)) > true, senão false
        public static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
        public static void verificarCPFForms(TextBox CPFTextBox, TextBox nextTextBox)
        {
            if (Validador.IsCpf(CPFTextBox.Text))
            {
                nextTextBox.Focus();
            }
            else if (CPFTextBox.Text.Equals(""))
            {
                nextTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Este CPF não é válido! Por favor, insira um válido.");
                CPFTextBox.Text = string.Empty;
                CPFTextBox.Focus();
            }
        }

        //VALIDADOR DE CNPJ - if (Validador.IsCnpj(txtCNPJ.Text)) > true, senão false
        public static bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }
        public static void verificarCNPJForms(TextBox CNPJTextBox, TextBox nextTextBox)
        {
            if (Validador.IsCnpj(CNPJTextBox.Text))
            {
                nextTextBox.Focus();
            }
            else if (CNPJTextBox.Text.Equals(""))
            {
                nextTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Este CNPJ não é válido! Por favor, insira um válido.");
                CNPJTextBox.Text = string.Empty;
                CNPJTextBox.Focus();
            }
        }

        //VALIDADOR DE E-MAIL - if (Validador.IsEmail(txtEmail.Text)) > true, senão false
        public static bool IsEmail(string strEmail)
        {
            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(strEmail, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void verificarEmailForms(TextBox EmailTextBox, TextBox nextTextBox)
        {
            if (Validador.IsEmail(EmailTextBox.Text))
            {
                nextTextBox.Focus();
            }
            else if (EmailTextBox.Text.Equals(""))
            {
                nextTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Este E-mail não é válido! Por favor, insira um válido.");
                EmailTextBox.Text = string.Empty;
                EmailTextBox.Focus();
            }
        }

        //VALIDADOR DE CEP - if (Validador.IsCep(txtCEP.Text)) > true, senão false
        public static bool IsCep(string cep)
        {
            if (cep.Length == 8)
            {
                cep = cep.Substring(0, 5) + "-" + cep.Substring(5, 3);
            }
            return System.Text.RegularExpressions.Regex.IsMatch(cep, ("[0-9]{5}-[0-9]{3}"));
        }
        public static void verificarCEPForms(TextBox CEPTextBox, TextBox nextTextBox)
        {
            if (Validador.IsCep(CEPTextBox.Text))
            {
                nextTextBox.Focus();
            }
            else if (CEPTextBox.Text.Equals(""))
            {
                nextTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Este CEP não é válido! Por favor, insira um válido.");
                CEPTextBox.Text = string.Empty;
                CEPTextBox.Focus();
            }
        }


    }
}
