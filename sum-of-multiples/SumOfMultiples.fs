module SumOfMultiples

let isMultipleOf numberToExamine list = List.exists (fun number -> numberToExamine % number = 0) list

let sum (numbers: int list) (upperBound: int): int = 
    [0..upperBound-1]
    |> List.filter (fun n -> isMultipleOf n numbers)
    |> List.sum