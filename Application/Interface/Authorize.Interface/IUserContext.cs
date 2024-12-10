﻿using System.Security.Claims;

namespace Authorize.Interface
{
    public interface IUserContext
    {

        public bool IsAuthenticated { get; }


        public long UserId { get; }


        public IEnumerable<Claim> Claims { get; }

    }
}