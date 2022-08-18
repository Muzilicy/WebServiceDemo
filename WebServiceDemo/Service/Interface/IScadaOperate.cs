using System.ServiceModel;
using WebServiceDemo.Models;

namespace WebServiceDemo.Service.Interface
{
    [ServiceContract]
    public interface IScadaOperate
    {
        /// <summary>
        /// 查询学生信息
        /// </summary>
        /// <param name="sno">学号</param>
        /// <returns>学生信息</returns>
        [OperationContract]
        UserModel GetInfo(string sno);
        /// <summary>
        /// 添加学生信息
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        [OperationContract]
        int AddInfo(UserModel student);
    }
}
