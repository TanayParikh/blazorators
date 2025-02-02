﻿// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace Blazor.SourceGenerators.Parsers;

internal enum ParserResultStatus
{
    Unknown,
    TargetTypeNotFound,
    SuccessfullyParsed,
    ErrorParsing
};
