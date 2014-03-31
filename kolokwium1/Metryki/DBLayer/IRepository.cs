using Metryki.Domain;

namespace Metryki.DBLayer
{
	public interface IRepository
	{
		void SaveOrUpdate(IPerson person);
		void Drop(IPerson person);
	}
}