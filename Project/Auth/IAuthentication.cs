using GetirAPI.Auth.Response;
using System.Runtime.InteropServices;

namespace GetirAPI
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IAuthentication
    {
        GetTokenResponse GetToken();
        void SetSecretKeys(string appSecretKey, string restSecretKey);
    }
}