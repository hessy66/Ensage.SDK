// <copyright file="PhantomAssassinStiflingDagger.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_phantom_assassin
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.phantom_assassin_stifling_dagger)]
    public class PhantomAssassinStiflingDagger : IAbilityComponent
    {
        [ImportingConstructor]
        public PhantomAssassinStiflingDagger([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.phantom_assassin_stifling_dagger))
        {
        }

        public PhantomAssassinStiflingDagger(IServiceContext context, IAbilityComponent ability)
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