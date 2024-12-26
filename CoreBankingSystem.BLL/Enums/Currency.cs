using System.ComponentModel.DataAnnotations;

namespace CoreBankingSystem.BLL.Enums
{
    public enum Currency
    {
        [Display(Name = "Kyrgyz Som")]
        KGS = 1,

        [Display(Name = "Russian Ruble")]
        RUB = 2,

        [Display(Name = "United States Dollar")]
        USD = 3,

        [Display(Name = "Euro")]
        EUR = 4,

        [Display(Name = "Pound Sterling")]
        GBP = 5,

        [Display(Name = "Chinese Yuan")]
        CNY = 6,

        [Display(Name = "Japanese Yen")]
        JPY = 7,

        [Display(Name = "Turkish Lira")]
        TRY = 8
    }
}
