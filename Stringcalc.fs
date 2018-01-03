open System

let splitString (t : string) = 
    let arr = t.Split ','
    arr
let convertSringsListToIntsList (sList:string [])=
    let len = Array.length sList
    let intArr = Array.create len 0
    for i = 0 to len - 1 do
        intArr.[i] <- sList.[i] |> int
    intArr
let Add (s : string) = 
    let st = (s.Trim())
    if not (st.Equals("")) then
        let nums = splitString st
        for i in nums do
            printfn "%A" i
        let sum =  Array.sum (convertSringsListToIntsList nums)
        
        printfn "%A" sum 
    else
        printfn "%s" "0"
    
Add "   9, 10 "