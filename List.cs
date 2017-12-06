using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;



namespace FinalProjectXamarin
{
    [Activity(Label = "Visited Places")]
    public class myListView : Activity
    {
        List<TableItem> tableItems = new List<TableItem>();
        ListView listView;
        HomeScreenAdapter homeAdapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.List);

            listView = FindViewById<ListView>(Resource.Id.List);

            tableItems.Add(new TableItem() { Heading = "Agra", SubHeading = "BEAUTY OF BEACHES", ImageResourceId = Resource.Drawable.agra.jpg });
            tableItems.Add(new TableItem() { Heading = "Mumbai", SubHeading = "SUNSHINE ON ISLAND", ImageResourceId = Resource.Drawable.mumbai.jpg });
            tableItems.Add(new TableItem() { Heading = "France", SubHeading = "CITY OF HEIGHT", ImageResourceId = Resource.Drawable.france.jpg });
            tableItems.Add(new TableItem() { Heading = "London", SubHeading = "BOLLYWOOD", ImageResourceId = Resource.Drawable.London.jpg });
            tableItems.Add(new TableItem() { Heading = "New York", SubHeading = "CITY OF LOVE", ImageResourceId = Resource.Drawable.NewYork.jpg });
            homeAdapter = new HomeScreenAdapter(this, tableItems);

            listView.Adapter = homeAdapter;
            listView.ItemClick += OnListItemClick;
        }

       
        }
    }
}q