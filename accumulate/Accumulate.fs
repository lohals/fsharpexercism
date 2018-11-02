module Accumulate

let accumulate (func: 'a -> 'b) (input: 'a list): 'b list = 
    [for n in input -> func n]