// <copyright file="TargetModifierComponent.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Components
{
    using Ensage.SDK.Service;

    public class TargetModifierComponent : ITargetModifierComponent
    {
        private IServiceContext context;

        private string v;

        public TargetModifierComponent(IServiceContext context)
        {
            this.context = context;
        }

        public TargetModifierComponent(IServiceContext context, string v)
            : this(context)
        {
            this.v = v;
        }

        public string TargetModifierName { get; }
    }
}