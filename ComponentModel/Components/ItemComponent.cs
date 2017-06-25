// <copyright file="ItemComponent.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Components
{
    using Ensage.SDK.Extensions;
    using Ensage.SDK.Service;

    using PlaySharp.Toolkit.Helper.Annotations;

    public class ItemComponent : EntityComponent<Item>, IItemComponent
    {
        public ItemComponent([NotNull] IServiceContext context, [NotNull] Item item)
            : base(context, item)
        {
        }

        public ItemComponent([NotNull] IServiceContext context, AbilityId id)
            : base(context, context.Owner.GetItemById(id))
        {
        }
    }
}