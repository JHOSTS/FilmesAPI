﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class ReadEnderecoDto
{
    public int Id { get; set; }
    public String Logradouro { get; set; }
    public int Numero { get; set; }
}
