using MuseuAPI.Dtos;
using MuseuAPI.Repositories.Interfaces;
using MuseuAPI.Services.Interfaces;
using MuseuAPI.Entities;

namespace MuseuAPI.Services
{
    public class ObraService : IObraService
    {
        private readonly IObraRepository _obraRepository;

        public ObraService(IObraRepository obraRepository)
        {
            _obraRepository = obraRepository;
        }

        public IEnumerable<ObraDto> GetAllObras()
        {
            var obras = _obraRepository.GetAllAsync().Result;
            return obras.Select(o => new ObraDto 
            { 
                Id = o.Id, 
                Nome = o.Nome, 
                Descricao = o.Descricao, 
                Imagem = o.Imagem 
            });
        }

        public ObraDto GetObraById(int id)
        {
            var obra = _obraRepository.GetByIdAsync(id).Result;
            if (obra == null) return null;

            return new ObraDto 
            { 
                Id = obra.Id, 
                Nome = obra.Nome, 
                Descricao = obra.Descricao, 
                Imagem = obra.Imagem 
            };
        }

        public ObraDto AddObra(ObraDto obraDto)
        {
            var obra = new Obra 
            { 
                Nome = obraDto.Nome, 
                Descricao = obraDto.Descricao, 
                Imagem = obraDto.Imagem 
            };
            var novaObra = _obraRepository.AddAsync(obra).Result;
            return new ObraDto 
            { 
                Id = novaObra.Id, 
                Nome = novaObra.Nome, 
                Descricao = novaObra.Descricao, 
                Imagem = novaObra.Imagem 
            };
        }

        public bool UpdateObra(int id, ObraDto obraDto)
        {
            var obra = _obraRepository.GetByIdAsync(id).Result;
            if (obra == null) return false;

            obra.Nome = obraDto.Nome;
            obra.Descricao = obraDto.Descricao;
            obra.Imagem = obraDto.Imagem;

            _obraRepository.UpdateAsync(obra).Wait();
            return true;
        }

        public bool DeleteObra(int id)
        {
            var obra = _obraRepository.GetByIdAsync(id).Result;
            if (obra == null) return false;

            _obraRepository.DeleteAsync(obra).Wait();
            return true;
        }
    }
}
