// <copyright file="InvokerSunStrike.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_invoker
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.invoker_sun_strike)]
    public class InvokerSunStrike : IAbilityComponent
    {
        [ImportingConstructor]
        public InvokerSunStrike([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.invoker_sun_strike))
        {
        }

        public InvokerSunStrike(IServiceContext context, IAbilityComponent ability)
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