// <copyright file="KeeperOfTheLightSpiritForm.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_keeper_of_the_light
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.keeper_of_the_light_spirit_form)]
    public class KeeperOfTheLightSpiritForm : IAbilityComponent
    {
        [ImportingConstructor]
        public KeeperOfTheLightSpiritForm([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.keeper_of_the_light_spirit_form))
        {
        }

        public KeeperOfTheLightSpiritForm(IServiceContext context, IAbilityComponent ability)
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