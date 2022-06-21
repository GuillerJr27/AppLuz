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

    class Global
    {
        public static List<Annio> annio = new List<Annio>()
        {
                new Annio (1,2017),
                new Annio (2,2018),
                new Annio (3,2019)
        };

        public static List<Mes> mes = new List<Mes> ()
         {
            new Mes (1,"Enero",5.4689  , 7.3467 , 5.6149 , 4.6162 , 5.1395 , 5.8914, 1),
            new Mes (2,"Febrero",5.3702, 7.444  , 5.7489 , 4.6052 , 5.1735,  5.9424, 1),
            new Mes (3,"Marzo",5.6805 ,  7.3991 , 5.6225 , 4.6553 , 5.0936 , 6.0138, 1),
            new Mes (4,"Abril",5.813  ,  7.4641 , 5.7661 , 4.7327 , 5.1287 , 6.1507, 1),
            new Mes (5,"Mayo",5.9153   , 7.4952 , 5.7098 , 5.0656 , 5.1585 , 6.2299, 1),
            new Mes (6,"Junio",5.888   , 7.5736 , 5.7314 , 5.0379 , 5.3221 , 6.2652, 1),
            new Mes (7,"Julio",5.936   , 7.6062 , 5.735  , 4.8393 , 5.2929 , 6.2508, 1),
            new Mes (8,"Agosto",5.9884 , 7.654  , 5.741  , 4.8762 , 5.3017 , 6.2901, 1),
            new Mes (9,"Septiembre",5.9871 , 7.7084 , 5.82 ,   4.9767 , 5.031,  6.3561, 1),
            new Mes (10,"Octubre",5.9751   , 7.7273 , 5.8143 , 5.2714 , 5.3809 , 6.3496, 1),
            new Mes (11,"Noviembre",6.0178 , 7.7189 , 5.8368 , 5.2138  ,5.4145 , 6.3742, 1),
            new Mes (12,"Diciembre",6.0399 , 7.8677,  6.0523 , 5.0057 , 5.391  , 6.4048, 1),



            new Mes (1,"Enero",6.0211  , 7.8719 , 6.0515 , 4.9616 , 5.381  , 6.3656, 2),
            new Mes (2,"Febrero",5.88  , 7.9868 , 6.1339 , 4.9623 , 5.4876 , 6.3938, 2),
            new Mes (3,"Marzo",6.0705  , 7.9683 , 6.0609  ,4.9586 , 5.4045 , 6.4323, 2),
            new Mes (4,"Abril",6.1875  , 7.9802 , 6.1409 , 5.049  , 5.443  , 6.5404, 2),
            new Mes (5,"Mayo",6.2977  ,  8.0462 , 6.2442 , 5.2938 , 5.4699 , 6.6613, 2),
            new Mes (6,"Junio",6.1541  , 8.0256 , 6.2338 , 5.2546 , 5.5396 , 6.5927, 2),
            new Mes (7,"Julio",6.1744 ,  8.0291 , 6.0332 , 5.0135 , 5.5182 , 6.4851, 2),
            new Mes (8,"Agosto",6.2249 , 7.997  , 6.0597 , 5.0737 , 5.5297 , 6.5024, 2),
            new Mes (9,"Septiembre",6.1825 , 8.1166 , 6.1405,  5.015  , 5.5895 , 6.5855, 2),
            new Mes (10,"Octubre",6.1932   , 8.1171 , 6.1139 , 5.3051 , 5.6079 , 6.5871, 2),
            new Mes (11,"Noviembre",6.1803 , 8.126  , 6.1486 , 5.0386 , 5.6215 , 6.5981, 2),
            new Mes (12,"Diciembre",6.2806 , 8.1351 , 6.3592 , 5.0763 , 5.6064 , 6.6326, 2),


            new Mes (1,"Enero",6.3758  , 8.3673 , 6.4578 , 5.2443 , 6.6818 , 6.5001, 3),
            new Mes (2,"Febrero",6.3295, 8.6228 , 6.539  , 5.2687 , 6.7457 , 6.5963, 3),
            new Mes (3,"Marzo",6.602   , 8.5686 , 6.4329 , 5.3464 , 6.7359 , 6.7055, 3),
            new Mes (4,"Abril",6.6481 ,  8.8591 , 6.6848 , 5.5181 , 6.8617 , 6.8703, 3),
            new Mes (5,"Mayo",6.9263    ,8.8587 , 6.596  , 5.743  , 7.0232 , 7.0302, 3),
            new Mes (6,"Junio",6.8164  , 8.9162 , 6.572  , 5.6983  ,7.1481 , 7.0414, 3),
            new Mes (7,"Julio",7.0131 ,  9.0255 , 6.65   , 5.5646  ,7.217  , 7.0893, 3),
            new Mes (8,"Agosto",7.0976 , 9.0734 , 6.6401 , 5.6911 , 7.2868 , 7.1412, 3),
            new Mes (9,"Septiembre",7.1582 , 9.312  , 6.8295 , 5.7918 , 7.3978 , 7.2991, 3),
            new Mes (10,"Octubre",7.2155  ,  9.3536  ,6.8523 , 6.1842 , 7.4592 , 7.3426, 3),
            new Mes (11,"Noviembre",7.2353 , 9.4794 , 6.9382,  6.0893 , 7.5678 , 7.337, 3),
            new Mes (12,"Diciembre",7.3931 , 9.7275 , 7.2773 , 6.0396  ,7.6627 , 7.4626, 3),





         };
         
    }


        public class Annio
        {
            int id;
            int a;

        public Annio(int id, int a)
        {
            this.Id = id;
            this.A = a;
        }

        public int Id { get => id; set => id = value; }
        public int A { get => a; set => a = value; }

    }
    public class Mes
    {
        int id;
        string nombre;
        double residencial;
        double comercial;
        double industrial;
        double irrigación;
        double bombeo;
        double promedio_nacional;
        int idannio;

        public Mes(int id, string nombre, double residencial, double comercial, double industrial, double irrigación, double bombeo, double promedio_nacional, int idannio)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Residencial = residencial;
            this.Comercial = comercial;
            this.Industrial = industrial;
            this.Irrigación = irrigación;
            this.Bombeo = bombeo;
            this.Promedio_nacional = promedio_nacional;
            this.Idannio = idannio;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Residencial { get => residencial; set => residencial = value; }
        public double Comercial { get => comercial; set => comercial = value; }
        public double Industrial { get => industrial; set => industrial = value; }
        public double Irrigación { get => irrigación; set => irrigación = value; }
        public double Bombeo { get => bombeo; set => bombeo = value; }
        public double Promedio_nacional { get => promedio_nacional; set => promedio_nacional = value; }
        public int Idannio { get => idannio; set => idannio = value; }
    }

}