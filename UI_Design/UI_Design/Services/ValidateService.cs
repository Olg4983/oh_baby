using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UI_Design
{
    class ValidateService
    {
        public static bool VerifyLogin(string email, string pass)
        {
            if (email == string.Empty)
            {
                FormMessage.Show("Введите email!");
                return false;
            }
            else if (!IsValidEmail(email))
            {
                FormMessage.Show("Введите настоящий email!");
                return false;
            }
            else if (pass == string.Empty)
            {
                FormMessage.Show("Введите пароль!");
                return false;
            }
            else
                return true;
        }

        public static bool IsValidEmail(string email)//проверка валидности Email
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);

            return isMatch.Success;
        }

        public static bool VerifyRegister(string firstName, string lastName, string email, string pass, string passCheck)
        {
            if (firstName == string.Empty)
            {
                FormMessage.Show("Введите имя!");
                return false;
            }
            else if (lastName == string.Empty)
            {
                FormMessage.Show("Введите фамилию!");
                return false;
            }
            else if (email == string.Empty)
            {
                FormMessage.Show("Введите email!");
                return false;
            }
            else if (!IsValidEmail(email))
            {
                FormMessage.Show("Введите настоящий email!");
                return false;
            }
            else if (pass == string.Empty)
            {
                FormMessage.Show("Введите пароль!");
                return false;
            }
            else if (pass == string.Empty)
            {
                FormMessage.Show("Введите проверочный пароль!");
                return false;
            }
            else if (passCheck != pass)
            {
                FormMessage.Show("Введенные пароли не совпадают!");
                return false;
            }
            else if (pass.Length < 8 || passCheck.Length < 8)
            {
                FormMessage.Show("Минимальная длина пароля - 8 символов");
                return false;
            }
            else if (pass.Length > 16 || passCheck.Length > 16)
            {
                FormMessage.Show("Максимальная длина пароля - 16 символов");
                return false;
            }
            else
                return true;
        }

        public static bool VerifyAddChild(string firstName, string lastName, string gender)
        {
            if (firstName == string.Empty)
            {
                FormMessage.Show("Введите имя!");
                return false;
            }
            else if (lastName == string.Empty)
            {
                FormMessage.Show("Введите фамилию!");
                return false;
            }
            else if (gender == string.Empty)
            {
                FormMessage.Show("Выберите пол ребенка!");
                return false;
            }
            else
                return true;
        }

        public static bool VerifyAddHealth(string lastName, string firstName, string fatherName, string prof)
        {
            if (lastName == string.Empty)
            {
                FormMessage.Show("Введите фамилию специалиста!");
                return false;
            }
            else if (firstName == string.Empty)
            {
                FormMessage.Show("Введите имя специалиста!");
                return false;
            }
            else if (fatherName == string.Empty)
            {
                FormMessage.Show("Введите отчество специалиста!");
                return false;
            }
            else if (prof == string.Empty)
            {
                FormMessage.Show("Введите проффесию специалиста!");
                return false;
            }
            else
                return true;
        }

        public static bool VerifiyAddDataDiagramm(string month, string growth, string weight)
        {
            if (month.Length > 2)
            {
                FormMessage.Show("Введите возраст ребенка!");
                return false;
            }
            else if (growth == string.Empty)
            {
                FormMessage.Show("Введите рост ребенка!");
                return false;
            }
            else if (weight == string.Empty)
            {
                FormMessage.Show("Введите вес ребенка!");
                return false;
            }
            else
                return true;
        }
    }
}
