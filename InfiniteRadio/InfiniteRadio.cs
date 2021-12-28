using System;
using Qurre;
using Qurre.API.Events;

namespace InfiniteRadio
{
    public class InfiniteRadio : Plugin
    {
        public override string Developer => "KoToXleB#4663";
        public override string Name => "InfiniteRadio";
        public override Version Version => new Version(1, 0, 0);
        public override int Priority => int.MinValue;
        public override void Enable() => RegisterEvents();
        public override void Disable() => UnregisterEvents();
        public Config CustomConfig { get; private set; }

        public void RegisterEvents()
        {
            CustomConfig = new Config();
            CustomConfigs.Add(CustomConfig);
            if (!CustomConfig.IsEnable) return;

            Qurre.Events.Player.RadioUsing += OnRadioUsing;
        }

        public void UnregisterEvents()
        {
            CustomConfigs.Remove(CustomConfig);
            if (!CustomConfig.IsEnable) return;

            Qurre.Events.Player.RadioUsing -= OnRadioUsing;
        }

        public static void OnRadioUsing(RadioUsingEvent ev)
        {
            ev.Battery = 100;
        }
    }
}
