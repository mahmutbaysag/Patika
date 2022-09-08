using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace atm_uygulamasi
{
    internal class atm
    {
        public Hashtable users;
        public ErrorLogger logger = new ErrorLogger();

        public atm()
        {
            this.users = new Hashtable();
            user u1 = new user("Adamın", "Biri", 500);
            user u2 = new user("Adamın", "Diğeri", 230);
            user u3 = new user("Adamın", "Öbürü", 10000);
            this.users.Add(u1.Identity, u1);
            this.users.Add(u2.Identity, u2);
            this.users.Add(u3.Identity, u3);
        }

        /*
        -Para yatır
        -Para çek
        -Gün Sonu oluştur
        -Gün sonu getir
         */

        public bool ParaYatir(int identity)
        {
            try
            {
                Console.WriteLine("Lütfen Yatırmak İstediğiniz tutarı giriniz: ");
                int miktar = int.Parse(Console.ReadLine());
                this.users[identity] = (int)this.users[identity] + miktar;
                return true;
            }
            catch(Exception err)
            {
                logger.log(err);
                return false;
            }
        }

        public bool ParaCek(int identity)
        {
            try
            {
                Console.WriteLine("Lütfen Çekmek İstediğiniz tutarı giriniz: ");
                int miktar = int.Parse(Console.ReadLine());
                this.users[identity] = (int)this.users[identity] - miktar;
                return true;
            }
            catch (Exception err)
            {
                logger.log(err);
                return false;
            }
        }

        public bool GunSonuOlustur()
        {
            StreamWriter sw = new StreamWriter(@"EOD_" + DateTime.Now.ToString("DDMMYY"));
            foreach(Exception er in logger.logs)
            {
                sw.WriteLine(er.Message);
            }
            sw.Close();
            Console.WriteLine("Gün Sonu Kaydı ALınmıştır: EOD_"+ DateTime.Now.ToString("DDMMYY"));
            return true;
        }

        public bool GunSonuGetir()
        {
            Console.WriteLine("Gün Sonu Kaydı");
            Console.WriteLine("**************");
            StreamReader sr = new StreamReader("EOD_"+ DateTime.Now.ToString("DDMMYY"));
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }
            return true;
        }

        public bool UserVarMi(int identity)
        {
            return this.users.ContainsKey(identity) ? true : false;
        }

    }
}
