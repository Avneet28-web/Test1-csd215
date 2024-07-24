// For more information see https://aka.ms/fsharp-console-apps
let salaries = [75000; 48000; 120000; 190000; 300113; 92000; 36000]

let displaySalaries salaries =
    salaries |> List.iter (fun salary -> printfn "Salary: $%d" salary)

let highIncomeSalaries = salaries |> List.filter (fun salary -> salary > 100000)

printfn "High-Income Salaries:"
displaySalaries highIncomeSalaries

