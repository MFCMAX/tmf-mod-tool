using System;
using System.IO;
using TMF.Enums;
using TMF.Utils;

namespace TMF.Structs.OtherStructs
{
	// Token: 0x0200000F RID: 15
	public class PriceList
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0000EDFE File Offset: 0x0000CFFE
		// (set) Token: 0x0600008B RID: 139 RVA: 0x0000EE06 File Offset: 0x0000D006
		public PriceListType Type { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600008C RID: 140 RVA: 0x0000EE0F File Offset: 0x0000D00F
		// (set) Token: 0x0600008D RID: 141 RVA: 0x0000EE17 File Offset: 0x0000D017
		public Price[] Prices { get; set; }

		// Token: 0x0600008E RID: 142 RVA: 0x0000EE20 File Offset: 0x0000D020
		public PriceList()
		{
			Price[] array = new Price[Globals.ItemData.ArrayOfItemDataXML.Length];
			Price price = default(Price);
			for (int i = 0; i < array.Length; i++)
			{
				price.Buy = Globals.ItemData.ArrayOfItemDataXML[i].MinCSPrice / 2;
				price.Sell = Globals.ItemData.ArrayOfItemDataXML[i].MinCSPrice;
				price.Perc = 50;
				price.UsePerc = true;
				price.ForSale = true;
				array[i] = price;
			}
			this.Prices = array;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000EEBC File Offset: 0x0000D0BC
		public static PriceList ReadPriceList(BinaryReader reader)
		{
			PriceList priceList = new PriceList();
			int num = reader.ReadInt32();
			if (num == 0)
			{
				return null;
			}
			priceList.Type = PriceListType.PlayerDefault;
			for (int i = 0; i < num; i++)
			{
				Price price = new Price
				{
					Buy = reader.ReadInt32(),
					Sell = reader.ReadInt32(),
					Perc = reader.ReadInt32(),
					UsePerc = reader.ReadBoolean(),
					ForSale = reader.ReadBoolean()
				};
				if (i < priceList.Prices.Length)
				{
					priceList.Prices[i] = price;
				}
			}
			return priceList;
		}
	}
}
