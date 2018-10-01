module Grains
open System

let powOf2 input:uint64 = uint64 (Math.Pow(float 2, float input))

let square (n: int): Result<uint64,string> = 
    match n with
    | 0 | -1 -> Error "Invalid input"
    | _ -> 
        if n > 64 then Error "Invalid input"
        else 
            uint64 (n - 1)
            |> powOf2
            |> Ok

let total: Result<uint64,string> = 
    [0UL..64UL]
    |> Seq.sumBy powOf2
    |> Ok