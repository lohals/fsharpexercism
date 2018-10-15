module Raindrops

let vocabulary = [
    (3,"Pling")
    (5,"Plang")
    (7,"Plong")
    ]

let hasFactor factor number = (number % factor = 0)


let convert (number: int): string =
 
    let convertToKnownString number (factor, output)  = 
        if hasFactor factor number 
        then output 
        else ""
    vocabulary
    |> List.map (convertToKnownString number)
    |> List.reduce (+) 
    |> function
        | "" -> number.ToString()
        | output -> output