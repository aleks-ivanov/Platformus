﻿// Copyright © 2020 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Platformus.Website.Data.Entities;

namespace Platformus.Website.Backend.ViewModels.DataTypes
{
  public static class CreateOrEditViewModelMapper
  {
    public static DataType Map(DataType dataType, CreateOrEditViewModel createOrEdit)
    {
      dataType.StorageDataType = createOrEdit.StorageDataType;
      dataType.JavaScriptEditorClassName = createOrEdit.JavaScriptEditorClassName;
      dataType.Name = createOrEdit.Name;
      dataType.Position = createOrEdit.Position;
      return dataType;
    }
  }
}