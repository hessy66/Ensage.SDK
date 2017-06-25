// <copyright file="RikiPermanentInvisibility.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_riki
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.riki_permanent_invisibility)]
    public class RikiPermanentInvisibility : IAbilityComponent
    {
        [ImportingConstructor]
        public RikiPermanentInvisibility([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.riki_permanent_invisibility))
        {
        }

        public RikiPermanentInvisibility(IServiceContext context, IAbilityComponent ability)
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