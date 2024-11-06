using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;

namespace CustomerManagement.Core.Models
{
    public class Client
    {
        public int Id { get; set; } // رقم المندوب او العميل او المورد 
        [ForeignKey("ClientType")]
        public int ClientTypeId { get; set; } // مميز عميل او مورد
        public ClientType? ClientType { get; set; }
        [ForeignKey("Application")]
        public int ApplicationId { get; set; } // التطبيق
        public Application? Application { get; set; } 
        public string NationalIdentity { get; set; } = null!; // رقم الهوية
        public bool IsEmployee { get; set; } // هل هو موظف؟
        public bool IsOperatingClient { get; set; } // هل هو عميل تشغيل
        public bool NoCommissionOnFriday { get; set; } // لا عمولة يوم الجمعة
        public bool BusinessDayCommissionOnly { get; set; } // تحسب عمولة يوم العمل فقط
        public string NameAr { get; set; } = null!;
        public string NameEn { get; set; } = null!;
        public string CustomerTaxNumber { get; set; } // الرقم الضريبي للعميل
        [ForeignKey("Moderator")]
        public int ModeratorId { get; set; } // المشرف
        public Moderator? Moderator { get; set; } // المشرف
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
        [ForeignKey("Nationality")]
        public int NationalityId { get; set; } // الجنسية
        public Nationality? Nationality { get; set; } // الجنسية
        public DateTime StartWorkDate { get; set; } // تاريخ بداية العمل
        public int AccountingDayId { get; set; } // يوم التصفية المحاسبة
        public AccountingDay? AccountingDay { get; set; } // يوم التصفية المحاسبة
        [ForeignKey("Currency")]
        public int CurrencyId { get; set; } // العملة
        public Currency? Currency { get; set; } // العملة
        [ForeignKey("Area")]
        public int AreaId { get; set; } // المنطقة الرئيسية
        public Area? Area { get; set; } // المنطقة الرئيسية
        [ForeignKey("Branch")]
        public int BranchId { get; set; } // الفرع
        public Branch? Branch { get; set; } // الفرع
        public int RegionId { get; set; } // Region Id
        public int ShiftId { get; set; } // Shift Id
        public string BankCode { get; set; } // رمز البنك
        public string IBAN { get; set; } // الآيبان
        public string AccountNumber { get; set; } // رقم الحساب
        public string CostCenter { get; set; } // مركز التكلفة
        public bool IsStop { get; set; } // إيقاف
        public DateTime StopDate { get; set; } // تاريخ التوقف
        public string StopReason { get; set; } // سبب التوقف
    }
}
