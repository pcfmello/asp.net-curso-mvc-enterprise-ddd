namespace PCFMELLO.CursoMvc.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<PCFMELLO.CursoMvc.Infra.Data.Context.CursoMVCContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; // Migration deve estar habilitado
        }

        protected override void Seed(PCFMELLO.CursoMvc.Infra.Data.Context.CursoMVCContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            /* Criar o banco de dados */
            // update-database -script (cria um script das tabelas antes da criação)


            /* Populando tabela clientes */
            /* context.Clientes.AddOrUpdate(
                new Domain.Entities.Cliente
                {
                    Nome = "PAULO CESAR",
                    CPF = "045589619-90",
                    DataNascimento = DateTime.Parse("1983-11-06"),
                    DataCadastro = DateTime.Now,
                    Email = "pcfmello@gmail.com",
                    Ativo = true,
                },

                new Domain.Entities.Cliente
                {
                    Nome = "CLAUDIA RODRIGUES",
                    CPF = "213584005-80",
                    DataNascimento = DateTime.Parse("1966-12-21"),
                    DataCadastro = DateTime.Now,
                    Email = "claudinha@gmail.com",
                    Ativo = true,
                },

                new Domain.Entities.Cliente
                {
                    Nome = "LUCAS RODRIGUES",
                    CPF = "021547785-21",
                    DataNascimento = DateTime.Parse("1996-11-04"),
                    DataCadastro = DateTime.Now,
                    Email = "lucas@gmail.com",
                    Ativo = true,
                }
            ); */
            /* Populando tabela clientes */
        }
    }
}
