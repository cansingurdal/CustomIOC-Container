using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Ioc_Example.Models
{
    public class BildirimManagerCreator
    {

        //public static BildirimManager Create()
        //{
        //    return new BildirimManager(new MesajGonder());
        //}
    }
    public class BildirimManager
    {
        private IBildirim _bildirim;
        public BildirimManager(IBildirim bildirim)
        {
            this._bildirim = bildirim;
        }

        public void BildirimYap()
        {
            _bildirim.Gonder();
        }
    }

    public interface IBildirim
    {
        void Gonder();
    }
    public class EPostaGonder: IBildirim
    {
        public void Gonder()
        {
            Debug.WriteLine("EPosta Gonderildi");
        }
    }
    public class MesajGonder: IBildirim
    {
        public void Gonder()
        {
            Debug.WriteLine("Mesaj Gonderildi");
        }
    }
}