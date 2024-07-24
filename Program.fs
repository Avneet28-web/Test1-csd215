// For more information see https://aka.ms/fsharp-console-apps
let salaries = [75000; 48000; 120000; 190000; 300113; 92000; 36000]

let displaySalaries salaries =
    salaries |> List.iter (printfn "Salary: $%d")

displaySalaries salaries

