// Copyright (c) Bitwiser.
// Licensed under the Apache License, Version 2.0.

using System.ComponentModel;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace LevelPlus.Common.Configs;

public class PlayConfig : ModConfig
{
  public override ConfigScope Mode => ConfigScope.ServerSide;
  public static PlayConfig Instance => ModContent.GetInstance<PlayConfig>();
  
  [DefaultValue(true)] public bool ScalingEnabled;
  [DefaultValue(0.025f)] public float LevelScalar;
  
  [DefaultValue(true)] public bool RandomStartingWeapon;
  
  [DefaultValue(true)] public bool LossEnabled;
  [Range(0.01f, 1.00f)] [DefaultValue(0.10f)] public float LossAmount;
  
  [Range(10, 500)] [DefaultValue(100)] public int MaxLevel;
  [DefaultValue(3)] public int StartingPoints;
  
  [DefaultValue(2)] public int Points;
  [DefaultValue(1)] public int Life;
  [DefaultValue(0)] public int Mana;
}