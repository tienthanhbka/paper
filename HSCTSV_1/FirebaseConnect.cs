using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp;
using FireSharp.Interfaces;

namespace HSCTSV_1
{
    class FirebaseConnect
    {
        private static FirebaseConnect instance;
        public static FirebaseConnect Instance
        {
            get { if (instance == null) instance = new FirebaseConnect(); return instance; }
            private set { instance = value; }
        }
        public IFirebaseClient client;
        public FirebaseConnect()
        {
            IFirebaseConfig config = new FirebaseConfig()
            {
                AuthSecret = "FPpGKNkIdgINQxDBy7yuQapjne0Nmn6k6OpvEfVi",
                BasePath = "https://hssv-a0353.firebaseio.com/"
            };
            client = new FirebaseClient(config);
        }
    }
}
