using WebApi.Dto.Vinculo;
using WebApi.Models;

namespace WebApi.Dto.Livro {
    public record LivroEdicaoDto(int Id, string Titulo, AutorVinculoDto Autor) {
    }
}
