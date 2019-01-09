using EntityHomeWork.Data;
using System.Linq;

namespace EntityHomeWork
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var drones = new DronesAndControllers())
			{
				var result = drones.Drones.ToList();
			}
		}
	}
}
