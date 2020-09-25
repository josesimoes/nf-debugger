﻿//
// Copyright (c) .NET Foundation and Contributors
// Portions Copyright (c) Microsoft Corporation.  All rights reserved.
// See LICENSE file in the project root for full license information.
//


namespace nanoFramework.Tools.Debugger.WireProtocol
{
    public interface IControllerRemote : IController
    {
        bool RegisterEndpoint(uint epType, uint epId);
        void DeregisterEndpoint(uint epType, uint epId);
    }
}
