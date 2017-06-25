// <copyright file="AbilityComponent.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Components
{
    using Ensage.Common.Extensions;
    using Ensage.SDK.Service;

    using PlaySharp.Toolkit.Helper.Annotations;

    public class AbilityComponent : EntityComponent<Ability>, IAbilityComponent
    {
        public AbilityComponent([NotNull] IServiceContext context, [NotNull] Ability ability)
            : base(context, ability)
        {
        }

        public AbilityComponent([NotNull] IServiceContext context, AbilityId id)
            : base(context, context.Owner.GetAbilityById(id))
        {
        }
    }
}