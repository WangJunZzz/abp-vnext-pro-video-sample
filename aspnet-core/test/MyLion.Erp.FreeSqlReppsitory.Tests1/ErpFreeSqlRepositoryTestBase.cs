using MyLion.Erp.FreeSqlReppsitory.Tests;
using MyLion.Erp.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLion.Erp
{
    public abstract class ErpFreeSqlRepositoryTestBase: ErpTestBase<ErpFreeSqlRepositoryTestModule>
    {
        public ErpFreeSqlRepositoryTestBase()
        {
            ServiceProvider.InitializeLocalization();
        }
    }
}
