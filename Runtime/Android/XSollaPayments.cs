using MirraGames.SDK.Common;
using System;

namespace MirraGames.SDK.XSolla.Android
{
    [Provider(typeof(IPayments))]
    public class XSollaPayments : CommonXSollaPayments
    {
        public XSollaPayments(IData data) : base(data) { }

        protected override void InvokeLogin(Action onSuccess, Action onError)
        {
            onSuccess?.Invoke();
        }

        protected override bool IsLoggedIn()
        {
            return true;
        }
    }
}