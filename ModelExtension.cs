using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_PR_BD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    public partial class SportEntities1 : DbContext
    {

        private static SportEntities1 context;

        public static SportEntities1 GetContext()
        {
            if (context == null) context = new SportEntities1();
            return context;
        }
     }
}
