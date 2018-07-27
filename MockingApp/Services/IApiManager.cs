using MockingApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MockingApp.Services
{
    public interface IApiManager
    {
        Task<bool> LoginUser(User user);
        Task<List<Dog>> GetDogs();
    }
}
