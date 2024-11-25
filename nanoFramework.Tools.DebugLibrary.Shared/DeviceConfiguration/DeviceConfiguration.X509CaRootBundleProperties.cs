﻿//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
//

//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
//

using CommunityToolkit.Mvvm.ComponentModel;
using System.Text;

namespace nanoFramework.Tools.Debugger
{
    public partial class DeviceConfiguration
    {
        public class X509CaRootBundleProperties : X509CaRootBundlePropertiesBase
        {
            private bool _isUnknown = true;

            public bool IsUnknown
            {
                get => _isUnknown;
                set => SetProperty(ref _isUnknown, value);
            }

            public X509CaRootBundleProperties()
            {
            }

            public X509CaRootBundleProperties(X509CaRootBundleBase certificate)
            {
                CertificateSize = (uint)certificate.Certificate.Length;
                Certificate = certificate.Certificate;

                // reset unknown flag
                IsUnknown = false;
            }

            // operator to allow casting a X509CaRootBundleProperties object to X509CaRootBundleBase
            public static explicit operator X509CaRootBundleBase(X509CaRootBundleProperties value)
            {
                var x509Certificate = new X509CaRootBundleBase()
                {
                    Marker = Encoding.UTF8.GetBytes(MarkerConfigurationX509CaRootBundle_v1),

                    CertificateSize = (uint)value.Certificate.Length,
                    Certificate = value.Certificate,
                };

                return x509Certificate;
            }
        }
    }
}