// <copyright file="ShadowAmulet.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Items
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportItemComponent(AbilityId.item_shadow_amulet)]
    public class ShadowAmulet : IItemComponent
    {
        [ImportingConstructor]
        public ShadowAmulet([Import] IServiceContext context)
            : this(context, new ItemComponent(context, AbilityId.item_shadow_amulet))
        {
        }

        public ShadowAmulet([Import] IServiceContext context, IItemComponent item)
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