// <copyright file="WispSpiritsOut.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_wisp
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.wisp_spirits_out)]
    public class WispSpiritsOut : IAbilityComponent
    {
        [ImportingConstructor]
        public WispSpiritsOut([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.wisp_spirits_out))
        {
        }

        public WispSpiritsOut(IServiceContext context, IAbilityComponent ability)
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