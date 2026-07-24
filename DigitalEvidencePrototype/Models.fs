module Models

open System

type Case =
    {
        CaseNumber : string
        CaseName : string
        Investigator : string
    }

type Evidence =
    {
        FilePath : string
        FileName : string
        SHA256 : string
        ImportedOn : DateTime
    }
