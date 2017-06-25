// <copyright file="MiranaLeap.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_mirana
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.mirana_leap)]
    public class MiranaLeap : IAbilityComponent
    {
        [ImportingConstructor]
        public MiranaLeap([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.mirana_leap))
        {
        }

        public MiranaLeap(IServiceContext context, IAbilityComponent ability)
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