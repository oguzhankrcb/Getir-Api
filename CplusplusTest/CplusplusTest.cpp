#include <iostream>
#include <Windows.h>

#import "C:\Users\CodeR\Desktop\Mikale\Projects\MikaleServices\CplusplusTest\GetirAPI.tlb"

inline void TESTHR(HRESULT x) { if FAILED(x) _com_issue_error(x); };

int main()
{
    setlocale(LC_ALL, "Turkish");

    CoInitialize(NULL);

    GetirAPI::IAuthenticationPtr authentication(__uuidof(GetirAPI::Authentication));

    authentication->SetSecretKeys("APP SECRET HERE","REST SECRET HERE");


    GetirAPI::IGetTokenResponsePtr str = authentication->GetToken();

    std::cout << str->token;

    GetirAPI::IOrderServicePtr orderService(__uuidof(GetirAPI::OrderService));

    GetirAPI::IGetCAFoodOrdersResponsePtr foodOrders = orderService->GetCanceledFoodOrders(str->token);

    SAFEARRAY* orders = foodOrders->FoodOrders;

    std::cout << "\r\n";

    if (orders) 
    {
        SafeArrayLock(orders);
        LONG lb;
        LONG ub;
        SafeArrayGetLBound(orders, 1, &lb);
        SafeArrayGetUBound(orders, 1, &ub);
        for (int i = lb; i <= ub; i++)
        {
            GetirAPI::IOrderPtr order(((IUnknown**)orders->pvData)[i]);
            wprintf(L"%s\n", (LPWSTR)order->Client->Name);
        }
        SafeArrayUnlock(orders);
    }

    std::cin;


    CoUninitialize();
}
