//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASPMVC_WebNgheNhac.Models.Test
{
    using System;
    using System.Collections.Generic;
    
    public partial class QUYENTRUYCAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QUYENTRUYCAP()
        {
            this.NGUOIDUNGs = new HashSet<NGUOIDUNG>();
        }
    
        public int MaQuyenTruyCap { get; set; }
        public string TenQuyenTruyCap { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGUOIDUNG> NGUOIDUNGs { get; set; }
    }
}