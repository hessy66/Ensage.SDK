// <copyright file="InventoryManager.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.Inventory
{
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.ComponentModel.Composition;
    using System.Linq;
    using System.Reflection;

    using Ensage.SDK.Extensions;
    using Ensage.SDK.Helpers;
    using Ensage.SDK.Inventory.Metadata;
    using Ensage.SDK.Service;

    using log4net;

    using PlaySharp.Toolkit.Logging;

    using Inventory = Ensage.Inventory;

    [ExportInventoryManager]
    public class InventoryManager : ControllableService, IInventoryManager
    {
        private static readonly ILog Log = AssemblyLogs.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private HashSet<InventoryItem> items;

        [ImportingConstructor]
        public InventoryManager([Import] IServiceContext context)
        {
            this.Owner = context.Owner;
            this.LastItems = new HashSet<InventoryItem>();
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public Inventory Inventory => this.Owner.Inventory;

        public HashSet<InventoryItem> Items
        {
            get
            {
                if (this.items == null)
                {
                    this.items = this.Inventory.Items.Select(item => new InventoryItem(item)).ToHashSet();
                }

                return this.items;
            }
        }

        public Unit Owner { get; }

        private HashSet<InventoryItem> LastItems { get; set; }

        public StockInfo GetStockInfo(AbilityId id, Team team = Team.Undefined)
        {
            if (team == Team.Undefined)
            {
                team = this.Owner.Team;
            }

            return Game.StockInfo.FirstOrDefault(e => e.AbilityId == id && e.Team == team);
        }

        protected override void OnActivate()
        {
            if (this.Owner.HasInventory)
            {
                UpdateManager.Subscribe(this.OnInventoryUpdate, 500);
                UpdateManager.SubscribeService(this.OnInventoryClear);
            }
        }

        protected override void OnDeactivate()
        {
            UpdateManager.Unsubscribe(this.OnInventoryUpdate);
            UpdateManager.Unsubscribe(this.OnInventoryClear);
        }

        private void OnInventoryClear()
        {
            this.items = null;
        }

        private void OnInventoryUpdate()
        {
            if (this.CollectionChanged != null)
            {
                // TODO: investigate arc ult item changes
                var added = this.Items.Except(this.LastItems).ToList();
                var removed = this.LastItems.Except(this.Items).ToList();

                foreach (var change in added)
                {
                    Log.Debug($"Added {change.Id}");
                }

                foreach (var change in removed)
                {
                    Log.Debug($"Removed {change.Id}");
                }

                if (removed.Count > 0)
                {
                    this.CollectionChanged.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, removed));
                }

                if (added.Count > 0)
                {
                    this.CollectionChanged.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, added));
                }

                this.LastItems = this.Items;
            }
        }
    }
}