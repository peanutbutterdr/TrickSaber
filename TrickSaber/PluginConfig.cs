﻿namespace TrickSaber
{
    public class PluginConfig
    {
        public static PluginConfig Instance { get; set; }

        public string TriggerAction { get; set; } = TrickAction.Throw.ToString();

        public string GripAction { get; set; } = TrickAction.None.ToString();

        public string ThumbstickAction { get; set; } = TrickAction.Spin.ToString();

        public string ThumstickDirection { get; set; } = ThumstickDir.Horizontal.ToString();

        public float TriggerThreshold { get; set; } = 0.8f;

        public float GripThreshold { get; set; } = 0.8f;

        public float ThumbstickThreshold { get; set; } = 0.8f;

        public float ControllerSnapThreshold { get; set; } = 0.3f;


        public float SpinSpeed { get; set; } = 1f;

        public string SpinDirection { get; set; } = SpinDir.Backward.ToString();

        public float ThrowVelocity { get; set; } = 1f;

        public bool EnableCuttingDuringTrick { get; set; } = false;
    }
}