let xRef = ref 1
let yRef = ref 2
let zRef = ref 3

let swap (x:int ref) (y:int ref) =
    let temp = !x
    x := !y
    y := temp

swap xRef yRef
printf "%d %d %d" (!xRef) (!yRef) (!zRef)