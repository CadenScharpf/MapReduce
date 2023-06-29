using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WordCountServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMapReduceServices
    {
        //http://localhost:55974/Service1.svc/Map
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Xml, RequestFormat = WebMessageFormat.Xml, UriTemplate = "Map")]
        ResponseData Map(RequestData data);

        //http://localhost:55974/Service1.svc/Reduce/{"DataTable":[{"key":"Students","value":1},{"key":"across","value":1},{"key":"Arizona","value":1},{"key":"participate","value":1},{"key":"in","value":1},{"key":"a","value":1},{"key":"statewide","value":1},{"key":"robotics","value":1},{"key":"hackathon","value":1},{"key":"accross","value":1},{"key":"arizona","value":1},{"key":"arizona","value":1},{"key":"a","value":1},{"key":"a","value":1},{"key":"a","value":1},{"key":"in","value":1
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Xml, RequestFormat = WebMessageFormat.Xml, UriTemplate = "Reduce")]
        ResponseData Reduce(RequestData data);

        //http://localhost:55974/Service1.svc/Combine/data
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Xml, RequestFormat = WebMessageFormat.Xml, UriTemplate = "Combine")]
        ResponseData Combine(RequestData data);


    }
    [DataContract(Namespace = "http://www.cse446.com/Assignment9")]
    public class RequestData
    {
        [DataMember]
        public string data { get; set; }
    }

    [DataContract(Namespace = "http://www.cse446.com/Assignment9")]
    public class ResponseData
    {
        [DataMember]
        public string data { get; set; }
    }

}
