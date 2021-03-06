﻿using NosCore.Core;
using System.Collections.Generic;

namespace NosCore.Networking
{
    public class MasterClientListSingleton
    {
        private static MasterClientListSingleton instance;

        private MasterClientListSingleton() { }

        public static MasterClientListSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MasterClientListSingleton();
                }
                return instance;
            }
        }

        public List<WorldServer> WorldServers { get; set; }
    }
}
