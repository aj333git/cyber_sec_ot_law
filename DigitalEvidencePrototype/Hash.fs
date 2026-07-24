module Hash

open System.IO
open System.Security.Cryptography

let computeSHA256 (filePath : string) =

    use sha = SHA256.Create()
    use stream = File.OpenRead(filePath)

    let hashBytes = sha.ComputeHash(stream)

    hashBytes
    |> Array.map (fun b -> b.ToString("x2"))
    |> String.concat ""
