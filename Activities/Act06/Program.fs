﻿/// KAIST CS220 In-Class Activity Project

let car lst =
  match lst with
  | hd :: _ -> hd
  | _ -> failwith "Empty list is given."

let cdr lst =
  match lst with
  | _ :: tl -> tl
  | _ -> failwith "Empty list is given."

/// Modify this function to return the last element of the given list.
let rec last lst =
  match lst with
  | [] -> failwith "no last element"
  | [x] -> x
  | _ :: tail -> last tail

/// Modify this function to return the last but one element of the given list.
let rec lastButOne lst =
  match lst with
  | [] | [_] -> failwith "fewer than two elements"
  | [x; _] -> x
  | _ :: tail -> lastButOne tail

printfn "last element: %d" <| last [ 1; 2; 3; 4; 5 ]
printfn "last element: %d" <| last [ "a"; "bcd"; "efg" ]
printfn "last but one element: %d" <| last [ 1; 2; 3; 4; 5 ]
printfn "last but one element: %d" <| last [ 1.1; 2.2 ]
