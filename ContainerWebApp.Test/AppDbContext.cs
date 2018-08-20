using System;
using System.Collections.Generic;

namespace ContainerWebApp.Test
{
    internal class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        internal static object GetSeedingMessages()
        {
            return new List<string>();
        }

        internal virtual object GetMessages()
        {
            return null;
        }
    }
}