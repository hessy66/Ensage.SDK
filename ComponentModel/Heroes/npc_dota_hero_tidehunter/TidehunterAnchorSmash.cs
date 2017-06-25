// <copyright file="TidehunterAnchorSmash.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_tidehunter
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.tidehunter_anchor_smash)]
    public class TidehunterAnchorSmash : IAbilityComponent
    {
        [ImportingConstructor]
        public TidehunterAnchorSmash([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.tidehunter_anchor_smash))
        {
        }

        public TidehunterAnchorSmash(IServiceContext context, IAbilityComponent ability)
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