using CustomerManagement.Core.Models;
using CustomerManagement.Core.ViewModels;
using CustomerManagement.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace CustomerManagement.Controllers
{
	public class ClientsController : Controller
	{
        private readonly ApplicationDbContext _context;

        public ClientsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
		{
            var clients = _context.Clients
                .Include(x => x.ClientType)
                .Include(x => x.Application)
                .ToList();
			return View(clients);
		}
		[HttpGet]
		public IActionResult Create() 
		{
            var accountingDays = _context.AccountingDays.Select(x => new SelectListItem()
            {
                Value = x.Id.ToString(),
                Text = x.Name
            }).ToList();

            var applications = _context.Applications.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            }).ToList();    

            var areas = _context.Areas.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            }).ToList();    

            var branchs = _context.Branchs.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            }).ToList();
            
            var clientTypes = _context.ClientTypes.Select(x => new SelectListItem()
            {
                Value = x.Id.ToString(),
                Text = x.Name
            }).ToList();   

            var currencies = _context.Currencies.Select(x => new SelectListItem()
            {
                Value = x.Id.ToString(),
                Text = x.Name
            }).ToList();     

            var moderators = _context.Moderators.Select(x => new SelectListItem()
            {
                Value = x.Id.ToString(),
                Text = x.Name
            }).ToList();     

            var nationalities = _context.Nationalities.Select(x => new SelectListItem()
            {
                Value = x.Id.ToString(),
                Text = x.Name
            }).ToList();


            var viewModel = new ClientViewModel
            {
                AccountingDays = accountingDays,
                Applications = applications,
                Areas = areas,
                Branchs = branchs,
                ClientTypes = clientTypes,
                Currencies = currencies,
                Moderators = moderators,
                Nationalities = nationalities
            };

            return View(viewModel);
        }
		[HttpPost]
		public IActionResult Create(ClientViewModel model) 
		{
            if (model.Commission <= 201)
                model.Bonus = 5;
            else if (model.Commission > 201)
                model.Bonus = 10;

            var client = new Client
            {
                ClientTypeId = model.ClientTypeId,
                ApplicationId = model.ApplicationId,
                NationalIdentity = model.NationalIdentity,
                IsEmployee = model.IsEmployee,
                IsOperatingClient = model.IsOperatingClient,
                NoCommissionOnFriday = model.NoCommissionOnFriday,
                BusinessDayCommissionOnly = model.BusinessDayCommissionOnly,
                NameAr = model.NameAr,
                NameEn = model.NameEn,
                CustomerTaxNumber = model.CustomerTaxNumber,
                ModeratorId = model.ModeratorId,
                AddressAr = model.AddressAr,
                AddressEn = model.AddressEn,
                PasswordApp = model.PasswordApp,
                IMEI = model.IMEI,
                PhoneNumberStcPay = model.PhoneNumberStcPay,
                CarNumber = model.CarNumber,
                CarRental = model.CarRental,
                DateOfReceiptCar = model.DateOfReceiptCar,
                PhoneNumber = model.PhoneNumber,
                zipCode = model.zipCode,
                Mailbox = model.Mailbox,
                FaxNumber = model.FaxNumber,
                IqamaExpirationDate = model.IqamaExpirationDate,
                LicenseExpirationDate = model.LicenseExpirationDate,
                Email = model.Email,        
                Commission = model.Commission,
                Bonus = model.Bonus,
                IsMonthlyCommission = model.IsMonthlyCommission,
                CommissionByValueOrPercentage = model.CommissionByValueOrPercentage,
                CommissionAfterOrderNumber = model.CommissionAfterOrderNumber,
                OrderCommission = model.OrderCommission,
                AllOrders = model.AllOrders,
                OpeningBalance = model.OpeningBalance,
                Creditlimit = model.Creditlimit,
                NationalityId = model.NationalityId,
                StartWorkDate = model.StartWorkDate,
                AccountingDayId = model.AccountingDayId,
                CurrencyId = model.CurrencyId,
                AreaId = model.AreaId,
                BranchId = model.BranchId,
                RegionId = model.RegionId,
                ShiftId = model.ShiftId,
                BankCode = model.BankCode,
                IBAN = model.IBAN,
                AccountNumber = model.AccountNumber,
                CostCenter = model.CostCenter,
                IsStop = model.IsStop,
                StopDate = model.StopDate,
                StopReason = model.StopReason
            };

            _context.Add(client);
            _context.SaveChanges();
			return RedirectToAction("Index");
		}
        [HttpGet]
        public IActionResult Update(int id)
        {
            var client = _context.Clients
                        .Include(x => x.AccountingDay)
                        .Include(x => x.Application)
                        .Include(x => x.Area)
                        .Include(x => x.Branch)
                        .Include(x => x.ClientType)
                        .Include(x => x.Currency)
                        .Include(x => x.Moderator)
                        .Include(x => x.Nationality)
                        .SingleOrDefault( x => x.Id == id);

            if (client == null) { return NotFound(); }

            var accountingDays = _context.AccountingDays.Select(x => new SelectListItem()
            {
                Value = x.Id.ToString(),
                Text = x.Name
            }).ToList();

            var applications = _context.Applications.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            }).ToList();

            var areas = _context.Areas.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            }).ToList();

            var branchs = _context.Branchs.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            }).ToList();

            var clientTypes = _context.ClientTypes.Select(x => new SelectListItem()
            {
                Value = x.Id.ToString(),
                Text = x.Name
            }).ToList();

            var currencies = _context.Currencies.Select(x => new SelectListItem()
            {
                Value = x.Id.ToString(),
                Text = x.Name
            }).ToList();

            var moderators = _context.Moderators.Select(x => new SelectListItem()
            {
                Value = x.Id.ToString(),
                Text = x.Name
            }).ToList();

            var nationalities = _context.Nationalities.Select(x => new SelectListItem()
            {
                Value = x.Id.ToString(),
                Text = x.Name
            }).ToList();


            var viewModel = new ClientViewModel
            {
                Id = client.Id,
                ClientTypeId = client.ClientTypeId,
                ApplicationId = client.ApplicationId,
                NationalIdentity = client.NationalIdentity,
                IsEmployee = client.IsEmployee,
                IsOperatingClient = client.IsOperatingClient,
                NoCommissionOnFriday = client.NoCommissionOnFriday,
                BusinessDayCommissionOnly = client.BusinessDayCommissionOnly,
                NameAr = client.NameAr,
                NameEn = client.NameEn,
                CustomerTaxNumber = client.CustomerTaxNumber,
                ModeratorId = client.ModeratorId,
                AddressAr = client.AddressAr,
                AddressEn = client.AddressEn,
                PasswordApp = client.PasswordApp,
                IMEI = client.IMEI,
                PhoneNumberStcPay = client.PhoneNumberStcPay,
                CarNumber = client.CarNumber,
                CarRental = client.CarRental,
                DateOfReceiptCar = client.DateOfReceiptCar,
                PhoneNumber = client.PhoneNumber,
                zipCode = client.zipCode,
                Mailbox = client.Mailbox,
                FaxNumber = client.FaxNumber,
                IqamaExpirationDate = client.IqamaExpirationDate,
                LicenseExpirationDate = client.LicenseExpirationDate,
                Email = client.Email,
                Commission = client.Commission,
                Bonus = client.Bonus,
                IsMonthlyCommission = client.IsMonthlyCommission,
                CommissionByValueOrPercentage = client.CommissionByValueOrPercentage,
                CommissionAfterOrderNumber = client.CommissionAfterOrderNumber,
                OrderCommission = client.OrderCommission,
                AllOrders = client.AllOrders,
                OpeningBalance = client.OpeningBalance,
                Creditlimit = client.Creditlimit,
                NationalityId = client.NationalityId,
                StartWorkDate = client.StartWorkDate,
                AccountingDayId = client.AccountingDayId,
                CurrencyId = client.CurrencyId,
                AreaId = client.AreaId,
                BranchId = client.BranchId,
                RegionId = client.RegionId,
                ShiftId = client.ShiftId,
                BankCode = client.BankCode,
                IBAN = client.IBAN,
                AccountNumber = client.AccountNumber,
                CostCenter = client.CostCenter,
                IsStop = client.IsStop,
                StopDate = client.StopDate,
                StopReason = client.StopReason,
                AccountingDays = accountingDays,
                Applications = applications,
                Areas = areas,
                Branchs = branchs,
                ClientTypes = clientTypes,
                Currencies = currencies,
                Moderators = moderators,
                Nationalities = nationalities
            };

            return View(viewModel);
        }      
        [HttpPost]
        public IActionResult Update(ClientViewModel model)
        {
            var client = _context.Clients
            .Include(x => x.AccountingDay)
            .Include(x => x.Application)
            .Include(x => x.Area)
            .Include(x => x.Branch)
            .Include(x => x.ClientType)
            .Include(x => x.Currency)
            .Include(x => x.Moderator)
            .Include(x => x.Nationality)
            .SingleOrDefault(x => x.Id == model.Id);

            if (client == null) { return NotFound(); }

            if (model.Commission <= 201)
                model.Bonus = 5;
            else if (model.Commission > 201)
                model.Bonus = 10;

            client.ClientTypeId = model.ClientTypeId;
            client.ApplicationId = model.ApplicationId;
            client.NationalIdentity = model.NationalIdentity;
            client.IsEmployee = model.IsEmployee;
            client.IsOperatingClient = model.IsOperatingClient;
            client.NoCommissionOnFriday = model.NoCommissionOnFriday;
            client.BusinessDayCommissionOnly = model.BusinessDayCommissionOnly;
            client.NameAr = model.NameAr;
            client.NameEn = model.NameEn;
            client.CustomerTaxNumber = model.CustomerTaxNumber;
            client.ModeratorId = model.ModeratorId;
            client.AddressAr = model.AddressAr;
            client.AddressEn = model.AddressEn;
            client.PasswordApp = model.PasswordApp;
            client.IMEI = model.IMEI;
            client.PhoneNumberStcPay = model.PhoneNumberStcPay;
            client.CarNumber = model.CarNumber;
            client.CarRental = model.CarRental;
            client.DateOfReceiptCar = model.DateOfReceiptCar;
            client.PhoneNumber = model.PhoneNumber;
            client.zipCode = model.zipCode;
            client.Mailbox = model.Mailbox;
            client.FaxNumber = model.FaxNumber;
            client.IqamaExpirationDate = model.IqamaExpirationDate;
            client.LicenseExpirationDate = model.LicenseExpirationDate;
            client.Email = model.Email;
            client.Commission = model.Commission;
            client.Bonus = model.Bonus;
            client.IsMonthlyCommission = model.IsMonthlyCommission;
            client.CommissionByValueOrPercentage = model.CommissionByValueOrPercentage;
            client.CommissionAfterOrderNumber = model.CommissionAfterOrderNumber;
            client.OrderCommission = model.OrderCommission;
            client.AllOrders = model.AllOrders;
            client.OpeningBalance = model.OpeningBalance;
            client.Creditlimit = model.Creditlimit;
            client.NationalityId = model.NationalityId;
            client.StartWorkDate = model.StartWorkDate;
            client.AccountingDayId = model.AccountingDayId;
            client.CurrencyId = model.CurrencyId;
            client.AreaId = model.AreaId;
            client.BranchId = model.BranchId;
            client.RegionId = model.RegionId;
            client.ShiftId = model.ShiftId;
            client.BankCode = model.BankCode;
            client.IBAN = model.IBAN;
            client.AccountNumber = model.AccountNumber;
            client.CostCenter = model.CostCenter;
            client.IsStop = model.IsStop;
            client.StopDate = model.StopDate;
            client.StopReason = model.StopReason;
    
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var client = _context.Clients.Find(id);
            if (client == null) return NotFound();
            _context.Remove(client);
            _context.SaveChanges();
            return Ok();
        }

    }
}
