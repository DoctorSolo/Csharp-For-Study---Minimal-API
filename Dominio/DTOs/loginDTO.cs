using System;

namespace MinimalAPI.DTOs;

public class LoginDTO
{
    public String Email { get; set; } = default!;
    public String Senha { get; set; } = default!;
}