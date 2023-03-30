using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
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
    /// Логика взаимодействия для AddRecord.xaml
    /// </summary>
    public partial class AddRecord : Window
    {
        public AddRecord()
        {
            InitializeComponent();
        }

        SportEntities1 db = SportEntities1.GetContext();

        TennisPlayer p1 = new TennisPlayer();

        private void Btn_Click_Add(object sender, RoutedEventArgs e)
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
/*
            if (rating2018.Text.Length == 0) errors.AppendLine("Рейтинг за 2018");
            if (rating2019.Text.Length == 0) errors.AppendLine("Рейтинг за 2019");
            if (rating2020.Text.Length == 0) errors.AppendLine("Рейтинг за 2020");
            if (rating2021.Text.Length == 0) errors.AppendLine("Рейтинг за 2021");
            if (rating2022.Text.Length == 0) errors.AppendLine("Рейтинг за 2022");
*/

/*
            if (TexInn.Text.Length != 12 || double.TryParse(TextInn.Text, out double x) == false)
                errors.AppendLine("Неправильный ИНН");

            if (DatePicker1.Text.Length == 0) errors.AppendLine("Введите дату");*/

            if (errors.Length >0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (int.TryParse(birthday.Text, out int age) && int.TryParse(rating2018Text.Text, out int intRating2018) && int.TryParse(rating2019Text.Text, out int intRating2019) && int.TryParse(rating2020Text.Text, out int intRating2020) && int.TryParse(rating2021Text.Text, out int intRating2021) && int.TryParse(rating2022Text.Text, out int intRating2022))
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
                p1.Rating2018 = intRating2018;
                p1.Rating2019 = intRating2019;
                p1.Rating2020 = intRating2020;
                p1.Rating2021 = intRating2021;
                p1.Rating2022 = intRating2022;
            }
            try
            {
                db.TennisPlayer.Add(p1);

                db.SaveChanges();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}