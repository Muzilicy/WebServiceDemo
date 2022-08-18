using System.Runtime.Serialization;

namespace WebServiceDemo.Models
{
    [DataContract]
    public class UserModel
    {
        /// <summary>
        /// 工号
        /// </summary>
        [DataMember]
        public string Sno { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [DataMember]
        public string Name { get; set; }
    }
}
