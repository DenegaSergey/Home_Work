using Airport.Core.Models;

namespace Airport.DAL.Repositories
{
    public  class PassportInfoRepository:PassportInfo
    {
        public string GetName()
        {
            Name = Console.ReadLine();
            return Name;
        }

        public int GetPassportNumber()
        {
            PassportNumber = Convert.ToInt32(Console.ReadLine());
            return PassportNumber; 
        }
    }
}
