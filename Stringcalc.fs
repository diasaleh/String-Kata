open System
let splitString (t : string) (delimiter: string[]) = 
    t.Split (delimiter, System.StringSplitOptions.None)
let stringToCharArr (s:string) =
    [for c in s -> c]|> List.toArray 
let containsNegativesNums intArr = 
    intArr |> Array.toList|> List.filter(fun n -> n < 0) |> List.sum 
let sumArrayIgnoreNumsBiggerThan1000 intArr = 
    intArr |> Array.toList|> List.filter(fun n -> n <= 1000) |> List.sum 
let removeEmptyStringsFromArr arr=
    Array.choose (fun elem -> if not (elem.Equals("")) then Some(elem) else None) arr
let convertSringsListToIntsList (sList:string [])=
    let len = Array.length sList
    let intArr = Array.create len 0
    for i = 0 to len - 1 do
        intArr.[i] <- sList.[i] |> int
    intArr  
let getFirstNumIndex (s : string)= 
    let mutable flag = true
    let mutable index = 0
    for i in 0 .. s.Length - 1 do
        if Char.IsNumber s.[i] then 
            if flag = true then
                flag <- false
                index <- i
    index
let getNumsString (s:string) = 
    if s.[..1].Equals("//") then
        let delA = [|"["; "]"|]
        let delString = (splitString s delA)
        let delArr = removeEmptyStringsFromArr (delString.[1.. delString.Length-2])
        printfn "\ndelArr = %A \n" delArr 
        let numsString=(splitString s.[(getFirstNumIndex s)..] delArr)
        numsString
    else
        let delArr = [|"\n"; ","|]
        let numsString=(splitString s delArr)
        numsString
let Add (s : string) = 
    let st = s.Trim()
    if not (st.Equals("")) then
        let numsString= getNumsString st
        printfn "\nSum = %A \n" numsString 
        let intAr = convertSringsListToIntsList numsString
        if containsNegativesNums intAr = 0 then
            let sum =  sumArrayIgnoreNumsBiggerThan1000 intAr
            printfn "\nSum = %A \n" sum 
        else
            printfn "\nnegatives not allowed\n"
    else
        printfn "%s" "0"
Add "//[*][%%][\n\n\n]\n1*2%%3\n\n\n5*33"