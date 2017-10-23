# 9/20/17
# CSC 221 - M2 Tutorial 1
# Shawn Witter
# This program implements newtons method and bisection search.

import random
def main():
    print("Player Guessing Game\n")
    playerGuessingGame()
    print("\nComputer Guessing Game\n")
    computerGuessingGame()
    print("\nComputer versus Computer Guessing Game\n")
    ComputerPlaysItself()
def playerGuessingGame():
    #Variables
    playerGuessesLeft = 10
    playerGuess = -1
    computerNumber = random.randint(1,100)

    #Game Loop
    while playerGuess != computerNumber:
        try:
            #Input playerGuess
            playerGuess = int(input("What number do you guess?\t"))

            #Check Guess to see if it is correct, too high, or too low.
            if playerGuess == computerNumber:
                print("You guessed the number! it was " + str(computerNumber))
            else:
                if playerGuess < 1 or playerGuess > 100:
                    print("Your number must be between 1 and 100. Please try again.")
                else:
                    if playerGuess < computerNumber:
                        playerGuessesLeft -= 1
                        print("Incorrect! Your number was too low.")
                    else:
                        playerGuessesLeft -= 1
                        print("Incorrect! Your number was too high.")

            #Check to see how many guesses the player has left.
            if playerGuessesLeft == 0:
                playerGuess = computerNumber
                print("You failed to guess the number. The number was " + str(computerNumber))
        except:
            # Catch Errors
            print("You must enter an integer for your guess. Please try again.")

def computerGuessingGame():
    # Variables
    ComputerGuessesLeft = 10
    playerNumber = -1
    computerGuess = 0
    high = 100
    low = 1

    #Player number choice loop.
    while playerNumber == -1:
        try:
            playerNumber = int(input("Please enter an between 1 and 100 for the computer to guess.\t"))

            if playerNumber > 100 or playerNumber < 1:
                playerNumber = -1
                print("The number must be between 1 and 100")
        except:
            print("The number must be an integer!")

    #Display playerNumber
    print(playerNumber)

    #Game Loop
    while computerGuess != playerNumber:
        try:
            # Guesses 1 through 4 use bisection
            # Guesses 5 through 6 use random numbers
            # Guesses 7 through 8 use bisection
            # Guesses 9 through 10 use random numbers

            if ComputerGuessesLeft > 6:
                computerGuess = int(float((high + low) / 2))
            elif ComputerGuessesLeft > 4:
                computerGuess = random.randint(low, high)
            if ComputerGuessesLeft > 3:
                computerGuess = int(float((high + low) / 2))
            else:
                computerGuess = random.randint(low, high)

            #Display computerGuess
            print(computerGuess)

            #Check to see if the number was correct
            # or if it is too high or too low.
            if computerGuess == playerNumber:
                print("You guessed the number! it was " + str(playerNumber))
            else:
                if computerGuess < 1 or computerGuess > 100:
                    print("Your number must be between 1 and 100. Please try again.")
                else:
                    if computerGuess < playerNumber:
                        low = computerGuess
                        ComputerGuessesLeft -= 1
                        print("Incorrect! Your number was too low.")
                    else:
                        high = computerGuess
                        ComputerGuessesLeft -= 1
                        print("Incorrect! Your number was too high.")

            #Check to see if the computer has any guesses left.
            if ComputerGuessesLeft == 0:
                computerGuess = playerNumber
                print("You failed to guess the number. The number was " + str(playerNumber))
        except:
            # Catch Errors
            print("The Computer made an error.")


def ComputerPlaysItself():
    #Variables
    ComputerGuessesLeft = 10
    computerNumber = random.randint(1,100)
    computerGuess = 0
    high = 100
    low = 1

    #Display computerNumber
    print(computerNumber)

    #Game Loop
    while computerGuess != computerNumber:
        try:
            # Guesses 1 through 4 use bisection
            # Guesses 5 through 6 use random numbers
            # Guesses 7 through 8 use bisection
            # Guesses 9 through 10 use random numbers
            if ComputerGuessesLeft > 6:
                computerGuess = int(float((high + low) / 2))
            elif ComputerGuessesLeft > 4:
                computerGuess = random.randint(low, high)
            if ComputerGuessesLeft > 3:
                computerGuess = int(float((high + low) / 2))
            else:
                computerGuess = random.randint(low, high)

            #Display computerGuess
            print(computerGuess)

            #Check to see if the number was correct
            # or if it is too high or too low.
            if computerGuess == computerNumber:
                print("You guessed the number! It was " + str(computerNumber))
            else:
                if computerGuess < 1 or computerGuess > 100:
                    print("Your number must be between 1 and 100. Please try again.")
                else:
                    if computerGuess < computerNumber:
                        low = computerGuess
                        ComputerGuessesLeft -= 1
                        print("Incorrect! Your number was too low.")
                    else:
                        high = computerGuess
                        ComputerGuessesLeft -= 1
                        print("Incorrect! Your number was too high.")

            #Check to see if the computer has any guesses left.
            if ComputerGuessesLeft == 0:
                computerGuess = computerNumber
                print("You failed to guess the number. The number was " + str(computerNumber))
        except:
            # Catch Errors
            print("The Computer made an error.")

main()
