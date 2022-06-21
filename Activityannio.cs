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
    [Activity(Label = "Activityannio")]
    public class Activityannio : Activity
    {
        Mes mes;

        ListView vlista;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.AnnioDetalle);
            int id = Intent.GetIntExtra("id", 0);

            mes = Global.mes.Where(x => x.Id == id).FirstOrDefault();


            vlista = FindViewById<ListView>(Resource.Id.listView1);

            vlista.Adapter = new AdapterDetalleAnnio(this, Global.mes.Where(x => x.Idannio == mes.Id).ToList());


            vlista.ItemClick += Vlista_ItemClick;
        }

        private void Vlista_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityMes));
            Mes mesx = Global.mes[e.Position];
            i.PutExtra("id", mesx.Id);
            StartActivity(i);
        }
    }
}