

namespace Oksman_Cooking
{
    using System;
    using System.Collections.Generic;

    public partial class Receipt
    {
        public int ReceiptID { get; set; }
        public string RecTitle { get; set; }
        public string RecDescription { get; set; }
        public string RecIngredients { get; set; }
        public int CategoryID { get; set; }
    }
}
