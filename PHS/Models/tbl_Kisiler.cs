//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PHS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Kisiler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Kisiler()
        {
            this.tbl_Hastaliklar = new HashSet<tbl_Hastaliklar>();
            this.tbl_Randevular = new HashSet<tbl_Randevular>();
            this.tbl_Recete = new HashSet<tbl_Recete>();
        }
    
        public int kisi_id { get; set; }
        public string kisi_isimSoyisim { get; set; }
        public string kisi_telefon { get; set; }
        public string kisi_eposta { get; set; }
        public string kisi_sifre { get; set; }
        public string kisi_adresSatiri1 { get; set; }
        public string kisi_adresSatiri2 { get; set; }
        public Nullable<int> kisi_postaKodu { get; set; }
        public string kisi_il { get; set; }
        public string kisi_acilTelNo { get; set; }
        public byte kisi_boy { get; set; }
        public short kisi_kilo { get; set; }
        public System.DateTime kisi_dogumTarihi { get; set; }
        public bool kisi_cinsiyet { get; set; }
        public bool kisi_isAktiv { get; set; }
        public bool kisi_isHamile { get; set; }
        public string kisi_meslek { get; set; }
        public Nullable<bool> isOnay { get; set; }
        public string kisi_kod1 { get; set; }
        public string kisi_kod2 { get; set; }
        public string kisi_profilResim { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Hastaliklar> tbl_Hastaliklar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Randevular> tbl_Randevular { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Recete> tbl_Recete { get; set; }
    }
}
