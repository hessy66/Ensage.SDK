// <copyright file="SoulBooster.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Items
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportItemComponent(AbilityId.item_soul_booster)]
    public class SoulBooster : IItemComponent
    {
        [ImportingConstructor]
        public SoulBooster([Import] IServiceContext context)
            : this(context, new ItemComponent(context, AbilityId.item_soul_booster))
        {
        }

        public SoulBooster([Import] IServiceContext context, IItemComponent item)
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