// For more information see https://aka.ms/fsharp-console-apps
let sumMultiplesOf3 n =
    
    let rec sumAcc multiple accumulator =
        if multiple > n then
            accumulator
        else
            sumAcc (multiple + 3) (accumulator + multiple)
    
    sumAcc 3 0

let result = sumMultiplesOf3 27
printfn "The sum of all multiples of 3 up to 27 is: %d" result
