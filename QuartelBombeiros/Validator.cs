using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartelBombeiros
{
    class Validator
    {
        public static bool isName(String nome)
        {
            char[] unallowedChars = { '!', '"', '#', '$', '%', '&', '/', '(', ')', '=', '?', '\'', '\\', '«', '»', '@', '£', '§', '{', '[', ']', '}', '€', '+', '´', 'º', '~', '*', '`', 'ª', '^', '¨', ',', '.', '-', ';', ':', '_', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for (int i = 0; i < unallowedChars.Length; i++)
                if (nome.Contains(unallowedChars[i]))
                    return false;

            return true;
        }

        public static bool hasSpecialChars(String campo)
        {
            char[] unallowedChars = { '!', '"', '#', '$', '%', '&', '/', '(', ')', '=', '?', '\'', '\\', '«', '»', '@', '£', '§', '{', '[', ']', '}', '€', '+', '´', 'º', '~', '*', '`', 'ª', '^', '¨', ',', '.', '-', ';', ':' };

            for (int i = 0; i < unallowedChars.Length; i++)
                if (campo.Contains(unallowedChars[i]))
                    return true;


            return false;
        }

        public static bool isNumeric(String num)
        {
            if (num == "")
                return true;
            int numero;
            if (Int32.TryParse(num, out numero))
            {
                return true;
            }
            return false;
        }

        public static bool isNumeric(String num, int i)
        {
            long j;
            if (long.TryParse(num, out j))
                return true;
            return false;
        }

        public static bool isPostCode(String codPos)
        {
            if (codPos.Length != 8)
                return false;

            if (codPos[4] != '-')
                return false;
            String aux = "";
            for (int i = 0; i < codPos.Length; i++)
            {
                aux = aux + codPos[i];
                if (i == 3)
                    i++;
            }
            return isNumeric(aux);
        }


        public static bool isEmail(String email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool isNIF(String NIF)
        {
            if (NIF.Length != 9)
                return false;

            if (!isNumeric(NIF))
                return false;

            if (NIF[0] == '0' || NIF[0] == '3' || NIF[0] == '4')
                return false;

            int[] aux = new int[9];
            for (int i = 0; i < NIF.Length; i++)
                aux[i] = NIF[i] - '0';

            int control = 0;
            for (int i = 1; i < NIF.Length; i++)
                control += ((10 - i) * aux[i - 1]);

            control = (11 - (control % 11));
            if (control >= 10)
                control = 0;

            return control == aux[8];

        }

        public static bool isBI(String BI)
        {
            if (BI.Length != 9)
                return false;

            if (!isNumeric(BI))
                return false;

            if (BI[0] == '0')
                return false;

            int[] aux = new int[9];
            for (int i = 0; i < BI.Length; i++)
                aux[i] = BI[i] - '0';

            int control = 0;
            for (int i = 1; i <= BI.Length; i++)
                control += ((10 - i) * aux[i - 1]);

            control = control % 11;

            return control == 0;
        }

        public static bool hasAge(String data)
        {
            try
            {
                DateTime d = DateTime.Parse(data);
                if (d <= DateTime.Now.AddYears(-18))
                    return false;
                return true;
            }
            catch
            {
                return false;
            }


        }

        public static bool isHora(String hora)
        {
            if(hora == "")
            {
                return true;
            }
            DateTime numero;
            if (DateTime.TryParse(hora, out numero))
            {
                return true;
            }
            return false;
        }

        public static bool isMatricula(String mat)
        {
            if (mat == "")
                return false;

            String[] aux = mat.Split('-');
            if (aux.Length==3) { 
                if (Validator.isNumeric(aux[0]) && Validator.isNumeric(aux[1]) && !Validator.isNumeric(aux[2][0].ToString()) && !Validator.isNumeric(aux[2][1].ToString()))
                    if (!Validator.hasSpecialChars(aux[2]))
                        return true;
                if (Validator.isNumeric(aux[1]) && Validator.isNumeric(aux[2]) && !Validator.isNumeric(aux[0][0].ToString()) && !Validator.isNumeric(aux[0][1].ToString()))
                    if (!Validator.hasSpecialChars(aux[0]))
                        return true;
                if (Validator.isNumeric(aux[2]) && Validator.isNumeric(aux[0]) && !Validator.isNumeric(aux[1][0].ToString()) && !Validator.isNumeric(aux[1][1].ToString()))
                    if (!Validator.hasSpecialChars(aux[1]))
                        return true;
            }
                return false;
           
        }


    }



}
