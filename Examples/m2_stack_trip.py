# -*- coding: utf-8 -*-
"""
Created on Mon Sep 25 12:33:13 2017

@author: norrisa
"""

def roundTrip():
    stack = []
    # go to class
    stack.append('ATC 244B')
    stack.append('ATC 2nd floor hallway')
    stack.append('ATC stairs')
    stack.append('ATC 1st floor hallway')
    stack.append('ATC 117')
    
    # go back
    print('returning:')
    while len(stack) > 0:
        location = stack.pop()
        print(location)
    