// <copyright file="KeeperOfTheLightSpiritFormIlluminateEnd.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_keeper_of_the_light
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.keeper_of_the_light_spirit_form_illuminate_end)]
    public class KeeperOfTheLightSpiritFormIlluminateEnd : IAbilityComponent
    {
        [ImportingConstructor]
        public KeeperOfTheLightSpiritFormIlluminateEnd([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.keeper_of_the_light_spirit_form_illuminate_end))
        {
        }

        public KeeperOfTheLightSpiritFormIlluminateEnd(IServiceContext context, IAbilityComponent ability)
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