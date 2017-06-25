// <copyright file="ArcaneBoots.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Items
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportItemComponent(AbilityId.item_arcane_boots)]
    public class ArcaneBoots : IItemComponent
    {
        [ImportingConstructor]
        public ArcaneBoots([Import] IServiceContext context)
            : this(context, new ItemComponent(context, AbilityId.item_arcane_boots))
        {
        }

        public ArcaneBoots([Import] IServiceContext context, IItemComponent item)
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