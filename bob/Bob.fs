module Bob

let isAllCaps (input:string) = input = (input.ToUpper())

let response (input: string): string = 
    match input with
    | _ when input |> Seq.forall System.Char.IsWhiteSpace -> "Fine. Be that way!"
    | _ when input.TrimEnd() |> Seq.last = '?' ->
            let question = input.TrimEnd('?') 
            match question with
            | _ when not (question |> Seq.exists System.Char.IsLetter) -> "Sure."
            | _ when isAllCaps question -> "Calm down, I know what I'm doing!"
            | _ -> "Sure."
    | _ when input 
        |> Seq.filter System.Char.IsLetterOrDigit 
        |> Seq.forall System.Char.IsDigit 
        -> "Whatever."
    | _ when isAllCaps input -> "Whoa, chill out!"
    | _ -> "Whatever."