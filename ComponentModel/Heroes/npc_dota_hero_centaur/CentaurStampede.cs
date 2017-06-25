// <copyright file="CentaurStampede.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_centaur
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.centaur_stampede)]
    public class CentaurStampede : IAbilityComponent
    {
        [ImportingConstructor]
        public CentaurStampede([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.centaur_stampede))
        {
        }

        public CentaurStampede(IServiceContext context, IAbilityComponent ability)
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