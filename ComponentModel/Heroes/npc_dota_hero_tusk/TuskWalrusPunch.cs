// <copyright file="TuskWalrusPunch.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_tusk
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.tusk_walrus_punch)]
    public class TuskWalrusPunch : IAbilityComponent
    {
        [ImportingConstructor]
        public TuskWalrusPunch([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.tusk_walrus_punch))
        {
        }

        public TuskWalrusPunch(IServiceContext context, IAbilityComponent ability)
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