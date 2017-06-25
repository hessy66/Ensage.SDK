// <copyright file="RecipeMagicWand.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Items
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportItemComponent(AbilityId.item_recipe_magic_wand)]
    public class RecipeMagicWand : IItemComponent
    {
        [ImportingConstructor]
        public RecipeMagicWand([Import] IServiceContext context)
            : this(context, new ItemComponent(context, AbilityId.item_recipe_magic_wand))
        {
        }

        public RecipeMagicWand([Import] IServiceContext context, IItemComponent item)
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