using Checkpoint_3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkpoint_3.Data
{
    public class ArticleContext : DbContext
    {
        public ArticleContext(DbContextOptions<ArticleContext> options)
            : base(options)
        {

        }
        public DbSet<Article> Article { get; set; }
    }
}

