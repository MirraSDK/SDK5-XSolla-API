using MirraGames.SDK.Common;
using UnityEngine;

namespace MirraGames.SDK.XSolla.Android
{
    [ProviderConfiguration(typeof(XSollaPayments))]
    public class XSollaPayments_Configuration : PropertyGroup
    {
        public override string Name => nameof(XSollaPayments);

        [field: SerializeField] public string Token { get; private set; } = "";

        public override StringProperty[] GetStringProperties()
        {
            return new StringProperty[] {
                new(
                    "Token",
                    getter: () => { return Token; },
                    setter: (value) => { Token = value; }
                )
            };
        }

    }
}