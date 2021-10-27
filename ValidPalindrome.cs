/*
C++ language

Given a string s, return true if the s can be palindrome after deleting at most one character from it.

 

Example 1:
    Input: s = "aba"
    Output: true

Example 2:
    Input: s = "abca"
    Output: true
    Explanation: You could delete the character 'c'.

Example 3:
    Input: s = "abc"
    Output: false

*/

class Solution {
public:
    
    bool check(string A, int start, int end){
        while(start<=end){
            if(A[start] != A[end]){
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
    
    bool validPalindrome(string A) {
        int start = 0;
        int end = A.size()-1;
        
        
        while(start<=end){
            if(A[start] != A[end]) {
                // 2 cases
                // delete a check for A[start+1....end]
                // delete e check for A[start....end-1]
                if(check(A, start+1, end) || check(A, start, end-1)){
                    return true;
                } else {
                    //after deleting 1 char we are unable to obtain a palindrome string
                    return false;
                }
            }
            start++;
            end--;
        }
        
        //string is already a palindrome
        return true;
    }
};