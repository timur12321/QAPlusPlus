//
//  ch3_main.swift
//
//  Created by Vamsi Vendra on 29/04/2016.
//
//

let test: [String] = ["unit_test1", "unit_test2"]

print("Please enter browser seperated by coma")

let input1 = readLine(stripNewline: true)
//let eachbrowser = input1!.componentsSeparatedByString(",");
let eachbrowser = input1!.characters.split(",").map { String($0) }

print("Please enter OS seperated by coma")
let input2 = readLine(stripNewline: true)
let eachosr = input2!.characters.split(",").map { String($0) }

//let eachosr = input2!.componentsSeparatedByString(",");

var i=0
var suite: [String] = []
while i < eachbrowser.count   {
    
    for os in eachosr{
        
        suite.append("\(test)"+" \(eachosr)"+" \(eachbrowser)")
        print(test)
    }
    i+=1
}

for eachtest in suite{
    print(eachtest)
}

