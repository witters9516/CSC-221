# -*- coding: utf-8 -*-
"""
Created on Mon Sep 25 12:16:24 2017

@author: norrisa
"""

def findVowels(word):
    vowels = ['a', 'e', 'i', 'o', 'u']
    found = []
    for letter in word:
        if letter in vowels:
            print(letter)

def findVowelsV2(word):
    vowels = ['a', 'e', 'i', 'o', 'u']
    found = []
    for letter in word:
        if letter in vowels:
            if letter not in found:
                found.append(letter)
    print('Found vowels: ',end='')
    for vowel in found:
        print(vowel,end=',')
    print()

def testFindVowels():
    word = input('Provide a word to search for vowels: ')
    findVowels(word)