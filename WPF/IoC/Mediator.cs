using System;
using System.Collections.Generic;
using System.Text;

namespace IoC
{
   public  class Mediator
    {
        public ILogger Logger { get; set; }
        public IApiService ApiService { get; set; }
        public IStorage Storage { get; set; }

        public Mediator(ILogger logger, IApiService apiService, IStorage storage)
        {
            Logger = logger;
            ApiService = apiService;
            Storage = storage;
        }
    }
}
