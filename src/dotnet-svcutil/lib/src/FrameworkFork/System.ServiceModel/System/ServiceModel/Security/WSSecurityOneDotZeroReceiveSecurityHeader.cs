// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.ServiceModel.Channels;
using System.ServiceModel.Description;

namespace System.ServiceModel.Security
{
    internal class WSSecurityOneDotZeroReceiveSecurityHeader : ReceiveSecurityHeader
    {
        public WSSecurityOneDotZeroReceiveSecurityHeader(Message message, string actor, bool mustUnderstand, bool relay,
            SecurityStandardsManager standardsManager,
            SecurityAlgorithmSuite algorithmSuite,
            int headerIndex,
            MessageDirection transferDirection)
            : base(message, actor, mustUnderstand, relay, standardsManager, algorithmSuite, headerIndex, transferDirection)
        {
        }
    }
}
