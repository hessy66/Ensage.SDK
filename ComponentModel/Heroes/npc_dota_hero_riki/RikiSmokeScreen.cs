// <copyright file="RikiSmokeScreen.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_riki
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.riki_smoke_screen)]
    public class RikiSmokeScreen : IAbilityComponent
    {
        [ImportingConstructor]
        public RikiSmokeScreen([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.riki_smoke_screen))
        {
        }

        public RikiSmokeScreen(IServiceContext context, IAbilityComponent ability)
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