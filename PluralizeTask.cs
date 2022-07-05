using System;
namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
			// Напишите функцию склонения слова "рублей" в зависимости от предшествующего числительного count.
			count = Math.Abs(count) % 100;
			var lcount = count % 10;
			if (count >= 11 && count <= 19) return "рублей";
			if (lcount >= 2 && lcount <= 4) return "рубля";
			if (lcount == 1) return "рубль";
			else return "рублей";

		}
	}
}