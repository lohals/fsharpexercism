module TwoFer

let twoFer (input: string option): string = 
    match input with
        | _ when input.IsNone -> "One for you, one for me."
        | _ -> sprintf "One for %s, one for me." input.Value