// Copyright (c) Bitwiser.
// Licensed under the Apache License, Version 2.0.

using LevelPlus.Common.Configs.Stats;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace LevelPlus.Common.Players.Stats;

public class CharmPlayer : BaseStat
{
  private CharmConfig Config => ModContent.GetInstance<CharmConfig>();

  protected override object[] DescriptionArgs => new object[] { };
  public override string Id => "Charm";

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
    player.GetDamage(DamageClass.Summon) *= 1.00f + Value * Config.Damage;
    player.maxMinions += Value / Config.MinionCost;
    player.maxTurrets += Value / Config.SentryCost;
  }

  public override void ModifyFishingLevel(Item fishingRod, Item bait, ref float fishingLevel)
  {
    fishingLevel += Value * Config.Fishing;
  }
}
