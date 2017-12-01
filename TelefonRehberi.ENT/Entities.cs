using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi.ENT
{
    public class Entities
    {
        public partial class Calisanlar
        {
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            public Calisanlar()
            {
                this.Calisanlar1 = new HashSet<Calisanlar>();
                this.Kullanicilar = new HashSet<Kullanicilar>();
            }

            public int CalisanId { get; set; }
            public string CalisanAd { get; set; }
            public string CalisanSoyad { get; set; }
            public string CalisanTelefon { get; set; }
            public int DepartmanId { get; set; }
            public Nullable<int> YöneticiId { get; set; }

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<Calisanlar> Calisanlar1 { get; set; }
            public virtual Calisanlar Calisanlar2 { get; set; }
            public virtual Departman Departman { get; set; }
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<Kullanicilar> Kullanicilar { get; set; }
        }
        public partial class Departman
        {
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            public Departman()
            {
                this.Calisanlar = new HashSet<Calisanlar>();
            }

            public int DepartmanId { get; set; }
            public string DepartmanAd { get; set; }

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<Calisanlar> Calisanlar { get; set; }
        }
        public partial class Kullanicilar
        {
            public string UserId { get; set; }
            public int CalisanId { get; set; }
            public int RolId { get; set; }
            public string Sifre { get; set; }

            public virtual Calisanlar Calisanlar { get; set; }
            public virtual Roller Roller { get; set; }
        }
        public partial class Roller
        {
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            public Roller()
            {
                this.Kullanicilar = new HashSet<Kullanicilar>();
            }

            public int RolId { get; set; }
            public string RolAd { get; set; }

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<Kullanicilar> Kullanicilar { get; set; }
        }


    }
}
