using AzureFunctionDatabase.Database;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

[assembly: FunctionsStartup(typeof(AzureFunctionDatabase.Startup))]
namespace AzureFunctionDatabase
{
    class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            string SqlConnection = "Server=DESKTOP-UID0NUC;Database=FunctionDatabase;Trusted_Connection=True";
            builder.Services.AddDbContext<FunctionContext>(
                options => options.UseSqlServer(SqlConnection));
        }
    }
}
