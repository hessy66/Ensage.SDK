// <copyright file="PugnaLifeDrain.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_pugna
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.pugna_life_drain)]
    public class PugnaLifeDrain : IAbilityComponent
    {
        [ImportingConstructor]
        public PugnaLifeDrain([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.pugna_life_drain))
        {
        }

        public PugnaLifeDrain(IServiceContext context, IAbilityComponent ability)
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