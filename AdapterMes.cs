using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuzApp
{
    class AdapterMes : BaseAdapter
    {

        Activity context;
        List<Mes> lista;

        public AdapterMes(Activity context, List<Mes> lista)
        {
            this.context = context;
            this.lista = lista;
        }

        public override int Count => lista.Count;

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            //El elemento devuelto
            var item = lista[position];


            //definimos el formato de la fila

            View view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem2, null);

            view.FindViewById<TextView>(Android. Resource.Id.Text1).Text = "Promedio_nacional";
            view.FindViewById<TextView>(Android.Resource.Id.Text2).Text = item.Promedio_nacional.ToString();

            return view;

        }
    }
}