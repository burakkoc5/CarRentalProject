using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.IoC
{
    public interface ICoreModule
    {
        //Genel bağımlılıkları yükleyecek
        //Tüm projelerde kullanılabilir
        void Load(IServiceCollection serviceCollection);
    }
}
