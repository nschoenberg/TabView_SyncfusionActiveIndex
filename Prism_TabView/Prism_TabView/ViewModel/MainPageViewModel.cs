using Prism.Commands;
using Prism.Navigation;
using Syncfusion.XForms.TabView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Prism_TabView
{
    public class MainPageViewModel : ViewModelBase, INavigationAware
    {
        public DelegateCommand<object> ItemTappedCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public DelegateCommand<object> ClickedCommand { get; set; }
        public TabItemCollection TabItems
        {
            get;
            set;
        }
       
        INavigationService _navigationService;
        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            GenerateSource();
            ItemTappedCommand = new DelegateCommand<object>(SetContent);
            ClickedCommand = new DelegateCommand<object>(NavigateToPreviousPage);
        }

        public void NavigateToPreviousPage(object obj)
        {
            _navigationService.GoBackAsync();
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public void SetContent(object obj)
        {
            _navigationService.NavigateAsync("Page1");
        }

        #region Fields

        private ObservableCollection<FileManager> imageNodeInfo;

        #endregion

        #region Properties

        public ObservableCollection<FileManager> ImageNodeInfo
        {
            get { return imageNodeInfo; }
            set { this.imageNodeInfo = value; }
        }

        #endregion

        #region Generate Source

        private void GenerateSource()
        {
            var nodeImageInfo = new ObservableCollection<FileManager>();
            Assembly assembly = typeof(MainPage).GetTypeInfo().Assembly;
            var doc = new FileManager() { ItemName = "Documents", ImageIcon = ImageSource.FromResource("Prism_TabView.Icons.treeview_folder.png", assembly) };
            var download = new FileManager() { ItemName = "Downloads", ImageIcon = ImageSource.FromResource("Prism_TabView.Icons.treeview_folder.png", assembly) };
            var mp3 = new FileManager() { ItemName = "Music", ImageIcon = ImageSource.FromResource("Prism_TabView.Icons.treeview_folder.png", assembly) };
            var pictures = new FileManager() { ItemName = "Pictures", ImageIcon = ImageSource.FromResource("Prism_TabView.Icons.treeview_folder.png", assembly) };
            var video = new FileManager() { ItemName = "Videos", ImageIcon = ImageSource.FromResource("Prism_TabView.Icons.treeview_folder.png", assembly) };

            var pollution = new FileManager() { ItemName = "Environmental Pollution.docx", ImageIcon = ImageSource.FromResource("Prism_TabView.Icons.treeview_word.png", assembly) };
            var globalWarming = new FileManager() { ItemName = "Global Warming.ppt", ImageIcon = ImageSource.FromResource("Prism_TabView.Icons.treeview_ppt.png", assembly) };
            var sanitation = new FileManager() { ItemName = "Sanitation.docx", ImageIcon = ImageSource.FromResource("Prism_TabView.Icons.treeview_word.png", assembly) };
            var socialNetwork = new FileManager() { ItemName = "Social Network.pdf", ImageIcon = ImageSource.FromResource("Prism_TabView.Icons.treeview_pdf.png", assembly) };
            var youthEmpower = new FileManager() { ItemName = "Youth Empowerment.pdf", ImageIcon = ImageSource.FromResource("Prism_TabView.Icons.treeview_pdf.png", assembly) };

            var games = new FileManager() { ItemName = "Game.exe", ImageIcon = ImageSource.FromResource("Prism_TabView.Icons.treeview_exe.png", assembly) };
            var tutorials = new FileManager() { ItemName = "Tutorials.zip", ImageIcon = ImageSource.FromResource("Prism_TabView.Icons.treeview_zip.png", assembly) };
            var typeScript = new FileManager() { ItemName = "TypeScript.7z", ImageIcon = ImageSource.FromResource("Prism_TabView.Icons.treeview_zip.png", assembly) };
            var uiGuide = new FileManager() { ItemName = "UI-Guide.pdf", ImageIcon = ImageSource.FromResource("Prism_TabView.Icons.treeview_pdf.png", assembly) };

            var song = new FileManager() { ItemName = "Gouttes", ImageIcon = ImageSource.FromResource("Prism_TabView.Icons.treeview_mp3.png", assembly) };

            var camera = new FileManager() { ItemName = "Camera Roll", ImageIcon = ImageSource.FromResource("Prism_TabView.Icons.treeview_folder.png", assembly) };
            var stone = new FileManager() { ItemName = "Stone.jpg", ImageIcon = ImageSource.FromResource("Prism_TabView.Icons.treeview_png.png", assembly) };
            var wind = new FileManager() { ItemName = "Wind.jpg", ImageIcon = ImageSource.FromResource("Prism_TabView.Icons.treeview_png.png", assembly) };

            var img0 = new FileManager() { ItemName = "WIN_20160726_094117.JPG", ImageIcon = ImageSource.FromResource("Prism_TabView.Icons.treeview_img0.png", assembly) };
            var img1 = new FileManager() { ItemName = "WIN_20160726_094118.JPG", ImageIcon = ImageSource.FromResource("Prism_TabView.Icons.treeview_img1.png", assembly) };

            var video1 = new FileManager() { ItemName = "Naturals.mp4", ImageIcon = ImageSource.FromResource("Prism_TabView.Icons.treeview_video.png", assembly) };
            var video2 = new FileManager() { ItemName = "Wild.mpeg", ImageIcon = ImageSource.FromResource("Prism_TabView.Icons.treeview_video.png", assembly) };

            doc.SubFiles = new ObservableCollection<FileManager>
            {
                pollution,
                globalWarming,
                sanitation,
                socialNetwork,
                youthEmpower
            };

            download.SubFiles = new ObservableCollection<FileManager>
            {
                games,
                tutorials,
                typeScript,
                uiGuide
            };

            mp3.SubFiles = new ObservableCollection<FileManager>
            {
                song
            };

            pictures.SubFiles = new ObservableCollection<FileManager>
            {
                camera,
                stone,
                wind
            };
            camera.SubFiles = new ObservableCollection<FileManager>
            {
                img0,
                img1
            };

            video.SubFiles = new ObservableCollection<FileManager>
            {
                video1,
                video2
            };

            nodeImageInfo.Add(doc);
            nodeImageInfo.Add(download);
            nodeImageInfo.Add(mp3);
            nodeImageInfo.Add(pictures);
            nodeImageInfo.Add(video);
            imageNodeInfo = nodeImageInfo;
        }

        #endregion
    }
}
