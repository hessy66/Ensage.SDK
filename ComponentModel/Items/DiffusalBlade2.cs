// <copyright file="DiffusalBlade2.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Items
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportItemComponent(AbilityId.item_diffusal_blade_2)]
    public class DiffusalBlade2 : IItemComponent
    {
        [ImportingConstructor]
        public DiffusalBlade2([Import] IServiceContext context)
            : this(context, new ItemComponent(context, AbilityId.item_diffusal_blade_2))
        {
        }

        public DiffusalBlade2([Import] IServiceContext context, IItemComponent item)
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