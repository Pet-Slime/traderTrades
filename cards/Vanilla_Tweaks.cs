using DiskCardGame;
using InscryptionAPI.Card;
using InscryptionAPI.Helpers;

namespace traderTrades.cards
{
	public static class Vanilla_Tweaks
	{
		public static void AddCard()
		{


			CardInfo cardInfo = CardManager.BaseGameCards.CardByName("CatUndead");
			cardInfo.metaCategories.Add(CardMetaCategory.TraderOffer);
			cardInfo.cost = 0;
			cardInfo.bonesCost = 9;
			Plugin.Log.LogWarning("The Trader now Sells: " + cardInfo.name);

			cardInfo = CardManager.BaseGameCards.CardByName("BaitBucket");
			cardInfo.metaCategories.Add(CardMetaCategory.TraderOffer);
			cardInfo.bonesCost = 5;
			cardInfo.DefaultAbilities.Add(Ability.IceCube);
			cardInfo.iceCubeParams = new IceCubeParams();
			cardInfo.iceCubeParams.creatureWithin = CardLoader.GetCardByName("Shark");
			Plugin.Log.LogWarning("The Trader now Sells: " + cardInfo.name);

			cardInfo = CardManager.BaseGameCards.CardByName("Dam");
			cardInfo.metaCategories.Add(CardMetaCategory.TraderOffer);
			cardInfo.DefaultAbilities.Add(Ability.IceCube);
			cardInfo.iceCubeParams = new IceCubeParams();
			cardInfo.iceCubeParams.creatureWithin = CardLoader.GetCardByName("Beaver");
			cardInfo.cost = 2;
			Plugin.Log.LogWarning("The Trader now Sells: " + cardInfo.name);

			cardInfo = CardManager.BaseGameCards.CardByName("DausBell");
			cardInfo.metaCategories.Add(CardMetaCategory.TraderOffer);
			Plugin.Log.LogWarning("The Trader now Sells: " + cardInfo.name);

			cardInfo = CardManager.BaseGameCards.CardByName("Smoke");
			cardInfo.metaCategories.Add(CardMetaCategory.TraderOffer);
			cardInfo.evolveParams = new EvolveParams
			{
				turnsToEvolve = 1,
				evolution = CardLoader.GetCardByName("Smoke_Improved")
			};
			Plugin.Log.LogWarning("The Trader now Sells: " + cardInfo.name);

			cardInfo = CardManager.BaseGameCards.CardByName("TrapFrog");
			cardInfo.metaCategories.Add(CardMetaCategory.TraderOffer);
			Plugin.Log.LogWarning("The Trader now Sells: " + cardInfo.name);

			cardInfo = CardManager.BaseGameCards.CardByName("Rabbit");
			cardInfo.metaCategories.Add(CardMetaCategory.TraderOffer);
			Plugin.Log.LogWarning("The Trader now Sells: " + cardInfo.name);

			cardInfo = CardManager.BaseGameCards.CardByName("Boulder");
			cardInfo.metaCategories.Add(CardMetaCategory.TraderOffer);
			Plugin.Log.LogWarning("The Trader now Sells: " + cardInfo.name);

		}
	}
}