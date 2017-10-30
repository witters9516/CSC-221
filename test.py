def main():
    title = 'a clash of KINGS'
    minor_words = 'a an the of'
    
    officialTitle = title_case(title, minor_words)
    print(officialTitle)


def title_case(title, minor_words):
    # print(title)
    titleWordList = list()
    minorWordList = list()
    officialTitle = ""
    if title != '':
        print("Yorgy Shmorgy!")
        titleWordList = title.split(' ')
        print(titleWordList)
        minorWordList = minor_words.split(' ')
        print(minorWordList)
        #for i in titleWordList:
            #titleWordList[i].lowercase()
            #print(titleWordList[i])

    count1 = 0
    for item in titleWordList:
        count1 += 1
    print("Count1 = " + str(count1))

    count2 = 0
    for item in minorWordList:
        count2 += 1
    print("Count2 = " + str(count2))
    
    for item in range(0, count1, 1):
        for item2 in range(0, count2, 1):
            print(titleWordList[item] + " : " + minorWordList[item2])
            if titleWordList[item] == minorWordList[item2]:
                if item == 0:
                    officialTitle += titleWordList[item].title() + " "
                else:
                    titleWordList[item] == minorWordList[item2]
                    officialTitle += titleWordList[item] + " "
            else:
                if item == (count1 -1):
                    officialTitle += titleWordList[item].title()
                else:
                    officialTitle += titleWordList[item].title() + " "
                
                    
        

    return officialTitle

main()
