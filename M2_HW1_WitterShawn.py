# This program answers 4 problems that require the use of pop and append.
# 10/1/17
# M2HW1
# Shawn Witter

def main():
    #Problem_1()
    #Problem_2()
    #Problem_3()
    Problem_4()

    
def Problem_1():
    #Create a list of vowels
    vowelsList = ['a', 'e', 'i', 'o', 'u']

    #Prompt user to enter a phrase.
    tempPhrase = input("Please enter a phrase:\t")

    #Turn the phrase into a list.
    tempList = tempPhrase.split(" ")

    #Nested to loop to find all vowels in the phrase.
    for item in tempList:
        print("Word: " + item)
        for ch in item:
            for ch2 in vowelsList:
                if ch.lower() == ch2:
                    print(ch + " found!")
        print()

def Problem_2():

    #Variable
    List = []

    #Append the directions to the list
    List.append("Turn right at the 1st cross street onto I-95BUS N")
    List.append("Turn right to merge onto NC-87 N")
    List.append("Continue onto NC-87 N/US-401 BUS N")
    List.append("Take the NC-24/NC-87/Bragg Blvd exit")
    List.append("Use the left 2 lanes to turn left onto NC-24 W/NC-87 N/Bragg Blvd")
    List.append("Turn left onto Barrington Cross St")
    List.append("Continue onto Devers St")
    List.append("Turn right onto Hull Rd")

    #Print out heading
    print("Directions to FTCC:\n")

    #Print out list
    for item in List:
        print(item)

    #Get index count
    count = 0
    for item in List:
        count += 1

    #Print out heading
    print("\nDirections back home:\n")

    #Using pop, Print out direction 
    for i in range(0,count,1):
        print(List.pop())

def Problem_3():
    #Variables
    minute = 5
    List = []

    for i in range(0, 60, 1):
        #reverse the list making it a "First in/First out"
        List.reverse()

        #Add in a customer at the minute they are supposed to arrive.
        if i == 1:
            List.append("Alice")
            print("Alice joins the queue at minute 1.")
        if i == 2:
            List.append("Bob")
            print("Bob joins the queue at minute 2.")
        if i == 7:
            List.append("Charles")
            print("Charles joins the queue at minute 7.")
        if i == 9:
            List.append("Dennis")
            print("Dennis joins the queue at minute 9.")
        if i == 10:
            List.append("Elise")
            print("Elise joins the queue at minute 10.")
        if i == 12:
            List.append("Fred")
            print("Fred joins the queue at minute 12.")
        if i == 20:
            List.append("George")
            print("George joins the queue at minute 20.")

        #Reverse the List to make it so that the original
        #first person is popped out.
        List.reverse()

        #If the minute is an increment of 5,
        #then serve the next person in line.
        if i == minute:
            print(List.pop() + " was served at minute " + str(minute) + ".")
            minute += 5
    

def Problem_4():
    #Variables
    PEG_1 = ["DISC B", "DISC A"]
    PEG_2 = []
    PEG_3 = []

    #Process to answer problem.
    #1. Disc A to peg 2 (peg 1 to peg 2)
    #2. Disc B to peg 3 (peg 1 to peg 3)
    #3. Disc A to peg 3 (peg 2 to peg 3)
    
    print("Begin Game")
    print("Peg 1: " + str(PEG_1))
    print("Peg 2: " + str(PEG_2))
    print("Peg 3: " + str(PEG_3))
    print()

    #1.
    disc_to_move = PEG_1.pop()
    PEG_2.append(disc_to_move)

    print("Peg 1: " + str(PEG_1))
    print("Peg 2: " + str(PEG_2))
    print("Peg 3: " + str(PEG_3))
    print()

    #2.
    disc_to_move = PEG_1.pop()
    PEG_3.append(disc_to_move)

    print("Peg 1: " + str(PEG_1))
    print("Peg 2: " + str(PEG_2))
    print("Peg 3: " + str(PEG_3))
    print()

    #3.
    disc_to_move = PEG_2.pop()
    PEG_3.append(disc_to_move)

    print("Peg 1: " + str(PEG_1))
    print("Peg 2: " + str(PEG_2))
    print("Peg 3: " + str(PEG_3))
    print()

main()
