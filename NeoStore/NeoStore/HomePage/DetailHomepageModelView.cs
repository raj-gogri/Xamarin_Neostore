using System.ComponentModel;

namespace NeoStore.HomePage
{
    internal class DetailHomepageModelView: INotifyPropertyChanged
    {
        string imageUrl;
        public event PropertyChangedEventHandler PropertyChanged;
        public string ImgUrl { get; set; }
        public DetailHomepageModelView()
        {
        }

        
    }
}