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
let containsNegNum intArr = 
    let sum = intArr |> Array.toList|> List.filter(fun n -> n < 0) |> List.sum
    sum 
let sumArrayIgnoreNumsBiggerThan1000 intArr = 
    let sum = intArr |> Array.toList|> List.filter(fun n -> n <= 1000) |> List.sum
    sum   
let setDelimiter (s:string) = 
    if s.[..1].Equals("//") then
        let del = explode s.[2..].[..0]
        let str = s.[4..]
        del, str
    else
        let del = explode "\n |, "
        del, s
let Add (s : string) = 
    let st = s.Trim()
    if not (st.Equals("")) then
        let del, str= setDelimiter st
        let nums = splitString str del
        let intAr = convertSringsListToIntsList nums
        if containsNegNum intAr = 0 then
            let sum =  sumArrayIgnoreNumsBiggerThan1000 intAr
            printfn "%A" sum 
        else
            printfn "negatives not allowed"
        for i in nums do
            printfn "%A" i
    else
        printfn "%s" "0"
Add "//;\n2;1001;4;5"