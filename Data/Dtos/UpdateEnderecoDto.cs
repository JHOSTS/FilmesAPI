using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class UpdateEnderecoDto
{
    public String Logradouro { get; set; }
    public int Numero { get; set; }
}
