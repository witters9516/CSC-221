def main():
    TextParser()

def TextParser():
    #List of verbs to check.
    verbList = ["do", "go", "see", "walk", "jump",
                "run", "sprint", "ride", "write", "hand",
                "watch", "hear", "play", "speak", "type"]
    #List of nouns to check.
    nounList = ["home","computer","pencil","paper","building",
                "car","dollar","cash","check","school",
                "keyboard","room","book","show","screen", "work"]
    #Lists for words found that are nouns or verbs.
    verbFoundList = []
    nounFoundList = []

    #Prompt user for input.
    inputString = input("Please type a sentence:\t")

    #Set count to 1 because there has to be at least one word
    count = 1

    #Loop to count words.
    for char in inputString:
        if char == " ":
            count += 1
    #If the word count is bigger than one, this creates a tuple.
    if count >= 2:
        stringTuple = inputString.split(" ")

    #Loop to Check both verbList and nounList to see if
    #there are matching words.   
    for item in stringTuple:
        verbCount = 0
        nounCount = 0
        #Strip any punctuation
        item = item.rstrip(',')
        item = item.rstrip('.')
        item = item.rstrip('!')
        item = item.rstrip(',')
        item = item.rstrip('?')
        #Check verbs
        for item2 in verbList:
            if item.lower() == item2:
                verbFoundList.append(item)
                print("Verb Found: " + item)
                verbCount += 1
        #Check Nouns
        for item2 in nounList:
            if item.lower() == item2:
                nounFoundList.append(item)
                print("Noun Found: " + item)
                nounCount += 1
        #If neither type of word is found, it states that the word was neither.
        if verbCount == 0 and nounCount == 0:
            print("No verb or noun found for the word: " + item)
        else:
            #If the word was a noun, but not a verb, it
            #states that it wasn't that type of word.
            if verbCount == 0:
                print("No verb found for the word: " + item)
            #If the word was a verb, but not a noun, it
            #states that it wasn't that type of word.
            if nounCount == 0:
                print("No noun found for the word: " + item)

    #Display inputString to screen.
    print("\nString inputed: " + str(stringTuple))

    #Display words that were found that are considered nouns or verbs.
    print("\nNouns and Verbs Found:")
    print("The following verbs found are: " + str(verbFoundList))
    print("The following nouns found are: " + str(nounFoundList))
        
main()
