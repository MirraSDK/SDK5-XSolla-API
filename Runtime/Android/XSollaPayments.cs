using MirraGames.SDK.Common;
using Newtonsoft.Json.Linq;
using System;
using Xsolla.Core;

namespace MirraGames.SDK.XSolla.Android
{
    [Provider(typeof(IPayments))]
    public class XSollaPayments : CommonXSollaPayments
    {
        public XSollaPayments(XSollaPayments_Configuration configuration, IData data) : base(data)
        {
            try
            {
                XsollaToken.Create(configuration.Token);
                GetItems();
            }
            catch (Exception exception)
            {
                Logger.CreateError(this, $"Failed to create XSolla token: {exception}");
                GetItems();
            }
        }

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