# -*- coding: utf-8 -*-
"""
Created on Mon Sep 25 08:57:10 2017

@author: norrisa
"""

# 9/25 m2, recursive cases

def main():
    print("main unimplemented")
    
def factI(n):
    
    """ assumes n is int > 0
    returns n! """
    result = 1
    while n > 1:
        result = result * n
        n = n - 1
    return result
 
def factR(n):
    """ assumes n is int > 0
    returns n! """
    if n == 1:
        return n
    else:
        return n*factR(n - 1)
    
def testFactorial():
    num = int(input("find the factorial of n = ? "))
    print ("iterative:",factI(num))
    print ("recursive:",factR(num))
    
def fib(n):
    """ assumes n is int > 0
    returns fibonacci of n"""
    if n == 0 or n == 1:
        return 1
    else:
        return fib(n-1) + fib(n-2)
    
def testFib():
    n = int(input("run fib() from 1 to ? "))
    for i in range(n+1):
        print('fib of',i,'=', fib(i))
    
     
def isPalindrome(s):
    """assumes s is a str
    returns True if letters in s form a palindrome, false otherwise.
    non-letters and capitalization are ignored. """
    
    def toChars(s):
        s = s.lower()
        letters = ''
        for c in s:
            if c in 'abcdefghijklmnopqrstuvwxyz':
                letters = letters + c
        print('letters only =',letters)
        return letters
    
    def isPal(s):
        print('  isPal called with',s)
        if len(s) <= 1:
            print('  About to return True from base case')
            return True
        else:
            return s[0] == s[-1] and isPal(s[1:-1])
            print('  About to return ',answer,' for ',sisPalin)
        
    return isPal(toChars(s))

def testIsPalindrome():
    phrase = input('Enter a phrase to test for palindrome nature? ')
    print("isPalindrome() =",isPalindrome(phrase))
    