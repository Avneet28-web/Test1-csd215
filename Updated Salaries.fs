// For more information see https://aka.ms/fsharp-console-apps
let salaries = [75000; 48000; 120000; 190000; 300113; 92000; 36000]

let updateSalaries salary =
    if salary < 49020 then salary + 20000
    else salary

let updatedSalaries = salaries |> List.map updateSalaries

let displaySalaries salaries =
    salaries |> List.iter (fun salary -> printfn "Salary: $%d" salary)

printfn "Updated Salaries:"
displaySalaries updatedSalaries
