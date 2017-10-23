# 9/20/17
# CSC 221 - M2 Tutorial 1
# Shawn Witter
# This program implements bisection search through
# the use of guessing games.

def main():
    Bronze()
    print("\n")
    Silver()
    print("\n")
    Gold()

# The Bronze method calculates the sqaure root of a
# number using brute force.
def Bronze():
    x = 25
    epsilon = 0.01
    step = epsilon ** 2
    numGuesses = 0
    ans = 0.0

    while abs(ans**2 - x) >= epsilon and ans <= x:
        ans += step
        numGuesses += 1
    print('numGuesses =', numGuesses)
    if abs(ans**2 - x) >= epsilon:
        print('Failed on square roof of', x)
    else:
        print(ans, 'is close to sqare root of', x)

# The Silver method calculates the square root of a
# number by using bisection.
def Silver():
    x = 25
    epsilon = 0.01
    numGuesses = 0
    low = 0.0
    high = max(1.0, x)
    ans = (high + low)/2.0

    while abs(ans**2 - x) >= epsilon:
        print('low = ', low, 'high = ', high, ' ans = ', ans)
        numGuesses += 1
        if ans ** 2 < x:
            low = ans
        else:
            high = ans
        ans = (high + low)/2.0        
    print('numGuesses =', numGuesses)
    if abs(ans**2 - x) >= epsilon:
        print('Failed on square roof of', x)
    else:
        print(ans, 'is close to sqare root of', x)

# The Gold method calculates using the pythagorean theorem of a
# 2 numbers.
def Gold():
    a = 10
    b = 11
    x = a**2 + b**2
    epsilon = 0.01
    numGuesses = 0
    low = 0.0
    high = max(1.0, x)
    ans = (high + low)/2.0

    while abs(ans**2 - x) >= epsilon:
        print('a = ', a, 'b = ', b, ' ans = ', ans)
        numGuesses += 1
        if ans ** 2 < x:
            low = ans
        else:
            high = ans
        ans = (high + low)/2.0        
    print('numGuesses =', numGuesses)
    if abs(ans**2 - x) >= epsilon:
        print('Failed on square roof of', x)
    else:
        print(ans, 'is close to sqare root of', x)

main()
