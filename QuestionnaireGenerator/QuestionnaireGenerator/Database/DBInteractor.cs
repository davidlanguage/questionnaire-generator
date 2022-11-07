using Microsoft.EntityFrameworkCore;
using QuestionnaireGenerator.Models;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;

namespace QuestionnaireGenerator.Database
{

        public class DBInteractor : DbContext
        {
            public DbSet<Question> questions { get; set; }
            
            public string DbPath { get; }

            public DBInteractor()
            {
                var folder = Environment.SpecialFolder.LocalApplicationData;
                var path = Environment.GetFolderPath(folder);
                DbPath = System.IO.Path.Join(path, "questionnaire.db");
            }

            // The following configures EF to create a Sqlite database file in the
            // special "local" folder for your platform.
            protected override void OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlite($"Data Source={DbPath}");
    }
    }
