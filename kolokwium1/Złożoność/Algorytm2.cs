namespace Złożoność
{
	public class Algorytm2
	{
		public static void Sort(int[] input, int left, int right)
		{
			if (left < right)
			{
				int q = Partition(input, left, right);
				Sort(input, left, q - 1);
				Sort(input, q + 1, right);
			}
		}

		private static int Partition(int[] input, int left, int right)
		{
			var pivot = input[right];
			int temp;

			var i = left;
			for (var j = left; j < right; j++)
			{
				if (input[j] <= pivot)
				{
					temp = input[j];
					input[j] = input[i];
					input[i] = temp;
					i++;
				}
			}

			input[right] = input[i];
			input[i] = pivot;

			return i;
		}
	}
}