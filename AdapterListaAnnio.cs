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
using Java.Lang;

namespace LuzApp
{
    class AdapterDetalleAnnio : BaseAdapter
    {
        Activity Context;
        List<Mes> lista;

        public AdapterDetalleAnnio(Activity context, List<Mes> lista)
        {
            Context = context;
            this.lista = lista;
        }

        public override int Count => lista.Count();

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
            var item = lista[position];
            View view = convertView;
            if (view == null)
                view = Context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);

            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = item.Nombre;

            return view;
        }
    }
}