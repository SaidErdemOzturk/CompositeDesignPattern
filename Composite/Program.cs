using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Yonetici yonetici = new Yonetici(1,"abc");
            ICalisan calisan1 = new Gelistirici(3,"CGelistirici");
            InsanKaynaklari insankaynaklari = new InsanKaynaklari(2,"insan kaynaklari");
            insankaynaklari.CalisanEkle(calisan1);
            yonetici.BilgiGoster();
            insankaynaklari.BilgiGoster();
            calisan1.BilgiGoster();
        }
    }
    interface ICalisan
    {
        void BilgiGoster();
    }



    class InsanKaynaklari:ICalisan
    {
        public int _id { get; set; }
        public string _isim { get; set; }

        List<ICalisan> list = new List<ICalisan>();

        public void BilgiGoster()
        {
            Console.WriteLine(_id + _isim);
        }
        public InsanKaynaklari(int Id, string Isim)
        {
            _id = Id;
            _isim = Isim;
        }

        public void CalisanEkle(ICalisan calisan)
        {
            list.Add(calisan);
        }
        public void CalisanCikart(ICalisan calisan)
        {
            list.Remove(calisan);
        }
    }
    class Yonetici:ICalisan
    {
        List<ICalisan> list = new List<ICalisan>();
        public int _id { get; set; }
        public string _isim { get; set; }

        ICalisan _calisan;
        public Yonetici(int id,string isim)
        {
            _id = id;
            _isim = isim;
        }

        public void BilgiGoster()
        {
            Console.WriteLine(_id + _isim);
        }
        public void CalisanEkle(ICalisan calisan)
        {
            list.Add(calisan);
        }
        public void CalisanCikart(ICalisan calisan)
        {
            list.Remove(calisan);
        }
    }
    class Tasarimci : ICalisan
    {
        public int _Id { get; set; }
        public string _Isim { get; set; }

        public void BilgiGoster()
        {
            Console.WriteLine(_Id + _Isim);
        }
        public Tasarimci(int Id,string Isim)
        {
            _Id = Id;
            _Isim = Isim;
        }
    }
    class Gelistirici : ICalisan
    {
        public int _Id { get; set; }
        public string _Isim { get; set; }
        public void BilgiGoster()
        {
            Console.WriteLine(_Id+_Isim);
        }
        public Gelistirici(int Id, string Isim)
        {
            _Id = Id;
            _Isim = Isim;
        }
    }

}
