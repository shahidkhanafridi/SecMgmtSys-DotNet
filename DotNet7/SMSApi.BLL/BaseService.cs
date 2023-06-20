global using SMSApi.Data.Repositories;

namespace SMSApi.BLL
{
    public interface IBaseService
    {

    }
    public class BaseService
    {
        private readonly IBaseRepository _repository;

        public BaseService(IBaseRepository repository)
        {
            _repository = repository;
        }
    }
}