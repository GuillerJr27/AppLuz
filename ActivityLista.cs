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

namespace LuzApp
{
    [Activity(Label = "ActivityLista", MainLauncher = true)]
    public class ActivityLista : Activity
    {
        ListView lista;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_main);
            lista = FindViewById<ListView>(Resource.Id.listView1);
            lista.Adapter = new AdapterMes(this, Global.mes);

            lista.ItemClick += Vlista_ItemClick;
        }

        private void Vlista_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityAnnio));
            Annio anniox = Global.annio[e.Position];
            i.PutExtra("id", anniox.Id);
            StartActivity(i);
        }
    }
}