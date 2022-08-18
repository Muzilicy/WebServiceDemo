using System.Runtime.Serialization;

namespace WebServiceDemo.Models
{
    [DataContract]
    public class FactoryModel
    {
        /// <summary>
        /// 工厂号
        /// </summary>
        [DataMember]
        public string Fno { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [DataMember]
        public string Name { get; set; }
    }
}
