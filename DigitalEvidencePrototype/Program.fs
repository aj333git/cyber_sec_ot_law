open System
open System.IO

open Models
open Hash
open Certificate

[<EntryPoint>]
let main argv =

    printfn ""
    printfn "======================================="
    printfn "Digital Evidence Prototype v0.1"
    printfn "======================================="
    printfn ""

    printf "Case Number : "
    let caseNumber = Console.ReadLine()

    printf "Case Name : "
    let caseName = Console.ReadLine()

    printf "Investigator : "
    let investigator = Console.ReadLine()

    printf ""
    printf "Evidence File Path : "

    let filePath = Console.ReadLine()

    if not (File.Exists(filePath)) then

        printfn ""
        printfn "File not found."

        0

    else

        let hash = computeSHA256 filePath

        let evidence =
            {
                FilePath = filePath
                FileName = Path.GetFileName(filePath)
                SHA256 = hash
                ImportedOn = DateTime.Now
            }

        let caseInfo =
            {
                CaseNumber = caseNumber
                CaseName = caseName
                Investigator = investigator
            }

        printfn ""
        printfn "SHA256"
        printfn "%s" hash

        let certificate = generate caseInfo evidence

        printfn ""
        printfn "Certificate Generated"

        printfn "%s" certificate

        0
