#!/usr/bin/swift

import Foundation

extension String {
	func strip() -> String {
		return self.stringByTrimmingCharactersInSet(
			NSCharacterSet.whitespaceAndNewlineCharacterSet()
		)
	}
}

// Get input for OSs
print("Enter OSs, comma-separated")
let os_input = readLine()

// Get input for browsers
print("Enter browsers, comma-separated")
let browser_input = readLine()

// Array-ify inputs
let oss = os_input?.characters.split{$0 == ","}.map(String.init)
let browsers = browser_input?.characters.split{$0 == ","}.map(String.init)

// Generate combinations
var scenarios: [String] = []
var i = 0
if let browsers = browsers, oss = oss {
    while i < oss.count {
        for browser in browsers {
            scenarios.append("OS: \(oss[i].strip()) / Browser: \(browser.strip())")
        }
        i += 1
    }
}

// Print combinations
print("")
i = 0
while i < scenarios.count {
	print("\(i+1). \(scenarios[i])")
	i += 1
}

// Print number of combinations
print("Scenarios: \(scenarios.count)")