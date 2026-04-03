using System.CodeDom.Compiler;
using System.ServiceModel;

namespace ArcEngine.QslInfo;

[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[ServiceContract(Namespace = "http://www.qslinfo.de", ConfigurationName = "QslInfo.qslinfoSoap")]
public interface qslinfoSoap
{
	[OperationContract(Action = "http://www.qslinfo.de/qslinfo", ReplyAction = "*")]
	qslinfoResponse qslinfo(qslinfoRequest request);
}
