namespace EntityHomeWork.Data
{
	using EntityHomeWork.Models;
	using System.Data.Entity;

	public class DronesAndControllers : DbContext
	{

		public DronesAndControllers()
			: base("name=DronesAndControllers")
		{
		}
		public DbSet<Drone> Drones { get; set; }
		public DbSet<RemoteController> RemoteControllers { get; set; }

	}


}