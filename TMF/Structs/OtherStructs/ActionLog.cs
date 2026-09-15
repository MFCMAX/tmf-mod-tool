using System;
using System.IO;
using TMF.Enums;

namespace TMF.Structs.OtherStructs
{
	// Token: 0x0200004C RID: 76
	public class ActionLog
	{
		// Token: 0x060002A4 RID: 676 RVA: 0x00012650 File Offset: 0x00010850
		public void ReadState(BinaryReader reader)
		{
			int num = reader.ReadInt32();
			if (num > 0)
			{
				this.createmined();
				int num2 = 0;
				while (num2 < num && num2 < this.mined.Length)
				{
					this.mined[num2] = reader.ReadInt32();
					num2++;
				}
			}
			int num3 = reader.ReadInt32();
			int num4 = reader.ReadInt32();
			this.actions = null;
			if (num3 > 0 && num4 > 0)
			{
				this.LazyCreateActions();
				int num5 = 0;
				while (num5 < num3 && num5 < this.actions.GetLength(0))
				{
					int num6 = 0;
					while (num6 < num4 && num6 < this.actions.GetLength(1))
					{
						this.actions[num5, num6] = reader.ReadInt32();
						num6++;
					}
					num5++;
				}
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0001270C File Offset: 0x0001090C
		public void WriteState(BinaryWriter writer)
		{
			bool flag = false;
			if (this.mined != null)
			{
				foreach (int num in this.mined)
				{
					if (num > 0)
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				writer.Write(0);
			}
			else
			{
				writer.Write(this.mined.Length);
				foreach (int value in this.mined)
				{
					writer.Write(value);
				}
			}
			flag = false;
			if (this.actions != null)
			{
				int num2 = 0;
				while (num2 < this.actions.GetLength(0) && !flag)
				{
					int num3 = 0;
					while (num3 < this.actions.GetLength(1) && !flag)
					{
						if (this.actions[num2, num3] > 0)
						{
							flag = true;
						}
						num3++;
					}
					num2++;
				}
			}
			if (!flag)
			{
				writer.Write(0);
				writer.Write(0);
				return;
			}
			writer.Write(this.actions.GetLength(0));
			writer.Write(this.actions.GetLength(1));
			for (int k = 0; k < this.actions.GetLength(0); k++)
			{
				for (int l = 0; l < this.actions.GetLength(1); l++)
				{
					writer.Write(this.actions[k, l]);
				}
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00012863 File Offset: 0x00010A63
		private void createmined()
		{
			if (this.mined == null)
			{
				this.mined = new int[256];
			}
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0001287D File Offset: 0x00010A7D
		private void LazyCreateActions()
		{
			if (this.actions == null)
			{
				this.actions = new int[508, 4];
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00012898 File Offset: 0x00010A98
		public void RemoveAction(Item item, ItemAction action)
		{
			this.actions[(int)item, (int)action] = 0;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x000128A8 File Offset: 0x00010AA8
		public void AddAction(Item item, ItemAction action)
		{
			if (action == ItemAction.Mined)
			{
				if (item < Item.zLastBlockID)
				{
					this.createmined();
					this.mined[(int)item]++;
					return;
				}
			}
			else
			{
				this.LazyCreateActions();
				this.actions[(int)item, (int)action]++;
			}
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00012901 File Offset: 0x00010B01
		public bool HasAction(Item item, ItemAction action)
		{
			return this.GetAction(item, action) > 0;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0001290E File Offset: 0x00010B0E
		public int GetAction(Item item, ItemAction action)
		{
			if (action == ItemAction.Mined)
			{
				if (this.mined == null || item >= Item.zLastBlockID)
				{
					return 0;
				}
				return this.mined[(int)item];
			}
			else
			{
				if (this.actions == null)
				{
					return 0;
				}
				return this.actions[(int)item, (int)action];
			}
		}

		// Token: 0x040005A8 RID: 1448
		private int[] mined;

		// Token: 0x040005A9 RID: 1449
		private int[,] actions;
	}
}
