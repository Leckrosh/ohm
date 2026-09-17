/*

  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.

  Copyright (C) 2009-2010 Paul Werelds <paul@werelds.net>
	Copyright (C) 2012 Michael Möller <mmoeller@openhardwaremonitor.org>

*/

using System;
using OpenHardwareMonitor.Hardware;

namespace OpenHardwareMonitor.WMI {
  /// <summary>
  /// The WMI Provider.
  ///
  /// On .NET Framework this class published the hardware and sensor data to
  /// WMI (root/OpenHardwareMonitor) via System.Management.Instrumentation.
  /// That API does not exist on .NET (Core), so the provider is currently a
  /// no-op stub kept only to preserve the public surface used by MainForm.
  /// The original implementation is preserved in the git history and in the
  /// non-compiled files WMI\Hardware.cs, WMI\Sensor.cs and WMI\IWmiObject.cs.
  /// </summary>
  public class WmiProvider : IDisposable {

    public WmiProvider(IComputer computer) { }

    public void Update() { }

    public void Dispose() { }
  }
}
