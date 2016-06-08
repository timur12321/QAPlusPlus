#!usr/bin/swift


print("Please enter something")
let input = readLine()


print("you enter: \(input)")

// If case
if (input == "Monday") {
    
    print ("yes it is monday")
    
}else if(input == "Tuesday"){
    
    print ("yes it is tuesday")
}else {
    print("its fools day")
}


let input2 = readLine()


// Switch case

if let i = input2 {
    
    switch i.lowercaseString {
        
    case "wednesday" :
        print("its Wednesday")
        
    case "wednesday" :
        print("its Thursday")
    default :
        print("Sunny day")
    }
    
} else {
    print("you put nothing :(")
}