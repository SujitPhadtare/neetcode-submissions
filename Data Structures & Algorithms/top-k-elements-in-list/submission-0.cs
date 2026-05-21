public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
                Dictionary<int, int> dc = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dc.TryGetValue(nums[i], out int freq))
            {
                dc[nums[i]] = freq+1;
            }
            else
            {
                dc[nums[i]] = 1;
            }
        }

        PriorityQueue<int, int> pq = new();
        int[] result = new int[k];
        foreach (var kvp in dc)
        {
            if(pq.Count < k){
            pq.Enqueue(kvp.Key, kvp.Value);
            }else if(pq.TryPeek(out int element, out int priority) && priority < kvp.Value){
                pq.Dequeue();
            pq.Enqueue(kvp.Key, kvp.Value);

            }
        }
        for (int i = 0; i < k; i++)
        {
            result[i] = pq.Dequeue();
        }

        return result;
    }
}
