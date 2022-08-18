using System.ServiceModel;
using WebServiceDemo.Models;

namespace WebServiceDemo.Service.Interface
{
    [ServiceContract]
    public interface IMesOperate
    {
        /// <summary>
        /// 查询工厂信息
        /// </summary>
        /// <param name="fno">工厂号</param>
        /// <returns>工厂信息</returns>
        [OperationContract]
        FactoryModel GetInfo(string fno);
        /// <summary>
        /// 添加工厂信息
        /// </summary>
        /// <param name="factory">工厂信息</param>
        /// <returns></returns>
        [OperationContract]
        string AddInfo(FactoryModel factory);
    }
}
