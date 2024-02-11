// Copyright (c) Bitwiser.
// Licensed under the Apache License, Version 2.0.

using LevelPlus.Common.Configs.Stats;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace LevelPlus.Common.Players.Stats;

public class BrawnPlayer : BaseStat
{
  private BrawnConfig Config => ModContent.GetInstance<BrawnConfig>();
  
  protected override object[] DescriptionArgs => new object[] { };
  public override string Id => "Brawn";

  public override bool IsLoadingEnabled(Mod mod) => true;

  public override void Load(Mod mod)
  {
    ModContent.GetInstance<StatPlayer>().RegisterStat(this);
  }

  public override void SaveData(TagCompound tag)
  {
  }

  public override void LoadData(TagCompound tag)
  {
  }

  public override void ModifyPlayer(ref Player player)
  {
    player.GetDamage(DamageClass.Melee) *= 1.00f + (Value * Config.Damage);
    player.pickSpeed *= 1.00f + (Value * Config.PickSpeed);
    //diminish
    player.wingTimeMax += (int)(player.wingTimeMax * Config.MaxWingTime * Value);
  }
}