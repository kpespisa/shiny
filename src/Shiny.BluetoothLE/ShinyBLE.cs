﻿using System;
using Shiny.BluetoothLE.Central;
using Shiny.BluetoothLE.Peripherals;


namespace Shiny
{
    public static class ShinyBLE
    {
        public static ICentralManager Central { get; } = ShinyHost.Resolve<ICentralManager>();
        public static IPeripheralManager Peripheral { get; } = ShinyHost.Resolve<IPeripheralManager>();
    }
}
