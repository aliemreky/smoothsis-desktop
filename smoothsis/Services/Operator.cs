using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smoothsis.Services
{
    class Operator
    {
        private string op_inckey;
        private string adsoyad;
        private string ise_bas_tarih;
        private string op_durumu;

        public Operator(string op_inckey, string adsoyad, string ise_bas_tarih, string op_durumu)
        {
            this.op_inckey = op_inckey;
            this.adsoyad = adsoyad;
            this.ise_bas_tarih = ise_bas_tarih;
            this.op_durumu = op_durumu;
        }

        public override bool Equals(object obj)
        {
            var @operator = obj as Operator;
            return @operator != null && adsoyad == @operator.adsoyad;
        }

        public string getOpInckey()
        {
            return op_inckey;
        }

        public string getAdSoyad()
        {
            return adsoyad;
        }

        public string getIseBasTarih()
        {
            return ise_bas_tarih;
        }

        public string getOpDurumu()
        {
            return op_durumu;
        }
    }
}
