﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    interface IProdutoDAO
    {
        void Adicionar(Produto p);
        void Atualizar(Produto p);
        void Remover(Produto p);
        List<Produto> Produtos(); // Método que representa o SELECT
    }
}
