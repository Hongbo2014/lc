namespace MyLC
{
    class BinarySearch
    {
        public int MyBinarySearch(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target) return mid;
                else if (nums[mid] > target) right = mid;
                else left = mid + 1;
            }

            if (nums[left] == target) return left;
            return -1;
        }
    }
}
