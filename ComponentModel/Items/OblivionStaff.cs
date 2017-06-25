// <copyright file="OblivionStaff.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Items
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportItemComponent(AbilityId.item_oblivion_staff)]
    public class OblivionStaff : IItemComponent
    {
        [ImportingConstructor]
        public OblivionStaff([Import] IServiceContext context)
            : this(context, new ItemComponent(context, AbilityId.item_oblivion_staff))
        {
        }

        public OblivionStaff([Import] IServiceContext context, IItemComponent item)
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