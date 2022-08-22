using Airport.DAL.Repositories;
using Airport.DAL.Repositories;

namespace Airport.BLL.Services
{
    public class PassportControlService
    {
        private readonly PassportInfoRepository _passportInfoRepository;

        public PassportControlService()
        {
            _passportInfoRepository = new PassportInfoRepository();
        }

        public bool NameIsCorrect(string userNme)
        {
            if (userNme.Length < 15)
            {
                return true;
            }

            return false;
        }
        public string CheckPassport()
        {
            Console.Write("Let's check your passport: ");
            int numb =int.Parse(Console.ReadLine());

            if ( numb != null)
            {
                Console.WriteLine("Your data has been confirmed, you can continue checking.");
            }
            else
            {
                Console.WriteLine("Your data does not match, please check your input.");
            }
            return null;
        }
    }
}
