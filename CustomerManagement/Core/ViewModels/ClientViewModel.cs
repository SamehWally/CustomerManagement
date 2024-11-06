using CustomerManagement.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CustomerManagement.Core.ViewModels
{
    public class ClientViewModel
    {
        public int Id { get; set; }
        public int ClientTypeId { get; set; }
        public int ApplicationId { get; set; }
        public string NationalIdentity { get; set; } = null!;
        public bool IsEmployee { get; set; }
        public bool IsOperatingClient { get; set; }
        public bool NoCommissionOnFriday { get; set; }
        public bool BusinessDayCommissionOnly { get; set; }
        public string NameAr { get; set; } = null!;
        public string NameEn { get; set; } = null!;

        public string CustomerTaxNumber { get; set; } // الرقم الضريبي للعميل
        public int ModeratorId { get; set; } // المشرف
        public string AddressAr { get; set; }
        public string AddressEn { get; set; }
        public string PasswordApp { get; set; }
        public string IMEI { get; set; }
        public string PhoneNumberStcPay { get; set; }
        public string CarNumber { get; set; }
        public string CarRental { get; set; } // ايجار السيارة
        public DateTime DateOfReceiptCar { get; set; } // تاريخ استلام السيارة
        public string PhoneNumber { get; set; }
        public string zipCode { get; set; } // الرمز البريدي
        public string Mailbox { get; set; } // صندوق بريد
        public string FaxNumber { get; set; } // رقم الفاكس
        public DateTime IqamaExpirationDate { get; set; } // تاريخ انتهاء الاقامة
        public DateTime LicenseExpirationDate { get; set; } // تاريخ انتهاء الرخصة
        public string Email { get; set; } // البريد الالكتروني
        public int Commission { get; set; } // العمولة
        public int Bonus { get; set; } // البونص
        public bool IsMonthlyCommission { get; set; } // هل يوجد عمولة شهرية
        public string CommissionByValueOrPercentage { get; set; } // العمولة بالقيمة او بالنسبة
        public int CommissionAfterOrderNumber { get; set; } // عمولة بعد الطلب رقم
        public int OrderCommission { get; set; } // عمولة الطلبات
        public bool AllOrders { get; set; } // جميع الطلبات
        public int OpeningBalance { get; set; } // الرصيد الافتتاحي
        public int Creditlimit { get; set; } // الحد الائتماني
        public int NationalityId { get; set; } // الجنسية
        public DateTime StartWorkDate { get; set; } // تاريخ بداية العمل
        public int AccountingDayId { get; set; } // يوم التصفية المحاسبة
        public int CurrencyId { get; set; } // العملة
        public int AreaId { get; set; } // المنطقة الرئيسية
        public int BranchId { get; set; } // الفرع
        public int RegionId { get; set; } // Region Id
        public int ShiftId { get; set; } // Shift Id
        public string BankCode { get; set; } // رمز البنك
        public string IBAN { get; set; } // الآيبان
        public string AccountNumber { get; set; } // رقم الحساب
        public string CostCenter { get; set; } // مركز التكلفة
        public bool IsStop { get; set; } // إيقاف
        public DateTime StopDate { get; set; } // تاريخ التوقف
        public string StopReason { get; set; } // سبب التوقف


        public List<SelectListItem> AccountingDays { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Applications { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Areas { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Branchs { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> ClientTypes { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Currencies { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Moderators { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Nationalities { get; set; } = new List<SelectListItem>();
    }
}
