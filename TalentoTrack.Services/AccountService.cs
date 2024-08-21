﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentoTrack.Common.DTOs.Account;
using TalentoTrack.Common.Repositoy;
using TalentoTrack.Common.Services;

namespace TalentoTrack.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public async Task<LoginResponse> VerifyLoginDetails(LoginRequest request)
        {
            LoginResponse response = new LoginResponse();
            try
            {
                var dbUser = await _accountRepository.GetLoginDetails(request.Username!, request.Password!);

                if(dbUser == null)
                {
                    response.Success = false;
                    response.ErrorMessage = "Invalid Creadential";

                }
                else
                {
                    response.Success = true;
                }

                return response;
            }
            catch(Exception ex)
            {
                throw;
            }

            
        }

        
    }
}
