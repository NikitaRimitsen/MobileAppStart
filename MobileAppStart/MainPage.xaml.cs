using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileAppStart
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            profileImage.Source = ImageSource.FromFile("cat.jpg");
            aboutList.ItemsSource = GetMenuList();
            var homePage = typeof(Views.AboutPage);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
            IsPresented = false;
        }
        public List<MasterMenuItems> GetMenuList()
        {
            var list = new List<MasterMenuItems>();
            list.Add(new MasterMenuItems()
            {
                Text = "Minust",
                Detail = "Lühike info",
                ImagePath = "cat.jpg",
                TargetPage = typeof(Views.AboutPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Minu kogemus",
                Detail = "Natuke rohkem minu kogemisest",
                ImagePath = "cat.jpg",
                TargetPage = typeof(Views.ExperiencePage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Minu oskused",
                Detail = "Natuke rohkem minu kogemisest",
                ImagePath = "cat.jpg",
                TargetPage = typeof(Views.SkillsPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Minu võidud",
                Detail = "Ma olen uhke!!!",
                ImagePath = "cat.jpg",
                TargetPage = typeof(Views.AchievemnetsPage)
            });
            return list;
        }
            private void aboutList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
            {
            var selectedMenuItem = (MasterMenuItems)e.SelectedItem;
            Type selectedPage = selectedMenuItem.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;
            }
    }
}
