// <copyright file="MedallionOfCourage.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Items
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportItemComponent(AbilityId.item_medallion_of_courage)]
    public class MedallionOfCourage : IItemComponent
    {
        [ImportingConstructor]
        public MedallionOfCourage([Import] IServiceContext context)
            : this(context, new ItemComponent(context, AbilityId.item_medallion_of_courage))
        {
        }

        public MedallionOfCourage([Import] IServiceContext context, IItemComponent item)
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