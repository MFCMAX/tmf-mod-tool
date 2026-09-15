using System;

namespace TMF.Utils
{
	// Token: 0x02000033 RID: 51
	public static class StringUtils
	{
		// Token: 0x06000219 RID: 537 RVA: 0x0001173C File Offset: 0x0000F93C
		public static string InsertSpacesBeforeCapitals(string s)
		{
			if (s == null || s.Length < 1)
			{
				return s;
			}
			string text = string.Empty + s[0];
			bool flag = true;
			bool flag2 = true;
			char c = '_';
			for (int i = 1; i < s.Length; i++)
			{
				char c2 = s[i];
				bool flag3 = char.IsUpper(c2);
				bool flag4 = char.IsDigit(c2);
				if (c != ' ' && ((flag3 && !flag) || (flag4 && !flag2)))
				{
					text += ' ';
				}
				flag = flag3;
				flag2 = flag4;
				c = c2;
				text += c2;
			}
			return text;
		}
	}
}
