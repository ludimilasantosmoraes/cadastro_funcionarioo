using System.Windows.Forms;
using System;

public static class ValidarCpf
{
    public static bool ValidaCPF(string cpf)
    {
        //para tirar os pontos e traçoes do cpf
        cpf = cpf.Replace(".", "");
        cpf = cpf.Replace("-", "");

        if (cpf.Length != 11)
        {
            MessageBox.Show(cpf);
            return false;
        }
        else
        {
            int a = Convert.ToInt32(cpf[0].ToString()) * 10;
            int b = Convert.ToInt32(cpf[1].ToString()) * 9;
            int c = Convert.ToInt32(cpf[2].ToString()) * 8;
            int d = Convert.ToInt32(cpf[3].ToString()) * 7;
            int e = Convert.ToInt32(cpf[4].ToString()) * 6;
            int f = Convert.ToInt32(cpf[5].ToString()) * 5;
            int g = Convert.ToInt32(cpf[6].ToString()) * 4;
            int h = Convert.ToInt32(cpf[7].ToString()) * 3;
            int i = Convert.ToInt32(cpf[8].ToString()) * 2;
            int soma = a + b + c + d + e + f + g + h + i;
            int resto = soma % 11;

            if (resto < 2)
            {
                if (Convert.ToInt32(cpf[9].ToString()) != 0)
                {
                    return false;
                }

            }
            else if (resto >= 2)
            {
                int sub = 11 - resto;
                if (Convert.ToInt32(cpf[9].ToString()) != sub)
                {
                    return false;
                }
            }
            int aa = Convert.ToInt32(cpf[0].ToString()) * 11;
            int bb = Convert.ToInt32(cpf[1].ToString()) * 10;
            int cc = Convert.ToInt32(cpf[2].ToString()) * 9;
            int dd = Convert.ToInt32(cpf[3].ToString()) * 8;
            int ee = Convert.ToInt32(cpf[4].ToString()) * 7;
            int ff = Convert.ToInt32(cpf[5].ToString()) * 6;
            int gg = Convert.ToInt32(cpf[6].ToString()) * 5;
            int hh = Convert.ToInt32(cpf[7].ToString()) * 4;
            int ii = Convert.ToInt32(cpf[8].ToString()) * 3;
            int jj = Convert.ToInt32(cpf[9].ToString()) * 2;
            int soma2 = aa + bb + cc + dd + ee + ff + gg + hh + ii + jj;
            int resto2 = soma2 % 11;
            if (resto2 < 2)
            {
                if (Convert.ToInt32(cpf[10].ToString()) != 0)
                {
                    return false;
                }

            }
            else if (resto2 >= 2)
            {
                int sub = 11 - resto2;
                if (Convert.ToInt32(cpf[10].ToString()) != sub)
                {
                    return false;
                }
            }
            return true;
        }

    }
}