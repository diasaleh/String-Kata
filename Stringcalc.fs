open System

let splitString (t : string) (delimiter) = 
    let arr = t.Split delimiter
    arr
let convertSringsListToIntsList (sList:string [])=
    let len = Array.length sList
    let intArr = Array.create len 0
    for i = 0 to len - 1 do
        intArr.[i] <- sList.[i] |> int
    intArr
let explode (s:string) =
    [for c in s -> c]|> List.toArray 
let Add (s : string) = 
    let st = s.Trim()
    if not (st.Equals("")) then
        let del = explode "\n |, "

        let nums = splitString st del
        for i in nums do
            printfn "%A" i
        let sum =  Array.sum (convertSringsListToIntsList nums)
        
        printfn "%A" sum 
    else
        printfn "%s" "0"
    
Add " 1\n2,8"