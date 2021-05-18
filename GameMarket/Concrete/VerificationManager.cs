using GameMarket.Entities;
using GameMarket.Services;

namespace GameMarket.Concrete
{
    public class VerificationManager : IVerificationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
