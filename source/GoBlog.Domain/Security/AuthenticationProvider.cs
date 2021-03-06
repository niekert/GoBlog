﻿using System.Web.Security;

namespace GoBlog.Domain.Security
{
    public class AuthenticationProvider : IAuthenticationProvider
    {
        public bool Authenticate(string username, string password)
        {
            var authenticated = FormsAuthentication.Authenticate(username, password);

            if (authenticated)
                FormsAuthentication.SetAuthCookie(username, false);

            return authenticated;
        }

        public void SignOut()
        {
            FormsAuthentication.SignOut();
        }
    }
}