using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentoTrack.Common.DTOs.Account;
using TalentoTrack.Common.Entity;

namespace TalentoTrack.Common.Repositoy
{
    public interface IAccountRepository
    {
        Task<LoginDetails> GetLoginDetails(string Username, string Password);
    }
}
