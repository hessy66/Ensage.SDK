// <copyright file="VengefulspiritWaveOfTerror.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_vengefulspirit
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.vengefulspirit_wave_of_terror)]
    public class VengefulspiritWaveOfTerror : IAbilityComponent
    {
        [ImportingConstructor]
        public VengefulspiritWaveOfTerror([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.vengefulspirit_wave_of_terror))
        {
        }

        public VengefulspiritWaveOfTerror(IServiceContext context, IAbilityComponent ability)
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