#!/usr/bin/swift

import Darwin

func getUserInput() -> String {
    // Take user input
    let input = readLine(stripNewline: true)

    // Print input
    if input == nil || input!.characters.count == 0 {
        // Talk or die
        print("Fine, I didn't want to chat either.")
        exit(1)
    }
    
    return input!
}

print("How old are you?")
var input = getUserInput()

switch Int(input) > 17 {
case true:
    print("You are an adult!")
default:
    print("Shouldn't you be in school?")
}

print("What day is it?")
input = getUserInput()

if input.lowercaseString == "friday" {
    print("It's Friday, Friday, gotta get down on Friday!")
} else {
    print("Nope!")
}

print("See ya!")