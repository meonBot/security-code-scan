﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace Analyzer.Utilities.Options
{
    internal enum EnumValuesPrefixTrigger
    {
        // NOTE: Below fields names are used in the .editorconfig specification.
        //       Hence the names should *not* be modified, as that would be a breaking
        //       change for .editorconfig specification.
        AnyEnumValue,
        AllEnumValues,
        Heuristic,
    }
}
