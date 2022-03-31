﻿// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.JSInterop;

/// <summary></summary>
[JSAutoInterop(
    TypeName = "NetworkInformation",
    Implementation = "window.navigator.connection",
    Url = "https://developer.mozilla.org/docs/Web/API/Window/localStorage")]
public partial interface INetworkInformationService
{
}