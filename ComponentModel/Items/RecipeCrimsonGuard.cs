// <copyright file="RecipeCrimsonGuard.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Items
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportItemComponent(AbilityId.item_recipe_crimson_guard)]
    public class RecipeCrimsonGuard : IItemComponent
    {
        [ImportingConstructor]
        public RecipeCrimsonGuard([Import] IServiceContext context)
            : this(context, new ItemComponent(context, AbilityId.item_recipe_crimson_guard))
        {
        }

        public RecipeCrimsonGuard([Import] IServiceContext context, IItemComponent item)
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