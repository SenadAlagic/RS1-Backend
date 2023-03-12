using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace eRezervacija.API.Helpers
{
    public class AutorizacijaAttribute : TypeFilterAttribute
    {
        public AutorizacijaAttribute(bool Admin, bool Vlasnik, bool Gost)
            : base(typeof(MyAuthorizeImpl))
        {
            Arguments = new object[] { Admin, Vlasnik, Gost };
        }

    }
    public class MyAuthorizeImpl : IActionFilter
    {
        private readonly bool _admin;
        private readonly bool _vlasnik;
        private readonly bool _gost;

        public MyAuthorizeImpl(bool Admin, bool Vlasnik, bool Gost)
        {
            _admin = Admin;
            _vlasnik = Vlasnik;
            _gost = Gost;
        }

        void IActionFilter.OnActionExecuted(ActionExecutedContext context)
        {
            //TODO: mozda dodati LogKretanjePoSistemu
        }

        void IActionFilter.OnActionExecuting(ActionExecutingContext context)
        {
            AuthTokenExtension.LoginInformacije loginInfo = context.HttpContext.GetLoginInfo();
            //ako nije logiran ili je korisnicki nalog null
            if (!loginInfo.isLogiran || loginInfo.korisnickiNalog == null)
            {
                context.Result = new UnauthorizedResult();
                return;
            }
            //ako postoji profil ali nije aktiviran TODO: implementirati aktivaciju
            //if (!loginInfo.korisnickiNalog.isAktiviran)
            //{

            //}
            if (loginInfo.korisnickiNalog.Uloga == "Admin" && _admin)
            {
                return;
            }
            if (loginInfo.korisnickiNalog.Uloga == "Vlasnik" && _vlasnik)
            {
                return;
            }
            if (loginInfo.korisnickiNalog.Uloga == "Gost" && _gost)
            {
                return;
            }
            context.Result = new UnauthorizedResult();
        }
    }
}
