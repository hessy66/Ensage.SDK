// <copyright file="JakiroDualBreath.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_jakiro
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.jakiro_dual_breath)]
    public class JakiroDualBreath : IAbilityComponent
    {
        [ImportingConstructor]
        public JakiroDualBreath([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.jakiro_dual_breath))
        {
        }

        public JakiroDualBreath(IServiceContext context, IAbilityComponent ability)
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