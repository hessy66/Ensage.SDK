// <copyright file="TuskFrozenSigil.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_tusk
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.tusk_frozen_sigil)]
    public class TuskFrozenSigil : IAbilityComponent
    {
        [ImportingConstructor]
        public TuskFrozenSigil([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.tusk_frozen_sigil))
        {
        }

        public TuskFrozenSigil(IServiceContext context, IAbilityComponent ability)
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