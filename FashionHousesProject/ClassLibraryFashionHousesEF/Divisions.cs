//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibraryFashionHousesEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Divisions
    {
        public int DIV_ID { get; set; }
        public int DIV_FH { get; set; }
        public string DIV_NAME { get; set; }
        public string DIV_ADRESS { get; set; }
        public int DIV_QTY { get; set; }
    
        public virtual FashionHouses FashionHouses { get; set; }
    }
}