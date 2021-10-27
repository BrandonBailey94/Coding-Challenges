/*
C++ language

Given a fixed-length integer array arr, duplicate each occurrence of zero, shifting the remaining elements to the right.

Note that elements beyond the length of the original array are not written. Do the above modifications to the input array in place and do not return anything.

Example 1:
    Input: arr = [1,0,2,3,0,4,5,0]
    Output: [1,0,0,2,3,0,0,4]
    Explanation: After calling your function, the input array is modified to: [1,0,0,2,3,0,0,4]

Example 2:
    Input: arr = [1,2,3]
    Output: [1,2,3]
    Explanation: After calling your function, the input array is modified to: [1,2,3]
*/

class Solution {
public:
    void duplicateZeros(vector<int>& arr) {
        for (int i = 0; i < arr.size(); i++) {
            if (arr[i] == 0) {
                for(int j = arr.size() - 2; j >= i; j--) {
                    arr[j+1] = arr[j];
                }
                i++;
            }
        }
    }
};