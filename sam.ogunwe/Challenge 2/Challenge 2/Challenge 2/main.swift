#!/usr/bin/swift
import Foundation

print("Whats the day")
let response = readLine(stripNewline: true)



if let res = response{
    switch res.lowercaseString {
    case "monday" :
        print("mon")
    case "tuesday" :
        print("tue")
    case "wednesday" :
        print("wed")
    case "thursday" :
        print("thurs")
    case "friday" :
        print("fri")
    default :
        print("Thats not a day")
    }
} else {
    print("sdsdsds")
}
