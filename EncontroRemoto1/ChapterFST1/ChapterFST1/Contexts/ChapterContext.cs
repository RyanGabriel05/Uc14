﻿using ChapterFST1.Models;
using Microsoft.EntityFrameworkCore;

namespace ChapterFST1.Contexts
{
    public class ChapterContext : DbContext
    {

        // dbcontext é a ponte entre o modelo de classe e o banco de dados

        public ChapterContext()
        {
        }
        public ChapterContext(DbContextOptions<ChapterContext> options)
        : base(options)
        {
        }
        // vamos utilizar esse método para configurar o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // cada provedor tem sua sintaxe para especificação
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-67BNS8D\\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true");
            }
        }
        // dbset representa as entidades que serão utilizadas nas operações de leitura, criação, atualização e deleção
        public DbSet<Livro> Livros { get; set; }

    }
}
