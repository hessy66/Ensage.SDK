// <copyright file="DazzlePoisonTouch.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_dazzle
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.dazzle_poison_touch)]
    public class DazzlePoisonTouch : IAbilityComponent
    {
        [ImportingConstructor]
        public DazzlePoisonTouch([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.dazzle_poison_touch))
        {
        }

        public DazzlePoisonTouch(IServiceContext context, IAbilityComponent ability)
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