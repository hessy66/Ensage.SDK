// <copyright file="NyxAssassinSpikedCarapace.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_nyx_assassin
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.nyx_assassin_spiked_carapace)]
    public class NyxAssassinSpikedCarapace : IAbilityComponent
    {
        [ImportingConstructor]
        public NyxAssassinSpikedCarapace([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.nyx_assassin_spiked_carapace))
        {
        }

        public NyxAssassinSpikedCarapace(IServiceContext context, IAbilityComponent ability)
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