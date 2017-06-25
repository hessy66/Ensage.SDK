// <copyright file="SampleComponentPlugin.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.Samples
{
    using System.ComponentModel.Composition;
    using System.Linq;
    using System.Reflection;

    using Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_pudge;
    using Ensage.SDK.Helpers;
    using Ensage.SDK.Service;
    using Ensage.SDK.Service.Metadata;

    using log4net;

    using PlaySharp.Toolkit.Logging;

    [ExportPlugin("SampleComponentPlugin", HeroId.npc_dota_hero_pudge)]
    public class SampleComponentPlugin : Plugin
    {
        private static readonly ILog Log = AssemblyLogs.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [ImportingConstructor]
        public SampleComponentPlugin([Import] IServiceContext context, [Import] Pudge hero)
        {
            this.Context = context;
            this.Hero = hero;
        }

        public IServiceContext Context { get; }

        public Pudge Hero { get; }

        protected override void OnActivate()
        {
            UpdateManager.Subscribe(this.OnUpdate);
        }

        protected override void OnDeactivate()
        {
            UpdateManager.Unsubscribe(this.OnUpdate);
        }

        private void OnUpdate()
        {
            if (!this.Hero.MeatHook.CanBeCasted)
            {
                return;
            }

            var target = this.Context.TargetSelector.Value.Active.GetTargets().FirstOrDefault(e => this.Hero.MeatHook.CanHit(e));

            if (target != null)
            {
                if (this.Hero.MeatHook.UseAbility(target))
                {
                    Log.Info($"HOOK ~~~~~~~~~~~~~~()> {target.Name}");
                }
            }
        }
    }
}