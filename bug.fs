let mutable x = 1
let mutable y = 2
let mutable z = 3

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d %d" x y z