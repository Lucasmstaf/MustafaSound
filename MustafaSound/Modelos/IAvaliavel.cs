﻿namespace MustafaSound.Modelos;

internal interface IAvaliavel
{
    double Media { get; }
    void AdicionarNota(Avaliacao nota);
}
