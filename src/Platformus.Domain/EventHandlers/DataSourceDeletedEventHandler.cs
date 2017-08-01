﻿// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Extensions.DependencyInjection;
using Platformus.Barebone;
using Platformus.Domain.Data.Entities;

namespace Platformus.Domain
{
  public class DataSourceDeletedEventHandler : IDataSourceDeletedEventHandler
  {
    public int Priority => 1000;

    public void HandleEvent(IRequestHandler requestHandler, DataSource dataSource)
    {
      requestHandler.HttpContext.RequestServices.GetService<ICache>().RemoveAll();
    }
  }
}