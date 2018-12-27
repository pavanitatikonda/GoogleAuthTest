using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Auth;

namespace GoogleAuth
{
    public interface IServiceCall
    {
        void LoginAuthenticate(OAuth2Authenticator authenticator);
    }
}
