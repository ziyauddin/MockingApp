using MockingApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MockingApp.Services
{
    public class ApiManager : IApiManager
    {
        public string BaseUrl = "";
        public async Task<bool> LoginUser(User user)
        {
            await Task.Delay(1000);

            if (user.UserName == "char" && user.Password == "1234")
                return true;
            else
                return false;
        }

        public async Task<List<Dog>> GetDogs()
        {
            await Task.Delay(1000);

            var dogs = new List<Dog>();
            dogs.Add(new Dog() { Photo = "https://puu.sh/AUlbg/795cde9d92.png", Name = "Charles", Age = "2 years", Race = "Dalmata" });
            dogs.Add(new Dog() { Photo = "https://puu.sh/AUlcj/e0004196da.png", Name = "Terry", Age = "4 years", Race = "Bulldog" });
            dogs.Add(new Dog() { Photo = "https://puu.sh/AUlc3/c34b240f69.png", Name = "Chanik", Age = "2 years", Race = "Caniche" });
            dogs.Add(new Dog() { Photo = "https://puu.sh/AUlbN/227f0f5a68.png", Name = "Peter", Age = "6 years", Race = "Basenji" });

            return dogs;
        }
    }
}
