namespace Złożoność
{
    public class Algorytm1
    {
	    public void Sort1()
	    {
			int[] number = { 89, 76, 45, 92, 67, 12, 99 };
			var flag = true;
			int temp;
			var numLength = number.Length;
			//sorting an array
			for (var i = 1; (i <= (numLength - 1)) && flag; i++)
			{
				flag = false;
				for (var j = 0; j < (numLength - 1); j++)
				{
					if (number[j + 1] > number[j])
					{
						temp = number[j];
						number[j] = number[j + 1];
						number[j + 1] = temp;
						flag = true;
					}
				}
			}
	    }
    }
}
