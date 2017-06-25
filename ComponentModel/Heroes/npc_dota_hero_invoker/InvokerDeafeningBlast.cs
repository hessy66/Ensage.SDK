// <copyright file="InvokerDeafeningBlast.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_invoker
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.invoker_deafening_blast)]
    public class InvokerDeafeningBlast : IAbilityComponent
    {
        [ImportingConstructor]
        public InvokerDeafeningBlast([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.invoker_deafening_blast))
        {
        }

        public InvokerDeafeningBlast(IServiceContext context, IAbilityComponent ability)
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