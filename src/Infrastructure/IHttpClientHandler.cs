﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public interface IHttpClientHandler
    {
        Task<T> GetAsync<T>(string url);
    }
}
