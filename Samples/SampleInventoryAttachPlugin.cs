// <copyright file="SampleInventoryAttachPlugin.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.Samples
{
    using System;
    using System.ComponentModel.Composition;
    using System.Reflection;

    using Ensage.SDK.Abilities.Items;
    using Ensage.SDK.Helpers;
    using Ensage.SDK.Inventory;
    using Ensage.SDK.Service;
    using Ensage.SDK.Service.Metadata;

    using log4net;

    using PlaySharp.Toolkit.Logging;

    [ExportPlugin("Sample-InventoryAttach-Plugin", StartupMode.Manual)]
    public class SampleInventoryAttachPlugin : Plugin
    {
        private static readonly ILog Log = AssemblyLogs.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private readonly IInventoryManager inventory;

        [ImportingConstructor]
        public SampleInventoryAttachPlugin([Import] IInventoryManager inventory)
        {
            this.inventory = inventory;
        }

        [ItemBinding]
        public item_orchid Orchid { get; set; }

        protected override void OnActivate()
        {
            this.inventory.Attach(this);

            UpdateManager.Subscribe(this.OnUpdate);
        }

        private void OnUpdate()
        {
            if (this.Orchid != null)
            {
                Console.WriteLine(this.Orchid.Item.Name);
            }
        }
    }
}