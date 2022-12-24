using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsft;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DependencyResolvers
{
	public class CoreModule : ICoreModule
	{
		public void Load(IServiceCollection servisCollection)
		{
			servisCollection.AddMemoryCache();
			servisCollection.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();
			servisCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
		}
	}
}
