// <copyright file="PhantomLancerSpiritLance.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_phantom_lancer
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.phantom_lancer_spirit_lance)]
    public class PhantomLancerSpiritLance : IAbilityComponent
    {
        [ImportingConstructor]
        public PhantomLancerSpiritLance([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.phantom_lancer_spirit_lance))
        {
        }

        public PhantomLancerSpiritLance(IServiceContext context, IAbilityComponent ability)
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