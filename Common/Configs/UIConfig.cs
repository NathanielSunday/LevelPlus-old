// Copyright (c) Bitwiser.
// Licensed under the Apache License, Version 2.0.

using System.ComponentModel;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace LevelPlus.Common.Configs;

// ReSharper disable file InconsistentNaming
public class UIConfig : ModConfig
{
  public override ConfigScope Mode => ConfigScope.ClientSide;
  public static UIConfig Instance => ModContent.GetInstance<UIConfig>();


  [DefaultValue(480)] [ReloadRequired] public int XpBarLeft;
  [DefaultValue(35)] [ReloadRequired] public int XpBarTop;
  [DefaultValue(35)] [ReloadRequired] public int SpendUILeft;
  [DefaultValue(200)] [ReloadRequired] public int SpendUITop;
}