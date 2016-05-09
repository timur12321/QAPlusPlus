#!/usr/bin/swift

import Darwin

func getOutOfHere(message: String) {
	print(message)
	print("I'm outta here. Terminating application.")
	exit(1)
}

func getUserInput() -> String {
	// Take user input
	let input = readLine(stripNewline: true)

	// Print input
	if input == nil || input!.characters.count == 0 {
		// Talk or die
		getOutOfHere("Why won't you talk to me? :(")
	}

	return input!
}

// Greet user
print("Hello! Say something. :)")

// Allow the user to engage in an exchange
getUserInput()

// Generate random numbers
let a = arc4random_uniform(10) + 1
let b = arc4random_uniform(10) + 1

// Ask a maths question
print("I knew you'd be on board. What's \(a) + \(b)? In base 10, of course. ;)")

// Get an answer
let answer = getUserInput()

// Marking time
if UInt32(answer) == a + b {
	print("That's right!")
} else {
	getOutOfHere("Wrong...")
}

// That's it
print("See ya!")

