using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu Projeto ASPNET CORE 1", "Minha Descricao de Projeto 1", 1, 1, 10000 ),
                new Project("Meu Projeto ASPNET CORE 2", "Minha Descricao de Projeto 2", 1, 1, 10000 ),
                new Project("Meu Projeto ASPNET CORE 3", "Minha Descricao de Projeto 3", 1, 1, 10000 )
            };

            Users = new List<User>
            {
                new User("Idalmir Oliveira", "idalmir@idalmir.com.br", new DateTime(1988, 8, 10)),
                new User("Pietro de Jesus", "pietro@pietro.com.br", new DateTime(2018, 12, 03)),
                new User("Elizabete Oliveira", "elizabete@elizabete.com.br", new DateTime(1988, 8, 10))
            };

            Skills = new List<Skill>
            {
                new Skill(".Net Core"),
                new Skill("C#"),
                new Skill("SQL")
            };
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
