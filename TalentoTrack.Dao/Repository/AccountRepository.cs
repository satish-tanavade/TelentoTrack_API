using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentoTrack.Common.DTOs.Account;
using TalentoTrack.Common.Entity;
using TalentoTrack.Common.Repositoy;
using TalentoTrack.Dao.Db;


namespace TalentoTrack.Dao.Repository
{
    public class AccountRepository : IAccountRepository
    {
        public TalentoTrack_DbContext _dbContext;

        public AccountRepository(TalentoTrack_DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<LoginDetails> GetLoginDetails(string Username, string Password)
        {
            var dbRecord = await _dbContext.tbl_login_details.Where(p => (p.Username != null && p.Username.Equals(Username!)) && (p.Password != null && p.Password.Equals(Password!))).FirstOrDefaultAsync();

            return dbRecord!;
        }
    }
}
