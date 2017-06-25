// <copyright file="FurionForceOfNature.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_furion
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.furion_force_of_nature)]
    public class FurionForceOfNature : IAbilityComponent
    {
        [ImportingConstructor]
        public FurionForceOfNature([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.furion_force_of_nature))
        {
        }

        public FurionForceOfNature(IServiceContext context, IAbilityComponent ability)
        {
            this.Context = context;
            this.Ability = ability;
        }

        public IAbilityComponent Ability { get; }

        public IServiceContext Context { get; }

        public Ability Instance
        {
            get
            {
                return this.Ability.Instance;
            }
        }
    }
}