# -*- coding: utf-8 -*-
"""
Created on Tue Jun 13 19:04:35 2017

@author: norrisa

Assume s is a string of lower case characters.

Write a program that prints the number of times the string 'bob' occurs in s. 
For example, if s = 'azcbobobegghakl', then your program should print

Number of times bob occurs is: 2
"""
s = "azcbobobegghakl"
count = 0
for i in range(0,len(s)-2):
    # print(s[i])
    if s[i] == 'b' and s[i+1] == 'o' and s[i+2] == 'b':
        # print('a bob at',i,'to',i+2)
        count += 1
print ('Number of times bob occurs is:',count)
    