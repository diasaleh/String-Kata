open System

let splitString (t : string) = 
    let arr = t.Split ','
    arr

let Add (s : string) = 
    let st = (s.Trim())
    if not (st.Equals("")) then
        let nums = splitString st
        printfn "%A" nums 
    else
        printfn "%s" "0"
    
Add "   9,9 "