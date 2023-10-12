// See https://aka.ms/new-console-template for more information
//bubbl sort

int[] nums = { 1, 23, 5, 65, 1, 4 };
for (int i = 0; i < nums.Length; i++)
{
    for (int j = 0; j < nums.Length; j++)
    {
        if (nums[i] == nums[j])
        {
            int num=0;
            int = nums[i];
            nums[i] = nums[j];
            nums[j] = num;

        }

    }
    Console.Write(i + "");
}
