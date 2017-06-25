// <copyright file="RingOfBasilius.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Items
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportItemComponent(AbilityId.item_ring_of_basilius)]
    public class RingOfBasilius : IItemComponent
    {
        [ImportingConstructor]
        public RingOfBasilius([Import] IServiceContext context)
            : this(context, new ItemComponent(context, AbilityId.item_ring_of_basilius))
        {
        }

        public RingOfBasilius([Import] IServiceContext context, IItemComponent item)
        {
            this.Item = item;
        }

        public Item Instance
        {
            get
            {
                return this.Item.Instance;
            }
        }

        protected IItemComponent Item { get; }
    }
}