import random
print('*************WELCOME TO MY GUESSING GAME************')
print()
play = input("PS: PLEASE READ THE INSTRUCTIONS BELOW BEFORE STARTING THE GAME." 
             "\n(A) You're to begin by guessing any random word you can think of. Hints will be given to you after your guess."
             "\n(B) Letters from your guess which are in the secretword will be shown to you and the others will be replaced by an un\n    derscore."
             "\n(C) Your guess must only contain a specified amount of letters (same amount of letters as the secretword)"
             "\n    (HINT AS TO THE NUMBER OF LETTERS WHICH ARE IN THE SECRETWORD WILL BE GIVEN TO YOU AT THE START OF THE GAME)"
             "\n(D) Letters from your guess which are in the same position as the letters in the secretword will be indicated using uppercase letters"
             "\n(E) Pay careful attention as hints are only shown once (as per your guess)."
             "\n\nAre you ready to play?(YES/NO) ")
print()

# options = ['woman', 'dog', 'cat', 'nephi', 'president', 'plane', 'food']
# words = random.choice(options)
# secretword = words
'---------------------'
'---------------------'
guess = ''
keep_playing = 'yes'
'---------------------'
'---------------------'

if play.lower() == 'no':
    print('You can always come back to play anytime you feel like.')
elif play.lower() =='yes':
    while keep_playing.lower() == 'yes':
         
        options = ['woman', 'dog', 'cat', 'nephi', 'president', 'plane', 'food']
        words = random.choice(options)
        secretword = words

        guess_count = 0

        print('Your first hint is: {}'.format('_ ' * len(secretword)), end='')
        while guess.lower() != secretword.lower():
            print()
            guess = input('What is your guess? ')
            guess_count = guess_count + 1
            if len(secretword) != len(guess):
                print("Sorry, the guess must have the same number of letters as the secret word.\nIt's a {} letter word.".format(len(secretword)))
            elif (guess.lower() != secretword.lower()) and (len(secretword) == len(guess)):
                print('Your hint is: ', end='')
                for char, letter in zip(secretword, guess):
                    if letter.lower() in secretword.lower() and letter in char:
                        print('{} '.format(letter.upper()), end='')                  
                    elif letter.lower() in secretword.lower():
                        print('{} '.format(letter.lower()) , end='')                       
                    else:
                        print('_ ', end='')
            elif guess.lower() == secretword.lower():
                print('CORRECT!The word is {}'.format(secretword))
                
                   
        print('\nCongratulations! You guessed it!')
        print('you used {} guess(es).'.format(guess_count))
        print()
        
        keep_playing = input('Would you like to keep playing?(yes/no) ')
        print()
    else:
        if keep_playing.lower() == 'no':
            print('Thank you for playing.')

        else:
            print('error')
else:
    print('Invalid Input')
        

                
                
    



    

    
                