# This program is a python version of the Mark V Addinator
# CSC 221 M1T1
# 9/9/2017
# Shawn Witter

import random

def main():
    MarkVLoop()


def MarkVLoop():
    Choice = "D"
    loop_Variable = 'y'
    
    while (loop_Variable != 'N'):
        # Print Menu
        print("MARK V ADDINATOR ONLINE\n")
        print("MAKE SELECTION:")
        print("A - ADD")
        print("B - ADD MORE")
        print("C - GAME")
        # Read Choice input
        Choice = input("Choice: ")


        if Choice == 'A' or Choice == 'a':
            #Call Add function
            Add()
            loop_Variable = input("Again?(Y/N)\t")    
        elif Choice == 'B' or Choice == 'b':       
            #Call AddMore function
            AddMore()
            loop_Variable = input("Again?(Y/N)\t")    
        elif Choice == 'C' or Choice == 'c':       
            #Call Game function
            Game()
            loop_Variable = input("Again?(Y/N)\t")
        else:
            print("INVALID ANSWER! Please Choose again.\n")

        #Check to see if the loop needs to be repeated.
        #If the user typed 'y' at the end of any of the cases, the loop will repeat.
        #If no, the loop runs this if statement to ensure the while loop will be false.
        if (loop_Variable == 'n' or loop_Variable == 'N'):
                print("Thank you for using the MARK V ADDINATOR!")
                print("Be sure to Pre-order the MARK VI at Mathstop Today!")
                print()
                loop_Variable = 'N'

#Asks the user for two numbers and adds them together. The results display to the screen.
def Add():
    valid = False
    while valid == False:
        try:
            #Variables For Case A
            total = 0
            first_Number = float(input("First Number?\t"))
            second_Number = float(input("Second Number?\t"))
        
            total = first_Number + second_Number
            print("Total:\t" + str(total))
            valid = True
        except:
            print("The value must be a float value. Please try again.\n")

#Asks the user for a first number and then a "next number".
#Keeps a running total while Displaying the total to the screen.
def AddMore():
    valid = False
    while valid == False:
        #Variables For Case B
        temp_Input = ""
        total = 0.0
        try:
            temp_Input = input("First Number?\t")
            temp_Number = float(temp_Input)
        
            total += temp_Number
        except:
            print("Invalid Number")
            # catch error
            # find loop

        #If the user types 'end' or 'END', the function ends.
        while temp_Input != "END":
            try:
                temp_Input = input("Next Number?\t")
                if temp_Input.upper() == "END":
                    print("Total:\t" + str(total))
                    temp_Input = "END"
                else:
                    temp_Number = float(temp_Input)
                    total += temp_Number
                valid = True
            except:
                if temp_Input == "TEN":
                    temp_Number = 10
                    total += temp_Number
                else:
                    print("Invalid Number")

#Picks a random number between a certain range and asks the user to guess what
#it is. If incorrect, the loop repeats.
def Game(): 
    #Variables For Case C
    preorder = "d"

    print("THIS FEATURE IS AVAILABLE TO PREORDER CUSTOMERS ONLY.\n");
    
    while preorder == "d":
        preorder = input("Have you Pro-oredered this feature?(Y/N)\t")
        
        if preorder == "y" or preorder == "Y":
            #Execute C
            #Generate random number;
            randomNum = random.randint(1,5)
            correct = "N"

            while correct == "N":
                temp_Input = input("Enter a number between 1 and 5:\t")
                temp_Number = float(temp_Input)
                if temp_Number == randomNum:
                    print("Correct!\t")
                    correct = "Y"
                else:
                    print("Incorrect!\t")
                    print("Please try again.\t")
        elif preorder == "n" or preorder == "N":
            print("THIS FEATURE IS AVAILABLE TO PREORDER CUSTOMERS ONLY.\n")
            print("ACCESS DENIED!\n")
        else:
            print("INVALID CHOICE!")
            preorder = "d"

main()
