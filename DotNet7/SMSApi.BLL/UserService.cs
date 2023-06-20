using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApi.BLL
{
    public interface IUserService
    {

    }
    public class UserService : BaseService, IUserService
    {
        public UserService(IBaseRepository repository) : base(repository)
        {
        }
    }
}
