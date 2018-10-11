module Raindrops

let vocabulary = [
    (3,"Pling");
    (5,"Plang");
    (7,"Plong")
    ]
let hasFactor factor number = (number % factor = 0)

let convertToKnownString (factor, output) number = 
    if hasFactor factor number 
    then output 
    else ""

let convert (number: int): string = 
    vocabulary
    |> List.map (fun vocab -> convertToKnownString vocab number)
    |> List.reduce (+) 
    |> function
        | "" -> number.ToString()
        | output -> output