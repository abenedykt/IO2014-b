namespace GeoParser
{
    public interface IGeoRepository
    {
        void Add(string nrDzialki, double x, double y, double minX, double minY, double maxX, double maxY);
    }
}
