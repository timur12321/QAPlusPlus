//
//  chal3.swift
//  chal
//
//  Created by Sam Ogunwe on 27/04/2016.
//
//
import Foundation

var all_tests: [String] = []


func testGen() {
    var cont = "Y"
    while  cont.lowercaseString == "y"{
        all_tests.removeAll()
        let tests: [String] = ["test1", "test2"]
        
        print("Enter OS's, sep by comma:")
        let opSys = readLine(stripNewline: true)
        let newOpSytems = opSys!.componentsSeparatedByString(", ")
        
        print("Enter Devices, sep by comma:")
        let device = readLine(stripNewline: true)
        let newDevice = device!.componentsSeparatedByString(", ")
        
        for test in tests{
            for ops in newOpSytems{
                for device in newDevice{
                    all_tests.append("\(test)"+" \(ops)"+" \(device)")
                    
                }
                
            }
        }
        for all_test in all_tests{
            print (all_test)
            
        }
        
        print("Start again Y/N?")
        cont = readLine(stripNewline: true)!
    }
    print ("Number of tests: \(all_tests.count)")
}


testGen()
