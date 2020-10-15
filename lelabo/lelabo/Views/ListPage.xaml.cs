using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lelabo.Views
{

    public class Article
    {
        public String Nom { get; set; }
        public String Prix { get; set; }

        public String Description { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {

        List<Article> articles;
        public ListPage()
        {
            InitializeComponent();
            articles = new List<Article>();
            articles.Add(new Article { Nom = "Lait", Prix = "4€" , Description="Pack de lait"});
            articles.Add(new Article { Nom = "Chocolat", Prix = "2.5€" , Description="75% de cacaco"});
            articles.Add(new Article { Nom = "Pain", Prix = "2€", Description= "Plusieurs baguettes"});
            articles.Add(new Article { Nom = "Beurre", Prix = "1.2€", Description = "Demi-sel" });

            maListView.ItemsSource = articles;

            maListView.ItemSelected += (sender, e) =>
            {
                if(maListView.SelectedItem != null)
                {

                    Article article = maListView.SelectedItem as Article;
                    DisplayAlert(article.Nom, article.Description, "Ok");
                    maListView.SelectedItem = null;
                }
            };
        }

    }
}