using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Times.Data;
using System;
using System.Linq;

namespace Times.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new TimesContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<TimesContext>>()))
                {
                    if(context.Time.Any())
                    {
                        return;
                    }
                    context.Time.AddRange(
                        new Time
                        {
                            Nome = "S.C Corinthians Paulista",
                            Abrev = "COR",
                            Cidade = "Sao Paulo"

                        },
                        new Time
                        {
                            Nome = "Marilia A.C",
                            Abrev = "MAC",
                            Cidade = "Marilia"

                        },
                            new Time
                        {
                            Nome = "Londrina E.C",
                            Abrev = "LEC",
                            Cidade = "Londrina"

                        },
                            new Time
                        {
                            Nome = "E.C XV de Jau",
                            Abrev = "XVJ",
                            Cidade = "Jau"

                        }

                    );
                    context.SaveChanges();
                }
        }
    }
}
