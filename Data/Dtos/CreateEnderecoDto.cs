using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class CreateEnderecoDto
{
    public String Logradouro { get; set; }
    public int Numero { get; set; }
}
