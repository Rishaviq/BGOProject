using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGO.Services.Helpers
{
    public static class ApiKeyContainer
    {
        private static string ApiKey;
        public static void SetKey(string key)
        {
            ApiKey = key;
        }
        public static string GetKey()
        {
            return ApiKey;
        }
    }
}
