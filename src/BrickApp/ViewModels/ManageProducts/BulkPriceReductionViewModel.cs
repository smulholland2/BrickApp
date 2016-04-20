using System.ComponentModel.DataAnnotations;

namespace BrickApp.ViewModels.ManageProducts
{
    public class BulkPriceReductionViewModel
    {
        [Display(Prompt = "Category")]
        public int CategoryId { get; set; }

        [Display(Prompt = "Percentage off MSRP")]
        public int PercentageOffMSRP { get; set; }
    }
}
