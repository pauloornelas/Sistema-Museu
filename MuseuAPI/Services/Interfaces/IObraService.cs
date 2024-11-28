using MuseuAPI.Dtos;

namespace MuseuAPI.Services.Interfaces
{
    public interface IObraService
    {
        IEnumerable<ObraDto> GetAllObras();
        ObraDto GetObraById(int id);
        ObraDto AddObra(ObraDto obra);
        bool UpdateObra(int id, ObraDto obra);
        bool DeleteObra(int id);
    }
}
