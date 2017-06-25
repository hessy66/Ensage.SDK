// <copyright file="ChannableComponent.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Components
{
    public class ChannableComponent : IChannableComponent
    {
        public float Duration { get; }

        public bool IsChanneling { get; }

        public float RemainingDuration { get; }
    }
}