using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{
    public class Migration
    {
        private readonly ILogger logger;

        public Migration(ILogger logger)
        {
            this.logger = logger;
        }

        public void Migrate()
        {
            logger.LogInfor("Migration started at {0}" + DateTime.Now);
            logger.LogInfor("Migration finished at {1}" + DateTime.Now);
        }
    }
}
