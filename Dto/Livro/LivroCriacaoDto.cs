using WebApi.Dto.Vinculo;
using WebApi.Models;

namespace WebApi.Dto.Livro {
    public record LivroCriacaoDto(string Titulo, AutorVinculoDto Autor) {
    }
}
