using System.Runtime.InteropServices;

namespace GetirAPI.Auth.Response
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IGetTokenResponse
    {
        string restaurantId { get; set; }
        string token { get; set; }
    }
}