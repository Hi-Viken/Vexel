using System.Threading.Tasks;
using Vexel.Code;

namespace Vexel.Service.AutoJob
{
	public interface IJobTask
	{
		//执行方法
		Task<AlwaysResult> Start();
	}
}