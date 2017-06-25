// <copyright file="NecrolyteSadist.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_necrolyte
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.necrolyte_sadist)]
    public class NecrolyteSadist : IAbilityComponent
    {
        [ImportingConstructor]
        public NecrolyteSadist([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.necrolyte_sadist))
        {
        }

        public NecrolyteSadist(IServiceContext context, IAbilityComponent ability)
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