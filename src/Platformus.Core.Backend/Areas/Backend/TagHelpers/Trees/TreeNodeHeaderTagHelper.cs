﻿// Copyright © 2021 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Platformus.Core.Backend
{
  [RestrictChildren("tree-node-title", "tree-node-buttons", "partial")]
  public class TreeNodeHeaderTagHelper : TagHelper
  {
    public string Class { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
      output.TagName = TagNames.Div;
      output.Attributes.SetAttribute(AttributeNames.Class, "node__header" + (string.IsNullOrEmpty(this.Class) ? null : $" {this.Class}"));
      context.Items["IsTreeNodeHeader"] = true;
    }
  }
}