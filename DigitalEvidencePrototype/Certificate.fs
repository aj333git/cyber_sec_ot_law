module Certificate

open System
open System.IO
open Models

let generate (caseInfo : Case) (evidence : Evidence) =

    let outputFile = "BSA_Section63_Certificate.txt"

    let lines =
        [
            "==========================================="
            "BSA SECTION 63 CERTIFICATE"
            "==========================================="
            ""

            "Case Number"
            caseInfo.CaseNumber
            ""

            "Case Name"
            caseInfo.CaseName
            ""

            "Investigator"
            caseInfo.Investigator
            ""

            "Evidence File"
            evidence.FileName
            ""

            "SHA-256"
            evidence.SHA256
            ""

            "Imported On"
            evidence.ImportedOn.ToString()
            ""

            "Generated On"
            DateTime.Now.ToString()
        ]

    File.WriteAllLines(outputFile, lines)

    outputFile
