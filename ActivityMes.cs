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
    [Activity(Label = "ActivityMes")]
    public class ActivityMes : Activity
    {
        Mes mes;
        ListView vlista;
        TextView text1, text2, text3, text4, text5, text6;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.DetalleMes);

            int id = Intent.GetIntExtra("id", 0);

            mes = Global.mes.Where(x => x.Id == id).FirstOrDefault();

            vlista = FindViewById<ListView>(Resource.Id.listView1);
            text1 = FindViewById<TextView>(Resource.Id.residencial);
            text2 = FindViewById<TextView>(Resource.Id.comercial);
            text3 = FindViewById<TextView>(Resource.Id.industrial);
            text4 = FindViewById<TextView>(Resource.Id.irrigación);
            text5 = FindViewById<TextView>(Resource.Id.bombeo);
            text6 = FindViewById<TextView>(Resource.Id.promedio_nacional);

            text1.Text = mes.Residencial.ToString();
            text2.Text = mes.Comercial.ToString();
            text3.Text = mes.Industrial.ToString();
            text4.Text = mes.Irrigación.ToString();
            text5.Text = mes.Bombeo.ToString();
            text6.Text = mes.Promedio_nacional.ToString();
            vlista = FindViewById<ListView>(Resource.Id.listView1);



        }
    }
}