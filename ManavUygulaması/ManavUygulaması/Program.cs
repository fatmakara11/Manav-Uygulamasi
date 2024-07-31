using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _WindowsFormIslemleri_
{
    static class Program
    {
        public static FrmMüşteriEkle FrmSatis
        {
            get => default(FrmMüşteriEkle);
            set
            {
            }
        }
        internal static FrmMüşteriEkle  frmMüsteriEkle
        {
            get => default(FrmMüşteriEkle);
            set
            {
            }
        }

       
        public static FormLogin FormLogin
        {
            get => default(FormLogin);
            set
            {
            }
        }

        public static SifreTazele SifreTazele
        {
            get => default(SifreTazele);
            set
            {
            }
        }

     /*   internal static ürünEkle ürünEkle
        {
            get => default(ürünEkle);
            set
            {
            }
        }

        internal static marka marka
        {
            get => default(marka);
            set
            {
            }
        }

        internal static kategori kategori
        {
            get => default(kategori);
            set
            {
            }
        }

        internal static müsteriListele müsteriListele
        {
            get => default(müsteriListele);
            set
            {
            }
        }

        internal static ürünEkle ürünEkle1
        {
            get => default(ürünEkle);
            set
            {
            }
        }

        internal static ürünlistele ürünlistele
        {
            get => default(ürünlistele);
            set
            {
            }
        }

        internal static satis satis
        {
            get => default(satis);
            set
            {
            }
        }

        internal static satisListele satisListele
        {
            get => default(satisListele);
            set
            {
            }
        } */

        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }

  

  
}
