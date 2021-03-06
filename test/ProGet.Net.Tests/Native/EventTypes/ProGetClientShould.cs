﻿using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Fact]
        public async Task EventTypes_GetEventTypesAsync()
        {
            var results = await _client.EventTypes_GetEventTypesAsync();

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}

