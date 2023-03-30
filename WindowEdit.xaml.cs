using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_PR_BD
{
    /// <summary>
    /// Логика взаимодействия для WindowEdit.xaml
    /// </summary>
    public partial class WindowEdit : Window
    {
        public WindowEdit()
        {
            InitializeComponent();
        }

        SportEntities1 db = SportEntities1.GetContext();

        TennisPlayer p1 = new TennisPlayer();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            p1 = db.TennisPlayer.Find(ClassDannie.fIOSportsman);

            fioSportsman.Text = p1.FIOSportsman;
            nameSportsman.Text = p1.NameSportsman;
            otchSportsman.Text = p1.OtchSportsman;
            genderSportsman.Text = p1.Gender;
            birthday.Text = p1.Birthday.ToString();
            fioTrener.Text = p1.FIOTrener;
            nameTrener.Text = p1.NameTrener;
            otchTrener.Text = p1.OtchTrener;
            country.Text = p1.Country;
            rating2018.Text = p1.Rating2018.ToString();
            rating2019.Text = p1.Rating2019.ToString();
            rating2020.Text = p1.Rating2020.ToString();
            rating2021.Text = p1.Rating2021.ToString();
            rating2022.Text = p1.Rating2022.ToString();
        }

        private void Button_Edit_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (fioSportsman.Text.Length == 0) errors.AppendLine("Введите фамилию спортсмена");
            if (nameSportsman.Text.Length == 0) errors.AppendLine("Введите имя спортсмена");
            //if (otchSportsman.Text.Length == 0) errors.AppendLine("Введите отчество спортсмена");
            if (genderSportsman.Text != "Мужской" && genderSportsman.Text != "Женский")
                errors.AppendLine("Введите пол Мужской/Женский");
            if (birthday.Text.Length == 0) errors.AppendLine("Введите возраст спортсмена");

            if (fioTrener.Text.Length == 0) errors.AppendLine("Введите фамилию тренера");
            if (nameTrener.Text.Length == 0) errors.AppendLine("Введите имя тренера");
            //if (otchTrener.Text.Length == 0) errors.AppendLine("Введите отчество тренера");
            if (country.Text.Length == 0) errors.AppendLine("Введите страну");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (int.TryParse(birthday.Text, out int age) && int.TryParse(rating2018.Text, out int intRating2018) && int.TryParse(rating2019.Text, out int intRating2019) && int.TryParse(rating2020.Text, out int intRating2020) && int.TryParse(rating2021.Text, out int intRating2021) && int.TryParse(rating2022.Text, out int intRating2022))
            {
                p1.FIOSportsman = fioSportsman.Text;
                p1.NameSportsman = nameSportsman.Text;
                p1.OtchSportsman = otchSportsman.Text;
                p1.Birthday = age;
                p1.Gender = genderSportsman.Text;
                p1.FIOTrener = fioTrener.Text;
                p1.NameTrener = nameTrener.Text;
                p1.OtchTrener = otchTrener.Text;
                p1.Country = country.Text;
                p1.Country = country.Text;
                p1.Rating2018 = intRating2018;
                p1.Rating2019 = intRating2019;
                p1.Rating2020 = intRating2020;
                p1.Rating2021 = intRating2021;
                p1.Rating2022 = intRating2022;
            }

            try
            {
                db.SaveChanges();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
    }
}
