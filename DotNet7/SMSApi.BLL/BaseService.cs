using Microsoft.Extensions.Configuration;

namespace SMSApi.BLL
{
    public class BaseService
    {
        protected readonly Data.AppDbContext _dbContext;
        protected readonly IConfiguration _config;
        public BaseService(Data.AppDbContext dbContext, IConfiguration config)
        {
            _dbContext= dbContext;
            _config= config;
        }
    }
}