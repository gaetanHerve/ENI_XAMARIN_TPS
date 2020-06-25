using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace M08_TP05.Services
{
    public class ConnectionService : IConnectionService
    {
        public bool CheckNetworkConnection()
        {
            Boolean result = false;

            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                result = true;
            }

            return result;
        }
    }
}
