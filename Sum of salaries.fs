// For more information see https://aka.ms/fsharp-console-apps
let salaries = [75000; 48000; 120000; 190000; 300113; 92000; 36000]

let filterSalaries salary =
    salary >= 50000 && salary <= 100000

let filteredSalaries = salaries |> List.filter filterSalaries

let sumSalaries = filteredSalaries |> List.fold (fun acc salary -> acc + salary) 0

printfn "Sum of salaries between $50,000 and $100,000: $%d" sumSalaries
