using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "O campo título é obrigatório!")]
    [StringLength(50, ErrorMessage = "O tamanho do gênero maior que 50 caracteres!")]
    public string? Titulo { get; set; }

    [Required(ErrorMessage = "O campo gênero é obrigatório!")]
    [StringLength(30, ErrorMessage = "O tamanho do gênero maior que 50 caracteres!")]
    public string? Genero { get; set; }

    [Required(ErrorMessage = "O campo título é obrigatório!")]
    [Range(70, 300, ErrorMessage = "O tamanho da duração deve ter entre 70 e 300 minutos")]
    public int Duracao { get; set; }
}
