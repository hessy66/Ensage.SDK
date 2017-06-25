// <copyright file="TemplarAssassinPsiBlades.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_templar_assassin
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.templar_assassin_psi_blades)]
    public class TemplarAssassinPsiBlades : IAbilityComponent
    {
        [ImportingConstructor]
        public TemplarAssassinPsiBlades([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.templar_assassin_psi_blades))
        {
        }

        public TemplarAssassinPsiBlades(IServiceContext context, IAbilityComponent ability)
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