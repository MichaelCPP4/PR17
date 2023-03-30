using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_PR_BD
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        //SportEntities1 db = new SportEntities1();
        SportEntities1 db = SportEntities1.GetContext();
        List<TennisPlayer> _TennisPlayer;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        { 
            db.TennisPlayer.Load();
            DataGrid1.ItemsSource = db.TennisPlayer.Local.ToBindingList();
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            AddRecord f = new AddRecord();
            f.ShowDialog();
            DataGrid1.Focus();
        }

        private void Button_Edit(object sender, RoutedEventArgs e)
        {
            int indexRow = DataGrid1.SelectedIndex;
            if (indexRow != -1)
            {
                TennisPlayer row = (TennisPlayer)DataGrid1.Items[indexRow];
                ClassDannie.fIOSportsman = row.FIOSportsman;

                WindowEdit f = new WindowEdit();
                f.ShowDialog();
                //DataGrid1.SourceUpdated();
                DataGrid1.Items.Refresh();
                DataGrid1.Focus();
            }
        }

        private void Button_Forma2(object sender, RoutedEventArgs e)
        {
            WindowEdit f = new WindowEdit();
            f.ShowDialog();
            DataGrid1.Focus();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("Удалить запись?", "Удаление записи.", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    TennisPlayer row = (TennisPlayer)DataGrid1.SelectedItems[0];

                    db.TennisPlayer.Remove(row);
                    db.SaveChanges();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Выберите запись");
                }
            }
        }

        private void Find_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < DataGrid1.Items.Count; i++)
            {
                var row = (TennisPlayer)DataGrid1.Items[i];
                string findContent = row.FIOSportsman;
                try
                {
                    if (findContent != null && findContent.Contains(txtFind.Text))
                    {
                        object item = DataGrid1.Items[i];
                        DataGrid1.SelectedItem = item;
                        DataGrid1.ScrollIntoView(item);
                        DataGrid1.Focus();
                        break;
                    }
                }
                catch {}
            }
        }

        private void Filtered_Click(object sender, RoutedEventArgs e)
        {
            if (txtFiltered.Text != String.Empty)
            {
                _TennisPlayer = db.TennisPlayer.ToList();

                var filtered = _TennisPlayer.Where(p => p.FIOSportsman == txtFiltered.Text);

                DataGrid1.ItemsSource = filtered;
            }
            else
            {
                DataGrid1.ItemsSource = db.TennisPlayer.Local.ToBindingList();
            }
        }
    }
}
