using CITB517_WebApplication.Models;
using System.Threading.Tasks;

namespace CITB517_WebApplication.Services.Interfaces
{
    public interface IUserService
    {
        Task Create(Register model);

    }
}