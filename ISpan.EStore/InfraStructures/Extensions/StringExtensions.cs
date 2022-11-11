namespace ISpan.EStore.InfraStructures.Extensions
{
	public static class StringExtensions
	{
		public static int Toint(this string source, int defaultValue)
		{
			bool isInt = int.TryParse(source, out int number);
			return isInt ? number : defaultValue;
		}
	}
}
