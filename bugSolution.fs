let rec loop x y =
    match x with
    | x when x < 10 -> loop (x + 1) (y + 2)
    | _ -> printfn "%d %d" x y

loop 0 0