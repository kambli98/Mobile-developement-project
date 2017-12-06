using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace FinalProjectXamarin
{
    [Activity(Label = "Blog")]
    public class BlogAuthorDescription : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.BlogPage);


            Button showPopupMenu = FindViewById<Button>(Resource.Id.button1);

            showPopupMenu.Click += delegate {


                PopupMenu menu = new PopupMenu(this, showPopupMenu);
                menu.Inflate(Resource.Menu.popup_menu);

                menu.MenuItemClick += (s1, e1) =>
                {
                    switch (e1.Item.TitleFormatted.ToString())
                    {
                        case "Places Visited":
                            StartActivity(typeof(List));
                            break;
                        case "Destination to be Visited":
                            StartActivity(typeof(List2));
                            break;
                        case "Contact Us":
                            StartActivity(typeof(contact));
                            break;
                    }
                };
                menu.Show();


            };
        }
    }
}