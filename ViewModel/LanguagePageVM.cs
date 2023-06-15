using HyunApp.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HyunApp.ViewModel
{
    public class LanguageTable
    {
        public string Name { get; set; } = "";

        public int Id { get; set; }

        public bool Active { get; set; }


    }


    public class LanguagePageVM: ViewModel.ViewModelClass
    {

        #region Lists
        private ObservableCollection<LanguageTable> langlist = new ObservableCollection<LanguageTable>();
        public ObservableCollection<LanguageTable> LanguagesList
        {
            get
            {

                return langlist;

            }
            set
            {
                langlist = value;
                OnPropertyChanged(nameof(LanguagesList));
            }

        }
        #endregion

        #region Command
        public ICommand ChangeLangaugeCommand { get; set; }
        private void ChangeLangaugeVoid(object parameter)
        {

            AppAccessGuide.Instance.Resources.MergedDictionaries.Clear();

            ResourceDictionary SelectedLanguage = new ResourceDictionary();
          

            var langauge = (LanguageTable)parameter;

            switch (langauge.Name)
            {
                case "한국어(Korean)":

                    SelectedLanguage.Source = new Uri("/HyunApp;component/Language/KoLanguage.xaml", UriKind.RelativeOrAbsolute);
                    AppAccessGuide.Instance.Resources.MergedDictionaries.Add(SelectedLanguage);
                    break;
                case "영어(english)":

                    SelectedLanguage.Source = new Uri("/HyunApp;component/Language/EnLanguage.xaml", UriKind.RelativeOrAbsolute);
                    AppAccessGuide.Instance.Resources.MergedDictionaries.Add(SelectedLanguage);
                    break;
                case "일본어(日本語)":

                    SelectedLanguage.Source = new Uri("/HyunApp;component/Language/JapanLanguage.xaml", UriKind.RelativeOrAbsolute);
                    AppAccessGuide.Instance.Resources.MergedDictionaries.Add(SelectedLanguage);
                    break;
                case "중국어(中文)":

                    SelectedLanguage.Source = new Uri("/HyunApp;component/Language/ChineseLanguage.xaml", UriKind.RelativeOrAbsolute);
                    AppAccessGuide.Instance.Resources.MergedDictionaries.Add(SelectedLanguage);
                    break;

            }


           

        }


        public ICommand NextPageCommand { get; set; }
        private void NextPageVoid(object parameter)
        {

            AppAccessGuide.Instance.MainGrid.Children.Add(new Pages.AppAccessPermissionInformation());

        }


        #endregion

        public LanguagePageVM()
        {
            #region Commands


            ChangeLangaugeCommand = new RelayCommand(ChangeLangaugeVoid);
            NextPageCommand = new RelayCommand(NextPageVoid);


            #endregion

            #region Lists

            LanguagesList.Add(new LanguageTable { Id = 1, Name = "한국어(Korean)" ,Active=false});
            LanguagesList.Add(new LanguageTable { Id = 2, Name = "영어(english)", Active = true });
            LanguagesList.Add(new LanguageTable { Id = 3, Name = "일본어(日本語)", Active = false });
            LanguagesList.Add(new LanguageTable { Id = 4, Name = "중국어(中文)", Active = false });
            LanguagesList.Add(new LanguageTable { Id = 5, Name = "중국어(中文)", Active = false });
            LanguagesList.Add(new LanguageTable { Id = 6, Name = "중국어(中文)" , Active = false });
            LanguagesList.Add(new LanguageTable { Id = 7, Name = "중국어(中文)" , Active = false });
            LanguagesList.Add(new LanguageTable { Id = 8, Name = "중국어(中文)" , Active = false });



            #endregion

        }

    }
}
