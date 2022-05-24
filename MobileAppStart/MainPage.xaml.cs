using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileAppStart
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            profileImage.Source = ImageSource.FromFile("cat.jpg");
            aboutList.ItemSource = GetMenuList();
            var homePage = typeof(Views.AboutPage);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
            IsPresented = false;
        }
        public List<MasterMenuItems> GetMenuList()
        {
            var list = new List<MasterMenuItems>();
            list.Add(new MasterMenuItems()
            {
                TextAlignment = "Minust",
                Detail = "Lühike info",
                ImagePath = "cat.jpg",
                TargetPage = typeof(View.AboutPage)
            });
            list.Add(new MasterMenuItems()
            {
                TextAlignment = "Minu kogemus",
                Detail = "Natuke rohkem minu kogemisest",
                ImagePath = "cat.jpg",
                TargetPage = typeof(View.ExperiencePage)
            });
            list.Add(new MasterMenuItems()
            {
                TextAlignment = "Minu oskused",
                Detail = "Natuke rohkem minu kogemisest",
                ImagePath = "cat.jpg",
                TargetPage = typeof(View.SkiilsPage)
            });
            list.Add(new MasterMenuItems()
            {
                TextAlignment = "Minu võidud",
                Detail = "Ma olen uhke!!!",
                ImagePath = "cat.jpg",
                TargetPage = typeof(View.AchievemnetsPage)
            });
            return list;

            private void aboutList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}
