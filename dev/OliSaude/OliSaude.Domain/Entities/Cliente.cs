﻿using OliSaude.Domain.Enums;
using OliSaude.Domain.ValueObject;

namespace OliSaude.Domain.Entities;

public class Cliente : Entity
{
    public Cliente(string nome, DateTime 
        dataNascimento, 
        ESexo sexo, 
        ProblemaSaude problemaDeSaude)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
        Sexo = sexo;
        ProblemaDeSaude = problemaDeSaude;
        DataActualizacao = DateTime.UtcNow;
    }

    public string Nome { get; private set; }
    public DateTime DataNascimento { get; private set; }
    public ESexo Sexo { get; private set; }
    public ProblemaSaude ProblemaDeSaude { get; private set; }
    public DateTime DataActualizacao { get; private set; }

    public void UpdateCliente(string nome, 
        DateTime dataNascimento,
        ESexo sexo,
        ProblemaSaude problemaDeSaude, DateTime dateActualizacao)
    {
        nome = Nome;
        dataNascimento= DataNascimento;
        sexo = Sexo;
        problemaDeSaude = ProblemaDeSaude;
        DataActualizacao= dateActualizacao;
    }
}
