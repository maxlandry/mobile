﻿using System.Net.Http;
using System;
using System.Net.Http.Headers;

namespace Bit.App
{
    public class ApiHttpClient : HttpClient
    {
        public ApiHttpClient()
        {
            Init();
        }

        public ApiHttpClient(HttpMessageHandler handler)
            : base(handler)
        {
            Init();
        }

        private void Init()
        {
            //BaseAddress = new Uri("http://192.168.1.3:4000");
            BaseAddress = new Uri("https://api.bitwarden.com");
            DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
