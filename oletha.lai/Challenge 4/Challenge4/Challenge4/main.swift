//
//  main.swift
//  Challenge4
//
//  Created by oletha on 09/05/2016.
//  Copyright © 2016 oletha. All rights reserved.
//

import Foundation

///// Recursive function to calculate factorial.
//func recursiveFactorial(n: UInt) -> UInt {
//    if n == 1 {
//        return 1
//    } else if n < 1 {
//        print("Invalid input")
//        return 0
//    }
//    return n * recursiveFactorial(n-1)
//}
//
///// Looping function to calculate factorial.
//func loopingFactorial(n: UInt) -> UInt {
//    var total: UInt = 1
//    if n < 1 {
//        print("Invalid input")
//        return 0
//    }
//    for i in 1...n {
//        total = total * i
//    }
//    return total
//}
//
//let n: UInt = 4
//print(recursiveFactorial(n))
//print(loopingFactorial(n))

extension String {

    /// Remove whitespace from either end of a string and return the new string.
    func strip() -> String {
        return self.stringByTrimmingCharactersInSet(
            NSCharacterSet.whitespaceAndNewlineCharacterSet()
        )
    }

}

/// Retrieve user input.
func getUserInput() -> [[String]] {

    // Get input for OSs
    print("Enter OSs, comma-separated")
    let os_input = readLine()

    // Get input for browsers
    print("Enter browsers, comma-separated")
    let browser_input = readLine()

    // Array-ify inputs
    let operatingSystems = os_input?.characters.split{$0 == ","}.map(String.init)
    let browsers = browser_input?.characters.split{$0 == ","}.map(String.init)

    var result: [[String]] = []

    if operatingSystems != nil {
        result.append(operatingSystems!)
    }
    if browsers != nil {
        result.append(browsers!)
    }

    return result
}

/// Combines two strings to make a "test case".
func combineStrings(a: String, b: String) -> String {
    return "\(a.strip()) / \(b.strip())"
}

/// Uses recursion to generate combinations from a 2D array.
func generateCombinations(array: [String], const: String) -> [String] {
    if array.isEmpty {
        return [String]()
    }
    let result = [combineStrings(array[0], b: const)]
    var newArray = array
    newArray.removeFirst()
    return result + generateCombinations(newArray, const: const)
}

let inputs = getUserInput()
var scenarios: [String] = []
for i in 0..<inputs[0].count {
    scenarios += generateCombinations(inputs[1], const: inputs[0][i])
}

// Print combinations
print("")
var i = 0
while i < scenarios.count {
    print("\(i+1). \(scenarios[i])")
    i += 1
}

// Print number of combinations
print("Scenarios: \(scenarios.count)")