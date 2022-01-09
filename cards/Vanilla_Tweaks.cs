using System;
using System.Collections.Generic;
using DiskCardGame;

namespace traderTrades.cards
{
	public static class Vanilla_Tweaks
	{
		public static void AddCard()
		{
			List<CardInfo> allData = ScriptableObjectLoader<CardInfo>.AllData;
			for (int i = 0; i < allData.Count; i++)
			{
				CardInfo cardInfo = allData[i];
				bool flag = cardInfo.name == "CatUndead";
				if (flag)
				{
					cardInfo.metaCategories.Add(CardMetaCategory.TraderOffer);
					cardInfo.cost = 0;
					cardInfo.bonesCost = 9;
					Plugin.Log.LogWarning("The Trader now Sells: " + cardInfo.name);
				}
				bool flag2 = cardInfo.name == "BaitBucket";
				if (flag2)
				{
					cardInfo.metaCategories.Add(CardMetaCategory.TraderOffer);
					cardInfo.bonesCost = 5;
					cardInfo.DefaultAbilities.Add(Ability.IceCube);
					cardInfo.iceCubeParams = new IceCubeParams
					{
						creatureWithin = CardLoader.GetCardByName("Shark")
					};
					Plugin.Log.LogWarning("The Trader now Sells: " + cardInfo.name);
				}
				bool flag3 = cardInfo.name == "Dam";
				if (flag3)
				{
					cardInfo.metaCategories.Add(CardMetaCategory.TraderOffer);
					cardInfo.DefaultAbilities.Add(Ability.IceCube);
					cardInfo.iceCubeParams = new IceCubeParams
					{
						creatureWithin = CardLoader.GetCardByName("Beaver")
					};
					cardInfo.cost = 1;
					Plugin.Log.LogWarning("The Trader now Sells: " + cardInfo.name);
				}
				bool flag4 = cardInfo.name == "DausBell";
				if (flag4)
				{
					cardInfo.metaCategories.Add(CardMetaCategory.TraderOffer);
					Plugin.Log.LogWarning("The Trader now Sells: " + cardInfo.name);
				}
				bool flag5 = cardInfo.name == "Smoke";
				if (flag5)
				{
					cardInfo.metaCategories.Add(CardMetaCategory.TraderOffer);
					cardInfo.evolveParams = new EvolveParams
					{
						turnsToEvolve = 1,
						evolution = CardLoader.GetCardByName("Smoke_Improved")
					};
					Plugin.Log.LogWarning("The Trader now Sells: " + cardInfo.name);
				}
				bool flag6 = cardInfo.name == "TrapFrog";
				if (flag6)
				{
					cardInfo.metaCategories.Add(CardMetaCategory.TraderOffer);
					Plugin.Log.LogWarning("The Trader now Sells: " + cardInfo.name);
				}
				bool flag7 = cardInfo.name == "Rabbit";
				if (flag7)
				{
					cardInfo.metaCategories.Add(CardMetaCategory.TraderOffer);
					Plugin.Log.LogWarning("The Trader now Sells: " + cardInfo.name);
				}
			}
		}
	}
}