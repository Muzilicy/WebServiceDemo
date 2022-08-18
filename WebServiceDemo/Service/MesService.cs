using WebServiceDemo.Models;
using WebServiceDemo.Service.Interface;

namespace WebServiceDemo.Service
{
    public class MesService : IMesOperate
    {
        public string AddInfo(FactoryModel factory)
        {
            return factory.Name;
        }

        public FactoryModel GetInfo(string fno)
        {
            return new FactoryModel() { Fno = fno , Name = "第一工厂" };
        }
    }
}
