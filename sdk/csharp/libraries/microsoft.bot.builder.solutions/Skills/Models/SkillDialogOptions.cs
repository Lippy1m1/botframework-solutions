﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Microsoft.Bot.Builder.Solutions.Skills.Models.Manifest;

namespace Microsoft.Bot.Builder.Solutions.Skills.Models
{
    [Obsolete("This type is being deprecated. To continue using Skill capability please refer to https://aka.ms/botframework-solutions/releases/0_8", false)]
    public class SkillDialogOptions
    {
        public SkillManifest SkillManifest { get; set; }

        public Dictionary<string, object> Parameters { get; set; } = new Dictionary<string, object>();
    }
}