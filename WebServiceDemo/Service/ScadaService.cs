using WebServiceDemo.Models;
using WebServiceDemo.Service.Interface;

namespace WebServiceDemo.Service
{
    public class ScadaService : IScadaOperate
    {
        public UserModel GetInfo(string sno)
        {
            return new UserModel() { Sno = sno, Name = "小红" };
        }

        public int AddInfo(UserModel student)
        {
            return 1;
        }
    }
}
